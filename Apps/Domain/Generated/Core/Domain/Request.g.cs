// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface Request :  UserInterfaceable,Searchable,SearchResult,Commentable, Allors.IObjectBase
	{


		global::System.String Description 
		{
			get;
			set;
		}

		bool ExistDescription{get;}

		void RemoveDescription();


		global::System.DateTime RequiredResponseDate 
		{
			get;
			set;
		}

		bool ExistRequiredResponseDate{get;}

		void RemoveRequiredResponseDate();


		global::Allors.Extent<RequestItem> RequestItems
		{ 
			get;
			set;
		}

		void AddRequestItem (RequestItem value);

		void RemoveRequestItem (RequestItem value);

		bool ExistRequestItems
		{
			get;
		}

		void RemoveRequestItems();


		global::System.String RequestNumber 
		{
			get;
			set;
		}

		bool ExistRequestNumber{get;}

		void RemoveRequestNumber();


		global::Allors.Extent<RespondingParty> RespondingParties
		{ 
			get;
			set;
		}

		void AddRespondingParty (RespondingParty value);

		void RemoveRespondingParty (RespondingParty value);

		bool ExistRespondingParties
		{
			get;
		}

		void RemoveRespondingParties();


		Party Originator
		{ 
			get;
			set;
		}

		bool ExistOriginator
		{
			get;
		}

		void RemoveOriginator();

	}

	public class RequestMeta
	{
		public static readonly RequestMeta Instance = new RequestMeta();

		public global::Allors.Meta.Interface ObjectType = global::Allors.Meta.Interfaces.Request;

		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.RequestDescription;
			}
		} 
		public global::Allors.Meta.RoleType RequiredResponseDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.RequestRequiredResponseDate;
			}
		} 
		public global::Allors.Meta.RoleType RequestItem 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.RequestRequestItem;
			}
		} 
		public global::Allors.Meta.RoleType RequestNumber 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.RequestRequestNumber;
			}
		} 
		public global::Allors.Meta.RoleType RespondingParty 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.RequestRespondingParty;
			}
		} 
		public global::Allors.Meta.RoleType Originator 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.RequestOriginator;
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
		public global::Allors.Meta.RoleType Comment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommentableComment;
			}
		} 

	}
}