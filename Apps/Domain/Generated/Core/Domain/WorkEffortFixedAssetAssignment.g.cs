// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class WorkEffortFixedAssetAssignment : Allors.ObjectBase , Commentable, UserInterfaceable, Period
	{
		public static readonly WorkEffortFixedAssetAssignmentMeta Meta = WorkEffortFixedAssetAssignmentMeta.Instance;

		public WorkEffortFixedAssetAssignment(Allors.IStrategy allors) : base(allors) {}

		public static WorkEffortFixedAssetAssignment Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (WorkEffortFixedAssetAssignment) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public AssetAssignmentStatus AssetAssignmentStatus
		{ 
			get
			{
				return (AssetAssignmentStatus) Strategy.GetCompositeRole(Meta.AssetAssignmentStatus);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.AssetAssignmentStatus ,value);
			}
		}

		virtual public bool ExistAssetAssignmentStatus
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.AssetAssignmentStatus);
			}
		}

		virtual public void RemoveAssetAssignmentStatus()
		{
			Strategy.RemoveCompositeRole(Meta.AssetAssignmentStatus);
		}


		virtual public WorkEffort Assignment
		{ 
			get
			{
				return (WorkEffort) Strategy.GetCompositeRole(Meta.Assignment);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Assignment ,value);
			}
		}

		virtual public bool ExistAssignment
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Assignment);
			}
		}

		virtual public void RemoveAssignment()
		{
			Strategy.RemoveCompositeRole(Meta.Assignment);
		}



		virtual public global::System.Decimal AllocatedCost 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.AllocatedCost);
			}
			set
			{
				Strategy.SetUnitRole(Meta.AllocatedCost, value);
			}
		}

		virtual public bool ExistAllocatedCost{
			get
			{
				return Strategy.ExistUnitRole(Meta.AllocatedCost);
			}
		}

		virtual public void RemoveAllocatedCost()
		{
			Strategy.RemoveUnitRole(Meta.AllocatedCost);
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



		virtual public global::System.String Comment 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Comment);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Comment, value);
			}
		}

		virtual public bool ExistComment{
			get
			{
				return Strategy.ExistUnitRole(Meta.Comment);
			}
		}

		virtual public void RemoveComment()
		{
			Strategy.RemoveUnitRole(Meta.Comment);
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



		virtual public global::System.DateTime FromDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.FromDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.FromDate, value);
			}
		}

		virtual public bool ExistFromDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.FromDate);
			}
		}

		virtual public void RemoveFromDate()
		{
			Strategy.RemoveUnitRole(Meta.FromDate);
		}



		virtual public global::System.DateTime ThroughDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.ThroughDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ThroughDate, value);
			}
		}

		virtual public bool ExistThroughDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.ThroughDate);
			}
		}

		virtual public void RemoveThroughDate()
		{
			Strategy.RemoveUnitRole(Meta.ThroughDate);
		}

	}

	public class WorkEffortFixedAssetAssignmentMeta
	{
		public static readonly WorkEffortFixedAssetAssignmentMeta Instance = new WorkEffortFixedAssetAssignmentMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.WorkEffortFixedAssetAssignment;

		public global::Allors.Meta.RoleType AssetAssignmentStatus 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortFixedAssetAssignmentAssetAssignmentStatus;
			}
		} 
		public global::Allors.Meta.RoleType Assignment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortFixedAssetAssignmentAssignment;
			}
		} 
		public global::Allors.Meta.RoleType AllocatedCost 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortFixedAssetAssignmentAllocatedCost;
			}
		} 
		public global::Allors.Meta.RoleType FixedAsset 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortFixedAssetAssignmentFixedAsset;
			}
		} 
		public global::Allors.Meta.RoleType Comment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommentableComment;
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
		public global::Allors.Meta.RoleType FromDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PeriodFromDate;
			}
		} 
		public global::Allors.Meta.RoleType ThroughDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PeriodThroughDate;
			}
		} 

	}
}