﻿//-------------------------------------------------------------------------------------------------
// <copyright file="UserGroup.v.cs" company="Allors bvba">
// Copyright 2002-2010 Allors bvba.
//
// Dual Licensed under
//   a) the General Public Licence v3 (GPL)
//   b) the Allors License
//
// The GPL License is included in the file gpl.txt.
// The Allors License is an addendum to your contract.
//
// Allors Applications is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// For more information visit http://www.allors.com/legal
// </copyright>
// <summary>Defines the UserGroup type.</summary>
//-------------------------------------------------------------------------------------------------

namespace Allors.Domain
{
    public partial class UserGroup
    {
        public void DeriveDisplayName()
        {
            this.BaseDeriveDisplayName();
        }
    }
}