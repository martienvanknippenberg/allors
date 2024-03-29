// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class Country : Allors.ObjectBase , UserInterfaceable, Searchable, GeographicBoundary, CityBound
	{
		public static readonly CountryMeta Meta = CountryMeta.Instance;

		public Country(Allors.IStrategy allors) : base(allors) {}

		public static Country Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (Country) allorsSession.Instantiate(allorsObjectId);		
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


		virtual public global::Allors.Extent<VatRate> VatRates
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.VatRate);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.VatRate, value);
			}
		}

		virtual public void AddVatRate (VatRate value)
		{
			Strategy.AddCompositeRole(Meta.VatRate, value);
		}

		virtual public void RemoveVatRate (VatRate value)
		{
			Strategy.RemoveCompositeRole(Meta.VatRate,value);
		}

		virtual public bool ExistVatRates
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.VatRate);
			}
		}

		virtual public void RemoveVatRates()
		{
			Strategy.RemoveCompositeRoles(Meta.VatRate);
		}



		virtual public global::System.Int32 IbanLength 
		{
			get
			{
				return (global::System.Int32) Strategy.GetUnitRole(Meta.IbanLength);
			}
			set
			{
				Strategy.SetUnitRole(Meta.IbanLength, value);
			}
		}

		virtual public bool ExistIbanLength{
			get
			{
				return Strategy.ExistUnitRole(Meta.IbanLength);
			}
		}

		virtual public void RemoveIbanLength()
		{
			Strategy.RemoveUnitRole(Meta.IbanLength);
		}



		virtual public global::System.Boolean EuMemberState 
		{
			get
			{
				return (global::System.Boolean) Strategy.GetUnitRole(Meta.EuMemberState);
			}
			set
			{
				Strategy.SetUnitRole(Meta.EuMemberState, value);
			}
		}

		virtual public bool ExistEuMemberState{
			get
			{
				return Strategy.ExistUnitRole(Meta.EuMemberState);
			}
		}

		virtual public void RemoveEuMemberState()
		{
			Strategy.RemoveUnitRole(Meta.EuMemberState);
		}



		virtual public global::System.String TelephoneCode 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.TelephoneCode);
			}
			set
			{
				Strategy.SetUnitRole(Meta.TelephoneCode, value);
			}
		}

		virtual public bool ExistTelephoneCode{
			get
			{
				return Strategy.ExistUnitRole(Meta.TelephoneCode);
			}
		}

		virtual public void RemoveTelephoneCode()
		{
			Strategy.RemoveUnitRole(Meta.TelephoneCode);
		}



		virtual public global::System.String IbanRegex 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.IbanRegex);
			}
			set
			{
				Strategy.SetUnitRole(Meta.IbanRegex, value);
			}
		}

		virtual public bool ExistIbanRegex{
			get
			{
				return Strategy.ExistUnitRole(Meta.IbanRegex);
			}
		}

		virtual public void RemoveIbanRegex()
		{
			Strategy.RemoveUnitRole(Meta.IbanRegex);
		}


		virtual public VatForm VatForm
		{ 
			get
			{
				return (VatForm) Strategy.GetCompositeRole(Meta.VatForm);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.VatForm ,value);
			}
		}

		virtual public bool ExistVatForm
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.VatForm);
			}
		}

		virtual public void RemoveVatForm()
		{
			Strategy.RemoveCompositeRole(Meta.VatForm);
		}



		virtual public global::System.String UriExtension 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.UriExtension);
			}
			set
			{
				Strategy.SetUnitRole(Meta.UriExtension, value);
			}
		}

		virtual public bool ExistUriExtension{
			get
			{
				return Strategy.ExistUnitRole(Meta.UriExtension);
			}
		}

		virtual public void RemoveUriExtension()
		{
			Strategy.RemoveUnitRole(Meta.UriExtension);
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



		virtual public global::System.Decimal Latitude 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.Latitude);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Latitude, value);
			}
		}

		virtual public bool ExistLatitude{
			get
			{
				return Strategy.ExistUnitRole(Meta.Latitude);
			}
		}

		virtual public void RemoveLatitude()
		{
			Strategy.RemoveUnitRole(Meta.Latitude);
		}



		virtual public global::System.Decimal Longitude 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.Longitude);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Longitude, value);
			}
		}

		virtual public bool ExistLongitude{
			get
			{
				return Strategy.ExistUnitRole(Meta.Longitude);
			}
		}

		virtual public void RemoveLongitude()
		{
			Strategy.RemoveUnitRole(Meta.Longitude);
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


		virtual public global::Allors.Extent<City> Cities
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.City);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.City, value);
			}
		}

		virtual public void AddCity (City value)
		{
			Strategy.AddCompositeRole(Meta.City, value);
		}

		virtual public void RemoveCity (City value)
		{
			Strategy.RemoveCompositeRole(Meta.City,value);
		}

		virtual public bool ExistCities
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.City);
			}
		}

		virtual public void RemoveCities()
		{
			Strategy.RemoveCompositeRoles(Meta.City);
		}



		virtual public global::Allors.Extent<Locale> LocalesWhereCountry
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.LocalesWhereCountry);
			}
		}

		virtual public bool ExistLocalesWhereCountry
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.LocalesWhereCountry);
			}
		}


		virtual public global::Allors.Extent<Citizenship> CitizenshipsWhereCountry
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.CitizenshipsWhereCountry);
			}
		}

		virtual public bool ExistCitizenshipsWhereCountry
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.CitizenshipsWhereCountry);
			}
		}


		virtual public global::Allors.Extent<Bank> BanksWhereCountry
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.BanksWhereCountry);
			}
		}

		virtual public bool ExistBanksWhereCountry
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.BanksWhereCountry);
			}
		}


		virtual public global::Allors.Extent<InternalOrganisation> InternalOrganisationsWhereEuListingState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.InternalOrganisationsWhereEuListingState);
			}
		}

		virtual public bool ExistInternalOrganisationsWhereEuListingState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.InternalOrganisationsWhereEuListingState);
			}
		}


		virtual public global::Allors.Extent<PostalAddress> PostalAddressesWhereCountry
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PostalAddressesWhereCountry);
			}
		}

		virtual public bool ExistPostalAddressesWhereCountry
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PostalAddressesWhereCountry);
			}
		}


		virtual public global::Allors.Extent<PostalBoundary> PostalBoundariesWhereCountry
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PostalBoundariesWhereCountry);
			}
		}

		virtual public bool ExistPostalBoundariesWhereCountry
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PostalBoundariesWhereCountry);
			}
		}


		virtual public global::Allors.Extent<CountryBound> CountryBoundsWhereCountry
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.CountryBoundsWhereCountry);
			}
		}

		virtual public bool ExistCountryBoundsWhereCountry
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.CountryBoundsWhereCountry);
			}
		}


		virtual public global::Allors.Extent<ShippingAndHandlingComponent> ShippingAndHandlingComponentsWhereGeographicBoundary
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ShippingAndHandlingComponentsWhereGeographicBoundary);
			}
		}

		virtual public bool ExistShippingAndHandlingComponentsWhereGeographicBoundary
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ShippingAndHandlingComponentsWhereGeographicBoundary);
			}
		}


		virtual public global::Allors.Extent<PriceComponent> PriceComponentsWhereGeographicBoundary
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PriceComponentsWhereGeographicBoundary);
			}
		}

		virtual public bool ExistPriceComponentsWhereGeographicBoundary
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PriceComponentsWhereGeographicBoundary);
			}
		}


		virtual public global::Allors.Extent<GeographicBoundaryComposite> GeographicBoundariesCompositesWhereAssociation
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.GeographicBoundariesCompositesWhereAssociation);
			}
		}

		virtual public bool ExistGeographicBoundariesCompositesWhereAssociation
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.GeographicBoundariesCompositesWhereAssociation);
			}
		}


		virtual public global::Allors.Extent<EstimatedProductCost> EstimatedProductCostsWhereGeographicBoundary
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.EstimatedProductCostsWhereGeographicBoundary);
			}
		}

		virtual public bool ExistEstimatedProductCostsWhereGeographicBoundary
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.EstimatedProductCostsWhereGeographicBoundary);
			}
		}


		virtual public global::Allors.Extent<PostalAddress> PostalAddressesWhereGeographicBoundary
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PostalAddressesWhereGeographicBoundary);
			}
		}

		virtual public bool ExistPostalAddressesWhereGeographicBoundary
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PostalAddressesWhereGeographicBoundary);
			}
		}

	}

	public class CountryMeta
	{
		public static readonly CountryMeta Instance = new CountryMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.Country;

		public global::Allors.Meta.RoleType Currency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CountryCurrency;
			}
		} 
		public global::Allors.Meta.RoleType Name 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CountryName;
			}
		} 
		public global::Allors.Meta.RoleType LocalisedName 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CountryLocalisedName;
			}
		} 
		public global::Allors.Meta.RoleType IsoCode 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CountryIsoCode;
			}
		} 
		public global::Allors.Meta.RoleType VatRate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CountryVatRate;
			}
		} 
		public global::Allors.Meta.RoleType IbanLength 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CountryIbanLength;
			}
		} 
		public global::Allors.Meta.RoleType EuMemberState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CountryEuMemberState;
			}
		} 
		public global::Allors.Meta.RoleType TelephoneCode 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CountryTelephoneCode;
			}
		} 
		public global::Allors.Meta.RoleType IbanRegex 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CountryIbanRegex;
			}
		} 
		public global::Allors.Meta.RoleType VatForm 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CountryVatForm;
			}
		} 
		public global::Allors.Meta.RoleType UriExtension 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CountryUriExtension;
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
		public global::Allors.Meta.RoleType SearchData 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SearchableSearchData;
			}
		} 
		public global::Allors.Meta.RoleType Abbreviation 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.GeographicBoundaryAbbreviation;
			}
		} 
		public global::Allors.Meta.RoleType Latitude 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.GeoLocatableLatitude;
			}
		} 
		public global::Allors.Meta.RoleType Longitude 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.GeoLocatableLongitude;
			}
		} 
		public global::Allors.Meta.RoleType UniqueId 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UniquelyIdentifiableUniqueId;
			}
		} 
		public global::Allors.Meta.RoleType City 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CityBoundCity;
			}
		} 

		public global::Allors.Meta.AssociationType LocalesWhereCountry 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.LocaleCountry;
			}
		} 
		public global::Allors.Meta.AssociationType CitizenshipsWhereCountry 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CitizenshipCountry;
			}
		} 
		public global::Allors.Meta.AssociationType BanksWhereCountry 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.BankCountry;
			}
		} 
		public global::Allors.Meta.AssociationType InternalOrganisationsWhereEuListingState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InternalOrganisationEuListingState;
			}
		} 
		public global::Allors.Meta.AssociationType PostalAddressesWhereCountry 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PostalAddressCountry;
			}
		} 
		public global::Allors.Meta.AssociationType PostalBoundariesWhereCountry 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PostalBoundaryCountry;
			}
		} 
		public global::Allors.Meta.AssociationType CountryBoundsWhereCountry 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CountryBoundCountry;
			}
		} 
		public global::Allors.Meta.AssociationType ShippingAndHandlingComponentsWhereGeographicBoundary 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ShippingAndHandlingComponentGeographicBoundary;
			}
		} 
		public global::Allors.Meta.AssociationType PriceComponentsWhereGeographicBoundary 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PriceComponentGeographicBoundary;
			}
		} 
		public global::Allors.Meta.AssociationType GeographicBoundariesCompositesWhereAssociation 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.GeographicBoundaryCompositeAssociation;
			}
		} 
		public global::Allors.Meta.AssociationType EstimatedProductCostsWhereGeographicBoundary 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.EstimatedProductCostGeographicBoundary;
			}
		} 
		public global::Allors.Meta.AssociationType PostalAddressesWhereGeographicBoundary 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PostalAddressGeographicBoundary;
			}
		} 

	}
}