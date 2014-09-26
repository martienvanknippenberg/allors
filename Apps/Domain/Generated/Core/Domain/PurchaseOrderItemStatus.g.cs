// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class PurchaseOrderItemStatus : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly PurchaseOrderItemStatusMeta Meta = PurchaseOrderItemStatusMeta.Instance;

		public PurchaseOrderItemStatus(Allors.IStrategy allors) : base(allors) {}

		public static PurchaseOrderItemStatus Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (PurchaseOrderItemStatus) allorsSession.Instantiate(allorsObjectId);		
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


		virtual public PurchaseOrderItemObjectState PurchaseOrderItemObjectState
		{ 
			get
			{
				return (PurchaseOrderItemObjectState) Strategy.GetCompositeRole(Meta.PurchaseOrderItemObjectState);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.PurchaseOrderItemObjectState ,value);
			}
		}

		virtual public bool ExistPurchaseOrderItemObjectState
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.PurchaseOrderItemObjectState);
			}
		}

		virtual public void RemovePurchaseOrderItemObjectState()
		{
			Strategy.RemoveCompositeRole(Meta.PurchaseOrderItemObjectState);
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



		virtual public PurchaseOrderItem PurchaseOrderItemWhereOrderItemStatus
		{ 
			get
			{
				return (PurchaseOrderItem) Strategy.GetCompositeAssociation(Meta.PurchaseOrderItemWhereOrderItemStatus);
			}
		} 

		virtual public bool ExistPurchaseOrderItemWhereOrderItemStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.PurchaseOrderItemWhereOrderItemStatus);
			}
		}


		virtual public PurchaseOrderItem PurchaseOrderItemWhereShipmentStatus
		{ 
			get
			{
				return (PurchaseOrderItem) Strategy.GetCompositeAssociation(Meta.PurchaseOrderItemWhereShipmentStatus);
			}
		} 

		virtual public bool ExistPurchaseOrderItemWhereShipmentStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.PurchaseOrderItemWhereShipmentStatus);
			}
		}


		virtual public PurchaseOrderItem PurchaseOrderItemWherePaymentStatus
		{ 
			get
			{
				return (PurchaseOrderItem) Strategy.GetCompositeAssociation(Meta.PurchaseOrderItemWherePaymentStatus);
			}
		} 

		virtual public bool ExistPurchaseOrderItemWherePaymentStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.PurchaseOrderItemWherePaymentStatus);
			}
		}


		virtual public PurchaseOrderItem PurchaseOrderItemWhereCurrentShipmentStatus
		{ 
			get
			{
				return (PurchaseOrderItem) Strategy.GetCompositeAssociation(Meta.PurchaseOrderItemWhereCurrentShipmentStatus);
			}
		} 

		virtual public bool ExistPurchaseOrderItemWhereCurrentShipmentStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.PurchaseOrderItemWhereCurrentShipmentStatus);
			}
		}


		virtual public PurchaseOrderItem PurchaseOrderItemWhereCurrentOrderItemStatus
		{ 
			get
			{
				return (PurchaseOrderItem) Strategy.GetCompositeAssociation(Meta.PurchaseOrderItemWhereCurrentOrderItemStatus);
			}
		} 

		virtual public bool ExistPurchaseOrderItemWhereCurrentOrderItemStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.PurchaseOrderItemWhereCurrentOrderItemStatus);
			}
		}


		virtual public PurchaseOrderItem PurchaseOrderItemWhereCurrentPaymentStatus
		{ 
			get
			{
				return (PurchaseOrderItem) Strategy.GetCompositeAssociation(Meta.PurchaseOrderItemWhereCurrentPaymentStatus);
			}
		} 

		virtual public bool ExistPurchaseOrderItemWhereCurrentPaymentStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.PurchaseOrderItemWhereCurrentPaymentStatus);
			}
		}

	}

	public class PurchaseOrderItemStatusMeta
	{
		public static readonly PurchaseOrderItemStatusMeta Instance = new PurchaseOrderItemStatusMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.PurchaseOrderItemStatus;

		public global::Allors.Meta.RoleType StartDateTime 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PurchaseOrderItemStatusStartDateTime;
			}
		} 
		public global::Allors.Meta.RoleType PurchaseOrderItemObjectState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PurchaseOrderItemStatusPurchaseOrderItemObjectState;
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

		public global::Allors.Meta.AssociationType PurchaseOrderItemWhereOrderItemStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseOrderItemOrderItemStatus;
			}
		} 
		public global::Allors.Meta.AssociationType PurchaseOrderItemWhereShipmentStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseOrderItemShipmentStatus;
			}
		} 
		public global::Allors.Meta.AssociationType PurchaseOrderItemWherePaymentStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseOrderItemPaymentStatus;
			}
		} 
		public global::Allors.Meta.AssociationType PurchaseOrderItemWhereCurrentShipmentStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseOrderItemCurrentShipmentStatus;
			}
		} 
		public global::Allors.Meta.AssociationType PurchaseOrderItemWhereCurrentOrderItemStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseOrderItemCurrentOrderItemStatus;
			}
		} 
		public global::Allors.Meta.AssociationType PurchaseOrderItemWhereCurrentPaymentStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseOrderItemCurrentPaymentStatus;
			}
		} 

	}
}