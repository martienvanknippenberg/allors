// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class BudgetRevision : Allors.ObjectBase , Searchable, UserInterfaceable
	{
		public static readonly BudgetRevisionMeta Meta = BudgetRevisionMeta.Instance;

		public BudgetRevision(Allors.IStrategy allors) : base(allors) {}

		public static BudgetRevision Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (BudgetRevision) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.DateTime RevisionDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.RevisionDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.RevisionDate, value);
			}
		}

		virtual public bool ExistRevisionDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.RevisionDate);
			}
		}

		virtual public void RemoveRevisionDate()
		{
			Strategy.RemoveUnitRole(Meta.RevisionDate);
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



		virtual public global::Allors.Extent<BudgetRevisionImpact> BudgetRevisionImpactsWhereBudgetRevision
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.BudgetRevisionImpactsWhereBudgetRevision);
			}
		}

		virtual public bool ExistBudgetRevisionImpactsWhereBudgetRevision
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.BudgetRevisionImpactsWhereBudgetRevision);
			}
		}


		virtual public Budget BudgetWhereBudgetRevision
		{ 
			get
			{
				return (Budget) Strategy.GetCompositeAssociation(Meta.BudgetWhereBudgetRevision);
			}
		} 

		virtual public bool ExistBudgetWhereBudgetRevision
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.BudgetWhereBudgetRevision);
			}
		}

	}

	public class BudgetRevisionMeta
	{
		public static readonly BudgetRevisionMeta Instance = new BudgetRevisionMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.BudgetRevision;

		public global::Allors.Meta.RoleType RevisionDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BudgetRevisionRevisionDate;
			}
		} 
		public global::Allors.Meta.RoleType SearchData 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SearchableSearchData;
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

		public global::Allors.Meta.AssociationType BudgetRevisionImpactsWhereBudgetRevision 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.BudgetRevisionImpactBudgetRevision;
			}
		} 
		public global::Allors.Meta.AssociationType BudgetWhereBudgetRevision 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.BudgetBudgetRevision;
			}
		} 

	}
}