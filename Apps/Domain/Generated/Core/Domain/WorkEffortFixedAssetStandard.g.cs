// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class WorkEffortFixedAssetStandard : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly WorkEffortFixedAssetStandardMeta Meta = WorkEffortFixedAssetStandardMeta.Instance;

		public WorkEffortFixedAssetStandard(Allors.IStrategy allors) : base(allors) {}

		public static WorkEffortFixedAssetStandard Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (WorkEffortFixedAssetStandard) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.Decimal EstimatedCost 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.EstimatedCost);
			}
			set
			{
				Strategy.SetUnitRole(Meta.EstimatedCost, value);
			}
		}

		virtual public bool ExistEstimatedCost{
			get
			{
				return Strategy.ExistUnitRole(Meta.EstimatedCost);
			}
		}

		virtual public void RemoveEstimatedCost()
		{
			Strategy.RemoveUnitRole(Meta.EstimatedCost);
		}



		virtual public global::System.Decimal EstimatedDuration 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.EstimatedDuration);
			}
			set
			{
				Strategy.SetUnitRole(Meta.EstimatedDuration, value);
			}
		}

		virtual public bool ExistEstimatedDuration{
			get
			{
				return Strategy.ExistUnitRole(Meta.EstimatedDuration);
			}
		}

		virtual public void RemoveEstimatedDuration()
		{
			Strategy.RemoveUnitRole(Meta.EstimatedDuration);
		}


		virtual public FixedAsset FixedAsset
		{ 
			get
			{
				return (FixedAsset) Strategy.GetCompositeRole(Meta.FixedAsset);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.FixedAsset ,value);
			}
		}

		virtual public bool ExistFixedAsset
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.FixedAsset);
			}
		}

		virtual public void RemoveFixedAsset()
		{
			Strategy.RemoveCompositeRole(Meta.FixedAsset);
		}



		virtual public global::System.Int32 EstimatedQuantity 
		{
			get
			{
				return (global::System.Int32) Strategy.GetUnitRole(Meta.EstimatedQuantity);
			}
			set
			{
				Strategy.SetUnitRole(Meta.EstimatedQuantity, value);
			}
		}

		virtual public bool ExistEstimatedQuantity{
			get
			{
				return Strategy.ExistUnitRole(Meta.EstimatedQuantity);
			}
		}

		virtual public void RemoveEstimatedQuantity()
		{
			Strategy.RemoveUnitRole(Meta.EstimatedQuantity);
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



		virtual public WorkEffortType WorkEffortTypeWhereWorkEffortFixedAssetStandard
		{ 
			get
			{
				return (WorkEffortType) Strategy.GetCompositeAssociation(Meta.WorkEffortTypeWhereWorkEffortFixedAssetStandard);
			}
		} 

		virtual public bool ExistWorkEffortTypeWhereWorkEffortFixedAssetStandard
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.WorkEffortTypeWhereWorkEffortFixedAssetStandard);
			}
		}

	}

	public class WorkEffortFixedAssetStandardMeta
	{
		public static readonly WorkEffortFixedAssetStandardMeta Instance = new WorkEffortFixedAssetStandardMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.WorkEffortFixedAssetStandard;

		public global::Allors.Meta.RoleType EstimatedCost 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortFixedAssetStandardEstimatedCost;
			}
		} 
		public global::Allors.Meta.RoleType EstimatedDuration 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortFixedAssetStandardEstimatedDuration;
			}
		} 
		public global::Allors.Meta.RoleType FixedAsset 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortFixedAssetStandardFixedAsset;
			}
		} 
		public global::Allors.Meta.RoleType EstimatedQuantity 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortFixedAssetStandardEstimatedQuantity;
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

		public global::Allors.Meta.AssociationType WorkEffortTypeWhereWorkEffortFixedAssetStandard 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.WorkEffortTypeWorkEffortFixedAssetStandard;
			}
		} 

	}
}