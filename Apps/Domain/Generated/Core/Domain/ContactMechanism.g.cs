// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface ContactMechanism :  UserInterfaceable,Searchable, Allors.IObjectBase
	{


		global::System.String Description 
		{
			get;
			set;
		}

		bool ExistDescription{get;}

		void RemoveDescription();


		global::Allors.Extent<ContactMechanism> FollowTo
		{ 
			get;
			set;
		}

		void AddFollowTo (ContactMechanism value);

		void RemoveFollowTo (ContactMechanism value);

		bool ExistFollowTo
		{
			get;
		}

		void RemoveFollowTo();



		global::Allors.Extent<PurchaseOrder> PurchaseOrdersWhereTakenViaContactMechanism
		{ 
			get;
		}

		bool ExistPurchaseOrdersWhereTakenViaContactMechanism
		{
			get;
		}


		global::Allors.Extent<PurchaseOrder> PurchaseOrdersWhereBillToContactMechanism
		{ 
			get;
		}

		bool ExistPurchaseOrdersWhereBillToContactMechanism
		{
			get;
		}


		BankAccount BankAccountWhereContactMechanism
		{
			get;
		}

		bool ExistBankAccountWhereContactMechanism
		{
			get;
		}


		global::Allors.Extent<BillingAccount> BillingAccountsWhereContactMechanism
		{ 
			get;
		}

		bool ExistBillingAccountsWhereContactMechanism
		{
			get;
		}


		global::Allors.Extent<Party> PartiesWhereHomeAddress
		{ 
			get;
		}

		bool ExistPartiesWhereHomeAddress
		{
			get;
		}


		global::Allors.Extent<Party> PartiesWhereSalesOffice
		{ 
			get;
		}

		bool ExistPartiesWhereSalesOffice
		{
			get;
		}


		global::Allors.Extent<Party> PartiesWhereBillingAddress
		{ 
			get;
		}

		bool ExistPartiesWhereBillingAddress
		{
			get;
		}


		global::Allors.Extent<Party> PartiesWhereHeadQuarter
		{ 
			get;
		}

		bool ExistPartiesWhereHeadQuarter
		{
			get;
		}


		global::Allors.Extent<Party> PartiesWhereOrderAddress
		{ 
			get;
		}

		bool ExistPartiesWhereOrderAddress
		{
			get;
		}


		global::Allors.Extent<RespondingParty> RespondingPartiesWhereContactMechanism
		{ 
			get;
		}

		bool ExistRespondingPartiesWhereContactMechanism
		{
			get;
		}


		global::Allors.Extent<SalesInvoice> SalesInvoicesWhereBillToContactMechanism
		{ 
			get;
		}

		bool ExistSalesInvoicesWhereBillToContactMechanism
		{
			get;
		}


		global::Allors.Extent<SalesInvoice> SalesInvoicesWhereBilledFromContactMechanism
		{ 
			get;
		}

		bool ExistSalesInvoicesWhereBilledFromContactMechanism
		{
			get;
		}


		global::Allors.Extent<SalesOrder> SalesOrdersWhereTakenByContactMechanism
		{ 
			get;
		}

		bool ExistSalesOrdersWhereTakenByContactMechanism
		{
			get;
		}


		global::Allors.Extent<SalesOrder> SalesOrdersWhereBillToContactMechanism
		{ 
			get;
		}

		bool ExistSalesOrdersWhereBillToContactMechanism
		{
			get;
		}


		global::Allors.Extent<SalesOrder> SalesOrdersWhereBillFromContactMechanism
		{ 
			get;
		}

		bool ExistSalesOrdersWhereBillFromContactMechanism
		{
			get;
		}


		global::Allors.Extent<SalesOrder> SalesOrdersWherePlacingContactMechanism
		{ 
			get;
		}

		bool ExistSalesOrdersWherePlacingContactMechanism
		{
			get;
		}


		global::Allors.Extent<Engagement> EngagementsWherePlacingContactMechanism
		{ 
			get;
		}

		bool ExistEngagementsWherePlacingContactMechanism
		{
			get;
		}


		global::Allors.Extent<Engagement> EngagementsWhereBillToContactMechanism
		{ 
			get;
		}

		bool ExistEngagementsWhereBillToContactMechanism
		{
			get;
		}


		global::Allors.Extent<Engagement> EngagementsWhereTakenViaContactMechanism
		{ 
			get;
		}

		bool ExistEngagementsWhereTakenViaContactMechanism
		{
			get;
		}


		global::Allors.Extent<Shipment> ShipmentsWhereBillToContactMechanism
		{ 
			get;
		}

		bool ExistShipmentsWhereBillToContactMechanism
		{
			get;
		}


		global::Allors.Extent<Shipment> ShipmentsWhereReceiverContactMechanism
		{ 
			get;
		}

		bool ExistShipmentsWhereReceiverContactMechanism
		{
			get;
		}


		global::Allors.Extent<Shipment> ShipmentsWhereInquireAboutContactMechanism
		{ 
			get;
		}

		bool ExistShipmentsWhereInquireAboutContactMechanism
		{
			get;
		}


		global::Allors.Extent<Shipment> ShipmentsWhereBillFromContactMechanism
		{ 
			get;
		}

		bool ExistShipmentsWhereBillFromContactMechanism
		{
			get;
		}


		global::Allors.Extent<ContactMechanism> ContactMechanismsWhereFollowTo
		{ 
			get;
		}

		bool ExistContactMechanismsWhereFollowTo
		{
			get;
		}


		global::Allors.Extent<PartyContactMechanism> PartyContactMechanismsWhereContactMechanism
		{ 
			get;
		}

		bool ExistPartyContactMechanismsWhereContactMechanism
		{
			get;
		}


		global::Allors.Extent<Facility> FacilitiesWhereFacilityContactMechanism
		{ 
			get;
		}

		bool ExistFacilitiesWhereFacilityContactMechanism
		{
			get;
		}

	}

	public class ContactMechanismMeta
	{
		public static readonly ContactMechanismMeta Instance = new ContactMechanismMeta();

		public global::Allors.Meta.Interface ObjectType = global::Allors.Meta.Interfaces.ContactMechanism;

		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ContactMechanismDescription;
			}
		} 
		public global::Allors.Meta.RoleType FollowTo 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ContactMechanismFollowTo;
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

		public global::Allors.Meta.AssociationType PurchaseOrdersWhereTakenViaContactMechanism 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseOrderTakenViaContactMechanism;
			}
		} 
		public global::Allors.Meta.AssociationType PurchaseOrdersWhereBillToContactMechanism 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseOrderBillToContactMechanism;
			}
		} 
		public global::Allors.Meta.AssociationType BankAccountWhereContactMechanism 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.BankAccountContactMechanism;
			}
		} 
		public global::Allors.Meta.AssociationType BillingAccountsWhereContactMechanism 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.BillingAccountContactMechanism;
			}
		} 
		public global::Allors.Meta.AssociationType PartiesWhereHomeAddress 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyHomeAddress;
			}
		} 
		public global::Allors.Meta.AssociationType PartiesWhereSalesOffice 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartySalesOffice;
			}
		} 
		public global::Allors.Meta.AssociationType PartiesWhereBillingAddress 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyBillingAddress;
			}
		} 
		public global::Allors.Meta.AssociationType PartiesWhereHeadQuarter 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyHeadQuarter;
			}
		} 
		public global::Allors.Meta.AssociationType PartiesWhereOrderAddress 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyOrderAddress;
			}
		} 
		public global::Allors.Meta.AssociationType RespondingPartiesWhereContactMechanism 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.RespondingPartyContactMechanism;
			}
		} 
		public global::Allors.Meta.AssociationType SalesInvoicesWhereBillToContactMechanism 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesInvoiceBillToContactMechanism;
			}
		} 
		public global::Allors.Meta.AssociationType SalesInvoicesWhereBilledFromContactMechanism 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesInvoiceBilledFromContactMechanism;
			}
		} 
		public global::Allors.Meta.AssociationType SalesOrdersWhereTakenByContactMechanism 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesOrderTakenByContactMechanism;
			}
		} 
		public global::Allors.Meta.AssociationType SalesOrdersWhereBillToContactMechanism 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesOrderBillToContactMechanism;
			}
		} 
		public global::Allors.Meta.AssociationType SalesOrdersWhereBillFromContactMechanism 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesOrderBillFromContactMechanism;
			}
		} 
		public global::Allors.Meta.AssociationType SalesOrdersWherePlacingContactMechanism 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesOrderPlacingContactMechanism;
			}
		} 
		public global::Allors.Meta.AssociationType EngagementsWherePlacingContactMechanism 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.EngagementPlacingContactMechanism;
			}
		} 
		public global::Allors.Meta.AssociationType EngagementsWhereBillToContactMechanism 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.EngagementBillToContactMechanism;
			}
		} 
		public global::Allors.Meta.AssociationType EngagementsWhereTakenViaContactMechanism 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.EngagementTakenViaContactMechanism;
			}
		} 
		public global::Allors.Meta.AssociationType ShipmentsWhereBillToContactMechanism 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ShipmentBillToContactMechanism;
			}
		} 
		public global::Allors.Meta.AssociationType ShipmentsWhereReceiverContactMechanism 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ShipmentReceiverContactMechanism;
			}
		} 
		public global::Allors.Meta.AssociationType ShipmentsWhereInquireAboutContactMechanism 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ShipmentInquireAboutContactMechanism;
			}
		} 
		public global::Allors.Meta.AssociationType ShipmentsWhereBillFromContactMechanism 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ShipmentBillFromContactMechanism;
			}
		} 
		public global::Allors.Meta.AssociationType ContactMechanismsWhereFollowTo 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ContactMechanismFollowTo;
			}
		} 
		public global::Allors.Meta.AssociationType PartyContactMechanismsWhereContactMechanism 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyContactMechanismContactMechanism;
			}
		} 
		public global::Allors.Meta.AssociationType FacilitiesWhereFacilityContactMechanism 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.FacilityFacilityContactMechanism;
			}
		} 

	}
}