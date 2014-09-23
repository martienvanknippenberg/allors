// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class SalesOrderItemStatus : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly SalesOrderItemStatusMeta Meta = SalesOrderItemStatusMeta.Instance;

		public SalesOrderItemStatus(Allors.IStrategy allors) : base(allors) {}

		public static SalesOrderItemStatus Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (SalesOrderItemStatus) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public SalesOrderItemObjectState SalesOrderItemObjectState
		{ 
			get
			{
				return (SalesOrderItemObjectState) Strategy.GetCompositeRole(Meta.SalesOrderItemObjectState);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.SalesOrderItemObjectState ,value);
			}
		}

		virtual public bool ExistSalesOrderItemObjectState
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.SalesOrderItemObjectState);
			}
		}

		virtual public void RemoveSalesOrderItemObjectState()
		{
			Strategy.RemoveCompositeRole(Meta.SalesOrderItemObjectState);
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



		virtual public global::Allors.Extent<SalesOrderItem> SalesOrderItemsWhereCurrentPaymentStatus
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesOrderItemsWhereCurrentPaymentStatus);
			}
		}

		virtual public bool ExistSalesOrderItemsWhereCurrentPaymentStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesOrderItemsWhereCurrentPaymentStatus);
			}
		}


		virtual public SalesOrderItem SalesOrderItemWhereOrderItemStatus
		{ 
			get
			{
				return (SalesOrderItem) Strategy.GetCompositeAssociation(Meta.SalesOrderItemWhereOrderItemStatus);
			}
		} 

		virtual public bool ExistSalesOrderItemWhereOrderItemStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.SalesOrderItemWhereOrderItemStatus);
			}
		}


		virtual public global::Allors.Extent<SalesOrderItem> SalesOrderItemsWhereCurrentShipmentStatus
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesOrderItemsWhereCurrentShipmentStatus);
			}
		}

		virtual public bool ExistSalesOrderItemsWhereCurrentShipmentStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesOrderItemsWhereCurrentShipmentStatus);
			}
		}


		virtual public SalesOrderItem SalesOrderItemWhereCurrentOrderItemStatus
		{ 
			get
			{
				return (SalesOrderItem) Strategy.GetCompositeAssociation(Meta.SalesOrderItemWhereCurrentOrderItemStatus);
			}
		} 

		virtual public bool ExistSalesOrderItemWhereCurrentOrderItemStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.SalesOrderItemWhereCurrentOrderItemStatus);
			}
		}


		virtual public SalesOrderItem SalesOrderItemWhereShipmentStatus
		{ 
			get
			{
				return (SalesOrderItem) Strategy.GetCompositeAssociation(Meta.SalesOrderItemWhereShipmentStatus);
			}
		} 

		virtual public bool ExistSalesOrderItemWhereShipmentStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.SalesOrderItemWhereShipmentStatus);
			}
		}


		virtual public SalesOrderItem SalesOrderItemWherePaymentStatus
		{ 
			get
			{
				return (SalesOrderItem) Strategy.GetCompositeAssociation(Meta.SalesOrderItemWherePaymentStatus);
			}
		} 

		virtual public bool ExistSalesOrderItemWherePaymentStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.SalesOrderItemWherePaymentStatus);
			}
		}

	}

	public class SalesOrderItemStatusMeta
	{
		public static readonly SalesOrderItemStatusMeta Instance = new SalesOrderItemStatusMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.SalesOrderItemStatus;

		public global::Allors.Meta.RoleType SalesOrderItemObjectState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SalesOrderItemStatusSalesOrderItemObjectState;
			}
		} 
		public global::Allors.Meta.RoleType StartDateTime 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SalesOrderItemStatusStartDateTime;
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

		public global::Allors.Meta.AssociationType SalesOrderItemsWhereCurrentPaymentStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesOrderItemCurrentPaymentStatus;
			}
		} 
		public global::Allors.Meta.AssociationType SalesOrderItemWhereOrderItemStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesOrderItemOrderItemStatus;
			}
		} 
		public global::Allors.Meta.AssociationType SalesOrderItemsWhereCurrentShipmentStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesOrderItemCurrentShipmentStatus;
			}
		} 
		public global::Allors.Meta.AssociationType SalesOrderItemWhereCurrentOrderItemStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesOrderItemCurrentOrderItemStatus;
			}
		} 
		public global::Allors.Meta.AssociationType SalesOrderItemWhereShipmentStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesOrderItemShipmentStatus;
			}
		} 
		public global::Allors.Meta.AssociationType SalesOrderItemWherePaymentStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesOrderItemPaymentStatus;
			}
		} 

	}
}