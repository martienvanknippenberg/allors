// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Many2OneTest.cs" company="Allors bvba">
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

namespace Allors.Adapters.Special.SqlClient.LongId.ReadCommitted
{
    using System;

    using Allors;

    using NUnit.Framework;

    [TestFixture]
    public class Many2OneTest : Special.Many2OneTest
    {
        private readonly Profile profile = new Profile();

        protected override IProfile Profile
        {
            get
            {
                return this.profile;
            }
        }

        [TearDown]
        protected void Dispose()
        {
            this.profile.Dispose();
        }
    }
}