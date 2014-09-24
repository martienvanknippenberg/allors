// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class BudgetRevisionImpact : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly BudgetRevisionImpactMeta Meta = BudgetRevisionImpactMeta.Instance;

		public BudgetRevisionImpact(Allors.IStrategy allors) : base(allors) {}

		public static BudgetRevisionImpact Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (BudgetRevisionImpact) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public BudgetItem BudgetItem
		{ 
			get
			{
				return (BudgetItem) Strategy.GetCompositeRole(Meta.BudgetItem);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.BudgetItem ,value);
			}
		}

		virtual public bool ExistBudgetItem
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.BudgetItem);
			}
		}

		virtual public void RemoveBudgetItem()
		{
			Strategy.RemoveCompositeRole(Meta.BudgetItem);
		}



		virtual public global::System.String Reason 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Reason);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Reason, value);
			}
		}

		virtual public bool ExistReason{
			get
			{
				return Strategy.ExistUnitRole(Meta.Reason);
			}
		}

		virtual public void RemoveReason()
		{
			Strategy.RemoveUnitRole(Meta.Reason);
		}



		virtual public global::System.Boolean Deleted 
		{
			get
			{
				return (global::System.Boolean) Strategy.GetUnitRole(Meta.Deleted);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Deleted, value);
			}
		}

		virtual public bool ExistDeleted{
			get
			{
				return Strategy.ExistUnitRole(Meta.Deleted);
			}
		}

		virtual public void RemoveDeleted()
		{
			Strategy.RemoveUnitRole(Meta.Deleted);
		}



		virtual public global::System.Boolean Added 
		{
			get
			{
				return (global::System.Boolean) Strategy.GetUnitRole(Meta.Added);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Added, value);
			}
		}

		virtual public bool ExistAdded{
			get
			{
				return Strategy.ExistUnitRole(Meta.Added);
			}
		}

		virtual public void RemoveAdded()
		{
			Strategy.RemoveUnitRole(Meta.Added);
		}



		virtual public global::System.Decimal RevisedAmount 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.RevisedAmount);
			}
			set
			{
				Strategy.SetUnitRole(Meta.RevisedAmount, value);
			}
		}

		virtual public bool ExistRevisedAmount{
			get
			{
				return Strategy.ExistUnitRole(Meta.RevisedAmount);
			}
		}

		virtual public void RemoveRevisedAmount()
		{
			Strategy.RemoveUnitRole(Meta.RevisedAmount);
		}


		virtual public BudgetRevision BudgetRevision
		{ 
			get
			{
				return (BudgetRevision) Strategy.GetCompositeRole(Meta.BudgetRevision);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.BudgetRevision ,value);
			}
		}

		virtual public bool ExistBudgetRevision
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.BudgetRevision);
			}
		}

		virtual public void RemoveBudgetRevision()
		{
			Strategy.RemoveCompositeRole(Meta.BudgetRevision);
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

	}

	public class BudgetRevisionImpactMeta
	{
		public static readonly BudgetRevisionImpactMeta Instance = new BudgetRevisionImpactMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.BudgetRevisionImpact;

		public global::Allors.Meta.RoleType BudgetItem 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BudgetRevisionImpactBudgetItem;
			}
		} 
		public global::Allors.Meta.RoleType Reason 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BudgetRevisionImpactReason;
			}
		} 
		public global::Allors.Meta.RoleType Deleted 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BudgetRevisionImpactDeleted;
			}
		} 
		public global::Allors.Meta.RoleType Added 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BudgetRevisionImpactAdded;
			}
		} 
		public global::Allors.Meta.RoleType RevisedAmount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BudgetRevisionImpactRevisedAmount;
			}
		} 
		public global::Allors.Meta.RoleType BudgetRevision 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BudgetRevisionImpactBudgetRevision;
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

	}
}