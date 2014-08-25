// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetCompositeRolesFactory.cs" company="Allors bvba">
//   Copyright 2002-2012 Allors bvba.
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

namespace Allors.Adapters.Database.Npgsql.Commands.Text
{
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;

    using Allors.Adapters.Database.Sql;
    using Allors.Adapters.Database.Sql.Commands;
    using Allors.Meta;

    using global::Npgsql;

    using Database = Database;
    using DatabaseSession = DatabaseSession;

    public class GetCompositeRolesFactory : IGetCompositeRolesFactory
    {
        public readonly Database Database;
        private readonly Dictionary<MetaRole, string> sqlByRoleType;

        public GetCompositeRolesFactory(Database database)
        {
            this.Database = database;
            this.sqlByRoleType = new Dictionary<MetaRole, string>();
        }

        public IGetCompositeRoles Create(Sql.DatabaseSession session)
        {
            return new GetCompositeRoles(this, session);
        }

        public string GetSql(MetaRole roleType)
        {
            if (!this.sqlByRoleType.ContainsKey(roleType))
            {
                var associationType = roleType.AssociationType;

                string sql;
                if (associationType.IsMany || !roleType.RelationType.ExistExclusiveRootClasses)
                {
                    sql = Schema.AllorsPrefix + "GR_" + roleType.FullSingularName;
                }
                else
                {
                    sql = Schema.AllorsPrefix + "GR_" + roleType.ObjectType.ExclusiveRootClass.Name + "_" + associationType.Name;
                }
 
                this.sqlByRoleType[roleType] = sql;
            }

            return this.sqlByRoleType[roleType];
        }

        private class GetCompositeRoles : DatabaseCommand, IGetCompositeRoles
        {
            private readonly GetCompositeRolesFactory factory;
            private readonly Dictionary<MetaRole, NpgsqlCommand> commandByRoleType;

            public GetCompositeRoles(GetCompositeRolesFactory factory, Sql.DatabaseSession session)
                : base((DatabaseSession)session)
            {
                this.factory = factory;
                this.commandByRoleType = new Dictionary<MetaRole, NpgsqlCommand>();
            }

            public void Execute(Roles roles, MetaRole roleType)
            {
                var reference = roles.Reference;

                NpgsqlCommand command;
                if (!this.commandByRoleType.TryGetValue(roleType, out command))
                {
                    command = this.Session.CreateNpgsqlCommand(this.factory.GetSql(roleType));
                    command.CommandType = CommandType.StoredProcedure;
                    this.AddInObject(command, this.Database.Schema.AssociationId.Param, reference.ObjectId.Value);

                    this.commandByRoleType[roleType] = command;
                }
                else
                {
                    this.SetInObject(command, this.Database.Schema.AssociationId.Param, reference.ObjectId.Value);
                }

                var objectIds = new List<ObjectId>();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var idString = reader[0].ToString();
                        var id = this.Database.AllorsObjectIds.Parse(idString);
                        objectIds.Add(id);
                    }
                }

                roles.CachedObject.SetValue(roleType, objectIds.ToArray());
            }
        }
    }
}