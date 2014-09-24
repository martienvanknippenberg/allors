// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class TimeAndMaterialsService : Allors.ObjectBase , Service
	{
		public static readonly TimeAndMaterialsServiceMeta Meta = TimeAndMaterialsServiceMeta.Instance;

		public TimeAndMaterialsService(Allors.IStrategy allors) : base(allors) {}

		public static TimeAndMaterialsService Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (TimeAndMaterialsService) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public ProductCategory PrimaryProductCategory
		{ 
			get
			{
				return (ProductCategory) Strategy.GetCompositeRole(Meta.PrimaryProductCategory);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.PrimaryProductCategory ,value);
			}
		}

		virtual public bool ExistPrimaryProductCategory
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.PrimaryProductCategory);
			}
		}

		virtual public void RemovePrimaryProductCategory()
		{
			Strategy.RemoveCompositeRole(Meta.PrimaryProductCategory);
		}



		virtual public global::System.DateTime SupportDiscontinuationDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.SupportDiscontinuationDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.SupportDiscontinuationDate, value);
			}
		}

		virtual public bool ExistSupportDiscontinuationDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.SupportDiscontinuationDate);
			}
		}

		virtual public void RemoveSupportDiscontinuationDate()
		{
			Strategy.RemoveUnitRole(Meta.SupportDiscontinuationDate);
		}



		virtual public global::System.DateTime SalesDiscontinuationDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.SalesDiscontinuationDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.SalesDiscontinuationDate, value);
			}
		}

		virtual public bool ExistSalesDiscontinuationDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.SalesDiscontinuationDate);
			}
		}

		virtual public void RemoveSalesDiscontinuationDate()
		{
			Strategy.RemoveUnitRole(Meta.SalesDiscontinuationDate);
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


		virtual public global::Allors.Extent<PriceComponent> VirtualProductPriceComponents
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.VirtualProductPriceComponent);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.VirtualProductPriceComponent, value);
			}
		}

		virtual public void AddVirtualProductPriceComponent (PriceComponent value)
		{
			Strategy.AddCompositeRole(Meta.VirtualProductPriceComponent, value);
		}

		virtual public void RemoveVirtualProductPriceComponent (PriceComponent value)
		{
			Strategy.RemoveCompositeRole(Meta.VirtualProductPriceComponent,value);
		}

		virtual public bool ExistVirtualProductPriceComponents
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.VirtualProductPriceComponent);
			}
		}

		virtual public void RemoveVirtualProductPriceComponents()
		{
			Strategy.RemoveCompositeRoles(Meta.VirtualProductPriceComponent);
		}



		virtual public global::System.String IntrastatCode 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.IntrastatCode);
			}
			set
			{
				Strategy.SetUnitRole(Meta.IntrastatCode, value);
			}
		}

		virtual public bool ExistIntrastatCode{
			get
			{
				return Strategy.ExistUnitRole(Meta.IntrastatCode);
			}
		}

		virtual public void RemoveIntrastatCode()
		{
			Strategy.RemoveUnitRole(Meta.IntrastatCode);
		}


		virtual public global::Allors.Extent<ProductCategory> ProductCategoriesExpanded
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.ProductCategoryExpanded);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.ProductCategoryExpanded, value);
			}
		}

		virtual public void AddProductCategoryExpanded (ProductCategory value)
		{
			Strategy.AddCompositeRole(Meta.ProductCategoryExpanded, value);
		}

		virtual public void RemoveProductCategoryExpanded (ProductCategory value)
		{
			Strategy.RemoveCompositeRole(Meta.ProductCategoryExpanded,value);
		}

		virtual public bool ExistProductCategoriesExpanded
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.ProductCategoryExpanded);
			}
		}

		virtual public void RemoveProductCategoriesExpanded()
		{
			Strategy.RemoveCompositeRoles(Meta.ProductCategoryExpanded);
		}


		virtual public Product ProductComplement
		{ 
			get
			{
				return (Product) Strategy.GetCompositeRole(Meta.ProductComplement);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.ProductComplement ,value);
			}
		}

		virtual public bool ExistProductComplement
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.ProductComplement);
			}
		}

		virtual public void RemoveProductComplement()
		{
			Strategy.RemoveCompositeRole(Meta.ProductComplement);
		}


		virtual public global::Allors.Extent<ProductFeature> OptionalFeatures
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.OptionalFeature);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.OptionalFeature, value);
			}
		}

		virtual public void AddOptionalFeature (ProductFeature value)
		{
			Strategy.AddCompositeRole(Meta.OptionalFeature, value);
		}

		virtual public void RemoveOptionalFeature (ProductFeature value)
		{
			Strategy.RemoveCompositeRole(Meta.OptionalFeature,value);
		}

		virtual public bool ExistOptionalFeatures
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.OptionalFeature);
			}
		}

		virtual public void RemoveOptionalFeatures()
		{
			Strategy.RemoveCompositeRoles(Meta.OptionalFeature);
		}


		virtual public Party ManufacturedBy
		{ 
			get
			{
				return (Party) Strategy.GetCompositeRole(Meta.ManufacturedBy);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.ManufacturedBy ,value);
			}
		}

		virtual public bool ExistManufacturedBy
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.ManufacturedBy);
			}
		}

		virtual public void RemoveManufacturedBy()
		{
			Strategy.RemoveCompositeRole(Meta.ManufacturedBy);
		}


		virtual public global::Allors.Extent<Product> Variants
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.Variant);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.Variant, value);
			}
		}

		virtual public void AddVariant (Product value)
		{
			Strategy.AddCompositeRole(Meta.Variant, value);
		}

		virtual public void RemoveVariant (Product value)
		{
			Strategy.RemoveCompositeRole(Meta.Variant,value);
		}

		virtual public bool ExistVariants
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.Variant);
			}
		}

		virtual public void RemoveVariants()
		{
			Strategy.RemoveCompositeRoles(Meta.Variant);
		}



		virtual public global::System.String Name 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Name);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Name, value);
			}
		}

		virtual public bool ExistName{
			get
			{
				return Strategy.ExistUnitRole(Meta.Name);
			}
		}

		virtual public void RemoveName()
		{
			Strategy.RemoveUnitRole(Meta.Name);
		}



		virtual public global::System.DateTime IntroductionDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.IntroductionDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.IntroductionDate, value);
			}
		}

		virtual public bool ExistIntroductionDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.IntroductionDate);
			}
		}

		virtual public void RemoveIntroductionDate()
		{
			Strategy.RemoveUnitRole(Meta.IntroductionDate);
		}


		virtual public global::Allors.Extent<Document> Documents
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.Document);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.Document, value);
			}
		}

		virtual public void AddDocument (Document value)
		{
			Strategy.AddCompositeRole(Meta.Document, value);
		}

		virtual public void RemoveDocument (Document value)
		{
			Strategy.RemoveCompositeRole(Meta.Document,value);
		}

		virtual public bool ExistDocuments
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.Document);
			}
		}

		virtual public void RemoveDocuments()
		{
			Strategy.RemoveCompositeRoles(Meta.Document);
		}


		virtual public global::Allors.Extent<ProductFeature> StandardFeatures
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.StandardFeature);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.StandardFeature, value);
			}
		}

		virtual public void AddStandardFeature (ProductFeature value)
		{
			Strategy.AddCompositeRole(Meta.StandardFeature, value);
		}

		virtual public void RemoveStandardFeature (ProductFeature value)
		{
			Strategy.RemoveCompositeRole(Meta.StandardFeature,value);
		}

		virtual public bool ExistStandardFeatures
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.StandardFeature);
			}
		}

		virtual public void RemoveStandardFeatures()
		{
			Strategy.RemoveCompositeRoles(Meta.StandardFeature);
		}


		virtual public UnitOfMeasure UnitOfMeasure
		{ 
			get
			{
				return (UnitOfMeasure) Strategy.GetCompositeRole(Meta.UnitOfMeasure);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.UnitOfMeasure ,value);
			}
		}

		virtual public bool ExistUnitOfMeasure
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.UnitOfMeasure);
			}
		}

		virtual public void RemoveUnitOfMeasure()
		{
			Strategy.RemoveCompositeRole(Meta.UnitOfMeasure);
		}


		virtual public global::Allors.Extent<EstimatedProductCost> EstimatedProductCosts
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.EstimatedProductCost);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.EstimatedProductCost, value);
			}
		}

		virtual public void AddEstimatedProductCost (EstimatedProductCost value)
		{
			Strategy.AddCompositeRole(Meta.EstimatedProductCost, value);
		}

		virtual public void RemoveEstimatedProductCost (EstimatedProductCost value)
		{
			Strategy.RemoveCompositeRole(Meta.EstimatedProductCost,value);
		}

		virtual public bool ExistEstimatedProductCosts
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.EstimatedProductCost);
			}
		}

		virtual public void RemoveEstimatedProductCosts()
		{
			Strategy.RemoveCompositeRoles(Meta.EstimatedProductCost);
		}


		virtual public global::Allors.Extent<Product> ProductObsolescences
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.ProductObsolescence);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.ProductObsolescence, value);
			}
		}

		virtual public void AddProductObsolescence (Product value)
		{
			Strategy.AddCompositeRole(Meta.ProductObsolescence, value);
		}

		virtual public void RemoveProductObsolescence (Product value)
		{
			Strategy.RemoveCompositeRole(Meta.ProductObsolescence,value);
		}

		virtual public bool ExistProductObsolescences
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.ProductObsolescence);
			}
		}

		virtual public void RemoveProductObsolescences()
		{
			Strategy.RemoveCompositeRoles(Meta.ProductObsolescence);
		}


		virtual public global::Allors.Extent<ProductFeature> SelectableFeatures
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.SelectableFeature);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.SelectableFeature, value);
			}
		}

		virtual public void AddSelectableFeature (ProductFeature value)
		{
			Strategy.AddCompositeRole(Meta.SelectableFeature, value);
		}

		virtual public void RemoveSelectableFeature (ProductFeature value)
		{
			Strategy.RemoveCompositeRole(Meta.SelectableFeature,value);
		}

		virtual public bool ExistSelectableFeatures
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.SelectableFeature);
			}
		}

		virtual public void RemoveSelectableFeatures()
		{
			Strategy.RemoveCompositeRoles(Meta.SelectableFeature);
		}


		virtual public VatRate VatRate
		{ 
			get
			{
				return (VatRate) Strategy.GetCompositeRole(Meta.VatRate);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.VatRate ,value);
			}
		}

		virtual public bool ExistVatRate
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.VatRate);
			}
		}

		virtual public void RemoveVatRate()
		{
			Strategy.RemoveCompositeRole(Meta.VatRate);
		}


		virtual public global::Allors.Extent<PriceComponent> BasePrices
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.BasePrice);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.BasePrice, value);
			}
		}

		virtual public void AddBasePrice (PriceComponent value)
		{
			Strategy.AddCompositeRole(Meta.BasePrice, value);
		}

		virtual public void RemoveBasePrice (PriceComponent value)
		{
			Strategy.RemoveCompositeRole(Meta.BasePrice,value);
		}

		virtual public bool ExistBasePrices
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.BasePrice);
			}
		}

		virtual public void RemoveBasePrices()
		{
			Strategy.RemoveCompositeRoles(Meta.BasePrice);
		}


		virtual public global::Allors.Extent<ProductCategory> ProductCategories
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.ProductCategory);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.ProductCategory, value);
			}
		}

		virtual public void AddProductCategory (ProductCategory value)
		{
			Strategy.AddCompositeRole(Meta.ProductCategory, value);
		}

		virtual public void RemoveProductCategory (ProductCategory value)
		{
			Strategy.RemoveCompositeRole(Meta.ProductCategory,value);
		}

		virtual public bool ExistProductCategories
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.ProductCategory);
			}
		}

		virtual public void RemoveProductCategories()
		{
			Strategy.RemoveCompositeRoles(Meta.ProductCategory);
		}


		virtual public InternalOrganisation SoldBy
		{ 
			get
			{
				return (InternalOrganisation) Strategy.GetCompositeRole(Meta.SoldBy);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.SoldBy ,value);
			}
		}

		virtual public bool ExistSoldBy
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.SoldBy);
			}
		}

		virtual public void RemoveSoldBy()
		{
			Strategy.RemoveCompositeRole(Meta.SoldBy);
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



		virtual public global::System.Guid UniqueId 
		{
			get
			{
				return (global::System.Guid) Strategy.GetUnitRole(Meta.UniqueId);
			}
			set
			{
				Strategy.SetUnitRole(Meta.UniqueId, value);
			}
		}

		virtual public bool ExistUniqueId{
			get
			{
				return Strategy.ExistUnitRole(Meta.UniqueId);
			}
		}

		virtual public void RemoveUniqueId()
		{
			Strategy.RemoveUnitRole(Meta.UniqueId);
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



		virtual public global::Allors.Extent<ProductDeliverySkillRequirement> ProductDeliverySkillRequirementsWhereService
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductDeliverySkillRequirementsWhereService);
			}
		}

		virtual public bool ExistProductDeliverySkillRequirementsWhereService
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductDeliverySkillRequirementsWhereService);
			}
		}


		virtual public global::Allors.Extent<ProductFeatureApplicabilityRelationship> ProductFeatureApplicabilityRelationshipsWhereAvailableFor
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductFeatureApplicabilityRelationshipsWhereAvailableFor);
			}
		}

		virtual public bool ExistProductFeatureApplicabilityRelationshipsWhereAvailableFor
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductFeatureApplicabilityRelationshipsWhereAvailableFor);
			}
		}


		virtual public global::Allors.Extent<ProductRequirement> ProductRequirementsWhereProduct
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductRequirementsWhereProduct);
			}
		}

		virtual public bool ExistProductRequirementsWhereProduct
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductRequirementsWhereProduct);
			}
		}


		virtual public global::Allors.Extent<QuoteItem> QuoteItemsWhereProduct
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.QuoteItemsWhereProduct);
			}
		}

		virtual public bool ExistQuoteItemsWhereProduct
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.QuoteItemsWhereProduct);
			}
		}


		virtual public global::Allors.Extent<SupplierOffering> SupplierOfferingsWhereProduct
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SupplierOfferingsWhereProduct);
			}
		}

		virtual public bool ExistSupplierOfferingsWhereProduct
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SupplierOfferingsWhereProduct);
			}
		}


		virtual public global::Allors.Extent<GeneralLedgerAccount> GeneralLedgerAccountsWhereDefaultCostUnit
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.GeneralLedgerAccountsWhereDefaultCostUnit);
			}
		}

		virtual public bool ExistGeneralLedgerAccountsWhereDefaultCostUnit
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.GeneralLedgerAccountsWhereDefaultCostUnit);
			}
		}


		virtual public global::Allors.Extent<GeneralLedgerAccount> GeneralLedgerAccountsWhereCostUnitAllowed
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.GeneralLedgerAccountsWhereCostUnitAllowed);
			}
		}

		virtual public bool ExistGeneralLedgerAccountsWhereCostUnitAllowed
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.GeneralLedgerAccountsWhereCostUnitAllowed);
			}
		}


		virtual public global::Allors.Extent<ProductConfiguration> ProductConfigurationsWhereProductUsedIn
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductConfigurationsWhereProductUsedIn);
			}
		}

		virtual public bool ExistProductConfigurationsWhereProductUsedIn
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductConfigurationsWhereProductUsedIn);
			}
		}


		virtual public global::Allors.Extent<ProductConfiguration> ProductConfigurationsWhereProduct
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductConfigurationsWhereProduct);
			}
		}

		virtual public bool ExistProductConfigurationsWhereProduct
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductConfigurationsWhereProduct);
			}
		}


		virtual public global::Allors.Extent<ProductRevenueHistory> ProductRevenueHistoriesWhereProduct
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductRevenueHistoriesWhereProduct);
			}
		}

		virtual public bool ExistProductRevenueHistoriesWhereProduct
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductRevenueHistoriesWhereProduct);
			}
		}


		virtual public global::Allors.Extent<PriceComponent> PriceComponentsWhereProduct
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PriceComponentsWhereProduct);
			}
		}

		virtual public bool ExistPriceComponentsWhereProduct
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PriceComponentsWhereProduct);
			}
		}


		virtual public global::Allors.Extent<PartyProductRevenue> PartyProductRevenuesWhereProduct
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartyProductRevenuesWhereProduct);
			}
		}

		virtual public bool ExistPartyProductRevenuesWhereProduct
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartyProductRevenuesWhereProduct);
			}
		}


		virtual public MarketingPackage MarketingPackageWhereProductUsedIn
		{ 
			get
			{
				return (MarketingPackage) Strategy.GetCompositeAssociation(Meta.MarketingPackageWhereProductUsedIn);
			}
		} 

		virtual public bool ExistMarketingPackageWhereProductUsedIn
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.MarketingPackageWhereProductUsedIn);
			}
		}


		virtual public global::Allors.Extent<MarketingPackage> MarketingPackagesWhereProduct
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.MarketingPackagesWhereProduct);
			}
		}

		virtual public bool ExistMarketingPackagesWhereProduct
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.MarketingPackagesWhereProduct);
			}
		}


		virtual public global::Allors.Extent<Product> ProductsWhereProductComplement
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductsWhereProductComplement);
			}
		}

		virtual public bool ExistProductsWhereProductComplement
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductsWhereProductComplement);
			}
		}


		virtual public Product ProductWhereVariant
		{ 
			get
			{
				return (Product) Strategy.GetCompositeAssociation(Meta.ProductWhereVariant);
			}
		} 

		virtual public bool ExistProductWhereVariant
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.ProductWhereVariant);
			}
		}


		virtual public global::Allors.Extent<Product> ProductsWhereProductObsolescence
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductsWhereProductObsolescence);
			}
		}

		virtual public bool ExistProductsWhereProductObsolescence
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductsWhereProductObsolescence);
			}
		}


		virtual public global::Allors.Extent<OrganisationGlAccount> OrganisationGlAccountsWhereProduct
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.OrganisationGlAccountsWhereProduct);
			}
		}

		virtual public bool ExistOrganisationGlAccountsWhereProduct
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.OrganisationGlAccountsWhereProduct);
			}
		}


		virtual public global::Allors.Extent<WorkEffortType> WorkEffortTypesWhereProductToProduce
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.WorkEffortTypesWhereProductToProduce);
			}
		}

		virtual public bool ExistWorkEffortTypesWhereProductToProduce
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.WorkEffortTypesWhereProductToProduce);
			}
		}


		virtual public global::Allors.Extent<SalesOrderItem> SalesOrderItemsWherePreviousProduct
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesOrderItemsWherePreviousProduct);
			}
		}

		virtual public bool ExistSalesOrderItemsWherePreviousProduct
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesOrderItemsWherePreviousProduct);
			}
		}


		virtual public global::Allors.Extent<SalesOrderItem> SalesOrderItemsWhereProduct
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesOrderItemsWhereProduct);
			}
		}

		virtual public bool ExistSalesOrderItemsWhereProduct
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesOrderItemsWhereProduct);
			}
		}


		virtual public global::Allors.Extent<ProductRevenue> ProductRevenuesWhereProduct
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductRevenuesWhereProduct);
			}
		}

		virtual public bool ExistProductRevenuesWhereProduct
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductRevenuesWhereProduct);
			}
		}


		virtual public global::Allors.Extent<SalesInvoiceItem> SalesInvoiceItemsWhereProduct
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesInvoiceItemsWhereProduct);
			}
		}

		virtual public bool ExistSalesInvoiceItemsWhereProduct
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesInvoiceItemsWhereProduct);
			}
		}


		virtual public global::Allors.Extent<EngagementItem> EngagementItemsWhereProduct
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.EngagementItemsWhereProduct);
			}
		}

		virtual public bool ExistEngagementItemsWhereProduct
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.EngagementItemsWhereProduct);
			}
		}


		virtual public global::Allors.Extent<PurchaseOrderItem> PurchaseOrderItemsWhereProduct
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PurchaseOrderItemsWhereProduct);
			}
		}

		virtual public bool ExistPurchaseOrderItemsWhereProduct
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PurchaseOrderItemsWhereProduct);
			}
		}


		virtual public global::Allors.Extent<RequestItem> RequestItemsWhereProduct
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.RequestItemsWhereProduct);
			}
		}

		virtual public bool ExistRequestItemsWhereProduct
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.RequestItemsWhereProduct);
			}
		}


		virtual public global::Allors.Extent<Good> GoodsWhereProductSubstitution
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.GoodsWhereProductSubstitution);
			}
		}

		virtual public bool ExistGoodsWhereProductSubstitution
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.GoodsWhereProductSubstitution);
			}
		}


		virtual public global::Allors.Extent<Good> GoodsWhereProductIncompatibility
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.GoodsWhereProductIncompatibility);
			}
		}

		virtual public bool ExistGoodsWhereProductIncompatibility
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.GoodsWhereProductIncompatibility);
			}
		}


		virtual public global::Allors.Extent<WorkRequirement> WorkRequirementsWhereProduct
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.WorkRequirementsWhereProduct);
			}
		}

		virtual public bool ExistWorkRequirementsWhereProduct
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.WorkRequirementsWhereProduct);
			}
		}


		virtual public global::Allors.Extent<PartyProductRevenueHistory> PartyProductRevenueHistoriesWhereProduct
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartyProductRevenueHistoriesWhereProduct);
			}
		}

		virtual public bool ExistPartyProductRevenueHistoriesWhereProduct
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartyProductRevenueHistoriesWhereProduct);
			}
		}

	}

	public class TimeAndMaterialsServiceMeta
	{
		public static readonly TimeAndMaterialsServiceMeta Instance = new TimeAndMaterialsServiceMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.TimeAndMaterialsService;

		public global::Allors.Meta.RoleType PrimaryProductCategory 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductPrimaryProductCategory;
			}
		} 
		public global::Allors.Meta.RoleType SupportDiscontinuationDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductSupportDiscontinuationDate;
			}
		} 
		public global::Allors.Meta.RoleType SalesDiscontinuationDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductSalesDiscontinuationDate;
			}
		} 
		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductDescription;
			}
		} 
		public global::Allors.Meta.RoleType VirtualProductPriceComponent 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductVirtualProductPriceComponent;
			}
		} 
		public global::Allors.Meta.RoleType IntrastatCode 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductIntrastatCode;
			}
		} 
		public global::Allors.Meta.RoleType ProductCategoryExpanded 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductProductCategoryExpanded;
			}
		} 
		public global::Allors.Meta.RoleType ProductComplement 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductProductComplement;
			}
		} 
		public global::Allors.Meta.RoleType OptionalFeature 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductOptionalFeature;
			}
		} 
		public global::Allors.Meta.RoleType ManufacturedBy 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductManufacturedBy;
			}
		} 
		public global::Allors.Meta.RoleType Variant 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductVariant;
			}
		} 
		public global::Allors.Meta.RoleType Name 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductName;
			}
		} 
		public global::Allors.Meta.RoleType IntroductionDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductIntroductionDate;
			}
		} 
		public global::Allors.Meta.RoleType Document 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductDocument;
			}
		} 
		public global::Allors.Meta.RoleType StandardFeature 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductStandardFeature;
			}
		} 
		public global::Allors.Meta.RoleType UnitOfMeasure 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductUnitOfMeasure;
			}
		} 
		public global::Allors.Meta.RoleType EstimatedProductCost 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductEstimatedProductCost;
			}
		} 
		public global::Allors.Meta.RoleType ProductObsolescence 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductProductObsolescence;
			}
		} 
		public global::Allors.Meta.RoleType SelectableFeature 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductSelectableFeature;
			}
		} 
		public global::Allors.Meta.RoleType VatRate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductVatRate;
			}
		} 
		public global::Allors.Meta.RoleType BasePrice 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductBasePrice;
			}
		} 
		public global::Allors.Meta.RoleType ProductCategory 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductProductCategory;
			}
		} 
		public global::Allors.Meta.RoleType SoldBy 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductSoldBy;
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
		public global::Allors.Meta.RoleType UniqueId 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UniquelyIdentifiableUniqueId;
			}
		} 
		public global::Allors.Meta.RoleType SearchData 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SearchableSearchData;
			}
		} 

		public global::Allors.Meta.AssociationType ProductDeliverySkillRequirementsWhereService 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductDeliverySkillRequirementService;
			}
		} 
		public global::Allors.Meta.AssociationType ProductFeatureApplicabilityRelationshipsWhereAvailableFor 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductFeatureApplicabilityRelationshipAvailableFor;
			}
		} 
		public global::Allors.Meta.AssociationType ProductRequirementsWhereProduct 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductRequirementProduct;
			}
		} 
		public global::Allors.Meta.AssociationType QuoteItemsWhereProduct 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.QuoteItemProduct;
			}
		} 
		public global::Allors.Meta.AssociationType SupplierOfferingsWhereProduct 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SupplierOfferingProduct;
			}
		} 
		public global::Allors.Meta.AssociationType GeneralLedgerAccountsWhereDefaultCostUnit 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.GeneralLedgerAccountDefaultCostUnit;
			}
		} 
		public global::Allors.Meta.AssociationType GeneralLedgerAccountsWhereCostUnitAllowed 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.GeneralLedgerAccountCostUnitAllowed;
			}
		} 
		public global::Allors.Meta.AssociationType ProductConfigurationsWhereProductUsedIn 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductConfigurationProductUsedIn;
			}
		} 
		public global::Allors.Meta.AssociationType ProductConfigurationsWhereProduct 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductConfigurationProduct;
			}
		} 
		public global::Allors.Meta.AssociationType ProductRevenueHistoriesWhereProduct 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductRevenueHistoryProduct;
			}
		} 
		public global::Allors.Meta.AssociationType PriceComponentsWhereProduct 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PriceComponentProduct;
			}
		} 
		public global::Allors.Meta.AssociationType PartyProductRevenuesWhereProduct 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyProductRevenueProduct;
			}
		} 
		public global::Allors.Meta.AssociationType MarketingPackageWhereProductUsedIn 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.MarketingPackageProductUsedIn;
			}
		} 
		public global::Allors.Meta.AssociationType MarketingPackagesWhereProduct 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.MarketingPackageProduct;
			}
		} 
		public global::Allors.Meta.AssociationType ProductsWhereProductComplement 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductProductComplement;
			}
		} 
		public global::Allors.Meta.AssociationType ProductWhereVariant 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductVariant;
			}
		} 
		public global::Allors.Meta.AssociationType ProductsWhereProductObsolescence 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductProductObsolescence;
			}
		} 
		public global::Allors.Meta.AssociationType OrganisationGlAccountsWhereProduct 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.OrganisationGlAccountProduct;
			}
		} 
		public global::Allors.Meta.AssociationType WorkEffortTypesWhereProductToProduce 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.WorkEffortTypeProductToProduce;
			}
		} 
		public global::Allors.Meta.AssociationType SalesOrderItemsWherePreviousProduct 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesOrderItemPreviousProduct;
			}
		} 
		public global::Allors.Meta.AssociationType SalesOrderItemsWhereProduct 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesOrderItemProduct;
			}
		} 
		public global::Allors.Meta.AssociationType ProductRevenuesWhereProduct 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductRevenueProduct;
			}
		} 
		public global::Allors.Meta.AssociationType SalesInvoiceItemsWhereProduct 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesInvoiceItemProduct;
			}
		} 
		public global::Allors.Meta.AssociationType EngagementItemsWhereProduct 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.EngagementItemProduct;
			}
		} 
		public global::Allors.Meta.AssociationType PurchaseOrderItemsWhereProduct 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseOrderItemProduct;
			}
		} 
		public global::Allors.Meta.AssociationType RequestItemsWhereProduct 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.RequestItemProduct;
			}
		} 
		public global::Allors.Meta.AssociationType GoodsWhereProductSubstitution 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.GoodProductSubstitution;
			}
		} 
		public global::Allors.Meta.AssociationType GoodsWhereProductIncompatibility 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.GoodProductIncompatibility;
			}
		} 
		public global::Allors.Meta.AssociationType WorkRequirementsWhereProduct 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.WorkRequirementProduct;
			}
		} 
		public global::Allors.Meta.AssociationType PartyProductRevenueHistoriesWhereProduct 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyProductRevenueHistoryProduct;
			}
		} 

	}
}