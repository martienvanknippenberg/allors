// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class SubAssembly : Allors.ObjectBase , Part
	{
		public static readonly SubAssemblyMeta Meta = SubAssemblyMeta.Instance;

		public SubAssembly(Allors.IStrategy allors) : base(allors) {}

		public static SubAssembly Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (SubAssembly) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public InternalOrganisation OwnedByParty
		{ 
			get
			{
				return (InternalOrganisation) Strategy.GetCompositeRole(Meta.OwnedByParty);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.OwnedByParty ,value);
			}
		}

		virtual public bool ExistOwnedByParty
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.OwnedByParty);
			}
		}

		virtual public void RemoveOwnedByParty()
		{
			Strategy.RemoveCompositeRole(Meta.OwnedByParty);
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


		virtual public global::Allors.Extent<PartSpecification> PartSpecifications
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.PartSpecification);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.PartSpecification, value);
			}
		}

		virtual public void AddPartSpecification (PartSpecification value)
		{
			Strategy.AddCompositeRole(Meta.PartSpecification, value);
		}

		virtual public void RemovePartSpecification (PartSpecification value)
		{
			Strategy.RemoveCompositeRole(Meta.PartSpecification,value);
		}

		virtual public bool ExistPartSpecifications
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.PartSpecification);
			}
		}

		virtual public void RemovePartSpecifications()
		{
			Strategy.RemoveCompositeRoles(Meta.PartSpecification);
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


		virtual public global::Allors.Extent<Document> Documents
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.Document);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.Document, value);
			}
		}

		virtual public void AddDocument (Document value)
		{
			Strategy.AddCompositeRole(Meta.Document, value);
		}

		virtual public void RemoveDocument (Document value)
		{
			Strategy.RemoveCompositeRole(Meta.Document,value);
		}

		virtual public bool ExistDocuments
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.Document);
			}
		}

		virtual public void RemoveDocuments()
		{
			Strategy.RemoveCompositeRoles(Meta.Document);
		}



		virtual public global::System.String ManufacturerId 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.ManufacturerId);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ManufacturerId, value);
			}
		}

		virtual public bool ExistManufacturerId{
			get
			{
				return Strategy.ExistUnitRole(Meta.ManufacturerId);
			}
		}

		virtual public void RemoveManufacturerId()
		{
			Strategy.RemoveUnitRole(Meta.ManufacturerId);
		}



		virtual public global::System.Int32 ReorderLevel 
		{
			get
			{
				return (global::System.Int32) Strategy.GetUnitRole(Meta.ReorderLevel);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ReorderLevel, value);
			}
		}

		virtual public bool ExistReorderLevel{
			get
			{
				return Strategy.ExistUnitRole(Meta.ReorderLevel);
			}
		}

		virtual public void RemoveReorderLevel()
		{
			Strategy.RemoveUnitRole(Meta.ReorderLevel);
		}



		virtual public global::System.Int32 ReorderQuantity 
		{
			get
			{
				return (global::System.Int32) Strategy.GetUnitRole(Meta.ReorderQuantity);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ReorderQuantity, value);
			}
		}

		virtual public bool ExistReorderQuantity{
			get
			{
				return Strategy.ExistUnitRole(Meta.ReorderQuantity);
			}
		}

		virtual public void RemoveReorderQuantity()
		{
			Strategy.RemoveUnitRole(Meta.ReorderQuantity);
		}


		virtual public global::Allors.Extent<PriceComponent> PriceComponents
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.PriceComponent);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.PriceComponent, value);
			}
		}

		virtual public void AddPriceComponent (PriceComponent value)
		{
			Strategy.AddCompositeRole(Meta.PriceComponent, value);
		}

		virtual public void RemovePriceComponent (PriceComponent value)
		{
			Strategy.RemoveCompositeRole(Meta.PriceComponent,value);
		}

		virtual public bool ExistPriceComponents
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.PriceComponent);
			}
		}

		virtual public void RemovePriceComponents()
		{
			Strategy.RemoveCompositeRoles(Meta.PriceComponent);
		}


		virtual public InventoryItemKind InventoryItemKind
		{ 
			get
			{
				return (InventoryItemKind) Strategy.GetCompositeRole(Meta.InventoryItemKind);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.InventoryItemKind ,value);
			}
		}

		virtual public bool ExistInventoryItemKind
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.InventoryItemKind);
			}
		}

		virtual public void RemoveInventoryItemKind()
		{
			Strategy.RemoveCompositeRole(Meta.InventoryItemKind);
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



		virtual public global::Allors.Extent<SupplierOffering> SupplierOfferingsWherePart
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SupplierOfferingsWherePart);
			}
		}

		virtual public bool ExistSupplierOfferingsWherePart
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SupplierOfferingsWherePart);
			}
		}


		virtual public global::Allors.Extent<PurchaseInvoiceItem> PurchaseInvoiceItemsWherePart
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PurchaseInvoiceItemsWherePart);
			}
		}

		virtual public bool ExistPurchaseInvoiceItemsWherePart
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PurchaseInvoiceItemsWherePart);
			}
		}


		virtual public global::Allors.Extent<PartRevision> PartRevisionsWhereSupersededByPart
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartRevisionsWhereSupersededByPart);
			}
		}

		virtual public bool ExistPartRevisionsWhereSupersededByPart
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartRevisionsWhereSupersededByPart);
			}
		}


		virtual public global::Allors.Extent<PartRevision> PartRevisionsWherePart
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartRevisionsWherePart);
			}
		}

		virtual public bool ExistPartRevisionsWherePart
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartRevisionsWherePart);
			}
		}


		virtual public global::Allors.Extent<InventoryItem> InventoryItemsWherePart
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.InventoryItemsWherePart);
			}
		}

		virtual public bool ExistInventoryItemsWherePart
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.InventoryItemsWherePart);
			}
		}


		virtual public global::Allors.Extent<WorkEffortPartStandard> WorkEffortPartStandardsWherePart
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.WorkEffortPartStandardsWherePart);
			}
		}

		virtual public bool ExistWorkEffortPartStandardsWherePart
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.WorkEffortPartStandardsWherePart);
			}
		}


		virtual public global::Allors.Extent<PurchaseOrderItem> PurchaseOrderItemsWherePart
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PurchaseOrderItemsWherePart);
			}
		}

		virtual public bool ExistPurchaseOrderItemsWherePart
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PurchaseOrderItemsWherePart);
			}
		}


		virtual public global::Allors.Extent<PartSubstitute> PartSubstitutesWhereSubstitutionPart
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartSubstitutesWhereSubstitutionPart);
			}
		}

		virtual public bool ExistPartSubstitutesWhereSubstitutionPart
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartSubstitutesWhereSubstitutionPart);
			}
		}


		virtual public global::Allors.Extent<PartSubstitute> PartSubstitutesWherePart
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartSubstitutesWherePart);
			}
		}

		virtual public bool ExistPartSubstitutesWherePart
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartSubstitutesWherePart);
			}
		}


		virtual public global::Allors.Extent<PartBillOfMaterial> PartBillOfMaterialsWherePart
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartBillOfMaterialsWherePart);
			}
		}

		virtual public bool ExistPartBillOfMaterialsWherePart
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartBillOfMaterialsWherePart);
			}
		}


		virtual public global::Allors.Extent<PartBillOfMaterial> PartBillOfMaterialsWhereComponentPart
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartBillOfMaterialsWhereComponentPart);
			}
		}

		virtual public bool ExistPartBillOfMaterialsWhereComponentPart
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartBillOfMaterialsWhereComponentPart);
			}
		}


		virtual public global::Allors.Extent<ShipmentItem> ShipmentItemsWherePart
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ShipmentItemsWherePart);
			}
		}

		virtual public bool ExistShipmentItemsWherePart
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ShipmentItemsWherePart);
			}
		}

	}

	public class SubAssemblyMeta
	{
		public static readonly SubAssemblyMeta Instance = new SubAssemblyMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.SubAssembly;

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