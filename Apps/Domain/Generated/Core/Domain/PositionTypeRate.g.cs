// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class PositionTypeRate : Allors.ObjectBase , AccessControlledObject, UserInterfaceable
	{
		public static readonly PositionTypeRateMeta Meta = PositionTypeRateMeta.Instance;

		public PositionTypeRate(Allors.IStrategy allors) : base(allors) {}

		public static PositionTypeRate Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (PositionTypeRate) allorsSession.Instantiate(allorsObjectId);		
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


		virtual public RateType RateType
		{ 
			get
			{
				return (RateType) Strategy.GetCompositeRole(Meta.RateType);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.RateType ,value);
			}
		}

		virtual public bool ExistRateType
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.RateType);
			}
		}

		virtual public void RemoveRateType()
		{
			Strategy.RemoveCompositeRole(Meta.RateType);
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



		virtual public global::Allors.Extent<PositionType> PositionTypesWherePositionTypeRate
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PositionTypesWherePositionTypeRate);
			}
		}

		virtual public bool ExistPositionTypesWherePositionTypeRate
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PositionTypesWherePositionTypeRate);
			}
		}

	}

	public class PositionTypeRateMeta
	{
		public static readonly PositionTypeRateMeta Instance = new PositionTypeRateMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.PositionTypeRate;

		public global::Allors.Meta.RoleType Rate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PositionTypeRateRate;
			}
		} 
		public global::Allors.Meta.RoleType RateType 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PositionTypeRateRateType;
			}
		} 
		public global::Allors.Meta.RoleType TimeFrequency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PositionTypeRateTimeFrequency;
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

		public global::Allors.Meta.AssociationType PositionTypesWherePositionTypeRate 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PositionTypePositionTypeRate;
			}
		} 

	}
}