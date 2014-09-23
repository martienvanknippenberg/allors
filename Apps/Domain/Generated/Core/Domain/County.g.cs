// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class County : Allors.ObjectBase , GeographicBoundary, CityBound, UserInterfaceable
	{
		public static readonly CountyMeta Meta = CountyMeta.Instance;

		public County(Allors.IStrategy allors) : base(allors) {}

		public static County Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (County) allorsSession.Instantiate(allorsObjectId);		
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


		virtual public State State
		{ 
			get
			{
				return (State) Strategy.GetCompositeRole(Meta.State);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.State ,value);
			}
		}

		virtual public bool ExistState
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.State);
			}
		}

		virtual public void RemoveState()
		{
			Strategy.RemoveCompositeRole(Meta.State);
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



		virtual public global::System.Decimal? Latitude 
		{
			get
			{
				return (global::System.Decimal?) Strategy.GetUnitRole(Meta.Latitude);
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



		virtual public global::System.Decimal? Longitude 
		{
			get
			{
				return (global::System.Decimal?) Strategy.GetUnitRole(Meta.Longitude);
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



		virtual public global::System.Guid? UniqueId 
		{
			get
			{
				return (global::System.Guid?) Strategy.GetUnitRole(Meta.UniqueId);
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

	public class CountyMeta
	{
		public static readonly CountyMeta Instance = new CountyMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.County;

		public global::Allors.Meta.RoleType Name 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CountyName;
			}
		} 
		public global::Allors.Meta.RoleType State 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CountyState;
			}
		} 
		public global::Allors.Meta.RoleType Abbreviation 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.GeographicBoundaryAbbreviation;
			}
		} 
		public global::Allors.Meta.RoleType SearchData 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SearchableSearchData;
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
		public global::Allors.Meta.RoleType DisplayName 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UserInterfaceableDisplayName;
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