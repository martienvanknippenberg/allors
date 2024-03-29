// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesOrder.v.cs" company="Allors bvba">
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
    using System.Collections.Generic;

    using Allors.Domain;

    public partial class SalesOrder
    {
        public string SalesRepNames()
        {
            return this.AppsSalesRepNames;
        }

        public void CancelOrder()
        {
            this.AppsCancelOrder();
        }

        public void Confirm()
        {
            this.AppsConfirm();
        }

        public void Reject()
        {
            this.AppsReject();
        }

        public void Hold()
        {
            this.AppsHold();
        }

        public void Approve()
        {
            this.AppsApprove();
        }

        public void Continue()
        {
            this.AppsContinue();
        }

        public void Complete()
        {
            this.AppsComplete();
        }

        public void Finish()
        {
            this.AppsFinish();
        }

        public void TryShip(IDerivation derivation)
        {
            this.AppsTryShip(derivation);
        }

        public CustomerShipment Ship(IDerivation derivation, KeyValuePair<PostalAddress, Party> address)
        {
            return this.AppsShip(derivation, address);
        }

        public List<Shipment> Ship(IDerivation derivation)
        {
            return this.AppsShip(derivation);
        }

        public void DeriveCurrentShipmentStatus(IDerivation derivation)
        {
            this.AppsDeriveCurrentShipmentStatus(derivation);
        }

        public void DeriveCurrentOrderStatus(IDerivation derivation)
        {
            this.AppsDeriveCurrentOrderStatus(derivation);
        }

        public void DeriveCurrentPaymentStatus(IDerivation derivation)
        {
            this.AppsDeriveCurrentPaymentStatus(derivation);
        }

        public void DeriveLocale(IDerivation derivation)
        {
            this.AppsDeriveLocale(derivation);
        }

        public void DeriveOrderTotals(IDerivation derivation)
        {
            this.AppsDeriveOrderTotals(derivation);
        }

        public void DeriveTemplate(IDerivation derivation)
        {
            this.AppsDeriveTemplate(derivation);
        }

        public void DeriveCustomers(IDerivation derivation)
        {
            this.AppsDeriveCustomers(derivation);
        }

        public void DeriveSalesReps(IDerivation derivation)
        {
            this.AppsDeriveSalesReps(derivation);
        }

        public void DeriveOrderItems(IDerivation derivation)
        {
            this.AppsDeriveOrderItems(derivation);
        }
    }
}