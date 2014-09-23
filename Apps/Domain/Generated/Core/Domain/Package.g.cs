// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class Package : Allors.ObjectBase , UniquelyIdentifiable, UserInterfaceable, Searchable
	{
		public static readonly PackageMeta Meta = PackageMeta.Instance;

		public Package(Allors.IStrategy allors) : base(allors) {}

		public static Package Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (Package) allorsSession.Instantiate(allorsObjectId);		
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



		virtual public global::System.Guid? UniqueId 
		{
			get
			{
				return (global::System.Guid?) Strategy.GetUnitRole(Meta.UniqueId);
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



		virtual public global::Allors.Extent<PartyPackageRevenueHistory> PartyPackageRevenueHistoriesWherePackage
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartyPackageRevenueHistoriesWherePackage);
			}
		}

		virtual public bool ExistPartyPackageRevenueHistoriesWherePackage
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartyPackageRevenueHistoriesWherePackage);
			}
		}


		virtual public global::Allors.Extent<PackageRevenue> PackageRevenuesWherePackage
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PackageRevenuesWherePackage);
			}
		}

		virtual public bool ExistPackageRevenuesWherePackage
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PackageRevenuesWherePackage);
			}
		}


		virtual public global::Allors.Extent<PartyPackageRevenue> PartyPackageRevenuesWherePackage
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartyPackageRevenuesWherePackage);
			}
		}

		virtual public bool ExistPartyPackageRevenuesWherePackage
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartyPackageRevenuesWherePackage);
			}
		}


		virtual public global::Allors.Extent<PackageRevenueHistory> PackageRevenueHistoriesWherePackage
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PackageRevenueHistoriesWherePackage);
			}
		}

		virtual public bool ExistPackageRevenueHistoriesWherePackage
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PackageRevenueHistoriesWherePackage);
			}
		}


		virtual public global::Allors.Extent<ProductCategory> ProductCategoriesWherePackage
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductCategoriesWherePackage);
			}
		}

		virtual public bool ExistProductCategoriesWherePackage
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductCategoriesWherePackage);
			}
		}

	}

	public class PackageMeta
	{
		public static readonly PackageMeta Instance = new PackageMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.Package;

		public global::Allors.Meta.RoleType Name 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PackageName;
			}
		} 
		public global::Allors.Meta.RoleType UniqueId 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UniquelyIdentifiableUniqueId;
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

		public global::Allors.Meta.AssociationType PartyPackageRevenueHistoriesWherePackage 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyPackageRevenueHistoryPackage;
			}
		} 
		public global::Allors.Meta.AssociationType PackageRevenuesWherePackage 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PackageRevenuePackage;
			}
		} 
		public global::Allors.Meta.AssociationType PartyPackageRevenuesWherePackage 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyPackageRevenuePackage;
			}
		} 
		public global::Allors.Meta.AssociationType PackageRevenueHistoriesWherePackage 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PackageRevenueHistoryPackage;
			}
		} 
		public global::Allors.Meta.AssociationType ProductCategoriesWherePackage 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductCategoryPackage;
			}
		} 

	}
}