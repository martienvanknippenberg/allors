// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PurchaseOrder.cs" company="Allors bvba">
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
    using System.Globalization;

    using Allors.Domain;

    using Resources;

    public partial class PurchaseOrder
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
                if (!this.CurrentObjectState.Equals(new PurchaseOrderObjectStates(this.DatabaseSession).Finished) &&
                    !this.CurrentObjectState.Equals(new PurchaseOrderObjectStates(this.DatabaseSession).Completed) &&
                    !this.CurrentObjectState.Equals(new PurchaseOrderObjectStates(this.DatabaseSession).Rejected) &&
                    !this.CurrentObjectState.Equals(new PurchaseOrderObjectStates(this.DatabaseSession).Cancelled))
                {
                    return true;
                }

                return false;
            }
        }

        public bool IsProvisional
        {
            get
            {
                return this.CurrentObjectState.Equals(new PurchaseOrderObjectStates(this.Session).Provisional);
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

        public string GetTotalBasePriceAsCurrencyString
        {
            get
            {
                return DecimalExtensions.AsCurrencyString(this.TotalBasePrice, this.CurrencyFormat);
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

        public string GetTotalExVatAsCurrencyString
        {
            get
            {
                return DecimalExtensions.AsCurrencyString(this.TotalExVat, this.CurrencyFormat);
            }
        }

        public string GetNothingAsCurrencyString
        {
            get
            {
                const decimal Nothing = 0;
                return Nothing.AsCurrencyString(this.CurrencyFormat);
            }
        }

        public OrderItem[] OrderItems
        {
            get
            {
                return this.PurchaseOrderItems;
            }
        }

        public string ShortOrderDateString
        {
            get { return this.OrderDate.ToShortDateString(); }
        }

        protected override void AppsOnPostBuild(IObjectBuilder builder)
        {
            base.AppsOnPostBuild(builder);

            if (!this.ExistCurrentObjectState)
            {
                this.CurrentObjectState = new PurchaseOrderObjectStates(this.Session).Provisional;
            }

            if (this.ExistTakenViaSupplier)
            {
                this.PreviousTakenViaSupplier = this.TakenViaSupplier;
            }

            if (!this.ExistBillToPurchaser)
            {
                this.BillToPurchaser = Singleton.Instance(this.Session).DefaultInternalOrganisation;
            }

            if (!this.ExistShipToBuyer)
            {
                this.ShipToBuyer = Singleton.Instance(this.Session).DefaultInternalOrganisation;
            }

            if (!this.ExistOrderNumber && this.ExistBillToPurchaser)
            {
                this.OrderNumber = this.BillToPurchaser.DeriveNextPurchaseOrderNumber();
            }

            if (!this.ExistOrderDate)
            {
                this.OrderDate = DateTime.Now;
            }

            if (!this.ExistEntryDate)
            {
                this.EntryDate = DateTime.Now;
            }

            if (!this.ExistCustomerCurrency)
            {
                if (this.ExistShipToBuyer)
                {
                    this.CustomerCurrency = this.ShipToBuyer.ExistPreferredCurrency ? this.ShipToBuyer.PreferredCurrency : this.ShipToBuyer.Locale.Country.Currency;
                }
            }

            if (!this.ExistFacility)
            {
                if (Singleton.Instance(this.Session).DefaultInternalOrganisation != null)
                {
                    this.Facility = Singleton.Instance(this.Session).DefaultInternalOrganisation.DefaultFacility;
                }
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
                if (this.ExistBillToPurchaser)
                {
                    derivation.AddDependency(this, this.BillToPurchaser);
                }

                if (this.ExistShipToBuyer)
                {
                    derivation.AddDependency(this, this.ShipToBuyer);
                }

                if (this.ExistTakenViaSupplier)
                {
                    derivation.AddDependency(this, this.TakenViaSupplier);
                }
            }

            if (this.ExistTakenViaSupplier)
            {
                var supplier = this.TakenViaSupplier as Organisation;
                if (supplier != null)
                {
                    var supplierRelationships = supplier.SupplierRelationshipsWhereSupplier;
                    supplierRelationships.Filter.AddEquals(SupplierRelationships.Meta.InternalOrganisation, this.ShipToBuyer);

                    foreach (SupplierRelationship supplierRelationship in supplierRelationships)
                    {
                        if (supplierRelationship.FromDate <= DateTime.Now && (!supplierRelationship.ExistThroughDate || supplierRelationship.ThroughDate >= DateTime.Now))
                        {
                            derivation.AddDependency(this, supplierRelationship);
                        }
                    }
                }
            }

            foreach (PurchaseOrderItem orderItem in this.OrderItems)
            {
                derivation.AddDependency(this, orderItem);
            }
        }

        protected override void AppsDerive(IDerivation derivation)
        {
            

            derivation.Log.AssertExists(this, PurchaseOrders.Meta.OrderNumber);
            derivation.Log.AssertExists(this, PurchaseOrders.Meta.OrderDate);
            derivation.Log.AssertExists(this, PurchaseOrders.Meta.CurrentObjectState);
            derivation.Log.AssertExists(this, PurchaseOrders.Meta.ShipToBuyer);
            derivation.Log.AssertExists(this, PurchaseOrders.Meta.BillToPurchaser);
            derivation.Log.AssertExists(this, PurchaseOrders.Meta.TakenViaSupplier);

            Organisation supplier = this.TakenViaSupplier as Organisation;
            if (supplier != null && this.ExistShipToBuyer)
            {
                if (!this.ShipToBuyer.Equals(supplier.InternalOrganisationWhereSupplier))
                {
                    derivation.Log.AddError(this, PurchaseOrders.Meta.TakenViaSupplier, ErrorMessages.PartyIsNotASupplier);
                }
            }

            if (!this.ExistShipToAddress && this.ExistShipToBuyer)
            {
                this.ShipToAddress = this.ShipToBuyer.ShippingAddress;
            }

            if (!this.ExistBillToContactMechanism && this.ExistBillToPurchaser)
            {
                this.BillToContactMechanism = this.BillToPurchaser.BillingAddress;
            }

            if (!this.ExistTakenViaContactMechanism && this.ExistTakenViaSupplier)
            {
                this.TakenViaContactMechanism = this.TakenViaSupplier.OrderAddress;
            }

            derivation.Log.AssertExists(this, PurchaseOrders.Meta.BillToContactMechanism);

            this.DeriveOrderItems(derivation);

            this.DeriveCurrentShipmentStatus(derivation);
            this.DeriveCurrentPaymentStatus(derivation);
            this.DeriveCurrentObjectState(derivation);
            this.DeriveLocale(derivation);
            this.DeriveOrderTotals(derivation);

            this.DisplayName = string.Format(
                "{0} - {1} from {2}",
                this.ExistOrderNumber ? this.OrderNumber : null,
                this.ExistOrderDate ? this.OrderDate : DateTime.MinValue,
                this.ExistTakenViaSupplier ? this.TakenViaSupplier.DeriveDisplayName() : null);

            var characterBoundaryText = this.ExistTakenViaSupplier ? this.TakenViaSupplier.DeriveSearchDataCharacterBoundaryText() : null;

            var wordBoundaryText = string.Format(
                "{0} {1} {2}",
                this.ExistOrderNumber ? this.OrderNumber : null,
                this.ExistOrderDate ? this.OrderDate : DateTime.MinValue,
                this.ExistTakenViaSupplier ? this.TakenViaSupplier.DeriveSearchDataWordBoundaryText() : null);

            this.SearchData.CharacterBoundaryText = characterBoundaryText;
            this.SearchData.WordBoundaryText = wordBoundaryText;
            this.PreviousTakenViaSupplier = this.TakenViaSupplier;
            this.PreviousObjectState = this.CurrentObjectState;

            this.DeriveTemplate(derivation);
        }

        protected override void AppsApplySecurityOnDerive()
        {
            this.RemoveSecurityTokens();
            this.AddSecurityToken(Singleton.Instance(this.Session).AdministratorSecurityToken);

            if (this.ExistBillToPurchaser)
            {
                var securityToken = this.BillToPurchaser.OwnerSecurityToken;

                if (!this.SecurityTokens.Contains(securityToken))
                {
                    this.AddSecurityToken(securityToken);
                }
            }

            if (this.ExistShipToBuyer)
            {
                var securityToken = this.ShipToBuyer.OwnerSecurityToken;

                if (!this.SecurityTokens.Contains(securityToken))
                {
                    this.AddSecurityToken(securityToken);
                }
            }

            if (this.ExistTakenViaSupplier)
            {
                var securityToken = this.TakenViaSupplier.OwnerSecurityToken;

                if (!this.SecurityTokens.Contains(securityToken))
                {
                    this.AddSecurityToken(securityToken);
                }
            }

            if (this.ExistPreviousTakenViaSupplier && !this.TakenViaSupplier.Equals(this.PreviousTakenViaSupplier))
            {
                this.RemoveSecurityToken(this.PreviousTakenViaSupplier.OwnerSecurityToken);
            }
        }

        private void DeriveCurrentObjectState(IDerivation derivation)
        {
            if (this.ExistCurrentObjectState && !this.CurrentObjectState.Equals(this.PreviousObjectState))
            {
                var currentStatus = new PurchaseOrderStatusBuilder(this.Session).WithPurchaseOrderObjectState(this.CurrentObjectState).Build();
                this.AddOrderStatus(currentStatus);
                this.CurrentOrderStatus = currentStatus;
            }

            if (this.ExistCurrentObjectState)
            {
                this.CurrentObjectState.Process(this);
            }
        }

        private void AppsCancelOrder()
        {
            this.CurrentObjectState = new PurchaseOrderObjectStates(Session).Cancelled;
        }

        private void AppsConfirm()
        {
            this.CurrentObjectState = new PurchaseOrderObjectStates(Session).InProcess;
        }

        private void AppsReject()
        {
            this.CurrentObjectState = new PurchaseOrderObjectStates(Session).Rejected;
        }

        private void AppsHold()
        {
            this.CurrentObjectState = new PurchaseOrderObjectStates(Session).OnHold;
        }

        private void AppsApprove()
        {
            this.CurrentObjectState = new PurchaseOrderObjectStates(Session).RequestsApproval;
        }

        private void AppsContinue()
        {
            this.CurrentObjectState = new PurchaseOrderObjectStates(Session).InProcess;
        }

        private void AppsComplete()
        {
            this.CurrentObjectState = new PurchaseOrderObjectStates(Session).Completed;
        }

        private void AppsFinish()
        {
            this.CurrentObjectState = new PurchaseOrderObjectStates(Session).Finished;
        }

        private void AppsDeriveCurrentPaymentStatus(IDerivation derivation)
        {
            var itemsPaid = false;
            var itemsPartiallyPaid = false;
            var itemsUnpaid = false;
            foreach (PurchaseOrderItem orderItem in this.ValidOrderItems)
            {
                if (orderItem.ExistCurrentPaymentStatus)
                {
                    if (orderItem.CurrentPaymentStatus.PurchaseOrderItemObjectState.Equals(new PurchaseOrderItemObjectStates(this.Session).PartiallyPaid))
                    {
                        itemsPartiallyPaid = true;
                    }

                    if (orderItem.CurrentPaymentStatus.PurchaseOrderItemObjectState.Equals(new PurchaseOrderItemObjectStates(this.Session).Paid))
                    {
                        itemsPaid = true;
                    }
                }
                else
                {
                    itemsUnpaid = true;
                }
            }

            if (itemsPaid && !itemsUnpaid && !itemsPartiallyPaid &&
                (!this.ExistCurrentPaymentStatus || !this.CurrentPaymentStatus.PurchaseOrderObjectState.Equals(new PurchaseOrderObjectStates(this.Session).Paid)))
            {
                this.CurrentPaymentStatus = new PurchaseOrderStatusBuilder(this.Session).WithPurchaseOrderObjectState(new PurchaseOrderObjectStates(this.Session).Paid).Build();
            }

            if ((itemsPartiallyPaid || (itemsPaid && itemsUnpaid)) &&
                (!this.ExistCurrentPaymentStatus || !this.CurrentPaymentStatus.PurchaseOrderObjectState.Equals(new PurchaseOrderObjectStates(this.Session).PartiallyPaid)))
            {
                this.CurrentPaymentStatus = new PurchaseOrderStatusBuilder(this.Session).WithPurchaseOrderObjectState(new PurchaseOrderObjectStates(this.Session).PartiallyPaid).Build();
            }

            this.DeriveCurrentOrderStatus(derivation);
        }

        private void AppsDeriveCurrentShipmentStatus(IDerivation derivation)
        {
            var itemsShipped = false;
            var itemsPartiallyShipped = false;
            var itemsNotShipped = false;
            foreach (PurchaseOrderItem orderItem in this.ValidOrderItems)
            {
                if (orderItem.ExistCurrentShipmentStatus)
                {
                    if (orderItem.CurrentShipmentStatus.PurchaseOrderItemObjectState.Equals(new PurchaseOrderItemObjectStates(this.Session).PartiallyReceived))
                    {
                        itemsPartiallyShipped = true;
                    }

                    if (orderItem.CurrentShipmentStatus.PurchaseOrderItemObjectState.Equals(new PurchaseOrderItemObjectStates(this.Session).Received))
                    {
                        itemsShipped = true;
                    }
                }
                else
                {
                    itemsNotShipped = true;
                }
            }

            if (itemsShipped && !itemsNotShipped && !itemsPartiallyShipped &&
                (!this.ExistCurrentShipmentStatus || !this.CurrentShipmentStatus.PurchaseOrderObjectState.Equals(new PurchaseOrderObjectStates(this.Session).Received)))
            {
                this.CurrentShipmentStatus = new PurchaseOrderStatusBuilder(this.Session).WithPurchaseOrderObjectState(new PurchaseOrderObjectStates(this.Session).Received).Build();
            }

            if ((itemsPartiallyShipped || (itemsShipped && itemsNotShipped)) &&
                (!this.ExistCurrentShipmentStatus || !this.CurrentShipmentStatus.PurchaseOrderObjectState.Equals(new PurchaseOrderObjectStates(this.Session).PartiallyReceived)))
            {
                this.CurrentShipmentStatus = new PurchaseOrderStatusBuilder(this.Session).WithPurchaseOrderObjectState(new PurchaseOrderObjectStates(this.Session).PartiallyReceived).Build();
            }

            this.DeriveCurrentOrderStatus(derivation);
        }

        private void AppsDeriveCurrentOrderStatus(IDerivation derivation)
        {
            if (this.ExistCurrentShipmentStatus && this.CurrentShipmentStatus.PurchaseOrderObjectState.Equals(new PurchaseOrderObjectStates(this.Session).Received))
            {
                this.Complete();
            }

            if (this.ExistCurrentPaymentStatus && this.CurrentPaymentStatus.PurchaseOrderObjectState.Equals(new PurchaseOrderObjectStates(this.Session).Paid))
            {
                this.Finish();
            }
        }

        private void AppsDeriveLocale(IDerivation derivation)
        {
            this.Locale = this.ExistShipToBuyer && this.ShipToBuyer.ExistLocale
                              ? this.ShipToBuyer.Locale
                              : Singleton.Instance(this.Session).DefaultLocale;
        }

        private void AppsDeriveOrderTotals(IDerivation derivation)
        {
            if (this.ExistValidOrderItems)
            {
                this.TotalBasePrice = 0;
                this.TotalDiscount = 0;
                this.TotalSurcharge = 0;
                this.TotalVat = 0;
                this.TotalExVat = 0;
                this.TotalIncVat = 0;

                foreach (PurchaseOrderItem orderItem in this.ValidOrderItems)
                {
                    this.TotalBasePrice += orderItem.TotalBasePrice;
                    this.TotalDiscount += orderItem.TotalDiscount;
                    this.TotalSurcharge += orderItem.TotalSurcharge;
                    this.TotalVat += orderItem.TotalVat;
                    this.TotalExVat += orderItem.TotalExVat;
                    this.TotalIncVat += orderItem.TotalIncVat;
                }
            }
        }

        private void AppsDeriveTemplate(IDerivation derivation)
        {
            StringTemplate template = null;
            var templates = this.ShipToBuyer.PurchaseOrderTemplates;

            if (this.ShipToBuyer.ExistLocale)
            {
                templates.Filter.AddEquals(StringTemplates.Meta.Locale, this.ShipToBuyer.Locale);
                template = templates.First;
            }

            if (template == null)
            {
                templates.Filter.AddEquals(StringTemplates.Meta.Locale, Singleton.Instance(this.Session).DefaultLocale);
                template = templates.First;
            }

            if (template != null)
            {
                this.PrintContent = template.Apply(new Dictionary<string, object> { { "this", this } });
            }
        }

        private void AppsDeriveOrderItems(IDerivation derivation)
        {
            var quantityOrderedByProduct = new Dictionary<Product, decimal>();
            var totalBasePriceByProduct = new Dictionary<Product, decimal>();
            var quantityOrderedByPart = new Dictionary<Part, decimal>();
            var totalBasePriceByPart = new Dictionary<Part, decimal>();

            foreach (PurchaseOrderItem purchaseOrderItem in this.ValidOrderItems)
            {
                purchaseOrderItem.Derive(derivation);
                purchaseOrderItem.DeriveDeliveryDate(derivation);
                purchaseOrderItem.DeriveCurrentShipmentStatus(derivation);
                purchaseOrderItem.DerivePrices();

                if (purchaseOrderItem.ExistProduct)
                {
                    if (!quantityOrderedByProduct.ContainsKey(purchaseOrderItem.Product))
                    {
                        quantityOrderedByProduct.Add(purchaseOrderItem.Product, purchaseOrderItem.QuantityOrdered);
                        totalBasePriceByProduct.Add(purchaseOrderItem.Product, purchaseOrderItem.TotalBasePrice);
                    }
                    else
                    {
                        quantityOrderedByProduct[purchaseOrderItem.Product] += purchaseOrderItem.QuantityOrdered;
                        totalBasePriceByProduct[purchaseOrderItem.Product] += purchaseOrderItem.TotalBasePrice;
                    }
                }

                if (purchaseOrderItem.ExistPart)
                {
                    if (!quantityOrderedByPart.ContainsKey(purchaseOrderItem.Part))
                    {
                        quantityOrderedByPart.Add(purchaseOrderItem.Part, purchaseOrderItem.QuantityOrdered);
                        totalBasePriceByPart.Add(purchaseOrderItem.Part, purchaseOrderItem.TotalBasePrice);
                    }
                    else
                    {
                        quantityOrderedByPart[purchaseOrderItem.Part] += purchaseOrderItem.QuantityOrdered;
                        totalBasePriceByPart[purchaseOrderItem.Part] += purchaseOrderItem.TotalBasePrice;
                    }
                }
            }
        }
    }
}