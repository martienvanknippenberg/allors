//------------------------------------------------------------------------------------------------- 
// <copyright file="OrderTermTests.cs" company="Allors bvba">
// Copyright 2002-2009 Allors bvba.
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
// <summary>Defines the MediaTests type.</summary>
//-------------------------------------------------------------------------------------------------

namespace Allors.Domain
{
    

    using NUnit.Framework;
    using Allors.Domain;

    [TestFixture]
    public class OrderTermTests : DomainTest
    {
        [Test]
        public void GivenOrderTerm_WhenDeriving_ThenDescriptionIsRequired()
        {
            var builder = new OrderTermBuilder(this.DatabaseSession);
            var orderTerm = builder.Build();

            Assert.IsTrue(this.DatabaseSession.Derive().HasErrors);

            this.DatabaseSession.Rollback();

            builder.WithTermType(new TermTypes(this.DatabaseSession).PercentageCancellationCharge);
            orderTerm = builder.Build();

            Assert.IsFalse(this.DatabaseSession.Derive().HasErrors);
        }

        [Test]
        public void GivenOrderTerm_WhenDeriving_ThenDisplayNameIsSet()
        {
            var orderTerm = new OrderTermBuilder(this.DatabaseSession)
                .WithTermType(new TermTypes(this.DatabaseSession).PercentageCancellationCharge)
                .WithTermValue("10")
                .Build();

            this.DatabaseSession.Derive(true);

            Assert.AreEqual("Percentage Cancellation Charge value 10", orderTerm.DisplayName);
        }
    }
}
