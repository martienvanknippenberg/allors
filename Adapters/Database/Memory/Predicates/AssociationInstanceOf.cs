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
        private readonly MetaAssociation associationType;
        private readonly MetaObject objectType;

        internal AssociationInstanceOf(ExtentFiltered extent, MetaAssociation associationType, MetaObject instanceObjectType)
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
            MetaObject associationObjectType = association.Strategy.ObjectType;
            return associationObjectType.Equals(this.objectType) || Array.IndexOf(associationObjectType.Supertypes, this.objectType) >= 0
                       ? ThreeValuedLogic.True
                       : ThreeValuedLogic.False;
        }
    }
}