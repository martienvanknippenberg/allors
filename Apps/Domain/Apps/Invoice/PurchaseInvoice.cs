// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PurchaseInvoice.cs" company="Allors bvba">
//   Copyright 2002-2012 Allors bvba.
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
    using System.Globalization;

    using Allors.Domain;

    using Resources;

    public partial class PurchaseInvoice
    {
        ObjectState Transitional.PreviousObjectState
        {
            get
            {
                return this.PreviousObjectState;
            }
        }

        ObjectState Transitional.CurrentObjectState
        {
            get
            {
                return this.CurrentObjectState;
            }
        }

        public NumberFormatInfo CurrencyFormat
        {
            get
            {
                var cultureInfo = new CultureInfo(this.Locale.Name, false);
                var currencyFormat = (NumberFormatInfo)cultureInfo.NumberFormat.Clone();
                currencyFormat.CurrencySymbol = this.CustomerCurrency.Symbol;
                return currencyFormat;
            }
        }

        public bool CanEdit
        {
            get
            {
                return true;
            }
        }

        public string GetTotalFeeAsCurrencyString
        {
            get
            {
                return DecimalExtensions.AsCurrencyString(this.TotalFee, this.CurrencyFormat);
            }
        }

        public string GetTotalShippingAndHandlingAsCurrencyString
        {
            get
            {
                return DecimalExtensions.AsCurrencyString(this.TotalShippingAndHandling, this.CurrencyFormat);
            }
        }

        public string GetTotalExVatAsCurrencyString
        {
            get
            {
                return DecimalExtensions.AsCurrencyString(this.TotalExVat, this.CurrencyFormat);
            }
        }

        public string GetTotalVatAsCurrencyString
        {
            get
            {
                return DecimalExtensions.AsCurrencyString(this.TotalVat, this.CurrencyFormat);
            }
        }

        public string GetTotalIncVatAsCurrencyString
        {
            get
            {
                return DecimalExtensions.AsCurrencyString(this.TotalIncVat, this.CurrencyFormat);
            }
        }

        public string GetSubTotalAsCurrencyString
        {
            get
            {
                var subtotal = this.TotalBasePrice - this.TotalDiscount + this.TotalSurcharge;
                return DecimalExtensions.AsCurrencyString(subtotal, this.CurrencyFormat);
            }
        }

        public bool HasDiscount
        {
            get
            {
                return this.TotalDiscount > 0;
            }
        }

        public bool HasSurcharge
        {
            get
            {
                return this.TotalSurcharge > 0;
            }
        }

        public bool HasFee
        {
            get
            {
                return this.TotalFee > 0;
            }
        }

        public bool HasShippingAndHandling
        {
            get
            {
                return this.TotalShippingAndHandling > 0;
            }
        }

        public string GetNothingAsCurrencyString
        {
            get
            {
                return DecimalExtensions.AsCurrencyString(0, this.CurrencyFormat);
            }
        }

        public InvoiceItem[] InvoiceItems
        {
            get
            {
                return this.PurchaseInvoiceItems;
            }
        }

        public string ShortInvoiceDateString
        {
            get { return this.InvoiceDate.ToShortDateString(); }
        }

        protected override void AppsOnPostBuild(IObjectBuilder builder)
        {
            base.AppsOnPostBuild(builder);

            if (!this.ExistCurrentObjectState)
            {
                this.CurrentObjectState = new PurchaseInvoiceObjectStates(this.Session).InProcess;
            }

            if (!this.ExistInvoiceNumber && this.ExistBilledToInternalOrganisation)
            {
                this.InvoiceNumber = this.BilledToInternalOrganisation.DeriveNextPurchaseInvoiceNumber();
            }

            if (!this.ExistInvoiceDate)
            {
                this.InvoiceDate = DateTime.Now;
            }

            if (!this.ExistEntryDate)
            {
                this.EntryDate = DateTime.Now;
            }

            if (!this.ExistTotalBasePrice)
            {
                this.TotalBasePrice = 0;
            }

            if (!this.ExistTotalBasePriceCustomerCurrency)
            {
                this.TotalBasePriceCustomerCurrency = 0;
            }

            if (!this.ExistTotalDiscount)
            {
                this.TotalDiscount = 0;
            }

            if (!this.ExistTotalDiscountCustomerCurrency)
            {
                this.TotalDiscountCustomerCurrency = 0;
            }

            if (!this.ExistTotalExVat)
            {
                this.TotalExVat = 0;
            }

            if (!this.ExistTotalExVatCustomerCurrency)
            {
                this.TotalExVatCustomerCurrency = 0;
            }

            if (!this.ExistTotalFee)
            {
                this.TotalFee = 0;
            }

            if (!this.ExistTotalFeeCustomerCurrency)
            {
                this.TotalFeeCustomerCurrency = 0;
            }

            if (!this.ExistTotalIncVat)
            {
                this.TotalIncVat = 0;
            }

            if (!this.ExistTotalIncVatCustomerCurrency)
            {
                this.TotalIncVatCustomerCurrency = 0;
            }

            if (!this.ExistTotalShippingAndHandling)
            {
                this.TotalShippingAndHandling = 0;
            }

            if (!this.ExistTotalShippingAndHandlingCustomerCurrency)
            {
                this.TotalShippingAndHandlingCustomerCurrency = 0;
            }

            if (!this.ExistTotalSurcharge)
            {
                this.TotalSurcharge = 0;
            }

            if (!this.ExistTotalSurchargeCustomerCurrency)
            {
                this.TotalSurchargeCustomerCurrency = 0;
            }

            if (!this.ExistTotalVat)
            {
                this.TotalVat = 0;
            }

            if (!this.ExistTotalVatCustomerCurrency)
            {
                this.TotalVatCustomerCurrency = 0;
            }

            if (!this.ExistSearchData)
            {
                this.SearchData = new SearchDataBuilder(this.Session).Build();
            }
        }

        protected override void AppsPrepareDerivation(IDerivation derivation)
        {
            base.AppsPrepareDerivation(derivation);

            // TODO:
            if (derivation.ChangeSet.Associations.Contains(this.Id))
            {
                if (this.ExistBilledToInternalOrganisation)
                {
                    derivation.AddDependency(this, this.BilledToInternalOrganisation);
                }
            }

            if (this.ExistBilledFromParty)
            {
                var supplier = this.BilledFromParty as Organisation;
                if (supplier != null)
                {
                    var supplierRelationships = supplier.SupplierRelationshipsWhereSupplier;
                    supplierRelationships.Filter.AddEquals(SupplierRelationships.Meta.InternalOrganisation, this.BilledToInternalOrganisation);

                    foreach (SupplierRelationship supplierRelationship in supplierRelationships)
                    {
                        if (supplierRelationship.FromDate <= DateTime.Now && (!supplierRelationship.ExistThroughDate || supplierRelationship.ThroughDate >= DateTime.Now))
                        {
                            derivation.AddDependency(this, supplierRelationship);
                        }
                    }
                }
            }
        }

        protected override void AppsDerive(IDerivation derivation)
        {
            

            derivation.Log.AssertExists(this, PurchaseInvoices.Meta.InvoiceNumber);
            derivation.Log.AssertExists(this, PurchaseInvoices.Meta.InvoiceDate);
            derivation.Log.AssertExists(this, PurchaseInvoices.Meta.PurchaseInvoiceType);
            derivation.Log.AssertExists(this, PurchaseInvoices.Meta.BilledToInternalOrganisation);
            derivation.Log.AssertExists(this, PurchaseInvoices.Meta.BilledFromParty);

            Organisation supplier = this.BilledFromParty as Organisation;
            if (supplier != null && this.ExistBilledToInternalOrganisation)
            {
                if (!this.BilledToInternalOrganisation.Equals(supplier.InternalOrganisationWhereSupplier))
                {
                    derivation.Log.AddError(this, PurchaseInvoices.Meta.BilledFromParty, ErrorMessages.PartyIsNotASupplier);
                }
            }

            if (this.ExistCurrentObjectState && !this.CurrentObjectState.Equals(this.PreviousObjectState))
            {
                this.CurrentObjectState.Process(this);

                var currentStatus = new PurchaseInvoiceStatusBuilder(this.Session).WithPurchaseInvoiceObjectState(this.CurrentObjectState).Build();
                this.AddInvoiceStatus(currentStatus);
                this.CurrentInvoiceStatus = currentStatus;
            }

            this.DeriveDisplayName();
            this.DeriveSearchDataCharacterBoundaryText();
            this.DeriveSearchDataWordBoundaryText();

            this.PreviousObjectState = this.CurrentObjectState;

            this.DeriveInvoiceItems(derivation);
            this.DeriveInvoiceTotals();
        }

        private void AppsDeriveInvoiceTotals()
        {
            if (this.ExistPurchaseInvoiceItems)
            {
                this.TotalBasePrice = 0;
                this.TotalDiscount = 0;
                this.TotalSurcharge = 0;
                this.TotalVat = 0;
                this.TotalExVat = 0;
                this.TotalIncVat = 0;

                foreach (PurchaseInvoiceItem item in this.PurchaseInvoiceItems)
                {
                    this.TotalBasePrice += item.TotalBasePrice;
                    this.TotalSurcharge += item.TotalSurcharge;
                    this.TotalSurcharge += item.TotalSurcharge;
                    this.TotalVat += item.TotalVat;
                    this.TotalExVat += item.TotalExVat;
                    this.TotalIncVat += item.TotalIncVat;
                }
            }
        }

        private void AppsSearchDataApprove(IDerivation derivation)
        {
            this.CurrentObjectState = new PurchaseInvoiceObjectStates(Session).Approved;
        }

        private void AppsReady(IDerivation derivation)
        {
            this.CurrentObjectState = new PurchaseInvoiceObjectStates(Session).ReadyForPosting;
        }

        private void AppsCancel(IDerivation derivation)
        {
            this.CurrentObjectState = new PurchaseInvoiceObjectStates(Session).Cancelled;
        }

        private void AppsDeriveInvoiceItems(IDerivation derivation)
        {
            foreach (PurchaseInvoiceItem purchaseInvoiceItem in this.PurchaseInvoiceItems)
            {
                purchaseInvoiceItem.DerivePrices();

                purchaseInvoiceItem.DeriveDisplayName();
            }
        }

        private void AppsDeriveDisplayName()
        {
            this.DisplayName = this.ComposeDisplayName();
        }

        private void AppsDeriveSearchDataCharacterBoundaryText()
        {
            this.SearchData.CharacterBoundaryText = this.AppsComposeSearchDataCharacterBoundaryText();
        }

        private void AppsDeriveSearchDataWordBoundaryText()
        {
            this.SearchData.WordBoundaryText = this.AppsComposeSearchDataWordBoundaryText();
        }

        private string AppsComposeDisplayName()
        {
            return string.Format(
                "{0} - {1} from {2}",
                this.ExistInvoiceNumber ? this.InvoiceNumber : null,
                this.ExistInvoiceDate ? this.InvoiceDate : DateTime.MinValue,
                this.ExistBilledFromParty ? this.BilledFromParty.DeriveDisplayName() : null);
        }

        private string AppsComposeSearchDataCharacterBoundaryText()
        {
            return this.ExistBilledFromParty ? this.BilledFromParty.DeriveSearchDataCharacterBoundaryText() : null;
        }

        private string AppsComposeSearchDataWordBoundaryText()
        {
            return string.Format(
                "{0} {1} {2}",
                this.ExistInvoiceNumber ? this.InvoiceNumber : null,
                this.ExistInvoiceDate ? this.InvoiceDate : DateTime.MinValue,
                this.ExistBilledFromParty ? this.BilledFromParty.DeriveSearchDataWordBoundaryText() : null);
        }
    }
}
