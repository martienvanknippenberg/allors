// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class InventoryItemVariance : Allors.ObjectBase , Searchable, UserInterfaceable, Commentable
	{
		public static readonly InventoryItemVarianceMeta Meta = InventoryItemVarianceMeta.Instance;

		public InventoryItemVariance(Allors.IStrategy allors) : base(allors) {}

		public static InventoryItemVariance Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (InventoryItemVariance) allorsSession.Instantiate(allorsObjectId);		
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


		virtual public ItemVarianceAccountingTransaction ItemVarianceAccountingTransaction
		{ 
			get
			{
				return (ItemVarianceAccountingTransaction) Strategy.GetCompositeRole(Meta.ItemVarianceAccountingTransaction);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.ItemVarianceAccountingTransaction ,value);
			}
		}

		virtual public bool ExistItemVarianceAccountingTransaction
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.ItemVarianceAccountingTransaction);
			}
		}

		virtual public void RemoveItemVarianceAccountingTransaction()
		{
			Strategy.RemoveCompositeRole(Meta.ItemVarianceAccountingTransaction);
		}



		virtual public global::System.DateTime InventoryDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.InventoryDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.InventoryDate, value);
			}
		}

		virtual public bool ExistInventoryDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.InventoryDate);
			}
		}

		virtual public void RemoveInventoryDate()
		{
			Strategy.RemoveUnitRole(Meta.InventoryDate);
		}


		virtual public VarianceReason Reason
		{ 
			get
			{
				return (VarianceReason) Strategy.GetCompositeRole(Meta.Reason);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Reason ,value);
			}
		}

		virtual public bool ExistReason
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Reason);
			}
		}

		virtual public void RemoveReason()
		{
			Strategy.RemoveCompositeRole(Meta.Reason);
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



		virtual public InventoryItem InventoryItemWhereInventoryItemVariance
		{ 
			get
			{
				return (InventoryItem) Strategy.GetCompositeAssociation(Meta.InventoryItemWhereInventoryItemVariance);
			}
		} 

		virtual public bool ExistInventoryItemWhereInventoryItemVariance
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.InventoryItemWhereInventoryItemVariance);
			}
		}

	}

	public class InventoryItemVarianceMeta
	{
		public static readonly InventoryItemVarianceMeta Instance = new InventoryItemVarianceMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.InventoryItemVariance;

		public global::Allors.Meta.RoleType Quantity 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InventoryItemVarianceQuantity;
			}
		} 
		public global::Allors.Meta.RoleType ItemVarianceAccountingTransaction 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InventoryItemVarianceItemVarianceAccountingTransaction;
			}
		} 
		public global::Allors.Meta.RoleType InventoryDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InventoryItemVarianceInventoryDate;
			}
		} 
		public global::Allors.Meta.RoleType Reason 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InventoryItemVarianceReason;
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
		public global::Allors.Meta.RoleType Comment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommentableComment;
			}
		} 

		public global::Allors.Meta.AssociationType InventoryItemWhereInventoryItemVariance 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InventoryItemInventoryItemVariance;
			}
		} 

	}
}