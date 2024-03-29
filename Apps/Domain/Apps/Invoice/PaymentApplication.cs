// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PaymentApplication.cs" company="Allors bvba">
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
    using Allors.Domain;

    using Resources;

    public partial class PaymentApplication
    {
        protected override void AppsPrepareDerivation(IDerivation derivation)
        {
            base.AppsPrepareDerivation(derivation);

            // TODO:
            if (derivation.ChangeSet.Associations.Contains(this.Id))
            {
                var receipt = this.PaymentWherePaymentApplication as Receipt;
                if (receipt != null)
                {
                    derivation.AddDependency(receipt, this);
                }

                if (this.ExistInvoiceItem)
                {
                    derivation.AddDependency((Derivable)this.InvoiceItem, this);
                }

                if (this.ExistInvoice)
                {
                    derivation.AddDependency((Derivable)this.Invoice, this);
                }
            }
        }

        protected override void AppsDerive(IDerivation derivation)
        {
            

            derivation.Log.AssertExistsAtMostOne(this, PaymentApplications.Meta.Invoice, PaymentApplications.Meta.InvoiceItem);
            derivation.Log.AssertExists(this, PaymentApplications.Meta.AmountApplied);

            if (this.ExistPaymentWherePaymentApplication && this.AmountApplied > this.PaymentWherePaymentApplication.Amount)
            {
                derivation.Log.AddError(this, PaymentApplications.Meta.AmountApplied, ErrorMessages.PaymentApplicationNotLargerThanPaymentAmount);
            }

            if (this.ExistInvoice && this.Invoice.AmountPaid > this.Invoice.TotalIncVat)
            {
                derivation.Log.AddError(this, PaymentApplications.Meta.AmountApplied, ErrorMessages.PaymentApplicationNotLargerThanInvoiceAmount);
            }

            if (this.ExistInvoiceItem && this.InvoiceItem.AmountPaid > this.InvoiceItem.TotalIncVat)
            {
                derivation.Log.AddError(this, PaymentApplications.Meta.AmountApplied, ErrorMessages.PaymentApplicationNotLargerThanInvoiceItemAmount);
            }

            var salesInvoice = this.Invoice as SalesInvoice;
            var purchaseInvoice = this.Invoice as PurchaseInvoice;
            var salesInvoiceItem = this.InvoiceItem as SalesInvoiceItem;
            var purchaseInvoiceItem  = this.InvoiceItem as PurchaseInvoiceItem;

            this.DisplayName = string.Format(
                "amount {0} applied to invoice {1}{2}{3}",
                this.ExistAmountApplied ? this.AmountApplied : 0,
                this.Invoice != null ? this.Invoice.ComposeDisplayName() : null,
                salesInvoiceItem != null ? salesInvoiceItem.SalesInvoiceWhereSalesInvoiceItem.ComposeDisplayName() : null,
                purchaseInvoiceItem != null ? purchaseInvoiceItem.PurchaseInvoiceItemType.Name : null);

            if (salesInvoice != null)
            {
                salesInvoice.Derive(derivation);
            }

            if (purchaseInvoice != null)
            {
                purchaseInvoice.Derive(derivation);
            }

            if (salesInvoiceItem != null)
            {
                salesInvoiceItem.SalesInvoiceWhereSalesInvoiceItem.Derive(derivation);
            }

            if (purchaseInvoiceItem != null)
            {
                purchaseInvoiceItem.PurchaseInvoiceItemType.Derive(derivation);
            }
        }
    }
}