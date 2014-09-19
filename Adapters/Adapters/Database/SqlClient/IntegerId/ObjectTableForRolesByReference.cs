// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ObjectTableForRolesByReference.cs" company="Allors bvba">
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

namespace Allors.Adapters.Database.SqlClient.IntegerId
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;

    using Allors.Adapters.Database.Sql;

    using Microsoft.SqlServer.Server;

    public class ObjectTableForRolesByReference : IEnumerable<SqlDataRecord>
    {
        private readonly Schema schema;
        private readonly Dictionary<Reference, Roles> rolesByReference;

        public ObjectTableForRolesByReference(Schema schema, Dictionary<Reference, Roles> rolesByReference)
        {
            this.schema = schema;
            this.rolesByReference = rolesByReference;
        }

        public IEnumerator<SqlDataRecord> GetEnumerator()
        {
            var objectArrayElement = this.schema.ObjectTableObject;
            var metaData = new SqlMetaData(objectArrayElement, SqlDbType.Int);
            var sqlDataRecord = new SqlDataRecord(metaData);
            foreach (var dictionaryEntry in this.rolesByReference)
            {
                var strategy = dictionaryEntry.Key;
                sqlDataRecord.SetInt32(0, (int)strategy.ObjectId.Value);
                yield return sqlDataRecord;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}