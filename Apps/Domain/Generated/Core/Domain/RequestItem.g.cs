// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class RequestItem : Allors.ObjectBase , UserInterfaceable, Commentable
	{
		public static readonly RequestItemMeta Meta = RequestItemMeta.Instance;

		public RequestItem(Allors.IStrategy allors) : base(allors) {}

		public static RequestItem Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (RequestItem) allorsSession.Instantiate(allorsObjectId);		
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



		virtual public global::System.Int32 Quantity 
		{
			get
			{
				return (global::System.Int32) Strategy.GetUnitRole(Meta.Quantity);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Quantity, value);
			}
		}

		virtual public bool ExistQuantity{
			get
			{
				return Strategy.ExistUnitRole(Meta.Quantity);
			}
		}

		virtual public void RemoveQuantity()
		{
			Strategy.RemoveUnitRole(Meta.Quantity);
		}


		virtual public global::Allors.Extent<Requirement> Requirements
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.Requirement);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.Requirement, value);
			}
		}

		virtual public void AddRequirement (Requirement value)
		{
			Strategy.AddCompositeRole(Meta.Requirement, value);
		}

		virtual public void RemoveRequirement (Requirement value)
		{
			Strategy.RemoveCompositeRole(Meta.Requirement,value);
		}

		virtual public bool ExistRequirements
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.Requirement);
			}
		}

		virtual public void RemoveRequirements()
		{
			Strategy.RemoveCompositeRoles(Meta.Requirement);
		}


		virtual public Deliverable Deliverable
		{ 
			get
			{
				return (Deliverable) Strategy.GetCompositeRole(Meta.Deliverable);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Deliverable ,value);
			}
		}

		virtual public bool ExistDeliverable
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Deliverable);
			}
		}

		virtual public void RemoveDeliverable()
		{
			Strategy.RemoveCompositeRole(Meta.Deliverable);
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


		virtual public NeededSkill NeededSkill
		{ 
			get
			{
				return (NeededSkill) Strategy.GetCompositeRole(Meta.NeededSkill);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.NeededSkill ,value);
			}
		}

		virtual public bool ExistNeededSkill
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.NeededSkill);
			}
		}

		virtual public void RemoveNeededSkill()
		{
			Strategy.RemoveCompositeRole(Meta.NeededSkill);
		}


		virtual public Product Product
		{ 
			get
			{
				return (Product) Strategy.GetCompositeRole(Meta.Product);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Product ,value);
			}
		}

		virtual public bool ExistProduct
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Product);
			}
		}

		virtual public void RemoveProduct()
		{
			Strategy.RemoveCompositeRole(Meta.Product);
		}



		virtual public global::System.Decimal MaximumAllowedPrice 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.MaximumAllowedPrice);
			}
			set
			{
				Strategy.SetUnitRole(Meta.MaximumAllowedPrice, value);
			}
		}

		virtual public bool ExistMaximumAllowedPrice{
			get
			{
				return Strategy.ExistUnitRole(Meta.MaximumAllowedPrice);
			}
		}

		virtual public void RemoveMaximumAllowedPrice()
		{
			Strategy.RemoveUnitRole(Meta.MaximumAllowedPrice);
		}



		virtual public global::System.DateTime RequiredByDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.RequiredByDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.RequiredByDate, value);
			}
		}

		virtual public bool ExistRequiredByDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.RequiredByDate);
			}
		}

		virtual public void RemoveRequiredByDate()
		{
			Strategy.RemoveUnitRole(Meta.RequiredByDate);
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



		virtual public global::System.String Comment 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Comment);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Comment, value);
			}
		}

		virtual public bool ExistComment{
			get
			{
				return Strategy.ExistUnitRole(Meta.Comment);
			}
		}

		virtual public void RemoveComment()
		{
			Strategy.RemoveUnitRole(Meta.Comment);
		}



		virtual public global::Allors.Extent<QuoteItem> QuoteItemsWhereRequestItem
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.QuoteItemsWhereRequestItem);
			}
		}

		virtual public bool ExistQuoteItemsWhereRequestItem
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.QuoteItemsWhereRequestItem);
			}
		}


		virtual public Request RequestWhereRequestItem
		{ 
			get
			{
				return (Request) Strategy.GetCompositeAssociation(Meta.RequestWhereRequestItem);
			}
		} 

		virtual public bool ExistRequestWhereRequestItem
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.RequestWhereRequestItem);
			}
		}

	}

	public class RequestItemMeta
	{
		public static readonly RequestItemMeta Instance = new RequestItemMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.RequestItem;

		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.RequestItemDescription;
			}
		} 
		public global::Allors.Meta.RoleType Quantity 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.RequestItemQuantity;
			}
		} 
		public global::Allors.Meta.RoleType Requirement 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.RequestItemRequirement;
			}
		} 
		public global::Allors.Meta.RoleType Deliverable 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.RequestItemDeliverable;
			}
		} 
		public global::Allors.Meta.RoleType ProductFeature 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.RequestItemProductFeature;
			}
		} 
		public global::Allors.Meta.RoleType NeededSkill 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.RequestItemNeededSkill;
			}
		} 
		public global::Allors.Meta.RoleType Product 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.RequestItemProduct;
			}
		} 
		public global::Allors.Meta.RoleType MaximumAllowedPrice 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.RequestItemMaximumAllowedPrice;
			}
		} 
		public global::Allors.Meta.RoleType RequiredByDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.RequestItemRequiredByDate;
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
		public global::Allors.Meta.RoleType Comment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommentableComment;
			}
		} 

		public global::Allors.Meta.AssociationType QuoteItemsWhereRequestItem 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.QuoteItemRequestItem;
			}
		} 
		public global::Allors.Meta.AssociationType RequestWhereRequestItem 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.RequestRequestItem;
			}
		} 

	}
}