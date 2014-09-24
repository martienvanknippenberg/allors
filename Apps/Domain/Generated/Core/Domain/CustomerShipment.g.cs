// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class CustomerShipment : Allors.ObjectBase , Shipment
	{
		public static readonly CustomerShipmentMeta Meta = CustomerShipmentMeta.Instance;

		public CustomerShipment(Allors.IStrategy allors) : base(allors) {}

		public static CustomerShipment Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (CustomerShipment) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public CustomerShipmentStatus CurrentShipmentStatus
		{ 
			get
			{
				return (CustomerShipmentStatus) Strategy.GetCompositeRole(Meta.CurrentShipmentStatus);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.CurrentShipmentStatus ,value);
			}
		}

		virtual public bool ExistCurrentShipmentStatus
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.CurrentShipmentStatus);
			}
		}

		virtual public void RemoveCurrentShipmentStatus()
		{
			Strategy.RemoveCompositeRole(Meta.CurrentShipmentStatus);
		}


		virtual public CustomerShipmentObjectState PreviousObjectState
		{ 
			get
			{
				return (CustomerShipmentObjectState) Strategy.GetCompositeRole(Meta.PreviousObjectState);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.PreviousObjectState ,value);
			}
		}

		virtual public bool ExistPreviousObjectState
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.PreviousObjectState);
			}
		}

		virtual public void RemovePreviousObjectState()
		{
			Strategy.RemoveCompositeRole(Meta.PreviousObjectState);
		}



		virtual public global::System.Boolean ReleasedManually 
		{
			get
			{
				return (global::System.Boolean) Strategy.GetUnitRole(Meta.ReleasedManually);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ReleasedManually, value);
			}
		}

		virtual public bool ExistReleasedManually{
			get
			{
				return Strategy.ExistUnitRole(Meta.ReleasedManually);
			}
		}

		virtual public void RemoveReleasedManually()
		{
			Strategy.RemoveUnitRole(Meta.ReleasedManually);
		}


		virtual public CustomerShipmentObjectState CurrentObjectState
		{ 
			get
			{
				return (CustomerShipmentObjectState) Strategy.GetCompositeRole(Meta.CurrentObjectState);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.CurrentObjectState ,value);
			}
		}

		virtual public bool ExistCurrentObjectState
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.CurrentObjectState);
			}
		}

		virtual public void RemoveCurrentObjectState()
		{
			Strategy.RemoveCompositeRole(Meta.CurrentObjectState);
		}


		virtual public global::Allors.Extent<CustomerShipmentStatus> ShipmentStatuses
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.ShipmentStatus);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.ShipmentStatus, value);
			}
		}

		virtual public void AddShipmentStatus (CustomerShipmentStatus value)
		{
			Strategy.AddCompositeRole(Meta.ShipmentStatus, value);
		}

		virtual public void RemoveShipmentStatus (CustomerShipmentStatus value)
		{
			Strategy.RemoveCompositeRole(Meta.ShipmentStatus,value);
		}

		virtual public bool ExistShipmentStatuses
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.ShipmentStatus);
			}
		}

		virtual public void RemoveShipmentStatuses()
		{
			Strategy.RemoveCompositeRoles(Meta.ShipmentStatus);
		}


		virtual public PaymentMethod PaymentMethod
		{ 
			get
			{
				return (PaymentMethod) Strategy.GetCompositeRole(Meta.PaymentMethod);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.PaymentMethod ,value);
			}
		}

		virtual public bool ExistPaymentMethod
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.PaymentMethod);
			}
		}

		virtual public void RemovePaymentMethod()
		{
			Strategy.RemoveCompositeRole(Meta.PaymentMethod);
		}



		virtual public global::System.Boolean WithoutCharges 
		{
			get
			{
				return (global::System.Boolean) Strategy.GetUnitRole(Meta.WithoutCharges);
			}
			set
			{
				Strategy.SetUnitRole(Meta.WithoutCharges, value);
			}
		}

		virtual public bool ExistWithoutCharges{
			get
			{
				return Strategy.ExistUnitRole(Meta.WithoutCharges);
			}
		}

		virtual public void RemoveWithoutCharges()
		{
			Strategy.RemoveUnitRole(Meta.WithoutCharges);
		}



		virtual public global::System.Boolean HeldManually 
		{
			get
			{
				return (global::System.Boolean) Strategy.GetUnitRole(Meta.HeldManually);
			}
			set
			{
				Strategy.SetUnitRole(Meta.HeldManually, value);
			}
		}

		virtual public bool ExistHeldManually{
			get
			{
				return Strategy.ExistUnitRole(Meta.HeldManually);
			}
		}

		virtual public void RemoveHeldManually()
		{
			Strategy.RemoveUnitRole(Meta.HeldManually);
		}



		virtual public global::System.Decimal ShipmentValue 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.ShipmentValue);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ShipmentValue, value);
			}
		}

		virtual public bool ExistShipmentValue{
			get
			{
				return Strategy.ExistUnitRole(Meta.ShipmentValue);
			}
		}

		virtual public void RemoveShipmentValue()
		{
			Strategy.RemoveUnitRole(Meta.ShipmentValue);
		}


		virtual public ShipmentMethod ShipmentMethod
		{ 
			get
			{
				return (ShipmentMethod) Strategy.GetCompositeRole(Meta.ShipmentMethod);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.ShipmentMethod ,value);
			}
		}

		virtual public bool ExistShipmentMethod
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.ShipmentMethod);
			}
		}

		virtual public void RemoveShipmentMethod()
		{
			Strategy.RemoveCompositeRole(Meta.ShipmentMethod);
		}


		virtual public ContactMechanism BillToContactMechanism
		{ 
			get
			{
				return (ContactMechanism) Strategy.GetCompositeRole(Meta.BillToContactMechanism);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.BillToContactMechanism ,value);
			}
		}

		virtual public bool ExistBillToContactMechanism
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.BillToContactMechanism);
			}
		}

		virtual public void RemoveBillToContactMechanism()
		{
			Strategy.RemoveCompositeRole(Meta.BillToContactMechanism);
		}


		virtual public global::Allors.Extent<ShipmentPackage> ShipmentPackages
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.ShipmentPackage);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.ShipmentPackage, value);
			}
		}

		virtual public void AddShipmentPackage (ShipmentPackage value)
		{
			Strategy.AddCompositeRole(Meta.ShipmentPackage, value);
		}

		virtual public void RemoveShipmentPackage (ShipmentPackage value)
		{
			Strategy.RemoveCompositeRole(Meta.ShipmentPackage,value);
		}

		virtual public bool ExistShipmentPackages
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.ShipmentPackage);
			}
		}

		virtual public void RemoveShipmentPackages()
		{
			Strategy.RemoveCompositeRoles(Meta.ShipmentPackage);
		}



		virtual public global::System.String ShipmentNumber 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.ShipmentNumber);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ShipmentNumber, value);
			}
		}

		virtual public bool ExistShipmentNumber{
			get
			{
				return Strategy.ExistUnitRole(Meta.ShipmentNumber);
			}
		}

		virtual public void RemoveShipmentNumber()
		{
			Strategy.RemoveUnitRole(Meta.ShipmentNumber);
		}


		virtual public global::Allors.Extent<Document> Documents
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.Document);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.Document, value);
			}
		}

		virtual public void AddDocument (Document value)
		{
			Strategy.AddCompositeRole(Meta.Document, value);
		}

		virtual public void RemoveDocument (Document value)
		{
			Strategy.RemoveCompositeRole(Meta.Document,value);
		}

		virtual public bool ExistDocuments
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.Document);
			}
		}

		virtual public void RemoveDocuments()
		{
			Strategy.RemoveCompositeRoles(Meta.Document);
		}


		virtual public Party BillToParty
		{ 
			get
			{
				return (Party) Strategy.GetCompositeRole(Meta.BillToParty);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.BillToParty ,value);
			}
		}

		virtual public bool ExistBillToParty
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.BillToParty);
			}
		}

		virtual public void RemoveBillToParty()
		{
			Strategy.RemoveCompositeRole(Meta.BillToParty);
		}


		virtual public Party ShipToParty
		{ 
			get
			{
				return (Party) Strategy.GetCompositeRole(Meta.ShipToParty);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.ShipToParty ,value);
			}
		}

		virtual public bool ExistShipToParty
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.ShipToParty);
			}
		}

		virtual public void RemoveShipToParty()
		{
			Strategy.RemoveCompositeRole(Meta.ShipToParty);
		}


		virtual public global::Allors.Extent<ShipmentItem> ShipmentItems
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.ShipmentItem);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.ShipmentItem, value);
			}
		}

		virtual public void AddShipmentItem (ShipmentItem value)
		{
			Strategy.AddCompositeRole(Meta.ShipmentItem, value);
		}

		virtual public void RemoveShipmentItem (ShipmentItem value)
		{
			Strategy.RemoveCompositeRole(Meta.ShipmentItem,value);
		}

		virtual public bool ExistShipmentItems
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.ShipmentItem);
			}
		}

		virtual public void RemoveShipmentItems()
		{
			Strategy.RemoveCompositeRoles(Meta.ShipmentItem);
		}


		virtual public InternalOrganisation BillFromInternalOrganisation
		{ 
			get
			{
				return (InternalOrganisation) Strategy.GetCompositeRole(Meta.BillFromInternalOrganisation);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.BillFromInternalOrganisation ,value);
			}
		}

		virtual public bool ExistBillFromInternalOrganisation
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.BillFromInternalOrganisation);
			}
		}

		virtual public void RemoveBillFromInternalOrganisation()
		{
			Strategy.RemoveCompositeRole(Meta.BillFromInternalOrganisation);
		}


		virtual public ContactMechanism ReceiverContactMechanism
		{ 
			get
			{
				return (ContactMechanism) Strategy.GetCompositeRole(Meta.ReceiverContactMechanism);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.ReceiverContactMechanism ,value);
			}
		}

		virtual public bool ExistReceiverContactMechanism
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.ReceiverContactMechanism);
			}
		}

		virtual public void RemoveReceiverContactMechanism()
		{
			Strategy.RemoveCompositeRole(Meta.ReceiverContactMechanism);
		}


		virtual public PostalAddress ShipToAddress
		{ 
			get
			{
				return (PostalAddress) Strategy.GetCompositeRole(Meta.ShipToAddress);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.ShipToAddress ,value);
			}
		}

		virtual public bool ExistShipToAddress
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.ShipToAddress);
			}
		}

		virtual public void RemoveShipToAddress()
		{
			Strategy.RemoveCompositeRole(Meta.ShipToAddress);
		}



		virtual public global::System.Decimal EstimatedShipCost 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.EstimatedShipCost);
			}
			set
			{
				Strategy.SetUnitRole(Meta.EstimatedShipCost, value);
			}
		}

		virtual public bool ExistEstimatedShipCost{
			get
			{
				return Strategy.ExistUnitRole(Meta.EstimatedShipCost);
			}
		}

		virtual public void RemoveEstimatedShipCost()
		{
			Strategy.RemoveUnitRole(Meta.EstimatedShipCost);
		}



		virtual public global::System.DateTime EstimatedShipDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.EstimatedShipDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.EstimatedShipDate, value);
			}
		}

		virtual public bool ExistEstimatedShipDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.EstimatedShipDate);
			}
		}

		virtual public void RemoveEstimatedShipDate()
		{
			Strategy.RemoveUnitRole(Meta.EstimatedShipDate);
		}



		virtual public global::System.DateTime LatestCancelDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.LatestCancelDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.LatestCancelDate, value);
			}
		}

		virtual public bool ExistLatestCancelDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.LatestCancelDate);
			}
		}

		virtual public void RemoveLatestCancelDate()
		{
			Strategy.RemoveUnitRole(Meta.LatestCancelDate);
		}


		virtual public Carrier Carrier
		{ 
			get
			{
				return (Carrier) Strategy.GetCompositeRole(Meta.Carrier);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Carrier ,value);
			}
		}

		virtual public bool ExistCarrier
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Carrier);
			}
		}

		virtual public void RemoveCarrier()
		{
			Strategy.RemoveCompositeRole(Meta.Carrier);
		}


		virtual public ContactMechanism InquireAboutContactMechanism
		{ 
			get
			{
				return (ContactMechanism) Strategy.GetCompositeRole(Meta.InquireAboutContactMechanism);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.InquireAboutContactMechanism ,value);
			}
		}

		virtual public bool ExistInquireAboutContactMechanism
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.InquireAboutContactMechanism);
			}
		}

		virtual public void RemoveInquireAboutContactMechanism()
		{
			Strategy.RemoveCompositeRole(Meta.InquireAboutContactMechanism);
		}



		virtual public global::System.DateTime EstimatedReadyDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.EstimatedReadyDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.EstimatedReadyDate, value);
			}
		}

		virtual public bool ExistEstimatedReadyDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.EstimatedReadyDate);
			}
		}

		virtual public void RemoveEstimatedReadyDate()
		{
			Strategy.RemoveUnitRole(Meta.EstimatedReadyDate);
		}


		virtual public PostalAddress ShipFromAddress
		{ 
			get
			{
				return (PostalAddress) Strategy.GetCompositeRole(Meta.ShipFromAddress);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.ShipFromAddress ,value);
			}
		}

		virtual public bool ExistShipFromAddress
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.ShipFromAddress);
			}
		}

		virtual public void RemoveShipFromAddress()
		{
			Strategy.RemoveCompositeRole(Meta.ShipFromAddress);
		}


		virtual public ContactMechanism BillFromContactMechanism
		{ 
			get
			{
				return (ContactMechanism) Strategy.GetCompositeRole(Meta.BillFromContactMechanism);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.BillFromContactMechanism ,value);
			}
		}

		virtual public bool ExistBillFromContactMechanism
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.BillFromContactMechanism);
			}
		}

		virtual public void RemoveBillFromContactMechanism()
		{
			Strategy.RemoveCompositeRole(Meta.BillFromContactMechanism);
		}



		virtual public global::System.String HandlingInstruction 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.HandlingInstruction);
			}
			set
			{
				Strategy.SetUnitRole(Meta.HandlingInstruction, value);
			}
		}

		virtual public bool ExistHandlingInstruction{
			get
			{
				return Strategy.ExistUnitRole(Meta.HandlingInstruction);
			}
		}

		virtual public void RemoveHandlingInstruction()
		{
			Strategy.RemoveUnitRole(Meta.HandlingInstruction);
		}


		virtual public Store Store
		{ 
			get
			{
				return (Store) Strategy.GetCompositeRole(Meta.Store);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Store ,value);
			}
		}

		virtual public bool ExistStore
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Store);
			}
		}

		virtual public void RemoveStore()
		{
			Strategy.RemoveCompositeRole(Meta.Store);
		}


		virtual public Party ShipFromParty
		{ 
			get
			{
				return (Party) Strategy.GetCompositeRole(Meta.ShipFromParty);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.ShipFromParty ,value);
			}
		}

		virtual public bool ExistShipFromParty
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.ShipFromParty);
			}
		}

		virtual public void RemoveShipFromParty()
		{
			Strategy.RemoveCompositeRole(Meta.ShipFromParty);
		}


		virtual public global::Allors.Extent<ShipmentRouteSegment> ShipmentRouteSegments
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.ShipmentRouteSegment);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.ShipmentRouteSegment, value);
			}
		}

		virtual public void AddShipmentRouteSegment (ShipmentRouteSegment value)
		{
			Strategy.AddCompositeRole(Meta.ShipmentRouteSegment, value);
		}

		virtual public void RemoveShipmentRouteSegment (ShipmentRouteSegment value)
		{
			Strategy.RemoveCompositeRole(Meta.ShipmentRouteSegment,value);
		}

		virtual public bool ExistShipmentRouteSegments
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.ShipmentRouteSegment);
			}
		}

		virtual public void RemoveShipmentRouteSegments()
		{
			Strategy.RemoveCompositeRoles(Meta.ShipmentRouteSegment);
		}



		virtual public global::System.DateTime EstimatedArrivalDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.EstimatedArrivalDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.EstimatedArrivalDate, value);
			}
		}

		virtual public bool ExistEstimatedArrivalDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.EstimatedArrivalDate);
			}
		}

		virtual public void RemoveEstimatedArrivalDate()
		{
			Strategy.RemoveUnitRole(Meta.EstimatedArrivalDate);
		}



		virtual public global::System.String PrintContent 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.PrintContent);
			}
			set
			{
				Strategy.SetUnitRole(Meta.PrintContent, value);
			}
		}

		virtual public bool ExistPrintContent{
			get
			{
				return Strategy.ExistUnitRole(Meta.PrintContent);
			}
		}

		virtual public void RemovePrintContent()
		{
			Strategy.RemoveUnitRole(Meta.PrintContent);
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



		virtual public global::System.Guid UniqueId 
		{
			get
			{
				return (global::System.Guid) Strategy.GetUnitRole(Meta.UniqueId);
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



		virtual public PickList PickListWhereCustomerShipmentCorrection
		{ 
			get
			{
				return (PickList) Strategy.GetCompositeAssociation(Meta.PickListWhereCustomerShipmentCorrection);
			}
		} 

		virtual public bool ExistPickListWhereCustomerShipmentCorrection
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.PickListWhereCustomerShipmentCorrection);
			}
		}


		virtual public global::Allors.Extent<SalesInvoice> SalesInvoicesWhereShipment
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesInvoicesWhereShipment);
			}
		}

		virtual public bool ExistSalesInvoicesWhereShipment
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesInvoicesWhereShipment);
			}
		}


		virtual public global::Allors.Extent<PrintQueue> PrintQueuesWherePrintable
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PrintQueuesWherePrintable);
			}
		}

		virtual public bool ExistPrintQueuesWherePrintable
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PrintQueuesWherePrintable);
			}
		}

	}

	public class CustomerShipmentMeta
	{
		public static readonly CustomerShipmentMeta Instance = new CustomerShipmentMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.CustomerShipment;

		public global::Allors.Meta.RoleType CurrentShipmentStatus 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CustomerShipmentCurrentShipmentStatus;
			}
		} 
		public global::Allors.Meta.RoleType PreviousObjectState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CustomerShipmentPreviousObjectState;
			}
		} 
		public global::Allors.Meta.RoleType ReleasedManually 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CustomerShipmentReleasedManually;
			}
		} 
		public global::Allors.Meta.RoleType CurrentObjectState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CustomerShipmentCurrentObjectState;
			}
		} 
		public global::Allors.Meta.RoleType ShipmentStatus 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CustomerShipmentShipmentStatus;
			}
		} 
		public global::Allors.Meta.RoleType PaymentMethod 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CustomerShipmentPaymentMethod;
			}
		} 
		public global::Allors.Meta.RoleType WithoutCharges 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CustomerShipmentWithoutCharges;
			}
		} 
		public global::Allors.Meta.RoleType HeldManually 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CustomerShipmentHeldManually;
			}
		} 
		public global::Allors.Meta.RoleType ShipmentValue 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CustomerShipmentShipmentValue;
			}
		} 
		public global::Allors.Meta.RoleType ShipmentMethod 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentShipmentMethod;
			}
		} 
		public global::Allors.Meta.RoleType BillToContactMechanism 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentBillToContactMechanism;
			}
		} 
		public global::Allors.Meta.RoleType ShipmentPackage 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentShipmentPackage;
			}
		} 
		public global::Allors.Meta.RoleType ShipmentNumber 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentShipmentNumber;
			}
		} 
		public global::Allors.Meta.RoleType Document 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentDocument;
			}
		} 
		public global::Allors.Meta.RoleType BillToParty 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentBillToParty;
			}
		} 
		public global::Allors.Meta.RoleType ShipToParty 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentShipToParty;
			}
		} 
		public global::Allors.Meta.RoleType ShipmentItem 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentShipmentItem;
			}
		} 
		public global::Allors.Meta.RoleType BillFromInternalOrganisation 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentBillFromInternalOrganisation;
			}
		} 
		public global::Allors.Meta.RoleType ReceiverContactMechanism 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentReceiverContactMechanism;
			}
		} 
		public global::Allors.Meta.RoleType ShipToAddress 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentShipToAddress;
			}
		} 
		public global::Allors.Meta.RoleType EstimatedShipCost 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentEstimatedShipCost;
			}
		} 
		public global::Allors.Meta.RoleType EstimatedShipDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentEstimatedShipDate;
			}
		} 
		public global::Allors.Meta.RoleType LatestCancelDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentLatestCancelDate;
			}
		} 
		public global::Allors.Meta.RoleType Carrier 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentCarrier;
			}
		} 
		public global::Allors.Meta.RoleType InquireAboutContactMechanism 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentInquireAboutContactMechanism;
			}
		} 
		public global::Allors.Meta.RoleType EstimatedReadyDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentEstimatedReadyDate;
			}
		} 
		public global::Allors.Meta.RoleType ShipFromAddress 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentShipFromAddress;
			}
		} 
		public global::Allors.Meta.RoleType BillFromContactMechanism 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentBillFromContactMechanism;
			}
		} 
		public global::Allors.Meta.RoleType HandlingInstruction 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentHandlingInstruction;
			}
		} 
		public global::Allors.Meta.RoleType Store 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentStore;
			}
		} 
		public global::Allors.Meta.RoleType ShipFromParty 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentShipFromParty;
			}
		} 
		public global::Allors.Meta.RoleType ShipmentRouteSegment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentShipmentRouteSegment;
			}
		} 
		public global::Allors.Meta.RoleType EstimatedArrivalDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentEstimatedArrivalDate;
			}
		} 
		public global::Allors.Meta.RoleType PrintContent 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PrintablePrintContent;
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

		public global::Allors.Meta.AssociationType PickListWhereCustomerShipmentCorrection 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PickListCustomerShipmentCorrection;
			}
		} 
		public global::Allors.Meta.AssociationType SalesInvoicesWhereShipment 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesInvoiceShipment;
			}
		} 
		public global::Allors.Meta.AssociationType PrintQueuesWherePrintable 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PrintQueuePrintable;
			}
		} 

		public global::Allors.Meta.MethodType Cancel 
		{
			get
			{
				return global::Allors.Meta.MethodTypes.CustomerShipmentCancel;
			}
		} 
		public global::Allors.Meta.MethodType Ship 
		{
			get
			{
				return global::Allors.Meta.MethodTypes.CustomerShipmentShip;
			}
		} 
		public global::Allors.Meta.MethodType Hold 
		{
			get
			{
				return global::Allors.Meta.MethodTypes.CustomerShipmentHold;
			}
		} 
		public global::Allors.Meta.MethodType Continue 
		{
			get
			{
				return global::Allors.Meta.MethodTypes.CustomerShipmentContinue;
			}
		} 

	}
}