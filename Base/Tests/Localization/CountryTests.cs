// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CountryTests.cs" company="Allors bvba">
//   Copyright 2002-2013 Allors bvba.
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
// --------------------------------------------------------------------------------------------------------------------

namespace Allors.Domain
{
    using NUnit.Framework;

    [TestFixture]
    public class CountryTests : DomainTest
    {
        [Test]
        public void GivenCountryWhenValidatingThenRequiredRelationsMustExist()
        {
            var builder = new CountryBuilder(this.DatabaseSession);
            builder.Build();
            
            Assert.IsTrue(this.DatabaseSession.Derive().HasErrors);

            builder.WithIsoCode("XX").Build();
            builder.Build();

            Assert.IsTrue(this.DatabaseSession.Derive().HasErrors);

            this.DatabaseSession.Rollback();

            builder.WithName("X Country");

            builder.Build();

            Assert.IsFalse(this.DatabaseSession.Derive().HasErrors);

            this.DatabaseSession.Rollback();

            builder = new CountryBuilder(this.DatabaseSession);
            builder.WithName("X Country");

            builder.Build();

            Assert.IsTrue(this.DatabaseSession.Derive().HasErrors);
        }

        [Test]
        public void GivenCountryWhenValidatingThenDisplayNameIsSet()
        {
            var country = new Countries(this.DatabaseSession).FindBy(Countries.Meta.IsoCode, "BE");

            this.DatabaseSession.Derive(true);

            Assert.AreEqual("Belgium", country.DisplayName);
        }
    }
}