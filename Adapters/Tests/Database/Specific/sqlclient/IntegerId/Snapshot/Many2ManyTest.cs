// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Many2ManyTest.cs" company="Allors bvba">
//   Copyright 2002-2010 Allors bvba.
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
// <summary>
//   Defines the Default type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Allors.Database.Special.SqlClient.IntegerId.Snapshot
{
    using Allors;

    using NUnit.Framework;

    [TestFixture]
    public class Many2ManyTest : Special.Many2ManyTest
    {
        private readonly Profile profile = new Profile();

        protected override ISession Session
        {
            get { return this.profile.Session; }
        }

        [SetUp]
        protected void Init()
        {
            this.profile.Init();
        }

        [TearDown]
        protected void Dispose()
        {
            this.profile.Dispose();
        }
    }
}