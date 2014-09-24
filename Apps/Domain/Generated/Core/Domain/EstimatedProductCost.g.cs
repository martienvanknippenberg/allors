// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface EstimatedProductCost :  Period,SearchResult,Searchable,UserInterfaceable, Allors.IObject
	{


		global::System.Decimal Cost 
		{
			get;
			set;
		}

		bool ExistCost{get;}

		void RemoveCost();


		Currency Currency
		{ 
			get;
			set;
		}

		bool ExistCurrency
		{
			get;
		}

		void RemoveCurrency();


		Organisation Organisation
		{ 
			get;
			set;
		}

		bool ExistOrganisation
		{
			get;
		}

		void RemoveOrganisation();


		global::System.String Description 
		{
			get;
			set;
		}

		bool ExistDescription{get;}

		void RemoveDescription();


		GeographicBoundary GeographicBoundary
		{ 
			get;
			set;
		}

		bool ExistGeographicBoundary
		{
			get;
		}

		void RemoveGeographicBoundary();



		Product ProductWhereEstimatedProductCost
		{
			get;
		}

		bool ExistProductWhereEstimatedProductCost
		{
			get;
		}


		ProductFeature ProductFeatureWhereEstimatedProductCost
		{
			get;
		}

		bool ExistProductFeatureWhereEstimatedProductCost
		{
			get;
		}

	}

	public class EstimatedProductCostMeta
	{
		public static readonly EstimatedProductCostMeta Instance = new EstimatedProductCostMeta();

		public global::Allors.Meta.Interface ObjectType = global::Allors.Meta.Interfaces.EstimatedProductCost;

		public global::Allors.Meta.RoleType Cost 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EstimatedProductCostCost;
			}
		} 
		public global::Allors.Meta.RoleType Currency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EstimatedProductCostCurrency;
			}
		} 
		public global::Allors.Meta.RoleType Organisation 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EstimatedProductCostOrganisation;
			}
		} 
		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EstimatedProductCostDescription;
			}
		} 
		public global::Allors.Meta.RoleType GeographicBoundary 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EstimatedProductCostGeographicBoundary;
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

		public global::Allors.Meta.AssociationType ProductWhereEstimatedProductCost 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductEstimatedProductCost;
			}
		} 
		public global::Allors.Meta.AssociationType ProductFeatureWhereEstimatedProductCost 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductFeatureEstimatedProductCost;
			}
		} 

	}
}