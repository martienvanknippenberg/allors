// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class Place : Allors.ObjectBase , UserInterfaceable, Searchable
	{
		public static readonly PlaceMeta Meta = PlaceMeta.Instance;

		public Place(Allors.IStrategy allors) : base(allors) {}

		public static Place Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (Place) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public Country Country
		{ 
			get
			{
				return (Country) Strategy.GetCompositeRole(Meta.Country);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Country ,value);
			}
		}

		virtual public bool ExistCountry
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Country);
			}
		}

		virtual public void RemoveCountry()
		{
			Strategy.RemoveCompositeRole(Meta.Country);
		}



		virtual public global::System.String City 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.City);
			}
			set
			{
				Strategy.SetUnitRole(Meta.City, value);
			}
		}

		virtual public bool ExistCity{
			get
			{
				return Strategy.ExistUnitRole(Meta.City);
			}
		}

		virtual public void RemoveCity()
		{
			Strategy.RemoveUnitRole(Meta.City);
		}



		virtual public global::System.String PostalCode 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.PostalCode);
			}
			set
			{
				Strategy.SetUnitRole(Meta.PostalCode, value);
			}
		}

		virtual public bool ExistPostalCode{
			get
			{
				return Strategy.ExistUnitRole(Meta.PostalCode);
			}
		}

		virtual public void RemovePostalCode()
		{
			Strategy.RemoveUnitRole(Meta.PostalCode);
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



		virtual public global::Allors.Extent<Address> AddressesWherePlace
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.AddressesWherePlace);
			}
		}

		virtual public bool ExistAddressesWherePlace
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.AddressesWherePlace);
			}
		}

	}

	public class PlaceMeta
	{
		public static readonly PlaceMeta Instance = new PlaceMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.Place;

		public global::Allors.Meta.RoleType Country 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PlaceCountry;
			}
		} 
		public global::Allors.Meta.RoleType City 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PlaceCity;
			}
		} 
		public global::Allors.Meta.RoleType PostalCode 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PlacePostalCode;
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

		public global::Allors.Meta.AssociationType AddressesWherePlace 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.AddressPlace;
			}
		} 

	}
}