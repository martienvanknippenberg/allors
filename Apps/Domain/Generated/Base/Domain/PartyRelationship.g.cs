// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface PartyRelationshipBuilder : PeriodBuilder ,CommentableBuilder ,UserInterfaceableBuilder , global::System.IDisposable
	{	
		PartyRelationshipStatus PartyRelationshipStatus {get;}

		

		global::System.Collections.Generic.List<Agreement> Agreements {get;}		

		
		PartyRelationshipPriority PartyRelationshipPriority {get;}

		

		global::System.Decimal? SimpleMovingAverage {get;}

		

		global::System.Collections.Generic.List<CommunicationEvent> CommunicationEvents {get;}		

		
	}

	public partial class PartyRelationships : global::Allors.ObjectsBase<PartyRelationship>
	{
		public static readonly PartyRelationshipMeta Meta = PartyRelationshipMeta.Instance;

		public PartyRelationships(Allors.ISession session) : base(session)
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