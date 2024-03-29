// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface Budget :  Period,Commentable,SearchResult,UniquelyIdentifiable,Transitional,UserInterfaceable,Searchable, Allors.IObjectBase
	{


		global::System.String Description 
		{
			get;
			set;
		}

		bool ExistDescription{get;}

		void RemoveDescription();


		global::Allors.Extent<BudgetRevision> BudgetRevisions
		{ 
			get;
			set;
		}

		void AddBudgetRevision (BudgetRevision value);

		void RemoveBudgetRevision (BudgetRevision value);

		bool ExistBudgetRevisions
		{
			get;
		}

		void RemoveBudgetRevisions();


		global::Allors.Extent<BudgetStatus> BudgetStatuses
		{ 
			get;
			set;
		}

		void AddBudgetStatus (BudgetStatus value);

		void RemoveBudgetStatus (BudgetStatus value);

		bool ExistBudgetStatuses
		{
			get;
		}

		void RemoveBudgetStatuses();


		global::System.String BudgetNumber 
		{
			get;
			set;
		}

		bool ExistBudgetNumber{get;}

		void RemoveBudgetNumber();


		BudgetObjectState CurrentObjectState
		{ 
			get;
			set;
		}

		bool ExistCurrentObjectState
		{
			get;
		}

		void RemoveCurrentObjectState();


		BudgetObjectState PreviousObjectState
		{ 
			get;
			set;
		}

		bool ExistPreviousObjectState
		{
			get;
		}

		void RemovePreviousObjectState();


		global::Allors.Extent<BudgetReview> BudgetReviews
		{ 
			get;
			set;
		}

		void AddBudgetReview (BudgetReview value);

		void RemoveBudgetReview (BudgetReview value);

		bool ExistBudgetReviews
		{
			get;
		}

		void RemoveBudgetReviews();


		BudgetStatus CurrentBudgetStatus
		{ 
			get;
			set;
		}

		bool ExistCurrentBudgetStatus
		{
			get;
		}

		void RemoveCurrentBudgetStatus();


		global::Allors.Extent<BudgetItem> BudgetItems
		{ 
			get;
			set;
		}

		void AddBudgetItem (BudgetItem value);

		void RemoveBudgetItem (BudgetItem value);

		bool ExistBudgetItems
		{
			get;
		}

		void RemoveBudgetItems();

	}

	public class BudgetMeta
	{
		public static readonly BudgetMeta Instance = new BudgetMeta();

		public global::Allors.Meta.Interface ObjectType = global::Allors.Meta.Interfaces.Budget;

		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BudgetDescription;
			}
		} 
		public global::Allors.Meta.RoleType BudgetRevision 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BudgetBudgetRevision;
			}
		} 
		public global::Allors.Meta.RoleType BudgetStatus 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BudgetBudgetStatus;
			}
		} 
		public global::Allors.Meta.RoleType BudgetNumber 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BudgetBudgetNumber;
			}
		} 
		public global::Allors.Meta.RoleType CurrentObjectState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BudgetCurrentObjectState;
			}
		} 
		public global::Allors.Meta.RoleType PreviousObjectState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BudgetPreviousObjectState;
			}
		} 
		public global::Allors.Meta.RoleType BudgetReview 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BudgetBudgetReview;
			}
		} 
		public global::Allors.Meta.RoleType CurrentBudgetStatus 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BudgetCurrentBudgetStatus;
			}
		} 
		public global::Allors.Meta.RoleType BudgetItem 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BudgetBudgetItem;
			}
		} 
		public global::Allors.Meta.RoleType FromDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PeriodFromDate;
			}
		} 
		public global::Allors.Meta.RoleType ThroughDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PeriodThroughDate;
			}
		} 
		public global::Allors.Meta.RoleType Comment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommentableComment;
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
		public global::Allors.Meta.RoleType SearchData 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SearchableSearchData;
			}
		} 

		public global::Allors.Meta.MethodType Close 
		{
			get
			{
				return global::Allors.Meta.MethodTypes.BudgetClose;
			}
		} 
		public global::Allors.Meta.MethodType Reopen 
		{
			get
			{
				return global::Allors.Meta.MethodTypes.BudgetReopen;
			}
		} 

	}
}