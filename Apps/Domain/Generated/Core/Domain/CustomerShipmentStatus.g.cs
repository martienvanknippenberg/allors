// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class CustomerShipmentStatus : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly CustomerShipmentStatusMeta Meta = CustomerShipmentStatusMeta.Instance;

		public CustomerShipmentStatus(Allors.IStrategy allors) : base(allors) {}

		public static CustomerShipmentStatus Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (CustomerShipmentStatus) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public CustomerShipmentObjectState CustomerShipmentObjectState
		{ 
			get
			{
				return (CustomerShipmentObjectState) Strategy.GetCompositeRole(Meta.CustomerShipmentObjectState);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.CustomerShipmentObjectState ,value);
			}
		}

		virtual public bool ExistCustomerShipmentObjectState
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.CustomerShipmentObjectState);
			}
		}

		virtual public void RemoveCustomerShipmentObjectState()
		{
			Strategy.RemoveCompositeRole(Meta.CustomerShipmentObjectState);
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



		virtual public CustomerShipment CustomerShipmentWhereCurrentShipmentStatus
		{ 
			get
			{
				return (CustomerShipment) Strategy.GetCompositeAssociation(Meta.CustomerShipmentWhereCurrentShipmentStatus);
			}
		} 

		virtual public bool ExistCustomerShipmentWhereCurrentShipmentStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.CustomerShipmentWhereCurrentShipmentStatus);
			}
		}


		virtual public CustomerShipment CustomerShipmentWhereShipmentStatus
		{ 
			get
			{
				return (CustomerShipment) Strategy.GetCompositeAssociation(Meta.CustomerShipmentWhereShipmentStatus);
			}
		} 

		virtual public bool ExistCustomerShipmentWhereShipmentStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.CustomerShipmentWhereShipmentStatus);
			}
		}

	}

	public class CustomerShipmentStatusMeta
	{
		public static readonly CustomerShipmentStatusMeta Instance = new CustomerShipmentStatusMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.CustomerShipmentStatus;

		public global::Allors.Meta.RoleType CustomerShipmentObjectState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CustomerShipmentStatusCustomerShipmentObjectState;
			}
		} 
		public global::Allors.Meta.RoleType StartDateTime 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CustomerShipmentStatusStartDateTime;
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

		public global::Allors.Meta.AssociationType CustomerShipmentWhereCurrentShipmentStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CustomerShipmentCurrentShipmentStatus;
			}
		} 
		public global::Allors.Meta.AssociationType CustomerShipmentWhereShipmentStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CustomerShipmentShipmentStatus;
			}
		} 

	}
}