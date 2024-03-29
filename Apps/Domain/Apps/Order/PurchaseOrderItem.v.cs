// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PurchaseOrderItem.v.cs" company="Allors bvba">
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

    public partial class PurchaseOrderItem
    {
        public void Confirm()
        {
            this.AppsConfirm();
        }

        public void Approve()
        {
            this.AppsApprove();
        }

        public void Cancel()
        {
            this.AppsCancel();
        }

        public void Reject()
        {
            this.AppsReject();
        }

        public void Complete()
        {
            this.AppsComplete();
        }

        public void Finish()
        {
            this.AppsFinish();
        }

        public void DeriveCurrentObjectState(IDerivation derivation)
        {
            this.AppsDeriveCurrentObjectState(derivation);
        }

        public void DeriveCurrentOrderStatus(IDerivation derivation)
        {
            this.AppsDeriveCurrentOrderStatus(derivation);
        }

        public void DeriveQuantities(IDerivation derivation)
        {
            this.AppsDeriveQuantities(derivation);
        }

        public void DerivePrices()
        {
            this.AppsDerivePrices();
        }

        public void DeriveIsValidOrderItem(IDerivation derivation)
        {
            this.AppsDeriveIsValidOrderItem(derivation);
        }

        public void DeriveDeliveryDate(IDerivation derivation)
        {
            this.AppsDeriveDeliveryDate(derivation);
        }

        public void DeriveCurrentShipmentStatus(IDerivation derivation)
        {
            this.AppsDeriveCurrentShipmentStatus(derivation);
        }

        public void DeriveDisplayName()
        {
            this.AppsDeriveDisplayName();
        }

        public string ComposeDisplayName()
        {
            return this.AppsComposeDisplayName();
        }
    }
}