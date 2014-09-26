// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class GlBudgetAllocation : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly GlBudgetAllocationMeta Meta = GlBudgetAllocationMeta.Instance;

		public GlBudgetAllocation(Allors.IStrategy allors) : base(allors) {}

		public static GlBudgetAllocation Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (GlBudgetAllocation) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public GeneralLedgerAccount GeneralLedgerAccount
		{ 
			get
			{
				return (GeneralLedgerAccount) Strategy.GetCompositeRole(Meta.GeneralLedgerAccount);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.GeneralLedgerAccount ,value);
			}
		}

		virtual public bool ExistGeneralLedgerAccount
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.GeneralLedgerAccount);
			}
		}

		virtual public void RemoveGeneralLedgerAccount()
		{
			Strategy.RemoveCompositeRole(Meta.GeneralLedgerAccount);
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



		virtual public global::System.Decimal AllocationPercentage 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.AllocationPercentage);
			}
			set
			{
				Strategy.SetUnitRole(Meta.AllocationPercentage, value);
			}
		}

		virtual public bool ExistAllocationPercentage{
			get
			{
				return Strategy.ExistUnitRole(Meta.AllocationPercentage);
			}
		}

		virtual public void RemoveAllocationPercentage()
		{
			Strategy.RemoveUnitRole(Meta.AllocationPercentage);
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

	public class GlBudgetAllocationMeta
	{
		public static readonly GlBudgetAllocationMeta Instance = new GlBudgetAllocationMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.GlBudgetAllocation;

		public global::Allors.Meta.RoleType GeneralLedgerAccount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.GlBudgetAllocationGeneralLedgerAccount;
			}
		} 
		public global::Allors.Meta.RoleType BudgetItem 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.GlBudgetAllocationBudgetItem;
			}
		} 
		public global::Allors.Meta.RoleType AllocationPercentage 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.GlBudgetAllocationAllocationPercentage;
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