// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class FaxCommunication : Allors.ObjectBase , CommunicationEvent
	{
		public static readonly FaxCommunicationMeta Meta = FaxCommunicationMeta.Instance;

		public FaxCommunication(Allors.IStrategy allors) : base(allors) {}

		public static FaxCommunication Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (FaxCommunication) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public Party Originator
		{ 
			get
			{
				return (Party) Strategy.GetCompositeRole(Meta.Originator);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Originator ,value);
			}
		}

		virtual public bool ExistOriginator
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Originator);
			}
		}

		virtual public void RemoveOriginator()
		{
			Strategy.RemoveCompositeRole(Meta.Originator);
		}


		virtual public Party Receiver
		{ 
			get
			{
				return (Party) Strategy.GetCompositeRole(Meta.Receiver);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Receiver ,value);
			}
		}

		virtual public bool ExistReceiver
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Receiver);
			}
		}

		virtual public void RemoveReceiver()
		{
			Strategy.RemoveCompositeRole(Meta.Receiver);
		}


		virtual public TelecommunicationsNumber OutgoingFaxNumber
		{ 
			get
			{
				return (TelecommunicationsNumber) Strategy.GetCompositeRole(Meta.OutgoingFaxNumber);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.OutgoingFaxNumber ,value);
			}
		}

		virtual public bool ExistOutgoingFaxNumber
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.OutgoingFaxNumber);
			}
		}

		virtual public void RemoveOutgoingFaxNumber()
		{
			Strategy.RemoveCompositeRole(Meta.OutgoingFaxNumber);
		}



		virtual public global::System.DateTime ScheduledStart 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.ScheduledStart);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ScheduledStart, value);
			}
		}

		virtual public bool ExistScheduledStart{
			get
			{
				return Strategy.ExistUnitRole(Meta.ScheduledStart);
			}
		}

		virtual public void RemoveScheduledStart()
		{
			Strategy.RemoveUnitRole(Meta.ScheduledStart);
		}


		virtual public global::Allors.Extent<CommunicationEventStatus> CommunicationEventStatuses
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.CommunicationEventStatus);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.CommunicationEventStatus, value);
			}
		}

		virtual public void AddCommunicationEventStatus (CommunicationEventStatus value)
		{
			Strategy.AddCompositeRole(Meta.CommunicationEventStatus, value);
		}

		virtual public void RemoveCommunicationEventStatus (CommunicationEventStatus value)
		{
			Strategy.RemoveCompositeRole(Meta.CommunicationEventStatus,value);
		}

		virtual public bool ExistCommunicationEventStatuses
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.CommunicationEventStatus);
			}
		}

		virtual public void RemoveCommunicationEventStatuses()
		{
			Strategy.RemoveCompositeRoles(Meta.CommunicationEventStatus);
		}


		virtual public global::Allors.Extent<Party> InvolvedParties
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.InvolvedParty);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.InvolvedParty, value);
			}
		}

		virtual public void AddInvolvedParty (Party value)
		{
			Strategy.AddCompositeRole(Meta.InvolvedParty, value);
		}

		virtual public void RemoveInvolvedParty (Party value)
		{
			Strategy.RemoveCompositeRole(Meta.InvolvedParty,value);
		}

		virtual public bool ExistInvolvedParties
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.InvolvedParty);
			}
		}

		virtual public void RemoveInvolvedParties()
		{
			Strategy.RemoveCompositeRoles(Meta.InvolvedParty);
		}



		virtual public global::System.DateTime InitialScheduledStartDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.InitialScheduledStartDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.InitialScheduledStartDate, value);
			}
		}

		virtual public bool ExistInitialScheduledStartDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.InitialScheduledStartDate);
			}
		}

		virtual public void RemoveInitialScheduledStartDate()
		{
			Strategy.RemoveUnitRole(Meta.InitialScheduledStartDate);
		}


		virtual public CommunicationEventObjectState CurrentObjectState
		{ 
			get
			{
				return (CommunicationEventObjectState) Strategy.GetCompositeRole(Meta.CurrentObjectState);
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


		virtual public global::Allors.Extent<CommunicationEventPurpose> EventPurposes
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.EventPurpose);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.EventPurpose, value);
			}
		}

		virtual public void AddEventPurpose (CommunicationEventPurpose value)
		{
			Strategy.AddCompositeRole(Meta.EventPurpose, value);
		}

		virtual public void RemoveEventPurpose (CommunicationEventPurpose value)
		{
			Strategy.RemoveCompositeRole(Meta.EventPurpose,value);
		}

		virtual public bool ExistEventPurposes
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.EventPurpose);
			}
		}

		virtual public void RemoveEventPurposes()
		{
			Strategy.RemoveCompositeRoles(Meta.EventPurpose);
		}


		virtual public global::Allors.Extent<WorkEffort> WorkEfforts
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.WorkEffort);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.WorkEffort, value);
			}
		}

		virtual public void AddWorkEffort (WorkEffort value)
		{
			Strategy.AddCompositeRole(Meta.WorkEffort, value);
		}

		virtual public void RemoveWorkEffort (WorkEffort value)
		{
			Strategy.RemoveCompositeRole(Meta.WorkEffort,value);
		}

		virtual public bool ExistWorkEfforts
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.WorkEffort);
			}
		}

		virtual public void RemoveWorkEfforts()
		{
			Strategy.RemoveCompositeRoles(Meta.WorkEffort);
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



		virtual public global::System.String Subject 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Subject);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Subject, value);
			}
		}

		virtual public bool ExistSubject{
			get
			{
				return Strategy.ExistUnitRole(Meta.Subject);
			}
		}

		virtual public void RemoveSubject()
		{
			Strategy.RemoveUnitRole(Meta.Subject);
		}


		virtual public CommunicationEventObjectState PreviousObjectState
		{ 
			get
			{
				return (CommunicationEventObjectState) Strategy.GetCompositeRole(Meta.PreviousObjectState);
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


		virtual public global::Allors.Extent<Media> Documents
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

		virtual public void AddDocument (Media value)
		{
			Strategy.AddCompositeRole(Meta.Document, value);
		}

		virtual public void RemoveDocument (Media value)
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


		virtual public Case Case
		{ 
			get
			{
				return (Case) Strategy.GetCompositeRole(Meta.Case);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Case ,value);
			}
		}

		virtual public bool ExistCase
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Case);
			}
		}

		virtual public void RemoveCase()
		{
			Strategy.RemoveCompositeRole(Meta.Case);
		}


		virtual public Person Owner
		{ 
			get
			{
				return (Person) Strategy.GetCompositeRole(Meta.Owner);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Owner ,value);
			}
		}

		virtual public bool ExistOwner
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Owner);
			}
		}

		virtual public void RemoveOwner()
		{
			Strategy.RemoveCompositeRole(Meta.Owner);
		}


		virtual public CommunicationEventStatus CurrentCommunicationEventStatus
		{ 
			get
			{
				return (CommunicationEventStatus) Strategy.GetCompositeRole(Meta.CurrentCommunicationEventStatus);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.CurrentCommunicationEventStatus ,value);
			}
		}

		virtual public bool ExistCurrentCommunicationEventStatus
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.CurrentCommunicationEventStatus);
			}
		}

		virtual public void RemoveCurrentCommunicationEventStatus()
		{
			Strategy.RemoveCompositeRole(Meta.CurrentCommunicationEventStatus);
		}



		virtual public global::System.DateTime ActualStart 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.ActualStart);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ActualStart, value);
			}
		}

		virtual public bool ExistActualStart{
			get
			{
				return Strategy.ExistUnitRole(Meta.ActualStart);
			}
		}

		virtual public void RemoveActualStart()
		{
			Strategy.RemoveUnitRole(Meta.ActualStart);
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



		virtual public global::System.String Comment 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Comment);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Comment, value);
			}
		}

		virtual public bool ExistComment{
			get
			{
				return Strategy.ExistUnitRole(Meta.Comment);
			}
		}

		virtual public void RemoveComment()
		{
			Strategy.RemoveUnitRole(Meta.Comment);
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



		virtual public PartyRelationship PartyRelationshipWhereCommunicationEvent
		{ 
			get
			{
				return (PartyRelationship) Strategy.GetCompositeAssociation(Meta.PartyRelationshipWhereCommunicationEvent);
			}
		} 

		virtual public bool ExistPartyRelationshipWhereCommunicationEvent
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.PartyRelationshipWhereCommunicationEvent);
			}
		}


		virtual public global::Allors.Extent<RequirementCommunication> RequirementCommunicationsWhereCommunicationEvent
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.RequirementCommunicationsWhereCommunicationEvent);
			}
		}

		virtual public bool ExistRequirementCommunicationsWhereCommunicationEvent
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.RequirementCommunicationsWhereCommunicationEvent);
			}
		}

	}

	public class FaxCommunicationMeta
	{
		public static readonly FaxCommunicationMeta Instance = new FaxCommunicationMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.FaxCommunication;

		public global::Allors.Meta.RoleType Originator 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.FaxCommunicationOriginator;
			}
		} 
		public global::Allors.Meta.RoleType Receiver 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.FaxCommunicationReceiver;
			}
		} 
		public global::Allors.Meta.RoleType OutgoingFaxNumber 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.FaxCommunicationOutgoingFaxNumber;
			}
		} 
		public global::Allors.Meta.RoleType ScheduledStart 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommunicationEventScheduledStart;
			}
		} 
		public global::Allors.Meta.RoleType CommunicationEventStatus 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommunicationEventCommunicationEventStatus;
			}
		} 
		public global::Allors.Meta.RoleType InvolvedParty 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommunicationEventInvolvedParty;
			}
		} 
		public global::Allors.Meta.RoleType InitialScheduledStartDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommunicationEventInitialScheduledStartDate;
			}
		} 
		public global::Allors.Meta.RoleType CurrentObjectState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommunicationEventCurrentObjectState;
			}
		} 
		public global::Allors.Meta.RoleType EventPurpose 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommunicationEventEventPurpose;
			}
		} 
		public global::Allors.Meta.RoleType WorkEffort 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommunicationEventWorkEffort;
			}
		} 
		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommunicationEventDescription;
			}
		} 
		public global::Allors.Meta.RoleType Subject 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommunicationEventSubject;
			}
		} 
		public global::Allors.Meta.RoleType PreviousObjectState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommunicationEventPreviousObjectState;
			}
		} 
		public global::Allors.Meta.RoleType Document 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommunicationEventDocument;
			}
		} 
		public global::Allors.Meta.RoleType Case 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommunicationEventCase;
			}
		} 
		public global::Allors.Meta.RoleType Owner 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommunicationEventOwner;
			}
		} 
		public global::Allors.Meta.RoleType CurrentCommunicationEventStatus 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommunicationEventCurrentCommunicationEventStatus;
			}
		} 
		public global::Allors.Meta.RoleType ActualStart 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommunicationEventActualStart;
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
		public global::Allors.Meta.RoleType DisplayName 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UserInterfaceableDisplayName;
			}
		} 
		public global::Allors.Meta.RoleType SearchData 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SearchableSearchData;
			}
		} 
		public global::Allors.Meta.RoleType Comment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommentableComment;
			}
		} 
		public global::Allors.Meta.RoleType UniqueId 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UniquelyIdentifiableUniqueId;
			}
		} 

		public global::Allors.Meta.AssociationType PartyRelationshipWhereCommunicationEvent 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyRelationshipCommunicationEvent;
			}
		} 
		public global::Allors.Meta.AssociationType RequirementCommunicationsWhereCommunicationEvent 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.RequirementCommunicationCommunicationEvent;
			}
		} 

		public global::Allors.Meta.MethodType Close 
		{
			get
			{
				return global::Allors.Meta.MethodTypes.CommunicationEventClose;
			}
		} 
		public global::Allors.Meta.MethodType Reopen 
		{
			get
			{
				return global::Allors.Meta.MethodTypes.CommunicationEventReopen;
			}
		} 
		public global::Allors.Meta.MethodType Cancel 
		{
			get
			{
				return global::Allors.Meta.MethodTypes.CommunicationEventCancel;
			}
		} 

	}
}