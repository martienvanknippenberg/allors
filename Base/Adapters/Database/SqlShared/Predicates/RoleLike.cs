// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RoleLike.cs" company="Allors bvba">
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

    public sealed class RoleLike : Predicate
    {
        private readonly RoleType role;
        private readonly string like;

        public RoleLike(ExtentFiltered extent, RoleType role, string like)
        {
            extent.CheckRole(role);
            CompositePredicateAssertions.ValidateRoleLikeFilter(role, like);
            this.role = role;
            this.like = like;
        }

        public override bool BuildWhere(ExtentStatement statement, string alias)
        {
            var schema = statement.Schema;
            statement.Append(" " + alias + "." + schema.Column(this.role) + " LIKE " + statement.AddParameter(this.like));
            return this.Include;
        }

        public override void Setup(ExtentStatement statement)
        {
            statement.UseRole(this.role);
        }
    }
}