// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class Currency : Allors.ObjectBase , UserInterfaceable, IUnitOfMeasure
	{
		public static readonly CurrencyMeta Meta = CurrencyMeta.Instance;

		public Currency(Allors.IStrategy allors) : base(allors) {}

		public static Currency Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (Currency) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.String IsoCode 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.IsoCode);
			}
			set
			{
				Strategy.SetUnitRole(Meta.IsoCode, value);
			}
		}

		virtual public bool ExistIsoCode{
			get
			{
				return Strategy.ExistUnitRole(Meta.IsoCode);
			}
		}

		virtual public void RemoveIsoCode()
		{
			Strategy.RemoveUnitRole(Meta.IsoCode);
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



		virtual public global::System.String Symbol 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Symbol);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Symbol, value);
			}
		}

		virtual public bool ExistSymbol{
			get
			{
				return Strategy.ExistUnitRole(Meta.Symbol);
			}
		}

		virtual public void RemoveSymbol()
		{
			Strategy.RemoveUnitRole(Meta.Symbol);
		}


		virtual public global::Allors.Extent<LocalisedText> LocalisedNames
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.LocalisedName);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.LocalisedName, value);
			}
		}

		virtual public void AddLocalisedName (LocalisedText value)
		{
			Strategy.AddCompositeRole(Meta.LocalisedName, value);
		}

		virtual public void RemoveLocalisedName (LocalisedText value)
		{
			Strategy.RemoveCompositeRole(Meta.LocalisedName,value);
		}

		virtual public bool ExistLocalisedNames
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.LocalisedName);
			}
		}

		virtual public void RemoveLocalisedNames()
		{
			Strategy.RemoveCompositeRoles(Meta.LocalisedName);
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


		virtual public global::Allors.Extent<UnitOfMeasureConversion> UnitOfMeasureConversions
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.UnitOfMeasureConversion);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.UnitOfMeasureConversion, value);
			}
		}

		virtual public void AddUnitOfMeasureConversion (UnitOfMeasureConversion value)
		{
			Strategy.AddCompositeRole(Meta.UnitOfMeasureConversion, value);
		}

		virtual public void RemoveUnitOfMeasureConversion (UnitOfMeasureConversion value)
		{
			Strategy.RemoveCompositeRole(Meta.UnitOfMeasureConversion,value);
		}

		virtual public bool ExistUnitOfMeasureConversions
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.UnitOfMeasureConversion);
			}
		}

		virtual public void RemoveUnitOfMeasureConversions()
		{
			Strategy.RemoveCompositeRoles(Meta.UnitOfMeasureConversion);
		}



		virtual public global::System.String Abbreviation 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Abbreviation);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Abbreviation, value);
			}
		}

		virtual public bool ExistAbbreviation{
			get
			{
				return Strategy.ExistUnitRole(Meta.Abbreviation);
			}
		}

		virtual public void RemoveAbbreviation()
		{
			Strategy.RemoveUnitRole(Meta.Abbreviation);
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



		virtual public global::Allors.Extent<Country> CountriesWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.CountriesWhereCurrency);
			}
		}

		virtual public bool ExistCountriesWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.CountriesWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<SalesRepPartyProductCategoryRevenue> SalesRepPartyProductCategoryRevenuesWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesRepPartyProductCategoryRevenuesWhereCurrency);
			}
		}

		virtual public bool ExistSalesRepPartyProductCategoryRevenuesWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesRepPartyProductCategoryRevenuesWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<PartyProductCategoryRevenueHistory> PartyProductCategoryRevenueHistoriesWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartyProductCategoryRevenueHistoriesWhereCurrency);
			}
		}

		virtual public bool ExistPartyProductCategoryRevenueHistoriesWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartyProductCategoryRevenueHistoriesWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<PartyRevenueHistory> PartyRevenueHistoriesWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartyRevenueHistoriesWhereCurrency);
			}
		}

		virtual public bool ExistPartyRevenueHistoriesWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartyRevenueHistoriesWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<ShippingAndHandlingComponent> ShippingAndHandlingComponentsWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ShippingAndHandlingComponentsWhereCurrency);
			}
		}

		virtual public bool ExistShippingAndHandlingComponentsWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ShippingAndHandlingComponentsWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<BankAccount> BankAccountsWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.BankAccountsWhereCurrency);
			}
		}

		virtual public bool ExistBankAccountsWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.BankAccountsWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<StoreRevenue> StoreRevenuesWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.StoreRevenuesWhereCurrency);
			}
		}

		virtual public bool ExistStoreRevenuesWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.StoreRevenuesWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<ProductCategoryRevenueHistory> ProductCategoryRevenueHistoriesWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductCategoryRevenueHistoriesWhereCurrency);
			}
		}

		virtual public bool ExistProductCategoryRevenueHistoriesWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductCategoryRevenueHistoriesWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<SalesRepRevenueHistory> SalesRepRevenueHistoriesWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesRepRevenueHistoriesWhereCurrency);
			}
		}

		virtual public bool ExistSalesRepRevenueHistoriesWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesRepRevenueHistoriesWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<ProductRevenueHistory> ProductRevenueHistoriesWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductRevenueHistoriesWhereCurrency);
			}
		}

		virtual public bool ExistProductRevenueHistoriesWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductRevenueHistoriesWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<SalesChannelRevenue> SalesChannelRevenuesWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesChannelRevenuesWhereCurrency);
			}
		}

		virtual public bool ExistSalesChannelRevenuesWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesChannelRevenuesWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<SalesChannelRevenueHistory> SalesChannelRevenueHistoriesWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesChannelRevenueHistoriesWhereCurrency);
			}
		}

		virtual public bool ExistSalesChannelRevenueHistoriesWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesChannelRevenueHistoriesWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<PriceComponent> PriceComponentsWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PriceComponentsWhereCurrency);
			}
		}

		virtual public bool ExistPriceComponentsWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PriceComponentsWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<PartyProductRevenue> PartyProductRevenuesWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartyProductRevenuesWhereCurrency);
			}
		}

		virtual public bool ExistPartyProductRevenuesWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartyProductRevenuesWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<Party> PartiesWherePreferredCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartiesWherePreferredCurrency);
			}
		}

		virtual public bool ExistPartiesWherePreferredCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartiesWherePreferredCurrency);
			}
		}


		virtual public global::Allors.Extent<PartyProductCategoryRevenue> PartyProductCategoryRevenuesWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartyProductCategoryRevenuesWhereCurrency);
			}
		}

		virtual public bool ExistPartyProductCategoryRevenuesWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartyProductCategoryRevenuesWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<ProductPurchasePrice> ProductPurchasePricesWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductPurchasePricesWhereCurrency);
			}
		}

		virtual public bool ExistProductPurchasePricesWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductPurchasePricesWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<StoreRevenueHistory> StoreRevenueHistoriesWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.StoreRevenueHistoriesWhereCurrency);
			}
		}

		virtual public bool ExistStoreRevenueHistoriesWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.StoreRevenueHistoriesWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<InternalOrganisationRevenueHistory> InternalOrganisationRevenueHistoriesWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.InternalOrganisationRevenueHistoriesWhereCurrency);
			}
		}

		virtual public bool ExistInternalOrganisationRevenueHistoriesWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.InternalOrganisationRevenueHistoriesWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<ProductCategoryRevenue> ProductCategoryRevenuesWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductCategoryRevenuesWhereCurrency);
			}
		}

		virtual public bool ExistProductCategoryRevenuesWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductCategoryRevenuesWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<PartyRevenue> PartyRevenuesWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartyRevenuesWhereCurrency);
			}
		}

		virtual public bool ExistPartyRevenuesWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartyRevenuesWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<SalesRepRevenue> SalesRepRevenuesWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesRepRevenuesWhereCurrency);
			}
		}

		virtual public bool ExistSalesRepRevenuesWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesRepRevenuesWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<SalesRepPartyRevenue> SalesRepPartyRevenuesWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesRepPartyRevenuesWhereCurrency);
			}
		}

		virtual public bool ExistSalesRepPartyRevenuesWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesRepPartyRevenuesWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<Order> OrdersWhereCustomerCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.OrdersWhereCustomerCurrency);
			}
		}

		virtual public bool ExistOrdersWhereCustomerCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.OrdersWhereCustomerCurrency);
			}
		}


		virtual public global::Allors.Extent<PartyPackageRevenueHistory> PartyPackageRevenueHistoriesWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartyPackageRevenueHistoriesWhereCurrency);
			}
		}

		virtual public bool ExistPartyPackageRevenueHistoriesWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartyPackageRevenueHistoriesWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<AmountDue> AmountsDueWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.AmountsDueWhereCurrency);
			}
		}

		virtual public bool ExistAmountsDueWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.AmountsDueWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<PackageRevenue> PackageRevenuesWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PackageRevenuesWhereCurrency);
			}
		}

		virtual public bool ExistPackageRevenuesWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PackageRevenuesWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<InternalOrganisationRevenue> InternalOrganisationRevenuesWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.InternalOrganisationRevenuesWhereCurrency);
			}
		}

		virtual public bool ExistInternalOrganisationRevenuesWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.InternalOrganisationRevenuesWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<PartyPackageRevenue> PartyPackageRevenuesWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartyPackageRevenuesWhereCurrency);
			}
		}

		virtual public bool ExistPartyPackageRevenuesWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartyPackageRevenuesWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<PackageRevenueHistory> PackageRevenueHistoriesWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PackageRevenueHistoriesWhereCurrency);
			}
		}

		virtual public bool ExistPackageRevenueHistoriesWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PackageRevenueHistoriesWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<ProductRevenue> ProductRevenuesWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductRevenuesWhereCurrency);
			}
		}

		virtual public bool ExistProductRevenuesWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductRevenuesWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<Invoice> InvoicesWhereCustomerCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.InvoicesWhereCustomerCurrency);
			}
		}

		virtual public bool ExistInvoicesWhereCustomerCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.InvoicesWhereCustomerCurrency);
			}
		}


		virtual public global::Allors.Extent<SalesRepCommission> SalesRepCommissionsWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesRepCommissionsWhereCurrency);
			}
		}

		virtual public bool ExistSalesRepCommissionsWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesRepCommissionsWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<InternalOrganisation> InternalOrganisationsWherePreviousCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.InternalOrganisationsWherePreviousCurrency);
			}
		}

		virtual public bool ExistInternalOrganisationsWherePreviousCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.InternalOrganisationsWherePreviousCurrency);
			}
		}


		virtual public global::Allors.Extent<EstimatedProductCost> EstimatedProductCostsWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.EstimatedProductCostsWhereCurrency);
			}
		}

		virtual public bool ExistEstimatedProductCostsWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.EstimatedProductCostsWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<SalesRepProductCategoryRevenue> SalesRepProductCategoryRevenuesWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesRepProductCategoryRevenuesWhereCurrency);
			}
		}

		virtual public bool ExistSalesRepProductCategoryRevenuesWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesRepProductCategoryRevenuesWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<PartyProductRevenueHistory> PartyProductRevenueHistoriesWhereCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartyProductRevenueHistoriesWhereCurrency);
			}
		}

		virtual public bool ExistPartyProductRevenueHistoriesWhereCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartyProductRevenueHistoriesWhereCurrency);
			}
		}


		virtual public global::Allors.Extent<Singleton> SingletonsWhereDefaultCurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SingletonsWhereDefaultCurrency);
			}
		}

		virtual public bool ExistSingletonsWhereDefaultCurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SingletonsWhereDefaultCurrency);
			}
		}


		virtual public global::Allors.Extent<UnitOfMeasureConversion> UnitOfMeasureConversionsWhereToUnitOfMeasure
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.UnitOfMeasureConversionsWhereToUnitOfMeasure);
			}
		}

		virtual public bool ExistUnitOfMeasureConversionsWhereToUnitOfMeasure
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.UnitOfMeasureConversionsWhereToUnitOfMeasure);
			}
		}

	}

	public class CurrencyMeta
	{
		public static readonly CurrencyMeta Instance = new CurrencyMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.Currency;

		public global::Allors.Meta.RoleType IsoCode 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CurrencyIsoCode;
			}
		} 
		public global::Allors.Meta.RoleType Name 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CurrencyName;
			}
		} 
		public global::Allors.Meta.RoleType Symbol 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CurrencySymbol;
			}
		} 
		public global::Allors.Meta.RoleType LocalisedName 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CurrencyLocalisedName;
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
		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.IUnitOfMeasureDescription;
			}
		} 
		public global::Allors.Meta.RoleType UnitOfMeasureConversion 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.IUnitOfMeasureUnitOfMeasureConversion;
			}
		} 
		public global::Allors.Meta.RoleType Abbreviation 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.IUnitOfMeasureAbbreviation;
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

		public global::Allors.Meta.AssociationType CountriesWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CountryCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType SalesRepPartyProductCategoryRevenuesWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesRepPartyProductCategoryRevenueCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType PartyProductCategoryRevenueHistoriesWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyProductCategoryRevenueHistoryCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType PartyRevenueHistoriesWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyRevenueHistoryCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType ShippingAndHandlingComponentsWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ShippingAndHandlingComponentCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType BankAccountsWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.BankAccountCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType StoreRevenuesWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.StoreRevenueCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType ProductCategoryRevenueHistoriesWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductCategoryRevenueHistoryCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType SalesRepRevenueHistoriesWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesRepRevenueHistoryCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType ProductRevenueHistoriesWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductRevenueHistoryCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType SalesChannelRevenuesWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesChannelRevenueCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType SalesChannelRevenueHistoriesWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesChannelRevenueHistoryCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType PriceComponentsWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PriceComponentCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType PartyProductRevenuesWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyProductRevenueCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType PartiesWherePreferredCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyPreferredCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType PartyProductCategoryRevenuesWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyProductCategoryRevenueCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType ProductPurchasePricesWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductPurchasePriceCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType StoreRevenueHistoriesWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.StoreRevenueHistoryCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType InternalOrganisationRevenueHistoriesWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InternalOrganisationRevenueHistoryCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType ProductCategoryRevenuesWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductCategoryRevenueCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType PartyRevenuesWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyRevenueCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType SalesRepRevenuesWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesRepRevenueCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType SalesRepPartyRevenuesWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesRepPartyRevenueCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType OrdersWhereCustomerCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.OrderCustomerCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType PartyPackageRevenueHistoriesWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyPackageRevenueHistoryCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType AmountsDueWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.AmountDueCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType PackageRevenuesWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PackageRevenueCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType InternalOrganisationRevenuesWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InternalOrganisationRevenueCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType PartyPackageRevenuesWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyPackageRevenueCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType PackageRevenueHistoriesWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PackageRevenueHistoryCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType ProductRevenuesWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductRevenueCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType InvoicesWhereCustomerCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InvoiceCustomerCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType SalesRepCommissionsWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesRepCommissionCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType InternalOrganisationsWherePreviousCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InternalOrganisationPreviousCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType EstimatedProductCostsWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.EstimatedProductCostCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType SalesRepProductCategoryRevenuesWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesRepProductCategoryRevenueCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType PartyProductRevenueHistoriesWhereCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyProductRevenueHistoryCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType SingletonsWhereDefaultCurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SingletonDefaultCurrency;
			}
		} 
		public global::Allors.Meta.AssociationType UnitOfMeasureConversionsWhereToUnitOfMeasure 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.UnitOfMeasureConversionToUnitOfMeasure;
			}
		} 

	}
}