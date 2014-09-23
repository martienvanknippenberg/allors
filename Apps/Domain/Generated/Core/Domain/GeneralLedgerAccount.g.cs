// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class GeneralLedgerAccount : Allors.ObjectBase , UniquelyIdentifiable, UserInterfaceable, Searchable, SearchResult
	{
		public static readonly GeneralLedgerAccountMeta Meta = GeneralLedgerAccountMeta.Instance;

		public GeneralLedgerAccount(Allors.IStrategy allors) : base(allors) {}

		public static GeneralLedgerAccount Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (GeneralLedgerAccount) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public Product DefaultCostUnit
		{ 
			get
			{
				return (Product) Strategy.GetCompositeRole(Meta.DefaultCostUnit);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.DefaultCostUnit ,value);
			}
		}

		virtual public bool ExistDefaultCostUnit
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.DefaultCostUnit);
			}
		}

		virtual public void RemoveDefaultCostUnit()
		{
			Strategy.RemoveCompositeRole(Meta.DefaultCostUnit);
		}


		virtual public CostCenter DefaultCostCenter
		{ 
			get
			{
				return (CostCenter) Strategy.GetCompositeRole(Meta.DefaultCostCenter);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.DefaultCostCenter ,value);
			}
		}

		virtual public bool ExistDefaultCostCenter
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.DefaultCostCenter);
			}
		}

		virtual public void RemoveDefaultCostCenter()
		{
			Strategy.RemoveCompositeRole(Meta.DefaultCostCenter);
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


		virtual public GeneralLedgerAccountType GeneralLedgerAccountType
		{ 
			get
			{
				return (GeneralLedgerAccountType) Strategy.GetCompositeRole(Meta.GeneralLedgerAccountType);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.GeneralLedgerAccountType ,value);
			}
		}

		virtual public bool ExistGeneralLedgerAccountType
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.GeneralLedgerAccountType);
			}
		}

		virtual public void RemoveGeneralLedgerAccountType()
		{
			Strategy.RemoveCompositeRole(Meta.GeneralLedgerAccountType);
		}



		virtual public global::System.Boolean? CashAccount 
		{
			get
			{
				return (global::System.Boolean?) Strategy.GetUnitRole(Meta.CashAccount);
			}
			set
			{
				Strategy.SetUnitRole(Meta.CashAccount, value);
			}
		}

		virtual public bool ExistCashAccount{
			get
			{
				return Strategy.ExistUnitRole(Meta.CashAccount);
			}
		}

		virtual public void RemoveCashAccount()
		{
			Strategy.RemoveUnitRole(Meta.CashAccount);
		}



		virtual public global::System.Boolean? CostCenterAccount 
		{
			get
			{
				return (global::System.Boolean?) Strategy.GetUnitRole(Meta.CostCenterAccount);
			}
			set
			{
				Strategy.SetUnitRole(Meta.CostCenterAccount, value);
			}
		}

		virtual public bool ExistCostCenterAccount{
			get
			{
				return Strategy.ExistUnitRole(Meta.CostCenterAccount);
			}
		}

		virtual public void RemoveCostCenterAccount()
		{
			Strategy.RemoveUnitRole(Meta.CostCenterAccount);
		}


		virtual public DebitCreditConstant Side
		{ 
			get
			{
				return (DebitCreditConstant) Strategy.GetCompositeRole(Meta.Side);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Side ,value);
			}
		}

		virtual public bool ExistSide
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Side);
			}
		}

		virtual public void RemoveSide()
		{
			Strategy.RemoveCompositeRole(Meta.Side);
		}



		virtual public global::System.Boolean? BalanceSheetAccount 
		{
			get
			{
				return (global::System.Boolean?) Strategy.GetUnitRole(Meta.BalanceSheetAccount);
			}
			set
			{
				Strategy.SetUnitRole(Meta.BalanceSheetAccount, value);
			}
		}

		virtual public bool ExistBalanceSheetAccount{
			get
			{
				return Strategy.ExistUnitRole(Meta.BalanceSheetAccount);
			}
		}

		virtual public void RemoveBalanceSheetAccount()
		{
			Strategy.RemoveUnitRole(Meta.BalanceSheetAccount);
		}



		virtual public global::System.Boolean? ReconciliationAccount 
		{
			get
			{
				return (global::System.Boolean?) Strategy.GetUnitRole(Meta.ReconciliationAccount);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ReconciliationAccount, value);
			}
		}

		virtual public bool ExistReconciliationAccount{
			get
			{
				return Strategy.ExistUnitRole(Meta.ReconciliationAccount);
			}
		}

		virtual public void RemoveReconciliationAccount()
		{
			Strategy.RemoveUnitRole(Meta.ReconciliationAccount);
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



		virtual public global::System.Boolean? CostCenterRequired 
		{
			get
			{
				return (global::System.Boolean?) Strategy.GetUnitRole(Meta.CostCenterRequired);
			}
			set
			{
				Strategy.SetUnitRole(Meta.CostCenterRequired, value);
			}
		}

		virtual public bool ExistCostCenterRequired{
			get
			{
				return Strategy.ExistUnitRole(Meta.CostCenterRequired);
			}
		}

		virtual public void RemoveCostCenterRequired()
		{
			Strategy.RemoveUnitRole(Meta.CostCenterRequired);
		}



		virtual public global::System.Boolean? CostUnitRequired 
		{
			get
			{
				return (global::System.Boolean?) Strategy.GetUnitRole(Meta.CostUnitRequired);
			}
			set
			{
				Strategy.SetUnitRole(Meta.CostUnitRequired, value);
			}
		}

		virtual public bool ExistCostUnitRequired{
			get
			{
				return Strategy.ExistUnitRole(Meta.CostUnitRequired);
			}
		}

		virtual public void RemoveCostUnitRequired()
		{
			Strategy.RemoveUnitRole(Meta.CostUnitRequired);
		}


		virtual public GeneralLedgerAccountGroup GeneralLedgerAccountGroup
		{ 
			get
			{
				return (GeneralLedgerAccountGroup) Strategy.GetCompositeRole(Meta.GeneralLedgerAccountGroup);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.GeneralLedgerAccountGroup ,value);
			}
		}

		virtual public bool ExistGeneralLedgerAccountGroup
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.GeneralLedgerAccountGroup);
			}
		}

		virtual public void RemoveGeneralLedgerAccountGroup()
		{
			Strategy.RemoveCompositeRole(Meta.GeneralLedgerAccountGroup);
		}


		virtual public global::Allors.Extent<CostCenter> CostCentersAllowed
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.CostCenterAllowed);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.CostCenterAllowed, value);
			}
		}

		virtual public void AddCostCenterAllowed (CostCenter value)
		{
			Strategy.AddCompositeRole(Meta.CostCenterAllowed, value);
		}

		virtual public void RemoveCostCenterAllowed (CostCenter value)
		{
			Strategy.RemoveCompositeRole(Meta.CostCenterAllowed,value);
		}

		virtual public bool ExistCostCentersAllowed
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.CostCenterAllowed);
			}
		}

		virtual public void RemoveCostCentersAllowed()
		{
			Strategy.RemoveCompositeRoles(Meta.CostCenterAllowed);
		}



		virtual public global::System.Boolean? CostUnitAccount 
		{
			get
			{
				return (global::System.Boolean?) Strategy.GetUnitRole(Meta.CostUnitAccount);
			}
			set
			{
				Strategy.SetUnitRole(Meta.CostUnitAccount, value);
			}
		}

		virtual public bool ExistCostUnitAccount{
			get
			{
				return Strategy.ExistUnitRole(Meta.CostUnitAccount);
			}
		}

		virtual public void RemoveCostUnitAccount()
		{
			Strategy.RemoveUnitRole(Meta.CostUnitAccount);
		}



		virtual public global::System.String AccountNumber 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.AccountNumber);
			}
			set
			{
				Strategy.SetUnitRole(Meta.AccountNumber, value);
			}
		}

		virtual public bool ExistAccountNumber{
			get
			{
				return Strategy.ExistUnitRole(Meta.AccountNumber);
			}
		}

		virtual public void RemoveAccountNumber()
		{
			Strategy.RemoveUnitRole(Meta.AccountNumber);
		}


		virtual public global::Allors.Extent<Product> CostUnitsAllowed
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.CostUnitAllowed);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.CostUnitAllowed, value);
			}
		}

		virtual public void AddCostUnitAllowed (Product value)
		{
			Strategy.AddCompositeRole(Meta.CostUnitAllowed, value);
		}

		virtual public void RemoveCostUnitAllowed (Product value)
		{
			Strategy.RemoveCompositeRole(Meta.CostUnitAllowed,value);
		}

		virtual public bool ExistCostUnitsAllowed
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.CostUnitAllowed);
			}
		}

		virtual public void RemoveCostUnitsAllowed()
		{
			Strategy.RemoveCompositeRoles(Meta.CostUnitAllowed);
		}



		virtual public global::System.Boolean? Protected 
		{
			get
			{
				return (global::System.Boolean?) Strategy.GetUnitRole(Meta.Protected);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Protected, value);
			}
		}

		virtual public bool ExistProtected{
			get
			{
				return Strategy.ExistUnitRole(Meta.Protected);
			}
		}

		virtual public void RemoveProtected()
		{
			Strategy.RemoveUnitRole(Meta.Protected);
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



		virtual public global::Allors.Extent<GlBudgetAllocation> GlBudgetAllocationsWhereGeneralLedgerAccount
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.GlBudgetAllocationsWhereGeneralLedgerAccount);
			}
		}

		virtual public bool ExistGlBudgetAllocationsWhereGeneralLedgerAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.GlBudgetAllocationsWhereGeneralLedgerAccount);
			}
		}


		virtual public global::Allors.Extent<InternalOrganisationAccountingPreference> InternalOrganisationAccountingPreferencesWhereGeneralLedgerAccount
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.InternalOrganisationAccountingPreferencesWhereGeneralLedgerAccount);
			}
		}

		virtual public bool ExistInternalOrganisationAccountingPreferencesWhereGeneralLedgerAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.InternalOrganisationAccountingPreferencesWhereGeneralLedgerAccount);
			}
		}


		virtual public global::Allors.Extent<OrganisationGlAccount> OrganisationGlAccountsWhereGeneralLedgerAccount
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.OrganisationGlAccountsWhereGeneralLedgerAccount);
			}
		}

		virtual public bool ExistOrganisationGlAccountsWhereGeneralLedgerAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.OrganisationGlAccountsWhereGeneralLedgerAccount);
			}
		}


		virtual public ChartOfAccounts ChartOfAccountsWhereGeneralLedgerAccount
		{ 
			get
			{
				return (ChartOfAccounts) Strategy.GetCompositeAssociation(Meta.ChartOfAccountsWhereGeneralLedgerAccount);
			}
		} 

		virtual public bool ExistChartOfAccountsWhereGeneralLedgerAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.ChartOfAccountsWhereGeneralLedgerAccount);
			}
		}


		virtual public InternalOrganisation InternalOrganisationWhereSalesPaymentDifferencesAccount
		{ 
			get
			{
				return (InternalOrganisation) Strategy.GetCompositeAssociation(Meta.InternalOrganisationWhereSalesPaymentDifferencesAccount);
			}
		} 

		virtual public bool ExistInternalOrganisationWhereSalesPaymentDifferencesAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.InternalOrganisationWhereSalesPaymentDifferencesAccount);
			}
		}


		virtual public InternalOrganisation InternalOrganisationWhereGeneralLedgerAccount
		{ 
			get
			{
				return (InternalOrganisation) Strategy.GetCompositeAssociation(Meta.InternalOrganisationWhereGeneralLedgerAccount);
			}
		} 

		virtual public bool ExistInternalOrganisationWhereGeneralLedgerAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.InternalOrganisationWhereGeneralLedgerAccount);
			}
		}


		virtual public global::Allors.Extent<InternalOrganisation> InternalOrganisationsWhereRetainedEarningsAccount
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.InternalOrganisationsWhereRetainedEarningsAccount);
			}
		}

		virtual public bool ExistInternalOrganisationsWhereRetainedEarningsAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.InternalOrganisationsWhereRetainedEarningsAccount);
			}
		}


		virtual public global::Allors.Extent<InternalOrganisation> InternalOrganisationsWhereSalesPaymentDiscountDifferencesAccount
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.InternalOrganisationsWhereSalesPaymentDiscountDifferencesAccount);
			}
		}

		virtual public bool ExistInternalOrganisationsWhereSalesPaymentDiscountDifferencesAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.InternalOrganisationsWhereSalesPaymentDiscountDifferencesAccount);
			}
		}


		virtual public global::Allors.Extent<InternalOrganisation> InternalOrganisationsWherePurchasePaymentDifferencesAccount
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.InternalOrganisationsWherePurchasePaymentDifferencesAccount);
			}
		}

		virtual public bool ExistInternalOrganisationsWherePurchasePaymentDifferencesAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.InternalOrganisationsWherePurchasePaymentDifferencesAccount);
			}
		}


		virtual public global::Allors.Extent<InternalOrganisation> InternalOrganisationsWhereSuspenceAccount
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.InternalOrganisationsWhereSuspenceAccount);
			}
		}

		virtual public bool ExistInternalOrganisationsWhereSuspenceAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.InternalOrganisationsWhereSuspenceAccount);
			}
		}


		virtual public global::Allors.Extent<InternalOrganisation> InternalOrganisationsWhereNetIncomeAccount
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.InternalOrganisationsWhereNetIncomeAccount);
			}
		}

		virtual public bool ExistInternalOrganisationsWhereNetIncomeAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.InternalOrganisationsWhereNetIncomeAccount);
			}
		}


		virtual public global::Allors.Extent<InternalOrganisation> InternalOrganisationsWherePurchasePaymentDiscountDifferencesAccount
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.InternalOrganisationsWherePurchasePaymentDiscountDifferencesAccount);
			}
		}

		virtual public bool ExistInternalOrganisationsWherePurchasePaymentDiscountDifferencesAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.InternalOrganisationsWherePurchasePaymentDiscountDifferencesAccount);
			}
		}


		virtual public global::Allors.Extent<InternalOrganisation> InternalOrganisationsWhereCalculationDifferencesAccount
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.InternalOrganisationsWhereCalculationDifferencesAccount);
			}
		}

		virtual public bool ExistInternalOrganisationsWhereCalculationDifferencesAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.InternalOrganisationsWhereCalculationDifferencesAccount);
			}
		}

	}

	public class GeneralLedgerAccountMeta
	{
		public static readonly GeneralLedgerAccountMeta Instance = new GeneralLedgerAccountMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.GeneralLedgerAccount;

		public global::Allors.Meta.RoleType DefaultCostUnit 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.GeneralLedgerAccountDefaultCostUnit;
			}
		} 
		public global::Allors.Meta.RoleType DefaultCostCenter 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.GeneralLedgerAccountDefaultCostCenter;
			}
		} 
		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.GeneralLedgerAccountDescription;
			}
		} 
		public global::Allors.Meta.RoleType GeneralLedgerAccountType 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.GeneralLedgerAccountGeneralLedgerAccountType;
			}
		} 
		public global::Allors.Meta.RoleType CashAccount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.GeneralLedgerAccountCashAccount;
			}
		} 
		public global::Allors.Meta.RoleType CostCenterAccount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.GeneralLedgerAccountCostCenterAccount;
			}
		} 
		public global::Allors.Meta.RoleType Side 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.GeneralLedgerAccountSide;
			}
		} 
		public global::Allors.Meta.RoleType BalanceSheetAccount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.GeneralLedgerAccountBalanceSheetAccount;
			}
		} 
		public global::Allors.Meta.RoleType ReconciliationAccount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.GeneralLedgerAccountReconciliationAccount;
			}
		} 
		public global::Allors.Meta.RoleType Name 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.GeneralLedgerAccountName;
			}
		} 
		public global::Allors.Meta.RoleType CostCenterRequired 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.GeneralLedgerAccountCostCenterRequired;
			}
		} 
		public global::Allors.Meta.RoleType CostUnitRequired 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.GeneralLedgerAccountCostUnitRequired;
			}
		} 
		public global::Allors.Meta.RoleType GeneralLedgerAccountGroup 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.GeneralLedgerAccountGeneralLedgerAccountGroup;
			}
		} 
		public global::Allors.Meta.RoleType CostCenterAllowed 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.GeneralLedgerAccountCostCenterAllowed;
			}
		} 
		public global::Allors.Meta.RoleType CostUnitAccount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.GeneralLedgerAccountCostUnitAccount;
			}
		} 
		public global::Allors.Meta.RoleType AccountNumber 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.GeneralLedgerAccountAccountNumber;
			}
		} 
		public global::Allors.Meta.RoleType CostUnitAllowed 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.GeneralLedgerAccountCostUnitAllowed;
			}
		} 
		public global::Allors.Meta.RoleType Protected 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.GeneralLedgerAccountProtected;
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

		public global::Allors.Meta.AssociationType GlBudgetAllocationsWhereGeneralLedgerAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.GlBudgetAllocationGeneralLedgerAccount;
			}
		} 
		public global::Allors.Meta.AssociationType InternalOrganisationAccountingPreferencesWhereGeneralLedgerAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InternalOrganisationAccountingPreferenceGeneralLedgerAccount;
			}
		} 
		public global::Allors.Meta.AssociationType OrganisationGlAccountsWhereGeneralLedgerAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.OrganisationGlAccountGeneralLedgerAccount;
			}
		} 
		public global::Allors.Meta.AssociationType ChartOfAccountsWhereGeneralLedgerAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ChartOfAccountsGeneralLedgerAccount;
			}
		} 
		public global::Allors.Meta.AssociationType InternalOrganisationWhereSalesPaymentDifferencesAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InternalOrganisationSalesPaymentDifferencesAccount;
			}
		} 
		public global::Allors.Meta.AssociationType InternalOrganisationWhereGeneralLedgerAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InternalOrganisationGeneralLedgerAccount;
			}
		} 
		public global::Allors.Meta.AssociationType InternalOrganisationsWhereRetainedEarningsAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InternalOrganisationRetainedEarningsAccount;
			}
		} 
		public global::Allors.Meta.AssociationType InternalOrganisationsWhereSalesPaymentDiscountDifferencesAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InternalOrganisationSalesPaymentDiscountDifferencesAccount;
			}
		} 
		public global::Allors.Meta.AssociationType InternalOrganisationsWherePurchasePaymentDifferencesAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InternalOrganisationPurchasePaymentDifferencesAccount;
			}
		} 
		public global::Allors.Meta.AssociationType InternalOrganisationsWhereSuspenceAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InternalOrganisationSuspenceAccount;
			}
		} 
		public global::Allors.Meta.AssociationType InternalOrganisationsWhereNetIncomeAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InternalOrganisationNetIncomeAccount;
			}
		} 
		public global::Allors.Meta.AssociationType InternalOrganisationsWherePurchasePaymentDiscountDifferencesAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InternalOrganisationPurchasePaymentDiscountDifferencesAccount;
			}
		} 
		public global::Allors.Meta.AssociationType InternalOrganisationsWhereCalculationDifferencesAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InternalOrganisationCalculationDifferencesAccount;
			}
		} 

	}
}