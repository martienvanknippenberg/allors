// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PurchaseOrderItem.cs" company="Allors bvba">
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

    

    public partial class PurchaseOrderItem
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

        public string GetActualUnitBasePriceAsCurrencyString
        {
            get
            {
                return this.ExistActualUnitPrice ? DecimalExtensions.AsCurrencyString(this.ActualUnitPrice, this.PurchaseOrderWherePurchaseOrderItem.CurrencyFormat) : string.Empty;
            }
        }

        public string GetUnitBasePriceAsCurrencyString
        {
            get
            {
                return DecimalExtensions.AsCurrencyString(this.UnitBasePrice, this.PurchaseOrderWherePurchaseOrderItem.CurrencyFormat);
            }
        }

        public string GetTotalExVatAsCurrencyString
        {
            get
            {
                return DecimalExtensions.AsCurrencyString(this.TotalExVat, this.PurchaseOrderWherePurchaseOrderItem.CurrencyFormat);
            }
        }

        public string GetNothingAsCurrencyString
        {
            get
            {
                const decimal Nothing = 0;
                return Nothing.AsCurrencyString(this.PurchaseOrderWherePurchaseOrderItem.CurrencyFormat);
            }
        }

        public string SupplierReference
        {
            get
            {
                Extent<SupplierOffering> offerings = null;

                if (this.ExistProduct)
                {
                    offerings = this.Product.SupplierOfferingsWhereProduct;
                }

                if (this.ExistPart)
                {
                    offerings = this.Part.SupplierOfferingsWherePart;
                }

                if (offerings != null)
                {
                    offerings.Filter.AddEquals(SupplierOfferings.Meta.Supplier, this.PurchaseOrderWherePurchaseOrderItem.TakenViaSupplier);
                    foreach (SupplierOffering offering in offerings)
                    {
                        if (offering.FromDate <= this.PurchaseOrderWherePurchaseOrderItem.OrderDate &&
                            (!offering.ExistThroughDate || offering.ThroughDate >= this.PurchaseOrderWherePurchaseOrderItem.OrderDate))
                        {
                            return offering.ReferenceNumber;
                        }
                    }
                }

                return string.Empty;
            }
        }

        protected override void AppsOnPostBuild(IObjectBuilder builder)
        {
            base.AppsOnPostBuild(builder);

            if (!this.ExistCurrentObjectState)
            {
                this.CurrentObjectState = new PurchaseOrderItemObjectStates(this.Session).Created;
            }
        }

        protected override void AppsPrepareDerivation(IDerivation derivation)
        {
            base.AppsPrepareDerivation(derivation);

            // TODO:
            if (derivation.ChangeSet.Associations.Contains(this.Id))
            {
                if (this.ExistPurchaseOrderWherePurchaseOrderItem)
                {
                    derivation.AddDependency(this.PurchaseOrderWherePurchaseOrderItem, this);
                }
            }
        }

        protected override void AppsDerive(IDerivation derivation)
        {
            

            derivation.Log.AssertExists(this, PurchaseOrderItems.Meta.QuantityOrdered);
            derivation.Log.AssertAtLeastOne(this, PurchaseOrderItems.Meta.Product, PurchaseOrderItems.Meta.Part);
            derivation.Log.AssertExistsAtMostOne(this, PurchaseOrderItems.Meta.Product, PurchaseOrderItems.Meta.Part);

            this.DeriveIsValidOrderItem(derivation);

            this.DeriveCurrentObjectState(derivation);

            this.DeriveDisplayName();
        }

        private void AppsDeriveDisplayName()
        {
            this.DisplayName = this.ComposeDisplayName();
        }

        private string AppsComposeDisplayName()
        {
            var uiText = new StringBuilder();

            if (this.ExistQuantityOrdered)
            {
                uiText.Append(this.QuantityOrdered);
                uiText.Append(" ");
            }

            if (this.ExistPart)
            {
                uiText.Append(this.Part.ComposeDisplayName());
            }

            if (this.ExistTotalExVat)
            {
                uiText.Append(", Total ex. VAT: ");
                uiText.Append(string.Format("{0:N2}", this.TotalExVat));
            }

            return uiText.ToString();
        }

        private void AppsDeriveIsValidOrderItem(IDerivation derivation)
        {
            if (this.ExistPurchaseOrderWherePurchaseOrderItem)
            {
                this.PurchaseOrderWherePurchaseOrderItem.RemoveValidOrderItem(this);

                if (!this.CurrentObjectState.Equals(new PurchaseOrderItemObjectStates(this.Session).Cancelled)
                    && !this.CurrentObjectState.Equals(new PurchaseOrderItemObjectStates(this.Session).Rejected))
                {
                    this.PurchaseOrderWherePurchaseOrderItem.AddValidOrderItem(this);
                }
            }
        }

        private void AppsDeriveCurrentObjectState(IDerivation derivation)
        {
            if (this.ExistOrderWhereValidOrderItem)
            {
                var order = this.PurchaseOrderWherePurchaseOrderItem;

                if (order.CurrentObjectState.Equals(new PurchaseOrderObjectStates(this.Session).Cancelled))
                {
                    this.Cancel();
                }

                if (order.CurrentObjectState.Equals(new PurchaseOrderObjectStates(this.Session).InProcess))
                {
                    if (this.CurrentObjectState.Equals(new PurchaseOrderItemObjectStates(Session).Created))
                    {
                        this.Confirm();
                    }
                }

                if (order.CurrentObjectState.Equals(new PurchaseOrderObjectStates(this.Session).Completed))
                {
                    this.Complete();
                }

                if (order.CurrentObjectState.Equals(new PurchaseOrderObjectStates(this.Session).Finished))
                {
                    this.Finish();
                }
            }

            if (this.ExistCurrentObjectState && !this.CurrentObjectState.Equals(this.PreviousObjectState))
            {
                var currentStatus = new PurchaseOrderItemStatusBuilder(this.Session).WithPurchaseOrderItemObjectState(this.CurrentObjectState).Build();
                this.AddOrderItemStatus(currentStatus);
                this.CurrentOrderItemStatus = currentStatus;
                this.PreviousObjectState = this.CurrentObjectState;
            }

            if (this.CurrentObjectState.Equals(new PurchaseOrderItemObjectStates(this.Session).InProcess))
            {
                this.DeriveQuantities(derivation);

                this.PreviousQuantity = this.QuantityOrdered;
            }

            if (this.CurrentObjectState.Equals(new PurchaseOrderItemObjectStates(this.Session).Cancelled) ||
                this.CurrentObjectState.Equals(new PurchaseOrderItemObjectStates(this.Session).Rejected))
            {
                this.DeriveQuantities(derivation);
            }

            if (this.ExistCurrentObjectState)
            {
                this.CurrentObjectState.Process(this);
            }
        }

        private void AppsDeriveCurrentOrderStatus(IDerivation derivation)
        {
            if (this.ExistCurrentShipmentStatus && this.CurrentShipmentStatus.PurchaseOrderItemObjectState.Equals(new PurchaseOrderItemObjectStates(this.Session).PartiallyReceived))
            {
                this.CurrentObjectState = new PurchaseOrderItemObjectStates(Session).PartiallyReceived;
                this.DeriveCurrentObjectState(derivation);
            }

            if (this.ExistCurrentShipmentStatus && this.CurrentShipmentStatus.PurchaseOrderItemObjectState.Equals(new PurchaseOrderItemObjectStates(this.Session).Received))
            {
                this.CurrentObjectState = new PurchaseOrderItemObjectStates(Session).Completed;
                this.DeriveCurrentObjectState(derivation);
            }
        }

        private void AppsConfirm()
        {
            this.CurrentObjectState = new PurchaseOrderItemObjectStates(Session).InProcess;
        }

        private void AppsApprove()
        {
            this.CurrentObjectState = new PurchaseOrderItemObjectStates(Session).InProcess;
        }

        private void AppsCancel()
        {
            this.CurrentObjectState = new PurchaseOrderItemObjectStates(Session).Cancelled;
        }

        private void AppsReject()
        {
            this.CurrentObjectState = new PurchaseOrderItemObjectStates(Session).Rejected;
        }

        private void AppsComplete()
        {
            this.CurrentObjectState = new PurchaseOrderItemObjectStates(Session).Completed;
        }

        private void AppsFinish()
        {
            this.CurrentObjectState = new PurchaseOrderItemObjectStates(Session).Finished;
        }

        private void AppsDeriveDeliveryDate(IDerivation derivation)
        {
            if (this.ExistAssignedDeliveryDate)
            {
                this.DeliveryDate = this.AssignedDeliveryDate;
            }
            else if (this.PurchaseOrderWherePurchaseOrderItem.ExistDeliveryDate)
            {
                this.DeliveryDate = this.PurchaseOrderWherePurchaseOrderItem.DeliveryDate;
            }            
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
            }
            else
            {
                var order = this.PurchaseOrderWherePurchaseOrderItem;
                var productPurchasePrice = new SupplierOfferings(this.Session).PurchasePrice(order.TakenViaSupplier, order.OrderDate, this.Product, this.Part);
                this.UnitBasePrice = productPurchasePrice != null ? productPurchasePrice.Price : 0M;
            }

            this.UnitVat = 0;
            this.TotalBasePrice = this.UnitBasePrice * this.QuantityOrdered;
            this.TotalDiscount = this.UnitDiscount * this.QuantityOrdered;
            this.TotalSurcharge = this.UnitSurcharge * this.QuantityOrdered;
            this.CalculatedUnitPrice = this.UnitBasePrice - this.UnitDiscount + this.UnitSurcharge;
            this.TotalVat = 0;
            this.TotalExVat = this.CalculatedUnitPrice * this.QuantityOrdered;
            this.TotalIncVat = this.TotalExVat + this.TotalVat;

            this.DeriveDisplayName();
        }

        private void AppsDeriveCurrentShipmentStatus(IDerivation derivation)
        {
            var quantityReceived = 0M;
            foreach (ShipmentReceipt shipmentReceipt in this.ShipmentReceiptsWhereOrderItem)
            {
                quantityReceived += shipmentReceipt.QuantityAccepted;
            }

            this.QuantityReceived = quantityReceived;

            if (quantityReceived > 0)
            {
                if (quantityReceived < this.QuantityOrdered)
                {
                    this.CurrentShipmentStatus = new PurchaseOrderItemStatusBuilder(this.Session)
                        .WithPurchaseOrderItemObjectState(new PurchaseOrderItemObjectStates(Session).PartiallyReceived)
                        .Build();
                }
                else
                {
                    this.CurrentShipmentStatus = new PurchaseOrderItemStatusBuilder(this.Session)
                        .WithPurchaseOrderItemObjectState(new PurchaseOrderItemObjectStates(Session).Received)
                        .Build();
                }

                this.AddShipmentStatus(CurrentShipmentStatus);
            }

            this.DeriveCurrentOrderStatus(derivation);

            if (this.ExistPurchaseOrderWherePurchaseOrderItem)
            {
                this.PurchaseOrderWherePurchaseOrderItem.DeriveCurrentShipmentStatus(derivation);
            }
        }

        private void AppsDeriveQuantities(IDerivation derivation)
        {
            NonSerializedInventoryItem inventoryItem = null;

            if (this.ExistProduct)
            {
                var good = this.Product as Good;
                if (good != null)
                {
                    var inventoryItems = good.InventoryItemsWhereGood;
                    inventoryItems.Filter.AddEquals(InventoryItems.Meta.Facility, this.PurchaseOrderWherePurchaseOrderItem.Facility);
                    inventoryItem = inventoryItems.First as NonSerializedInventoryItem;
                }
            }

            if (this.ExistPart)
            {
                var inventoryItems = this.Part.InventoryItemsWherePart;
                inventoryItems.Filter.AddEquals(InventoryItems.Meta.Facility, this.PurchaseOrderWherePurchaseOrderItem.Facility);
                inventoryItem = inventoryItems.First as NonSerializedInventoryItem;
            }

            if (this.CurrentObjectState.Equals(new PurchaseOrderItemObjectStates(this.Session).InProcess))
            {
                if (!this.ExistPreviousQuantity || !this.QuantityOrdered.Equals(this.PreviousQuantity))
                {
                    if (inventoryItem != null)
                    {
                        inventoryItem.Derive(derivation);
                    }
                }
            }

            if (this.CurrentObjectState.Equals(new PurchaseOrderItemObjectStates(this.Session).Cancelled) ||
                this.CurrentObjectState.Equals(new PurchaseOrderItemObjectStates(this.Session).Rejected))
            {
                if (inventoryItem != null)
                {
                    inventoryItem.Derive(derivation);
                }
            }
        }
    }
}