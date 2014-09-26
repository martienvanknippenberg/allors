// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface CommunicationEventBuilder : TransitionalBuilder ,UserInterfaceableBuilder ,SearchResultBuilder ,SearchableBuilder ,CommentableBuilder ,UniquelyIdentifiableBuilder , global::System.IDisposable
	{	

		global::System.DateTime? ScheduledStart {get;}

		

		global::System.Collections.Generic.List<CommunicationEventStatus> CommunicationEventStatuses {get;}		

		

		global::System.Collections.Generic.List<Party> InvolvedParties {get;}		

		

		global::System.DateTime? InitialScheduledStartDate {get;}

		
		CommunicationEventObjectState CurrentObjectState {get;}

		

		global::System.Collections.Generic.List<CommunicationEventPurpose> EventPurposes {get;}		

		

		global::System.Collections.Generic.List<WorkEffort> WorkEfforts {get;}		

		

		global::System.String Description {get;}

		

		global::System.String Subject {get;}

		
		CommunicationEventObjectState PreviousObjectState {get;}

		

		global::System.Collections.Generic.List<Media> Documents {get;}		

		
		Case Case {get;}

		
		Person Owner {get;}

		
		CommunicationEventStatus CurrentCommunicationEventStatus {get;}

		

		global::System.DateTime? ActualStart {get;}

		
	}

	public partial class CommunicationEvents : global::Allors.ObjectsBase<CommunicationEvent>
	{
		public static readonly CommunicationEventMeta Meta = CommunicationEventMeta.Instance;

		public CommunicationEvents(Allors.ISession session) : base(session)
		{
		}

		public override Allors.Meta.Composite ObjectType
		{
			get
			{
				return Meta.ObjectType;
			}
		}
	}

}