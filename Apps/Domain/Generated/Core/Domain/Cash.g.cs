// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class Cash : Allors.ObjectBase , PaymentMethod
	{
		public static readonly CashMeta Meta = CashMeta.Instance;

		public Cash(Allors.IStrategy allors) : base(allors) {}

		public static Cash Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (Cash) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public Person PersonResponsible
		{ 
			get
			{
				return (Person) Strategy.GetCompositeRole(Meta.PersonResponsible);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.PersonResponsible ,value);
			}
		}

		virtual public bool ExistPersonResponsible
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.PersonResponsible);
			}
		}

		virtual public void RemovePersonResponsible()
		{
			Strategy.RemoveCompositeRole(Meta.PersonResponsible);
		}



		virtual public global::System.Decimal? BalanceLimit 
		{
			get
			{
				return (global::System.Decimal?) Strategy.GetUnitRole(Meta.BalanceLimit);
			}
			set
			{
				Strategy.SetUnitRole(Meta.BalanceLimit, value);
			}
		}

		virtual public bool ExistBalanceLimit{
			get
			{
				return Strategy.ExistUnitRole(Meta.BalanceLimit);
			}
		}

		virtual public void RemoveBalanceLimit()
		{
			Strategy.RemoveUnitRole(Meta.BalanceLimit);
		}



		virtual public global::System.Decimal? CurrentBalance 
		{
			get
			{
				return (global::System.Decimal?) Strategy.GetUnitRole(Meta.CurrentBalance);
			}
			set
			{
				Strategy.SetUnitRole(Meta.CurrentBalance, value);
			}
		}

		virtual public bool ExistCurrentBalance{
			get
			{
				return Strategy.ExistUnitRole(Meta.CurrentBalance);
			}
		}

		virtual public void RemoveCurrentBalance()
		{
			Strategy.RemoveUnitRole(Meta.CurrentBalance);
		}


		virtual public Journal Journal
		{ 
			get
			{
				return (Journal) Strategy.GetCompositeRole(Meta.Journal);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Journal ,value);
			}
		}

		virtual public bool ExistJournal
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Journal);
			}
		}

		virtual public void RemoveJournal()
		{
			Strategy.RemoveCompositeRole(Meta.Journal);
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


		virtual public OrganisationGlAccount GlPaymentInTransit
		{ 
			get
			{
				return (OrganisationGlAccount) Strategy.GetCompositeRole(Meta.GlPaymentInTransit);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.GlPaymentInTransit ,value);
			}
		}

		virtual public bool ExistGlPaymentInTransit
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.GlPaymentInTransit);
			}
		}

		virtual public void RemoveGlPaymentInTransit()
		{
			Strategy.RemoveCompositeRole(Meta.GlPaymentInTransit);
		}



		virtual public global::System.String Remarks 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Remarks);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Remarks, value);
			}
		}

		virtual public bool ExistRemarks{
			get
			{
				return Strategy.ExistUnitRole(Meta.Remarks);
			}
		}

		virtual public void RemoveRemarks()
		{
			Strategy.RemoveUnitRole(Meta.Remarks);
		}


		virtual public OrganisationGlAccount GeneralLedgerAccount
		{ 
			get
			{
				return (OrganisationGlAccount) Strategy.GetCompositeRole(Meta.GeneralLedgerAccount);
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


		virtual public SupplierRelationship Creditor
		{ 
			get
			{
				return (SupplierRelationship) Strategy.GetCompositeRole(Meta.Creditor);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Creditor ,value);
			}
		}

		virtual public bool ExistCreditor
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Creditor);
			}
		}

		virtual public void RemoveCreditor()
		{
			Strategy.RemoveCompositeRole(Meta.Creditor);
		}



		virtual public global::System.Boolean? IsActive 
		{
			get
			{
				return (global::System.Boolean?) Strategy.GetUnitRole(Meta.IsActive);
			}
			set
			{
				Strategy.SetUnitRole(Meta.IsActive, value);
			}
		}

		virtual public bool ExistIsActive{
			get
			{
				return Strategy.ExistUnitRole(Meta.IsActive);
			}
		}

		virtual public void RemoveIsActive()
		{
			Strategy.RemoveUnitRole(Meta.IsActive);
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



		virtual public global::Allors.Extent<InternalOrganisationAccountingPreference> InternalOrganisationAccountingPreferencesWherePaymentMethod
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.InternalOrganisationAccountingPreferencesWherePaymentMethod);
			}
		}

		virtual public bool ExistInternalOrganisationAccountingPreferencesWherePaymentMethod
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.InternalOrganisationAccountingPreferencesWherePaymentMethod);
			}
		}


		virtual public global::Allors.Extent<Party> PartiesWhereDefaultPaymentMethod
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartiesWhereDefaultPaymentMethod);
			}
		}

		virtual public bool ExistPartiesWhereDefaultPaymentMethod
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartiesWhereDefaultPaymentMethod);
			}
		}


		virtual public global::Allors.Extent<SalesInvoice> SalesInvoicesWherePaymentMethod
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesInvoicesWherePaymentMethod);
			}
		}

		virtual public bool ExistSalesInvoicesWherePaymentMethod
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesInvoicesWherePaymentMethod);
			}
		}


		virtual public global::Allors.Extent<SalesOrder> SalesOrdersWherePaymentMethod
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesOrdersWherePaymentMethod);
			}
		}

		virtual public bool ExistSalesOrdersWherePaymentMethod
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesOrdersWherePaymentMethod);
			}
		}


		virtual public global::Allors.Extent<AmountDue> AmountsDueWherePaymentMethod
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.AmountsDueWherePaymentMethod);
			}
		}

		virtual public bool ExistAmountsDueWherePaymentMethod
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.AmountsDueWherePaymentMethod);
			}
		}


		virtual public global::Allors.Extent<PayrollPreference> PayrollPreferencesWherePaymentMethod
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PayrollPreferencesWherePaymentMethod);
			}
		}

		virtual public bool ExistPayrollPreferencesWherePaymentMethod
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PayrollPreferencesWherePaymentMethod);
			}
		}


		virtual public global::Allors.Extent<CustomerShipment> CustomerShipmentsWherePaymentMethod
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.CustomerShipmentsWherePaymentMethod);
			}
		}

		virtual public bool ExistCustomerShipmentsWherePaymentMethod
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.CustomerShipmentsWherePaymentMethod);
			}
		}


		virtual public global::Allors.Extent<Payment> PaymentsWherePaymentMethod
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PaymentsWherePaymentMethod);
			}
		}

		virtual public bool ExistPaymentsWherePaymentMethod
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PaymentsWherePaymentMethod);
			}
		}


		virtual public InternalOrganisation InternalOrganisationWhereActivePaymentMethod
		{ 
			get
			{
				return (InternalOrganisation) Strategy.GetCompositeAssociation(Meta.InternalOrganisationWhereActivePaymentMethod);
			}
		} 

		virtual public bool ExistInternalOrganisationWhereActivePaymentMethod
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.InternalOrganisationWhereActivePaymentMethod);
			}
		}


		virtual public InternalOrganisation InternalOrganisationWherePaymentMethod
		{ 
			get
			{
				return (InternalOrganisation) Strategy.GetCompositeAssociation(Meta.InternalOrganisationWherePaymentMethod);
			}
		} 

		virtual public bool ExistInternalOrganisationWherePaymentMethod
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.InternalOrganisationWherePaymentMethod);
			}
		}


		virtual public global::Allors.Extent<Store> StoresWhereDefaultPaymentMethod
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.StoresWhereDefaultPaymentMethod);
			}
		}

		virtual public bool ExistStoresWhereDefaultPaymentMethod
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.StoresWhereDefaultPaymentMethod);
			}
		}


		virtual public global::Allors.Extent<Store> StoresWherePaymentMethod
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.StoresWherePaymentMethod);
			}
		}

		virtual public bool ExistStoresWherePaymentMethod
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.StoresWherePaymentMethod);
			}
		}

	}

	public class CashMeta
	{
		public static readonly CashMeta Instance = new CashMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.Cash;

		public global::Allors.Meta.RoleType PersonResponsible 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CashPersonResponsible;
			}
		} 
		public global::Allors.Meta.RoleType BalanceLimit 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PaymentMethodBalanceLimit;
			}
		} 
		public global::Allors.Meta.RoleType CurrentBalance 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PaymentMethodCurrentBalance;
			}
		} 
		public global::Allors.Meta.RoleType Journal 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PaymentMethodJournal;
			}
		} 
		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PaymentMethodDescription;
			}
		} 
		public global::Allors.Meta.RoleType GlPaymentInTransit 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PaymentMethodGlPaymentInTransit;
			}
		} 
		public global::Allors.Meta.RoleType Remarks 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PaymentMethodRemarks;
			}
		} 
		public global::Allors.Meta.RoleType GeneralLedgerAccount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PaymentMethodGeneralLedgerAccount;
			}
		} 
		public global::Allors.Meta.RoleType Creditor 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PaymentMethodCreditor;
			}
		} 
		public global::Allors.Meta.RoleType IsActive 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PaymentMethodIsActive;
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
		public global::Allors.Meta.RoleType UniqueId 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UniquelyIdentifiableUniqueId;
			}
		} 
		public global::Allors.Meta.RoleType SearchData 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SearchableSearchData;
			}
		} 

		public global::Allors.Meta.AssociationType InternalOrganisationAccountingPreferencesWherePaymentMethod 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InternalOrganisationAccountingPreferencePaymentMethod;
			}
		} 
		public global::Allors.Meta.AssociationType PartiesWhereDefaultPaymentMethod 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyDefaultPaymentMethod;
			}
		} 
		public global::Allors.Meta.AssociationType SalesInvoicesWherePaymentMethod 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesInvoicePaymentMethod;
			}
		} 
		public global::Allors.Meta.AssociationType SalesOrdersWherePaymentMethod 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesOrderPaymentMethod;
			}
		} 
		public global::Allors.Meta.AssociationType AmountsDueWherePaymentMethod 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.AmountDuePaymentMethod;
			}
		} 
		public global::Allors.Meta.AssociationType PayrollPreferencesWherePaymentMethod 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PayrollPreferencePaymentMethod;
			}
		} 
		public global::Allors.Meta.AssociationType CustomerShipmentsWherePaymentMethod 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CustomerShipmentPaymentMethod;
			}
		} 
		public global::Allors.Meta.AssociationType PaymentsWherePaymentMethod 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PaymentPaymentMethod;
			}
		} 
		public global::Allors.Meta.AssociationType InternalOrganisationWhereActivePaymentMethod 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InternalOrganisationActivePaymentMethod;
			}
		} 
		public global::Allors.Meta.AssociationType InternalOrganisationWherePaymentMethod 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InternalOrganisationPaymentMethod;
			}
		} 
		public global::Allors.Meta.AssociationType StoresWhereDefaultPaymentMethod 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.StoreDefaultPaymentMethod;
			}
		} 
		public global::Allors.Meta.AssociationType StoresWherePaymentMethod 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.StorePaymentMethod;
			}
		} 

	}
}