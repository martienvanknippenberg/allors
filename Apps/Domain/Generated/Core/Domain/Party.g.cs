// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface Party :  Localised,UserInterfaceable,SearchResult,SecurityTokenOwner,UniquelyIdentifiable,Searchable, Allors.IObject
	{


		global::System.Decimal YTDRevenue 
		{
			get;
			set;
		}

		bool ExistYTDRevenue{get;}

		void RemoveYTDRevenue();


		global::System.Decimal LastYearsRevenue 
		{
			get;
			set;
		}

		bool ExistLastYearsRevenue{get;}

		void RemoveLastYearsRevenue();


		TelecommunicationsNumber BillingInquiriesFax
		{ 
			get;
			set;
		}

		bool ExistBillingInquiriesFax
		{
			get;
		}

		void RemoveBillingInquiriesFax();


		global::Allors.Extent<Qualification> Qualifications
		{ 
			get;
			set;
		}

		void AddQualification (Qualification value);

		void RemoveQualification (Qualification value);

		bool ExistQualifications
		{
			get;
		}

		void RemoveQualifications();


		ContactMechanism HomeAddress
		{ 
			get;
			set;
		}

		bool ExistHomeAddress
		{
			get;
		}

		void RemoveHomeAddress();


		ContactMechanism SalesOffice
		{ 
			get;
			set;
		}

		bool ExistSalesOffice
		{
			get;
		}

		void RemoveSalesOffice();


		TelecommunicationsNumber OrderInquiriesFax
		{ 
			get;
			set;
		}

		bool ExistOrderInquiriesFax
		{
			get;
		}

		void RemoveOrderInquiriesFax();


		global::Allors.Extent<Person> CurrentSalesReps
		{ 
			get;
			set;
		}

		void AddCurrentSalesRep (Person value);

		void RemoveCurrentSalesRep (Person value);

		bool ExistCurrentSalesReps
		{
			get;
		}

		void RemoveCurrentSalesReps();


		global::Allors.Extent<PartyContactMechanism> PartyContactMechanisms
		{ 
			get;
			set;
		}

		void AddPartyContactMechanism (PartyContactMechanism value);

		void RemovePartyContactMechanism (PartyContactMechanism value);

		bool ExistPartyContactMechanisms
		{
			get;
		}

		void RemovePartyContactMechanisms();


		TelecommunicationsNumber ShippingInquiriesFax
		{ 
			get;
			set;
		}

		bool ExistShippingInquiriesFax
		{
			get;
		}

		void RemoveShippingInquiriesFax();


		TelecommunicationsNumber ShippingInquiriesPhone
		{ 
			get;
			set;
		}

		bool ExistShippingInquiriesPhone
		{
			get;
		}

		void RemoveShippingInquiriesPhone();


		global::Allors.Extent<BillingAccount> BillingAccounts
		{ 
			get;
			set;
		}

		void AddBillingAccount (BillingAccount value);

		void RemoveBillingAccount (BillingAccount value);

		bool ExistBillingAccounts
		{
			get;
		}

		void RemoveBillingAccounts();


		TelecommunicationsNumber OrderInquiriesPhone
		{ 
			get;
			set;
		}

		bool ExistOrderInquiriesPhone
		{
			get;
		}

		void RemoveOrderInquiriesPhone();


		global::Allors.Extent<PartySkill> PartySkills
		{ 
			get;
			set;
		}

		void AddPartySkill (PartySkill value);

		void RemovePartySkill (PartySkill value);

		bool ExistPartySkills
		{
			get;
		}

		void RemovePartySkills();


		global::Allors.Extent<PartyClassification> PartyClassifications
		{ 
			get;
			set;
		}

		void AddPartyClassification (PartyClassification value);

		void RemovePartyClassification (PartyClassification value);

		bool ExistPartyClassifications
		{
			get;
		}

		void RemovePartyClassifications();


		global::System.Boolean ExcludeFromDunning 
		{
			get;
			set;
		}

		bool ExistExcludeFromDunning{get;}

		void RemoveExcludeFromDunning();


		global::Allors.Extent<BankAccount> BankAccounts
		{ 
			get;
			set;
		}

		void AddBankAccount (BankAccount value);

		void RemoveBankAccount (BankAccount value);

		bool ExistBankAccounts
		{
			get;
		}

		void RemoveBankAccounts();


		ContactMechanism BillingAddress
		{ 
			get;
			set;
		}

		bool ExistBillingAddress
		{
			get;
		}

		void RemoveBillingAddress();


		ShipmentMethod DefaultShipmentMethod
		{ 
			get;
			set;
		}

		bool ExistDefaultShipmentMethod
		{
			get;
		}

		void RemoveDefaultShipmentMethod();


		global::Allors.Extent<Resume> Resumes
		{ 
			get;
			set;
		}

		void AddResume (Resume value);

		void RemoveResume (Resume value);

		bool ExistResumes
		{
			get;
		}

		void RemoveResumes();


		ContactMechanism HeadQuarter
		{ 
			get;
			set;
		}

		bool ExistHeadQuarter
		{
			get;
		}

		void RemoveHeadQuarter();


		ElectronicAddress PersonalEmailAddress
		{ 
			get;
			set;
		}

		bool ExistPersonalEmailAddress
		{
			get;
		}

		void RemovePersonalEmailAddress();


		TelecommunicationsNumber CellPhoneNumber
		{ 
			get;
			set;
		}

		bool ExistCellPhoneNumber
		{
			get;
		}

		void RemoveCellPhoneNumber();


		TelecommunicationsNumber BillingInquiriesPhone
		{ 
			get;
			set;
		}

		bool ExistBillingInquiriesPhone
		{
			get;
		}

		void RemoveBillingInquiriesPhone();


		global::System.String PartyName 
		{
			get;
			set;
		}

		bool ExistPartyName{get;}

		void RemovePartyName();


		ContactMechanism OrderAddress
		{ 
			get;
			set;
		}

		bool ExistOrderAddress
		{
			get;
		}

		void RemoveOrderAddress();


		ElectronicAddress InternetAddress
		{ 
			get;
			set;
		}

		bool ExistInternetAddress
		{
			get;
		}

		void RemoveInternetAddress();


		global::Allors.Extent<Media> Contents
		{ 
			get;
			set;
		}

		void AddContent (Media value);

		void RemoveContent (Media value);

		bool ExistContents
		{
			get;
		}

		void RemoveContents();


		global::Allors.Extent<CreditCard> CreditCards
		{ 
			get;
			set;
		}

		void AddCreditCard (CreditCard value);

		void RemoveCreditCard (CreditCard value);

		bool ExistCreditCards
		{
			get;
		}

		void RemoveCreditCards();


		PostalAddress ShippingAddress
		{ 
			get;
			set;
		}

		bool ExistShippingAddress
		{
			get;
		}

		void RemoveShippingAddress();


		global::System.Decimal OpenOrderAmount 
		{
			get;
			set;
		}

		bool ExistOpenOrderAmount{get;}

		void RemoveOpenOrderAmount();


		TelecommunicationsNumber GeneralFaxNumber
		{ 
			get;
			set;
		}

		bool ExistGeneralFaxNumber
		{
			get;
		}

		void RemoveGeneralFaxNumber();


		PaymentMethod DefaultPaymentMethod
		{ 
			get;
			set;
		}

		bool ExistDefaultPaymentMethod
		{
			get;
		}

		void RemoveDefaultPaymentMethod();


		TelecommunicationsNumber GeneralPhoneNumber
		{ 
			get;
			set;
		}

		bool ExistGeneralPhoneNumber
		{
			get;
		}

		void RemoveGeneralPhoneNumber();


		Currency PreferredCurrency
		{ 
			get;
			set;
		}

		bool ExistPreferredCurrency
		{
			get;
		}

		void RemovePreferredCurrency();


		VatRegime VatRegime
		{ 
			get;
			set;
		}

		bool ExistVatRegime
		{
			get;
		}

		void RemoveVatRegime();



		global::Allors.Extent<QuoteItem> QuoteItemsWhereAuthorizer
		{ 
			get;
		}

		bool ExistQuoteItemsWhereAuthorizer
		{
			get;
		}


		global::Allors.Extent<SalesRepPartyProductCategoryRevenue> SalesRepPartyProductCategoryRevenuesWhereParty
		{ 
			get;
		}

		bool ExistSalesRepPartyProductCategoryRevenuesWhereParty
		{
			get;
		}


		global::Allors.Extent<PartyProductCategoryRevenueHistory> PartyProductCategoryRevenueHistoriesWhereParty
		{ 
			get;
		}

		bool ExistPartyProductCategoryRevenueHistoriesWhereParty
		{
			get;
		}


		global::Allors.Extent<LetterCorrespondence> LetterCorrespondencesWhereOriginator
		{ 
			get;
		}

		bool ExistLetterCorrespondencesWhereOriginator
		{
			get;
		}


		global::Allors.Extent<LetterCorrespondence> LetterCorrespondencesWhereReceiver
		{ 
			get;
		}

		bool ExistLetterCorrespondencesWhereReceiver
		{
			get;
		}


		global::Allors.Extent<PurchaseOrder> PurchaseOrdersWherePreviousTakenViaSupplier
		{ 
			get;
		}

		bool ExistPurchaseOrdersWherePreviousTakenViaSupplier
		{
			get;
		}


		global::Allors.Extent<PurchaseOrder> PurchaseOrdersWhereTakenViaSupplier
		{ 
			get;
		}

		bool ExistPurchaseOrdersWhereTakenViaSupplier
		{
			get;
		}


		global::Allors.Extent<Quote> QuotesWhereIssuer
		{ 
			get;
		}

		bool ExistQuotesWhereIssuer
		{
			get;
		}


		global::Allors.Extent<Quote> QuotesWhereReceiver
		{ 
			get;
		}

		bool ExistQuotesWhereReceiver
		{
			get;
		}


		global::Allors.Extent<SupplierOffering> SupplierOfferingsWhereSupplier
		{ 
			get;
		}

		bool ExistSupplierOfferingsWhereSupplier
		{
			get;
		}


		global::Allors.Extent<WorkEffortPartyAssignment> WorkEffortPartyAssignmentsWhereParty
		{ 
			get;
		}

		bool ExistWorkEffortPartyAssignmentsWhereParty
		{
			get;
		}


		global::Allors.Extent<PartyRevenueHistory> PartyRevenueHistoriesWhereParty
		{ 
			get;
		}

		bool ExistPartyRevenueHistoriesWhereParty
		{
			get;
		}


		global::Allors.Extent<FaxCommunication> FaxCommunicationsWhereOriginator
		{ 
			get;
		}

		bool ExistFaxCommunicationsWhereOriginator
		{
			get;
		}


		global::Allors.Extent<FaxCommunication> FaxCommunicationsWhereReceiver
		{ 
			get;
		}

		bool ExistFaxCommunicationsWhereReceiver
		{
			get;
		}


		global::Allors.Extent<PickList> PickListsWhereShipToParty
		{ 
			get;
		}

		bool ExistPickListsWhereShipToParty
		{
			get;
		}


		global::Allors.Extent<Request> RequestsWhereOriginator
		{ 
			get;
		}

		bool ExistRequestsWhereOriginator
		{
			get;
		}


		global::Allors.Extent<PriceComponent> PriceComponentsWhereSpecifiedFor
		{ 
			get;
		}

		bool ExistPriceComponentsWhereSpecifiedFor
		{
			get;
		}


		global::Allors.Extent<PartyProductRevenue> PartyProductRevenuesWhereParty
		{ 
			get;
		}

		bool ExistPartyProductRevenuesWhereParty
		{
			get;
		}


		global::Allors.Extent<CustomerRelationship> CustomerRelationshipsWhereCustomer
		{ 
			get;
		}

		bool ExistCustomerRelationshipsWhereCustomer
		{
			get;
		}


		global::Allors.Extent<PartyProductCategoryRevenue> PartyProductCategoryRevenuesWhereParty
		{ 
			get;
		}

		bool ExistPartyProductCategoryRevenuesWhereParty
		{
			get;
		}


		global::Allors.Extent<PartyFixedAssetAssignment> PartyFixedAssetAssignmentsWhereParty
		{ 
			get;
		}

		bool ExistPartyFixedAssetAssignmentsWhereParty
		{
			get;
		}


		global::Allors.Extent<RespondingParty> RespondingPartiesWhereParty
		{ 
			get;
		}

		bool ExistRespondingPartiesWhereParty
		{
			get;
		}


		global::Allors.Extent<Product> ProductsWhereManufacturedBy
		{ 
			get;
		}

		bool ExistProductsWhereManufacturedBy
		{
			get;
		}


		global::Allors.Extent<OrganisationGlAccount> OrganisationGlAccountsWhereParty
		{ 
			get;
		}

		bool ExistOrganisationGlAccountsWhereParty
		{
			get;
		}


		global::Allors.Extent<SalesInvoice> SalesInvoicesWherePreviousBillToCustomer
		{ 
			get;
		}

		bool ExistSalesInvoicesWherePreviousBillToCustomer
		{
			get;
		}


		global::Allors.Extent<SalesInvoice> SalesInvoicesWherePreviousShipToCustomer
		{ 
			get;
		}

		bool ExistSalesInvoicesWherePreviousShipToCustomer
		{
			get;
		}


		global::Allors.Extent<SalesInvoice> SalesInvoicesWhereBillToCustomer
		{ 
			get;
		}

		bool ExistSalesInvoicesWhereBillToCustomer
		{
			get;
		}


		global::Allors.Extent<SalesInvoice> SalesInvoicesWhereShipToCustomer
		{ 
			get;
		}

		bool ExistSalesInvoicesWhereShipToCustomer
		{
			get;
		}


		global::Allors.Extent<SalesInvoice> SalesInvoicesWhereCustomer
		{ 
			get;
		}

		bool ExistSalesInvoicesWhereCustomer
		{
			get;
		}


		global::Allors.Extent<ExternalAccountingTransaction> ExternalAccountingTransactionsWhereFromParty
		{ 
			get;
		}

		bool ExistExternalAccountingTransactionsWhereFromParty
		{
			get;
		}


		global::Allors.Extent<ExternalAccountingTransaction> ExternalAccountingTransactionsWhereToParty
		{ 
			get;
		}

		bool ExistExternalAccountingTransactionsWhereToParty
		{
			get;
		}


		global::Allors.Extent<SalesRepRelationship> SalesRepRelationshipsWhereCustomer
		{ 
			get;
		}

		bool ExistSalesRepRelationshipsWhereCustomer
		{
			get;
		}


		global::Allors.Extent<PartyRevenue> PartyRevenuesWhereParty
		{ 
			get;
		}

		bool ExistPartyRevenuesWhereParty
		{
			get;
		}


		global::Allors.Extent<SalesOrder> SalesOrdersWhereShipToCustomer
		{ 
			get;
		}

		bool ExistSalesOrdersWhereShipToCustomer
		{
			get;
		}


		global::Allors.Extent<SalesOrder> SalesOrdersWhereBillToCustomer
		{ 
			get;
		}

		bool ExistSalesOrdersWhereBillToCustomer
		{
			get;
		}


		global::Allors.Extent<SalesOrder> SalesOrdersWherePreviousShipToCustomer
		{ 
			get;
		}

		bool ExistSalesOrdersWherePreviousShipToCustomer
		{
			get;
		}


		global::Allors.Extent<SalesOrder> SalesOrdersWhereCustomer
		{ 
			get;
		}

		bool ExistSalesOrdersWhereCustomer
		{
			get;
		}


		global::Allors.Extent<SalesOrder> SalesOrdersWherePreviousBillToCustomer
		{ 
			get;
		}

		bool ExistSalesOrdersWherePreviousBillToCustomer
		{
			get;
		}


		global::Allors.Extent<SalesOrder> SalesOrdersWherePlacingCustomer
		{ 
			get;
		}

		bool ExistSalesOrdersWherePlacingCustomer
		{
			get;
		}


		global::Allors.Extent<Engagement> EngagementsWhereBillToParty
		{ 
			get;
		}

		bool ExistEngagementsWhereBillToParty
		{
			get;
		}


		global::Allors.Extent<Engagement> EngagementsWherePlacingParty
		{ 
			get;
		}

		bool ExistEngagementsWherePlacingParty
		{
			get;
		}


		global::Allors.Extent<SalesRepPartyRevenue> SalesRepPartyRevenuesWhereParty
		{ 
			get;
		}

		bool ExistSalesRepPartyRevenuesWhereParty
		{
			get;
		}


		global::Allors.Extent<PurchaseInvoice> PurchaseInvoicesWhereBilledFromParty
		{ 
			get;
		}

		bool ExistPurchaseInvoicesWhereBilledFromParty
		{
			get;
		}


		global::Allors.Extent<PartyPackageRevenueHistory> PartyPackageRevenueHistoriesWhereParty
		{ 
			get;
		}

		bool ExistPartyPackageRevenueHistoriesWhereParty
		{
			get;
		}


		global::Allors.Extent<SalesOrderItem> SalesOrderItemsWhereShipToParty
		{ 
			get;
		}

		bool ExistSalesOrderItemsWhereShipToParty
		{
			get;
		}


		global::Allors.Extent<SalesOrderItem> SalesOrderItemsWhereAssignedShipToParty
		{ 
			get;
		}

		bool ExistSalesOrderItemsWhereAssignedShipToParty
		{
			get;
		}


		global::Allors.Extent<PartyPackageRevenue> PartyPackageRevenuesWhereParty
		{ 
			get;
		}

		bool ExistPartyPackageRevenuesWhereParty
		{
			get;
		}


		global::Allors.Extent<Shipment> ShipmentsWhereBillToParty
		{ 
			get;
		}

		bool ExistShipmentsWhereBillToParty
		{
			get;
		}


		global::Allors.Extent<Shipment> ShipmentsWhereShipToParty
		{ 
			get;
		}

		bool ExistShipmentsWhereShipToParty
		{
			get;
		}


		global::Allors.Extent<Shipment> ShipmentsWhereShipFromParty
		{ 
			get;
		}

		bool ExistShipmentsWhereShipFromParty
		{
			get;
		}


		global::Allors.Extent<Payment> PaymentsWhereSendingParty
		{ 
			get;
		}

		bool ExistPaymentsWhereSendingParty
		{
			get;
		}


		global::Allors.Extent<Payment> PaymentsWhereReceivingParty
		{ 
			get;
		}

		bool ExistPaymentsWhereReceivingParty
		{
			get;
		}


		global::Allors.Extent<ClientRelationship> ClientRelationshipsWhereClient
		{ 
			get;
		}

		bool ExistClientRelationshipsWhereClient
		{
			get;
		}


		global::Allors.Extent<CommunicationEvent> CommunicationEventsWhereInvolvedParty
		{ 
			get;
		}

		bool ExistCommunicationEventsWhereInvolvedParty
		{
			get;
		}


		InternalOrganisation InternalOrganisationWhereCustomer
		{
			get;
		}

		bool ExistInternalOrganisationWhereCustomer
		{
			get;
		}


		InternalOrganisation InternalOrganisationWhereSupplier
		{
			get;
		}

		bool ExistInternalOrganisationWhereSupplier
		{
			get;
		}


		global::Allors.Extent<Requirement> RequirementsWhereAuthorizer
		{ 
			get;
		}

		bool ExistRequirementsWhereAuthorizer
		{
			get;
		}


		global::Allors.Extent<Requirement> RequirementsWhereNeededFor
		{ 
			get;
		}

		bool ExistRequirementsWhereNeededFor
		{
			get;
		}


		global::Allors.Extent<Requirement> RequirementsWhereOriginator
		{ 
			get;
		}

		bool ExistRequirementsWhereOriginator
		{
			get;
		}


		global::Allors.Extent<Requirement> RequirementsWhereServicedBy
		{ 
			get;
		}

		bool ExistRequirementsWhereServicedBy
		{
			get;
		}


		global::Allors.Extent<SubContractorRelationship> SubContractorRelationshipsWhereContractor
		{ 
			get;
		}

		bool ExistSubContractorRelationshipsWhereContractor
		{
			get;
		}


		global::Allors.Extent<SubContractorRelationship> SubContractorRelationshipsWhereSubContractor
		{ 
			get;
		}

		bool ExistSubContractorRelationshipsWhereSubContractor
		{
			get;
		}


		global::Allors.Extent<WebSiteCommunication> WebSiteCommunicationsWhereOriginator
		{ 
			get;
		}

		bool ExistWebSiteCommunicationsWhereOriginator
		{
			get;
		}


		global::Allors.Extent<WebSiteCommunication> WebSiteCommunicationsWhereReceiver
		{ 
			get;
		}

		bool ExistWebSiteCommunicationsWhereReceiver
		{
			get;
		}


		global::Allors.Extent<PartyProductRevenueHistory> PartyProductRevenueHistoriesWhereParty
		{ 
			get;
		}

		bool ExistPartyProductRevenueHistoriesWhereParty
		{
			get;
		}


		global::Allors.Extent<UserGroup> UserGroupsWhereParty
		{ 
			get;
		}

		bool ExistUserGroupsWhereParty
		{
			get;
		}

	}

	public class PartyMeta
	{
		public static readonly PartyMeta Instance = new PartyMeta();

		public global::Allors.Meta.Interface ObjectType = global::Allors.Meta.Interfaces.Party;

		public global::Allors.Meta.RoleType YTDRevenue 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyYTDRevenue;
			}
		} 
		public global::Allors.Meta.RoleType LastYearsRevenue 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyLastYearsRevenue;
			}
		} 
		public global::Allors.Meta.RoleType BillingInquiriesFax 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyBillingInquiriesFax;
			}
		} 
		public global::Allors.Meta.RoleType Qualification 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyQualification;
			}
		} 
		public global::Allors.Meta.RoleType HomeAddress 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyHomeAddress;
			}
		} 
		public global::Allors.Meta.RoleType SalesOffice 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartySalesOffice;
			}
		} 
		public global::Allors.Meta.RoleType OrderInquiriesFax 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyOrderInquiriesFax;
			}
		} 
		public global::Allors.Meta.RoleType CurrentSalesRep 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyCurrentSalesRep;
			}
		} 
		public global::Allors.Meta.RoleType PartyContactMechanism 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyPartyContactMechanism;
			}
		} 
		public global::Allors.Meta.RoleType ShippingInquiriesFax 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyShippingInquiriesFax;
			}
		} 
		public global::Allors.Meta.RoleType ShippingInquiriesPhone 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyShippingInquiriesPhone;
			}
		} 
		public global::Allors.Meta.RoleType BillingAccount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyBillingAccount;
			}
		} 
		public global::Allors.Meta.RoleType OrderInquiriesPhone 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyOrderInquiriesPhone;
			}
		} 
		public global::Allors.Meta.RoleType PartySkill 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyPartySkill;
			}
		} 
		public global::Allors.Meta.RoleType PartyClassification 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyPartyClassification;
			}
		} 
		public global::Allors.Meta.RoleType ExcludeFromDunning 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyExcludeFromDunning;
			}
		} 
		public global::Allors.Meta.RoleType BankAccount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyBankAccount;
			}
		} 
		public global::Allors.Meta.RoleType BillingAddress 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyBillingAddress;
			}
		} 
		public global::Allors.Meta.RoleType DefaultShipmentMethod 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyDefaultShipmentMethod;
			}
		} 
		public global::Allors.Meta.RoleType Resume 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyResume;
			}
		} 
		public global::Allors.Meta.RoleType HeadQuarter 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyHeadQuarter;
			}
		} 
		public global::Allors.Meta.RoleType PersonalEmailAddress 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyPersonalEmailAddress;
			}
		} 
		public global::Allors.Meta.RoleType CellPhoneNumber 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyCellPhoneNumber;
			}
		} 
		public global::Allors.Meta.RoleType BillingInquiriesPhone 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyBillingInquiriesPhone;
			}
		} 
		public global::Allors.Meta.RoleType PartyName 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyPartyName;
			}
		} 
		public global::Allors.Meta.RoleType OrderAddress 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyOrderAddress;
			}
		} 
		public global::Allors.Meta.RoleType InternetAddress 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyInternetAddress;
			}
		} 
		public global::Allors.Meta.RoleType Content 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyContent;
			}
		} 
		public global::Allors.Meta.RoleType CreditCard 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyCreditCard;
			}
		} 
		public global::Allors.Meta.RoleType ShippingAddress 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyShippingAddress;
			}
		} 
		public global::Allors.Meta.RoleType OpenOrderAmount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyOpenOrderAmount;
			}
		} 
		public global::Allors.Meta.RoleType GeneralFaxNumber 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyGeneralFaxNumber;
			}
		} 
		public global::Allors.Meta.RoleType DefaultPaymentMethod 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyDefaultPaymentMethod;
			}
		} 
		public global::Allors.Meta.RoleType GeneralPhoneNumber 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyGeneralPhoneNumber;
			}
		} 
		public global::Allors.Meta.RoleType PreferredCurrency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyPreferredCurrency;
			}
		} 
		public global::Allors.Meta.RoleType VatRegime 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyVatRegime;
			}
		} 
		public global::Allors.Meta.RoleType Locale 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.LocalisedLocale;
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
		public global::Allors.Meta.RoleType OwnerSecurityToken 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SecurityTokenOwnerOwnerSecurityToken;
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

		public global::Allors.Meta.AssociationType QuoteItemsWhereAuthorizer 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.QuoteItemAuthorizer;
			}
		} 
		public global::Allors.Meta.AssociationType SalesRepPartyProductCategoryRevenuesWhereParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesRepPartyProductCategoryRevenueParty;
			}
		} 
		public global::Allors.Meta.AssociationType PartyProductCategoryRevenueHistoriesWhereParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyProductCategoryRevenueHistoryParty;
			}
		} 
		public global::Allors.Meta.AssociationType LetterCorrespondencesWhereOriginator 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.LetterCorrespondenceOriginator;
			}
		} 
		public global::Allors.Meta.AssociationType LetterCorrespondencesWhereReceiver 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.LetterCorrespondenceReceiver;
			}
		} 
		public global::Allors.Meta.AssociationType PurchaseOrdersWherePreviousTakenViaSupplier 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseOrderPreviousTakenViaSupplier;
			}
		} 
		public global::Allors.Meta.AssociationType PurchaseOrdersWhereTakenViaSupplier 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseOrderTakenViaSupplier;
			}
		} 
		public global::Allors.Meta.AssociationType QuotesWhereIssuer 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.QuoteIssuer;
			}
		} 
		public global::Allors.Meta.AssociationType QuotesWhereReceiver 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.QuoteReceiver;
			}
		} 
		public global::Allors.Meta.AssociationType SupplierOfferingsWhereSupplier 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SupplierOfferingSupplier;
			}
		} 
		public global::Allors.Meta.AssociationType WorkEffortPartyAssignmentsWhereParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.WorkEffortPartyAssignmentParty;
			}
		} 
		public global::Allors.Meta.AssociationType PartyRevenueHistoriesWhereParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyRevenueHistoryParty;
			}
		} 
		public global::Allors.Meta.AssociationType FaxCommunicationsWhereOriginator 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.FaxCommunicationOriginator;
			}
		} 
		public global::Allors.Meta.AssociationType FaxCommunicationsWhereReceiver 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.FaxCommunicationReceiver;
			}
		} 
		public global::Allors.Meta.AssociationType PickListsWhereShipToParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PickListShipToParty;
			}
		} 
		public global::Allors.Meta.AssociationType RequestsWhereOriginator 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.RequestOriginator;
			}
		} 
		public global::Allors.Meta.AssociationType PriceComponentsWhereSpecifiedFor 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PriceComponentSpecifiedFor;
			}
		} 
		public global::Allors.Meta.AssociationType PartyProductRevenuesWhereParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyProductRevenueParty;
			}
		} 
		public global::Allors.Meta.AssociationType CustomerRelationshipsWhereCustomer 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CustomerRelationshipCustomer;
			}
		} 
		public global::Allors.Meta.AssociationType PartyProductCategoryRevenuesWhereParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyProductCategoryRevenueParty;
			}
		} 
		public global::Allors.Meta.AssociationType PartyFixedAssetAssignmentsWhereParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyFixedAssetAssignmentParty;
			}
		} 
		public global::Allors.Meta.AssociationType RespondingPartiesWhereParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.RespondingPartyParty;
			}
		} 
		public global::Allors.Meta.AssociationType ProductsWhereManufacturedBy 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductManufacturedBy;
			}
		} 
		public global::Allors.Meta.AssociationType OrganisationGlAccountsWhereParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.OrganisationGlAccountParty;
			}
		} 
		public global::Allors.Meta.AssociationType SalesInvoicesWherePreviousBillToCustomer 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesInvoicePreviousBillToCustomer;
			}
		} 
		public global::Allors.Meta.AssociationType SalesInvoicesWherePreviousShipToCustomer 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesInvoicePreviousShipToCustomer;
			}
		} 
		public global::Allors.Meta.AssociationType SalesInvoicesWhereBillToCustomer 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesInvoiceBillToCustomer;
			}
		} 
		public global::Allors.Meta.AssociationType SalesInvoicesWhereShipToCustomer 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesInvoiceShipToCustomer;
			}
		} 
		public global::Allors.Meta.AssociationType SalesInvoicesWhereCustomer 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesInvoiceCustomer;
			}
		} 
		public global::Allors.Meta.AssociationType ExternalAccountingTransactionsWhereFromParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ExternalAccountingTransactionFromParty;
			}
		} 
		public global::Allors.Meta.AssociationType ExternalAccountingTransactionsWhereToParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ExternalAccountingTransactionToParty;
			}
		} 
		public global::Allors.Meta.AssociationType SalesRepRelationshipsWhereCustomer 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesRepRelationshipCustomer;
			}
		} 
		public global::Allors.Meta.AssociationType PartyRevenuesWhereParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyRevenueParty;
			}
		} 
		public global::Allors.Meta.AssociationType SalesOrdersWhereShipToCustomer 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesOrderShipToCustomer;
			}
		} 
		public global::Allors.Meta.AssociationType SalesOrdersWhereBillToCustomer 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesOrderBillToCustomer;
			}
		} 
		public global::Allors.Meta.AssociationType SalesOrdersWherePreviousShipToCustomer 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesOrderPreviousShipToCustomer;
			}
		} 
		public global::Allors.Meta.AssociationType SalesOrdersWhereCustomer 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesOrderCustomer;
			}
		} 
		public global::Allors.Meta.AssociationType SalesOrdersWherePreviousBillToCustomer 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesOrderPreviousBillToCustomer;
			}
		} 
		public global::Allors.Meta.AssociationType SalesOrdersWherePlacingCustomer 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesOrderPlacingCustomer;
			}
		} 
		public global::Allors.Meta.AssociationType EngagementsWhereBillToParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.EngagementBillToParty;
			}
		} 
		public global::Allors.Meta.AssociationType EngagementsWherePlacingParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.EngagementPlacingParty;
			}
		} 
		public global::Allors.Meta.AssociationType SalesRepPartyRevenuesWhereParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesRepPartyRevenueParty;
			}
		} 
		public global::Allors.Meta.AssociationType PurchaseInvoicesWhereBilledFromParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseInvoiceBilledFromParty;
			}
		} 
		public global::Allors.Meta.AssociationType PartyPackageRevenueHistoriesWhereParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyPackageRevenueHistoryParty;
			}
		} 
		public global::Allors.Meta.AssociationType SalesOrderItemsWhereShipToParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesOrderItemShipToParty;
			}
		} 
		public global::Allors.Meta.AssociationType SalesOrderItemsWhereAssignedShipToParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesOrderItemAssignedShipToParty;
			}
		} 
		public global::Allors.Meta.AssociationType PartyPackageRevenuesWhereParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyPackageRevenueParty;
			}
		} 
		public global::Allors.Meta.AssociationType ShipmentsWhereBillToParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ShipmentBillToParty;
			}
		} 
		public global::Allors.Meta.AssociationType ShipmentsWhereShipToParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ShipmentShipToParty;
			}
		} 
		public global::Allors.Meta.AssociationType ShipmentsWhereShipFromParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ShipmentShipFromParty;
			}
		} 
		public global::Allors.Meta.AssociationType PaymentsWhereSendingParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PaymentSendingParty;
			}
		} 
		public global::Allors.Meta.AssociationType PaymentsWhereReceivingParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PaymentReceivingParty;
			}
		} 
		public global::Allors.Meta.AssociationType ClientRelationshipsWhereClient 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ClientRelationshipClient;
			}
		} 
		public global::Allors.Meta.AssociationType CommunicationEventsWhereInvolvedParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CommunicationEventInvolvedParty;
			}
		} 
		public global::Allors.Meta.AssociationType InternalOrganisationWhereCustomer 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InternalOrganisationCustomer;
			}
		} 
		public global::Allors.Meta.AssociationType InternalOrganisationWhereSupplier 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InternalOrganisationSupplier;
			}
		} 
		public global::Allors.Meta.AssociationType RequirementsWhereAuthorizer 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.RequirementAuthorizer;
			}
		} 
		public global::Allors.Meta.AssociationType RequirementsWhereNeededFor 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.RequirementNeededFor;
			}
		} 
		public global::Allors.Meta.AssociationType RequirementsWhereOriginator 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.RequirementOriginator;
			}
		} 
		public global::Allors.Meta.AssociationType RequirementsWhereServicedBy 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.RequirementServicedBy;
			}
		} 
		public global::Allors.Meta.AssociationType SubContractorRelationshipsWhereContractor 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SubContractorRelationshipContractor;
			}
		} 
		public global::Allors.Meta.AssociationType SubContractorRelationshipsWhereSubContractor 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SubContractorRelationshipSubContractor;
			}
		} 
		public global::Allors.Meta.AssociationType WebSiteCommunicationsWhereOriginator 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.WebSiteCommunicationOriginator;
			}
		} 
		public global::Allors.Meta.AssociationType WebSiteCommunicationsWhereReceiver 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.WebSiteCommunicationReceiver;
			}
		} 
		public global::Allors.Meta.AssociationType PartyProductRevenueHistoriesWhereParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyProductRevenueHistoryParty;
			}
		} 
		public global::Allors.Meta.AssociationType UserGroupsWhereParty 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.UserGroupParty;
			}
		} 

	}
}