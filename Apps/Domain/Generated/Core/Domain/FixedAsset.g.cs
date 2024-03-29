// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface FixedAsset :  UserInterfaceable,SearchResult,Searchable, Allors.IObjectBase
	{


		global::System.String Name 
		{
			get;
			set;
		}

		bool ExistName{get;}

		void RemoveName();


		global::System.DateTime LastServiceDate 
		{
			get;
			set;
		}

		bool ExistLastServiceDate{get;}

		void RemoveLastServiceDate();


		global::System.DateTime AcquiredDate 
		{
			get;
			set;
		}

		bool ExistAcquiredDate{get;}

		void RemoveAcquiredDate();


		global::System.String Description 
		{
			get;
			set;
		}

		bool ExistDescription{get;}

		void RemoveDescription();


		global::System.Decimal ProductionCapacity 
		{
			get;
			set;
		}

		bool ExistProductionCapacity{get;}

		void RemoveProductionCapacity();


		global::System.DateTime NextServiceDate 
		{
			get;
			set;
		}

		bool ExistNextServiceDate{get;}

		void RemoveNextServiceDate();



		global::Allors.Extent<WorkEffortFixedAssetAssignment> WorkEffortFixedAssetAssignmentsWhereFixedAsset
		{ 
			get;
		}

		bool ExistWorkEffortFixedAssetAssignmentsWhereFixedAsset
		{
			get;
		}


		global::Allors.Extent<PartyFixedAssetAssignment> PartyFixedAssetAssignmentsWhereFixedAsset
		{ 
			get;
		}

		bool ExistPartyFixedAssetAssignmentsWhereFixedAsset
		{
			get;
		}


		global::Allors.Extent<Depreciation> DepreciationsWhereFixedAsset
		{ 
			get;
		}

		bool ExistDepreciationsWhereFixedAsset
		{
			get;
		}


		global::Allors.Extent<WorkEffortType> WorkEffortTypesWhereFixedAssetToRepair
		{ 
			get;
		}

		bool ExistWorkEffortTypesWhereFixedAssetToRepair
		{
			get;
		}


		global::Allors.Extent<WorkEffortFixedAssetStandard> WorkEffortFixedAssetStandardsWhereFixedAsset
		{ 
			get;
		}

		bool ExistWorkEffortFixedAssetStandardsWhereFixedAsset
		{
			get;
		}


		global::Allors.Extent<WorkRequirement> WorkRequirementsWhereFixedAsset
		{ 
			get;
		}

		bool ExistWorkRequirementsWhereFixedAsset
		{
			get;
		}

	}

	public class FixedAssetMeta
	{
		public static readonly FixedAssetMeta Instance = new FixedAssetMeta();

		public global::Allors.Meta.Interface ObjectType = global::Allors.Meta.Interfaces.FixedAsset;

		public global::Allors.Meta.RoleType Name 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.FixedAssetName;
			}
		} 
		public global::Allors.Meta.RoleType LastServiceDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.FixedAssetLastServiceDate;
			}
		} 
		public global::Allors.Meta.RoleType AcquiredDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.FixedAssetAcquiredDate;
			}
		} 
		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.FixedAssetDescription;
			}
		} 
		public global::Allors.Meta.RoleType ProductionCapacity 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.FixedAssetProductionCapacity;
			}
		} 
		public global::Allors.Meta.RoleType NextServiceDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.FixedAssetNextServiceDate;
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

		public global::Allors.Meta.AssociationType WorkEffortFixedAssetAssignmentsWhereFixedAsset 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.WorkEffortFixedAssetAssignmentFixedAsset;
			}
		} 
		public global::Allors.Meta.AssociationType PartyFixedAssetAssignmentsWhereFixedAsset 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyFixedAssetAssignmentFixedAsset;
			}
		} 
		public global::Allors.Meta.AssociationType DepreciationsWhereFixedAsset 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.DepreciationFixedAsset;
			}
		} 
		public global::Allors.Meta.AssociationType WorkEffortTypesWhereFixedAssetToRepair 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.WorkEffortTypeFixedAssetToRepair;
			}
		} 
		public global::Allors.Meta.AssociationType WorkEffortFixedAssetStandardsWhereFixedAsset 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.WorkEffortFixedAssetStandardFixedAsset;
			}
		} 
		public global::Allors.Meta.AssociationType WorkRequirementsWhereFixedAsset 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.WorkRequirementFixedAsset;
			}
		} 

	}
}