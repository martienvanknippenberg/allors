// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class CustomerReturnStatus : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly CustomerReturnStatusMeta Meta = CustomerReturnStatusMeta.Instance;

		public CustomerReturnStatus(Allors.IStrategy allors) : base(allors) {}

		public static CustomerReturnStatus Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (CustomerReturnStatus) allorsSession.Instantiate(allorsObjectId);		
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


		virtual public ShipmentReceipt ShipmentReceipt
		{ 
			get
			{
				return (ShipmentReceipt) Strategy.GetCompositeRole(Meta.ShipmentReceipt);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.ShipmentReceipt ,value);
			}
		}

		virtual public bool ExistShipmentReceipt
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.ShipmentReceipt);
			}
		}

		virtual public void RemoveShipmentReceipt()
		{
			Strategy.RemoveCompositeRole(Meta.ShipmentReceipt);
		}


		virtual public CustomerReturnObjectState CustomerReturnObjectState
		{ 
			get
			{
				return (CustomerReturnObjectState) Strategy.GetCompositeRole(Meta.CustomerReturnObjectState);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.CustomerReturnObjectState ,value);
			}
		}

		virtual public bool ExistCustomerReturnObjectState
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.CustomerReturnObjectState);
			}
		}

		virtual public void RemoveCustomerReturnObjectState()
		{
			Strategy.RemoveCompositeRole(Meta.CustomerReturnObjectState);
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



		virtual public CustomerReturn CustomerReturnWhereCurrentShipmentStatus
		{ 
			get
			{
				return (CustomerReturn) Strategy.GetCompositeAssociation(Meta.CustomerReturnWhereCurrentShipmentStatus);
			}
		} 

		virtual public bool ExistCustomerReturnWhereCurrentShipmentStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.CustomerReturnWhereCurrentShipmentStatus);
			}
		}


		virtual public CustomerReturn CustomerReturnWhereShipmentStatus
		{ 
			get
			{
				return (CustomerReturn) Strategy.GetCompositeAssociation(Meta.CustomerReturnWhereShipmentStatus);
			}
		} 

		virtual public bool ExistCustomerReturnWhereShipmentStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.CustomerReturnWhereShipmentStatus);
			}
		}

	}

	public class CustomerReturnStatusMeta
	{
		public static readonly CustomerReturnStatusMeta Instance = new CustomerReturnStatusMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.CustomerReturnStatus;

		public global::Allors.Meta.RoleType StartDateTime 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CustomerReturnStatusStartDateTime;
			}
		} 
		public global::Allors.Meta.RoleType ShipmentReceipt 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CustomerReturnStatusShipmentReceipt;
			}
		} 
		public global::Allors.Meta.RoleType CustomerReturnObjectState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CustomerReturnStatusCustomerReturnObjectState;
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

		public global::Allors.Meta.AssociationType CustomerReturnWhereCurrentShipmentStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CustomerReturnCurrentShipmentStatus;
			}
		} 
		public global::Allors.Meta.AssociationType CustomerReturnWhereShipmentStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CustomerReturnShipmentStatus;
			}
		} 

	}
}