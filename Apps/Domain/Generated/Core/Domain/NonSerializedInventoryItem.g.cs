// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class NonSerializedInventoryItem : Allors.ObjectBase , InventoryItem
	{
		public static readonly NonSerializedInventoryItemMeta Meta = NonSerializedInventoryItemMeta.Instance;

		public NonSerializedInventoryItem(Allors.IStrategy allors) : base(allors) {}

		public static NonSerializedInventoryItem Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (NonSerializedInventoryItem) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public NonSerializedInventoryItemObjectState CurrentObjectState
		{ 
			get
			{
				return (NonSerializedInventoryItemObjectState) Strategy.GetCompositeRole(Meta.CurrentObjectState);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.CurrentObjectState ,value);
			}
		}

		virtual public bool ExistCurrentObjectState
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.CurrentObjectState);
			}
		}

		virtual public void RemoveCurrentObjectState()
		{
			Strategy.RemoveCompositeRole(Meta.CurrentObjectState);
		}



		virtual public global::System.Decimal QuantityCommittedOut 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.QuantityCommittedOut);
			}
			set
			{
				Strategy.SetUnitRole(Meta.QuantityCommittedOut, value);
			}
		}

		virtual public bool ExistQuantityCommittedOut{
			get
			{
				return Strategy.ExistUnitRole(Meta.QuantityCommittedOut);
			}
		}

		virtual public void RemoveQuantityCommittedOut()
		{
			Strategy.RemoveUnitRole(Meta.QuantityCommittedOut);
		}


		virtual public global::Allors.Extent<NonSerializedInventoryItemStatus> NonSerializedInventoryItemStatuses
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.NonSerializedInventoryItemStatus);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.NonSerializedInventoryItemStatus, value);
			}
		}

		virtual public void AddNonSerializedInventoryItemStatus (NonSerializedInventoryItemStatus value)
		{
			Strategy.AddCompositeRole(Meta.NonSerializedInventoryItemStatus, value);
		}

		virtual public void RemoveNonSerializedInventoryItemStatus (NonSerializedInventoryItemStatus value)
		{
			Strategy.RemoveCompositeRole(Meta.NonSerializedInventoryItemStatus,value);
		}

		virtual public bool ExistNonSerializedInventoryItemStatuses
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.NonSerializedInventoryItemStatus);
			}
		}

		virtual public void RemoveNonSerializedInventoryItemStatuses()
		{
			Strategy.RemoveCompositeRoles(Meta.NonSerializedInventoryItemStatus);
		}


		virtual public NonSerializedInventoryItemObjectState PreviousObjectState
		{ 
			get
			{
				return (NonSerializedInventoryItemObjectState) Strategy.GetCompositeRole(Meta.PreviousObjectState);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.PreviousObjectState ,value);
			}
		}

		virtual public bool ExistPreviousObjectState
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.PreviousObjectState);
			}
		}

		virtual public void RemovePreviousObjectState()
		{
			Strategy.RemoveCompositeRole(Meta.PreviousObjectState);
		}


		virtual public NonSerializedInventoryItemStatus CurrentInventoryItemStatus
		{ 
			get
			{
				return (NonSerializedInventoryItemStatus) Strategy.GetCompositeRole(Meta.CurrentInventoryItemStatus);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.CurrentInventoryItemStatus ,value);
			}
		}

		virtual public bool ExistCurrentInventoryItemStatus
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.CurrentInventoryItemStatus);
			}
		}

		virtual public void RemoveCurrentInventoryItemStatus()
		{
			Strategy.RemoveCompositeRole(Meta.CurrentInventoryItemStatus);
		}



		virtual public global::System.Decimal QuantityOnHand 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.QuantityOnHand);
			}
			set
			{
				Strategy.SetUnitRole(Meta.QuantityOnHand, value);
			}
		}

		virtual public bool ExistQuantityOnHand{
			get
			{
				return Strategy.ExistUnitRole(Meta.QuantityOnHand);
			}
		}

		virtual public void RemoveQuantityOnHand()
		{
			Strategy.RemoveUnitRole(Meta.QuantityOnHand);
		}



		virtual public global::System.Decimal PreviousQuantityOnHand 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.PreviousQuantityOnHand);
			}
			set
			{
				Strategy.SetUnitRole(Meta.PreviousQuantityOnHand, value);
			}
		}

		virtual public bool ExistPreviousQuantityOnHand{
			get
			{
				return Strategy.ExistUnitRole(Meta.PreviousQuantityOnHand);
			}
		}

		virtual public void RemovePreviousQuantityOnHand()
		{
			Strategy.RemoveUnitRole(Meta.PreviousQuantityOnHand);
		}



		virtual public global::System.Decimal AvailableToPromise 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.AvailableToPromise);
			}
			set
			{
				Strategy.SetUnitRole(Meta.AvailableToPromise, value);
			}
		}

		virtual public bool ExistAvailableToPromise{
			get
			{
				return Strategy.ExistUnitRole(Meta.AvailableToPromise);
			}
		}

		virtual public void RemoveAvailableToPromise()
		{
			Strategy.RemoveUnitRole(Meta.AvailableToPromise);
		}



		virtual public global::System.Decimal QuantityExpectedIn 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.QuantityExpectedIn);
			}
			set
			{
				Strategy.SetUnitRole(Meta.QuantityExpectedIn, value);
			}
		}

		virtual public bool ExistQuantityExpectedIn{
			get
			{
				return Strategy.ExistUnitRole(Meta.QuantityExpectedIn);
			}
		}

		virtual public void RemoveQuantityExpectedIn()
		{
			Strategy.RemoveUnitRole(Meta.QuantityExpectedIn);
		}


		virtual public global::Allors.Extent<InventoryItemVariance> InventoryItemVariances
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.InventoryItemVariance);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.InventoryItemVariance, value);
			}
		}

		virtual public void AddInventoryItemVariance (InventoryItemVariance value)
		{
			Strategy.AddCompositeRole(Meta.InventoryItemVariance, value);
		}

		virtual public void RemoveInventoryItemVariance (InventoryItemVariance value)
		{
			Strategy.RemoveCompositeRole(Meta.InventoryItemVariance,value);
		}

		virtual public bool ExistInventoryItemVariances
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.InventoryItemVariance);
			}
		}

		virtual public void RemoveInventoryItemVariances()
		{
			Strategy.RemoveCompositeRoles(Meta.InventoryItemVariance);
		}


		virtual public Part Part
		{ 
			get
			{
				return (Part) Strategy.GetCompositeRole(Meta.Part);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Part ,value);
			}
		}

		virtual public bool ExistPart
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Part);
			}
		}

		virtual public void RemovePart()
		{
			Strategy.RemoveCompositeRole(Meta.Part);
		}


		virtual public Container Container
		{ 
			get
			{
				return (Container) Strategy.GetCompositeRole(Meta.Container);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Container ,value);
			}
		}

		virtual public bool ExistContainer
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Container);
			}
		}

		virtual public void RemoveContainer()
		{
			Strategy.RemoveCompositeRole(Meta.Container);
		}



		virtual public global::System.String Name 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Name);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Name, value);
			}
		}

		virtual public bool ExistName{
			get
			{
				return Strategy.ExistUnitRole(Meta.Name);
			}
		}

		virtual public void RemoveName()
		{
			Strategy.RemoveUnitRole(Meta.Name);
		}


		virtual public Lot Lot
		{ 
			get
			{
				return (Lot) Strategy.GetCompositeRole(Meta.Lot);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Lot ,value);
			}
		}

		virtual public bool ExistLot
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Lot);
			}
		}

		virtual public void RemoveLot()
		{
			Strategy.RemoveCompositeRole(Meta.Lot);
		}



		virtual public global::System.String Sku 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Sku);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Sku, value);
			}
		}

		virtual public bool ExistSku{
			get
			{
				return Strategy.ExistUnitRole(Meta.Sku);
			}
		}

		virtual public void RemoveSku()
		{
			Strategy.RemoveUnitRole(Meta.Sku);
		}


		virtual public UnitOfMeasure UnitOfMeasure
		{ 
			get
			{
				return (UnitOfMeasure) Strategy.GetCompositeRole(Meta.UnitOfMeasure);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.UnitOfMeasure ,value);
			}
		}

		virtual public bool ExistUnitOfMeasure
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.UnitOfMeasure);
			}
		}

		virtual public void RemoveUnitOfMeasure()
		{
			Strategy.RemoveCompositeRole(Meta.UnitOfMeasure);
		}


		virtual public global::Allors.Extent<ProductCategory> DerivedProductCategories
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.DerivedProductCategory);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.DerivedProductCategory, value);
			}
		}

		virtual public void AddDerivedProductCategory (ProductCategory value)
		{
			Strategy.AddCompositeRole(Meta.DerivedProductCategory, value);
		}

		virtual public void RemoveDerivedProductCategory (ProductCategory value)
		{
			Strategy.RemoveCompositeRole(Meta.DerivedProductCategory,value);
		}

		virtual public bool ExistDerivedProductCategories
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.DerivedProductCategory);
			}
		}

		virtual public void RemoveDerivedProductCategories()
		{
			Strategy.RemoveCompositeRoles(Meta.DerivedProductCategory);
		}


		virtual public Good Good
		{ 
			get
			{
				return (Good) Strategy.GetCompositeRole(Meta.Good);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Good ,value);
			}
		}

		virtual public bool ExistGood
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Good);
			}
		}

		virtual public void RemoveGood()
		{
			Strategy.RemoveCompositeRole(Meta.Good);
		}


		virtual public Facility Facility
		{ 
			get
			{
				return (Facility) Strategy.GetCompositeRole(Meta.Facility);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Facility ,value);
			}
		}

		virtual public bool ExistFacility
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Facility);
			}
		}

		virtual public void RemoveFacility()
		{
			Strategy.RemoveCompositeRole(Meta.Facility);
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


		virtual public SearchData SearchData
		{ 
			get
			{
				return (SearchData) Strategy.GetCompositeRole(Meta.SearchData);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.SearchData ,value);
			}
		}

		virtual public bool ExistSearchData
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.SearchData);
			}
		}

		virtual public void RemoveSearchData()
		{
			Strategy.RemoveCompositeRole(Meta.SearchData);
		}



		virtual public global::System.Guid UniqueId 
		{
			get
			{
				return (global::System.Guid) Strategy.GetUnitRole(Meta.UniqueId);
			}
			set
			{
				Strategy.SetUnitRole(Meta.UniqueId, value);
			}
		}

		virtual public bool ExistUniqueId{
			get
			{
				return Strategy.ExistUnitRole(Meta.UniqueId);
			}
		}

		virtual public void RemoveUniqueId()
		{
			Strategy.RemoveUnitRole(Meta.UniqueId);
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



		virtual public global::Allors.Extent<ShipmentReceipt> ShipmentReceiptsWhereInventoryItem
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ShipmentReceiptsWhereInventoryItem);
			}
		}

		virtual public bool ExistShipmentReceiptsWhereInventoryItem
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ShipmentReceiptsWhereInventoryItem);
			}
		}


		virtual public global::Allors.Extent<SalesOrderItem> SalesOrderItemsWherePreviousReservedFromInventoryItem
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesOrderItemsWherePreviousReservedFromInventoryItem);
			}
		}

		virtual public bool ExistSalesOrderItemsWherePreviousReservedFromInventoryItem
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesOrderItemsWherePreviousReservedFromInventoryItem);
			}
		}


		virtual public global::Allors.Extent<SalesOrderItem> SalesOrderItemsWhereReservedFromInventoryItem
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesOrderItemsWhereReservedFromInventoryItem);
			}
		}

		virtual public bool ExistSalesOrderItemsWhereReservedFromInventoryItem
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesOrderItemsWhereReservedFromInventoryItem);
			}
		}


		virtual public global::Allors.Extent<ItemIssuance> ItemIssuancesWhereInventoryItem
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ItemIssuancesWhereInventoryItem);
			}
		}

		virtual public bool ExistItemIssuancesWhereInventoryItem
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ItemIssuancesWhereInventoryItem);
			}
		}


		virtual public global::Allors.Extent<WorkEffort> WorkEffortsWhereInventoryItemProduced
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.WorkEffortsWhereInventoryItemProduced);
			}
		}

		virtual public bool ExistWorkEffortsWhereInventoryItemProduced
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.WorkEffortsWhereInventoryItemProduced);
			}
		}


		virtual public global::Allors.Extent<PickListItem> PickListItemsWhereInventoryItem
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PickListItemsWhereInventoryItem);
			}
		}

		virtual public bool ExistPickListItemsWhereInventoryItem
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PickListItemsWhereInventoryItem);
			}
		}


		virtual public global::Allors.Extent<ShipmentItem> ShipmentItemsWhereInventoryItem
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ShipmentItemsWhereInventoryItem);
			}
		}

		virtual public bool ExistShipmentItemsWhereInventoryItem
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ShipmentItemsWhereInventoryItem);
			}
		}


		virtual public global::Allors.Extent<InventoryItemConfiguration> InventoryItemConfigurationsWhereInventoryItem
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.InventoryItemConfigurationsWhereInventoryItem);
			}
		}

		virtual public bool ExistInventoryItemConfigurationsWhereInventoryItem
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.InventoryItemConfigurationsWhereInventoryItem);
			}
		}


		virtual public global::Allors.Extent<InventoryItemConfiguration> InventoryItemConfigurationsWhereComponentInventoryItem
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.InventoryItemConfigurationsWhereComponentInventoryItem);
			}
		}

		virtual public bool ExistInventoryItemConfigurationsWhereComponentInventoryItem
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.InventoryItemConfigurationsWhereComponentInventoryItem);
			}
		}


		virtual public global::Allors.Extent<WorkEffortInventoryAssignment> WorkEffortInventoryAssignmentsWhereInventoryItem
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.WorkEffortInventoryAssignmentsWhereInventoryItem);
			}
		}

		virtual public bool ExistWorkEffortInventoryAssignmentsWhereInventoryItem
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.WorkEffortInventoryAssignmentsWhereInventoryItem);
			}
		}

	}

	public class NonSerializedInventoryItemMeta
	{
		public static readonly NonSerializedInventoryItemMeta Instance = new NonSerializedInventoryItemMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.NonSerializedInventoryItem;

		public global::Allors.Meta.RoleType CurrentObjectState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.NonSerializedInventoryItemCurrentObjectState;
			}
		} 
		public global::Allors.Meta.RoleType QuantityCommittedOut 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.NonSerializedInventoryItemQuantityCommittedOut;
			}
		} 
		public global::Allors.Meta.RoleType NonSerializedInventoryItemStatus 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.NonSerializedInventoryItemNonSerializedInventoryItemStatus;
			}
		} 
		public global::Allors.Meta.RoleType PreviousObjectState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.NonSerializedInventoryItemPreviousObjectState;
			}
		} 
		public global::Allors.Meta.RoleType CurrentInventoryItemStatus 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.NonSerializedInventoryItemCurrentInventoryItemStatus;
			}
		} 
		public global::Allors.Meta.RoleType QuantityOnHand 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.NonSerializedInventoryItemQuantityOnHand;
			}
		} 
		public global::Allors.Meta.RoleType PreviousQuantityOnHand 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.NonSerializedInventoryItemPreviousQuantityOnHand;
			}
		} 
		public global::Allors.Meta.RoleType AvailableToPromise 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.NonSerializedInventoryItemAvailableToPromise;
			}
		} 
		public global::Allors.Meta.RoleType QuantityExpectedIn 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.NonSerializedInventoryItemQuantityExpectedIn;
			}
		} 
		public global::Allors.Meta.RoleType InventoryItemVariance 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InventoryItemInventoryItemVariance;
			}
		} 
		public global::Allors.Meta.RoleType Part 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InventoryItemPart;
			}
		} 
		public global::Allors.Meta.RoleType Container 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InventoryItemContainer;
			}
		} 
		public global::Allors.Meta.RoleType Name 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InventoryItemName;
			}
		} 
		public global::Allors.Meta.RoleType Lot 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InventoryItemLot;
			}
		} 
		public global::Allors.Meta.RoleType Sku 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InventoryItemSku;
			}
		} 
		public global::Allors.Meta.RoleType UnitOfMeasure 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InventoryItemUnitOfMeasure;
			}
		} 
		public global::Allors.Meta.RoleType DerivedProductCategory 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InventoryItemDerivedProductCategory;
			}
		} 
		public global::Allors.Meta.RoleType Good 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InventoryItemGood;
			}
		} 
		public global::Allors.Meta.RoleType Facility 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InventoryItemFacility;
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
		public global::Allors.Meta.RoleType SearchData 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SearchableSearchData;
			}
		} 
		public global::Allors.Meta.RoleType UniqueId 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UniquelyIdentifiableUniqueId;
			}
		} 
		public global::Allors.Meta.RoleType DisplayName 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UserInterfaceableDisplayName;
			}
		} 

		public global::Allors.Meta.AssociationType ShipmentReceiptsWhereInventoryItem 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ShipmentReceiptInventoryItem;
			}
		} 
		public global::Allors.Meta.AssociationType SalesOrderItemsWherePreviousReservedFromInventoryItem 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesOrderItemPreviousReservedFromInventoryItem;
			}
		} 
		public global::Allors.Meta.AssociationType SalesOrderItemsWhereReservedFromInventoryItem 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesOrderItemReservedFromInventoryItem;
			}
		} 
		public global::Allors.Meta.AssociationType ItemIssuancesWhereInventoryItem 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ItemIssuanceInventoryItem;
			}
		} 
		public global::Allors.Meta.AssociationType WorkEffortsWhereInventoryItemProduced 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.WorkEffortInventoryItemProduced;
			}
		} 
		public global::Allors.Meta.AssociationType PickListItemsWhereInventoryItem 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PickListItemInventoryItem;
			}
		} 
		public global::Allors.Meta.AssociationType ShipmentItemsWhereInventoryItem 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ShipmentItemInventoryItem;
			}
		} 
		public global::Allors.Meta.AssociationType InventoryItemConfigurationsWhereInventoryItem 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InventoryItemConfigurationInventoryItem;
			}
		} 
		public global::Allors.Meta.AssociationType InventoryItemConfigurationsWhereComponentInventoryItem 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InventoryItemConfigurationComponentInventoryItem;
			}
		} 
		public global::Allors.Meta.AssociationType WorkEffortInventoryAssignmentsWhereInventoryItem 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.WorkEffortInventoryAssignmentInventoryItem;
			}
		} 

	}
}