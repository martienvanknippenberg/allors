// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PersonTests.cs" company="Allors bvba">
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
//   Defines the PersonTests type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Allors.Domain
{
    using Allors;
    using NUnit.Framework;

    [TestFixture]
    public class PersonTests : DomainTest
    {
        [Test]
        public void GivenPersonWhenDerivingThenDisplayNameIsSet()
        {
            var builder = new PersonBuilder(this.DatabaseSession).WithLastName("Knippenberg");

            var person = builder.Build();

            this.DatabaseSession.Derive(true);

            Assert.AreEqual("Knippenberg", person.DisplayName);

            builder.WithMiddleName("van");
            person = builder.Build();

            this.DatabaseSession.Derive(true);

            Assert.AreEqual("van Knippenberg", person.DisplayName);

            builder.WithFirstName("Martien");
            person = builder.Build();

            this.DatabaseSession.Derive(true);

            Assert.AreEqual("Martien van Knippenberg", person.DisplayName);
        }
    }
}
