// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesInvoiceItem.v.cs" company="Allors bvba">
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
    public partial class SalesInvoiceItem
    {
        public void Cancel(IDerivation derivation)
        {
            this.AppsCancel(derivation);
        }

        public void WriteOff(IDerivation derivation)
        {
            this.AppsWriteOff(derivation);
        }

        public void PaymentReceived(IDerivation derivation)
        {
            this.AppsPaymentReceived(derivation);
        }

        public void DeriveCurrentPaymentStatus(IDerivation derivation)
        {
            this.AppsDeriveCurrentPaymentStatus(derivation);
        }

        public void DeriveAmountPaid(IDerivation derivation)
        {
            this.AppsDeriveAmountPaid(derivation);
        }

        public void DeriveCurrentObjectState(IDerivation derivation)
        {
            this.AppsDeriveCurrentObjectState(derivation);
        }

        public void DerivePrices(IDerivation derivation, decimal quantityInvoiced = 0, decimal totalBasePrice = 0)
        {
            this.AppsDerivePrices(derivation, quantityInvoiced, totalBasePrice);
        }

        public void DeriveDisplayName()
        {
            this.AppsDeriveDisplayName();
        }

        public void DeriveVatRate(IDerivation derivation)
        {
            this.AppsDeriveVatRate(derivation);
        }

        public void DeriveVatRegime(IDerivation derivation)
        {
            this.AppsDeriveVatRegime(derivation);
        }

        public void DeriveMarkupAndProfitMargin(IDerivation derivation)
        {
            this.AppsDeriveMarkupAndProfitMargin(derivation);
        }

        public void DeriveSalesRep(IDerivation derivation)
        {
            this.AppsDeriveSalesRep(derivation);
        }
    }
}