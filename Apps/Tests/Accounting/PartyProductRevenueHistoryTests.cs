// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PartyProductRevenueHistoryTests.cs" company="Allors bvba">
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
    public class PartyProductRevenueHistoryTests : DomainTest
    {
        [Test]
        public void GivenPartyProductRevenueHistory_WhenDeriving_ThenDisplayNameIsSet()
        {
            var revenue = 100.25M;
            
            var internalOrganisation = new InternalOrganisations(this.DatabaseSession).FindBy(InternalOrganisations.Meta.Name, "internalOrganisation");
            var party = new OrganisationBuilder(this.DatabaseSession).WithName("Organisation").Build();

            new CustomerRelationshipBuilder(this.DatabaseSession).WithCustomer(party).WithInternalOrganisation(internalOrganisation).Build();

            var product = new GoodBuilder(this.DatabaseSession)
                .WithSku("10101")
                .WithVatRate(new VatRates(this.DatabaseSession).Extent().First)
                .WithName("good1")
                .WithInventoryItemKind(new InventoryItemKinds(this.DatabaseSession).NonSerialized)
                .WithUnitOfMeasure(new UnitsOfMeasure(this.DatabaseSession).Piece)
                .WithPrimaryProductCategory(new ProductCategories(this.DatabaseSession).Extent().First)
                .Build();

            var packageRevenueHistory = new PartyProductRevenueHistoryBuilder(this.DatabaseSession)
                .WithParty(party)
                .WithProduct(product)
                .WithRevenue(revenue)
                .WithInternalOrganisation(internalOrganisation)
                .Build();

            this.DatabaseSession.Derive(true);

            Assert.AreEqual(string.Format("{0}, {1}: {2} revenue trailing twelve months at {3}", party.DisplayName, product.DisplayName, revenue.AsCurrencyString(internalOrganisation.CurrencyFormat), internalOrganisation.DisplayName), packageRevenueHistory.DisplayName);
        }

        [Test]
        public void GivenSalesInvoice_WhenDerived_ThenTotalExVatIsAddedToPartyProductRevenueHistory()
        {
            var productItem = new SalesInvoiceItemTypes(this.DatabaseSession).ProductItem;
            var contactMechanism = new ContactMechanisms(this.DatabaseSession).Extent().First; 

            var euro = new Currencies(this.DatabaseSession).FindBy(Currencies.Meta.IsoCode, "EUR");
            var vatRate21 = new VatRateBuilder(this.DatabaseSession).WithRate(21).Build();
            var catMain = new ProductCategoryBuilder(this.DatabaseSession).WithDescription("main cat").Build();
            var cat1 = new ProductCategoryBuilder(this.DatabaseSession).WithDescription("cat for good1").WithParent(catMain).Build();

            var good1 = new GoodBuilder(this.DatabaseSession)
                .WithSku("10101")
                .WithVatRate(vatRate21)
                .WithName("good1")
                .WithInventoryItemKind(new InventoryItemKinds(this.DatabaseSession).NonSerialized)
                .WithUnitOfMeasure(new UnitsOfMeasure(this.DatabaseSession).Piece)
                .WithPrimaryProductCategory(cat1)
                .Build();

            var customer = new Organisations(this.DatabaseSession).FindBy(Organisations.Meta.Name, "customer");
            var internalOrganisation = new InternalOrganisations(this.DatabaseSession).FindBy(InternalOrganisations.Meta.Name, "internalOrganisation");
            internalOrganisation.PreferredCurrency = euro;

            new CustomerRelationshipBuilder(this.DatabaseSession).WithCustomer(customer).WithInternalOrganisation(internalOrganisation).Build();

            this.DatabaseSession.Derive(true);
            this.DatabaseSession.Commit();

            var date = DateTime.Now.AddYears(-1).AddMonths(-1);
            decimal revenuePastTwelveMonths = 0;
            for (var i = 1; i <= 13; i++)
            {
                var invoice = new SalesInvoiceBuilder(this.DatabaseSession)
                    .WithInvoiceDate(date)
                    .WithBillToCustomer(customer)
                    .WithBillToContactMechanism(contactMechanism)
                    .WithSalesChannel(new SalesChannels(this.DatabaseSession).WebChannel)
                    .WithSalesInvoiceType(new SalesInvoiceTypes(this.DatabaseSession).SalesInvoice)
                    .Build();

                var item = new SalesInvoiceItemBuilder(this.DatabaseSession).WithProduct(good1).WithQuantity(1).WithActualUnitPrice(i * 10M).WithSalesInvoiceItemType(productItem).Build();
                invoice.AddSalesInvoiceItem(item);

                this.DatabaseSession.Derive(true);
                this.DatabaseSession.Commit();

                var history = customer.PartyProductRevenueHistoriesWhereParty.First;

                //// first iteration is too old
                if (i > 1)
                {
                    revenuePastTwelveMonths += i * 10M;
                }

                ////date in first iteration is too old, no history yet.
                if (history != null)
                {
                    Assert.AreEqual(revenuePastTwelveMonths, history.Revenue);
                }

                date = date.AddMonths(1);
            }
        }

        [Test]
        public void DeriveHistory()
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
                .WithInvoiceDate(DateTime.Now.AddMonths(-1))
                .WithInvoiceNumber("1")
                .WithBillToCustomer(customer1)
                .WithBillToContactMechanism(contactMechanism)
                .WithSalesInvoiceType(new SalesInvoiceTypes(this.DatabaseSession).SalesInvoice)
                .Build();

            var item1a = new SalesInvoiceItemBuilder(this.DatabaseSession).WithProduct(good1).WithQuantity(3).WithActualUnitPrice(15).WithSalesInvoiceItemType(productItem).Build();
            invoice1.AddSalesInvoiceItem(item1a);

            var item1b = new SalesInvoiceItemBuilder(this.DatabaseSession).WithProduct(good1).WithQuantity(3).WithActualUnitPrice(15).WithSalesInvoiceItemType(productItem).Build();
            invoice1.AddSalesInvoiceItem(item1b);

            var item1c = new SalesInvoiceItemBuilder(this.DatabaseSession).WithProduct(good2).WithQuantity(5).WithActualUnitPrice(10).WithSalesInvoiceItemType(productItem).Build();
            invoice1.AddSalesInvoiceItem(item1c);

            this.DatabaseSession.Derive(true);

            var invoice2 = new SalesInvoiceBuilder(this.DatabaseSession)
                .WithInvoiceDate(DateTime.Now)
                .WithInvoiceNumber("1")
                .WithBillToCustomer(customer1)
                .WithBillToContactMechanism(contactMechanism)
                .WithSalesInvoiceType(new SalesInvoiceTypes(this.DatabaseSession).SalesInvoice)
                .Build();

            var item2a = new SalesInvoiceItemBuilder(this.DatabaseSession).WithProduct(good1).WithQuantity(3).WithActualUnitPrice(15).WithSalesInvoiceItemType(productItem).Build();
            invoice2.AddSalesInvoiceItem(item2a);

            var item2b = new SalesInvoiceItemBuilder(this.DatabaseSession).WithProduct(good1).WithQuantity(3).WithActualUnitPrice(15).WithSalesInvoiceItemType(productItem).Build();
            invoice2.AddSalesInvoiceItem(item2b);

            var item2c = new SalesInvoiceItemBuilder(this.DatabaseSession).WithProduct(good2).WithQuantity(5).WithActualUnitPrice(10).WithSalesInvoiceItemType(productItem).Build();
            invoice2.AddSalesInvoiceItem(item2c);

            this.DatabaseSession.Derive(true);

            Singleton.Instance(this.DatabaseSession).DeriveRevenues();

            var customer1Good1RevenueHistories = customer1.PartyProductRevenueHistoriesWhereParty;
            customer1Good1RevenueHistories.Filter.AddEquals(PartyProductRevenueHistories.Meta.Product, good1);
            var customer1Good1RevenueHistory = customer1Good1RevenueHistories.First;

            var customer1Good2RevenueHistories = customer1.PartyProductRevenueHistoriesWhereParty;
            customer1Good2RevenueHistories.Filter.AddEquals(PartyProductRevenueHistories.Meta.Product, good2);
            var customer1Good2RevenueHistory = customer1Good2RevenueHistories.First;

            Assert.AreEqual(180, customer1Good1RevenueHistory.Revenue);
            Assert.AreEqual(100, customer1Good2RevenueHistory.Revenue);

            var invoice3 = new SalesInvoiceBuilder(this.DatabaseSession)
                .WithInvoiceDate(DateTime.Now)
                .WithInvoiceNumber("1")
                .WithBillToCustomer(customer2)
                .WithBillToContactMechanism(contactMechanism)
                .WithSalesInvoiceType(new SalesInvoiceTypes(this.DatabaseSession).SalesInvoice)
                .Build();

            var item3a = new SalesInvoiceItemBuilder(this.DatabaseSession).WithProduct(good1).WithQuantity(1).WithActualUnitPrice(15).WithSalesInvoiceItemType(productItem).Build();
            invoice3.AddSalesInvoiceItem(item3a);

            var item3b = new SalesInvoiceItemBuilder(this.DatabaseSession).WithProduct(good2).WithQuantity(1).WithActualUnitPrice(10).WithSalesInvoiceItemType(productItem).Build();
            invoice3.AddSalesInvoiceItem(item3b);

            this.DatabaseSession.Derive(true);

            Singleton.Instance(this.DatabaseSession).DeriveRevenues();

            var customer2Good1RevenueHistories = customer2.PartyProductRevenueHistoriesWhereParty;
            customer2Good1RevenueHistories.Filter.AddEquals(PartyProductRevenueHistories.Meta.Product, good1);
            var customer2Good1RevenueHistory = customer2Good1RevenueHistories.First;

            var customer2Good2RevenueHistories = customer2.PartyProductRevenueHistoriesWhereParty;
            customer2Good2RevenueHistories.Filter.AddEquals(PartyProductRevenueHistories.Meta.Product, good2);
            var customer2Good2RevenueHistory = customer2Good2RevenueHistories.First;

            Assert.AreEqual(180, customer1Good1RevenueHistory.Revenue);
            Assert.AreEqual(100, customer1Good2RevenueHistory.Revenue);

            Assert.AreEqual(15, customer2Good1RevenueHistory.Revenue);
            Assert.AreEqual(10, customer2Good2RevenueHistory.Revenue);
        }
    }
}
