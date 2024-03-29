// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetCompositeAssociationFactory.cs" company="Allors bvba">
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
    using System;
    using System.Collections.Generic;
    using System.Data;

    using Allors.Adapters.Database.Sql;
    using Allors.Adapters.Database.Sql.Commands;
    using Allors.Meta;

    using global::Npgsql;

    using Database = Database;
    using DatabaseSession = DatabaseSession;

    public class GetCompositeAssociationFactory : IGetCompositeAssociationFactory
    {
        public readonly Database Database;
        private readonly Dictionary<IAssociationType, string> sqlByAssociationType;

        public GetCompositeAssociationFactory(Database database)
        {
            this.Database = database;
            this.sqlByAssociationType = new Dictionary<IAssociationType, string>();
        }

        public IGetCompositeAssociation Create(Sql.DatabaseSession session)
        {
            return new GetCompositeAssociation(this, session);
        }

        public string GetSql(IAssociationType associationType)
        {
            if (!this.sqlByAssociationType.ContainsKey(associationType))
            {
                var roleType = associationType.RoleType;

                string sql;
                if (associationType.RelationType.ExistExclusiveLeafClasses)
                {
                    if (roleType.IsOne)
                    {
                        sql = Schema.AllorsPrefix + "GA_" + associationType.ObjectType.ExclusiveLeafClass.Name + "_" + associationType.SingularName;
                    }
                    else
                    {
                        var compositeType = (IComposite)roleType.ObjectType;
                        sql = Schema.AllorsPrefix + "GA_" + compositeType.ExclusiveLeafClass.Name + "_" + associationType.SingularName;
                    }
                }
                else
                {
                    sql = Schema.AllorsPrefix + "GA_" + roleType.SingularFullName;
                }

                this.sqlByAssociationType[associationType] = sql;
            }

            return this.sqlByAssociationType[associationType];
        }

        private class GetCompositeAssociation : DatabaseCommand, IGetCompositeAssociation
        {
            private readonly GetCompositeAssociationFactory factory;
            private readonly Dictionary<IAssociationType, NpgsqlCommand> commandByAssociationType;

            public GetCompositeAssociation(GetCompositeAssociationFactory factory, Sql.DatabaseSession session)
                : base((DatabaseSession)session)
            {
                this.factory = factory;
                this.commandByAssociationType = new Dictionary<IAssociationType, NpgsqlCommand>();
            }

            public Reference Execute(Reference role, IAssociationType associationType)
            {
                Reference associationObject = null;

                NpgsqlCommand command;
                if (!this.commandByAssociationType.TryGetValue(associationType, out command))
                {
                    command = this.Session.CreateNpgsqlCommand(this.factory.GetSql(associationType));
                    command.CommandType = CommandType.StoredProcedure;
                    this.AddInObject(command, this.Database.Schema.RoleId.Param, role.ObjectId.Value);

                    this.commandByAssociationType[associationType] = command;
                }
                else
                {
                    this.SetInObject(command, this.Database.Schema.RoleId.Param, role.ObjectId.Value);
                }

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    ObjectId id = this.Database.AllorsObjectIds.Parse(result.ToString());

                    if (associationType.ObjectType.ExistExclusiveLeafClass)
                    {
                        associationObject = this.Session.GetOrCreateAssociationForExistingObject(associationType.ObjectType.ExclusiveLeafClass.ExclusiveLeafClass, id);
                    }
                    else
                    {
                        associationObject = this.Session.GetOrCreateAssociationForExistingObject(id);
                    }
                }

                return associationObject;
            }
        }
    }
}