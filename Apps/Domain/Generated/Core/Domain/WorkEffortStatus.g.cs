// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class WorkEffortStatus : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly WorkEffortStatusMeta Meta = WorkEffortStatusMeta.Instance;

		public WorkEffortStatus(Allors.IStrategy allors) : base(allors) {}

		public static WorkEffortStatus Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (WorkEffortStatus) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.DateTime StartDateTime 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.StartDateTime);
			}
			set
			{
				Strategy.SetUnitRole(Meta.StartDateTime, value);
			}
		}

		virtual public bool ExistStartDateTime{
			get
			{
				return Strategy.ExistUnitRole(Meta.StartDateTime);
			}
		}

		virtual public void RemoveStartDateTime()
		{
			Strategy.RemoveUnitRole(Meta.StartDateTime);
		}


		virtual public WorkEffortObjectState WorkEffortObjectState
		{ 
			get
			{
				return (WorkEffortObjectState) Strategy.GetCompositeRole(Meta.WorkEffortObjectState);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.WorkEffortObjectState ,value);
			}
		}

		virtual public bool ExistWorkEffortObjectState
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.WorkEffortObjectState);
			}
		}

		virtual public void RemoveWorkEffortObjectState()
		{
			Strategy.RemoveCompositeRole(Meta.WorkEffortObjectState);
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



		virtual public WorkEffort WorkEffortWhereCurrentWorkEffortStatus
		{ 
			get
			{
				return (WorkEffort) Strategy.GetCompositeAssociation(Meta.WorkEffortWhereCurrentWorkEffortStatus);
			}
		} 

		virtual public bool ExistWorkEffortWhereCurrentWorkEffortStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.WorkEffortWhereCurrentWorkEffortStatus);
			}
		}


		virtual public WorkEffort WorkEffortWhereWorkEffortStatus
		{ 
			get
			{
				return (WorkEffort) Strategy.GetCompositeAssociation(Meta.WorkEffortWhereWorkEffortStatus);
			}
		} 

		virtual public bool ExistWorkEffortWhereWorkEffortStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.WorkEffortWhereWorkEffortStatus);
			}
		}

	}

	public class WorkEffortStatusMeta
	{
		public static readonly WorkEffortStatusMeta Instance = new WorkEffortStatusMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.WorkEffortStatus;

		public global::Allors.Meta.RoleType StartDateTime 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortStatusStartDateTime;
			}
		} 
		public global::Allors.Meta.RoleType WorkEffortObjectState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortStatusWorkEffortObjectState;
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

		public global::Allors.Meta.AssociationType WorkEffortWhereCurrentWorkEffortStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.WorkEffortCurrentWorkEffortStatus;
			}
		} 
		public global::Allors.Meta.AssociationType WorkEffortWhereWorkEffortStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.WorkEffortWorkEffortStatus;
			}
		} 

	}
}