//------------------------------------------------------------------------------------------------- 
// <copyright file="CostCenterTests.cs" company="Allors bvba">
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

    [TestFixture]
    public class CostCenterTests : DomainTest
    {
        [Test]
        public void GivenCostCenter_WhenDeriving_ThenRequiredRelationsMustExist()
        {
            var builder = new CostCenterBuilder(this.DatabaseSession);
            builder.Build();

            Assert.IsTrue(this.DatabaseSession.Derive().HasErrors);

            this.DatabaseSession.Rollback();

            builder.WithName("CostCenter");
            builder.Build();

            Assert.IsFalse(this.DatabaseSession.Derive().HasErrors);
        }

        [Test]
        public void GivenCostCenter_WhenDeriving_ThenPostBuildRelationsMustExist()
        {
            var costCenter = new CostCenterBuilder(this.DatabaseSession)
                .WithName("CostCenter")
                .Build();

            Assert.IsTrue(costCenter.ExistUniqueId);
        }

        [Test]
        public void GivenCostCenter_WhenDeriving_ThenDisplayNameIsSet()
        {
            var costCenter = new CostCenterBuilder(this.DatabaseSession)
                .WithName("CostCenter")
                .Build();

            this.DatabaseSession.Derive(true);

            Assert.AreEqual(costCenter.Name, costCenter.DisplayName);
        }
    }
}