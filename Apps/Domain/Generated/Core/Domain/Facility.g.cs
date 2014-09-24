// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface Facility :  UserInterfaceable,SearchResult,GeoLocatable,Searchable, Allors.IObject
	{


		Facility MadeUpOf
		{ 
			get;
			set;
		}

		bool ExistMadeUpOf
		{
			get;
		}

		void RemoveMadeUpOf();


		global::System.Decimal SquareFootage 
		{
			get;
			set;
		}

		bool ExistSquareFootage{get;}

		void RemoveSquareFootage();


		global::System.String Description 
		{
			get;
			set;
		}

		bool ExistDescription{get;}

		void RemoveDescription();


		global::Allors.Extent<ContactMechanism> FacilityContactMechanisms
		{ 
			get;
			set;
		}

		void AddFacilityContactMechanism (ContactMechanism value);

		void RemoveFacilityContactMechanism (ContactMechanism value);

		bool ExistFacilityContactMechanisms
		{
			get;
		}

		void RemoveFacilityContactMechanisms();


		global::System.String Name 
		{
			get;
			set;
		}

		bool ExistName{get;}

		void RemoveName();


		InternalOrganisation Owner
		{ 
			get;
			set;
		}

		bool ExistOwner
		{
			get;
		}

		void RemoveOwner();



		global::Allors.Extent<PurchaseOrder> PurchaseOrdersWhereFacility
		{ 
			get;
		}

		bool ExistPurchaseOrdersWhereFacility
		{
			get;
		}


		global::Allors.Extent<WorkEffortPartyAssignment> WorkEffortPartyAssignmentsWhereFacility
		{ 
			get;
		}

		bool ExistWorkEffortPartyAssignmentsWhereFacility
		{
			get;
		}


		global::Allors.Extent<PurchaseShipment> PurchaseShipmentsWhereFacility
		{ 
			get;
		}

		bool ExistPurchaseShipmentsWhereFacility
		{
			get;
		}


		global::Allors.Extent<WorkEffort> WorkEffortsWhereFacility
		{ 
			get;
		}

		bool ExistWorkEffortsWhereFacility
		{
			get;
		}


		global::Allors.Extent<InventoryItem> InventoryItemsWhereFacility
		{ 
			get;
		}

		bool ExistInventoryItemsWhereFacility
		{
			get;
		}


		global::Allors.Extent<ShipmentRouteSegment> ShipmentRouteSegmentsWhereFromFacility
		{ 
			get;
		}

		bool ExistShipmentRouteSegmentsWhereFromFacility
		{
			get;
		}


		global::Allors.Extent<ShipmentRouteSegment> ShipmentRouteSegmentsWhereToFacility
		{ 
			get;
		}

		bool ExistShipmentRouteSegmentsWhereToFacility
		{
			get;
		}


		global::Allors.Extent<Container> ContainersWhereFacility
		{ 
			get;
		}

		bool ExistContainersWhereFacility
		{
			get;
		}


		global::Allors.Extent<InternalOrganisation> InternalOrganisationsWhereDefaultFacility
		{ 
			get;
		}

		bool ExistInternalOrganisationsWhereDefaultFacility
		{
			get;
		}


		global::Allors.Extent<Facility> FacilitiesWhereMadeUpOf
		{ 
			get;
		}

		bool ExistFacilitiesWhereMadeUpOf
		{
			get;
		}


		global::Allors.Extent<Requirement> RequirementsWhereFacility
		{ 
			get;
		}

		bool ExistRequirementsWhereFacility
		{
			get;
		}


		global::Allors.Extent<Store> StoresWhereDefaultFacility
		{ 
			get;
		}

		bool ExistStoresWhereDefaultFacility
		{
			get;
		}

	}

	public class FacilityMeta
	{
		public static readonly FacilityMeta Instance = new FacilityMeta();

		public global::Allors.Meta.Interface ObjectType = global::Allors.Meta.Interfaces.Facility;

		public global::Allors.Meta.RoleType MadeUpOf 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.FacilityMadeUpOf;
			}
		} 
		public global::Allors.Meta.RoleType SquareFootage 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.FacilitySquareFootage;
			}
		} 
		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.FacilityDescription;
			}
		} 
		public global::Allors.Meta.RoleType FacilityContactMechanism 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.FacilityFacilityContactMechanism;
			}
		} 
		public global::Allors.Meta.RoleType Name 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.FacilityName;
			}
		} 
		public global::Allors.Meta.RoleType Owner 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.FacilityOwner;
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
		public global::Allors.Meta.RoleType Latitude 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.GeoLocatableLatitude;
			}
		} 
		public global::Allors.Meta.RoleType Longitude 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.GeoLocatableLongitude;
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

		public global::Allors.Meta.AssociationType PurchaseOrdersWhereFacility 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseOrderFacility;
			}
		} 
		public global::Allors.Meta.AssociationType WorkEffortPartyAssignmentsWhereFacility 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.WorkEffortPartyAssignmentFacility;
			}
		} 
		public global::Allors.Meta.AssociationType PurchaseShipmentsWhereFacility 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseShipmentFacility;
			}
		} 
		public global::Allors.Meta.AssociationType WorkEffortsWhereFacility 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.WorkEffortFacility;
			}
		} 
		public global::Allors.Meta.AssociationType InventoryItemsWhereFacility 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InventoryItemFacility;
			}
		} 
		public global::Allors.Meta.AssociationType ShipmentRouteSegmentsWhereFromFacility 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ShipmentRouteSegmentFromFacility;
			}
		} 
		public global::Allors.Meta.AssociationType ShipmentRouteSegmentsWhereToFacility 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ShipmentRouteSegmentToFacility;
			}
		} 
		public global::Allors.Meta.AssociationType ContainersWhereFacility 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ContainerFacility;
			}
		} 
		public global::Allors.Meta.AssociationType InternalOrganisationsWhereDefaultFacility 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InternalOrganisationDefaultFacility;
			}
		} 
		public global::Allors.Meta.AssociationType FacilitiesWhereMadeUpOf 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.FacilityMadeUpOf;
			}
		} 
		public global::Allors.Meta.AssociationType RequirementsWhereFacility 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.RequirementFacility;
			}
		} 
		public global::Allors.Meta.AssociationType StoresWhereDefaultFacility 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.StoreDefaultFacility;
			}
		} 

	}
}