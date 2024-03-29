// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface RequestBuilder : UserInterfaceableBuilder ,SearchableBuilder ,SearchResultBuilder ,CommentableBuilder , global::System.IDisposable
	{	

		global::System.String Description {get;}

		

		global::System.DateTime? RequiredResponseDate {get;}

		

		global::System.Collections.Generic.List<RequestItem> RequestItems {get;}		

		

		global::System.String RequestNumber {get;}

		

		global::System.Collections.Generic.List<RespondingParty> RespondingParties {get;}		

		
		Party Originator {get;}

		
	}

	public partial class Requests : global::Allors.ObjectsBase<Request>
	{
		public static readonly RequestMeta Meta = RequestMeta.Instance;

		public Requests(Allors.ISession session) : base(session)
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