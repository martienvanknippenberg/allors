// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PurchaseInvoiceItem.cs" company="Allors bvba">
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
    using System.Text;

    using Allors.Domain;

    public partial class PurchaseInvoiceItem
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

        public decimal PriceAdjustment
        {
            get
            {
                return this.TotalSurcharge - this.TotalDiscount;
            }
        }

        public string GetTotalExVatAsCurrencyString
        {
            get
            {
                return DecimalExtensions.AsCurrencyString(this.TotalExVat, this.PurchaseInvoiceWherePurchaseInvoiceItem.CurrencyFormat);
            }
        }

        public string GetTotalIncVatAsCurrencyString
        {
            get
            {
                return DecimalExtensions.AsCurrencyString(this.TotalIncVat, this.PurchaseInvoiceWherePurchaseInvoiceItem.CurrencyFormat);
            }
        }

        public string GetNothingAsCurrencyString
        {
            get
            {
                const decimal Nothing = 0;
                return Nothing.AsCurrencyString(this.PurchaseInvoiceWherePurchaseInvoiceItem.CurrencyFormat);
            }
        }

        public string VatRateAsString
        {
            get
            {
                return this.DerivedVatRate.Rate.ToString("##.##");
            }
        }

        protected override void AppsPrepareDerivation(IDerivation derivation)
        {
            base.AppsPrepareDerivation(derivation);

            var invoice = this.PurchaseInvoiceWherePurchaseInvoiceItem;
            if (invoice != null)
            {
                // TODO:
                if (derivation.ChangeSet.Associations.Contains(this.Id))
                {
                    derivation.AddDependency(invoice, this);
                }
            }
        }

        protected override void AppsDerive(IDerivation derivation)
        {
            

            derivation.Log.AssertExists(this, PurchaseInvoiceItems.Meta.Part);
            derivation.Log.AssertExists(this, PurchaseInvoiceItems.Meta.Quantity);
            derivation.Log.AssertExists(this, PurchaseInvoiceItems.Meta.ActualUnitPrice);
            derivation.Log.AssertExists(this, PurchaseInvoiceItems.Meta.PurchaseInvoiceItemType);
        }

        private void AppsDerivePrices()
        {
            this.UnitBasePrice = 0;
            this.UnitDiscount = 0;
            this.UnitSurcharge = 0;

            if (this.ExistActualUnitPrice)
            {
                this.UnitBasePrice = this.ActualUnitPrice;
                this.CalculatedUnitPrice = this.ActualUnitPrice;

                var discountAdjustment = this.GetDiscountAdjustment();

                if (discountAdjustment != null)
                {
                    if (discountAdjustment.ExistPercentage)
                    {
                        this.UnitDiscount += decimal.Round(((this.UnitBasePrice * discountAdjustment.Percentage) / 100), 2);
                    }
                    else
                    {
                        this.UnitDiscount += discountAdjustment.Amount;
                    }
                }

                var surchargeAdjustment = this.GetSurchargeAdjustment();

                if (surchargeAdjustment != null)
                {
                    if (surchargeAdjustment.ExistPercentage)
                    {
                        this.UnitSurcharge += decimal.Round(((this.UnitBasePrice * surchargeAdjustment.Percentage) / 100), 2);
                    }
                    else
                    {
                        this.UnitSurcharge += surchargeAdjustment.Amount;
                    }
                }

                decimal vat = 0;

                if (this.ExistDerivedVatRate)
                {
                    var vatRate = this.DerivedVatRate.Rate;
                    var vatBase = this.UnitBasePrice - this.UnitDiscount + this.UnitSurcharge;
                    vat = decimal.Round(((vatBase * vatRate) / 100), 2);
                }

                this.UnitVat = vat;
                this.TotalBasePrice = this.UnitBasePrice * this.Quantity;
                this.TotalDiscount = this.UnitDiscount * this.Quantity;
                this.TotalSurcharge = this.UnitSurcharge * this.Quantity;
                this.CalculatedUnitPrice = this.UnitBasePrice - this.UnitDiscount + this.UnitSurcharge;
                this.TotalVat = this.UnitVat * this.Quantity;
                this.TotalExVat = this.CalculatedUnitPrice * this.Quantity;
                this.TotalIncVat = this.TotalExVat + this.TotalVat;
            }
        }

        private SurchargeAdjustment GetSurchargeAdjustment()
        {
            var surchargeAdjustment = this.ExistSurchargeAdjustment ? this.SurchargeAdjustment : null;
            if (surchargeAdjustment == null && this.ExistPurchaseInvoiceWherePurchaseInvoiceItem)
            {
                surchargeAdjustment = this.PurchaseInvoiceWherePurchaseInvoiceItem.ExistSurchargeAdjustment ? this.PurchaseInvoiceWherePurchaseInvoiceItem.SurchargeAdjustment : null;
            }

            return surchargeAdjustment;
        }

        private DiscountAdjustment GetDiscountAdjustment()
        {
            var discountAdjustment = this.ExistDiscountAdjustment ? this.DiscountAdjustment : null;
            if (discountAdjustment == null && this.ExistPurchaseInvoiceWherePurchaseInvoiceItem)
            {
                discountAdjustment = this.PurchaseInvoiceWherePurchaseInvoiceItem.ExistDiscountAdjustment ? this.PurchaseInvoiceWherePurchaseInvoiceItem.DiscountAdjustment : null;
            }

            return discountAdjustment;
        }

        private void AppsDeriveDisplayName()
        {
            var uiText = new StringBuilder();

            if (this.ExistQuantity)
            {
                uiText.Append(this.Quantity);
                uiText.Append(" ");
            }

            if (this.ExistPart)
            {
                uiText.Append(this.Part.ComposeDisplayName());
            }

            if (this.ExistTotalExVat)
            {
                uiText.Append(", Total: ");
                uiText.Append(string.Format("{0:N2}", this.TotalExVat));
            }

            this.DisplayName = uiText.ToString();
        }
    }
}