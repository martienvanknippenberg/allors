// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class PickListStatus : Allors.ObjectBase , UserInterfaceable, AccessControlledObject
	{
		public static readonly PickListStatusMeta Meta = PickListStatusMeta.Instance;

		public PickListStatus(Allors.IStrategy allors) : base(allors) {}

		public static PickListStatus Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (PickListStatus) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public PickListObjectState PickListObjectState
		{ 
			get
			{
				return (PickListObjectState) Strategy.GetCompositeRole(Meta.PickListObjectState);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.PickListObjectState ,value);
			}
		}

		virtual public bool ExistPickListObjectState
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.PickListObjectState);
			}
		}

		virtual public void RemovePickListObjectState()
		{
			Strategy.RemoveCompositeRole(Meta.PickListObjectState);
		}



		virtual public global::System.DateTime? StartDateTime 
		{
			get
			{
				return (global::System.DateTime?) Strategy.GetUnitRole(Meta.StartDateTime);
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



		virtual public PickList PickListWhereCurrentPickListStatus
		{ 
			get
			{
				return (PickList) Strategy.GetCompositeAssociation(Meta.PickListWhereCurrentPickListStatus);
			}
		} 

		virtual public bool ExistPickListWhereCurrentPickListStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.PickListWhereCurrentPickListStatus);
			}
		}


		virtual public PickList PickListWherePickListStatus
		{ 
			get
			{
				return (PickList) Strategy.GetCompositeAssociation(Meta.PickListWherePickListStatus);
			}
		} 

		virtual public bool ExistPickListWherePickListStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.PickListWherePickListStatus);
			}
		}

	}

	public class PickListStatusMeta
	{
		public static readonly PickListStatusMeta Instance = new PickListStatusMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.PickListStatus;

		public global::Allors.Meta.RoleType PickListObjectState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PickListStatusPickListObjectState;
			}
		} 
		public global::Allors.Meta.RoleType StartDateTime 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PickListStatusStartDateTime;
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

		public global::Allors.Meta.AssociationType PickListWhereCurrentPickListStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PickListCurrentPickListStatus;
			}
		} 
		public global::Allors.Meta.AssociationType PickListWherePickListStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PickListPickListStatus;
			}
		} 

	}
}