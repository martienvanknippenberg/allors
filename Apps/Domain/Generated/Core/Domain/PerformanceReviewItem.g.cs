// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class PerformanceReviewItem : Allors.ObjectBase , Commentable, UserInterfaceable
	{
		public static readonly PerformanceReviewItemMeta Meta = PerformanceReviewItemMeta.Instance;

		public PerformanceReviewItem(Allors.IStrategy allors) : base(allors) {}

		public static PerformanceReviewItem Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (PerformanceReviewItem) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public RatingType RatingType
		{ 
			get
			{
				return (RatingType) Strategy.GetCompositeRole(Meta.RatingType);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.RatingType ,value);
			}
		}

		virtual public bool ExistRatingType
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.RatingType);
			}
		}

		virtual public void RemoveRatingType()
		{
			Strategy.RemoveCompositeRole(Meta.RatingType);
		}


		virtual public PerformanceReviewItemType PerformanceReviewItemType
		{ 
			get
			{
				return (PerformanceReviewItemType) Strategy.GetCompositeRole(Meta.PerformanceReviewItemType);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.PerformanceReviewItemType ,value);
			}
		}

		virtual public bool ExistPerformanceReviewItemType
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.PerformanceReviewItemType);
			}
		}

		virtual public void RemovePerformanceReviewItemType()
		{
			Strategy.RemoveCompositeRole(Meta.PerformanceReviewItemType);
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



		virtual public PerformanceReview PerformanceReviewWherePerformanceReviewItem
		{ 
			get
			{
				return (PerformanceReview) Strategy.GetCompositeAssociation(Meta.PerformanceReviewWherePerformanceReviewItem);
			}
		} 

		virtual public bool ExistPerformanceReviewWherePerformanceReviewItem
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.PerformanceReviewWherePerformanceReviewItem);
			}
		}

	}

	public class PerformanceReviewItemMeta
	{
		public static readonly PerformanceReviewItemMeta Instance = new PerformanceReviewItemMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.PerformanceReviewItem;

		public global::Allors.Meta.RoleType RatingType 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PerformanceReviewItemRatingType;
			}
		} 
		public global::Allors.Meta.RoleType PerformanceReviewItemType 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PerformanceReviewItemPerformanceReviewItemType;
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

		public global::Allors.Meta.AssociationType PerformanceReviewWherePerformanceReviewItem 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PerformanceReviewPerformanceReviewItem;
			}
		} 

	}
}