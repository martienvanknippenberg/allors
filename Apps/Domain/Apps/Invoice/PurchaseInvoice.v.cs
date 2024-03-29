// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PurchaseInvoice.v.cs" company="Allors bvba">
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

    public partial class PurchaseInvoice
    {
        public void Approve(IDerivation derivation)
        {
            this.AppsSearchDataApprove(derivation);
        }

        public void Ready(IDerivation derivation)
        {
            this.AppsReady(derivation);
        }

        public void Cancel(IDerivation derivation)
        {
            this.AppsCancel(derivation);
        }

        public void DeriveInvoiceTotals()
        {
            this.AppsDeriveInvoiceTotals();
        }

        public void DeriveInvoiceItems(IDerivation derivation)
        {
            this.AppsDeriveInvoiceItems(derivation);
        }

        public void DeriveDisplayName()
        {
            this.AppsDeriveDisplayName();
        }

        public void DeriveSearchDataCharacterBoundaryText()
        {
            this.AppsDeriveSearchDataCharacterBoundaryText();
        }

        public void DeriveSearchDataWordBoundaryText()
        {
            this.AppsDeriveSearchDataWordBoundaryText();
        }

        public string ComposeDisplayName()
        {
            return this.AppsComposeDisplayName();
        }

        public string ComposeSearchDataCharacterBoundaryText()
        {
            return this.AppsComposeSearchDataCharacterBoundaryText();
        }

        public string ComposeSearchDataWordBoundaryText()
        {
            return this.AppsComposeSearchDataWordBoundaryText();
        }
    }
}