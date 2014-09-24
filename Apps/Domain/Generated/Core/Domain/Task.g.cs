// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class Task : Allors.ObjectBase , WorkEffort
	{
		public static readonly TaskMeta Meta = TaskMeta.Instance;

		public Task(Allors.IStrategy allors) : base(allors) {}

		public static Task Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (Task) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public WorkEffortStatus CurrentWorkEffortStatus
		{ 
			get
			{
				return (WorkEffortStatus) Strategy.GetCompositeRole(Meta.CurrentWorkEffortStatus);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.CurrentWorkEffortStatus ,value);
			}
		}

		virtual public bool ExistCurrentWorkEffortStatus
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.CurrentWorkEffortStatus);
			}
		}

		virtual public void RemoveCurrentWorkEffortStatus()
		{
			Strategy.RemoveCompositeRole(Meta.CurrentWorkEffortStatus);
		}


		virtual public global::Allors.Extent<WorkEffort> Precendencies
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.Precendency);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.Precendency, value);
			}
		}

		virtual public void AddPrecendency (WorkEffort value)
		{
			Strategy.AddCompositeRole(Meta.Precendency, value);
		}

		virtual public void RemovePrecendency (WorkEffort value)
		{
			Strategy.RemoveCompositeRole(Meta.Precendency,value);
		}

		virtual public bool ExistPrecendencies
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.Precendency);
			}
		}

		virtual public void RemovePrecendencies()
		{
			Strategy.RemoveCompositeRoles(Meta.Precendency);
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


		virtual public global::Allors.Extent<Deliverable> DeliverablesProduced
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.DeliverableProduced);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.DeliverableProduced, value);
			}
		}

		virtual public void AddDeliverableProduced (Deliverable value)
		{
			Strategy.AddCompositeRole(Meta.DeliverableProduced, value);
		}

		virtual public void RemoveDeliverableProduced (Deliverable value)
		{
			Strategy.RemoveCompositeRole(Meta.DeliverableProduced,value);
		}

		virtual public bool ExistDeliverablesProduced
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.DeliverableProduced);
			}
		}

		virtual public void RemoveDeliverablesProduced()
		{
			Strategy.RemoveCompositeRoles(Meta.DeliverableProduced);
		}


		virtual public global::Allors.Extent<WorkEffortInventoryAssignment> InventoryItemsNeeded
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.InventoryItemNeeded);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.InventoryItemNeeded, value);
			}
		}

		virtual public void AddInventoryItemNeeded (WorkEffortInventoryAssignment value)
		{
			Strategy.AddCompositeRole(Meta.InventoryItemNeeded, value);
		}

		virtual public void RemoveInventoryItemNeeded (WorkEffortInventoryAssignment value)
		{
			Strategy.RemoveCompositeRole(Meta.InventoryItemNeeded,value);
		}

		virtual public bool ExistInventoryItemsNeeded
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.InventoryItemNeeded);
			}
		}

		virtual public void RemoveInventoryItemsNeeded()
		{
			Strategy.RemoveCompositeRoles(Meta.InventoryItemNeeded);
		}


		virtual public global::Allors.Extent<WorkEffort> Children
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.Child);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.Child, value);
			}
		}

		virtual public void AddChild (WorkEffort value)
		{
			Strategy.AddCompositeRole(Meta.Child, value);
		}

		virtual public void RemoveChild (WorkEffort value)
		{
			Strategy.RemoveCompositeRole(Meta.Child,value);
		}

		virtual public bool ExistChildren
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.Child);
			}
		}

		virtual public void RemoveChildren()
		{
			Strategy.RemoveCompositeRoles(Meta.Child);
		}


		virtual public OrderItem OrderItemFulfillment
		{ 
			get
			{
				return (OrderItem) Strategy.GetCompositeRole(Meta.OrderItemFulfillment);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.OrderItemFulfillment ,value);
			}
		}

		virtual public bool ExistOrderItemFulfillment
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.OrderItemFulfillment);
			}
		}

		virtual public void RemoveOrderItemFulfillment()
		{
			Strategy.RemoveCompositeRole(Meta.OrderItemFulfillment);
		}


		virtual public global::Allors.Extent<WorkEffortStatus> WorkEffortStatuses
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.WorkEffortStatus);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.WorkEffortStatus, value);
			}
		}

		virtual public void AddWorkEffortStatus (WorkEffortStatus value)
		{
			Strategy.AddCompositeRole(Meta.WorkEffortStatus, value);
		}

		virtual public void RemoveWorkEffortStatus (WorkEffortStatus value)
		{
			Strategy.RemoveCompositeRole(Meta.WorkEffortStatus,value);
		}

		virtual public bool ExistWorkEffortStatuses
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.WorkEffortStatus);
			}
		}

		virtual public void RemoveWorkEffortStatuses()
		{
			Strategy.RemoveCompositeRoles(Meta.WorkEffortStatus);
		}


		virtual public WorkEffortType WorkEffortType
		{ 
			get
			{
				return (WorkEffortType) Strategy.GetCompositeRole(Meta.WorkEffortType);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.WorkEffortType ,value);
			}
		}

		virtual public bool ExistWorkEffortType
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.WorkEffortType);
			}
		}

		virtual public void RemoveWorkEffortType()
		{
			Strategy.RemoveCompositeRole(Meta.WorkEffortType);
		}


		virtual public global::Allors.Extent<InventoryItem> InventoryItemsProduced
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.InventoryItemProduced);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.InventoryItemProduced, value);
			}
		}

		virtual public void AddInventoryItemProduced (InventoryItem value)
		{
			Strategy.AddCompositeRole(Meta.InventoryItemProduced, value);
		}

		virtual public void RemoveInventoryItemProduced (InventoryItem value)
		{
			Strategy.RemoveCompositeRole(Meta.InventoryItemProduced,value);
		}

		virtual public bool ExistInventoryItemsProduced
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.InventoryItemProduced);
			}
		}

		virtual public void RemoveInventoryItemsProduced()
		{
			Strategy.RemoveCompositeRoles(Meta.InventoryItemProduced);
		}


		virtual public global::Allors.Extent<Requirement> RequirementFulfillments
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.RequirementFulfillment);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.RequirementFulfillment, value);
			}
		}

		virtual public void AddRequirementFulfillment (Requirement value)
		{
			Strategy.AddCompositeRole(Meta.RequirementFulfillment, value);
		}

		virtual public void RemoveRequirementFulfillment (Requirement value)
		{
			Strategy.RemoveCompositeRole(Meta.RequirementFulfillment,value);
		}

		virtual public bool ExistRequirementFulfillments
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.RequirementFulfillment);
			}
		}

		virtual public void RemoveRequirementFulfillments()
		{
			Strategy.RemoveCompositeRoles(Meta.RequirementFulfillment);
		}



		virtual public global::System.String SpecialTerms 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.SpecialTerms);
			}
			set
			{
				Strategy.SetUnitRole(Meta.SpecialTerms, value);
			}
		}

		virtual public bool ExistSpecialTerms{
			get
			{
				return Strategy.ExistUnitRole(Meta.SpecialTerms);
			}
		}

		virtual public void RemoveSpecialTerms()
		{
			Strategy.RemoveUnitRole(Meta.SpecialTerms);
		}


		virtual public global::Allors.Extent<WorkEffort> Concurrencies
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.Concurrency);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.Concurrency, value);
			}
		}

		virtual public void AddConcurrency (WorkEffort value)
		{
			Strategy.AddCompositeRole(Meta.Concurrency, value);
		}

		virtual public void RemoveConcurrency (WorkEffort value)
		{
			Strategy.RemoveCompositeRole(Meta.Concurrency,value);
		}

		virtual public bool ExistConcurrencies
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.Concurrency);
			}
		}

		virtual public void RemoveConcurrencies()
		{
			Strategy.RemoveCompositeRoles(Meta.Concurrency);
		}



		virtual public global::System.Decimal ActualHours 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.ActualHours);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ActualHours, value);
			}
		}

		virtual public bool ExistActualHours{
			get
			{
				return Strategy.ExistUnitRole(Meta.ActualHours);
			}
		}

		virtual public void RemoveActualHours()
		{
			Strategy.RemoveUnitRole(Meta.ActualHours);
		}



		virtual public global::System.String Description 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Description);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Description, value);
			}
		}

		virtual public bool ExistDescription{
			get
			{
				return Strategy.ExistUnitRole(Meta.Description);
			}
		}

		virtual public void RemoveDescription()
		{
			Strategy.RemoveUnitRole(Meta.Description);
		}


		virtual public WorkEffortObjectState PreviousObjectState
		{ 
			get
			{
				return (WorkEffortObjectState) Strategy.GetCompositeRole(Meta.PreviousObjectState);
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


		virtual public WorkEffortObjectState CurrentObjectState
		{ 
			get
			{
				return (WorkEffortObjectState) Strategy.GetCompositeRole(Meta.CurrentObjectState);
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



		virtual public global::System.Decimal EstimatedHours 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.EstimatedHours);
			}
			set
			{
				Strategy.SetUnitRole(Meta.EstimatedHours, value);
			}
		}

		virtual public bool ExistEstimatedHours{
			get
			{
				return Strategy.ExistUnitRole(Meta.EstimatedHours);
			}
		}

		virtual public void RemoveEstimatedHours()
		{
			Strategy.RemoveUnitRole(Meta.EstimatedHours);
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



		virtual public global::Allors.Extent<QuoteItem> QuoteItemsWhereWorkEffort
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.QuoteItemsWhereWorkEffort);
			}
		}

		virtual public bool ExistQuoteItemsWhereWorkEffort
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.QuoteItemsWhereWorkEffort);
			}
		}


		virtual public global::Allors.Extent<WorkEffortPartyAssignment> WorkEffortPartyAssignmentsWhereAssignment
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.WorkEffortPartyAssignmentsWhereAssignment);
			}
		}

		virtual public bool ExistWorkEffortPartyAssignmentsWhereAssignment
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.WorkEffortPartyAssignmentsWhereAssignment);
			}
		}


		virtual public global::Allors.Extent<WorkEffortBilling> WorkEffortBillingsWhereWorkEffort
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.WorkEffortBillingsWhereWorkEffort);
			}
		}

		virtual public bool ExistWorkEffortBillingsWhereWorkEffort
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.WorkEffortBillingsWhereWorkEffort);
			}
		}


		virtual public global::Allors.Extent<WorkEffortAssignment> WorkEffortAssignmentsWhereAssignment
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.WorkEffortAssignmentsWhereAssignment);
			}
		}

		virtual public bool ExistWorkEffortAssignmentsWhereAssignment
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.WorkEffortAssignmentsWhereAssignment);
			}
		}


		virtual public global::Allors.Extent<WorkEffortFixedAssetAssignment> WorkEffortFixedAssetAssignmentsWhereAssignment
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.WorkEffortFixedAssetAssignmentsWhereAssignment);
			}
		}

		virtual public bool ExistWorkEffortFixedAssetAssignmentsWhereAssignment
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.WorkEffortFixedAssetAssignmentsWhereAssignment);
			}
		}


		virtual public global::Allors.Extent<ServiceEntry> ServiceEntriesWhereWorkEffort
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ServiceEntriesWhereWorkEffort);
			}
		}

		virtual public bool ExistServiceEntriesWhereWorkEffort
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ServiceEntriesWhereWorkEffort);
			}
		}


		virtual public global::Allors.Extent<WorkEffort> WorkEffortsWherePrecendency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.WorkEffortsWherePrecendency);
			}
		}

		virtual public bool ExistWorkEffortsWherePrecendency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.WorkEffortsWherePrecendency);
			}
		}


		virtual public global::Allors.Extent<WorkEffort> WorkEffortsWhereChild
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.WorkEffortsWhereChild);
			}
		}

		virtual public bool ExistWorkEffortsWhereChild
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.WorkEffortsWhereChild);
			}
		}


		virtual public global::Allors.Extent<WorkEffort> WorkEffortsWhereConcurrency
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.WorkEffortsWhereConcurrency);
			}
		}

		virtual public bool ExistWorkEffortsWhereConcurrency
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.WorkEffortsWhereConcurrency);
			}
		}


		virtual public global::Allors.Extent<EngagementItem> EngagementItemsWhereEngagementWorkFulfillment
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.EngagementItemsWhereEngagementWorkFulfillment);
			}
		}

		virtual public bool ExistEngagementItemsWhereEngagementWorkFulfillment
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.EngagementItemsWhereEngagementWorkFulfillment);
			}
		}


		virtual public global::Allors.Extent<CommunicationEvent> CommunicationEventsWhereWorkEffort
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.CommunicationEventsWhereWorkEffort);
			}
		}

		virtual public bool ExistCommunicationEventsWhereWorkEffort
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.CommunicationEventsWhereWorkEffort);
			}
		}


		virtual public global::Allors.Extent<WorkEffortInventoryAssignment> WorkEffortInventoryAssignmentsWhereAssignment
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.WorkEffortInventoryAssignmentsWhereAssignment);
			}
		}

		virtual public bool ExistWorkEffortInventoryAssignmentsWhereAssignment
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.WorkEffortInventoryAssignmentsWhereAssignment);
			}
		}

	}

	public class TaskMeta
	{
		public static readonly TaskMeta Instance = new TaskMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.Task;

		public global::Allors.Meta.RoleType CurrentWorkEffortStatus 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortCurrentWorkEffortStatus;
			}
		} 
		public global::Allors.Meta.RoleType Precendency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortPrecendency;
			}
		} 
		public global::Allors.Meta.RoleType Facility 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortFacility;
			}
		} 
		public global::Allors.Meta.RoleType DeliverableProduced 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortDeliverableProduced;
			}
		} 
		public global::Allors.Meta.RoleType InventoryItemNeeded 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortInventoryItemNeeded;
			}
		} 
		public global::Allors.Meta.RoleType Child 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortChild;
			}
		} 
		public global::Allors.Meta.RoleType OrderItemFulfillment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortOrderItemFulfillment;
			}
		} 
		public global::Allors.Meta.RoleType WorkEffortStatus 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortWorkEffortStatus;
			}
		} 
		public global::Allors.Meta.RoleType WorkEffortType 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortWorkEffortType;
			}
		} 
		public global::Allors.Meta.RoleType InventoryItemProduced 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortInventoryItemProduced;
			}
		} 
		public global::Allors.Meta.RoleType RequirementFulfillment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortRequirementFulfillment;
			}
		} 
		public global::Allors.Meta.RoleType SpecialTerms 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortSpecialTerms;
			}
		} 
		public global::Allors.Meta.RoleType Concurrency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortConcurrency;
			}
		} 
		public global::Allors.Meta.RoleType ActualHours 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortActualHours;
			}
		} 
		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortDescription;
			}
		} 
		public global::Allors.Meta.RoleType PreviousObjectState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortPreviousObjectState;
			}
		} 
		public global::Allors.Meta.RoleType CurrentObjectState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortCurrentObjectState;
			}
		} 
		public global::Allors.Meta.RoleType EstimatedHours 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortEstimatedHours;
			}
		} 
		public global::Allors.Meta.RoleType SearchData 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SearchableSearchData;
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
		public global::Allors.Meta.RoleType UniqueId 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UniquelyIdentifiableUniqueId;
			}
		} 

		public global::Allors.Meta.AssociationType QuoteItemsWhereWorkEffort 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.QuoteItemWorkEffort;
			}
		} 
		public global::Allors.Meta.AssociationType WorkEffortPartyAssignmentsWhereAssignment 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.WorkEffortPartyAssignmentAssignment;
			}
		} 
		public global::Allors.Meta.AssociationType WorkEffortBillingsWhereWorkEffort 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.WorkEffortBillingWorkEffort;
			}
		} 
		public global::Allors.Meta.AssociationType WorkEffortAssignmentsWhereAssignment 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.WorkEffortAssignmentAssignment;
			}
		} 
		public global::Allors.Meta.AssociationType WorkEffortFixedAssetAssignmentsWhereAssignment 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.WorkEffortFixedAssetAssignmentAssignment;
			}
		} 
		public global::Allors.Meta.AssociationType ServiceEntriesWhereWorkEffort 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ServiceEntryWorkEffort;
			}
		} 
		public global::Allors.Meta.AssociationType WorkEffortsWherePrecendency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.WorkEffortPrecendency;
			}
		} 
		public global::Allors.Meta.AssociationType WorkEffortsWhereChild 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.WorkEffortChild;
			}
		} 
		public global::Allors.Meta.AssociationType WorkEffortsWhereConcurrency 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.WorkEffortConcurrency;
			}
		} 
		public global::Allors.Meta.AssociationType EngagementItemsWhereEngagementWorkFulfillment 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.EngagementItemEngagementWorkFulfillment;
			}
		} 
		public global::Allors.Meta.AssociationType CommunicationEventsWhereWorkEffort 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CommunicationEventWorkEffort;
			}
		} 
		public global::Allors.Meta.AssociationType WorkEffortInventoryAssignmentsWhereAssignment 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.WorkEffortInventoryAssignmentAssignment;
			}
		} 

		public global::Allors.Meta.MethodType Confirm 
		{
			get
			{
				return global::Allors.Meta.MethodTypes.WorkEffortConfirm;
			}
		} 
		public global::Allors.Meta.MethodType WorkDone 
		{
			get
			{
				return global::Allors.Meta.MethodTypes.WorkEffortWorkDone;
			}
		} 
		public global::Allors.Meta.MethodType Finish 
		{
			get
			{
				return global::Allors.Meta.MethodTypes.WorkEffortFinish;
			}
		} 
		public global::Allors.Meta.MethodType Cancel 
		{
			get
			{
				return global::Allors.Meta.MethodTypes.WorkEffortCancel;
			}
		} 
		public global::Allors.Meta.MethodType Reopen 
		{
			get
			{
				return global::Allors.Meta.MethodTypes.WorkEffortReopen;
			}
		} 

	}
}