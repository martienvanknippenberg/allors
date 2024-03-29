// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class DesiredProductFeature : Allors.ObjectBase , UserInterfaceable, Searchable
	{
		public static readonly DesiredProductFeatureMeta Meta = DesiredProductFeatureMeta.Instance;

		public DesiredProductFeature(Allors.IStrategy allors) : base(allors) {}

		public static DesiredProductFeature Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (DesiredProductFeature) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.Boolean Required 
		{
			get
			{
				return (global::System.Boolean) Strategy.GetUnitRole(Meta.Required);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Required, value);
			}
		}

		virtual public bool ExistRequired{
			get
			{
				return Strategy.ExistUnitRole(Meta.Required);
			}
		}

		virtual public void RemoveRequired()
		{
			Strategy.RemoveUnitRole(Meta.Required);
		}


		virtual public ProductFeature ProductFeature
		{ 
			get
			{
				return (ProductFeature) Strategy.GetCompositeRole(Meta.ProductFeature);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.ProductFeature ,value);
			}
		}

		virtual public bool ExistProductFeature
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.ProductFeature);
			}
		}

		virtual public void RemoveProductFeature()
		{
			Strategy.RemoveCompositeRole(Meta.ProductFeature);
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



		virtual public global::Allors.Extent<ProductRequirement> ProductRequirementsWhereDesiredProductFeature
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductRequirementsWhereDesiredProductFeature);
			}
		}

		virtual public bool ExistProductRequirementsWhereDesiredProductFeature
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductRequirementsWhereDesiredProductFeature);
			}
		}

	}

	public class DesiredProductFeatureMeta
	{
		public static readonly DesiredProductFeatureMeta Instance = new DesiredProductFeatureMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.DesiredProductFeature;

		public global::Allors.Meta.RoleType Required 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.DesiredProductFeatureRequired;
			}
		} 
		public global::Allors.Meta.RoleType ProductFeature 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.DesiredProductFeatureProductFeature;
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

		public global::Allors.Meta.AssociationType ProductRequirementsWhereDesiredProductFeature 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductRequirementDesiredProductFeature;
			}
		} 

	}
}