// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesOrder.cs" company="Allors bvba">
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
    using System.Text;

    
    using Allors.Domain;

    using Resources;

    public partial class SalesOrder
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

        public string GetTotalVatAsCurrencyString
        {
            get
            {
                return this.TotalVat.AsCurrencyString(this.CurrencyFormat);
            }
        }

        public string GetTotalIncVatAsCurrencyString
        {
            get
            {
                return DecimalExtensions.AsCurrencyString(this.TotalIncVat, this.CurrencyFormat);
            }
        }

        public PaymentMethod GetPaymentMethod
        {
            get
            {
                if (this.ExistBillToCustomer && this.BillToCustomer.ExistDefaultPaymentMethod)
                {
                    return this.BillToCustomer.DefaultPaymentMethod;
                }

                return this.Store.DefaultPaymentMethod;
            }
        }

        public bool CanEdit
        {
            get
            {
                if (!this.CurrentObjectState.Equals(new SalesOrderObjectStates(this.DatabaseSession).Finished) &&
                    !this.CurrentObjectState.Equals(new SalesOrderObjectStates(this.DatabaseSession).Completed) &&
                    !this.CurrentObjectState.Equals(new SalesOrderObjectStates(this.DatabaseSession).Rejected) &&
                    !this.CurrentObjectState.Equals(new SalesOrderObjectStates(this.DatabaseSession).Cancelled))
                {
                    return true;
                }

                return false;
            }
        }

        public OrderItem[] OrderItems
        {
            get
            {
                return this.SalesOrderItems;
            }
        }

        public string ShortOrderDateString
        {
            get { return this.OrderDate.ToShortDateString(); }
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

        public string GetTotalDiscountAsCurrencyString
        {
            get
            {
                return DecimalExtensions.AsCurrencyString(this.TotalDiscount, this.CurrencyFormat);
            }
        }

        public string GetTotalSurchargeAsCurrencyString
        {
            get
            {
                return DecimalExtensions.AsCurrencyString(this.TotalSurcharge, this.CurrencyFormat);
            }
        }

        public string GetTotalFeeAsCurrencyString
        {
            get
            {
                return DecimalExtensions.AsCurrencyString(this.TotalFee, this.CurrencyFormat);
            }
        }

        public string GetTotalShippingAndHandlingAsCurrencyString
        {
            get
            {
                return DecimalExtensions.AsCurrencyString(this.TotalShippingAndHandling, this.CurrencyFormat);
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

        public string GetExtraDiscountAmountAsCurrencyString
        {
            get
            {
                if (this.ExistDiscountAdjustment)
                {
                    if (this.DiscountAdjustment.ExistAmount)
                    {
                        return DecimalExtensions.AsCurrencyString(this.DiscountAdjustment.Amount, this.CurrencyFormat);
                    }
                }

                return string.Empty;
            }
        }

        public string GetExtraDiscountPercentage
        {
            get
            {
                if (this.ExistDiscountAdjustment)
                {
                    if (this.DiscountAdjustment.ExistPercentage)
                    {
                        return this.DiscountAdjustment.Percentage.ToString(this.Locale);
                    }
                }

                return string.Empty;
            }
        }

        public bool IsProposal
        {
            get
            {
                return this.CurrentObjectState.Equals(new SalesOrderObjectStates(this.Session).Provisional);
            }
        }

        public bool HasDiscount
        {
            get
            {
                if (this.ExistTotalDiscount)
                {
                    return this.TotalDiscount > 0;
                }

                return false;
            }
        }

        public bool HasSurcharge
        {
            get
            {
                if (this.ExistTotalSurcharge)
                {
                    return this.TotalSurcharge > 0;
                }

                return false;
            }
        }

        public bool HasFee
        {
            get
            {
                if (this.ExistTotalFee)
                {
                    return this.TotalFee > 0;
                }

                return false;
            }
        }

        public bool HasShippingAndHandling
        {
            get
            {
                if (this.ExistTotalShippingAndHandling)
                {
                    return this.TotalShippingAndHandling > 0;
                }

                return false;
            }
        }

        public bool ScheduledManually
        {
            get
            {
                if (this.ExistOrderKind && this.OrderKind.ScheduleManually)
                {
                    return true;
                }

                return false;
            }
        }

        private string AppsSalesRepNames
        {
            get
            {
                var names = new StringBuilder();
                foreach (Person salesRep in this.SalesReps)
                {
                    if (names.Length > 0)
                    {
                        names.Append(", ");
                    }

                    names.Append(salesRep.DeriveDisplayName());
                }

                return names.ToString();
            }
        }

        public string TotalExVatAsCurrencyString()
        {
            return this.GetTotalExVatAsCurrencyString;
        }

        public void SetActualDiscountAmount(decimal amount)
        {
            if (!this.ExistDiscountAdjustment)
            {
                this.DiscountAdjustment = new DiscountAdjustmentBuilder(this.Session).Build();
            }

            this.DiscountAdjustment.Amount = amount;
            this.DiscountAdjustment.RemovePercentage();
        }

        public void SetActualDiscountPercentage(decimal percentage)
        {
            if (!this.ExistDiscountAdjustment)
            {
                this.DiscountAdjustment = new DiscountAdjustmentBuilder(this.Session).Build();
            }

            this.DiscountAdjustment.Percentage = percentage;
            this.DiscountAdjustment.RemoveAmount();
        }

        protected override void AppsOnPostBuild(IObjectBuilder builder)
        {
            base.AppsOnPostBuild(builder);
            
            if (!this.ExistCurrentObjectState)
            {
                this.CurrentObjectState = new SalesOrderObjectStates(this.Session).Provisional;
            }

            if (!this.ExistPartiallyShip)
            {
                this.PartiallyShip = true;
            }

            if (!this.ExistOrderDate)
            {
                this.OrderDate = DateTime.Now;
            }

            if (!this.ExistEntryDate)
            {
                this.EntryDate = DateTime.Now;
            }

            if (!this.ExistDeliveryDate)
            {
                this.DeliveryDate = DateTime.Now;
            }

            if (!this.ExistTakenByInternalOrganisation)
            {
                this.TakenByInternalOrganisation = Singleton.Instance(this.Session).DefaultInternalOrganisation;
            }

            if (!this.ExistStore && this.ExistTakenByInternalOrganisation)
            {
                if (this.TakenByInternalOrganisation.StoresWhereOwner.Count == 1)
                {
                    this.Store = this.TakenByInternalOrganisation.StoresWhereOwner.First;
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

            if (!this.ExistTotalIncVat)
            {
                this.TotalIncVat = 0;
            }

            if (!this.ExistTotalIncVatCustomerCurrency)
            {
                this.TotalIncVatCustomerCurrency = 0;
            }

            if (!this.ExistTotalVat)
            {
                this.TotalVat = 0;
            }

            if (!this.ExistTotalVatCustomerCurrency)
            {
                this.TotalVatCustomerCurrency = 0;
            }

            if (!this.ExistVatRegime && this.ExistBillToCustomer)
            {
                this.VatRegime = this.BillToCustomer.VatRegime;
            }

            if (!this.ExistPaymentMethod)
            {
                if (this.ShipToCustomer != null)
                {
                    this.PaymentMethod = this.ShipToCustomer.DefaultPaymentMethod;
                }

                if (!this.ExistPaymentMethod && this.ExistStore)
                {
                    this.PaymentMethod = this.Store.DefaultPaymentMethod;
                }
            }

            if (!this.ExistBillToCustomer && this.ExistShipToCustomer)
            {
                this.BillToCustomer = this.ShipToCustomer;
            }

            if (!this.ExistShipToCustomer && this.ExistBillToCustomer)
            {
                this.ShipToCustomer = this.BillToCustomer;
            }

            if (!this.ExistShipToAddress && this.ExistShipToCustomer)
            {
                this.ShipToAddress = this.ShipToCustomer.ShippingAddress;
            }

            if (!this.ExistShipmentMethod)
            {
                if (this.ShipToCustomer != null)
                {
                    this.ShipmentMethod = this.ShipToCustomer.DefaultShipmentMethod;
                }

                if (this.ShipToCustomer != null && this.ExistStore)
                {
                    this.ShipmentMethod = this.Store.DefaultShipmentMethod;
                }
            }

            if (!this.ExistSearchData)
            {
                this.SearchData = new SearchDataBuilder(this.Session).Build();
            }
        }

        protected override void AppsPrepareDerivation(IDerivation derivation)
        {
            base.AppsPrepareDerivation(derivation);

            if (this.ExistBillToCustomer)
            {
                var customerRelationships = this.BillToCustomer.CustomerRelationshipsWhereCustomer;
                customerRelationships.Filter.AddEquals(CustomerRelationships.Meta.InternalOrganisation, this.TakenByInternalOrganisation);

                foreach (CustomerRelationship customerRelationship in customerRelationships)
                {
                    if (customerRelationship.FromDate <= DateTime.Now && (!customerRelationship.ExistThroughDate || customerRelationship.ThroughDate >= DateTime.Now))
                    {
                        derivation.AddDependency(this, customerRelationship);
                    }
                }
            }

            if (this.ExistShipToCustomer)
            {
                var customerRelationships = this.ShipToCustomer.CustomerRelationshipsWhereCustomer;
                customerRelationships.Filter.AddEquals(CustomerRelationships.Meta.InternalOrganisation, this.TakenByInternalOrganisation);

                foreach (CustomerRelationship customerRelationship in customerRelationships)
                {
                    if (customerRelationship.FromDate <= DateTime.Now && (!customerRelationship.ExistThroughDate || customerRelationship.ThroughDate >= DateTime.Now))
                    {
                        derivation.AddDependency(this, customerRelationship);
                    }
                }
            }

            foreach (SalesOrderItem orderItem in this.OrderItems)
            {
                derivation.AddDependency(this, orderItem);
            }
        }

        protected override void AppsDerive(IDerivation derivation)
        {
            

            if (!this.ExistOrderNumber && this.ExistStore)
            {
                this.OrderNumber = this.Store.DeriveNextSalesOrderNumber();
            }

            if (!this.ExistBillToCustomer && this.ExistShipToCustomer)
            {
                this.BillToCustomer = this.ShipToCustomer;
            }

            if (!this.ExistShipToCustomer && this.ExistBillToCustomer)
            {
                this.ShipToCustomer = this.BillToCustomer;
            }

            if (!this.ExistShipToAddress && this.ExistShipToCustomer)
            {
                this.ShipToAddress = this.ShipToCustomer.ShippingAddress;               
            }

            if (!this.ExistShipmentMethod && this.ExistShipToCustomer)
            {
                this.ShipmentMethod = this.ShipToCustomer.DefaultShipmentMethod ?? this.Store.DefaultShipmentMethod;
            }

            if (!this.ExistBillToContactMechanism && this.ExistBillToCustomer)
            {
                this.BillToContactMechanism = this.BillToCustomer.BillingAddress;
            }

            if (!this.ExistBillFromContactMechanism && this.ExistTakenByInternalOrganisation)
            {
                this.BillFromContactMechanism = this.TakenByInternalOrganisation.BillingAddress;
            }

            if (!this.ExistTakenByContactMechanism && this.ExistTakenByInternalOrganisation)
            {
                this.TakenByContactMechanism = this.TakenByInternalOrganisation.OrderAddress;
            }

            if (!this.ExistCustomerCurrency)
            {
                if (this.ExistBillToCustomer &&
                    (this.BillToCustomer.ExistPreferredCurrency || this.BillToCustomer.ExistLocale))
                {
                    this.CustomerCurrency = this.BillToCustomer.ExistPreferredCurrency ? this.BillToCustomer.PreferredCurrency : this.BillToCustomer.Locale.Country.Currency;
                }
                else
                {
                    if (this.ExistTakenByInternalOrganisation)
                    {
                        this.CustomerCurrency = this.TakenByInternalOrganisation.ExistPreferredCurrency ? this.TakenByInternalOrganisation.PreferredCurrency : this.TakenByInternalOrganisation.Locale.Country.Currency;
                    }
                }
            }

            if (this.ExistBillToCustomer && this.ExistTakenByInternalOrganisation)
            {
                if (!this.TakenByInternalOrganisation.Equals(this.BillToCustomer.InternalOrganisationWhereCustomer))
                {
                    derivation.Log.AddError(this, SalesOrders.Meta.BillToCustomer, ErrorMessages.PartyIsNotACustomer);
                }
            }

            if (this.ExistShipToCustomer && this.ExistTakenByInternalOrganisation)
            {
                if (!this.TakenByInternalOrganisation.Equals(this.ShipToCustomer.InternalOrganisationWhereCustomer))
                {
                    derivation.Log.AddError(this, SalesOrders.Meta.ShipToCustomer, ErrorMessages.PartyIsNotACustomer);
                }
            }

            if (!this.ExistVatRegime && this.ExistBillToCustomer)
            {
                this.VatRegime = this.BillToCustomer.VatRegime;
            }

            if (!this.ExistPaymentMethod && this.ExistBillToCustomer)
            {
                this.PaymentMethod = this.BillToCustomer.DefaultPaymentMethod ?? this.Store.DefaultPaymentMethod;
            }

            this.DeriveOrderItems(derivation);

            this.DeriveCurrentShipmentStatus(derivation);
            this.DeriveCurrentOrderStatus(derivation);
            this.DeriveCurrentObjectState(derivation);
            this.DeriveLocale(derivation);
            this.DeriveOrderTotals(derivation);
            this.DeriveCustomers(derivation);
            this.DeriveSalesReps(derivation);
            this.DeriveCurrentPaymentStatus(derivation);

            this.TryShip(derivation);

            this.DisplayName = string.Format(
                "{0} - {1} to {2}",
                this.ExistOrderNumber ? this.OrderNumber : null,
                this.ExistOrderDate ? this.OrderDate : DateTime.MinValue,
                this.ExistShipToCustomer ? this.ShipToCustomer.DeriveDisplayName() : null);

            var characterBoundaryText = string.Format(
                "{0} {1}",
                this.ExistOrderNumber ? this.OrderNumber : null,
                this.ExistShipToCustomer ? this.ShipToCustomer.DeriveSearchDataCharacterBoundaryText() : null);

            var wordBoundaryText = string.Format(
                "{0} {1}",
                this.ExistOrderDate ? this.OrderDate : DateTime.MinValue,
                this.ExistShipToCustomer ? this.ShipToCustomer.DeriveSearchDataWordBoundaryText() : null);

            this.SearchData.CharacterBoundaryText = characterBoundaryText;
            this.SearchData.WordBoundaryText = wordBoundaryText;

            derivation.Log.AssertExists(this, SalesOrders.Meta.OrderNumber);
            derivation.Log.AssertExists(this, SalesOrders.Meta.OrderDate);
            derivation.Log.AssertExists(this, SalesOrders.Meta.CustomerCurrency);
            derivation.Log.AssertExists(this, SalesOrders.Meta.DeliveryDate);
            derivation.Log.AssertExists(this, SalesOrders.Meta.CurrentObjectState);
            derivation.Log.AssertExists(this, SalesOrders.Meta.TakenByInternalOrganisation);
            derivation.Log.AssertExists(this, SalesOrders.Meta.Store);

            this.PreviousBillToCustomer = this.BillToCustomer;
            this.PreviousShipToCustomer = this.ShipToCustomer;  
        
            this.DeriveTemplate(derivation);
        }

        protected override void AppsApplySecurityOnDerive()
        {
            this.RemoveSecurityTokens();
            this.AddSecurityToken(Singleton.Instance(this.Session).AdministratorSecurityToken);

            if (this.ExistTakenByInternalOrganisation)
            {
                var securityToken = this.TakenByInternalOrganisation.OwnerSecurityToken;

                if (!this.SecurityTokens.Contains(securityToken))
                {
                    this.AddSecurityToken(securityToken);
                }
            }

            if (this.ExistBillToCustomer && !this.SecurityTokens.Contains(this.BillToCustomer.OwnerSecurityToken))
            {
                this.AddSecurityToken(BillToCustomer.OwnerSecurityToken);
            }

            if (this.ExistPreviousBillToCustomer && !this.BillToCustomer.Equals(this.PreviousBillToCustomer))
            {
                this.RemoveSecurityToken(this.PreviousBillToCustomer.OwnerSecurityToken);
            }

            if (this.ExistShipToCustomer && !this.SecurityTokens.Contains(this.ShipToCustomer.OwnerSecurityToken))
            {
                this.AddSecurityToken(ShipToCustomer.OwnerSecurityToken);
            }

            if (this.ExistPreviousShipToCustomer && !this.ShipToCustomer.Equals(this.PreviousShipToCustomer))
            {
                this.RemoveSecurityToken(this.PreviousShipToCustomer.OwnerSecurityToken);
            }
        }

        private void DeriveCurrentObjectState(IDerivation derivation)
        {
            if (this.ExistCurrentObjectState && !this.CurrentObjectState.Equals(this.PreviousObjectState))
            {
                this.CurrentObjectState.Process(this);

                var currentStatus = new SalesOrderStatusBuilder(this.Session).WithSalesOrderObjectState(this.CurrentObjectState).Build();
                this.AddOrderStatus(currentStatus);
                this.CurrentOrderStatus = currentStatus;
                this.PreviousObjectState = this.CurrentObjectState;
            }
        }

        private void AppsCancelOrder()
        {
            this.CurrentObjectState = new SalesOrderObjectStates(Session).Cancelled;
        }

        private void AppsConfirm()
        {
            var orderThreshold = this.Store.OrderThreshold;

            var customerRelationships = this.BillToCustomer.CustomerRelationshipsWhereCustomer;
            customerRelationships.Filter.AddEquals(CustomerRelationships.Meta.InternalOrganisation, this.TakenByInternalOrganisation);

            decimal amountOverDue = 0;
            decimal creditLimit = 0;
            foreach (CustomerRelationship customerRelationship in customerRelationships)
            {
                if (customerRelationship.FromDate <= DateTime.Now && (!customerRelationship.ExistThroughDate || customerRelationship.ThroughDate >= DateTime.Now))
                {
                    creditLimit = customerRelationship.ExistCreditLimit ? customerRelationship.CreditLimit : this.Store.ExistCreditLimit ? this.Store.CreditLimit : 0;
                    amountOverDue = customerRelationship.AmountOverDue;
                }
            }
            
            if (amountOverDue > creditLimit || this.TotalExVat < orderThreshold)
            {
                this.CurrentObjectState = new SalesOrderObjectStates(Session).RequestsApproval;                    
            }
            else
            {
                this.CurrentObjectState = new SalesOrderObjectStates(Session).InProcess;
            }
        }

        private void AppsReject()
        {
            this.CurrentObjectState = new SalesOrderObjectStates(Session).Rejected;
        }

        private void AppsHold()
        {
            this.CurrentObjectState = new SalesOrderObjectStates(Session).OnHold;
        }

        private void AppsApprove()
        {
            this.CurrentObjectState = new SalesOrderObjectStates(Session).InProcess;
        }

        private void AppsContinue()
        {
            this.CurrentObjectState = new SalesOrderObjectStates(Session).InProcess;
        }

        private void AppsComplete()
        {
            this.CurrentObjectState = new SalesOrderObjectStates(Session).Completed;
        }

        private void AppsFinish()
        {
            this.CurrentObjectState = new SalesOrderObjectStates(Session).Finished;
        }

        private void AppsDeriveCurrentPaymentStatus(IDerivation derivation)
        {
            var itemsPaid = false;
            var itemsPartiallyPaid = false;
            var itemsUnpaid = false;

            foreach (SalesOrderItem orderItem in this.ValidOrderItems)
            {
                if (orderItem.ExistCurrentPaymentStatus)
                {
                    if (orderItem.CurrentPaymentStatus.SalesOrderItemObjectState.Equals(new SalesOrderItemObjectStates(this.Session).PartiallyPaid))
                    {
                        itemsPartiallyPaid = true;
                    }

                    if (orderItem.CurrentPaymentStatus.SalesOrderItemObjectState.Equals(new SalesOrderItemObjectStates(this.Session).Paid))
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
                (!this.ExistCurrentPaymentStatus || !this.CurrentPaymentStatus.SalesOrderObjectState.Equals(new SalesOrderObjectStates(this.Session).Paid)))
            {
                this.CurrentPaymentStatus = new SalesOrderStatusBuilder(this.Session).WithSalesOrderObjectState(new SalesOrderObjectStates(this.Session).Paid).Build();
            }

            if ((itemsPartiallyPaid || (itemsPaid && itemsUnpaid)) &&
                (!this.ExistCurrentPaymentStatus || !this.CurrentPaymentStatus.SalesOrderObjectState.Equals(new SalesOrderObjectStates(this.Session).PartiallyPaid)))
            {
                this.CurrentPaymentStatus = new SalesOrderStatusBuilder(this.Session).WithSalesOrderObjectState(new SalesOrderObjectStates(this.Session).PartiallyPaid).Build();
            }

            this.DeriveCurrentOrderStatus(derivation);
        }

        private void AppsDeriveCurrentShipmentStatus(IDerivation derivation)
        {
            var itemsShipped = false;
            var itemsPartiallyShipped = false;
            var itemsNotShipped = false;
            
            foreach (SalesOrderItem orderItem in this.ValidOrderItems)
            {
                if (orderItem.ExistCurrentShipmentStatus)
                {
                    if (orderItem.CurrentShipmentStatus.SalesOrderItemObjectState.Equals(new SalesOrderItemObjectStates(this.Session).PartiallyShipped))
                    {
                        itemsPartiallyShipped = true;
                    }

                    if (orderItem.CurrentShipmentStatus.SalesOrderItemObjectState.Equals(new SalesOrderItemObjectStates(this.Session).Shipped))
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
                (!this.ExistCurrentShipmentStatus || !this.CurrentShipmentStatus.SalesOrderObjectState.Equals(new SalesOrderObjectStates(this.Session).Shipped)))
            {
                this.CurrentShipmentStatus = new SalesOrderStatusBuilder(this.Session).WithSalesOrderObjectState(new SalesOrderObjectStates(this.Session).Shipped).Build();
            }

            if ((itemsPartiallyShipped || (itemsShipped && itemsNotShipped)) &&
                (!this.ExistCurrentShipmentStatus || !this.CurrentShipmentStatus.SalesOrderObjectState.Equals(new SalesOrderObjectStates(this.Session).PartiallyShipped)))
            {
                this.CurrentShipmentStatus = new SalesOrderStatusBuilder(this.Session).WithSalesOrderObjectState(new SalesOrderObjectStates(this.Session).PartiallyShipped).Build();
            }

            this.DeriveCurrentOrderStatus(derivation);
        }

        private void AppsDeriveCurrentOrderStatus(IDerivation derivation)
        {
            if (this.ExistCurrentShipmentStatus && this.CurrentShipmentStatus.SalesOrderObjectState.Equals(new SalesOrderObjectStates(this.Session).Shipped))
            {
                this.Complete();
            }

            if (this.ExistCurrentPaymentStatus && this.CurrentPaymentStatus.SalesOrderObjectState.Equals(new SalesOrderObjectStates(this.Session).Paid))
            {
                this.Finish();
            }
        }

        private void AppsDeriveSalesReps(IDerivation derivation)
        {
            this.RemoveSalesReps();
            foreach (SalesOrderItem item in this.ValidOrderItems)
            {
                this.AddSalesRep(item.SalesRep);
            }
        }

        private void AppsDeriveOrderTotals(IDerivation derivation)
        {
            if (this.ExistValidOrderItems)
            {
                this.TotalBasePrice = 0;
                this.TotalDiscount = 0;
                this.TotalSurcharge = 0;
                this.TotalExVat = 0;
                this.TotalFee = 0;
                this.TotalShippingAndHandling = 0;
                this.TotalVat = 0;
                this.TotalIncVat = 0;
                this.TotalPurchasePrice = 0;
                this.TotalListPrice = 0;
                this.MaintainedMarkupPercentage = 0;
                this.InitialMarkupPercentage = 0;
                this.MaintainedProfitMargin = 0;
                this.InitialProfitMargin = 0;

                foreach (SalesOrderItem item in this.ValidOrderItems)
                {
                    if (!item.ExistSalesOrderItemWhereOrderedWithFeature)
                    {
                        this.TotalBasePrice += item.TotalBasePrice;
                        this.TotalDiscount += item.TotalDiscount;
                        this.TotalSurcharge += item.TotalSurcharge;
                        this.TotalExVat += item.TotalExVat;
                        this.TotalVat += item.TotalVat;
                        this.TotalIncVat += item.TotalIncVat;
                        this.TotalPurchasePrice += item.UnitPurchasePrice;
                        this.TotalListPrice += item.CalculatedUnitPrice;
                    }
                }

                this.AppsDeriveOrderAdjustments();
                this.AppsDeriveTotalFee();
                this.AppsDeriveTotalShippingAndHandling();
                this.AppsDeriveMarkupAndProfitMargin(derivation);
            }
        }

        private void AppsDeriveOrderAdjustments()
        {
            if (this.ExistDiscountAdjustment)
            {
                decimal discount = this.DiscountAdjustment.ExistPercentage ? decimal.Round((this.TotalExVat * this.DiscountAdjustment.Percentage) / 100, 2) : this.DiscountAdjustment.Amount;

                this.TotalDiscount += discount;
                this.TotalExVat -= discount;

                if (this.ExistVatRegime)
                {
                    decimal vat = decimal.Round((discount * this.VatRegime.VatRate.Rate) / 100, 2);

                    this.TotalVat -= vat;
                    this.TotalIncVat -= discount + vat;
                }
            }

            if (this.ExistSurchargeAdjustment)
            {
                decimal surcharge = this.SurchargeAdjustment.ExistPercentage ? decimal.Round((this.TotalExVat * this.SurchargeAdjustment.Percentage) / 100, 2) : this.SurchargeAdjustment.Amount;

                this.TotalSurcharge += surcharge;
                this.TotalExVat += surcharge;

                if (this.ExistVatRegime)
                {
                    decimal vat = decimal.Round((surcharge * this.VatRegime.VatRate.Rate) / 100, 2);
                    this.TotalVat += vat;
                    this.TotalIncVat += surcharge + vat;
                }
            }
        }

        private void AppsDeriveTotalFee()
        {
            if (this.ExistFee)
            {
                decimal fee = this.Fee.ExistPercentage ? decimal.Round((this.TotalExVat * this.Fee.Percentage) / 100, 2) : this.Fee.Amount;

                this.TotalFee += fee;
                this.TotalExVat += fee;

                if (this.Fee.ExistVatRate)
                {
                    decimal vat = decimal.Round((fee * this.Fee.VatRate.Rate) / 100, 2);
                    this.TotalVat += vat;
                    this.TotalIncVat += fee + vat;
                }
            }
        }

        private void AppsDeriveTotalShippingAndHandling()
        {
            if (this.ExistShippingAndHandlingCharge)
            {
                decimal shipping = this.ShippingAndHandlingCharge.ExistPercentage ? 
                    decimal.Round((this.TotalExVat * this.ShippingAndHandlingCharge.Percentage) / 100, 2) :
                    this.ShippingAndHandlingCharge.Amount;

                this.TotalShippingAndHandling += shipping;
                this.TotalExVat += shipping;

                if (this.ShippingAndHandlingCharge.ExistVatRate)
                {
                    decimal vat = decimal.Round((shipping * this.ShippingAndHandlingCharge.VatRate.Rate) / 100, 2);
                    this.TotalVat += vat;
                    this.TotalIncVat += shipping + vat;
                }
            }
        }

        private void AppsDeriveMarkupAndProfitMargin(IDerivation derivation)
        {
            //// Only take into account items for which there is data at the item level.
            //// Skip negative sales.
            decimal totalPurchasePrice = 0;
            decimal totalUnitBasePrice = 0;
            decimal totalListPrice = 0;

            foreach (SalesOrderItem item in this.ValidOrderItems)
            {
                if (item.TotalExVat > 0)
                {
                    totalPurchasePrice += item.UnitPurchasePrice;
                    totalUnitBasePrice += item.UnitBasePrice;
                    totalListPrice += item.CalculatedUnitPrice;
                }
            }

            if (totalPurchasePrice != 0 && totalListPrice != 0 && totalUnitBasePrice != 0)
            {
                this.InitialMarkupPercentage = decimal.Round(((totalUnitBasePrice / totalPurchasePrice) - 1) * 100, 2);
                this.MaintainedMarkupPercentage = decimal.Round(((totalListPrice / totalPurchasePrice) - 1) * 100, 2);

                this.InitialProfitMargin = decimal.Round(((totalUnitBasePrice - totalPurchasePrice) / totalUnitBasePrice) * 100, 2);
                this.MaintainedProfitMargin = decimal.Round(((totalListPrice - totalPurchasePrice) / totalListPrice) * 100, 2);
            }
        }

        private void AppsDeriveLocale(IDerivation derivation)
        {
            if (this.ExistBillToCustomer && this.BillToCustomer.ExistLocale)
            {
                this.Locale = this.BillToCustomer.Locale;
            }
            else
            {
                this.Locale = this.ExistTakenByInternalOrganisation ? this.TakenByInternalOrganisation.Locale : Singleton.Instance(this.Session).DefaultLocale;
            }
        }

        private void AppsDeriveTemplate(IDerivation derivation)
        {
            StringTemplate template = null;
            if (this.ExistStore && this.ExistBillToCustomer && this.BillToCustomer.ExistLocale)
            {
                var templates = this.Store.SalesOrderTemplates;
                templates.Filter.AddEquals(StringTemplates.Meta.Locale, this.BillToCustomer.Locale);
                template = templates.First;
            }

            if (this.ExistStore && template == null && this.TakenByInternalOrganisation.ExistLocale)
            {
                var templates = this.Store.SalesOrderTemplates;
                templates.Filter.AddEquals(StringTemplates.Meta.Locale, this.TakenByInternalOrganisation.Locale);
                template = templates.First;
            }

            if (this.ExistStore && template == null)
            {
                var templates = this.Store.SalesOrderTemplates;
                templates.Filter.AddEquals(StringTemplates.Meta.Locale, Singleton.Instance(this.Session).DefaultLocale);
                template = templates.First;
            }

            if (template != null)
            {
                this.PrintContent = template.Apply(new Dictionary<string, object> { { "this", this } });
            }
        }

        private void AppsDeriveCustomers(IDerivation derivation)
        {
            this.RemoveCustomers();

            this.AddCustomer(this.BillToCustomer);
            this.AddCustomer(this.ShipToCustomer);
            this.AddCustomer(this.PlacingCustomer);
        }

        private void AppsTryShip(IDerivation derivation)
        {
            if (this.CurrentObjectState.Equals(new SalesOrderObjectStates(this.DatabaseSession).InProcess) && !this.ScheduledManually)
            {
                var somethingToShip = false;
                var allItemsAvailable = true;

                foreach (SalesOrderItem salesOrderItem in this.ValidOrderItems)
                {
                    if (!this.PartiallyShip && salesOrderItem.QuantityRequestsShipping != salesOrderItem.QuantityOrdered)
                    {
                        allItemsAvailable = false;
                        break;
                    }

                    if (this.PartiallyShip && salesOrderItem.QuantityRequestsShipping > 0)
                    {
                        somethingToShip = true;
                    }
                }

                if (this.CurrentObjectState.Equals(new SalesOrderObjectStates(this.Session).InProcess) &&
                    ((!this.PartiallyShip && allItemsAvailable) || somethingToShip))
                {
                    this.Ship(derivation);
                }
            }
        }

        private List<Shipment> AppsShip(IDerivation derivation)
        {
            var addresses = this.ShipToAddresses();
            var shipments = new List<Shipment>();
            if (addresses.Count > 0)
            {
                foreach (var address in addresses)
                {
                    shipments.Add(this.Ship(derivation, address));
                }
            }

            return shipments;
        }

        private CustomerShipment AppsShip(IDerivation derivation, KeyValuePair<PostalAddress, Party> address)
        {
            var pendingShipment = address.Value.GetPendingCustomerShipmentForStore(address.Key, this.Store, this.ShipmentMethod);

            if (pendingShipment == null)
            {
                pendingShipment = new CustomerShipmentBuilder(this.Session)
                    .WithBillFromInternalOrganisation(this.TakenByInternalOrganisation)
                    .WithBillFromContactMechanism(this.BillFromContactMechanism)
                    .WithShipFromParty(this.TakenByInternalOrganisation)
                    .WithShipFromAddress(this.TakenByInternalOrganisation.ShippingAddress)
                    .WithBillToParty(this.BillToCustomer)
                    .WithBillToContactMechanism(this.BillToContactMechanism)
                    .WithShipToAddress(address.Key)
                    .WithShipToParty(address.Value)
                    .WithShipmentPackage(new ShipmentPackageBuilder(this.Session).Build())
                    .WithStore(this.Store)
                    .WithShipmentMethod(this.ShipmentMethod)
                    .WithPaymentMethod(this.PaymentMethod)
                    .Build();
            }

            foreach (SalesOrderItem orderItem in this.ValidOrderItems)
            {
                if (orderItem.ExistProduct && orderItem.ShipToAddress.Equals(address.Key) && orderItem.QuantityRequestsShipping > 0)
                {
                    var good = orderItem.Product as Good;

                    ShipmentItem shipmentItem = null;
                    foreach (ShipmentItem item in pendingShipment.ShipmentItems)
                    {
                        if (item.Good.Equals(good))
                        {
                            shipmentItem = item;
                            break;
                        }
                    }

                    if (shipmentItem != null)
                    {
                        shipmentItem.Quantity += orderItem.QuantityRequestsShipping;
                        shipmentItem.ContentsDescription = string.Format("{0} * {1}", shipmentItem.Quantity, good);
                    }
                    else
                    {
                        shipmentItem = new ShipmentItemBuilder(this.Session)
                            .WithGood(good)
                            .WithQuantity(orderItem.QuantityRequestsShipping)
                            .WithContentsDescription(string.Format("{0} * {1}", orderItem.QuantityRequestsShipping, good))
                            .Build();

                        pendingShipment.AddShipmentItem(shipmentItem);
                    }

                    foreach (SalesOrderItem featureItem in orderItem.OrderedWithFeatures)
                    {
                        shipmentItem.AddProductFeature(featureItem.ProductFeature);
                    }

                    var orderShipmentsWhereShipmentItem = shipmentItem.OrderShipmentsWhereShipmentItem;
                    orderShipmentsWhereShipmentItem.Filter.AddEquals(OrderShipments.Meta.SalesOrderItem, orderItem);

                    if (orderShipmentsWhereShipmentItem.First == null)
                    {
                        new OrderShipmentBuilder(this.Session)
                            .WithSalesOrderItem(orderItem)
                            .WithShipmentItem(shipmentItem)
                            .WithQuantity(orderItem.QuantityRequestsShipping)
                            .Build();
                    }
                    else
                    {
                        orderShipmentsWhereShipmentItem.First.Quantity += orderItem.QuantityRequestsShipping;
                    }

                    orderItem.DeriveOnShip(derivation);
                }
            }

            pendingShipment.Derive(derivation);
            return pendingShipment;
        }

        private Dictionary<PostalAddress, Party> ShipToAddresses()
        {
            var addresses = new Dictionary<PostalAddress, Party>();
            foreach (SalesOrderItem item in this.ValidOrderItems)
            {
                if (item.QuantityRequestsShipping > 0)
                {
                    if (!addresses.ContainsKey(item.ShipToAddress))
                    {
                        addresses.Add(item.ShipToAddress, item.ShipToParty);
                    }
                }
            }

            return addresses;
        }

        private void AppsDeriveOrderItems(IDerivation derivation)
        {
            var quantityOrderedByProduct = new Dictionary<Product, decimal>();
            var totalBasePriceByProduct = new Dictionary<Product, decimal>();

            foreach (SalesOrderItem salesOrderItem in this.ValidOrderItems)
            {
                foreach (SalesOrderItem featureItem in salesOrderItem.OrderedWithFeatures)
                {
                    featureItem.DerivePrices(derivation);
                }

                salesOrderItem.DeriveDeliveryDate(derivation);
                salesOrderItem.DeriveShipTo(derivation);
                salesOrderItem.DeriveSalesRep(derivation);
                salesOrderItem.CalculatePurchasePrice(derivation);
                salesOrderItem.CalculateUnitPrice(derivation);
                salesOrderItem.DerivePrices(derivation);
                salesOrderItem.DeriveCurrentShipmentStatus(derivation);
                salesOrderItem.DeriveVatRegime(derivation);
                salesOrderItem.DeriveCurrentPaymentStatus(derivation);

                // for the second time, because unitbaseprice might not be set
                salesOrderItem.DeriveIsValidOrderItem(derivation);                

                if (salesOrderItem.ExistProduct)
                {
                    if (!quantityOrderedByProduct.ContainsKey(salesOrderItem.Product))
                    {
                        quantityOrderedByProduct.Add(salesOrderItem.Product, salesOrderItem.QuantityOrdered);
                        totalBasePriceByProduct.Add(salesOrderItem.Product, salesOrderItem.TotalBasePrice);
                    }
                    else
                    {
                        quantityOrderedByProduct[salesOrderItem.Product] += salesOrderItem.QuantityOrdered;
                        totalBasePriceByProduct[salesOrderItem.Product] += salesOrderItem.TotalBasePrice;                        
                    }
                }
            }

            foreach (SalesOrderItem salesOrderItem in this.ValidOrderItems)
            {
                decimal quantityOrdered = 0;
                decimal totalBasePrice = 0;

                if (salesOrderItem.ExistProduct)
                {
                    quantityOrderedByProduct.TryGetValue(salesOrderItem.Product, out quantityOrdered);
                    totalBasePriceByProduct.TryGetValue(salesOrderItem.Product, out totalBasePrice);
                }

                foreach (SalesOrderItem featureItem in salesOrderItem.OrderedWithFeatures)
                {
                    featureItem.DerivePrices(derivation, quantityOrdered, totalBasePrice);
                }

                salesOrderItem.DerivePrices(derivation, quantityOrdered, totalBasePrice);
                salesOrderItem.DeriveDisplayName();
            }
        }
    }
}
