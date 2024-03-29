//------------------------------------------------------------------------------------------------- 
// <copyright file="RequirementTests.cs" company="Allors bvba">
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
    
    using Allors.Domain;

    using NUnit.Framework;

    [TestFixture]
    public class RequirementTests : DomainTest
    {
        [Test]
        public void GivenCustomerRequirement_WhenBuild_ThenPreviousObjectStateEqualsCurrencObjectState()
        {
            var requirement = new CustomerRequirementBuilder(this.DatabaseSession).WithDescription("CustomerRequirement").Build();

            this.DatabaseSession.Derive(true);

            Assert.AreEqual(new RequirementObjectStates(this.DatabaseSession).Active, requirement.CurrentObjectState);
            Assert.IsNotNull(requirement.PreviousObjectState);
            Assert.AreEqual(requirement.PreviousObjectState, requirement.CurrentObjectState);
        }

        [Test]
        public void GivenCustomerRequirement_WhenConfirmed_ThenCurrentRequirementStatusMustBeDerived()
        {
            var requirement = new CustomerRequirementBuilder(this.DatabaseSession).WithDescription("CustomerRequirement").Build();

            this.DatabaseSession.Derive(true);

            Assert.AreEqual(1, requirement.RequirementStatuses.Count);
            Assert.AreEqual(new RequirementObjectStates(this.DatabaseSession).Active, requirement.CurrentRequirementStatus.RequirementObjectState);

            requirement.Close();

            this.DatabaseSession.Derive(true);

            Assert.AreEqual(2, requirement.RequirementStatuses.Count);
            Assert.AreEqual(new RequirementObjectStates(this.DatabaseSession).Closed, requirement.CurrentRequirementStatus.RequirementObjectState);
        }

        [Test]
        public void GivenCustomerRequirement_WhenDeriving_ThenDescriptionIsRequired()
        {
            var builder = new CustomerRequirementBuilder(this.DatabaseSession);
            var customerRequirement = builder.Build();

            Assert.IsTrue(this.DatabaseSession.Derive().HasErrors);

            this.DatabaseSession.Rollback();

            builder.WithDescription("CustomerRequirement");
            customerRequirement = builder.Build();

            Assert.IsFalse(this.DatabaseSession.Derive().HasErrors);
        }

        [Test]
        public void GivenCustomerRequirement_WhenDeriving_ThenDisplayNameIsSet()
        {
            var customerRequirement = new CustomerRequirementBuilder(this.DatabaseSession)
                .WithDescription("CustomerRequirement")
                .Build();

            this.DatabaseSession.Derive(true);

            Assert.AreEqual("CustomerRequirement", customerRequirement.DisplayName);
        }

        [Test]
        public void GivenInternalRequirement_WhenDeriving_ThenDescriptionIsRequired()
        {
            var builder = new InternalRequirementBuilder(this.DatabaseSession);
            var internalRequirement = builder.Build();

            Assert.IsTrue(this.DatabaseSession.Derive().HasErrors);

            this.DatabaseSession.Rollback();

            builder.WithDescription("InternalRequirement");
            internalRequirement = builder.Build();

            Assert.IsFalse(this.DatabaseSession.Derive().HasErrors);
        }

        [Test]
        public void GivenInternalRequirement_WhenDeriving_ThenDisplayNameIsSet()
        {
            var internalRequirement = new InternalRequirementBuilder(this.DatabaseSession)
                .WithDescription("InternalRequirement")
                .Build();

            this.DatabaseSession.Derive(true);

            Assert.AreEqual("InternalRequirement", internalRequirement.DisplayName);
        }

        [Test]
        public void GivenProductRequirement_WhenDeriving_ThenDescriptionIsRequired()
        {
            var builder = new ProductRequirementBuilder(this.DatabaseSession);
            var productRequirement = builder.Build();

            Assert.IsTrue(this.DatabaseSession.Derive().HasErrors);

            this.DatabaseSession.Rollback();

            builder.WithDescription("ProductRequirement");
            productRequirement = builder.Build();

            Assert.IsFalse(this.DatabaseSession.Derive().HasErrors);
        }

        [Test]
        public void GivenProductRequirement_WhenDeriving_ThenDisplayNameIsSet()
        {
            var productRequirement = new ProductRequirementBuilder(this.DatabaseSession)
                .WithDescription("ProductRequirement")
                .Build();

            this.DatabaseSession.Derive(true);

            Assert.AreEqual("ProductRequirement", productRequirement.DisplayName);
        }

        [Test]
        public void GivenProjectRequirement_WhenDeriving_ThenDescriptionIsRequired()
        {
            var builder = new ProjectRequirementBuilder(this.DatabaseSession);
            var projectRequirement = builder.Build();

            Assert.IsTrue(this.DatabaseSession.Derive().HasErrors);

            this.DatabaseSession.Rollback();

            builder.WithDescription("ProjectRequirement");
            projectRequirement = builder.Build();

            Assert.IsFalse(this.DatabaseSession.Derive().HasErrors);
        }

        [Test]
        public void GivenProjectRequirement_WhenDeriving_ThenDisplayNameIsSet()
        {
            var projectRequirement = new ProjectRequirementBuilder(this.DatabaseSession)
                .WithDescription("ProjectRequirement")
                .Build();

            this.DatabaseSession.Derive(true);

            Assert.AreEqual("ProjectRequirement", projectRequirement.DisplayName);
        }

        [Test]
        public void GivenResourceRequirement_WhenDeriving_ThenDescriptionIsRequired()
        {
            var builder = new ResourceRequirementBuilder(this.DatabaseSession);
            var resourceRequirement = builder.Build();

            Assert.IsTrue(this.DatabaseSession.Derive().HasErrors);

            this.DatabaseSession.Rollback();

            builder.WithDescription("ResourceRequirement");
            resourceRequirement = builder.Build();

            Assert.IsFalse(this.DatabaseSession.Derive().HasErrors);
        }

        [Test]
        public void GivenResourceRequirement_WhenDeriving_ThenDisplayNameIsSet()
        {
            var resourceRequirement = new ResourceRequirementBuilder(this.DatabaseSession)
                .WithDescription("ResourceRequirement")
                .Build();

            this.DatabaseSession.Derive(true);

            Assert.AreEqual("ResourceRequirement", resourceRequirement.DisplayName);
        }

        [Test]
        public void GivenWorkRequirement_WhenDeriving_ThenDescriptionIsRequired()
        {
            var builder = new WorkRequirementBuilder(this.DatabaseSession);
            var workRequirement = builder.Build();

            Assert.IsTrue(this.DatabaseSession.Derive().HasErrors);

            this.DatabaseSession.Rollback();

            builder.WithDescription("WorkRequirement");
            workRequirement = builder.Build();

            Assert.IsFalse(this.DatabaseSession.Derive().HasErrors);
        }

        [Test]
        public void GivenWorkRequirement_WhenDeriving_ThenDisplayNameIsSet()
        {
            var workRequirement = new WorkRequirementBuilder(this.DatabaseSession)
                .WithDescription("WorkRequirement")
                .Build();

            this.DatabaseSession.Derive(true);

            Assert.AreEqual("WorkRequirement", workRequirement.DisplayName);
        }
    }
}