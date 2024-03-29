// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class CostCenterCategory : Allors.ObjectBase , Searchable, UserInterfaceable, SearchResult, AccessControlledObject, UniquelyIdentifiable
	{
		public static readonly CostCenterCategoryMeta Meta = CostCenterCategoryMeta.Instance;

		public CostCenterCategory(Allors.IStrategy allors) : base(allors) {}

		public static CostCenterCategory Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (CostCenterCategory) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public CostCenterCategory Parent
		{ 
			get
			{
				return (CostCenterCategory) Strategy.GetCompositeRole(Meta.Parent);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Parent ,value);
			}
		}

		virtual public bool ExistParent
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Parent);
			}
		}

		virtual public void RemoveParent()
		{
			Strategy.RemoveCompositeRole(Meta.Parent);
		}


		virtual public global::Allors.Extent<CostCenterCategory> Ancestors
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.Ancestor);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.Ancestor, value);
			}
		}

		virtual public void AddAncestor (CostCenterCategory value)
		{
			Strategy.AddCompositeRole(Meta.Ancestor, value);
		}

		virtual public void RemoveAncestor (CostCenterCategory value)
		{
			Strategy.RemoveCompositeRole(Meta.Ancestor,value);
		}

		virtual public bool ExistAncestors
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.Ancestor);
			}
		}

		virtual public void RemoveAncestors()
		{
			Strategy.RemoveCompositeRoles(Meta.Ancestor);
		}


		virtual public global::Allors.Extent<CostCenterCategory> Children
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.Child);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.Child, value);
			}
		}

		virtual public void AddChild (CostCenterCategory value)
		{
			Strategy.AddCompositeRole(Meta.Child, value);
		}

		virtual public void RemoveChild (CostCenterCategory value)
		{
			Strategy.RemoveCompositeRole(Meta.Child,value);
		}

		virtual public bool ExistChildren
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.Child);
			}
		}

		virtual public void RemoveChildren()
		{
			Strategy.RemoveCompositeRoles(Meta.Child);
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



		virtual public global::System.Guid UniqueId 
		{
			get
			{
				return (global::System.Guid) Strategy.GetUnitRole(Meta.UniqueId);
			}
			set
			{
				Strategy.SetUnitRole(Meta.UniqueId, value);
			}
		}

		virtual public bool ExistUniqueId{
			get
			{
				return Strategy.ExistUnitRole(Meta.UniqueId);
			}
		}

		virtual public void RemoveUniqueId()
		{
			Strategy.RemoveUnitRole(Meta.UniqueId);
		}



		virtual public global::Allors.Extent<CostCenterCategory> CostCenterCategoriesWhereParent
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.CostCenterCategoriesWhereParent);
			}
		}

		virtual public bool ExistCostCenterCategoriesWhereParent
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.CostCenterCategoriesWhereParent);
			}
		}


		virtual public global::Allors.Extent<CostCenterCategory> CostCenterCategoriesWhereAncestor
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.CostCenterCategoriesWhereAncestor);
			}
		}

		virtual public bool ExistCostCenterCategoriesWhereAncestor
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.CostCenterCategoriesWhereAncestor);
			}
		}


		virtual public global::Allors.Extent<CostCenterCategory> CostCenterCategoriesWhereChild
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.CostCenterCategoriesWhereChild);
			}
		}

		virtual public bool ExistCostCenterCategoriesWhereChild
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.CostCenterCategoriesWhereChild);
			}
		}


		virtual public global::Allors.Extent<CostCenter> CostCentersWhereCostCenterCategory
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.CostCentersWhereCostCenterCategory);
			}
		}

		virtual public bool ExistCostCentersWhereCostCenterCategory
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.CostCentersWhereCostCenterCategory);
			}
		}

	}

	public class CostCenterCategoryMeta
	{
		public static readonly CostCenterCategoryMeta Instance = new CostCenterCategoryMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.CostCenterCategory;

		public global::Allors.Meta.RoleType Parent 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CostCenterCategoryParent;
			}
		} 
		public global::Allors.Meta.RoleType Ancestor 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CostCenterCategoryAncestor;
			}
		} 
		public global::Allors.Meta.RoleType Child 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CostCenterCategoryChild;
			}
		} 
		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CostCenterCategoryDescription;
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
		public global::Allors.Meta.RoleType UniqueId 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UniquelyIdentifiableUniqueId;
			}
		} 

		public global::Allors.Meta.AssociationType CostCenterCategoriesWhereParent 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CostCenterCategoryParent;
			}
		} 
		public global::Allors.Meta.AssociationType CostCenterCategoriesWhereAncestor 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CostCenterCategoryAncestor;
			}
		} 
		public global::Allors.Meta.AssociationType CostCenterCategoriesWhereChild 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CostCenterCategoryChild;
			}
		} 
		public global::Allors.Meta.AssociationType CostCentersWhereCostCenterCategory 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CostCenterCostCenterCategory;
			}
		} 

	}
}