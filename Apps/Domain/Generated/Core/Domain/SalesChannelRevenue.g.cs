// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class SalesChannelRevenue : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly SalesChannelRevenueMeta Meta = SalesChannelRevenueMeta.Instance;

		public SalesChannelRevenue(Allors.IStrategy allors) : base(allors) {}

		public static SalesChannelRevenue Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (SalesChannelRevenue) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.Int32 Year 
		{
			get
			{
				return (global::System.Int32) Strategy.GetUnitRole(Meta.Year);
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



		virtual public global::System.Int32 Month 
		{
			get
			{
				return (global::System.Int32) Strategy.GetUnitRole(Meta.Month);
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



		virtual public global::System.String SalesChannelName 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.SalesChannelName);
			}
			set
			{
				Strategy.SetUnitRole(Meta.SalesChannelName, value);
			}
		}

		virtual public bool ExistSalesChannelName{
			get
			{
				return Strategy.ExistUnitRole(Meta.SalesChannelName);
			}
		}

		virtual public void RemoveSalesChannelName()
		{
			Strategy.RemoveUnitRole(Meta.SalesChannelName);
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

	public class SalesChannelRevenueMeta
	{
		public static readonly SalesChannelRevenueMeta Instance = new SalesChannelRevenueMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.SalesChannelRevenue;

		public global::Allors.Meta.RoleType Year 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SalesChannelRevenueYear;
			}
		} 
		public global::Allors.Meta.RoleType Month 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SalesChannelRevenueMonth;
			}
		} 
		public global::Allors.Meta.RoleType Currency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SalesChannelRevenueCurrency;
			}
		} 
		public global::Allors.Meta.RoleType SalesChannel 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SalesChannelRevenueSalesChannel;
			}
		} 
		public global::Allors.Meta.RoleType SalesChannelName 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SalesChannelRevenueSalesChannelName;
			}
		} 
		public global::Allors.Meta.RoleType Revenue 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SalesChannelRevenueRevenue;
			}
		} 
		public global::Allors.Meta.RoleType InternalOrganisation 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SalesChannelRevenueInternalOrganisation;
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