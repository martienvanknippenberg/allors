// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class RecurringCharge : Allors.ObjectBase , PriceComponent
	{
		public static readonly RecurringChargeMeta Meta = RecurringChargeMeta.Instance;

		public RecurringCharge(Allors.IStrategy allors) : base(allors) {}

		public static RecurringCharge Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (RecurringCharge) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public TimeFrequency TimeFrequency
		{ 
			get
			{
				return (TimeFrequency) Strategy.GetCompositeRole(Meta.TimeFrequency);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.TimeFrequency ,value);
			}
		}

		virtual public bool ExistTimeFrequency
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.TimeFrequency);
			}
		}

		virtual public void RemoveTimeFrequency()
		{
			Strategy.RemoveCompositeRole(Meta.TimeFrequency);
		}


		virtual public GeographicBoundary GeographicBoundary
		{ 
			get
			{
				return (GeographicBoundary) Strategy.GetCompositeRole(Meta.GeographicBoundary);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.GeographicBoundary ,value);
			}
		}

		virtual public bool ExistGeographicBoundary
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.GeographicBoundary);
			}
		}

		virtual public void RemoveGeographicBoundary()
		{
			Strategy.RemoveCompositeRole(Meta.GeographicBoundary);
		}



		virtual public global::System.Decimal Rate 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.Rate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Rate, value);
			}
		}

		virtual public bool ExistRate{
			get
			{
				return Strategy.ExistUnitRole(Meta.Rate);
			}
		}

		virtual public void RemoveRate()
		{
			Strategy.RemoveUnitRole(Meta.Rate);
		}


		virtual public RevenueValueBreak RevenueValueBreak
		{ 
			get
			{
				return (RevenueValueBreak) Strategy.GetCompositeRole(Meta.RevenueValueBreak);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.RevenueValueBreak ,value);
			}
		}

		virtual public bool ExistRevenueValueBreak
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.RevenueValueBreak);
			}
		}

		virtual public void RemoveRevenueValueBreak()
		{
			Strategy.RemoveCompositeRole(Meta.RevenueValueBreak);
		}


		virtual public PartyClassification PartyClassification
		{ 
			get
			{
				return (PartyClassification) Strategy.GetCompositeRole(Meta.PartyClassification);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.PartyClassification ,value);
			}
		}

		virtual public bool ExistPartyClassification
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.PartyClassification);
			}
		}

		virtual public void RemovePartyClassification()
		{
			Strategy.RemoveCompositeRole(Meta.PartyClassification);
		}


		virtual public OrderQuantityBreak OrderQuantityBreak
		{ 
			get
			{
				return (OrderQuantityBreak) Strategy.GetCompositeRole(Meta.OrderQuantityBreak);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.OrderQuantityBreak ,value);
			}
		}

		virtual public bool ExistOrderQuantityBreak
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.OrderQuantityBreak);
			}
		}

		virtual public void RemoveOrderQuantityBreak()
		{
			Strategy.RemoveCompositeRole(Meta.OrderQuantityBreak);
		}


		virtual public PackageQuantityBreak PackageQuantityBreak
		{ 
			get
			{
				return (PackageQuantityBreak) Strategy.GetCompositeRole(Meta.PackageQuantityBreak);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.PackageQuantityBreak ,value);
			}
		}

		virtual public bool ExistPackageQuantityBreak
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.PackageQuantityBreak);
			}
		}

		virtual public void RemovePackageQuantityBreak()
		{
			Strategy.RemoveCompositeRole(Meta.PackageQuantityBreak);
		}


		virtual public Product Product
		{ 
			get
			{
				return (Product) Strategy.GetCompositeRole(Meta.Product);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Product ,value);
			}
		}

		virtual public bool ExistProduct
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Product);
			}
		}

		virtual public void RemoveProduct()
		{
			Strategy.RemoveCompositeRole(Meta.Product);
		}


		virtual public RevenueQuantityBreak RevenueQuantityBreak
		{ 
			get
			{
				return (RevenueQuantityBreak) Strategy.GetCompositeRole(Meta.RevenueQuantityBreak);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.RevenueQuantityBreak ,value);
			}
		}

		virtual public bool ExistRevenueQuantityBreak
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.RevenueQuantityBreak);
			}
		}

		virtual public void RemoveRevenueQuantityBreak()
		{
			Strategy.RemoveCompositeRole(Meta.RevenueQuantityBreak);
		}


		virtual public Party SpecifiedFor
		{ 
			get
			{
				return (Party) Strategy.GetCompositeRole(Meta.SpecifiedFor);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.SpecifiedFor ,value);
			}
		}

		virtual public bool ExistSpecifiedFor
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.SpecifiedFor);
			}
		}

		virtual public void RemoveSpecifiedFor()
		{
			Strategy.RemoveCompositeRole(Meta.SpecifiedFor);
		}


		virtual public ProductFeature ProductFeature
		{ 
			get
			{
				return (ProductFeature) Strategy.GetCompositeRole(Meta.ProductFeature);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.ProductFeature ,value);
			}
		}

		virtual public bool ExistProductFeature
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.ProductFeature);
			}
		}

		virtual public void RemoveProductFeature()
		{
			Strategy.RemoveCompositeRole(Meta.ProductFeature);
		}


		virtual public AgreementPricingProgram AgreementPricingProgram
		{ 
			get
			{
				return (AgreementPricingProgram) Strategy.GetCompositeRole(Meta.AgreementPricingProgram);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.AgreementPricingProgram ,value);
			}
		}

		virtual public bool ExistAgreementPricingProgram
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.AgreementPricingProgram);
			}
		}

		virtual public void RemoveAgreementPricingProgram()
		{
			Strategy.RemoveCompositeRole(Meta.AgreementPricingProgram);
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


		virtual public Currency Currency
		{ 
			get
			{
				return (Currency) Strategy.GetCompositeRole(Meta.Currency);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Currency ,value);
			}
		}

		virtual public bool ExistCurrency
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Currency);
			}
		}

		virtual public void RemoveCurrency()
		{
			Strategy.RemoveCompositeRole(Meta.Currency);
		}


		virtual public OrderKind OrderKind
		{ 
			get
			{
				return (OrderKind) Strategy.GetCompositeRole(Meta.OrderKind);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.OrderKind ,value);
			}
		}

		virtual public bool ExistOrderKind
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.OrderKind);
			}
		}

		virtual public void RemoveOrderKind()
		{
			Strategy.RemoveCompositeRole(Meta.OrderKind);
		}


		virtual public OrderValue OrderValue
		{ 
			get
			{
				return (OrderValue) Strategy.GetCompositeRole(Meta.OrderValue);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.OrderValue ,value);
			}
		}

		virtual public bool ExistOrderValue
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.OrderValue);
			}
		}

		virtual public void RemoveOrderValue()
		{
			Strategy.RemoveCompositeRole(Meta.OrderValue);
		}



		virtual public global::System.Decimal Price 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.Price);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Price, value);
			}
		}

		virtual public bool ExistPrice{
			get
			{
				return Strategy.ExistUnitRole(Meta.Price);
			}
		}

		virtual public void RemovePrice()
		{
			Strategy.RemoveUnitRole(Meta.Price);
		}


		virtual public ProductCategory ProductCategory
		{ 
			get
			{
				return (ProductCategory) Strategy.GetCompositeRole(Meta.ProductCategory);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.ProductCategory ,value);
			}
		}

		virtual public bool ExistProductCategory
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.ProductCategory);
			}
		}

		virtual public void RemoveProductCategory()
		{
			Strategy.RemoveCompositeRole(Meta.ProductCategory);
		}


		virtual public SalesChannel SalesChannel
		{ 
			get
			{
				return (SalesChannel) Strategy.GetCompositeRole(Meta.SalesChannel);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.SalesChannel ,value);
			}
		}

		virtual public bool ExistSalesChannel
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.SalesChannel);
			}
		}

		virtual public void RemoveSalesChannel()
		{
			Strategy.RemoveCompositeRole(Meta.SalesChannel);
		}



		virtual public global::System.DateTime FromDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.FromDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.FromDate, value);
			}
		}

		virtual public bool ExistFromDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.FromDate);
			}
		}

		virtual public void RemoveFromDate()
		{
			Strategy.RemoveUnitRole(Meta.FromDate);
		}



		virtual public global::System.DateTime ThroughDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.ThroughDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ThroughDate, value);
			}
		}

		virtual public bool ExistThroughDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.ThroughDate);
			}
		}

		virtual public void RemoveThroughDate()
		{
			Strategy.RemoveUnitRole(Meta.ThroughDate);
		}


		virtual public SearchData SearchData
		{ 
			get
			{
				return (SearchData) Strategy.GetCompositeRole(Meta.SearchData);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.SearchData ,value);
			}
		}

		virtual public bool ExistSearchData
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.SearchData);
			}
		}

		virtual public void RemoveSearchData()
		{
			Strategy.RemoveCompositeRole(Meta.SearchData);
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



		virtual public global::System.String Comment 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Comment);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Comment, value);
			}
		}

		virtual public bool ExistComment{
			get
			{
				return Strategy.ExistUnitRole(Meta.Comment);
			}
		}

		virtual public void RemoveComment()
		{
			Strategy.RemoveUnitRole(Meta.Comment);
		}



		virtual public Product ProductWhereVirtualProductPriceComponent
		{ 
			get
			{
				return (Product) Strategy.GetCompositeAssociation(Meta.ProductWhereVirtualProductPriceComponent);
			}
		} 

		virtual public bool ExistProductWhereVirtualProductPriceComponent
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.ProductWhereVirtualProductPriceComponent);
			}
		}


		virtual public global::Allors.Extent<Product> ProductsWhereBasePrice
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductsWhereBasePrice);
			}
		}

		virtual public bool ExistProductsWhereBasePrice
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductsWhereBasePrice);
			}
		}


		virtual public EngagementRate EngagementRateWhereGoverningPriceComponent
		{ 
			get
			{
				return (EngagementRate) Strategy.GetCompositeAssociation(Meta.EngagementRateWhereGoverningPriceComponent);
			}
		} 

		virtual public bool ExistEngagementRateWhereGoverningPriceComponent
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.EngagementRateWhereGoverningPriceComponent);
			}
		}


		virtual public Part PartWherePriceComponent
		{ 
			get
			{
				return (Part) Strategy.GetCompositeAssociation(Meta.PartWherePriceComponent);
			}
		} 

		virtual public bool ExistPartWherePriceComponent
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.PartWherePriceComponent);
			}
		}


		virtual public global::Allors.Extent<ProductFeature> ProductFeaturesWhereBasePrice
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductFeaturesWhereBasePrice);
			}
		}

		virtual public bool ExistProductFeaturesWhereBasePrice
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductFeaturesWhereBasePrice);
			}
		}


		virtual public global::Allors.Extent<InvoiceItem> InvoiceItemsWhereCurrentPriceComponent
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.InvoiceItemsWhereCurrentPriceComponent);
			}
		}

		virtual public bool ExistInvoiceItemsWhereCurrentPriceComponent
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.InvoiceItemsWhereCurrentPriceComponent);
			}
		}


		virtual public global::Allors.Extent<OrderItem> OrderItemsWhereCurrentPriceComponent
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.OrderItemsWhereCurrentPriceComponent);
			}
		}

		virtual public bool ExistOrderItemsWhereCurrentPriceComponent
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.OrderItemsWhereCurrentPriceComponent);
			}
		}

	}

	public class RecurringChargeMeta
	{
		public static readonly RecurringChargeMeta Instance = new RecurringChargeMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.RecurringCharge;

		public global::Allors.Meta.RoleType TimeFrequency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.RecurringChargeTimeFrequency;
			}
		} 
		public global::Allors.Meta.RoleType GeographicBoundary 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PriceComponentGeographicBoundary;
			}
		} 
		public global::Allors.Meta.RoleType Rate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PriceComponentRate;
			}
		} 
		public global::Allors.Meta.RoleType RevenueValueBreak 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PriceComponentRevenueValueBreak;
			}
		} 
		public global::Allors.Meta.RoleType PartyClassification 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PriceComponentPartyClassification;
			}
		} 
		public global::Allors.Meta.RoleType OrderQuantityBreak 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PriceComponentOrderQuantityBreak;
			}
		} 
		public global::Allors.Meta.RoleType PackageQuantityBreak 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PriceComponentPackageQuantityBreak;
			}
		} 
		public global::Allors.Meta.RoleType Product 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PriceComponentProduct;
			}
		} 
		public global::Allors.Meta.RoleType RevenueQuantityBreak 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PriceComponentRevenueQuantityBreak;
			}
		} 
		public global::Allors.Meta.RoleType SpecifiedFor 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PriceComponentSpecifiedFor;
			}
		} 
		public global::Allors.Meta.RoleType ProductFeature 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PriceComponentProductFeature;
			}
		} 
		public global::Allors.Meta.RoleType AgreementPricingProgram 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PriceComponentAgreementPricingProgram;
			}
		} 
		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PriceComponentDescription;
			}
		} 
		public global::Allors.Meta.RoleType Currency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PriceComponentCurrency;
			}
		} 
		public global::Allors.Meta.RoleType OrderKind 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PriceComponentOrderKind;
			}
		} 
		public global::Allors.Meta.RoleType OrderValue 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PriceComponentOrderValue;
			}
		} 
		public global::Allors.Meta.RoleType Price 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PriceComponentPrice;
			}
		} 
		public global::Allors.Meta.RoleType ProductCategory 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PriceComponentProductCategory;
			}
		} 
		public global::Allors.Meta.RoleType SalesChannel 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PriceComponentSalesChannel;
			}
		} 
		public global::Allors.Meta.RoleType FromDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PeriodFromDate;
			}
		} 
		public global::Allors.Meta.RoleType ThroughDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PeriodThroughDate;
			}
		} 
		public global::Allors.Meta.RoleType SearchData 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SearchableSearchData;
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
		public global::Allors.Meta.RoleType Comment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommentableComment;
			}
		} 

		public global::Allors.Meta.AssociationType ProductWhereVirtualProductPriceComponent 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductVirtualProductPriceComponent;
			}
		} 
		public global::Allors.Meta.AssociationType ProductsWhereBasePrice 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductBasePrice;
			}
		} 
		public global::Allors.Meta.AssociationType EngagementRateWhereGoverningPriceComponent 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.EngagementRateGoverningPriceComponent;
			}
		} 
		public global::Allors.Meta.AssociationType PartWherePriceComponent 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartPriceComponent;
			}
		} 
		public global::Allors.Meta.AssociationType ProductFeaturesWhereBasePrice 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductFeatureBasePrice;
			}
		} 
		public global::Allors.Meta.AssociationType InvoiceItemsWhereCurrentPriceComponent 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InvoiceItemCurrentPriceComponent;
			}
		} 
		public global::Allors.Meta.AssociationType OrderItemsWhereCurrentPriceComponent 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.OrderItemCurrentPriceComponent;
			}
		} 

	}
}