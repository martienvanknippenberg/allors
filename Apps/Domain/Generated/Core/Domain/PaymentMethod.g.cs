// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface PaymentMethod :  UserInterfaceable,UniquelyIdentifiable,AccessControlledObject,Searchable, Allors.IObjectBase
	{


		global::System.Decimal BalanceLimit 
		{
			get;
			set;
		}

		bool ExistBalanceLimit{get;}

		void RemoveBalanceLimit();


		global::System.Decimal CurrentBalance 
		{
			get;
			set;
		}

		bool ExistCurrentBalance{get;}

		void RemoveCurrentBalance();


		Journal Journal
		{ 
			get;
			set;
		}

		bool ExistJournal
		{
			get;
		}

		void RemoveJournal();


		global::System.String Description 
		{
			get;
			set;
		}

		bool ExistDescription{get;}

		void RemoveDescription();


		OrganisationGlAccount GlPaymentInTransit
		{ 
			get;
			set;
		}

		bool ExistGlPaymentInTransit
		{
			get;
		}

		void RemoveGlPaymentInTransit();


		global::System.String Remarks 
		{
			get;
			set;
		}

		bool ExistRemarks{get;}

		void RemoveRemarks();


		OrganisationGlAccount GeneralLedgerAccount
		{ 
			get;
			set;
		}

		bool ExistGeneralLedgerAccount
		{
			get;
		}

		void RemoveGeneralLedgerAccount();


		SupplierRelationship Creditor
		{ 
			get;
			set;
		}

		bool ExistCreditor
		{
			get;
		}

		void RemoveCreditor();


		global::System.Boolean IsActive 
		{
			get;
			set;
		}

		bool ExistIsActive{get;}

		void RemoveIsActive();



		global::Allors.Extent<InternalOrganisationAccountingPreference> InternalOrganisationAccountingPreferencesWherePaymentMethod
		{ 
			get;
		}

		bool ExistInternalOrganisationAccountingPreferencesWherePaymentMethod
		{
			get;
		}


		global::Allors.Extent<Party> PartiesWhereDefaultPaymentMethod
		{ 
			get;
		}

		bool ExistPartiesWhereDefaultPaymentMethod
		{
			get;
		}


		global::Allors.Extent<SalesInvoice> SalesInvoicesWherePaymentMethod
		{ 
			get;
		}

		bool ExistSalesInvoicesWherePaymentMethod
		{
			get;
		}


		global::Allors.Extent<SalesOrder> SalesOrdersWherePaymentMethod
		{ 
			get;
		}

		bool ExistSalesOrdersWherePaymentMethod
		{
			get;
		}


		global::Allors.Extent<AmountDue> AmountsDueWherePaymentMethod
		{ 
			get;
		}

		bool ExistAmountsDueWherePaymentMethod
		{
			get;
		}


		global::Allors.Extent<PayrollPreference> PayrollPreferencesWherePaymentMethod
		{ 
			get;
		}

		bool ExistPayrollPreferencesWherePaymentMethod
		{
			get;
		}


		global::Allors.Extent<CustomerShipment> CustomerShipmentsWherePaymentMethod
		{ 
			get;
		}

		bool ExistCustomerShipmentsWherePaymentMethod
		{
			get;
		}


		global::Allors.Extent<Payment> PaymentsWherePaymentMethod
		{ 
			get;
		}

		bool ExistPaymentsWherePaymentMethod
		{
			get;
		}


		InternalOrganisation InternalOrganisationWhereActivePaymentMethod
		{
			get;
		}

		bool ExistInternalOrganisationWhereActivePaymentMethod
		{
			get;
		}


		InternalOrganisation InternalOrganisationWherePaymentMethod
		{
			get;
		}

		bool ExistInternalOrganisationWherePaymentMethod
		{
			get;
		}


		global::Allors.Extent<Store> StoresWhereDefaultPaymentMethod
		{ 
			get;
		}

		bool ExistStoresWhereDefaultPaymentMethod
		{
			get;
		}


		global::Allors.Extent<Store> StoresWherePaymentMethod
		{ 
			get;
		}

		bool ExistStoresWherePaymentMethod
		{
			get;
		}

	}

	public class PaymentMethodMeta
	{
		public static readonly PaymentMethodMeta Instance = new PaymentMethodMeta();

		public global::Allors.Meta.Interface ObjectType = global::Allors.Meta.Interfaces.PaymentMethod;

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