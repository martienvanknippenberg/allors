// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AssociationEquals.cs" company="Allors bvba">
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

namespace Allors.Adapters.Database.Sql
{
    using Allors.Meta;

    public sealed class AssociationEquals : Predicate
    {
        private readonly IObject allorsObject;
        private readonly MetaAssociation association;

        public AssociationEquals(ExtentFiltered extent, MetaAssociation association, IObject allorsObject)
        {
            extent.CheckAssociation(association);
            CompositePredicateAssertions.AssertAssociationEquals(association, allorsObject);
            this.association = association;
            this.allorsObject = allorsObject;
        }

        public override bool BuildWhere(ExtentStatement statement, string alias)
        {
            var schema = statement.Schema;
            if ((this.association.IsMany && this.association.RelationTypeWhereAssociationType.RoleType.IsMany) || !this.association.RelationTypeWhereAssociationType.ExistExclusiveRootClasses)
            {
                statement.Append(" (" + this.association.RootName + "_A." + schema.AssociationId + " IS NOT NULL AND ");
                statement.Append(" " + this.association.RootName + "_A." + schema.AssociationId + "=" + this.allorsObject.Strategy.ObjectId + ")");
            }
            else
            {
                if (this.association.RelationTypeWhereAssociationType.RoleType.IsMany)
                {
                    statement.Append(" (" + alias + "." + schema.Column(this.association) + " IS NOT NULL AND ");
                    statement.Append(" " + alias + "." + schema.Column(this.association) + "=" + this.allorsObject.Strategy.ObjectId + ")");
                }
                else
                {
                    statement.Append(" (" + this.association.RootName + "_A." + schema.ObjectId + " IS NOT NULL AND ");
                    statement.Append(" " + this.association.RootName + "_A." + schema.ObjectId + " =" + this.allorsObject.Strategy.ObjectId + ")");
                }
            }

            return this.Include;
        }

        public override void Setup(ExtentStatement statement)
        {
            statement.UseAssociation(this.association);
        }
    }
}