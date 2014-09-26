// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class PartyProductRevenueHistory : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly PartyProductRevenueHistoryMeta Meta = PartyProductRevenueHistoryMeta.Instance;

		public PartyProductRevenueHistory(Allors.IStrategy allors) : base(allors) {}

		public static PartyProductRevenueHistory Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (PartyProductRevenueHistory) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.Decimal Revenue 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.Revenue);
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

	public class PartyProductRevenueHistoryMeta
	{
		public static readonly PartyProductRevenueHistoryMeta Instance = new PartyProductRevenueHistoryMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.PartyProductRevenueHistory;

		public global::Allors.Meta.RoleType Revenue 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyProductRevenueHistoryRevenue;
			}
		} 
		public global::Allors.Meta.RoleType Party 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyProductRevenueHistoryParty;
			}
		} 
		public global::Allors.Meta.RoleType Product 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyProductRevenueHistoryProduct;
			}
		} 
		public global::Allors.Meta.RoleType Quantity 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyProductRevenueHistoryQuantity;
			}
		} 
		public global::Allors.Meta.RoleType InternalOrganisation 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyProductRevenueHistoryInternalOrganisation;
			}
		} 
		public global::Allors.Meta.RoleType Currency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyProductRevenueHistoryCurrency;
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