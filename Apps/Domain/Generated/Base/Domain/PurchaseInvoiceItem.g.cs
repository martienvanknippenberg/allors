// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class PurchaseInvoiceItem
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (PurchaseInvoiceItemBuilder)objectBuilder;
			

			if(builder.TotalIncVatCustomerCurrency.HasValue)
			{
				this.TotalIncVatCustomerCurrency = builder.TotalIncVatCustomerCurrency.Value;
			}			
					

			if(builder.TotalVatCustomerCurrency.HasValue)
			{
				this.TotalVatCustomerCurrency = builder.TotalVatCustomerCurrency.Value;
			}			
					

			if(builder.TotalBasePrice.HasValue)
			{
				this.TotalBasePrice = builder.TotalBasePrice.Value;
			}			
					

			if(builder.TotalSurcharge.HasValue)
			{
				this.TotalSurcharge = builder.TotalSurcharge.Value;
			}			
					

			if(builder.TotalInvoiceAdjustment.HasValue)
			{
				this.TotalInvoiceAdjustment = builder.TotalInvoiceAdjustment.Value;
			}			
					

			if(builder.TotalExVatCustomerCurrency.HasValue)
			{
				this.TotalExVatCustomerCurrency = builder.TotalExVatCustomerCurrency.Value;
			}			
					

			if(builder.TotalDiscount.HasValue)
			{
				this.TotalDiscount = builder.TotalDiscount.Value;
			}			
					

			if(builder.TotalDiscountAsPercentage.HasValue)
			{
				this.TotalDiscountAsPercentage = builder.TotalDiscountAsPercentage.Value;
			}			
					

			if(builder.CalculatedUnitPrice.HasValue)
			{
				this.CalculatedUnitPrice = builder.CalculatedUnitPrice.Value;
			}			
					

			if(builder.UnitDiscount.HasValue)
			{
				this.UnitDiscount = builder.UnitDiscount.Value;
			}			
					

			if(builder.TotalIncVat.HasValue)
			{
				this.TotalIncVat = builder.TotalIncVat.Value;
			}			
					

			if(builder.UnitBasePrice.HasValue)
			{
				this.UnitBasePrice = builder.UnitBasePrice.Value;
			}			
					

			if(builder.TotalSurchargeCustomerCurrency.HasValue)
			{
				this.TotalSurchargeCustomerCurrency = builder.TotalSurchargeCustomerCurrency.Value;
			}			
					

			if(builder.ActualUnitPrice.HasValue)
			{
				this.ActualUnitPrice = builder.ActualUnitPrice.Value;
			}			
		

			this.Message = builder.Message;
					

			if(builder.TotalInvoiceAdjustmentCustomerCurrency.HasValue)
			{
				this.TotalInvoiceAdjustmentCustomerCurrency = builder.TotalInvoiceAdjustmentCustomerCurrency.Value;
			}			
					

			if(builder.AmountPaid.HasValue)
			{
				this.AmountPaid = builder.AmountPaid.Value;
			}			
					

			if(builder.TotalDiscountCustomerCurrency.HasValue)
			{
				this.TotalDiscountCustomerCurrency = builder.TotalDiscountCustomerCurrency.Value;
			}			
					

			if(builder.UnitSurcharge.HasValue)
			{
				this.UnitSurcharge = builder.UnitSurcharge.Value;
			}			
					

			if(builder.TotalExVat.HasValue)
			{
				this.TotalExVat = builder.TotalExVat.Value;
			}			
					

			if(builder.Quantity.HasValue)
			{
				this.Quantity = builder.Quantity.Value;
			}			
					

			if(builder.TotalSurchargeAsPercentage.HasValue)
			{
				this.TotalSurchargeAsPercentage = builder.TotalSurchargeAsPercentage.Value;
			}			
					

			if(builder.TotalBasePriceCustomerCurrency.HasValue)
			{
				this.TotalBasePriceCustomerCurrency = builder.TotalBasePriceCustomerCurrency.Value;
			}			
					

			if(builder.TotalVat.HasValue)
			{
				this.TotalVat = builder.TotalVat.Value;
			}			
					

			if(builder.UnitVat.HasValue)
			{
				this.UnitVat = builder.UnitVat.Value;
			}			
		

			this.Description = builder.Description;
		

			this.DisplayName = builder.DisplayName;
		

			this.PreviousObjectState = builder.PreviousObjectState;



			this.PurchaseInvoiceItemType = builder.PurchaseInvoiceItemType;



			this.Part = builder.Part;



			this.CurrentInvoiceItemStatus = builder.CurrentInvoiceItemStatus;


			if(builder.InvoiceItemStatuses!=null)
			{
				this.InvoiceItemStatuses = builder.InvoiceItemStatuses.ToArray();
			}


			this.CurrentObjectState = builder.CurrentObjectState;


			if(builder.InvoiceTerms!=null)
			{
				this.InvoiceTerms = builder.InvoiceTerms.ToArray();
			}

			if(builder.InvoiceVatRateItems!=null)
			{
				this.InvoiceVatRateItems = builder.InvoiceVatRateItems.ToArray();
			}


			this.AssignedVatRegime = builder.AssignedVatRegime;



			this.AdjustmentFor = builder.AdjustmentFor;



			this.SerializedInventoryItem = builder.SerializedInventoryItem;


			if(builder.CurrentPriceComponents!=null)
			{
				this.CurrentPriceComponents = builder.CurrentPriceComponents.ToArray();
			}


			this.DiscountAdjustment = builder.DiscountAdjustment;



			this.DerivedVatRate = builder.DerivedVatRate;



			this.VatRegime = builder.VatRegime;



			this.SurchargeAdjustment = builder.SurchargeAdjustment;


			if(builder.DeniedPermissions!=null)
			{
				this.DeniedPermissions = builder.DeniedPermissions.ToArray();
			}

			if(builder.SecurityTokens!=null)
			{
				this.SecurityTokens = builder.SecurityTokens.ToArray();
			}

		}
	}

	public partial class PurchaseInvoiceItemBuilder : Allors.ObjectBuilder<PurchaseInvoiceItem> , InvoiceItemBuilder, global::System.IDisposable
	{		
		public PurchaseInvoiceItemBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public PurchaseInvoiceItemObjectState PreviousObjectState {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithPreviousObjectState(PurchaseInvoiceItemObjectState value)
		        {
		            if(this.PreviousObjectState!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.PreviousObjectState = value;
		            return this;
		        }		

				
				public PurchaseInvoiceItemType PurchaseInvoiceItemType {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithPurchaseInvoiceItemType(PurchaseInvoiceItemType value)
		        {
		            if(this.PurchaseInvoiceItemType!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.PurchaseInvoiceItemType = value;
		            return this;
		        }		

				
				public Part Part {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithPart(Part value)
		        {
		            if(this.Part!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Part = value;
		            return this;
		        }		

				
				public PurchaseInvoiceItemStatus CurrentInvoiceItemStatus {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithCurrentInvoiceItemStatus(PurchaseInvoiceItemStatus value)
		        {
		            if(this.CurrentInvoiceItemStatus!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.CurrentInvoiceItemStatus = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<PurchaseInvoiceItemStatus> InvoiceItemStatuses {get; set;}	

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithInvoiceItemStatus(PurchaseInvoiceItemStatus value)
		        {
					if(this.InvoiceItemStatuses == null)
					{
						this.InvoiceItemStatuses = new global::System.Collections.Generic.List<PurchaseInvoiceItemStatus>(); 
					}
		            this.InvoiceItemStatuses.Add(value);
		            return this;
		        }		

				
				public PurchaseInvoiceItemObjectState CurrentObjectState {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithCurrentObjectState(PurchaseInvoiceItemObjectState value)
		        {
		            if(this.CurrentObjectState!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.CurrentObjectState = value;
		            return this;
		        }		

				
				public global::System.Decimal? TotalIncVatCustomerCurrency {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithTotalIncVatCustomerCurrency(global::System.Decimal? value)
		        {
				    if(this.TotalIncVatCustomerCurrency!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.TotalIncVatCustomerCurrency = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<AgreementTerm> InvoiceTerms {get; set;}	

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithInvoiceTerm(AgreementTerm value)
		        {
					if(this.InvoiceTerms == null)
					{
						this.InvoiceTerms = new global::System.Collections.Generic.List<AgreementTerm>(); 
					}
		            this.InvoiceTerms.Add(value);
		            return this;
		        }		

				
				public global::System.Decimal? TotalVatCustomerCurrency {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithTotalVatCustomerCurrency(global::System.Decimal? value)
		        {
				    if(this.TotalVatCustomerCurrency!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.TotalVatCustomerCurrency = value;
		            return this;
		        }	

				public global::System.Decimal? TotalBasePrice {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithTotalBasePrice(global::System.Decimal? value)
		        {
				    if(this.TotalBasePrice!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.TotalBasePrice = value;
		            return this;
		        }	

				public global::System.Decimal? TotalSurcharge {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithTotalSurcharge(global::System.Decimal? value)
		        {
				    if(this.TotalSurcharge!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.TotalSurcharge = value;
		            return this;
		        }	

				public global::System.Decimal? TotalInvoiceAdjustment {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithTotalInvoiceAdjustment(global::System.Decimal? value)
		        {
				    if(this.TotalInvoiceAdjustment!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.TotalInvoiceAdjustment = value;
		            return this;
		        }	

				public global::System.Decimal? TotalExVatCustomerCurrency {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithTotalExVatCustomerCurrency(global::System.Decimal? value)
		        {
				    if(this.TotalExVatCustomerCurrency!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.TotalExVatCustomerCurrency = value;
		            return this;
		        }	

				public global::System.Decimal? TotalDiscount {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithTotalDiscount(global::System.Decimal? value)
		        {
				    if(this.TotalDiscount!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.TotalDiscount = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<InvoiceVatRateItem> InvoiceVatRateItems {get; set;}	

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithInvoiceVatRateItem(InvoiceVatRateItem value)
		        {
					if(this.InvoiceVatRateItems == null)
					{
						this.InvoiceVatRateItems = new global::System.Collections.Generic.List<InvoiceVatRateItem>(); 
					}
		            this.InvoiceVatRateItems.Add(value);
		            return this;
		        }		

				
				public global::System.Decimal? TotalDiscountAsPercentage {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithTotalDiscountAsPercentage(global::System.Decimal? value)
		        {
				    if(this.TotalDiscountAsPercentage!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.TotalDiscountAsPercentage = value;
		            return this;
		        }	

				public global::System.Decimal? CalculatedUnitPrice {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithCalculatedUnitPrice(global::System.Decimal? value)
		        {
				    if(this.CalculatedUnitPrice!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.CalculatedUnitPrice = value;
		            return this;
		        }	

				public global::System.Decimal? UnitDiscount {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithUnitDiscount(global::System.Decimal? value)
		        {
				    if(this.UnitDiscount!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UnitDiscount = value;
		            return this;
		        }	

				public VatRegime AssignedVatRegime {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithAssignedVatRegime(VatRegime value)
		        {
		            if(this.AssignedVatRegime!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.AssignedVatRegime = value;
		            return this;
		        }		

				
				public global::System.Decimal? TotalIncVat {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithTotalIncVat(global::System.Decimal? value)
		        {
				    if(this.TotalIncVat!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.TotalIncVat = value;
		            return this;
		        }	

				public InvoiceItem AdjustmentFor {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithAdjustmentFor(InvoiceItem value)
		        {
		            if(this.AdjustmentFor!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.AdjustmentFor = value;
		            return this;
		        }		

				
				public global::System.Decimal? UnitBasePrice {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithUnitBasePrice(global::System.Decimal? value)
		        {
				    if(this.UnitBasePrice!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UnitBasePrice = value;
		            return this;
		        }	

				public global::System.Decimal? TotalSurchargeCustomerCurrency {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithTotalSurchargeCustomerCurrency(global::System.Decimal? value)
		        {
				    if(this.TotalSurchargeCustomerCurrency!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.TotalSurchargeCustomerCurrency = value;
		            return this;
		        }	

				public SerializedInventoryItem SerializedInventoryItem {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithSerializedInventoryItem(SerializedInventoryItem value)
		        {
		            if(this.SerializedInventoryItem!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SerializedInventoryItem = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<PriceComponent> CurrentPriceComponents {get; set;}	

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithCurrentPriceComponent(PriceComponent value)
		        {
					if(this.CurrentPriceComponents == null)
					{
						this.CurrentPriceComponents = new global::System.Collections.Generic.List<PriceComponent>(); 
					}
		            this.CurrentPriceComponents.Add(value);
		            return this;
		        }		

				
				public DiscountAdjustment DiscountAdjustment {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithDiscountAdjustment(DiscountAdjustment value)
		        {
		            if(this.DiscountAdjustment!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.DiscountAdjustment = value;
		            return this;
		        }		

				
				public global::System.Decimal? ActualUnitPrice {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithActualUnitPrice(global::System.Decimal? value)
		        {
				    if(this.ActualUnitPrice!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ActualUnitPrice = value;
		            return this;
		        }	

				public global::System.String Message {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithMessage(global::System.String value)
		        {
				    if(this.Message!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Message = value;
		            return this;
		        }	

				public global::System.Decimal? TotalInvoiceAdjustmentCustomerCurrency {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithTotalInvoiceAdjustmentCustomerCurrency(global::System.Decimal? value)
		        {
				    if(this.TotalInvoiceAdjustmentCustomerCurrency!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.TotalInvoiceAdjustmentCustomerCurrency = value;
		            return this;
		        }	

				public global::System.Decimal? AmountPaid {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithAmountPaid(global::System.Decimal? value)
		        {
				    if(this.AmountPaid!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.AmountPaid = value;
		            return this;
		        }	

				public VatRate DerivedVatRate {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithDerivedVatRate(VatRate value)
		        {
		            if(this.DerivedVatRate!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.DerivedVatRate = value;
		            return this;
		        }		

				
				public global::System.Decimal? TotalDiscountCustomerCurrency {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithTotalDiscountCustomerCurrency(global::System.Decimal? value)
		        {
				    if(this.TotalDiscountCustomerCurrency!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.TotalDiscountCustomerCurrency = value;
		            return this;
		        }	

				public global::System.Decimal? UnitSurcharge {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithUnitSurcharge(global::System.Decimal? value)
		        {
				    if(this.UnitSurcharge!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UnitSurcharge = value;
		            return this;
		        }	

				public global::System.Decimal? TotalExVat {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithTotalExVat(global::System.Decimal? value)
		        {
				    if(this.TotalExVat!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.TotalExVat = value;
		            return this;
		        }	

				public global::System.Decimal? Quantity {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithQuantity(global::System.Decimal? value)
		        {
				    if(this.Quantity!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Quantity = value;
		            return this;
		        }	

				public global::System.Decimal? TotalSurchargeAsPercentage {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithTotalSurchargeAsPercentage(global::System.Decimal? value)
		        {
				    if(this.TotalSurchargeAsPercentage!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.TotalSurchargeAsPercentage = value;
		            return this;
		        }	

				public VatRegime VatRegime {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithVatRegime(VatRegime value)
		        {
		            if(this.VatRegime!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.VatRegime = value;
		            return this;
		        }		

				
				public global::System.Decimal? TotalBasePriceCustomerCurrency {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithTotalBasePriceCustomerCurrency(global::System.Decimal? value)
		        {
				    if(this.TotalBasePriceCustomerCurrency!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.TotalBasePriceCustomerCurrency = value;
		            return this;
		        }	

				public global::System.Decimal? TotalVat {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithTotalVat(global::System.Decimal? value)
		        {
				    if(this.TotalVat!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.TotalVat = value;
		            return this;
		        }	

				public SurchargeAdjustment SurchargeAdjustment {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithSurchargeAdjustment(SurchargeAdjustment value)
		        {
		            if(this.SurchargeAdjustment!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SurchargeAdjustment = value;
		            return this;
		        }		

				
				public global::System.Decimal? UnitVat {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithUnitVat(global::System.Decimal? value)
		        {
				    if(this.UnitVat!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UnitVat = value;
		            return this;
		        }	

				public global::System.String Description {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithDescription(global::System.String value)
		        {
				    if(this.Description!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Description = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithDeniedPermission(Permission value)
		        {
					if(this.DeniedPermissions == null)
					{
						this.DeniedPermissions = new global::System.Collections.Generic.List<Permission>(); 
					}
		            this.DeniedPermissions.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<SecurityToken> SecurityTokens {get; set;}	

				/// <exclude/>
				public PurchaseInvoiceItemBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class PurchaseInvoiceItems : global::Allors.ObjectsBase<PurchaseInvoiceItem>
	{
		public static readonly PurchaseInvoiceItemMeta Meta = PurchaseInvoiceItemMeta.Instance;

		public PurchaseInvoiceItems(Allors.ISession session) : base(session)
		{
		}

		public override Allors.Meta.Composite ObjectType
		{
			get
			{
				return Meta.ObjectType;
			}
		}
	}

}