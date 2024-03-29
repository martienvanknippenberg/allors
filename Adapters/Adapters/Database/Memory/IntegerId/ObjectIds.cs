﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ObjectIds.cs" company="Allors bvba">
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

namespace Allors.Adapters.Database.Memory.IntegerId
{
    internal sealed class ObjectIds : Memory.ObjectIds
    {
        private int currentId;

        internal ObjectIds()
        {
            currentId = 0;
        }

        internal override void AdjustCurrentId(ObjectId id)
        {
            ObjectIdInteger idInteger = (ObjectIdInteger) id;
            if (idInteger.ValueInteger > currentId)
            {
                currentId = idInteger.ValueInteger;
            }
        }

        internal override ObjectId Next()
        {
            return new ObjectIdInteger(++currentId);
        }

        internal override ObjectId Parse(string idString)
        {
            return new ObjectIdInteger(idString);
        }

        internal override void Reset()
        {
            currentId = 0;
        }
    }
}