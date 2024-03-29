// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomerShipment.cs" company="Allors bvba">
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

    public partial class CustomerShipment
    {
        public bool CanEdit
        {
            get
            {
                if (this.CurrentObjectState.Equals(new CustomerShipmentObjectStates(this.DatabaseSession).Created) ||
                    this.CurrentObjectState.Equals(new CustomerShipmentObjectStates(this.DatabaseSession).Picked) ||
                    this.CurrentObjectState.Equals(new CustomerShipmentObjectStates(this.DatabaseSession).OnHold) ||
                    this.CurrentObjectState.Equals(new CustomerShipmentObjectStates(this.DatabaseSession).Packed))
                {
                    return true;
                }

                return false;
            }
        }

        public bool CanShip
        {
            get
            {
                if (!this.CurrentObjectState.Equals(new CustomerShipmentObjectStates(this.Session).Packed))
                {
                    return false;
                }

                if (this.PendingPickList != null)
                {
                    return false;
                }

                var picklists = this.ShipToParty.PickListsWhereShipToParty;
                picklists.Filter.AddEquals(PickLists.Meta.Store, this.Store);
                picklists.Filter.AddNot().AddEquals(PickLists.Meta.CurrentObjectState, new PickListObjectStates(this.Session).Picked);
                if (picklists.First != null)
                {
                    return false;
                }

                foreach (ShipmentItem shipmentItem in this.ShipmentItems)
                {
                    foreach (OrderShipment orderShipment in shipmentItem.OrderShipmentsWhereShipmentItem)
                    {
                        if (orderShipment.SalesOrderItem.SalesOrderWhereSalesOrderItem.CurrentObjectState.Equals(new Allors.Domain.SalesOrderObjectStates(this.Session).OnHold))
                        {
                            return false;
                        }
                    }
                }

                return true;
            }
        }

        public string ShortShipDateString
        {
            get { return this.EstimatedShipDate.ToShortDateString(); }
        }

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

        private PickList PendingPickList
        {
            get
            {
                var picklists = this.ShipToParty.PickListsWhereShipToParty;
                picklists.Filter.AddNot().AddExists(PickLists.Meta.Picker);

                PickList pendingPickList = null;
                foreach (PickList picklist in picklists)
                {
                    if (!picklist.IsNegativePickList)
                    {
                        pendingPickList = picklist;
                        break;
                    }
                }

                return pendingPickList;
            }
        }

        public void DeriveTemplate(IDerivation derivation)
        {
            if (this.ExistStore && this.Store.CustomerShipmentTemplates.Count > 0)
            {
                this.PrintContent = this.Store.CustomerShipmentTemplates.First.Apply(new Dictionary<string, object> { { "this", this } });
            }
        }

        protected override void AppsOnPostBuild(IObjectBuilder builder)
        {
            base.AppsOnPostBuild(builder);

            if (!this.ExistCurrentObjectState)
            {
                this.CurrentObjectState = new CustomerShipmentObjectStates(this.Session).Created;
            }

            if (!this.ExistReleasedManually)
            {
                this.ReleasedManually = false;
            }

            if (!this.ExistHeldManually)
            {
                this.HeldManually = false;
            }

            if (!this.ExistWithoutCharges)
            {
                this.WithoutCharges = false;
            }

            if (!this.ExistShipFromParty)
            {
                this.ShipFromParty = Domain.Singleton.Instance(this.Session).DefaultInternalOrganisation;
            }

            if (!this.ExistStore && this.ExistShipFromParty)
            {
                var organisation = this.ShipFromParty as Domain.InternalOrganisation;
                if (organisation != null && organisation.StoresWhereOwner.Count == 1)
                {
                    this.Store = organisation.StoresWhereOwner.First;
                }
            }

            if (!this.ExistEstimatedShipDate)
            {
                this.EstimatedShipDate = DateTime.Now.Date;
            }

            if (!this.ExistShipmentNumber && this.ExistStore)
            {
                this.ShipmentNumber = this.Store.DeriveNextShipmentNumber();
            }

            if (!this.ExistCarrier && this.ExistStore)
            {
                this.Carrier = this.Store.DefaultCarrier;
            }
        
            if (!this.ExistSearchData)
            {
                this.SearchData = new SearchDataBuilder(this.Session).Build();
            }
        }

        protected override void AppsPrepareDerivation(IDerivation derivation)
        {
            base.AppsPrepareDerivation(derivation);

            foreach (ShipmentItem shipmentItem in this.ShipmentItems)
            {
                derivation.AddDependency(this, shipmentItem);

                foreach (OrderShipment orderShipment in shipmentItem.OrderShipmentsWhereShipmentItem)
                {
                    if (orderShipment.ExistSalesOrderItem)
                    {
                        derivation.AddDependency(this, orderShipment.SalesOrderItem);
                    }

                    if (orderShipment.ExistPurchaseOrderItem)
                    {
                        derivation.AddDependency(this, orderShipment.PurchaseOrderItem);
                    }
                }
            }

            foreach (ShipmentPackage shipmentPackage in this.ShipmentPackages)
            {
                derivation.AddDependency(this, shipmentPackage);
            }                
        }

        protected override void AppsDerive(IDerivation derivation)
        {
            

            if (!this.ExistShipToAddress && this.ExistShipToParty)
            {
                this.ShipToAddress = this.ShipToParty.ShippingAddress;
            }

            if (!this.ExistShipFromAddress && this.ExistShipFromParty)
            {
                this.ShipFromAddress = this.ShipFromParty.ShippingAddress;
            }

            if (!this.ExistShipFromAddress && this.ExistShipFromParty)
            {
                this.ShipFromAddress = this.ShipFromParty.ShippingAddress;
            }

            if (!this.ExistBillFromContactMechanism && this.ExistBillFromInternalOrganisation)
            {
                this.BillFromContactMechanism = this.BillFromInternalOrganisation.BillingAddress;
            }
        
            this.DisplayName = string.Format(
                "{0} to {1}",
                this.ExistShipmentNumber ? this.ShipmentNumber : null,
                this.ExistShipToParty ? this.ShipToParty.DeriveDisplayName() : null);

            var characterBoundaryText = this.ExistShipToParty ? this.ShipToParty.DeriveSearchDataCharacterBoundaryText() : null;

            var wordBoundaryText = string.Format(
                "{0} {1}",
                this.ExistShipmentNumber ? this.ShipmentNumber : null,
                this.ExistShipToParty ? this.ShipToParty.DeriveSearchDataWordBoundaryText() : null);

            this.SearchData.CharacterBoundaryText = characterBoundaryText;
            this.SearchData.WordBoundaryText = wordBoundaryText;            

            derivation.Log.AssertExists(this, Shipments.Meta.ShipmentNumber);
            derivation.Log.AssertExists(this, Shipments.Meta.ShipToParty);
            derivation.Log.AssertExists(this, Shipments.Meta.ShipFromParty);
            derivation.Log.AssertExists(this, Shipments.Meta.ShipToAddress);
            derivation.Log.AssertExists(this, Shipments.Meta.ShipFromAddress);
            derivation.Log.AssertExists(this, Shipments.Meta.ShipmentMethod);
            derivation.Log.AssertExists(this, Shipments.Meta.Carrier);

            this.CreatePickList(derivation);
            this.AppsDeriveShipmentValue(derivation);
            this.AppsDeriveCurrentShipmentState(derivation);
            
            this.DeriveCurrentObjectState(derivation);
            
            this.PreviousObjectState = this.CurrentObjectState;

            this.DeriveTemplate(derivation);
        }

        protected override void AppsApplySecurityOnDerive()
        {
            this.RemoveSecurityTokens();
            this.AddSecurityToken(Domain.Singleton.Instance(this.Session).AdministratorSecurityToken);

            if (this.ExistShipFromParty)
            {
                this.AddSecurityToken(this.ShipFromParty.OwnerSecurityToken);
            }

            if (this.ExistBillToParty)
            {
                if (this.BillToParty.ExistOwnerSecurityToken && !this.SecurityTokens.Contains(this.BillToParty.OwnerSecurityToken))
                {
                    this.AddSecurityToken(BillToParty.OwnerSecurityToken);                    
                }
            }

            if (this.ExistShipToParty)
            {
                if (this.ShipToParty.ExistOwnerSecurityToken && !this.SecurityTokens.Contains(this.ShipToParty.OwnerSecurityToken))
                {
                    this.AddSecurityToken(ShipToParty.OwnerSecurityToken);
                }
            }

            if (this.ExistShipFromParty)
            {
                if (this.ShipFromParty.ExistOwnerSecurityToken && !this.SecurityTokens.Contains(this.ShipFromParty.OwnerSecurityToken))
                {
                    this.AddSecurityToken(ShipFromParty.OwnerSecurityToken);
                }
            }
        }

        private void AppsDeriveInvoices(IDerivation derivation)
        {
            var invoiceByOrder = new Dictionary<Allors.Domain.SalesOrder, Allors.Domain.SalesInvoice>();
            var costsInvoiced = false;

            foreach (ShipmentItem shipmentItem in this.ShipmentItems)
            {
                foreach (OrderShipment orderShipment in shipmentItem.OrderShipmentsWhereShipmentItem)
                {
                    var salesOrder = orderShipment.SalesOrderItem.SalesOrderWhereSalesOrderItem;

                    Allors.Domain.SalesInvoice salesInvoice;
                    if (!invoiceByOrder.TryGetValue(salesOrder, out salesInvoice))
                    {
                        salesInvoice = new SalesInvoiceBuilder(this.Session)
                            .WithStore(salesOrder.Store)
                            .WithSalesOrder(salesOrder)
                            .WithShipment(this)
                            .WithInvoiceDate(DateTime.Now)
                            .WithSalesChannel(salesOrder.SalesChannel)
                            .WithSalesInvoiceType(new Allors.Domain.SalesInvoiceTypes(this.Session).SalesInvoice)
                            .WithVatRegime(salesOrder.VatRegime)
                            .WithBilledFromContactMechanism(this.BillFromContactMechanism)
                            .WithBilledFromInternalOrganisation(this.BillFromInternalOrganisation)
                            .WithBillToContactMechanism(this.BillToContactMechanism)
                            .WithBillToCustomer(this.BillToParty)
                            .WithShipToCustomer(this.ShipToParty)
                            .WithShipToAddress(this.ShipToAddress)
                            .WithInitialMarkupPercentage(salesOrder.InitialMarkupPercentage)
                            .WithInitialProfitMargin(salesOrder.InitialProfitMargin)
                            .WithMaintainedMarkupPercentage(salesOrder.MaintainedMarkupPercentage)
                            .WithMaintainedProfitMargin(salesOrder.MaintainedProfitMargin)
                            .WithDiscountAdjustment(salesOrder.DiscountAdjustment)
                            .WithSurchargeAdjustment(salesOrder.SurchargeAdjustment)
                            .WithShippingAndHandlingCharge(salesOrder.ShippingAndHandlingCharge)
                            .WithFee(salesOrder.Fee)
                            .WithCustomerReference(salesOrder.CustomerReference)
                            .WithPaymentMethod(this.PaymentMethod)
                            .Build();

                        invoiceByOrder.Add(salesOrder, salesInvoice);

                        if (!costsInvoiced)
                        {
                            var costs = this.DeriveShippingAndHandlingCharges(derivation);
                            if (costs > 0)
                            {
                                salesInvoice.ShippingAndHandlingCharge = new ShippingAndHandlingChargeBuilder(this.Session).WithAmount(costs).Build();
                                costsInvoiced = true;
                            }
                        }
                    }

                    var invoiceItem = new SalesInvoiceItemBuilder(this.Session)
                        .WithSalesInvoiceItemType(new Allors.Domain.SalesInvoiceItemTypes(this.Session).ProductItem)
                        .WithSalesOrderItem(orderShipment.SalesOrderItem)
                        .WithVatRegime(orderShipment.SalesOrderItem.VatRegime)
                        .WithProduct(orderShipment.SalesOrderItem.Product)
                        .WithQuantity(orderShipment.Quantity)
                        .WithUnitVat(orderShipment.SalesOrderItem.UnitVat)
                        .WithUnitBasePrice(orderShipment.SalesOrderItem.UnitBasePrice)
                        .WithUnitDiscount(orderShipment.SalesOrderItem.UnitDiscount)
                        .WithUnitSurcharge(orderShipment.SalesOrderItem.UnitSurcharge)
                        .WithCalculatedUnitPrice(orderShipment.SalesOrderItem.CalculatedUnitPrice)
                        .WithTotalBasePrice(orderShipment.SalesOrderItem.UnitBasePrice * orderShipment.Quantity)
                        .WithTotalDiscount(orderShipment.SalesOrderItem.UnitDiscount * orderShipment.Quantity)
                        .WithTotalSurcharge(orderShipment.SalesOrderItem.UnitSurcharge * orderShipment.Quantity)
                        .WithTotalVat(orderShipment.SalesOrderItem.UnitVat * orderShipment.Quantity)
                        .WithTotalExVat(orderShipment.SalesOrderItem.CalculatedUnitPrice * orderShipment.Quantity)
                        .WithTotalIncVat((orderShipment.SalesOrderItem.CalculatedUnitPrice + orderShipment.SalesOrderItem.UnitVat) * orderShipment.Quantity)
                        .WithUnitPurchasePrice(orderShipment.SalesOrderItem.UnitPurchasePrice)
                        .WithInitialMarkupPercentage(orderShipment.SalesOrderItem.InitialMarkupPercentage)
                        .WithInitialProfitMargin(orderShipment.SalesOrderItem.InitialProfitMargin)
                        .WithMaintainedMarkupPercentage(orderShipment.SalesOrderItem.MaintainedMarkupPercentage)
                        .WithMaintainedProfitMargin(orderShipment.SalesOrderItem.MaintainedProfitMargin)
                        .Build();

                    salesInvoice.AddSalesInvoiceItem(invoiceItem);
                    shipmentItem.AddInvoiceItem(invoiceItem);
                }

                foreach (var keyValuePair in invoiceByOrder)
                {
                    // TODO: put this in prepare
                    // keyValuePair.Value.Derive(derivation);
                }
            }
        }

        private void AppsCancel()
        {
            this.CurrentObjectState = new CustomerShipmentObjectStates(Session).Cancelled;
        }

        private void AppsHold()
        {
            this.HeldManually = true;
            this.PutOnHold();
        }

        private void AppsPutOnHold()
        {
            foreach (PickList pickList in this.ShipToParty.PickListsWhereShipToParty)
            {
                if (this.Store.Equals(pickList.Store) &&
                    !pickList.IsNegativePickList &&
                    !pickList.ExistPicker)
                {
                    pickList.Hold();
                }
            }

            this.CurrentObjectState = new CustomerShipmentObjectStates(Session).OnHold;
        }

        private void AppsContinue()
        {
            this.ReleasedManually = true;
            this.ProcessOnContinue();
        }

        private void AppsProcessOnContinue()
        {
            this.CurrentObjectState = new CustomerShipmentObjectStates(Session).Created;

            foreach (PickList pickList in this.ShipToParty.PickListsWhereShipToParty)
            {
                if (this.Store.Equals(pickList.Store) && pickList.CurrentObjectState.Equals(new PickListObjectStates(this.Session).OnHold))
                {
                    pickList.Continue();
                }
            }
        }

        private void AppsSetPicked()
        {
            this.CurrentObjectState = new CustomerShipmentObjectStates(Session).Picked;
        }

        private void AppsSetPacked()
        {
            this.CurrentObjectState = new CustomerShipmentObjectStates(Session).Packed;
        }

        private void AppsShip()
        {
            if (this.CanShip)
            {
                this.CurrentObjectState = new CustomerShipmentObjectStates(Session).Shipped;
                this.EstimatedShipDate = DateTime.Now.Date;
            }
        }

        private void CreatePickList(IDerivation derivation)
        {
            if (this.ExistShipToParty)
            {
                var pendingPickList = this.PendingPickList;

                if (pendingPickList != null)
                {
                    foreach (PickListItem pickListItem in pendingPickList.PickListItems)
                    {
                        foreach (ItemIssuance itemIssuance in pickListItem.ItemIssuancesWherePickListItem)
                        {
                            itemIssuance.Delete();
                        }
   
                        pendingPickList.RemovePickListItem(pickListItem);
                        pickListItem.Delete();
                    }
                }

                foreach (ShipmentItem shipmentItem in this.ShipmentItems)
                {
                    var quantityIssued = 0M;
                    foreach (ItemIssuance itemIssuance in shipmentItem.ItemIssuancesWhereShipmentItem)
                    {
                        quantityIssued += itemIssuance.Quantity;
                    }

                    if (!shipmentItem.ExistItemIssuancesWhereShipmentItem || shipmentItem.Quantity > quantityIssued)
                    {
                        var orderItem = shipmentItem.OrderShipmentsWhereShipmentItem[0].SalesOrderItem;

                        if (pendingPickList == null)
                        {
                            pendingPickList = new PickListBuilder(this.Session).WithShipToParty(this.ShipToParty).WithStore(this.Store).Build();
                        }

                        PickListItem pickListItem = null;
                        foreach (PickListItem item in pendingPickList.PickListItems)
                        {
                            if (item.InventoryItem.Equals(orderItem.ReservedFromInventoryItem))
                            {
                                pickListItem = item;
                                break;
                            }
                        }

                        if (pickListItem != null)
                        {
                            pickListItem.RequestedQuantity += shipmentItem.Quantity;

                            var itemIssuances = pickListItem.ItemIssuancesWherePickListItem;
                            itemIssuances.Filter.AddEquals(ItemIssuances.Meta.ShipmentItem, shipmentItem);
                            itemIssuances.First.Quantity = shipmentItem.Quantity;
                        }
                        else
                        {
                            var quantity = shipmentItem.Quantity - quantityIssued;
                            pickListItem = new PickListItemBuilder(this.Session)
                                .WithInventoryItem(orderItem.ReservedFromInventoryItem)
                                .WithRequestedQuantity(quantity)
                                .WithActualQuantity(quantity)
                                .Build();

                            new ItemIssuanceBuilder(this.Session)
                                .WithInventoryItem(orderItem.ReservedFromInventoryItem)
                                .WithShipmentItem(shipmentItem)
                                .WithQuantity(quantity)
                                .WithPickListItem(pickListItem)
                                .Build();
                        }

                        pendingPickList.AddPickListItem(pickListItem);
                    }
                }

                if (pendingPickList != null)
                {
                    pendingPickList.Derive(derivation);
                }
            }
        }

        private void CreateNegativePickList(IDerivation derivation, CustomerShipment shipment, Allors.Domain.SalesOrderItem orderItem, decimal quantity)
        {
            if (this.ExistShipToParty)
            {
                var pickList = new PickListBuilder(this.Session)
                    .WithShipToParty(this.ShipToParty)
                    .WithCustomerShipmentCorrection(shipment)
                    .WithStore(this.Store)
                    .Build();

                pickList.AddPickListItem(new PickListItemBuilder(this.Session)
                                        .WithInventoryItem(orderItem.ReservedFromInventoryItem)
                                        .WithRequestedQuantity(0 - quantity)
                                        .Build());
            }
        }

        private decimal AppsDeriveShippingAndHandlingCharges(IDerivation derivation)
        {
            var charges = 0M;

            if (!this.WithoutCharges)
            {
                foreach (ShippingAndHandlingComponent shippingAndHandlingComponent in new ShippingAndHandlingComponents(this.DatabaseSession).Extent())
                {
                    if (shippingAndHandlingComponent.FromDate <= DateTime.Now &&
                        (!shippingAndHandlingComponent.ExistThroughDate || shippingAndHandlingComponent.ThroughDate >= DateTime.Now))
                    {
                        if (ShippingAndHandlingComponents.IsEligible(shippingAndHandlingComponent, this))
                        {
                            if (charges == 0 || shippingAndHandlingComponent.Cost < charges)
                            {
                                charges = shippingAndHandlingComponent.Cost;
                            }
                        }
                    }
                }
            }

            return charges;
        }

        private void AppsDeriveOrderItemQuantityShipped(IDerivation derivation)
        {
            var salesOrders = new List<Allors.Domain.SalesOrder>();

            foreach (ShipmentItem shipmentItem in this.ShipmentItems)
            {
                foreach (OrderShipment orderShipment in shipmentItem.OrderShipmentsWhereShipmentItem)
                {
                    orderShipment.SalesOrderItem.DeriveOnShipped(derivation, orderShipment.Quantity);
                    salesOrders.Add(orderShipment.SalesOrderItem.SalesOrderWhereSalesOrderItem);
                }
            }
        }

        private void AppsDeriveQuantityDecreased(IDerivation derivation, ShipmentItem shipmentItem, Allors.Domain.SalesOrderItem orderItem, decimal correction)
        {
            var remainingCorrection = correction;

            foreach (OrderShipment orderShipment in shipmentItem.OrderShipmentsWhereShipmentItem)
            {
                if (orderShipment.SalesOrderItem.Equals(orderItem) && remainingCorrection > 0)
                {
                    decimal quantity;
                    if (orderShipment.Quantity < remainingCorrection)
                    {
                        quantity = orderShipment.Quantity;
                        remainingCorrection -= quantity;
                    }
                    else
                    {
                        quantity = remainingCorrection;
                        remainingCorrection = 0;
                    }

                    orderShipment.Quantity -= quantity;
                    shipmentItem.Quantity -= quantity;

                    var itemIssuanceCorrection = quantity;
                    foreach (ItemIssuance itemIssuance in shipmentItem.ItemIssuancesWhereShipmentItem)
                    {
                        if (!itemIssuance.PickListItem.PickListWherePickListItem.ExistPicker)
                        {
                            decimal subQuantity;
                            if (itemIssuance.Quantity < itemIssuanceCorrection)
                            {
                                subQuantity = itemIssuance.Quantity;
                                itemIssuanceCorrection -= quantity;
                            }
                            else
                            {
                                subQuantity = itemIssuanceCorrection;
                                itemIssuanceCorrection = 0;
                            }

                            itemIssuance.Quantity -= subQuantity;

                            if (itemIssuanceCorrection == 0)
                            {
                                break;
                            }
                        }
                    }

                    if (orderShipment.Quantity == 0)
                    {
                        foreach (ItemIssuance itemIssuance in orderShipment.ShipmentItem.ItemIssuancesWhereShipmentItem)
                        {
                            if (!itemIssuance.PickListItem.PickListWherePickListItem.ExistPicker)
                            {
                                itemIssuance.Delete();
                            }
                        }

                        orderShipment.Delete();
                    }
                }
            }

            if (this.PendingPickList == null)
            {
                var shipment = (CustomerShipment)shipmentItem.ShipmentWhereShipmentItem;
                this.CreateNegativePickList(derivation, shipment, orderItem, correction);
            }

            if (shipmentItem.Quantity == 0)
            {
                shipmentItem.Delete();
            }

            if (!this.ExistShipmentItems)
            {
                this.Cancel();

                if (this.PendingPickList != null)
                {
                    this.PendingPickList.Cancel();
                }
            }
        }

        private void AppsDeriveShipmentValue(IDerivation derivation)
        {
            this.ShipmentValue = 0;
            foreach (ShipmentItem shipmentItem in this.ShipmentItems)
            {
                foreach (OrderShipment orderShipment in shipmentItem.OrderShipmentsWhereShipmentItem)
                {
                    this.ShipmentValue += orderShipment.SalesOrderItem.TotalExVat;
                }
            }
        }

        private void AppsDeriveCurrentShipmentState(IDerivation derivation)
        {
            if (this.ExistShipToParty && this.ExistShipmentItems)
            {
                ////cancel shipment if nothing left to ship
                if (this.ExistShipmentItems && this.PendingPickList == null
                    && !this.CurrentObjectState.Equals(new CustomerShipmentObjectStates(this.Session).Cancelled))
                {
                    var canCancel = true;
                    foreach (ShipmentItem shipmentItem in this.ShipmentItems)
                    {
                        if (shipmentItem.Quantity > 0)
                        {
                            canCancel = false;
                            break;
                        }
                    }

                    if (canCancel)
                    {
                        this.Cancel();
                    }
                }

                if ((this.CurrentObjectState.Equals(new CustomerShipmentObjectStates(Session).Created) || 
                    this.CurrentObjectState.Equals(new CustomerShipmentObjectStates(Session).Packed)) &&
                    this.ShipToParty.ExistPickListsWhereShipToParty)
                {
                    var isPicked = true;
                    foreach (PickList pickList in this.ShipToParty.PickListsWhereShipToParty)
                    {
                        if (this.Store.Equals(pickList.Store) && 
                            !pickList.IsNegativePickList &&
                            !pickList.CurrentObjectState.Equals(new PickListObjectStates(this.Session).Picked))
                        {
                            isPicked = false;
                        }
                    }

                    if (isPicked)
                    {
                        this.SetPicked();
                    }
                }

                if (this.CurrentObjectState.Equals(new CustomerShipmentObjectStates(Session).Picked)
                    || this.CurrentObjectState.Equals(new CustomerShipmentObjectStates(Session).Packed))
                {
                    var totalShippingQuantity = 0M;
                    var totalPackagedQuantity = 0M;
                    foreach (ShipmentItem shipmentItem in this.ShipmentItems)
                    {
                        totalShippingQuantity += shipmentItem.Quantity;
                        foreach (PackagingContent packagingContent in shipmentItem.PackagingContentsWhereShipmentItem)
                        {
                            totalPackagedQuantity += packagingContent.Quantity;
                        }
                    }

                    if (totalPackagedQuantity == totalShippingQuantity)
                    {
                        this.SetPacked();
                    }
                }

                if (this.CurrentObjectState.Equals(new CustomerShipmentObjectStates(this.Session).Created)
                    || this.CurrentObjectState.Equals(new CustomerShipmentObjectStates(this.Session).Picked)
                    || this.CurrentObjectState.Equals(new CustomerShipmentObjectStates(this.Session).Packed))
                {
                    if (this.ShipmentValue < this.Store.ShipmentThreshold && !this.ReleasedManually)
                    {                      
                        this.PutOnHold();
                    }
                }

                if (this.CurrentObjectState.Equals(new CustomerShipmentObjectStates(this.Session).OnHold) && 
                    !this.HeldManually &&
                    ((this.ShipmentValue >= this.Store.ShipmentThreshold) || this.ReleasedManually))
                {
                    this.Continue();
                }
            }
        }

        private void AppsDeriveCurrentObjectState(IDerivation derivation)
        {
            if (this.ExistCurrentObjectState && !this.CurrentObjectState.Equals(this.PreviousObjectState))
            {
                var currentStatus = new CustomerShipmentStatusBuilder(this.Session).WithCustomerShipmentObjectState(this.CurrentObjectState).Build();
                this.AddShipmentStatus(currentStatus);
                this.CurrentShipmentStatus = currentStatus;

                if (this.CurrentObjectState.Equals(new CustomerShipmentObjectStates(Session).Shipped))
                {
                    this.DeriveInvoices(derivation);
                    this.AppsDeriveOrderItemQuantityShipped(derivation);
                }
            }

            if (this.ExistCurrentObjectState)
            {
                this.CurrentObjectState.Process(this);
            }
        }
    }
}