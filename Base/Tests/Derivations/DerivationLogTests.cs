// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DerivationLogTests.cs" company="Allors bvba">
//   Copyright 2002-2009 Allors bvba.
// 
// Dual Licensed under
//   a) the General Public Licence v3 (GPL)
//   b) the Allors License
// 
// The GPL License is included in the file gpl.txt.
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
//   Defines the ApplicationTests type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Allors.Common
{
    using System;

    using global::Allors.Domain;

    using NUnit.Framework;

    [TestFixture]
    public class DerivationLogTests : DomainTest
    {
        [Test]
        public void AssertIsUniqueTest()
        {
            var c1 = new DerivationLogC1Builder(this.DatabaseSession).Build();
            var c2 = new DerivationLogC2Builder(this.DatabaseSession).Build();

            Assert.IsFalse(this.DatabaseSession.Derive().HasErrors);

            c1.UniqueId = Guid.NewGuid();

            Assert.IsFalse(this.DatabaseSession.Derive().HasErrors);

            c2.UniqueId = c1.UniqueId;

            Assert.IsTrue(this.DatabaseSession.Derive().HasErrors);
        }
   }
}
