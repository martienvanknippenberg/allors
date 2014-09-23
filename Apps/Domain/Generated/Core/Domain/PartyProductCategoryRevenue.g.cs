// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class PartyProductCategoryRevenue : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly PartyProductCategoryRevenueMeta Meta = PartyProductCategoryRevenueMeta.Instance;

		public PartyProductCategoryRevenue(Allors.IStrategy allors) : base(allors) {}

		public static PartyProductCategoryRevenue Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (PartyProductCategoryRevenue) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public Party Party
		{ 
			get
			{
				return (Party) Strategy.GetCompositeRole(Meta.Party);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Party ,value);
			}
		}

		virtual public bool ExistParty
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Party);
			}
		}

		virtual public void RemoveParty()
		{
			Strategy.RemoveCompositeRole(Meta.Party);
		}



		virtual public global::System.Decimal? Revenue 
		{
			get
			{
				return (global::System.Decimal?) Strategy.GetUnitRole(Meta.Revenue);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Revenue, value);
			}
		}

		virtual public bool ExistRevenue{
			get
			{
				return Strategy.ExistUnitRole(Meta.Revenue);
			}
		}

		virtual public void RemoveRevenue()
		{
			Strategy.RemoveUnitRole(Meta.Revenue);
		}



		virtual public global::System.Int32? Month 
		{
			get
			{
				return (global::System.Int32?) Strategy.GetUnitRole(Meta.Month);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Month, value);
			}
		}

		virtual public bool ExistMonth{
			get
			{
				return Strategy.ExistUnitRole(Meta.Month);
			}
		}

		virtual public void RemoveMonth()
		{
			Strategy.RemoveUnitRole(Meta.Month);
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



		virtual public global::System.Int32? Year 
		{
			get
			{
				return (global::System.Int32?) Strategy.GetUnitRole(Meta.Year);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Year, value);
			}
		}

		virtual public bool ExistYear{
			get
			{
				return Strategy.ExistUnitRole(Meta.Year);
			}
		}

		virtual public void RemoveYear()
		{
			Strategy.RemoveUnitRole(Meta.Year);
		}



		virtual public global::System.String PartyProductCategoryName 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.PartyProductCategoryName);
			}
			set
			{
				Strategy.SetUnitRole(Meta.PartyProductCategoryName, value);
			}
		}

		virtual public bool ExistPartyProductCategoryName{
			get
			{
				return Strategy.ExistUnitRole(Meta.PartyProductCategoryName);
			}
		}

		virtual public void RemovePartyProductCategoryName()
		{
			Strategy.RemoveUnitRole(Meta.PartyProductCategoryName);
		}


		virtual public InternalOrganisation InternalOrganisation
		{ 
			get
			{
				return (InternalOrganisation) Strategy.GetCompositeRole(Meta.InternalOrganisation);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.InternalOrganisation ,value);
			}
		}

		virtual public bool ExistInternalOrganisation
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.InternalOrganisation);
			}
		}

		virtual public void RemoveInternalOrganisation()
		{
			Strategy.RemoveCompositeRole(Meta.InternalOrganisation);
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



		virtual public global::System.Decimal? Quantity 
		{
			get
			{
				return (global::System.Decimal?) Strategy.GetUnitRole(Meta.Quantity);
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

	}

	public class PartyProductCategoryRevenueMeta
	{
		public static readonly PartyProductCategoryRevenueMeta Instance = new PartyProductCategoryRevenueMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.PartyProductCategoryRevenue;

		public global::Allors.Meta.RoleType Party 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyProductCategoryRevenueParty;
			}
		} 
		public global::Allors.Meta.RoleType Revenue 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyProductCategoryRevenueRevenue;
			}
		} 
		public global::Allors.Meta.RoleType Month 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyProductCategoryRevenueMonth;
			}
		} 
		public global::Allors.Meta.RoleType Currency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyProductCategoryRevenueCurrency;
			}
		} 
		public global::Allors.Meta.RoleType Year 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyProductCategoryRevenueYear;
			}
		} 
		public global::Allors.Meta.RoleType PartyProductCategoryName 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyProductCategoryRevenuePartyProductCategoryName;
			}
		} 
		public global::Allors.Meta.RoleType InternalOrganisation 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyProductCategoryRevenueInternalOrganisation;
			}
		} 
		public global::Allors.Meta.RoleType ProductCategory 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyProductCategoryRevenueProductCategory;
			}
		} 
		public global::Allors.Meta.RoleType Quantity 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyProductCategoryRevenueQuantity;
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

	}
}