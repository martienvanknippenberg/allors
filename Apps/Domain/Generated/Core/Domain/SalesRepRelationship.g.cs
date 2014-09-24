// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class SalesRepRelationship : Allors.ObjectBase , UserInterfaceable, Commentable, AccessControlledObject, Period, PartyRelationship
	{
		public static readonly SalesRepRelationshipMeta Meta = SalesRepRelationshipMeta.Instance;

		public SalesRepRelationship(Allors.IStrategy allors) : base(allors) {}

		public static SalesRepRelationship Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (SalesRepRelationship) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public Person SalesRepresentative
		{ 
			get
			{
				return (Person) Strategy.GetCompositeRole(Meta.SalesRepresentative);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.SalesRepresentative ,value);
			}
		}

		virtual public bool ExistSalesRepresentative
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.SalesRepresentative);
			}
		}

		virtual public void RemoveSalesRepresentative()
		{
			Strategy.RemoveCompositeRole(Meta.SalesRepresentative);
		}



		virtual public global::System.Decimal LastYearsCommission 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.LastYearsCommission);
			}
			set
			{
				Strategy.SetUnitRole(Meta.LastYearsCommission, value);
			}
		}

		virtual public bool ExistLastYearsCommission{
			get
			{
				return Strategy.ExistUnitRole(Meta.LastYearsCommission);
			}
		}

		virtual public void RemoveLastYearsCommission()
		{
			Strategy.RemoveUnitRole(Meta.LastYearsCommission);
		}


		virtual public global::Allors.Extent<ProductCategory> ProductCategories
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.ProductCategory);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.ProductCategory, value);
			}
		}

		virtual public void AddProductCategory (ProductCategory value)
		{
			Strategy.AddCompositeRole(Meta.ProductCategory, value);
		}

		virtual public void RemoveProductCategory (ProductCategory value)
		{
			Strategy.RemoveCompositeRole(Meta.ProductCategory,value);
		}

		virtual public bool ExistProductCategories
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.ProductCategory);
			}
		}

		virtual public void RemoveProductCategories()
		{
			Strategy.RemoveCompositeRoles(Meta.ProductCategory);
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



		virtual public global::System.Decimal YTDCommission 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.YTDCommission);
			}
			set
			{
				Strategy.SetUnitRole(Meta.YTDCommission, value);
			}
		}

		virtual public bool ExistYTDCommission{
			get
			{
				return Strategy.ExistUnitRole(Meta.YTDCommission);
			}
		}

		virtual public void RemoveYTDCommission()
		{
			Strategy.RemoveUnitRole(Meta.YTDCommission);
		}


		virtual public Party Customer
		{ 
			get
			{
				return (Party) Strategy.GetCompositeRole(Meta.Customer);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Customer ,value);
			}
		}

		virtual public bool ExistCustomer
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Customer);
			}
		}

		virtual public void RemoveCustomer()
		{
			Strategy.RemoveCompositeRole(Meta.Customer);
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



		virtual public global::System.String Comment 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Comment);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Comment, value);
			}
		}

		virtual public bool ExistComment{
			get
			{
				return Strategy.ExistUnitRole(Meta.Comment);
			}
		}

		virtual public void RemoveComment()
		{
			Strategy.RemoveUnitRole(Meta.Comment);
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


		virtual public PartyRelationshipStatus PartyRelationshipStatus
		{ 
			get
			{
				return (PartyRelationshipStatus) Strategy.GetCompositeRole(Meta.PartyRelationshipStatus);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.PartyRelationshipStatus ,value);
			}
		}

		virtual public bool ExistPartyRelationshipStatus
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.PartyRelationshipStatus);
			}
		}

		virtual public void RemovePartyRelationshipStatus()
		{
			Strategy.RemoveCompositeRole(Meta.PartyRelationshipStatus);
		}


		virtual public global::Allors.Extent<Agreement> Agreements
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.Agreement);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.Agreement, value);
			}
		}

		virtual public void AddAgreement (Agreement value)
		{
			Strategy.AddCompositeRole(Meta.Agreement, value);
		}

		virtual public void RemoveAgreement (Agreement value)
		{
			Strategy.RemoveCompositeRole(Meta.Agreement,value);
		}

		virtual public bool ExistAgreements
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.Agreement);
			}
		}

		virtual public void RemoveAgreements()
		{
			Strategy.RemoveCompositeRoles(Meta.Agreement);
		}


		virtual public PartyRelationshipPriority PartyRelationshipPriority
		{ 
			get
			{
				return (PartyRelationshipPriority) Strategy.GetCompositeRole(Meta.PartyRelationshipPriority);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.PartyRelationshipPriority ,value);
			}
		}

		virtual public bool ExistPartyRelationshipPriority
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.PartyRelationshipPriority);
			}
		}

		virtual public void RemovePartyRelationshipPriority()
		{
			Strategy.RemoveCompositeRole(Meta.PartyRelationshipPriority);
		}



		virtual public global::System.Decimal SimpleMovingAverage 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.SimpleMovingAverage);
			}
			set
			{
				Strategy.SetUnitRole(Meta.SimpleMovingAverage, value);
			}
		}

		virtual public bool ExistSimpleMovingAverage{
			get
			{
				return Strategy.ExistUnitRole(Meta.SimpleMovingAverage);
			}
		}

		virtual public void RemoveSimpleMovingAverage()
		{
			Strategy.RemoveUnitRole(Meta.SimpleMovingAverage);
		}


		virtual public global::Allors.Extent<CommunicationEvent> CommunicationEvents
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.CommunicationEvent);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.CommunicationEvent, value);
			}
		}

		virtual public void AddCommunicationEvent (CommunicationEvent value)
		{
			Strategy.AddCompositeRole(Meta.CommunicationEvent, value);
		}

		virtual public void RemoveCommunicationEvent (CommunicationEvent value)
		{
			Strategy.RemoveCompositeRole(Meta.CommunicationEvent,value);
		}

		virtual public bool ExistCommunicationEvents
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.CommunicationEvent);
			}
		}

		virtual public void RemoveCommunicationEvents()
		{
			Strategy.RemoveCompositeRoles(Meta.CommunicationEvent);
		}

	}

	public class SalesRepRelationshipMeta
	{
		public static readonly SalesRepRelationshipMeta Instance = new SalesRepRelationshipMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.SalesRepRelationship;

		public global::Allors.Meta.RoleType SalesRepresentative 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SalesRepRelationshipSalesRepresentative;
			}
		} 
		public global::Allors.Meta.RoleType LastYearsCommission 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SalesRepRelationshipLastYearsCommission;
			}
		} 
		public global::Allors.Meta.RoleType ProductCategory 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SalesRepRelationshipProductCategory;
			}
		} 
		public global::Allors.Meta.RoleType InternalOrganisation 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SalesRepRelationshipInternalOrganisation;
			}
		} 
		public global::Allors.Meta.RoleType YTDCommission 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SalesRepRelationshipYTDCommission;
			}
		} 
		public global::Allors.Meta.RoleType Customer 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SalesRepRelationshipCustomer;
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
		public global::Allors.Meta.RoleType Comment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommentableComment;
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
		public global::Allors.Meta.RoleType PartyRelationshipStatus 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyRelationshipPartyRelationshipStatus;
			}
		} 
		public global::Allors.Meta.RoleType Agreement 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyRelationshipAgreement;
			}
		} 
		public global::Allors.Meta.RoleType PartyRelationshipPriority 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyRelationshipPartyRelationshipPriority;
			}
		} 
		public global::Allors.Meta.RoleType SimpleMovingAverage 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyRelationshipSimpleMovingAverage;
			}
		} 
		public global::Allors.Meta.RoleType CommunicationEvent 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartyRelationshipCommunicationEvent;
			}
		} 

	}
}