// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class PurchaseInvoiceItem : Allors.ObjectBase , InvoiceItem
	{
		public static readonly PurchaseInvoiceItemMeta Meta = PurchaseInvoiceItemMeta.Instance;

		public PurchaseInvoiceItem(Allors.IStrategy allors) : base(allors) {}

		public static PurchaseInvoiceItem Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (PurchaseInvoiceItem) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public PurchaseInvoiceItemObjectState PreviousObjectState
		{ 
			get
			{
				return (PurchaseInvoiceItemObjectState) Strategy.GetCompositeRole(Meta.PreviousObjectState);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.PreviousObjectState ,value);
			}
		}

		virtual public bool ExistPreviousObjectState
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.PreviousObjectState);
			}
		}

		virtual public void RemovePreviousObjectState()
		{
			Strategy.RemoveCompositeRole(Meta.PreviousObjectState);
		}


		virtual public PurchaseInvoiceItemType PurchaseInvoiceItemType
		{ 
			get
			{
				return (PurchaseInvoiceItemType) Strategy.GetCompositeRole(Meta.PurchaseInvoiceItemType);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.PurchaseInvoiceItemType ,value);
			}
		}

		virtual public bool ExistPurchaseInvoiceItemType
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.PurchaseInvoiceItemType);
			}
		}

		virtual public void RemovePurchaseInvoiceItemType()
		{
			Strategy.RemoveCompositeRole(Meta.PurchaseInvoiceItemType);
		}


		virtual public Part Part
		{ 
			get
			{
				return (Part) Strategy.GetCompositeRole(Meta.Part);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Part ,value);
			}
		}

		virtual public bool ExistPart
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Part);
			}
		}

		virtual public void RemovePart()
		{
			Strategy.RemoveCompositeRole(Meta.Part);
		}


		virtual public PurchaseInvoiceItemStatus CurrentInvoiceItemStatus
		{ 
			get
			{
				return (PurchaseInvoiceItemStatus) Strategy.GetCompositeRole(Meta.CurrentInvoiceItemStatus);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.CurrentInvoiceItemStatus ,value);
			}
		}

		virtual public bool ExistCurrentInvoiceItemStatus
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.CurrentInvoiceItemStatus);
			}
		}

		virtual public void RemoveCurrentInvoiceItemStatus()
		{
			Strategy.RemoveCompositeRole(Meta.CurrentInvoiceItemStatus);
		}


		virtual public global::Allors.Extent<PurchaseInvoiceItemStatus> InvoiceItemStatuses
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.InvoiceItemStatus);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.InvoiceItemStatus, value);
			}
		}

		virtual public void AddInvoiceItemStatus (PurchaseInvoiceItemStatus value)
		{
			Strategy.AddCompositeRole(Meta.InvoiceItemStatus, value);
		}

		virtual public void RemoveInvoiceItemStatus (PurchaseInvoiceItemStatus value)
		{
			Strategy.RemoveCompositeRole(Meta.InvoiceItemStatus,value);
		}

		virtual public bool ExistInvoiceItemStatuses
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.InvoiceItemStatus);
			}
		}

		virtual public void RemoveInvoiceItemStatuses()
		{
			Strategy.RemoveCompositeRoles(Meta.InvoiceItemStatus);
		}


		virtual public PurchaseInvoiceItemObjectState CurrentObjectState
		{ 
			get
			{
				return (PurchaseInvoiceItemObjectState) Strategy.GetCompositeRole(Meta.CurrentObjectState);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.CurrentObjectState ,value);
			}
		}

		virtual public bool ExistCurrentObjectState
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.CurrentObjectState);
			}
		}

		virtual public void RemoveCurrentObjectState()
		{
			Strategy.RemoveCompositeRole(Meta.CurrentObjectState);
		}



		virtual public global::System.Decimal TotalIncVatCustomerCurrency 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.TotalIncVatCustomerCurrency);
			}
			set
			{
				Strategy.SetUnitRole(Meta.TotalIncVatCustomerCurrency, value);
			}
		}

		virtual public bool ExistTotalIncVatCustomerCurrency{
			get
			{
				return Strategy.ExistUnitRole(Meta.TotalIncVatCustomerCurrency);
			}
		}

		virtual public void RemoveTotalIncVatCustomerCurrency()
		{
			Strategy.RemoveUnitRole(Meta.TotalIncVatCustomerCurrency);
		}


		virtual public global::Allors.Extent<AgreementTerm> InvoiceTerms
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.InvoiceTerm);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.InvoiceTerm, value);
			}
		}

		virtual public void AddInvoiceTerm (AgreementTerm value)
		{
			Strategy.AddCompositeRole(Meta.InvoiceTerm, value);
		}

		virtual public void RemoveInvoiceTerm (AgreementTerm value)
		{
			Strategy.RemoveCompositeRole(Meta.InvoiceTerm,value);
		}

		virtual public bool ExistInvoiceTerms
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.InvoiceTerm);
			}
		}

		virtual public void RemoveInvoiceTerms()
		{
			Strategy.RemoveCompositeRoles(Meta.InvoiceTerm);
		}



		virtual public global::System.Decimal TotalVatCustomerCurrency 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.TotalVatCustomerCurrency);
			}
			set
			{
				Strategy.SetUnitRole(Meta.TotalVatCustomerCurrency, value);
			}
		}

		virtual public bool ExistTotalVatCustomerCurrency{
			get
			{
				return Strategy.ExistUnitRole(Meta.TotalVatCustomerCurrency);
			}
		}

		virtual public void RemoveTotalVatCustomerCurrency()
		{
			Strategy.RemoveUnitRole(Meta.TotalVatCustomerCurrency);
		}



		virtual public global::System.Decimal TotalBasePrice 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.TotalBasePrice);
			}
			set
			{
				Strategy.SetUnitRole(Meta.TotalBasePrice, value);
			}
		}

		virtual public bool ExistTotalBasePrice{
			get
			{
				return Strategy.ExistUnitRole(Meta.TotalBasePrice);
			}
		}

		virtual public void RemoveTotalBasePrice()
		{
			Strategy.RemoveUnitRole(Meta.TotalBasePrice);
		}



		virtual public global::System.Decimal TotalSurcharge 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.TotalSurcharge);
			}
			set
			{
				Strategy.SetUnitRole(Meta.TotalSurcharge, value);
			}
		}

		virtual public bool ExistTotalSurcharge{
			get
			{
				return Strategy.ExistUnitRole(Meta.TotalSurcharge);
			}
		}

		virtual public void RemoveTotalSurcharge()
		{
			Strategy.RemoveUnitRole(Meta.TotalSurcharge);
		}



		virtual public global::System.Decimal TotalInvoiceAdjustment 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.TotalInvoiceAdjustment);
			}
			set
			{
				Strategy.SetUnitRole(Meta.TotalInvoiceAdjustment, value);
			}
		}

		virtual public bool ExistTotalInvoiceAdjustment{
			get
			{
				return Strategy.ExistUnitRole(Meta.TotalInvoiceAdjustment);
			}
		}

		virtual public void RemoveTotalInvoiceAdjustment()
		{
			Strategy.RemoveUnitRole(Meta.TotalInvoiceAdjustment);
		}



		virtual public global::System.Decimal TotalExVatCustomerCurrency 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.TotalExVatCustomerCurrency);
			}
			set
			{
				Strategy.SetUnitRole(Meta.TotalExVatCustomerCurrency, value);
			}
		}

		virtual public bool ExistTotalExVatCustomerCurrency{
			get
			{
				return Strategy.ExistUnitRole(Meta.TotalExVatCustomerCurrency);
			}
		}

		virtual public void RemoveTotalExVatCustomerCurrency()
		{
			Strategy.RemoveUnitRole(Meta.TotalExVatCustomerCurrency);
		}



		virtual public global::System.Decimal TotalDiscount 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.TotalDiscount);
			}
			set
			{
				Strategy.SetUnitRole(Meta.TotalDiscount, value);
			}
		}

		virtual public bool ExistTotalDiscount{
			get
			{
				return Strategy.ExistUnitRole(Meta.TotalDiscount);
			}
		}

		virtual public void RemoveTotalDiscount()
		{
			Strategy.RemoveUnitRole(Meta.TotalDiscount);
		}


		virtual public global::Allors.Extent<InvoiceVatRateItem> InvoiceVatRateItems
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.InvoiceVatRateItem);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.InvoiceVatRateItem, value);
			}
		}

		virtual public void AddInvoiceVatRateItem (InvoiceVatRateItem value)
		{
			Strategy.AddCompositeRole(Meta.InvoiceVatRateItem, value);
		}

		virtual public void RemoveInvoiceVatRateItem (InvoiceVatRateItem value)
		{
			Strategy.RemoveCompositeRole(Meta.InvoiceVatRateItem,value);
		}

		virtual public bool ExistInvoiceVatRateItems
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.InvoiceVatRateItem);
			}
		}

		virtual public void RemoveInvoiceVatRateItems()
		{
			Strategy.RemoveCompositeRoles(Meta.InvoiceVatRateItem);
		}



		virtual public global::System.Decimal TotalDiscountAsPercentage 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.TotalDiscountAsPercentage);
			}
			set
			{
				Strategy.SetUnitRole(Meta.TotalDiscountAsPercentage, value);
			}
		}

		virtual public bool ExistTotalDiscountAsPercentage{
			get
			{
				return Strategy.ExistUnitRole(Meta.TotalDiscountAsPercentage);
			}
		}

		virtual public void RemoveTotalDiscountAsPercentage()
		{
			Strategy.RemoveUnitRole(Meta.TotalDiscountAsPercentage);
		}



		virtual public global::System.Decimal CalculatedUnitPrice 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.CalculatedUnitPrice);
			}
			set
			{
				Strategy.SetUnitRole(Meta.CalculatedUnitPrice, value);
			}
		}

		virtual public bool ExistCalculatedUnitPrice{
			get
			{
				return Strategy.ExistUnitRole(Meta.CalculatedUnitPrice);
			}
		}

		virtual public void RemoveCalculatedUnitPrice()
		{
			Strategy.RemoveUnitRole(Meta.CalculatedUnitPrice);
		}



		virtual public global::System.Decimal UnitDiscount 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.UnitDiscount);
			}
			set
			{
				Strategy.SetUnitRole(Meta.UnitDiscount, value);
			}
		}

		virtual public bool ExistUnitDiscount{
			get
			{
				return Strategy.ExistUnitRole(Meta.UnitDiscount);
			}
		}

		virtual public void RemoveUnitDiscount()
		{
			Strategy.RemoveUnitRole(Meta.UnitDiscount);
		}


		virtual public VatRegime AssignedVatRegime
		{ 
			get
			{
				return (VatRegime) Strategy.GetCompositeRole(Meta.AssignedVatRegime);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.AssignedVatRegime ,value);
			}
		}

		virtual public bool ExistAssignedVatRegime
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.AssignedVatRegime);
			}
		}

		virtual public void RemoveAssignedVatRegime()
		{
			Strategy.RemoveCompositeRole(Meta.AssignedVatRegime);
		}



		virtual public global::System.Decimal TotalIncVat 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.TotalIncVat);
			}
			set
			{
				Strategy.SetUnitRole(Meta.TotalIncVat, value);
			}
		}

		virtual public bool ExistTotalIncVat{
			get
			{
				return Strategy.ExistUnitRole(Meta.TotalIncVat);
			}
		}

		virtual public void RemoveTotalIncVat()
		{
			Strategy.RemoveUnitRole(Meta.TotalIncVat);
		}


		virtual public InvoiceItem AdjustmentFor
		{ 
			get
			{
				return (InvoiceItem) Strategy.GetCompositeRole(Meta.AdjustmentFor);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.AdjustmentFor ,value);
			}
		}

		virtual public bool ExistAdjustmentFor
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.AdjustmentFor);
			}
		}

		virtual public void RemoveAdjustmentFor()
		{
			Strategy.RemoveCompositeRole(Meta.AdjustmentFor);
		}



		virtual public global::System.Decimal UnitBasePrice 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.UnitBasePrice);
			}
			set
			{
				Strategy.SetUnitRole(Meta.UnitBasePrice, value);
			}
		}

		virtual public bool ExistUnitBasePrice{
			get
			{
				return Strategy.ExistUnitRole(Meta.UnitBasePrice);
			}
		}

		virtual public void RemoveUnitBasePrice()
		{
			Strategy.RemoveUnitRole(Meta.UnitBasePrice);
		}



		virtual public global::System.Decimal TotalSurchargeCustomerCurrency 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.TotalSurchargeCustomerCurrency);
			}
			set
			{
				Strategy.SetUnitRole(Meta.TotalSurchargeCustomerCurrency, value);
			}
		}

		virtual public bool ExistTotalSurchargeCustomerCurrency{
			get
			{
				return Strategy.ExistUnitRole(Meta.TotalSurchargeCustomerCurrency);
			}
		}

		virtual public void RemoveTotalSurchargeCustomerCurrency()
		{
			Strategy.RemoveUnitRole(Meta.TotalSurchargeCustomerCurrency);
		}


		virtual public SerializedInventoryItem SerializedInventoryItem
		{ 
			get
			{
				return (SerializedInventoryItem) Strategy.GetCompositeRole(Meta.SerializedInventoryItem);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.SerializedInventoryItem ,value);
			}
		}

		virtual public bool ExistSerializedInventoryItem
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.SerializedInventoryItem);
			}
		}

		virtual public void RemoveSerializedInventoryItem()
		{
			Strategy.RemoveCompositeRole(Meta.SerializedInventoryItem);
		}


		virtual public global::Allors.Extent<PriceComponent> CurrentPriceComponents
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.CurrentPriceComponent);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.CurrentPriceComponent, value);
			}
		}

		virtual public void AddCurrentPriceComponent (PriceComponent value)
		{
			Strategy.AddCompositeRole(Meta.CurrentPriceComponent, value);
		}

		virtual public void RemoveCurrentPriceComponent (PriceComponent value)
		{
			Strategy.RemoveCompositeRole(Meta.CurrentPriceComponent,value);
		}

		virtual public bool ExistCurrentPriceComponents
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.CurrentPriceComponent);
			}
		}

		virtual public void RemoveCurrentPriceComponents()
		{
			Strategy.RemoveCompositeRoles(Meta.CurrentPriceComponent);
		}


		virtual public DiscountAdjustment DiscountAdjustment
		{ 
			get
			{
				return (DiscountAdjustment) Strategy.GetCompositeRole(Meta.DiscountAdjustment);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.DiscountAdjustment ,value);
			}
		}

		virtual public bool ExistDiscountAdjustment
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.DiscountAdjustment);
			}
		}

		virtual public void RemoveDiscountAdjustment()
		{
			Strategy.RemoveCompositeRole(Meta.DiscountAdjustment);
		}



		virtual public global::System.Decimal ActualUnitPrice 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.ActualUnitPrice);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ActualUnitPrice, value);
			}
		}

		virtual public bool ExistActualUnitPrice{
			get
			{
				return Strategy.ExistUnitRole(Meta.ActualUnitPrice);
			}
		}

		virtual public void RemoveActualUnitPrice()
		{
			Strategy.RemoveUnitRole(Meta.ActualUnitPrice);
		}



		virtual public global::System.String Message 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Message);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Message, value);
			}
		}

		virtual public bool ExistMessage{
			get
			{
				return Strategy.ExistUnitRole(Meta.Message);
			}
		}

		virtual public void RemoveMessage()
		{
			Strategy.RemoveUnitRole(Meta.Message);
		}



		virtual public global::System.Decimal TotalInvoiceAdjustmentCustomerCurrency 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.TotalInvoiceAdjustmentCustomerCurrency);
			}
			set
			{
				Strategy.SetUnitRole(Meta.TotalInvoiceAdjustmentCustomerCurrency, value);
			}
		}

		virtual public bool ExistTotalInvoiceAdjustmentCustomerCurrency{
			get
			{
				return Strategy.ExistUnitRole(Meta.TotalInvoiceAdjustmentCustomerCurrency);
			}
		}

		virtual public void RemoveTotalInvoiceAdjustmentCustomerCurrency()
		{
			Strategy.RemoveUnitRole(Meta.TotalInvoiceAdjustmentCustomerCurrency);
		}



		virtual public global::System.Decimal AmountPaid 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.AmountPaid);
			}
			set
			{
				Strategy.SetUnitRole(Meta.AmountPaid, value);
			}
		}

		virtual public bool ExistAmountPaid{
			get
			{
				return Strategy.ExistUnitRole(Meta.AmountPaid);
			}
		}

		virtual public void RemoveAmountPaid()
		{
			Strategy.RemoveUnitRole(Meta.AmountPaid);
		}


		virtual public VatRate DerivedVatRate
		{ 
			get
			{
				return (VatRate) Strategy.GetCompositeRole(Meta.DerivedVatRate);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.DerivedVatRate ,value);
			}
		}

		virtual public bool ExistDerivedVatRate
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.DerivedVatRate);
			}
		}

		virtual public void RemoveDerivedVatRate()
		{
			Strategy.RemoveCompositeRole(Meta.DerivedVatRate);
		}



		virtual public global::System.Decimal TotalDiscountCustomerCurrency 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.TotalDiscountCustomerCurrency);
			}
			set
			{
				Strategy.SetUnitRole(Meta.TotalDiscountCustomerCurrency, value);
			}
		}

		virtual public bool ExistTotalDiscountCustomerCurrency{
			get
			{
				return Strategy.ExistUnitRole(Meta.TotalDiscountCustomerCurrency);
			}
		}

		virtual public void RemoveTotalDiscountCustomerCurrency()
		{
			Strategy.RemoveUnitRole(Meta.TotalDiscountCustomerCurrency);
		}



		virtual public global::System.Decimal UnitSurcharge 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.UnitSurcharge);
			}
			set
			{
				Strategy.SetUnitRole(Meta.UnitSurcharge, value);
			}
		}

		virtual public bool ExistUnitSurcharge{
			get
			{
				return Strategy.ExistUnitRole(Meta.UnitSurcharge);
			}
		}

		virtual public void RemoveUnitSurcharge()
		{
			Strategy.RemoveUnitRole(Meta.UnitSurcharge);
		}



		virtual public global::System.Decimal TotalExVat 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.TotalExVat);
			}
			set
			{
				Strategy.SetUnitRole(Meta.TotalExVat, value);
			}
		}

		virtual public bool ExistTotalExVat{
			get
			{
				return Strategy.ExistUnitRole(Meta.TotalExVat);
			}
		}

		virtual public void RemoveTotalExVat()
		{
			Strategy.RemoveUnitRole(Meta.TotalExVat);
		}



		virtual public global::System.Decimal Quantity 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.Quantity);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Quantity, value);
			}
		}

		virtual public bool ExistQuantity{
			get
			{
				return Strategy.ExistUnitRole(Meta.Quantity);
			}
		}

		virtual public void RemoveQuantity()
		{
			Strategy.RemoveUnitRole(Meta.Quantity);
		}



		virtual public global::System.Decimal TotalSurchargeAsPercentage 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.TotalSurchargeAsPercentage);
			}
			set
			{
				Strategy.SetUnitRole(Meta.TotalSurchargeAsPercentage, value);
			}
		}

		virtual public bool ExistTotalSurchargeAsPercentage{
			get
			{
				return Strategy.ExistUnitRole(Meta.TotalSurchargeAsPercentage);
			}
		}

		virtual public void RemoveTotalSurchargeAsPercentage()
		{
			Strategy.RemoveUnitRole(Meta.TotalSurchargeAsPercentage);
		}


		virtual public VatRegime VatRegime
		{ 
			get
			{
				return (VatRegime) Strategy.GetCompositeRole(Meta.VatRegime);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.VatRegime ,value);
			}
		}

		virtual public bool ExistVatRegime
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.VatRegime);
			}
		}

		virtual public void RemoveVatRegime()
		{
			Strategy.RemoveCompositeRole(Meta.VatRegime);
		}



		virtual public global::System.Decimal TotalBasePriceCustomerCurrency 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.TotalBasePriceCustomerCurrency);
			}
			set
			{
				Strategy.SetUnitRole(Meta.TotalBasePriceCustomerCurrency, value);
			}
		}

		virtual public bool ExistTotalBasePriceCustomerCurrency{
			get
			{
				return Strategy.ExistUnitRole(Meta.TotalBasePriceCustomerCurrency);
			}
		}

		virtual public void RemoveTotalBasePriceCustomerCurrency()
		{
			Strategy.RemoveUnitRole(Meta.TotalBasePriceCustomerCurrency);
		}



		virtual public global::System.Decimal TotalVat 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.TotalVat);
			}
			set
			{
				Strategy.SetUnitRole(Meta.TotalVat, value);
			}
		}

		virtual public bool ExistTotalVat{
			get
			{
				return Strategy.ExistUnitRole(Meta.TotalVat);
			}
		}

		virtual public void RemoveTotalVat()
		{
			Strategy.RemoveUnitRole(Meta.TotalVat);
		}


		virtual public SurchargeAdjustment SurchargeAdjustment
		{ 
			get
			{
				return (SurchargeAdjustment) Strategy.GetCompositeRole(Meta.SurchargeAdjustment);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.SurchargeAdjustment ,value);
			}
		}

		virtual public bool ExistSurchargeAdjustment
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.SurchargeAdjustment);
			}
		}

		virtual public void RemoveSurchargeAdjustment()
		{
			Strategy.RemoveCompositeRole(Meta.SurchargeAdjustment);
		}



		virtual public global::System.Decimal UnitVat 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.UnitVat);
			}
			set
			{
				Strategy.SetUnitRole(Meta.UnitVat, value);
			}
		}

		virtual public bool ExistUnitVat{
			get
			{
				return Strategy.ExistUnitRole(Meta.UnitVat);
			}
		}

		virtual public void RemoveUnitVat()
		{
			Strategy.RemoveUnitRole(Meta.UnitVat);
		}



		virtual public global::System.String Description 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Description);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Description, value);
			}
		}

		virtual public bool ExistDescription{
			get
			{
				return Strategy.ExistUnitRole(Meta.Description);
			}
		}

		virtual public void RemoveDescription()
		{
			Strategy.RemoveUnitRole(Meta.Description);
		}



		virtual public global::System.String DisplayName 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.DisplayName);
			}
			set
			{
				Strategy.SetUnitRole(Meta.DisplayName, value);
			}
		}

		virtual public bool ExistDisplayName{
			get
			{
				return Strategy.ExistUnitRole(Meta.DisplayName);
			}
		}

		virtual public void RemoveDisplayName()
		{
			Strategy.RemoveUnitRole(Meta.DisplayName);
		}


		virtual public global::Allors.Extent<Permission> DeniedPermissions
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.DeniedPermission);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.DeniedPermission, value);
			}
		}

		virtual public void AddDeniedPermission (Permission value)
		{
			Strategy.AddCompositeRole(Meta.DeniedPermission, value);
		}

		virtual public void RemoveDeniedPermission (Permission value)
		{
			Strategy.RemoveCompositeRole(Meta.DeniedPermission,value);
		}

		virtual public bool ExistDeniedPermissions
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.DeniedPermission);
			}
		}

		virtual public void RemoveDeniedPermissions()
		{
			Strategy.RemoveCompositeRoles(Meta.DeniedPermission);
		}


		virtual public global::Allors.Extent<SecurityToken> SecurityTokens
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.SecurityToken);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.SecurityToken, value);
			}
		}

		virtual public void AddSecurityToken (SecurityToken value)
		{
			Strategy.AddCompositeRole(Meta.SecurityToken, value);
		}

		virtual public void RemoveSecurityToken (SecurityToken value)
		{
			Strategy.RemoveCompositeRole(Meta.SecurityToken,value);
		}

		virtual public bool ExistSecurityTokens
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.SecurityToken);
			}
		}

		virtual public void RemoveSecurityTokens()
		{
			Strategy.RemoveCompositeRoles(Meta.SecurityToken);
		}



		virtual public PurchaseInvoice PurchaseInvoiceWherePurchaseInvoiceItem
		{ 
			get
			{
				return (PurchaseInvoice) Strategy.GetCompositeAssociation(Meta.PurchaseInvoiceWherePurchaseInvoiceItem);
			}
		} 

		virtual public bool ExistPurchaseInvoiceWherePurchaseInvoiceItem
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.PurchaseInvoiceWherePurchaseInvoiceItem);
			}
		}


		virtual public global::Allors.Extent<WorkEffortBilling> WorkEffortBillingsWhereInvoiceItem
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.WorkEffortBillingsWhereInvoiceItem);
			}
		}

		virtual public bool ExistWorkEffortBillingsWhereInvoiceItem
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.WorkEffortBillingsWhereInvoiceItem);
			}
		}


		virtual public global::Allors.Extent<ServiceEntryBilling> ServiceEntryBillingsWhereInvoiceItem
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ServiceEntryBillingsWhereInvoiceItem);
			}
		}

		virtual public bool ExistServiceEntryBillingsWhereInvoiceItem
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ServiceEntryBillingsWhereInvoiceItem);
			}
		}


		virtual public global::Allors.Extent<PaymentApplication> PaymentApplicationsWhereInvoiceItem
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PaymentApplicationsWhereInvoiceItem);
			}
		}

		virtual public bool ExistPaymentApplicationsWhereInvoiceItem
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PaymentApplicationsWhereInvoiceItem);
			}
		}


		virtual public ShipmentItem ShipmentItemWhereInvoiceItem
		{ 
			get
			{
				return (ShipmentItem) Strategy.GetCompositeAssociation(Meta.ShipmentItemWhereInvoiceItem);
			}
		} 

		virtual public bool ExistShipmentItemWhereInvoiceItem
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.ShipmentItemWhereInvoiceItem);
			}
		}


		virtual public global::Allors.Extent<InvoiceItem> InvoiceItemsWhereAdjustmentFor
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.InvoiceItemsWhereAdjustmentFor);
			}
		}

		virtual public bool ExistInvoiceItemsWhereAdjustmentFor
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.InvoiceItemsWhereAdjustmentFor);
			}
		}

	}

	public class PurchaseInvoiceItemMeta
	{
		public static readonly PurchaseInvoiceItemMeta Instance = new PurchaseInvoiceItemMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.PurchaseInvoiceItem;

		public global::Allors.Meta.RoleType PreviousObjectState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PurchaseInvoiceItemPreviousObjectState;
			}
		} 
		public global::Allors.Meta.RoleType PurchaseInvoiceItemType 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PurchaseInvoiceItemPurchaseInvoiceItemType;
			}
		} 
		public global::Allors.Meta.RoleType Part 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PurchaseInvoiceItemPart;
			}
		} 
		public global::Allors.Meta.RoleType CurrentInvoiceItemStatus 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PurchaseInvoiceItemCurrentInvoiceItemStatus;
			}
		} 
		public global::Allors.Meta.RoleType InvoiceItemStatus 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PurchaseInvoiceItemInvoiceItemStatus;
			}
		} 
		public global::Allors.Meta.RoleType CurrentObjectState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PurchaseInvoiceItemCurrentObjectState;
			}
		} 
		public global::Allors.Meta.RoleType TotalIncVatCustomerCurrency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemTotalIncVatCustomerCurrency;
			}
		} 
		public global::Allors.Meta.RoleType InvoiceTerm 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemInvoiceTerm;
			}
		} 
		public global::Allors.Meta.RoleType TotalVatCustomerCurrency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemTotalVatCustomerCurrency;
			}
		} 
		public global::Allors.Meta.RoleType TotalBasePrice 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemTotalBasePrice;
			}
		} 
		public global::Allors.Meta.RoleType TotalSurcharge 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemTotalSurcharge;
			}
		} 
		public global::Allors.Meta.RoleType TotalInvoiceAdjustment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemTotalInvoiceAdjustment;
			}
		} 
		public global::Allors.Meta.RoleType TotalExVatCustomerCurrency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemTotalExVatCustomerCurrency;
			}
		} 
		public global::Allors.Meta.RoleType TotalDiscount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemTotalDiscount;
			}
		} 
		public global::Allors.Meta.RoleType InvoiceVatRateItem 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemInvoiceVatRateItem;
			}
		} 
		public global::Allors.Meta.RoleType TotalDiscountAsPercentage 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemTotalDiscountAsPercentage;
			}
		} 
		public global::Allors.Meta.RoleType CalculatedUnitPrice 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemCalculatedUnitPrice;
			}
		} 
		public global::Allors.Meta.RoleType UnitDiscount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemUnitDiscount;
			}
		} 
		public global::Allors.Meta.RoleType AssignedVatRegime 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemAssignedVatRegime;
			}
		} 
		public global::Allors.Meta.RoleType TotalIncVat 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemTotalIncVat;
			}
		} 
		public global::Allors.Meta.RoleType AdjustmentFor 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemAdjustmentFor;
			}
		} 
		public global::Allors.Meta.RoleType UnitBasePrice 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemUnitBasePrice;
			}
		} 
		public global::Allors.Meta.RoleType TotalSurchargeCustomerCurrency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemTotalSurchargeCustomerCurrency;
			}
		} 
		public global::Allors.Meta.RoleType SerializedInventoryItem 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemSerializedInventoryItem;
			}
		} 
		public global::Allors.Meta.RoleType CurrentPriceComponent 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemCurrentPriceComponent;
			}
		} 
		public global::Allors.Meta.RoleType DiscountAdjustment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemDiscountAdjustment;
			}
		} 
		public global::Allors.Meta.RoleType ActualUnitPrice 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemActualUnitPrice;
			}
		} 
		public global::Allors.Meta.RoleType Message 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemMessage;
			}
		} 
		public global::Allors.Meta.RoleType TotalInvoiceAdjustmentCustomerCurrency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemTotalInvoiceAdjustmentCustomerCurrency;
			}
		} 
		public global::Allors.Meta.RoleType AmountPaid 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemAmountPaid;
			}
		} 
		public global::Allors.Meta.RoleType DerivedVatRate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemDerivedVatRate;
			}
		} 
		public global::Allors.Meta.RoleType TotalDiscountCustomerCurrency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemTotalDiscountCustomerCurrency;
			}
		} 
		public global::Allors.Meta.RoleType UnitSurcharge 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemUnitSurcharge;
			}
		} 
		public global::Allors.Meta.RoleType TotalExVat 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemTotalExVat;
			}
		} 
		public global::Allors.Meta.RoleType Quantity 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemQuantity;
			}
		} 
		public global::Allors.Meta.RoleType TotalSurchargeAsPercentage 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemTotalSurchargeAsPercentage;
			}
		} 
		public global::Allors.Meta.RoleType VatRegime 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemVatRegime;
			}
		} 
		public global::Allors.Meta.RoleType TotalBasePriceCustomerCurrency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemTotalBasePriceCustomerCurrency;
			}
		} 
		public global::Allors.Meta.RoleType TotalVat 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemTotalVat;
			}
		} 
		public global::Allors.Meta.RoleType SurchargeAdjustment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemSurchargeAdjustment;
			}
		} 
		public global::Allors.Meta.RoleType UnitVat 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemUnitVat;
			}
		} 
		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceItemDescription;
			}
		} 
		public global::Allors.Meta.RoleType DisplayName 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UserInterfaceableDisplayName;
			}
		} 
		public global::Allors.Meta.RoleType DeniedPermission 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AccessControlledObjectDeniedPermission;
			}
		} 
		public global::Allors.Meta.RoleType SecurityToken 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AccessControlledObjectSecurityToken;
			}
		} 

		public global::Allors.Meta.AssociationType PurchaseInvoiceWherePurchaseInvoiceItem 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseInvoicePurchaseInvoiceItem;
			}
		} 
		public global::Allors.Meta.AssociationType WorkEffortBillingsWhereInvoiceItem 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.WorkEffortBillingInvoiceItem;
			}
		} 
		public global::Allors.Meta.AssociationType ServiceEntryBillingsWhereInvoiceItem 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ServiceEntryBillingInvoiceItem;
			}
		} 
		public global::Allors.Meta.AssociationType PaymentApplicationsWhereInvoiceItem 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PaymentApplicationInvoiceItem;
			}
		} 
		public global::Allors.Meta.AssociationType ShipmentItemWhereInvoiceItem 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ShipmentItemInvoiceItem;
			}
		} 
		public global::Allors.Meta.AssociationType InvoiceItemsWhereAdjustmentFor 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InvoiceItemAdjustmentFor;
			}
		} 

	}
}