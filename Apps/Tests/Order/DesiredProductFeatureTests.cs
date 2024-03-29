//------------------------------------------------------------------------------------------------- 
// <copyright file="DesiredProductFeatureTests.cs" company="Allors bvba">
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
    public class DesiredProductFeatureTests : DomainTest
    {
        [Test]
        public void GivenDesiredProductFeature_WhenDeriving_ThenRequiredRelationsMustExist()
        {
            var vatRate21 = new VatRateBuilder(this.DatabaseSession).WithRate(21).Build();
            var softwareFeature = new SoftwareFeatureBuilder(this.DatabaseSession)
                .WithDescription("Tutorial DVD")
                .WithVatRate(vatRate21)
                .WithLocalisedName(new LocalisedTextBuilder(this.DatabaseSession).WithText("Tutorial").WithLocale(Singleton.Instance(this.DatabaseSession).DefaultLocale).Build())
                .Build();

            this.DatabaseSession.Derive(true);
            this.DatabaseSession.Commit();

            var builder = new DesiredProductFeatureBuilder(this.DatabaseSession);
            var desiredProductFeature = builder.Build();

            Assert.IsTrue(this.DatabaseSession.Derive().HasErrors);

            this.DatabaseSession.Rollback();
            
            builder.WithRequired(false);
            desiredProductFeature = builder.Build();

            Assert.IsTrue(this.DatabaseSession.Derive().HasErrors);

            this.DatabaseSession.Rollback();

            builder.WithProductFeature(softwareFeature);
            desiredProductFeature = builder.Build();

            Assert.IsFalse(this.DatabaseSession.Derive().HasErrors);
        }

        [Test]
        public void GivenDesiredProductFeature_WhenDeriving_ThenDisplayNameIsSet()
        {
            var vatRate21 = new VatRateBuilder(this.DatabaseSession).WithRate(21).Build();
            var softwareFeature = new SoftwareFeatureBuilder(this.DatabaseSession)
                .WithLocalisedName(new LocalisedTextBuilder(this.DatabaseSession).WithText("Tutorial DVD").WithLocale(Singleton.Instance(this.DatabaseSession).DefaultLocale).Build())
                .WithVatRate(vatRate21).Build();

            var desiredProductFeature = new DesiredProductFeatureBuilder(this.DatabaseSession)
                .WithRequired(false)
                .WithProductFeature(softwareFeature)
                .Build();

            this.DatabaseSession.Derive(true);

            Assert.AreEqual("Tutorial DVD", desiredProductFeature.DisplayName);
        }
    }
}