﻿//------------------------------------------------------------------------------------------------- 
// <copyright file="JournalTests.cs" company="Allors bvba">
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
    public class JournalTests : DomainTest
    {
        [Test]
        public void GivenJournal_WhenDeriving_ThenDescriptionMustExist()
        {
            var internalOrganisation = new InternalOrganisations(this.DatabaseSession).FindBy(InternalOrganisations.Meta.Name, "internalOrganisation");

            var glAccount = new GeneralLedgerAccountBuilder(this.DatabaseSession)
                .WithAccountNumber("0001")
                .WithName("GeneralLedgerAccount")
                .WithBalanceSheetAccount(true)
                .WithSide(new DebitCreditConstants(this.DatabaseSession).Debit)
                .WithGeneralLedgerAccountType(new GeneralLedgerAccountTypeBuilder(this.DatabaseSession).WithDescription("accountType").Build())
                .WithGeneralLedgerAccountGroup(new GeneralLedgerAccountGroupBuilder(this.DatabaseSession).WithDescription("accountGroup").Build())
                .Build();

            var internalOrganisationGlAccount = new OrganisationGlAccountBuilder(this.DatabaseSession)
                .WithInternalOrganisation(internalOrganisation)
                .WithGeneralLedgerAccount(glAccount)
                .Build();

            this.DatabaseSession.Commit();

            var builder = new JournalBuilder(this.DatabaseSession);
            builder.WithInternalOrganisation(internalOrganisation);
            builder.WithJournalType(new JournalTypes(this.DatabaseSession).Bank);
            builder.WithContraAccount(internalOrganisationGlAccount);
            builder.Build();

            Assert.IsTrue(this.DatabaseSession.Derive().HasErrors);

            this.DatabaseSession.Rollback();

            builder.WithDescription("description");
            builder.Build();

            Assert.IsFalse(this.DatabaseSession.Derive().HasErrors);
        }

        [Test]
        public void GivenJournal_WhenDeriving_ThenInternalOrganisationMustExist()
        {
            var internalOrganisation = new InternalOrganisations(this.DatabaseSession).FindBy(InternalOrganisations.Meta.Name, "internalOrganisation");
            var glAccount = new GeneralLedgerAccountBuilder(this.DatabaseSession)
                .WithAccountNumber("0001")
                .WithName("GeneralLedgerAccount")
                .WithBalanceSheetAccount(true)
                .WithSide(new DebitCreditConstants(this.DatabaseSession).Debit)
                .WithGeneralLedgerAccountType(new GeneralLedgerAccountTypeBuilder(this.DatabaseSession).WithDescription("accountType").Build())
                .WithGeneralLedgerAccountGroup(new GeneralLedgerAccountGroupBuilder(this.DatabaseSession).WithDescription("accountGroup").Build())
                .Build();

            var internalOrganisationGlAccount = new OrganisationGlAccountBuilder(this.DatabaseSession)
                .WithInternalOrganisation(internalOrganisation)
                .WithGeneralLedgerAccount(glAccount)
                .Build();

            this.DatabaseSession.Commit();

            var builder = new JournalBuilder(this.DatabaseSession);
            builder.WithDescription("description");
            builder.WithJournalType(new JournalTypes(this.DatabaseSession).Bank);
            builder.WithContraAccount(internalOrganisationGlAccount);
            builder.Build();

            Assert.IsTrue(this.DatabaseSession.Derive().HasErrors);

            this.DatabaseSession.Rollback();

            builder.WithInternalOrganisation(new InternalOrganisations(this.DatabaseSession).FindBy(InternalOrganisations.Meta.Name, "internalOrganisation"));
            builder.Build();

            Assert.IsFalse(this.DatabaseSession.Derive().HasErrors);
        }

        [Test]
        public void GivenJournal_WhenDeriving_ThenJournalTypeMustExist()
        {
            var internalOrganisation = new InternalOrganisations(this.DatabaseSession).FindBy(InternalOrganisations.Meta.Name, "internalOrganisation");
            var glAccount = new GeneralLedgerAccountBuilder(this.DatabaseSession)
                .WithAccountNumber("0001")
                .WithName("GeneralLedgerAccount")
                .WithBalanceSheetAccount(true)
                .WithSide(new DebitCreditConstants(this.DatabaseSession).Debit)
                .WithGeneralLedgerAccountType(new GeneralLedgerAccountTypeBuilder(this.DatabaseSession).WithDescription("accountType").Build())
                .WithGeneralLedgerAccountGroup(new GeneralLedgerAccountGroupBuilder(this.DatabaseSession).WithDescription("accountGroup").Build())
                .Build();

            var internalOrganisationGlAccount = new OrganisationGlAccountBuilder(this.DatabaseSession)
                .WithInternalOrganisation(internalOrganisation)
                .WithGeneralLedgerAccount(glAccount)
                .Build();

            this.DatabaseSession.Commit();

            var builder = new JournalBuilder(this.DatabaseSession);
            builder.WithDescription("description");
            builder.WithInternalOrganisation(new InternalOrganisations(this.DatabaseSession).FindBy(InternalOrganisations.Meta.Name, "internalOrganisation"));
            builder.WithContraAccount(internalOrganisationGlAccount);
            builder.Build();

            Assert.IsTrue(this.DatabaseSession.Derive().HasErrors);

            this.DatabaseSession.Rollback();

            builder.WithJournalType(new JournalTypes(this.DatabaseSession).Bank);
            builder.Build();

            Assert.IsFalse(this.DatabaseSession.Derive().HasErrors);
        }

        [Test]
        public void GivenJournal_WhenDeriving_ThenContraAccountMustExist()
        {
            var internalOrganisation = new InternalOrganisations(this.DatabaseSession).FindBy(InternalOrganisations.Meta.Name, "internalOrganisation");

            var builder = new JournalBuilder(this.DatabaseSession);
            builder.WithDescription("description");
            builder.WithInternalOrganisation(internalOrganisation);
            builder.WithJournalType(new JournalTypes(this.DatabaseSession).Bank);
            builder.Build();

            Assert.IsTrue(this.DatabaseSession.Derive().HasErrors);

            this.DatabaseSession.Rollback();

            var glAccount = new GeneralLedgerAccountBuilder(this.DatabaseSession)
                .WithAccountNumber("0001")
                .WithName("GeneralLedgerAccount")
                .WithBalanceSheetAccount(true)
                .WithSide(new DebitCreditConstants(this.DatabaseSession).Debit)
                .WithGeneralLedgerAccountType(new GeneralLedgerAccountTypeBuilder(this.DatabaseSession).WithDescription("accountType").Build())
                .WithGeneralLedgerAccountGroup(new GeneralLedgerAccountGroupBuilder(this.DatabaseSession).WithDescription("accountGroup").Build())
                .Build();

            var internalOrganisationGlAccount = new OrganisationGlAccountBuilder(this.DatabaseSession)
                .WithInternalOrganisation(internalOrganisation)
                .WithGeneralLedgerAccount(glAccount)
                .Build();

            builder.WithContraAccount(internalOrganisationGlAccount);
            builder.Build();

            Assert.IsFalse(this.DatabaseSession.Derive().HasErrors);
        }

        [Test]
        public void GivenJournal_WhenBuildWithout_ThenBlockUnpaidTransactionsIsFalse()
        {
            var journal = new JournalBuilder(this.DatabaseSession)
                .Build();

            this.DatabaseSession.Derive();

            Assert.IsFalse(journal.BlockUnpaidTransactions);
        }

        [Test]
        public void GivenJournal_WhenBuildWithout_ThenCloseWhenInBalanceIsFalse()
        {
            var journal = new JournalBuilder(this.DatabaseSession)
                .Build();

            this.DatabaseSession.Derive();

            Assert.IsFalse(journal.CloseWhenInBalance);
        }

        [Test]
        public void GivenJournal_WhenBuildWithout_ThenUseAsDefaultIsFalse()
        {
            var journal = new JournalBuilder(this.DatabaseSession)
                .Build();

            this.DatabaseSession.Derive();

            Assert.IsFalse(journal.UseAsDefault);
        }

        [Test]
        public void GivenJournal_WhenDeriving_ThenDisplayNameIsSet()
        {
            var journal = new JournalBuilder(this.DatabaseSession)
                .WithDescription("description")
                .Build();

            this.DatabaseSession.Derive();
 
            Assert.AreEqual("description", journal.DisplayName);
        }

        [Test]
        public void GivenJournal_WhenDeriving_ThenContraAccountCanBeChangedWhenNotUsedYet()
        {
            var internalOrganisation = new InternalOrganisations(this.DatabaseSession).FindBy(InternalOrganisations.Meta.Name, "internalOrganisation");

            var generalLedgerAccount1 = new GeneralLedgerAccountBuilder(this.DatabaseSession)
                .WithAccountNumber("0001")
                .WithName("bankAccount 1")
                .WithBalanceSheetAccount(true)
                .WithSide(new DebitCreditConstants(this.DatabaseSession).Debit)
                .WithGeneralLedgerAccountType(new GeneralLedgerAccountTypeBuilder(this.DatabaseSession).WithDescription("accountType").Build())
                .WithGeneralLedgerAccountGroup(new GeneralLedgerAccountGroupBuilder(this.DatabaseSession).WithDescription("accountGroup").Build())
                .Build();

            var internalOrganisationGlAccount1 = new OrganisationGlAccountBuilder(this.DatabaseSession)
                .WithInternalOrganisation(internalOrganisation)
                .WithGeneralLedgerAccount(generalLedgerAccount1)
                .Build();

            var generalLedgerAccount2 = new GeneralLedgerAccountBuilder(this.DatabaseSession)
                .WithAccountNumber("0002")
                .WithName("bankAccount 2")
                .WithBalanceSheetAccount(true)
                .WithSide(new DebitCreditConstants(this.DatabaseSession).Debit)
                .WithGeneralLedgerAccountType(new GeneralLedgerAccountTypeBuilder(this.DatabaseSession).WithDescription("accountType").Build())
                .WithGeneralLedgerAccountGroup(new GeneralLedgerAccountGroupBuilder(this.DatabaseSession).WithDescription("accountGroup").Build())
                .Build();

            var internalOrganisationGlAccount2 = new OrganisationGlAccountBuilder(this.DatabaseSession)
                .WithInternalOrganisation(internalOrganisation)
                .WithGeneralLedgerAccount(generalLedgerAccount2)
                .Build();

            var journal = new JournalBuilder(this.DatabaseSession)
                .WithDescription("description")
                .WithContraAccount(internalOrganisationGlAccount1)
                .WithInternalOrganisation(new InternalOrganisations(this.DatabaseSession).FindBy(InternalOrganisations.Meta.Name, "internalOrganisation"))
                .WithJournalType(new JournalTypes(this.DatabaseSession).Bank)
                .Build();

            this.DatabaseSession.Derive(true);

            Assert.AreEqual(generalLedgerAccount1, journal.PreviousContraAccount);

            journal.ContraAccount = internalOrganisationGlAccount2;

            this.DatabaseSession.Derive(true);

            Assert.AreEqual(generalLedgerAccount2, journal.PreviousContraAccount);
        }

        [Test]
        public void GivenJournal_WhenDeriving_ThenContraAccountCanNotBeChangedWhenJournalEntriesArePresent()
        {
            var internalOrganisation = new InternalOrganisations(this.DatabaseSession).FindBy(InternalOrganisations.Meta.Name, "internalOrganisation");

            var generalLedgerAccount1 = new GeneralLedgerAccountBuilder(this.DatabaseSession)
                .WithAccountNumber("0001")
                .WithName("bankAccount 1")
                .WithBalanceSheetAccount(true)
                .WithSide(new DebitCreditConstants(this.DatabaseSession).Debit)
                .WithGeneralLedgerAccountType(new GeneralLedgerAccountTypeBuilder(this.DatabaseSession).WithDescription("accountType").Build())
                .WithGeneralLedgerAccountGroup(new GeneralLedgerAccountGroupBuilder(this.DatabaseSession).WithDescription("accountGroup").Build())
                .Build();

            var internalOrganisationGlAccount1 = new OrganisationGlAccountBuilder(this.DatabaseSession)
                .WithInternalOrganisation(internalOrganisation)
                .WithGeneralLedgerAccount(generalLedgerAccount1)
                .Build();

            var generalLedgerAccount2 = new GeneralLedgerAccountBuilder(this.DatabaseSession)
                .WithAccountNumber("0002")
                .WithName("bankAccount 2")
                .WithBalanceSheetAccount(true)
                .WithSide(new DebitCreditConstants(this.DatabaseSession).Debit)
                .WithGeneralLedgerAccountType(new GeneralLedgerAccountTypeBuilder(this.DatabaseSession).WithDescription("accountType").Build())
                .WithGeneralLedgerAccountGroup(new GeneralLedgerAccountGroupBuilder(this.DatabaseSession).WithDescription("accountGroup").Build())
                .Build();

            var internalOrganisationGlAccount2 = new OrganisationGlAccountBuilder(this.DatabaseSession)
                .WithInternalOrganisation(internalOrganisation)
                .WithGeneralLedgerAccount(generalLedgerAccount2)
                .Build();

            var journal = new JournalBuilder(this.DatabaseSession)
                .WithDescription("description")
                .WithContraAccount(internalOrganisationGlAccount1)
                .WithInternalOrganisation(new InternalOrganisations(this.DatabaseSession).FindBy(InternalOrganisations.Meta.Name, "internalOrganisation"))
                .WithJournalType(new JournalTypes(this.DatabaseSession).Bank)
                .Build();

            this.DatabaseSession.Derive(true);

            Assert.AreEqual(generalLedgerAccount1, journal.PreviousContraAccount);

            journal.AddJournalEntry(new JournalEntryBuilder(this.DatabaseSession)
                                        .WithJournalEntryDetail(new JournalEntryDetailBuilder(this.DatabaseSession)
                                                                    .WithAmount(1)
                                                                    .WithDebit(true)
                                                                    .WithGeneralLedgerAccount(internalOrganisationGlAccount1)
                                                                    .Build())
                                        .Build()); 
                                                                    
            journal.ContraAccount = internalOrganisationGlAccount2;

            Assert.AreEqual("description.ContraAccount, description.PreviousContraAccount are not equal", this.DatabaseSession.Derive().Errors[0].Message);
        }

        [Test]
        public void GivenJournal_WhenDeriving_ThenJournalTypeCanBeChangedWhenJournalIsNotUsedYet()
        {
            var internalOrganisation = new InternalOrganisations(this.DatabaseSession).FindBy(InternalOrganisations.Meta.Name, "internalOrganisation");

            var generalLedgerAccount1 = new GeneralLedgerAccountBuilder(this.DatabaseSession)
                .WithAccountNumber("0001")
                .WithName("bankAccount 1")
                .WithBalanceSheetAccount(true)
                .WithSide(new DebitCreditConstants(this.DatabaseSession).Debit)
                .WithGeneralLedgerAccountType(new GeneralLedgerAccountTypeBuilder(this.DatabaseSession).WithDescription("accountType").Build())
                .WithGeneralLedgerAccountGroup(new GeneralLedgerAccountGroupBuilder(this.DatabaseSession).WithDescription("accountGroup").Build())
                .Build();

            var internalOrganisationGlAccount = new OrganisationGlAccountBuilder(this.DatabaseSession)
                .WithInternalOrganisation(internalOrganisation)
                .WithGeneralLedgerAccount(generalLedgerAccount1)
                .Build();

            var journal = new JournalBuilder(this.DatabaseSession)
                .WithDescription("description")
                .WithContraAccount(internalOrganisationGlAccount)
                .WithInternalOrganisation(new InternalOrganisations(this.DatabaseSession).FindBy(InternalOrganisations.Meta.Name, "internalOrganisation"))
                .WithJournalType(new JournalTypes(this.DatabaseSession).Bank)
                .Build();

            this.DatabaseSession.Derive(true);

            Assert.AreEqual(generalLedgerAccount1, journal.PreviousContraAccount);

            journal.JournalType = new JournalTypes(this.DatabaseSession).Cash;

            this.DatabaseSession.Derive(true);

            Assert.AreEqual(new JournalTypes(this.DatabaseSession).Cash, journal.PreviousJournalType);
        }

        [Test]
        public void GivenJournal_WhenDeriving_ThenJournalTypeCanNotBeChangedWhenJournalEntriesArePresent()
        {
            var internalOrganisation = new InternalOrganisations(this.DatabaseSession).FindBy(InternalOrganisations.Meta.Name, "internalOrganisation");

            var generalLedgerAccount1 = new GeneralLedgerAccountBuilder(this.DatabaseSession)
                .WithAccountNumber("0001")
                .WithName("bankAccount 1")
                .WithBalanceSheetAccount(true)
                .WithSide(new DebitCreditConstants(this.DatabaseSession).Debit)
                .WithGeneralLedgerAccountType(new GeneralLedgerAccountTypeBuilder(this.DatabaseSession).WithDescription("accountType").Build())
                .WithGeneralLedgerAccountGroup(new GeneralLedgerAccountGroupBuilder(this.DatabaseSession).WithDescription("accountGroup").Build())
                .Build();

            var internalOrganisationGlAccount = new OrganisationGlAccountBuilder(this.DatabaseSession)
                .WithInternalOrganisation(internalOrganisation)
                .WithGeneralLedgerAccount(generalLedgerAccount1)
                .Build();

            var journal = new JournalBuilder(this.DatabaseSession)
                .WithDescription("description")
                .WithContraAccount(internalOrganisationGlAccount)
                .WithInternalOrganisation(new InternalOrganisations(this.DatabaseSession).FindBy(InternalOrganisations.Meta.Name, "internalOrganisation"))
                .WithJournalType(new JournalTypes(this.DatabaseSession).Bank)
                .Build();

            this.DatabaseSession.Derive(true);

            Assert.AreEqual(generalLedgerAccount1, journal.PreviousContraAccount);

            journal.AddJournalEntry(new JournalEntryBuilder(this.DatabaseSession)
                                        .WithJournalEntryDetail(new JournalEntryDetailBuilder(this.DatabaseSession)
                                                                    .WithAmount(1)
                                                                    .WithDebit(true)
                                                                    .WithGeneralLedgerAccount(internalOrganisationGlAccount)
                                                                    .Build())
                                        .Build());

            journal.JournalType = new JournalTypes(this.DatabaseSession).Cash;

            Assert.AreEqual("description.JournalType, description.PreviousJournalType are not equal", this.DatabaseSession.Derive().Errors[0].Message);
        }
    }
}
