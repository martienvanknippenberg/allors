// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class RevenueValueBreak : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly RevenueValueBreakMeta Meta = RevenueValueBreakMeta.Instance;

		public RevenueValueBreak(Allors.IStrategy allors) : base(allors) {}

		public static RevenueValueBreak Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (RevenueValueBreak) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.Decimal ThroughAmount 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.ThroughAmount);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ThroughAmount, value);
			}
		}

		virtual public bool ExistThroughAmount{
			get
			{
				return Strategy.ExistUnitRole(Meta.ThroughAmount);
			}
		}

		virtual public void RemoveThroughAmount()
		{
			Strategy.RemoveUnitRole(Meta.ThroughAmount);
		}



		virtual public global::System.Decimal FromAmount 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.FromAmount);
			}
			set
			{
				Strategy.SetUnitRole(Meta.FromAmount, value);
			}
		}

		virtual public bool ExistFromAmount{
			get
			{
				return Strategy.ExistUnitRole(Meta.FromAmount);
			}
		}

		virtual public void RemoveFromAmount()
		{
			Strategy.RemoveUnitRole(Meta.FromAmount);
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



		virtual public global::Allors.Extent<PriceComponent> PriceComponentsWhereRevenueValueBreak
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PriceComponentsWhereRevenueValueBreak);
			}
		}

		virtual public bool ExistPriceComponentsWhereRevenueValueBreak
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PriceComponentsWhereRevenueValueBreak);
			}
		}

	}

	public class RevenueValueBreakMeta
	{
		public static readonly RevenueValueBreakMeta Instance = new RevenueValueBreakMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.RevenueValueBreak;

		public global::Allors.Meta.RoleType ThroughAmount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.RevenueValueBreakThroughAmount;
			}
		} 
		public global::Allors.Meta.RoleType FromAmount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.RevenueValueBreakFromAmount;
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

		public global::Allors.Meta.AssociationType PriceComponentsWhereRevenueValueBreak 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PriceComponentRevenueValueBreak;
			}
		} 

	}
}