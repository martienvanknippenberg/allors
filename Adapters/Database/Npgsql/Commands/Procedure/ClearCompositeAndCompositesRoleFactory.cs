// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClearCompositeAndCompositesRoleFactory.cs" company="Allors bvba">
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

namespace Allors.Adapters.Database.Npgsql.Commands.Procedure
{
    using System.Collections.Generic;
    using System.Data;

    using Allors.Adapters.Database.Sql.Commands;
    using Allors.Meta;

    using global::Npgsql;

    using Database = Database;
    using DatabaseSession = DatabaseSession;

    public class ClearCompositeAndCompositesRoleFactory : IClearCompositeAndCompositesRoleFactory
    {
        public readonly Database Database;
        private readonly Dictionary<RoleType, string> sqlByRoleType;

        public ClearCompositeAndCompositesRoleFactory(Database database)
        {
            this.Database = database;
            this.sqlByRoleType = new Dictionary<RoleType, string>();
        }

        public IClearCompositeAndCompositesRole Create(Sql.DatabaseSession session)
        {
            return new ClearCompositeAndCompositesRole(this, session);
        }

        public string GetSql(RoleType roleType)
        {
            if (!this.sqlByRoleType.ContainsKey(roleType))
            {
                var associationType = roleType.AssociationType;

                string sql;
                if ((roleType.IsMany && associationType.IsMany) || !roleType.RelationType.ExistExclusiveRootClasses)
                {
                    sql = Sql.Schema.AllorsPrefix + "C_" + roleType.FullSingularName;
                }
                else
                {
                    if (roleType.IsOne)
                    {
                        sql = Sql.Schema.AllorsPrefix + "C_" + associationType.ObjectType.ExclusiveRootClass.Name + "_" + roleType.RootName;
                    }
                    else
                    {
                        var compositeType = (Composite)roleType.ObjectType;
                        sql = Sql.Schema.AllorsPrefix + "C_" + compositeType.ExclusiveRootClass.Name + "_" + associationType.Name;
                    }
                }

                this.sqlByRoleType[roleType] = sql;
            }

            return this.sqlByRoleType[roleType];
        }

        private class ClearCompositeAndCompositesRole : DatabaseCommand, IClearCompositeAndCompositesRole
        {
            private readonly ClearCompositeAndCompositesRoleFactory factory;
            private readonly Dictionary<RoleType, NpgsqlCommand> commandByRoleType;

            public ClearCompositeAndCompositesRole(ClearCompositeAndCompositesRoleFactory factory, Sql.DatabaseSession session)
                : base((DatabaseSession)session)
            {
                this.factory = factory;
                this.commandByRoleType = new Dictionary<RoleType, NpgsqlCommand>();
            }

            public void Execute(IList<ObjectId> associations, RoleType roleType)
            {
                var schema = this.factory.Database.NpgsqlSchema;

                NpgsqlCommand command;
                if (!this.commandByRoleType.TryGetValue(roleType, out command))
                {
                    command = this.Session.CreateNpgsqlCommand(this.factory.GetSql(roleType));
                    command.CommandType = CommandType.StoredProcedure;
                    this.AddInTable(command, schema.ObjectArrayParam, this.Database.CreateObjectTable(associations));

                    this.commandByRoleType[roleType] = command;
                }
                else
                {
                    this.SetInTable(command, schema.ObjectArrayParam, this.Database.CreateObjectTable(associations));
                }

                command.ExecuteNonQuery();
            }
        }
    }
}