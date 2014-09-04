//------------------------------------------------------------------------------------------------- 
// <copyright file="Unit.cs" company="Allors bvba">
// Copyright 2002-2013 Allors bvba.
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
// <summary>Defines the ObjectType type.</summary>
//-------------------------------------------------------------------------------------------------

namespace Allors.Meta
{
    using System;

    public partial class Unit : ObjectType
    {
        private UnitTags unitTag;

        public Unit(Domain domain, Guid id) : base(domain, id)
        {
            domain.OnUnitCreated(this);
        }

        public UnitTags UnitTag
        {
            get
            {
                return this.unitTag;
            }

            set
            {
                this.Environment.AssertUnlocked();
                this.unitTag = value;
                this.Environment.Stale();
            }
        }
    }
}