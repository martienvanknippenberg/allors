// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PartyPackageRevenuesTests.cs" company="Allors bvba">
//   Copyright 2002-2009 Allors bvba.
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
    using System;

    
    using Allors.Domain;

    using NUnit.Framework;

    [TestFixture]
    public class PartyPackageRevenuesTests : DomainTest
    {
        [Test]
        public void GivenPartyPackageRevenue_WhenDeriving_ThenDisplayNameIsSet()
        {
            const decimal Revenue = 100.25M;
            const int Year = 2011;
            const int Month = 12;
            var internalOrganisation = new InternalOrganisations(this.DatabaseSession).FindBy(InternalOrganisations.Meta.Name, "internalOrganisation");
            var party = new OrganisationBuilder(this.DatabaseSession).WithName("Organisation").Build();
            var package = new PackageBuilder(this.DatabaseSession).WithName("package").Build();

            var revenue = new PartyPackageRevenueBuilder(this.DatabaseSession)
                .WithParty(party)
                .WithPackage(package)
                .WithYear(Year)
                .WithMonth(Month)
                .WithRevenue(Revenue)
                .WithInternalOrganisation(internalOrganisation)
                .Build();

            this.DatabaseSession.Derive(true);

            Assert.AreEqual(string.Format("{0}, {1}: {2}/{3} {4} at {5}", party.DisplayName, package.DisplayName, Year, Month, Revenue.AsCurrencyString(internalOrganisation.CurrencyFormat), internalOrganisation.DisplayName), revenue.DisplayName);
        }

        [Test]
        public void DeriveRevenues()
        {
            var productItem = new SalesInvoiceItemTypes(this.DatabaseSession).ProductItem;
            var contactMechanism = new ContactMechanisms(this.DatabaseSession).Extent().First;

            var customer1 = new OrganisationBuilder(this.DatabaseSession).WithName("customer1").Build();
            var customer2 = new OrganisationBuilder(this.DatabaseSession).WithName("customer2").Build();
            var salesRep1 = new PersonBuilder(this.DatabaseSession).WithLastName("salesRep1").Build();
            var salesRep2 = new PersonBuilder(this.DatabaseSession).WithLastName("salesRep2").Build();
            var package1 = new PackageBuilder(this.DatabaseSession).WithName("package1").Build();
            var package2 = new PackageBuilder(this.DatabaseSession).WithName("package2").Build();
            var catMain = new ProductCategoryBuilder(this.DatabaseSession).WithDescription("main cat").Build();

            var cat1 = new ProductCategoryBuilder(this.DatabaseSession).WithDescription("cat for good1").WithParent(catMain).WithPackage(package1).Build();
            var cat2 = new ProductCategoryBuilder(this.DatabaseSession).WithDescription("cat for good2").WithParent(catMain).WithPackage(package2).Build();

            new SalesRepRelationshipBuilder(this.DatabaseSession).WithFromDate(DateTime.Now).WithCustomer(customer1).WithProductCategory(cat1).WithSalesRepresentative(salesRep1).Build();
            new SalesRepRelationshipBuilder(this.DatabaseSession).WithFromDate(DateTime.Now).WithCustomer(customer1).WithProductCategory(cat2).WithSalesRepresentative(salesRep2).Build();

            this.DatabaseSession.Derive(true);

            new SalesRepRelationshipBuilder(this.DatabaseSession).WithFromDate(DateTime.Now).WithCustomer(customer2).WithProductCategory(cat1).WithSalesRepresentative(salesRep1).Build();
            new SalesRepRelationshipBuilder(this.DatabaseSession).WithFromDate(DateTime.Now).WithCustomer(customer2).WithProductCategory(cat2).WithSalesRepresentative(salesRep2).Build();

            this.DatabaseSession.Derive(true);

            var euro = new Currencies(this.DatabaseSession).FindBy(Currencies.Meta.IsoCode, "EUR");
            var vatRate21 = new VatRateBuilder(this.DatabaseSession).WithRate(21).Build();

            var good1 = new GoodBuilder(this.DatabaseSession)
                .WithSku("10101")
                .WithVatRate(vatRate21)
                .WithName("good1")
                .WithInventoryItemKind(new InventoryItemKinds(this.DatabaseSession).NonSerialized)
                .WithUnitOfMeasure(new UnitsOfMeasure(this.DatabaseSession).Piece)
                .WithPrimaryProductCategory(cat1)
                .Build();

            var good2 = new GoodBuilder(this.DatabaseSession)
                .WithSku("10102")
                .WithVatRate(vatRate21)
                .WithName("good2")
                .WithInventoryItemKind(new InventoryItemKinds(this.DatabaseSession).NonSerialized)
                .WithUnitOfMeasure(new UnitsOfMeasure(this.DatabaseSession).Piece)
                .WithPrimaryProductCategory(cat2)
                .Build();

            var internalOrganisation = new InternalOrganisations(this.DatabaseSession).FindBy(InternalOrganisations.Meta.Name, "internalOrganisation");
            internalOrganisation.PreferredCurrency = euro;

            new CustomerRelationshipBuilder(this.DatabaseSession).WithCustomer(customer1).WithInternalOrganisation(internalOrganisation).Build();
            new CustomerRelationshipBuilder(this.DatabaseSession).WithCustomer(customer2).WithInternalOrganisation(internalOrganisation).Build();

            var invoice1 = new SalesInvoiceBuilder(this.DatabaseSession)
                .WithInvoiceDate(DateTime.Now)
                .WithInvoiceNumber("1")
                .WithBillToCustomer(customer1)
                .WithBillToContactMechanism(contactMechanism)
                .WithSalesInvoiceType(new SalesInvoiceTypes(this.DatabaseSession).SalesInvoice)
                .Build();

            var item1 = new SalesInvoiceItemBuilder(this.DatabaseSession).WithProduct(good1).WithQuantity(3).WithActualUnitPrice(15).WithSalesInvoiceItemType(productItem).Build();
            invoice1.AddSalesInvoiceItem(item1);

            var item2 = new SalesInvoiceItemBuilder(this.DatabaseSession).WithProduct(good1).WithQuantity(3).WithActualUnitPrice(15).WithSalesInvoiceItemType(productItem).Build();
            invoice1.AddSalesInvoiceItem(item2);

            var item3 = new SalesInvoiceItemBuilder(this.DatabaseSession).WithProduct(good2).WithQuantity(5).WithActualUnitPrice(10).WithSalesInvoiceItemType(productItem).Build();
            invoice1.AddSalesInvoiceItem(item3);

            this.DatabaseSession.Derive(true);

            Singleton.Instance(this.DatabaseSession).DeriveRevenues();

            var customer1PackageRevenues = customer1.PartyPackageRevenuesWhereParty;
            Assert.AreEqual(2, customer1PackageRevenues.Count);

            customer1PackageRevenues.Filter.AddEquals(PartyPackageRevenues.Meta.Package, package1);
            var customer1Package1Revenue = customer1PackageRevenues.First;

            customer1PackageRevenues = customer1.PartyPackageRevenuesWhereParty;
            customer1PackageRevenues.Filter.AddEquals(PartyPackageRevenues.Meta.Package, package2);
            var customer1Package2Revenue = customer1PackageRevenues.First;

            Assert.AreEqual(90, customer1Package1Revenue.Revenue);
            Assert.AreEqual(50, customer1Package2Revenue.Revenue);

            var invoice2 = new SalesInvoiceBuilder(this.DatabaseSession)
                .WithInvoiceDate(DateTime.Now)
                .WithInvoiceNumber("1")
                .WithBillToCustomer(customer2)
                .WithBillToContactMechanism(contactMechanism)
                .WithSalesInvoiceType(new SalesInvoiceTypes(this.DatabaseSession).SalesInvoice)
                .Build();

            var item4 = new SalesInvoiceItemBuilder(this.DatabaseSession).WithProduct(good1).WithQuantity(1).WithActualUnitPrice(15).WithSalesInvoiceItemType(productItem).Build();
            invoice2.AddSalesInvoiceItem(item4);

            this.DatabaseSession.Derive(true);

            var item5 = new SalesInvoiceItemBuilder(this.DatabaseSession).WithProduct(good2).WithQuantity(1).WithActualUnitPrice(10).WithSalesInvoiceItemType(productItem).Build();
            invoice2.AddSalesInvoiceItem(item5);

            this.DatabaseSession.Derive(true);

            Singleton.Instance(this.DatabaseSession).DeriveRevenues();

            var customer2PackageRevenues = customer2.PartyPackageRevenuesWhereParty;
            Assert.AreEqual(2, customer2PackageRevenues.Count);

            customer2PackageRevenues.Filter.AddEquals(PartyPackageRevenues.Meta.Package, package1);
            var customer2Package1Revenue = customer2PackageRevenues.First;

            customer2PackageRevenues = customer2.PartyPackageRevenuesWhereParty;
            customer2PackageRevenues.Filter.AddEquals(PartyPackageRevenues.Meta.Package, package2);
            var customer2Package2Revenue = customer2PackageRevenues.First;

            Assert.AreEqual(15, customer2Package1Revenue.Revenue);
            Assert.AreEqual(10, customer2Package2Revenue.Revenue);
        }
    }
}
