// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class Permission : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly PermissionMeta Meta = PermissionMeta.Instance;

		public Permission(Allors.IStrategy allors) : base(allors) {}

		public static Permission Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (Permission) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.Guid OperandTypePointer 
		{
			get
			{
				return (global::System.Guid) Strategy.GetUnitRole(Meta.OperandTypePointer);
			}
			set
			{
				Strategy.SetUnitRole(Meta.OperandTypePointer, value);
			}
		}

		virtual public bool ExistOperandTypePointer{
			get
			{
				return Strategy.ExistUnitRole(Meta.OperandTypePointer);
			}
		}

		virtual public void RemoveOperandTypePointer()
		{
			Strategy.RemoveUnitRole(Meta.OperandTypePointer);
		}



		virtual public global::System.Guid ConcreteClassPointer 
		{
			get
			{
				return (global::System.Guid) Strategy.GetUnitRole(Meta.ConcreteClassPointer);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ConcreteClassPointer, value);
			}
		}

		virtual public bool ExistConcreteClassPointer{
			get
			{
				return Strategy.ExistUnitRole(Meta.ConcreteClassPointer);
			}
		}

		virtual public void RemoveConcreteClassPointer()
		{
			Strategy.RemoveUnitRole(Meta.ConcreteClassPointer);
		}



		virtual public global::System.Int32 OperationEnum 
		{
			get
			{
				return (global::System.Int32) Strategy.GetUnitRole(Meta.OperationEnum);
			}
			set
			{
				Strategy.SetUnitRole(Meta.OperationEnum, value);
			}
		}

		virtual public bool ExistOperationEnum{
			get
			{
				return Strategy.ExistUnitRole(Meta.OperationEnum);
			}
		}

		virtual public void RemoveOperationEnum()
		{
			Strategy.RemoveUnitRole(Meta.OperationEnum);
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



		virtual public global::Allors.Extent<Role> RolesWherePermission
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.RolesWherePermission);
			}
		}

		virtual public bool ExistRolesWherePermission
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.RolesWherePermission);
			}
		}


		virtual public global::Allors.Extent<AccessControlledObject> AccessControlledObjectsWhereDeniedPermission
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.AccessControlledObjectsWhereDeniedPermission);
			}
		}

		virtual public bool ExistAccessControlledObjectsWhereDeniedPermission
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.AccessControlledObjectsWhereDeniedPermission);
			}
		}


		virtual public global::Allors.Extent<ObjectState> ObjectStatesWhereDeniedPermission
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ObjectStatesWhereDeniedPermission);
			}
		}

		virtual public bool ExistObjectStatesWhereDeniedPermission
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ObjectStatesWhereDeniedPermission);
			}
		}

	}

	public class PermissionMeta
	{
		public static readonly PermissionMeta Instance = new PermissionMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.Permission;

		public global::Allors.Meta.RoleType OperandTypePointer 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PermissionOperandTypePointer;
			}
		} 
		public global::Allors.Meta.RoleType ConcreteClassPointer 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PermissionConcreteClassPointer;
			}
		} 
		public global::Allors.Meta.RoleType OperationEnum 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PermissionOperationEnum;
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

		public global::Allors.Meta.AssociationType RolesWherePermission 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.RolePermission;
			}
		} 
		public global::Allors.Meta.AssociationType AccessControlledObjectsWhereDeniedPermission 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.AccessControlledObjectDeniedPermission;
			}
		} 
		public global::Allors.Meta.AssociationType ObjectStatesWhereDeniedPermission 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ObjectStateDeniedPermission;
			}
		} 

	}
}