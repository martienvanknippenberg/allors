// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class DropShipmentStatus : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly DropShipmentStatusMeta Meta = DropShipmentStatusMeta.Instance;

		public DropShipmentStatus(Allors.IStrategy allors) : base(allors) {}

		public static DropShipmentStatus Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (DropShipmentStatus) allorsSession.Instantiate(allorsObjectId);		
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


		virtual public DropShipmentObjectState DropShipmentObjectState
		{ 
			get
			{
				return (DropShipmentObjectState) Strategy.GetCompositeRole(Meta.DropShipmentObjectState);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.DropShipmentObjectState ,value);
			}
		}

		virtual public bool ExistDropShipmentObjectState
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.DropShipmentObjectState);
			}
		}

		virtual public void RemoveDropShipmentObjectState()
		{
			Strategy.RemoveCompositeRole(Meta.DropShipmentObjectState);
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



		virtual public DropShipment DropShipmentWhereShipmentStatus
		{ 
			get
			{
				return (DropShipment) Strategy.GetCompositeAssociation(Meta.DropShipmentWhereShipmentStatus);
			}
		} 

		virtual public bool ExistDropShipmentWhereShipmentStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.DropShipmentWhereShipmentStatus);
			}
		}


		virtual public DropShipment DropShipmentWhereCurrentShipmentStatus
		{ 
			get
			{
				return (DropShipment) Strategy.GetCompositeAssociation(Meta.DropShipmentWhereCurrentShipmentStatus);
			}
		} 

		virtual public bool ExistDropShipmentWhereCurrentShipmentStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.DropShipmentWhereCurrentShipmentStatus);
			}
		}

	}

	public class DropShipmentStatusMeta
	{
		public static readonly DropShipmentStatusMeta Instance = new DropShipmentStatusMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.DropShipmentStatus;

		public global::Allors.Meta.RoleType StartDateTime 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.DropShipmentStatusStartDateTime;
			}
		} 
		public global::Allors.Meta.RoleType DropShipmentObjectState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.DropShipmentStatusDropShipmentObjectState;
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

		public global::Allors.Meta.AssociationType DropShipmentWhereShipmentStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.DropShipmentShipmentStatus;
			}
		} 
		public global::Allors.Meta.AssociationType DropShipmentWhereCurrentShipmentStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.DropShipmentCurrentShipmentStatus;
			}
		} 

	}
}