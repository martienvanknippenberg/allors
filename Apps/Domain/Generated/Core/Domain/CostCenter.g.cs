// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class CostCenter : Allors.ObjectBase , UserInterfaceable, Searchable, UniquelyIdentifiable, AccessControlledObject
	{
		public static readonly CostCenterMeta Meta = CostCenterMeta.Instance;

		public CostCenter(Allors.IStrategy allors) : base(allors) {}

		public static CostCenter Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (CostCenter) allorsSession.Instantiate(allorsObjectId);		
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


		virtual public OrganisationGlAccount InternalTransferGlAccount
		{ 
			get
			{
				return (OrganisationGlAccount) Strategy.GetCompositeRole(Meta.InternalTransferGlAccount);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.InternalTransferGlAccount ,value);
			}
		}

		virtual public bool ExistInternalTransferGlAccount
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.InternalTransferGlAccount);
			}
		}

		virtual public void RemoveInternalTransferGlAccount()
		{
			Strategy.RemoveCompositeRole(Meta.InternalTransferGlAccount);
		}


		virtual public global::Allors.Extent<CostCenterCategory> CostCenterCategories
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.CostCenterCategory);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.CostCenterCategory, value);
			}
		}

		virtual public void AddCostCenterCategory (CostCenterCategory value)
		{
			Strategy.AddCompositeRole(Meta.CostCenterCategory, value);
		}

		virtual public void RemoveCostCenterCategory (CostCenterCategory value)
		{
			Strategy.RemoveCompositeRole(Meta.CostCenterCategory,value);
		}

		virtual public bool ExistCostCenterCategories
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.CostCenterCategory);
			}
		}

		virtual public void RemoveCostCenterCategories()
		{
			Strategy.RemoveCompositeRoles(Meta.CostCenterCategory);
		}


		virtual public OrganisationGlAccount RedistributedCostsGlAccount
		{ 
			get
			{
				return (OrganisationGlAccount) Strategy.GetCompositeRole(Meta.RedistributedCostsGlAccount);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.RedistributedCostsGlAccount ,value);
			}
		}

		virtual public bool ExistRedistributedCostsGlAccount
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.RedistributedCostsGlAccount);
			}
		}

		virtual public void RemoveRedistributedCostsGlAccount()
		{
			Strategy.RemoveCompositeRole(Meta.RedistributedCostsGlAccount);
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



		virtual public global::System.Boolean? Active 
		{
			get
			{
				return (global::System.Boolean?) Strategy.GetUnitRole(Meta.Active);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Active, value);
			}
		}

		virtual public bool ExistActive{
			get
			{
				return Strategy.ExistUnitRole(Meta.Active);
			}
		}

		virtual public void RemoveActive()
		{
			Strategy.RemoveUnitRole(Meta.Active);
		}



		virtual public global::System.Boolean? UseGlAccountOfBooking 
		{
			get
			{
				return (global::System.Boolean?) Strategy.GetUnitRole(Meta.UseGlAccountOfBooking);
			}
			set
			{
				Strategy.SetUnitRole(Meta.UseGlAccountOfBooking, value);
			}
		}

		virtual public bool ExistUseGlAccountOfBooking{
			get
			{
				return Strategy.ExistUnitRole(Meta.UseGlAccountOfBooking);
			}
		}

		virtual public void RemoveUseGlAccountOfBooking()
		{
			Strategy.RemoveUnitRole(Meta.UseGlAccountOfBooking);
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



		virtual public global::Allors.Extent<GeneralLedgerAccount> GeneralLedgerAccountsWhereDefaultCostCenter
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.GeneralLedgerAccountsWhereDefaultCostCenter);
			}
		}

		virtual public bool ExistGeneralLedgerAccountsWhereDefaultCostCenter
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.GeneralLedgerAccountsWhereDefaultCostCenter);
			}
		}


		virtual public global::Allors.Extent<GeneralLedgerAccount> GeneralLedgerAccountsWhereCostCenterAllowed
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.GeneralLedgerAccountsWhereCostCenterAllowed);
			}
		}

		virtual public bool ExistGeneralLedgerAccountsWhereCostCenterAllowed
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.GeneralLedgerAccountsWhereCostCenterAllowed);
			}
		}

	}

	public class CostCenterMeta
	{
		public static readonly CostCenterMeta Instance = new CostCenterMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.CostCenter;

		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CostCenterDescription;
			}
		} 
		public global::Allors.Meta.RoleType InternalTransferGlAccount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CostCenterInternalTransferGlAccount;
			}
		} 
		public global::Allors.Meta.RoleType CostCenterCategory 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CostCenterCostCenterCategory;
			}
		} 
		public global::Allors.Meta.RoleType RedistributedCostsGlAccount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CostCenterRedistributedCostsGlAccount;
			}
		} 
		public global::Allors.Meta.RoleType Name 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CostCenterName;
			}
		} 
		public global::Allors.Meta.RoleType Active 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CostCenterActive;
			}
		} 
		public global::Allors.Meta.RoleType UseGlAccountOfBooking 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CostCenterUseGlAccountOfBooking;
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

		public global::Allors.Meta.AssociationType GeneralLedgerAccountsWhereDefaultCostCenter 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.GeneralLedgerAccountDefaultCostCenter;
			}
		} 
		public global::Allors.Meta.AssociationType GeneralLedgerAccountsWhereCostCenterAllowed 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.GeneralLedgerAccountCostCenterAllowed;
			}
		} 

	}
}