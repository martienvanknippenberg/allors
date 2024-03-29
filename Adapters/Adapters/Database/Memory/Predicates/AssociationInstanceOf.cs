// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AssociationInstanceOf.cs" company="Allors bvba">
//   Copyright 2002-2013 Allors bvba.
// 
// Dual Licensed under
//   a) the Lesser General Public Licence v3 (LGPL)
//   b) the Allors License
// 
// The LGPL License is included in the file lgpl.txt.
// The Allors License is an addendum to your contract.
// 
// Allors Platform is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// For more information visit http://www.allors.com/legal
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Allors.Adapters.Database.Memory
{
    using System;
    using Allors.Meta;

    internal sealed class AssociationInstanceOf : Predicate
    {
        private readonly IAssociationType associationType;
        private readonly IObjectType objectType;

        internal AssociationInstanceOf(ExtentFiltered extent, IAssociationType associationType, IObjectType instanceObjectType)
        {
            extent.CheckForAssociationType(associationType);
            CompositePredicateAssertions.ValidateAssociationInstanceof(associationType, instanceObjectType);

            this.associationType = associationType;
            this.objectType = instanceObjectType;
        }

        internal override ThreeValuedLogic Evaluate(Strategy strategy)
        {
            var association = strategy.GetCompositeAssociation(this.associationType);

            if (association == null)
            {
                return ThreeValuedLogic.False;
            }

            // TODO: Optimize
            var associationObjectType = association.Strategy.ObjectType;
            if (associationObjectType.Equals(this.objectType))
            {
                return ThreeValuedLogic.True;
            }

            var @interface = this.objectType as IInterface;
            return (@interface != null && associationObjectType.ContainsSupertype(@interface))
                       ? ThreeValuedLogic.True
                       : ThreeValuedLogic.False;
        }
    }
}