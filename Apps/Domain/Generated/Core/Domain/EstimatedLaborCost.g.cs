// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class EstimatedLaborCost : Allors.ObjectBase , EstimatedProductCost
	{
		public static readonly EstimatedLaborCostMeta Meta = EstimatedLaborCostMeta.Instance;

		public EstimatedLaborCost(Allors.IStrategy allors) : base(allors) {}

		public static EstimatedLaborCost Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (EstimatedLaborCost) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.Decimal Cost 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.Cost);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Cost, value);
			}
		}

		virtual public bool ExistCost{
			get
			{
				return Strategy.ExistUnitRole(Meta.Cost);
			}
		}

		virtual public void RemoveCost()
		{
			Strategy.RemoveUnitRole(Meta.Cost);
		}


		virtual public Currency Currency
		{ 
			get
			{
				return (Currency) Strategy.GetCompositeRole(Meta.Currency);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Currency ,value);
			}
		}

		virtual public bool ExistCurrency
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Currency);
			}
		}

		virtual public void RemoveCurrency()
		{
			Strategy.RemoveCompositeRole(Meta.Currency);
		}


		virtual public Organisation Organisation
		{ 
			get
			{
				return (Organisation) Strategy.GetCompositeRole(Meta.Organisation);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Organisation ,value);
			}
		}

		virtual public bool ExistOrganisation
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Organisation);
			}
		}

		virtual public void RemoveOrganisation()
		{
			Strategy.RemoveCompositeRole(Meta.Organisation);
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


		virtual public GeographicBoundary GeographicBoundary
		{ 
			get
			{
				return (GeographicBoundary) Strategy.GetCompositeRole(Meta.GeographicBoundary);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.GeographicBoundary ,value);
			}
		}

		virtual public bool ExistGeographicBoundary
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.GeographicBoundary);
			}
		}

		virtual public void RemoveGeographicBoundary()
		{
			Strategy.RemoveCompositeRole(Meta.GeographicBoundary);
		}



		virtual public global::System.DateTime FromDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.FromDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.FromDate, value);
			}
		}

		virtual public bool ExistFromDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.FromDate);
			}
		}

		virtual public void RemoveFromDate()
		{
			Strategy.RemoveUnitRole(Meta.FromDate);
		}



		virtual public global::System.DateTime ThroughDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.ThroughDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ThroughDate, value);
			}
		}

		virtual public bool ExistThroughDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.ThroughDate);
			}
		}

		virtual public void RemoveThroughDate()
		{
			Strategy.RemoveUnitRole(Meta.ThroughDate);
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



		virtual public Product ProductWhereEstimatedProductCost
		{ 
			get
			{
				return (Product) Strategy.GetCompositeAssociation(Meta.ProductWhereEstimatedProductCost);
			}
		} 

		virtual public bool ExistProductWhereEstimatedProductCost
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.ProductWhereEstimatedProductCost);
			}
		}


		virtual public ProductFeature ProductFeatureWhereEstimatedProductCost
		{ 
			get
			{
				return (ProductFeature) Strategy.GetCompositeAssociation(Meta.ProductFeatureWhereEstimatedProductCost);
			}
		} 

		virtual public bool ExistProductFeatureWhereEstimatedProductCost
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.ProductFeatureWhereEstimatedProductCost);
			}
		}

	}

	public class EstimatedLaborCostMeta
	{
		public static readonly EstimatedLaborCostMeta Instance = new EstimatedLaborCostMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.EstimatedLaborCost;

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