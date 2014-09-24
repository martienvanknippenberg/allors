// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class ItemIssuance : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly ItemIssuanceMeta Meta = ItemIssuanceMeta.Instance;

		public ItemIssuance(Allors.IStrategy allors) : base(allors) {}

		public static ItemIssuance Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (ItemIssuance) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.DateTime IssuanceDateTime 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.IssuanceDateTime);
			}
			set
			{
				Strategy.SetUnitRole(Meta.IssuanceDateTime, value);
			}
		}

		virtual public bool ExistIssuanceDateTime{
			get
			{
				return Strategy.ExistUnitRole(Meta.IssuanceDateTime);
			}
		}

		virtual public void RemoveIssuanceDateTime()
		{
			Strategy.RemoveUnitRole(Meta.IssuanceDateTime);
		}


		virtual public InventoryItem InventoryItem
		{ 
			get
			{
				return (InventoryItem) Strategy.GetCompositeRole(Meta.InventoryItem);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.InventoryItem ,value);
			}
		}

		virtual public bool ExistInventoryItem
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.InventoryItem);
			}
		}

		virtual public void RemoveInventoryItem()
		{
			Strategy.RemoveCompositeRole(Meta.InventoryItem);
		}



		virtual public global::System.Decimal Quantity 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.Quantity);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Quantity, value);
			}
		}

		virtual public bool ExistQuantity{
			get
			{
				return Strategy.ExistUnitRole(Meta.Quantity);
			}
		}

		virtual public void RemoveQuantity()
		{
			Strategy.RemoveUnitRole(Meta.Quantity);
		}


		virtual public ShipmentItem ShipmentItem
		{ 
			get
			{
				return (ShipmentItem) Strategy.GetCompositeRole(Meta.ShipmentItem);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.ShipmentItem ,value);
			}
		}

		virtual public bool ExistShipmentItem
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.ShipmentItem);
			}
		}

		virtual public void RemoveShipmentItem()
		{
			Strategy.RemoveCompositeRole(Meta.ShipmentItem);
		}


		virtual public PickListItem PickListItem
		{ 
			get
			{
				return (PickListItem) Strategy.GetCompositeRole(Meta.PickListItem);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.PickListItem ,value);
			}
		}

		virtual public bool ExistPickListItem
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.PickListItem);
			}
		}

		virtual public void RemovePickListItem()
		{
			Strategy.RemoveCompositeRole(Meta.PickListItem);
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

	}

	public class ItemIssuanceMeta
	{
		public static readonly ItemIssuanceMeta Instance = new ItemIssuanceMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.ItemIssuance;

		public global::Allors.Meta.RoleType IssuanceDateTime 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ItemIssuanceIssuanceDateTime;
			}
		} 
		public global::Allors.Meta.RoleType InventoryItem 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ItemIssuanceInventoryItem;
			}
		} 
		public global::Allors.Meta.RoleType Quantity 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ItemIssuanceQuantity;
			}
		} 
		public global::Allors.Meta.RoleType ShipmentItem 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ItemIssuanceShipmentItem;
			}
		} 
		public global::Allors.Meta.RoleType PickListItem 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ItemIssuancePickListItem;
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

	}
}