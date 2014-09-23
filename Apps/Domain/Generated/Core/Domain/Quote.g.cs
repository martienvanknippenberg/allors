// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface Quote :  UserInterfaceable,SearchResult,Searchable, Allors.IObject
	{


		global::System.DateTime? ValidFromDate 
		{
			get;
			set;
		}

		bool ExistValidFromDate{get;}

		void RemoveValidFromDate();


		global::Allors.Extent<QuoteTerm> QuoteTerms
		{ 
			get;
			set;
		}

		void AddQuoteTerm (QuoteTerm value);

		void RemoveQuoteTerm (QuoteTerm value);

		bool ExistQuoteTerms
		{
			get;
		}

		void RemoveQuoteTerms();


		Party Issuer
		{ 
			get;
			set;
		}

		bool ExistIssuer
		{
			get;
		}

		void RemoveIssuer();


		global::System.DateTime? ValidThroughDate 
		{
			get;
			set;
		}

		bool ExistValidThroughDate{get;}

		void RemoveValidThroughDate();


		global::System.String Description 
		{
			get;
			set;
		}

		bool ExistDescription{get;}

		void RemoveDescription();


		Party Receiver
		{ 
			get;
			set;
		}

		bool ExistReceiver
		{
			get;
		}

		void RemoveReceiver();


		global::System.Decimal? Amount 
		{
			get;
			set;
		}

		bool ExistAmount{get;}

		void RemoveAmount();


		global::System.DateTime? IssueDate 
		{
			get;
			set;
		}

		bool ExistIssueDate{get;}

		void RemoveIssueDate();


		global::Allors.Extent<QuoteItem> QuoteItems
		{ 
			get;
			set;
		}

		void AddQuoteItem (QuoteItem value);

		void RemoveQuoteItem (QuoteItem value);

		bool ExistQuoteItems
		{
			get;
		}

		void RemoveQuoteItems();


		global::System.String QuoteNumber 
		{
			get;
			set;
		}

		bool ExistQuoteNumber{get;}

		void RemoveQuoteNumber();

	}

	public class QuoteMeta
	{
		public static readonly QuoteMeta Instance = new QuoteMeta();

		public global::Allors.Meta.Interface ObjectType = global::Allors.Meta.Interfaces.Quote;

		public global::Allors.Meta.RoleType ValidFromDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.QuoteValidFromDate;
			}
		} 
		public global::Allors.Meta.RoleType QuoteTerm 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.QuoteQuoteTerm;
			}
		} 
		public global::Allors.Meta.RoleType Issuer 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.QuoteIssuer;
			}
		} 
		public global::Allors.Meta.RoleType ValidThroughDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.QuoteValidThroughDate;
			}
		} 
		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.QuoteDescription;
			}
		} 
		public global::Allors.Meta.RoleType Receiver 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.QuoteReceiver;
			}
		} 
		public global::Allors.Meta.RoleType Amount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.QuoteAmount;
			}
		} 
		public global::Allors.Meta.RoleType IssueDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.QuoteIssueDate;
			}
		} 
		public global::Allors.Meta.RoleType QuoteItem 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.QuoteQuoteItem;
			}
		} 
		public global::Allors.Meta.RoleType QuoteNumber 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.QuoteQuoteNumber;
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

	}
}