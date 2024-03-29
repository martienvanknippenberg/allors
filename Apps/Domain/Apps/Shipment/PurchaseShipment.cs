// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PurchaseShipment.cs" company="Allors bvba">
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
    using System.Collections.Generic;

    
    using Allors.Domain;

    public partial class PurchaseShipment
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

        public bool CanEdit
        {
            get
            {
                if (this.CurrentObjectState.Equals(new PurchaseShipmentObjectStates(this.DatabaseSession).Created))
                {
                    return true;
                }

                return false;
            }
        }

        public string DateString
        {
            get { return this.EstimatedArrivalDate.ToShortDateString(); }
        }

        public void DeriveTemplate(IDerivation derivation)
        {
            var internalOrganisation = this.ShipToParty as Domain.InternalOrganisation;
            if (internalOrganisation != null && internalOrganisation.PurchaseShipmentTemplates.Count > 0)
            {
                this.PrintContent =
                    internalOrganisation.PurchaseShipmentTemplates.First.Apply(new Dictionary<string, object> { { "this", this } });
            }
        }

        protected override void AppsOnPostBuild(IObjectBuilder builder)
        {
            base.AppsOnPostBuild(builder);

            if (!this.ExistCurrentObjectState)
            {
                this.CurrentObjectState = new PurchaseShipmentObjectStates(this.Session).Created;
            }

            if (!this.ExistShipToParty)
            {
                this.ShipToParty = Domain.Singleton.Instance(this.Session).DefaultInternalOrganisation;
            }

            if (!this.ExistFacility && this.ExistShipToParty)
            {
                var toParty = this.ShipToParty as Domain.InternalOrganisation;
                if (toParty != null)
                {
                    this.Facility = toParty.DefaultFacility;
                }
            }

            if (!this.ExistShipmentNumber && this.ExistShipToParty)
            {
                var internalOrganisation = this.ShipToParty as Domain.InternalOrganisation;

                if (internalOrganisation != null)
                {
                    this.ShipmentNumber = internalOrganisation.DeriveNextShipmentNumber();
                }
            }

            if (!this.ExistEstimatedArrivalDate)
            {
                this.EstimatedArrivalDate = DateTime.Now.Date;
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
                foreach (ShipmentItem shipmentItem in this.ShipmentItems)
                {
                    if (shipmentItem.ShipmentReceiptWhereShipmentItem.ExistInventoryItem)
                    {
                        derivation.AddDependency(shipmentItem.ShipmentReceiptWhereShipmentItem.InventoryItem, this);
                    }
                }
            }
        }

        protected override void AppsDerive(IDerivation derivation)
        {
            

            derivation.Log.AssertExists(this, Shipments.Meta.ShipmentNumber);
            derivation.Log.AssertExists(this, Shipments.Meta.ShipToParty);
            derivation.Log.AssertExists(this, Shipments.Meta.ShipFromParty);
            derivation.Log.AssertExists(this, PurchaseShipments.Meta.Facility);

            if (!this.ExistShipToAddress && this.ExistShipToParty)
            {
                this.ShipToAddress = this.ShipToParty.ShippingAddress;
            }

            if (!this.ExistShipFromAddress && this.ExistShipFromParty)
            {
                this.ShipFromAddress = this.ShipFromParty.ShippingAddress;
            }

            this.DisplayName = string.Format(
                "{0} from {1}",
                this.ExistShipmentNumber ? this.ShipmentNumber : null,
                this.ExistShipFromParty ? this.ShipFromParty.DeriveDisplayName() : null);

            var characterBoundaryText = this.ExistShipFromParty ? this.ShipFromParty.DeriveSearchDataCharacterBoundaryText() : null;

            var wordBoundaryText = string.Format(
                "{0} {1}",
                this.ExistShipmentNumber ? this.ShipmentNumber : null,
                this.ExistShipFromParty ? this.ShipFromParty.DeriveSearchDataWordBoundaryText() : null);

            this.SearchData.CharacterBoundaryText = characterBoundaryText;
            this.SearchData.WordBoundaryText = wordBoundaryText;

            if (this.ExistCurrentObjectState && 
                this.CurrentObjectState.UniqueId.Equals(PurchaseShipmentObjectStates.CompletedId) &&
                !this.CurrentObjectState.Equals(this.PreviousObjectState))
            {

                this.AppsDeriveOrderItemQuantityReceived(derivation);
            }

            this.DeriveCurrentObjectState(derivation);
            this.PreviousObjectState = this.CurrentObjectState;

            foreach (ShipmentItem shipmentItem in this.ShipmentItems)
            {
                shipmentItem.Derive(derivation);
            }

            this.DeriveTemplate(derivation);
        }

        protected override void AppsApplySecurityOnDerive()
        {
            this.RemoveSecurityTokens();
            this.AddSecurityToken(Domain.Singleton.Instance(this.Session).AdministratorSecurityToken);

            if (this.ExistShipToParty)
            {
                this.AddSecurityToken(this.ShipToParty.OwnerSecurityToken);
            }
        }

        private void AppsDeriveCurrentObjectState(IDerivation derivation)
        {
            

            if (this.ExistCurrentObjectState && !this.CurrentObjectState.Equals(this.PreviousObjectState))
            {
                var currentStatus = new PurchaseShipmentStatusBuilder(this.Session).WithPurchaseShipmentObjectState(this.CurrentObjectState).Build();
                this.AddShipmentStatus(currentStatus);
                this.CurrentShipmentStatus = currentStatus;
            }

            if (this.ExistCurrentObjectState)
            {
                this.CurrentObjectState.Process(this);
            }
        }

        private void AppsComplete()
        {
            this.CurrentObjectState = new PurchaseShipmentObjectStates(Session).Completed;
        }

        private void AppsDeriveOrderItemQuantityReceived(IDerivation derivation)
        {
            foreach (ShipmentItem shipmentItem in this.ShipmentItems)
            {
                var receipt = shipmentItem.ShipmentReceiptWhereShipmentItem;
                var orderItem = (Allors.Domain.PurchaseOrderItem)receipt.OrderItem;

                if (orderItem != null)
                {
                    orderItem.DeriveCurrentShipmentStatus(derivation);
                    orderItem.PurchaseOrderWherePurchaseOrderItem.DeriveTemplate(derivation);
                }
            }
        }
    }
}