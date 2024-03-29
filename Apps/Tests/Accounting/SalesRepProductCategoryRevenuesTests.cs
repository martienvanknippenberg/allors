// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesRepProductCategoryRevenuesTests.cs" company="Allors bvba">
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
    public class SalesRepProductCategoryRevenuesTests : DomainTest
    {
        [Test]
        public void GivenSalesRepProductCategoryRevenueHistory_WhenDeriving_ThenDisplayNameIsSet()
        {
            const decimal Revenue = 100.25M;
            const int Year = 2011;
            const int Month = 12;
            var internalOrganisation = new InternalOrganisations(this.DatabaseSession).FindBy(InternalOrganisations.Meta.Name, "internalOrganisation");
            var salesRep = new PersonBuilder(this.DatabaseSession).WithLastName("salesRep").Build();
            var productCategory = new ProductCategoryBuilder(this.DatabaseSession).WithDescription("productCategory").Build();

            var revenueHistory = new SalesRepProductCategoryRevenueBuilder(this.DatabaseSession)
                .WithInternalOrganisation(internalOrganisation)
                .WithSalesRep(salesRep)
                .WithProductCategory(productCategory)
                .WithYear(Year)
                .WithMonth(Month)
                .WithRevenue(Revenue)
                .Build();

            this.DatabaseSession.Derive(true);

            Assert.AreEqual(string.Format("{0}, {1}: {2}/{3} {4} at {5}", salesRep.DisplayName, productCategory.DisplayName, Year, Month, Revenue.AsCurrencyString(internalOrganisation.CurrencyFormat), internalOrganisation.DisplayName), revenueHistory.DisplayName);
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
            var catMain = new ProductCategoryBuilder(this.DatabaseSession).WithDescription("main cat").Build();
            var cat1 = new ProductCategoryBuilder(this.DatabaseSession).WithDescription("cat for good1").WithParent(catMain).Build();
            var cat2 = new ProductCategoryBuilder(this.DatabaseSession).WithDescription("cat for good2").WithParent(catMain).Build();

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

            var salesRep1ProductCategoryRevenues = salesRep1.SalesRepProductCategoryRevenuesWhereSalesRep;
            Assert.AreEqual(2, salesRep1ProductCategoryRevenues.Count);

            salesRep1ProductCategoryRevenues.Filter.AddEquals(SalesRepProductCategoryRevenues.Meta.ProductCategory, cat1);
            var salesRep1Cat1Revenue = salesRep1ProductCategoryRevenues.First;

            salesRep1ProductCategoryRevenues = salesRep1.SalesRepProductCategoryRevenuesWhereSalesRep;
            salesRep1ProductCategoryRevenues.Filter.AddEquals(SalesRepProductCategoryRevenues.Meta.ProductCategory, catMain);
            var salesRep1CatMainRevenue = salesRep1ProductCategoryRevenues.First;

            var salesRep2ProductCategoryRevenues = salesRep2.SalesRepProductCategoryRevenuesWhereSalesRep;
            Assert.AreEqual(2, salesRep2ProductCategoryRevenues.Count);

            salesRep2ProductCategoryRevenues.Filter.AddEquals(SalesRepProductCategoryRevenues.Meta.ProductCategory, cat2);
            var salesRep2Cat2Revenue = salesRep2ProductCategoryRevenues.First;

            salesRep2ProductCategoryRevenues = salesRep2.SalesRepProductCategoryRevenuesWhereSalesRep;
            salesRep2ProductCategoryRevenues.Filter.AddEquals(SalesRepProductCategoryRevenues.Meta.ProductCategory, catMain);
            var salesRep2CatMainRevenue = salesRep2ProductCategoryRevenues.First;

            Assert.AreEqual(90, salesRep1Cat1Revenue.Revenue);
            Assert.AreEqual(90, salesRep1CatMainRevenue.Revenue);
            Assert.AreEqual(50, salesRep2Cat2Revenue.Revenue);
            Assert.AreEqual(50, salesRep2CatMainRevenue.Revenue);

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

            Assert.AreEqual(105, salesRep1Cat1Revenue.Revenue);
            Assert.AreEqual(105, salesRep1CatMainRevenue.Revenue);
            Assert.AreEqual(60, salesRep2Cat2Revenue.Revenue);
            Assert.AreEqual(60, salesRep2CatMainRevenue.Revenue);
        }
    }
}
