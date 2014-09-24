// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class PurchaseReturnStatus : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly PurchaseReturnStatusMeta Meta = PurchaseReturnStatusMeta.Instance;

		public PurchaseReturnStatus(Allors.IStrategy allors) : base(allors) {}

		public static PurchaseReturnStatus Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (PurchaseReturnStatus) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public PurchaseReturnObjectState PurchaseReturnObjectState
		{ 
			get
			{
				return (PurchaseReturnObjectState) Strategy.GetCompositeRole(Meta.PurchaseReturnObjectState);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.PurchaseReturnObjectState ,value);
			}
		}

		virtual public bool ExistPurchaseReturnObjectState
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.PurchaseReturnObjectState);
			}
		}

		virtual public void RemovePurchaseReturnObjectState()
		{
			Strategy.RemoveCompositeRole(Meta.PurchaseReturnObjectState);
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



		virtual public PurchaseReturn PurchaseReturnWhereCurrentShipmentStatus
		{ 
			get
			{
				return (PurchaseReturn) Strategy.GetCompositeAssociation(Meta.PurchaseReturnWhereCurrentShipmentStatus);
			}
		} 

		virtual public bool ExistPurchaseReturnWhereCurrentShipmentStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.PurchaseReturnWhereCurrentShipmentStatus);
			}
		}


		virtual public PurchaseReturn PurchaseReturnWhereShipmentStatus
		{ 
			get
			{
				return (PurchaseReturn) Strategy.GetCompositeAssociation(Meta.PurchaseReturnWhereShipmentStatus);
			}
		} 

		virtual public bool ExistPurchaseReturnWhereShipmentStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.PurchaseReturnWhereShipmentStatus);
			}
		}

	}

	public class PurchaseReturnStatusMeta
	{
		public static readonly PurchaseReturnStatusMeta Instance = new PurchaseReturnStatusMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.PurchaseReturnStatus;

		public global::Allors.Meta.RoleType PurchaseReturnObjectState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PurchaseReturnStatusPurchaseReturnObjectState;
			}
		} 
		public global::Allors.Meta.RoleType StartDateTime 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PurchaseReturnStatusStartDateTime;
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

		public global::Allors.Meta.AssociationType PurchaseReturnWhereCurrentShipmentStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseReturnCurrentShipmentStatus;
			}
		} 
		public global::Allors.Meta.AssociationType PurchaseReturnWhereShipmentStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseReturnShipmentStatus;
			}
		} 

	}
}