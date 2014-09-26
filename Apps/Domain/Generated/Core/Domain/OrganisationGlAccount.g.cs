// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class OrganisationGlAccount : Allors.ObjectBase , UserInterfaceable, Period
	{
		public static readonly OrganisationGlAccountMeta Meta = OrganisationGlAccountMeta.Instance;

		public OrganisationGlAccount(Allors.IStrategy allors) : base(allors) {}

		public static OrganisationGlAccount Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (OrganisationGlAccount) allorsSession.Instantiate(allorsObjectId);		
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


		virtual public OrganisationGlAccount Parent
		{ 
			get
			{
				return (OrganisationGlAccount) Strategy.GetCompositeRole(Meta.Parent);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Parent ,value);
			}
		}

		virtual public bool ExistParent
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Parent);
			}
		}

		virtual public void RemoveParent()
		{
			Strategy.RemoveCompositeRole(Meta.Parent);
		}


		virtual public Party Party
		{ 
			get
			{
				return (Party) Strategy.GetCompositeRole(Meta.Party);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Party ,value);
			}
		}

		virtual public bool ExistParty
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Party);
			}
		}

		virtual public void RemoveParty()
		{
			Strategy.RemoveCompositeRole(Meta.Party);
		}



		virtual public global::System.Boolean HasBankStatementTransactions 
		{
			get
			{
				return (global::System.Boolean) Strategy.GetUnitRole(Meta.HasBankStatementTransactions);
			}
			set
			{
				Strategy.SetUnitRole(Meta.HasBankStatementTransactions, value);
			}
		}

		virtual public bool ExistHasBankStatementTransactions{
			get
			{
				return Strategy.ExistUnitRole(Meta.HasBankStatementTransactions);
			}
		}

		virtual public void RemoveHasBankStatementTransactions()
		{
			Strategy.RemoveUnitRole(Meta.HasBankStatementTransactions);
		}


		virtual public ProductCategory ProductCategory
		{ 
			get
			{
				return (ProductCategory) Strategy.GetCompositeRole(Meta.ProductCategory);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.ProductCategory ,value);
			}
		}

		virtual public bool ExistProductCategory
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.ProductCategory);
			}
		}

		virtual public void RemoveProductCategory()
		{
			Strategy.RemoveCompositeRole(Meta.ProductCategory);
		}


		virtual public InternalOrganisation InternalOrganisation
		{ 
			get
			{
				return (InternalOrganisation) Strategy.GetCompositeRole(Meta.InternalOrganisation);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.InternalOrganisation ,value);
			}
		}

		virtual public bool ExistInternalOrganisation
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.InternalOrganisation);
			}
		}

		virtual public void RemoveInternalOrganisation()
		{
			Strategy.RemoveCompositeRole(Meta.InternalOrganisation);
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



		virtual public global::System.DateTime FromDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.FromDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.FromDate, value);
			}
		}

		virtual public bool ExistFromDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.FromDate);
			}
		}

		virtual public void RemoveFromDate()
		{
			Strategy.RemoveUnitRole(Meta.FromDate);
		}



		virtual public global::System.DateTime ThroughDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.ThroughDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ThroughDate, value);
			}
		}

		virtual public bool ExistThroughDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.ThroughDate);
			}
		}

		virtual public void RemoveThroughDate()
		{
			Strategy.RemoveUnitRole(Meta.ThroughDate);
		}



		virtual public global::Allors.Extent<CostCenter> CostCentersWhereInternalTransferGlAccount
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.CostCentersWhereInternalTransferGlAccount);
			}
		}

		virtual public bool ExistCostCentersWhereInternalTransferGlAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.CostCentersWhereInternalTransferGlAccount);
			}
		}


		virtual public global::Allors.Extent<CostCenter> CostCentersWhereRedistributedCostsGlAccount
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.CostCentersWhereRedistributedCostsGlAccount);
			}
		}

		virtual public bool ExistCostCentersWhereRedistributedCostsGlAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.CostCentersWhereRedistributedCostsGlAccount);
			}
		}


		virtual public global::Allors.Extent<OrganisationGlAccount> OrganisationGlAccountsWhereParent
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.OrganisationGlAccountsWhereParent);
			}
		}

		virtual public bool ExistOrganisationGlAccountsWhereParent
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.OrganisationGlAccountsWhereParent);
			}
		}


		virtual public global::Allors.Extent<OrganisationGlAccountBalance> OrganisationGlAccountBalancesWhereOrganisationGlAccount
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.OrganisationGlAccountBalancesWhereOrganisationGlAccount);
			}
		}

		virtual public bool ExistOrganisationGlAccountBalancesWhereOrganisationGlAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.OrganisationGlAccountBalancesWhereOrganisationGlAccount);
			}
		}


		virtual public global::Allors.Extent<VatRegime> VatRegimesWhereGeneralLedgerAccount
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.VatRegimesWhereGeneralLedgerAccount);
			}
		}

		virtual public bool ExistVatRegimesWhereGeneralLedgerAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.VatRegimesWhereGeneralLedgerAccount);
			}
		}


		virtual public global::Allors.Extent<JournalEntryDetail> JournalEntryDetailsWhereGeneralLedgerAccount
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.JournalEntryDetailsWhereGeneralLedgerAccount);
			}
		}

		virtual public bool ExistJournalEntryDetailsWhereGeneralLedgerAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.JournalEntryDetailsWhereGeneralLedgerAccount);
			}
		}


		virtual public VatRate VatRateWhereVatPayableAccount
		{ 
			get
			{
				return (VatRate) Strategy.GetCompositeAssociation(Meta.VatRateWhereVatPayableAccount);
			}
		} 

		virtual public bool ExistVatRateWhereVatPayableAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.VatRateWhereVatPayableAccount);
			}
		}


		virtual public global::Allors.Extent<VatRate> VatRatesWhereVatToPayAccount
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.VatRatesWhereVatToPayAccount);
			}
		}

		virtual public bool ExistVatRatesWhereVatToPayAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.VatRatesWhereVatToPayAccount);
			}
		}


		virtual public global::Allors.Extent<VatRate> VatRatesWhereVatToReceiveAccount
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.VatRatesWhereVatToReceiveAccount);
			}
		}

		virtual public bool ExistVatRatesWhereVatToReceiveAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.VatRatesWhereVatToReceiveAccount);
			}
		}


		virtual public VatRate VatRateWhereVatReceivableAccount
		{ 
			get
			{
				return (VatRate) Strategy.GetCompositeAssociation(Meta.VatRateWhereVatReceivableAccount);
			}
		} 

		virtual public bool ExistVatRateWhereVatReceivableAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.VatRateWhereVatReceivableAccount);
			}
		}


		virtual public global::Allors.Extent<Journal> JournalsWhereGlPaymentInTransit
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.JournalsWhereGlPaymentInTransit);
			}
		}

		virtual public bool ExistJournalsWhereGlPaymentInTransit
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.JournalsWhereGlPaymentInTransit);
			}
		}


		virtual public Journal JournalWhereContraAccount
		{ 
			get
			{
				return (Journal) Strategy.GetCompositeAssociation(Meta.JournalWhereContraAccount);
			}
		} 

		virtual public bool ExistJournalWhereContraAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.JournalWhereContraAccount);
			}
		}


		virtual public global::Allors.Extent<Journal> JournalsWherePreviousContraAccount
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.JournalsWherePreviousContraAccount);
			}
		}

		virtual public bool ExistJournalsWherePreviousContraAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.JournalsWherePreviousContraAccount);
			}
		}


		virtual public global::Allors.Extent<PaymentMethod> PaymentMethodsWhereGlPaymentInTransit
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PaymentMethodsWhereGlPaymentInTransit);
			}
		}

		virtual public bool ExistPaymentMethodsWhereGlPaymentInTransit
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PaymentMethodsWhereGlPaymentInTransit);
			}
		}


		virtual public PaymentMethod PaymentMethodWhereGeneralLedgerAccount
		{ 
			get
			{
				return (PaymentMethod) Strategy.GetCompositeAssociation(Meta.PaymentMethodWhereGeneralLedgerAccount);
			}
		} 

		virtual public bool ExistPaymentMethodWhereGeneralLedgerAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.PaymentMethodWhereGeneralLedgerAccount);
			}
		}

	}

	public class OrganisationGlAccountMeta
	{
		public static readonly OrganisationGlAccountMeta Instance = new OrganisationGlAccountMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.OrganisationGlAccount;

		public global::Allors.Meta.RoleType Product 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrganisationGlAccountProduct;
			}
		} 
		public global::Allors.Meta.RoleType Parent 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrganisationGlAccountParent;
			}
		} 
		public global::Allors.Meta.RoleType Party 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrganisationGlAccountParty;
			}
		} 
		public global::Allors.Meta.RoleType HasBankStatementTransactions 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrganisationGlAccountHasBankStatementTransactions;
			}
		} 
		public global::Allors.Meta.RoleType ProductCategory 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrganisationGlAccountProductCategory;
			}
		} 
		public global::Allors.Meta.RoleType InternalOrganisation 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrganisationGlAccountInternalOrganisation;
			}
		} 
		public global::Allors.Meta.RoleType GeneralLedgerAccount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrganisationGlAccountGeneralLedgerAccount;
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
		public global::Allors.Meta.RoleType FromDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PeriodFromDate;
			}
		} 
		public global::Allors.Meta.RoleType ThroughDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PeriodThroughDate;
			}
		} 

		public global::Allors.Meta.AssociationType CostCentersWhereInternalTransferGlAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CostCenterInternalTransferGlAccount;
			}
		} 
		public global::Allors.Meta.AssociationType CostCentersWhereRedistributedCostsGlAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CostCenterRedistributedCostsGlAccount;
			}
		} 
		public global::Allors.Meta.AssociationType OrganisationGlAccountsWhereParent 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.OrganisationGlAccountParent;
			}
		} 
		public global::Allors.Meta.AssociationType OrganisationGlAccountBalancesWhereOrganisationGlAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.OrganisationGlAccountBalanceOrganisationGlAccount;
			}
		} 
		public global::Allors.Meta.AssociationType VatRegimesWhereGeneralLedgerAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.VatRegimeGeneralLedgerAccount;
			}
		} 
		public global::Allors.Meta.AssociationType JournalEntryDetailsWhereGeneralLedgerAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.JournalEntryDetailGeneralLedgerAccount;
			}
		} 
		public global::Allors.Meta.AssociationType VatRateWhereVatPayableAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.VatRateVatPayableAccount;
			}
		} 
		public global::Allors.Meta.AssociationType VatRatesWhereVatToPayAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.VatRateVatToPayAccount;
			}
		} 
		public global::Allors.Meta.AssociationType VatRatesWhereVatToReceiveAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.VatRateVatToReceiveAccount;
			}
		} 
		public global::Allors.Meta.AssociationType VatRateWhereVatReceivableAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.VatRateVatReceivableAccount;
			}
		} 
		public global::Allors.Meta.AssociationType JournalsWhereGlPaymentInTransit 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.JournalGlPaymentInTransit;
			}
		} 
		public global::Allors.Meta.AssociationType JournalWhereContraAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.JournalContraAccount;
			}
		} 
		public global::Allors.Meta.AssociationType JournalsWherePreviousContraAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.JournalPreviousContraAccount;
			}
		} 
		public global::Allors.Meta.AssociationType PaymentMethodsWhereGlPaymentInTransit 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PaymentMethodGlPaymentInTransit;
			}
		} 
		public global::Allors.Meta.AssociationType PaymentMethodWhereGeneralLedgerAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PaymentMethodGeneralLedgerAccount;
			}
		} 

	}
}