//------------------------------------------------------------------------------------------------- 
// <copyright file="ConstraintSpecificationTests.cs" company="Allors bvba">
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
    public class ConstraintSpecificationTests : DomainTest
    {
        [Test]
        public void GivenConstraintSpecification_WhenDeriving_ThenRequiredRelationsMustExist()
        {
            var builder = new ConstraintSpecificationBuilder(this.DatabaseSession);
            var specification = builder.Build();

            Assert.IsTrue(this.DatabaseSession.Derive().HasErrors);

            this.DatabaseSession.Rollback();

            builder.WithDescription("Description");
            specification = builder.Build();

            Assert.IsFalse(this.DatabaseSession.Derive().HasErrors);

            Assert.AreEqual(specification.CurrentPartSpecificationStatus.PartSpecificationObjectState, new PartSpecificationObjectStates(this.DatabaseSession).Created);
            Assert.AreEqual(specification.CurrentObjectState, new PartSpecificationObjectStates(this.DatabaseSession).Created);
            Assert.AreEqual(specification.CurrentObjectState, specification.PreviousObjectState);
        }

        [Test]
        public void GivenConstraintSpecification_WhenDeriving_ThenDisplayNameIsSet()
        {
            var specification = new ConstraintSpecificationBuilder(this.DatabaseSession)
                .WithDescription("Activity")
                .Build();

            this.DatabaseSession.Derive(true);

            Assert.AreEqual(specification.Description, specification.DisplayName);
        }
    }
}