// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface Part :  UserInterfaceable,Searchable,UniquelyIdentifiable,SearchResult, Allors.IObjectBase
	{


		InternalOrganisation OwnedByParty
		{ 
			get;
			set;
		}

		bool ExistOwnedByParty
		{
			get;
		}

		void RemoveOwnedByParty();


		global::System.String Name 
		{
			get;
			set;
		}

		bool ExistName{get;}

		void RemoveName();


		global::Allors.Extent<PartSpecification> PartSpecifications
		{ 
			get;
			set;
		}

		void AddPartSpecification (PartSpecification value);

		void RemovePartSpecification (PartSpecification value);

		bool ExistPartSpecifications
		{
			get;
		}

		void RemovePartSpecifications();


		UnitOfMeasure UnitOfMeasure
		{ 
			get;
			set;
		}

		bool ExistUnitOfMeasure
		{
			get;
		}

		void RemoveUnitOfMeasure();


		global::Allors.Extent<Document> Documents
		{ 
			get;
			set;
		}

		void AddDocument (Document value);

		void RemoveDocument (Document value);

		bool ExistDocuments
		{
			get;
		}

		void RemoveDocuments();


		global::System.String ManufacturerId 
		{
			get;
			set;
		}

		bool ExistManufacturerId{get;}

		void RemoveManufacturerId();


		global::System.Int32 ReorderLevel 
		{
			get;
			set;
		}

		bool ExistReorderLevel{get;}

		void RemoveReorderLevel();


		global::System.Int32 ReorderQuantity 
		{
			get;
			set;
		}

		bool ExistReorderQuantity{get;}

		void RemoveReorderQuantity();


		global::Allors.Extent<PriceComponent> PriceComponents
		{ 
			get;
			set;
		}

		void AddPriceComponent (PriceComponent value);

		void RemovePriceComponent (PriceComponent value);

		bool ExistPriceComponents
		{
			get;
		}

		void RemovePriceComponents();


		InventoryItemKind InventoryItemKind
		{ 
			get;
			set;
		}

		bool ExistInventoryItemKind
		{
			get;
		}

		void RemoveInventoryItemKind();



		global::Allors.Extent<SupplierOffering> SupplierOfferingsWherePart
		{ 
			get;
		}

		bool ExistSupplierOfferingsWherePart
		{
			get;
		}


		global::Allors.Extent<PurchaseInvoiceItem> PurchaseInvoiceItemsWherePart
		{ 
			get;
		}

		bool ExistPurchaseInvoiceItemsWherePart
		{
			get;
		}


		global::Allors.Extent<PartRevision> PartRevisionsWhereSupersededByPart
		{ 
			get;
		}

		bool ExistPartRevisionsWhereSupersededByPart
		{
			get;
		}


		global::Allors.Extent<PartRevision> PartRevisionsWherePart
		{ 
			get;
		}

		bool ExistPartRevisionsWherePart
		{
			get;
		}


		global::Allors.Extent<InventoryItem> InventoryItemsWherePart
		{ 
			get;
		}

		bool ExistInventoryItemsWherePart
		{
			get;
		}


		global::Allors.Extent<WorkEffortPartStandard> WorkEffortPartStandardsWherePart
		{ 
			get;
		}

		bool ExistWorkEffortPartStandardsWherePart
		{
			get;
		}


		global::Allors.Extent<PurchaseOrderItem> PurchaseOrderItemsWherePart
		{ 
			get;
		}

		bool ExistPurchaseOrderItemsWherePart
		{
			get;
		}


		global::Allors.Extent<PartSubstitute> PartSubstitutesWhereSubstitutionPart
		{ 
			get;
		}

		bool ExistPartSubstitutesWhereSubstitutionPart
		{
			get;
		}


		global::Allors.Extent<PartSubstitute> PartSubstitutesWherePart
		{ 
			get;
		}

		bool ExistPartSubstitutesWherePart
		{
			get;
		}


		global::Allors.Extent<PartBillOfMaterial> PartBillOfMaterialsWherePart
		{ 
			get;
		}

		bool ExistPartBillOfMaterialsWherePart
		{
			get;
		}


		global::Allors.Extent<PartBillOfMaterial> PartBillOfMaterialsWhereComponentPart
		{ 
			get;
		}

		bool ExistPartBillOfMaterialsWhereComponentPart
		{
			get;
		}


		global::Allors.Extent<ShipmentItem> ShipmentItemsWherePart
		{ 
			get;
		}

		bool ExistShipmentItemsWherePart
		{
			get;
		}

	}

	public class PartMeta
	{
		public static readonly PartMeta Instance = new PartMeta();

		public global::Allors.Meta.Interface ObjectType = global::Allors.Meta.Interfaces.Part;

		public global::Allors.Meta.RoleType OwnedByParty 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartOwnedByParty;
			}
		} 
		public global::Allors.Meta.RoleType Name 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartName;
			}
		} 
		public global::Allors.Meta.RoleType PartSpecification 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartPartSpecification;
			}
		} 
		public global::Allors.Meta.RoleType UnitOfMeasure 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartUnitOfMeasure;
			}
		} 
		public global::Allors.Meta.RoleType Document 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartDocument;
			}
		} 
		public global::Allors.Meta.RoleType ManufacturerId 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartManufacturerId;
			}
		} 
		public global::Allors.Meta.RoleType ReorderLevel 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartReorderLevel;
			}
		} 
		public global::Allors.Meta.RoleType ReorderQuantity 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartReorderQuantity;
			}
		} 
		public global::Allors.Meta.RoleType PriceComponent 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartPriceComponent;
			}
		} 
		public global::Allors.Meta.RoleType InventoryItemKind 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartInventoryItemKind;
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

		public global::Allors.Meta.AssociationType SupplierOfferingsWherePart 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SupplierOfferingPart;
			}
		} 
		public global::Allors.Meta.AssociationType PurchaseInvoiceItemsWherePart 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseInvoiceItemPart;
			}
		} 
		public global::Allors.Meta.AssociationType PartRevisionsWhereSupersededByPart 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartRevisionSupersededByPart;
			}
		} 
		public global::Allors.Meta.AssociationType PartRevisionsWherePart 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartRevisionPart;
			}
		} 
		public global::Allors.Meta.AssociationType InventoryItemsWherePart 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InventoryItemPart;
			}
		} 
		public global::Allors.Meta.AssociationType WorkEffortPartStandardsWherePart 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.WorkEffortPartStandardPart;
			}
		} 
		public global::Allors.Meta.AssociationType PurchaseOrderItemsWherePart 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseOrderItemPart;
			}
		} 
		public global::Allors.Meta.AssociationType PartSubstitutesWhereSubstitutionPart 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartSubstituteSubstitutionPart;
			}
		} 
		public global::Allors.Meta.AssociationType PartSubstitutesWherePart 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartSubstitutePart;
			}
		} 
		public global::Allors.Meta.AssociationType PartBillOfMaterialsWherePart 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartBillOfMaterialPart;
			}
		} 
		public global::Allors.Meta.AssociationType PartBillOfMaterialsWhereComponentPart 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartBillOfMaterialComponentPart;
			}
		} 
		public global::Allors.Meta.AssociationType ShipmentItemsWherePart 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ShipmentItemPart;
			}
		} 

	}
}