// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AssociationContainedInExtent.cs" company="Allors bvba">
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
    using Meta;

    public sealed class AssociationContainedInExtent : In
    {
        private readonly IAssociationType association;
        private readonly SqlExtent inExtent;

        public AssociationContainedInExtent(ExtentFiltered extent, IAssociationType association, Allors.Extent inExtent)
        {
            extent.CheckAssociation(association);
            CompositePredicateAssertions.AssertAssociationContainedIn(association, inExtent);
            this.association = association;
            this.inExtent = ((Extent)inExtent).ContainedInExtent;
        }

        public override bool BuildWhere(ExtentStatement statement, string alias)
        {
            var schema = statement.Schema;
            var inStatement = statement.CreateChild(this.inExtent, this.association);

            inStatement.UseRole(this.association.RoleType);

            if ((this.association.IsMany && this.association.RelationType.RoleType.IsMany) || !this.association.RelationType.ExistExclusiveLeafClasses)
            {
                statement.Append(" (" + this.association.SingularName + "_A." + schema.RoleId + " IS NOT NULL AND ");
                statement.Append(" " + this.association.SingularName + "_A." + schema.RoleId + " IN (\n");
                this.inExtent.BuildSql(inStatement);
                statement.Append(" ))\n");
            }
            else
            {
                if (this.association.RelationType.RoleType.IsMany)
                {
                    statement.Append(" (" + alias + "." + schema.Column(this.association) + " IS NOT NULL AND ");
                    statement.Append(" " + alias + "." + schema.Column(this.association) + " IN (\n");
                    this.inExtent.BuildSql(inStatement);
                    statement.Append(" ))\n");
                }
                else
                {
                    statement.Append(" (" + this.association.SingularName + "_A." + schema.ObjectId + " IS NOT NULL AND ");
                    statement.Append(" " + this.association.SingularName + "_A." + schema.ObjectId + " IN (\n");
                    this.inExtent.BuildSql(inStatement);
                    statement.Append(" ))\n");
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