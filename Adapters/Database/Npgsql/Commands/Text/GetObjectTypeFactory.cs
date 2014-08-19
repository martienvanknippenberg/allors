// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetObjectTypeFactory.cs" company="Allors bvba">
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

namespace Allors.R1.Adapters.Database.Npgsql.Commands.Text
{
    using System;

    using Allors.R1.Adapters.Database.Sql.Commands;
    using Allors.R1.Meta;

    using global::Npgsql;

    using Database = Database;
    using DatabaseSession = Allors.R1.Adapters.Database.Npgsql.DatabaseSession;

    public class GetObjectTypeFactory : IGetObjectTypeFactory
    {
        public readonly Database Database;
        public readonly string Sql;

        public GetObjectTypeFactory(Database database)
        {
            this.Database = database;
            this.Sql = "SELECT " + database.Schema.TypeId + "\n";
            this.Sql += "FROM " + database.Schema.Objects + "\n";
            this.Sql += "WHERE " + database.Schema.ObjectId + "=" + database.Schema.ObjectId.Param.InvocationName + "\n";
        }

        public IGetObjectType Create(Sql.DatabaseSession session)
        {
            return new GetObjectType(this, session);
        }

        private class GetObjectType : DatabaseCommand, IGetObjectType
        {
            private readonly GetObjectTypeFactory factory;
            private NpgsqlCommand command;

            public GetObjectType(GetObjectTypeFactory factory, Sql.DatabaseSession session)
                : base((DatabaseSession)session)
            {
                this.factory = factory;
            }

            public ObjectType Execute(ObjectId objectId)
            {
                if (this.command == null)
                {
                    this.command = this.Session.CreateNpgsqlCommand(this.factory.Sql);
                    this.AddInObject(this.command, this.Database.Schema.ObjectId.Param, objectId.Value);
                }
                else
                {
                    this.SetInObject(this.command, this.Database.Schema.ObjectId.Param, objectId.Value);
                }

                var result = this.command.ExecuteScalar();
                if (result == null)
                {
                    return null;
                }

                return this.Session.NpgsqlDatabase.ObjectFactory.GetObjectTypeForType((Guid)result);
            }
        }
    }
}