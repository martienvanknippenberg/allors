// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface EngagementItem :  UserInterfaceable, Allors.IObject
	{


		QuoteItem QuoteItem
		{ 
			get;
			set;
		}

		bool ExistQuoteItem
		{
			get;
		}

		void RemoveQuoteItem();


		global::System.String Description 
		{
			get;
			set;
		}

		bool ExistDescription{get;}

		void RemoveDescription();


		global::System.DateTime? ExpectedStartDate 
		{
			get;
			set;
		}

		bool ExistExpectedStartDate{get;}

		void RemoveExpectedStartDate();


		global::System.DateTime? ExpectedEndDate 
		{
			get;
			set;
		}

		bool ExistExpectedEndDate{get;}

		void RemoveExpectedEndDate();


		WorkEffort EngagementWorkFulfillment
		{ 
			get;
			set;
		}

		bool ExistEngagementWorkFulfillment
		{
			get;
		}

		void RemoveEngagementWorkFulfillment();


		global::Allors.Extent<EngagementRate> EngagementRates
		{ 
			get;
			set;
		}

		void AddEngagementRate (EngagementRate value);

		void RemoveEngagementRate (EngagementRate value);

		bool ExistEngagementRates
		{
			get;
		}

		void RemoveEngagementRates();


		EngagementRate CurrentEngagementRate
		{ 
			get;
			set;
		}

		bool ExistCurrentEngagementRate
		{
			get;
		}

		void RemoveCurrentEngagementRate();


		global::Allors.Extent<EngagementItem> OrderedWiths
		{ 
			get;
			set;
		}

		void AddOrderedWith (EngagementItem value);

		void RemoveOrderedWith (EngagementItem value);

		bool ExistOrderedWiths
		{
			get;
		}

		void RemoveOrderedWiths();


		Person CurrentAssignedProfessional
		{ 
			get;
			set;
		}

		bool ExistCurrentAssignedProfessional
		{
			get;
		}

		void RemoveCurrentAssignedProfessional();


		Product Product
		{ 
			get;
			set;
		}

		bool ExistProduct
		{
			get;
		}

		void RemoveProduct();


		ProductFeature ProductFeature
		{ 
			get;
			set;
		}

		bool ExistProductFeature
		{
			get;
		}

		void RemoveProductFeature();



		global::Allors.Extent<ServiceEntry> ServiceEntriesWhereEngagementItem
		{ 
			get;
		}

		bool ExistServiceEntriesWhereEngagementItem
		{
			get;
		}


		Engagement EngagementWhereEngagementItem
		{
			get;
		}

		bool ExistEngagementWhereEngagementItem
		{
			get;
		}


		global::Allors.Extent<ProfessionalAssignment> ProfessionalAssignmentsWhereEngagementItem
		{ 
			get;
		}

		bool ExistProfessionalAssignmentsWhereEngagementItem
		{
			get;
		}


		EngagementItem EngagementItemWhereOrderedWith
		{
			get;
		}

		bool ExistEngagementItemWhereOrderedWith
		{
			get;
		}

	}

	public class EngagementItemMeta
	{
		public static readonly EngagementItemMeta Instance = new EngagementItemMeta();

		public global::Allors.Meta.Interface ObjectType = global::Allors.Meta.Interfaces.EngagementItem;

		public global::Allors.Meta.RoleType QuoteItem 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EngagementItemQuoteItem;
			}
		} 
		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EngagementItemDescription;
			}
		} 
		public global::Allors.Meta.RoleType ExpectedStartDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EngagementItemExpectedStartDate;
			}
		} 
		public global::Allors.Meta.RoleType ExpectedEndDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EngagementItemExpectedEndDate;
			}
		} 
		public global::Allors.Meta.RoleType EngagementWorkFulfillment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EngagementItemEngagementWorkFulfillment;
			}
		} 
		public global::Allors.Meta.RoleType EngagementRate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EngagementItemEngagementRate;
			}
		} 
		public global::Allors.Meta.RoleType CurrentEngagementRate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EngagementItemCurrentEngagementRate;
			}
		} 
		public global::Allors.Meta.RoleType OrderedWith 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EngagementItemOrderedWith;
			}
		} 
		public global::Allors.Meta.RoleType CurrentAssignedProfessional 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EngagementItemCurrentAssignedProfessional;
			}
		} 
		public global::Allors.Meta.RoleType Product 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EngagementItemProduct;
			}
		} 
		public global::Allors.Meta.RoleType ProductFeature 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EngagementItemProductFeature;
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

		public global::Allors.Meta.AssociationType ServiceEntriesWhereEngagementItem 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ServiceEntryEngagementItem;
			}
		} 
		public global::Allors.Meta.AssociationType EngagementWhereEngagementItem 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.EngagementEngagementItem;
			}
		} 
		public global::Allors.Meta.AssociationType ProfessionalAssignmentsWhereEngagementItem 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProfessionalAssignmentEngagementItem;
			}
		} 
		public global::Allors.Meta.AssociationType EngagementItemWhereOrderedWith 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.EngagementItemOrderedWith;
			}
		} 

	}
}