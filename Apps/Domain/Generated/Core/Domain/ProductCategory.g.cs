// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class ProductCategory : Allors.ObjectBase , UserInterfaceable, Searchable, SearchResult, UniquelyIdentifiable
	{
		public static readonly ProductCategoryMeta Meta = ProductCategoryMeta.Instance;

		public ProductCategory(Allors.IStrategy allors) : base(allors) {}

		public static ProductCategory Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (ProductCategory) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public Package Package
		{ 
			get
			{
				return (Package) Strategy.GetCompositeRole(Meta.Package);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Package ,value);
			}
		}

		virtual public bool ExistPackage
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Package);
			}
		}

		virtual public void RemovePackage()
		{
			Strategy.RemoveCompositeRole(Meta.Package);
		}



		virtual public global::System.String Code 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Code);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Code, value);
			}
		}

		virtual public bool ExistCode{
			get
			{
				return Strategy.ExistUnitRole(Meta.Code);
			}
		}

		virtual public void RemoveCode()
		{
			Strategy.RemoveUnitRole(Meta.Code);
		}


		virtual public Media NoImageAvailableImage
		{ 
			get
			{
				return (Media) Strategy.GetCompositeRole(Meta.NoImageAvailableImage);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.NoImageAvailableImage ,value);
			}
		}

		virtual public bool ExistNoImageAvailableImage
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.NoImageAvailableImage);
			}
		}

		virtual public void RemoveNoImageAvailableImage()
		{
			Strategy.RemoveCompositeRole(Meta.NoImageAvailableImage);
		}


		virtual public global::Allors.Extent<ProductCategory> Parents
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.Parent);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.Parent, value);
			}
		}

		virtual public void AddParent (ProductCategory value)
		{
			Strategy.AddCompositeRole(Meta.Parent, value);
		}

		virtual public void RemoveParent (ProductCategory value)
		{
			Strategy.RemoveCompositeRole(Meta.Parent,value);
		}

		virtual public bool ExistParents
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.Parent);
			}
		}

		virtual public void RemoveParents()
		{
			Strategy.RemoveCompositeRoles(Meta.Parent);
		}


		virtual public global::Allors.Extent<ProductCategory> Children
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

		virtual public void AddChild (ProductCategory value)
		{
			Strategy.AddCompositeRole(Meta.Child, value);
		}

		virtual public void RemoveChild (ProductCategory value)
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



		virtual public global::System.String Name 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Name);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Name, value);
			}
		}

		virtual public bool ExistName{
			get
			{
				return Strategy.ExistUnitRole(Meta.Name);
			}
		}

		virtual public void RemoveName()
		{
			Strategy.RemoveUnitRole(Meta.Name);
		}


		virtual public Media CategoryImage
		{ 
			get
			{
				return (Media) Strategy.GetCompositeRole(Meta.CategoryImage);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.CategoryImage ,value);
			}
		}

		virtual public bool ExistCategoryImage
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.CategoryImage);
			}
		}

		virtual public void RemoveCategoryImage()
		{
			Strategy.RemoveCompositeRole(Meta.CategoryImage);
		}


		virtual public global::Allors.Extent<ProductCategory> Ancestors
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

		virtual public void AddAncestor (ProductCategory value)
		{
			Strategy.AddCompositeRole(Meta.Ancestor, value);
		}

		virtual public void RemoveAncestor (ProductCategory value)
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



		virtual public global::Allors.Extent<SalesRepPartyProductCategoryRevenue> SalesRepPartyProductCategoryRevenuesWhereProductCategory
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesRepPartyProductCategoryRevenuesWhereProductCategory);
			}
		}

		virtual public bool ExistSalesRepPartyProductCategoryRevenuesWhereProductCategory
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesRepPartyProductCategoryRevenuesWhereProductCategory);
			}
		}


		virtual public global::Allors.Extent<PartyProductCategoryRevenueHistory> PartyProductCategoryRevenueHistoriesWhereProductCategory
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartyProductCategoryRevenueHistoriesWhereProductCategory);
			}
		}

		virtual public bool ExistPartyProductCategoryRevenueHistoriesWhereProductCategory
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartyProductCategoryRevenueHistoriesWhereProductCategory);
			}
		}


		virtual public global::Allors.Extent<Brand> BrandsWhereProductCategory
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.BrandsWhereProductCategory);
			}
		}

		virtual public bool ExistBrandsWhereProductCategory
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.BrandsWhereProductCategory);
			}
		}


		virtual public global::Allors.Extent<ProductCategoryRevenueHistory> ProductCategoryRevenueHistoriesWhereProductCategory
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductCategoryRevenueHistoriesWhereProductCategory);
			}
		}

		virtual public bool ExistProductCategoryRevenueHistoriesWhereProductCategory
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductCategoryRevenueHistoriesWhereProductCategory);
			}
		}


		virtual public global::Allors.Extent<PriceComponent> PriceComponentsWhereProductCategory
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PriceComponentsWhereProductCategory);
			}
		}

		virtual public bool ExistPriceComponentsWhereProductCategory
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PriceComponentsWhereProductCategory);
			}
		}


		virtual public global::Allors.Extent<PartyProductCategoryRevenue> PartyProductCategoryRevenuesWhereProductCategory
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartyProductCategoryRevenuesWhereProductCategory);
			}
		}

		virtual public bool ExistPartyProductCategoryRevenuesWhereProductCategory
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartyProductCategoryRevenuesWhereProductCategory);
			}
		}


		virtual public global::Allors.Extent<Product> ProductsWherePrimaryProductCategory
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductsWherePrimaryProductCategory);
			}
		}

		virtual public bool ExistProductsWherePrimaryProductCategory
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductsWherePrimaryProductCategory);
			}
		}


		virtual public global::Allors.Extent<Product> ProductsWhereProductCategoryExpanded
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductsWhereProductCategoryExpanded);
			}
		}

		virtual public bool ExistProductsWhereProductCategoryExpanded
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductsWhereProductCategoryExpanded);
			}
		}


		virtual public global::Allors.Extent<Product> ProductsWhereProductCategory
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductsWhereProductCategory);
			}
		}

		virtual public bool ExistProductsWhereProductCategory
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductsWhereProductCategory);
			}
		}


		virtual public global::Allors.Extent<OrganisationGlAccount> OrganisationGlAccountsWhereProductCategory
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.OrganisationGlAccountsWhereProductCategory);
			}
		}

		virtual public bool ExistOrganisationGlAccountsWhereProductCategory
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.OrganisationGlAccountsWhereProductCategory);
			}
		}


		virtual public global::Allors.Extent<InventoryItem> InventoryItemsWhereDerivedProductCategory
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.InventoryItemsWhereDerivedProductCategory);
			}
		}

		virtual public bool ExistInventoryItemsWhereDerivedProductCategory
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.InventoryItemsWhereDerivedProductCategory);
			}
		}


		virtual public global::Allors.Extent<SalesRepRelationship> SalesRepRelationshipsWhereProductCategory
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesRepRelationshipsWhereProductCategory);
			}
		}

		virtual public bool ExistSalesRepRelationshipsWhereProductCategory
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesRepRelationshipsWhereProductCategory);
			}
		}


		virtual public global::Allors.Extent<ProductCategoryRevenue> ProductCategoryRevenuesWhereProductCategory
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductCategoryRevenuesWhereProductCategory);
			}
		}

		virtual public bool ExistProductCategoryRevenuesWhereProductCategory
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductCategoryRevenuesWhereProductCategory);
			}
		}


		virtual public global::Allors.Extent<ProductCategory> ProductCategoriesWhereParent
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductCategoriesWhereParent);
			}
		}

		virtual public bool ExistProductCategoriesWhereParent
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductCategoriesWhereParent);
			}
		}


		virtual public global::Allors.Extent<ProductCategory> ProductCategoriesWhereChild
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductCategoriesWhereChild);
			}
		}

		virtual public bool ExistProductCategoriesWhereChild
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductCategoriesWhereChild);
			}
		}


		virtual public global::Allors.Extent<ProductCategory> ProductCategoriesWhereAncestor
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductCategoriesWhereAncestor);
			}
		}

		virtual public bool ExistProductCategoriesWhereAncestor
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductCategoriesWhereAncestor);
			}
		}


		virtual public global::Allors.Extent<SalesRepProductCategoryRevenue> SalesRepProductCategoryRevenuesWhereProductCategory
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesRepProductCategoryRevenuesWhereProductCategory);
			}
		}

		virtual public bool ExistSalesRepProductCategoryRevenuesWhereProductCategory
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesRepProductCategoryRevenuesWhereProductCategory);
			}
		}

	}

	public class ProductCategoryMeta
	{
		public static readonly ProductCategoryMeta Instance = new ProductCategoryMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.ProductCategory;

		public global::Allors.Meta.RoleType Package 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductCategoryPackage;
			}
		} 
		public global::Allors.Meta.RoleType Code 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductCategoryCode;
			}
		} 
		public global::Allors.Meta.RoleType NoImageAvailableImage 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductCategoryNoImageAvailableImage;
			}
		} 
		public global::Allors.Meta.RoleType Parent 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductCategoryParent;
			}
		} 
		public global::Allors.Meta.RoleType Child 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductCategoryChild;
			}
		} 
		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductCategoryDescription;
			}
		} 
		public global::Allors.Meta.RoleType Name 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductCategoryName;
			}
		} 
		public global::Allors.Meta.RoleType CategoryImage 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductCategoryCategoryImage;
			}
		} 
		public global::Allors.Meta.RoleType Ancestor 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ProductCategoryAncestor;
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
		public global::Allors.Meta.RoleType UniqueId 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UniquelyIdentifiableUniqueId;
			}
		} 

		public global::Allors.Meta.AssociationType SalesRepPartyProductCategoryRevenuesWhereProductCategory 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesRepPartyProductCategoryRevenueProductCategory;
			}
		} 
		public global::Allors.Meta.AssociationType PartyProductCategoryRevenueHistoriesWhereProductCategory 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyProductCategoryRevenueHistoryProductCategory;
			}
		} 
		public global::Allors.Meta.AssociationType BrandsWhereProductCategory 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.BrandProductCategory;
			}
		} 
		public global::Allors.Meta.AssociationType ProductCategoryRevenueHistoriesWhereProductCategory 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductCategoryRevenueHistoryProductCategory;
			}
		} 
		public global::Allors.Meta.AssociationType PriceComponentsWhereProductCategory 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PriceComponentProductCategory;
			}
		} 
		public global::Allors.Meta.AssociationType PartyProductCategoryRevenuesWhereProductCategory 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyProductCategoryRevenueProductCategory;
			}
		} 
		public global::Allors.Meta.AssociationType ProductsWherePrimaryProductCategory 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductPrimaryProductCategory;
			}
		} 
		public global::Allors.Meta.AssociationType ProductsWhereProductCategoryExpanded 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductProductCategoryExpanded;
			}
		} 
		public global::Allors.Meta.AssociationType ProductsWhereProductCategory 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductProductCategory;
			}
		} 
		public global::Allors.Meta.AssociationType OrganisationGlAccountsWhereProductCategory 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.OrganisationGlAccountProductCategory;
			}
		} 
		public global::Allors.Meta.AssociationType InventoryItemsWhereDerivedProductCategory 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InventoryItemDerivedProductCategory;
			}
		} 
		public global::Allors.Meta.AssociationType SalesRepRelationshipsWhereProductCategory 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesRepRelationshipProductCategory;
			}
		} 
		public global::Allors.Meta.AssociationType ProductCategoryRevenuesWhereProductCategory 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductCategoryRevenueProductCategory;
			}
		} 
		public global::Allors.Meta.AssociationType ProductCategoriesWhereParent 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductCategoryParent;
			}
		} 
		public global::Allors.Meta.AssociationType ProductCategoriesWhereChild 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductCategoryChild;
			}
		} 
		public global::Allors.Meta.AssociationType ProductCategoriesWhereAncestor 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductCategoryAncestor;
			}
		} 
		public global::Allors.Meta.AssociationType SalesRepProductCategoryRevenuesWhereProductCategory 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesRepProductCategoryRevenueProductCategory;
			}
		} 

	}
}