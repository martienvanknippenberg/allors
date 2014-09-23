// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class CustomEngagementItem : Allors.ObjectBase , EngagementItem
	{
		public static readonly CustomEngagementItemMeta Meta = CustomEngagementItemMeta.Instance;

		public CustomEngagementItem(Allors.IStrategy allors) : base(allors) {}

		public static CustomEngagementItem Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (CustomEngagementItem) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.String DescriptionOfWork 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.DescriptionOfWork);
			}
			set
			{
				Strategy.SetUnitRole(Meta.DescriptionOfWork, value);
			}
		}

		virtual public bool ExistDescriptionOfWork{
			get
			{
				return Strategy.ExistUnitRole(Meta.DescriptionOfWork);
			}
		}

		virtual public void RemoveDescriptionOfWork()
		{
			Strategy.RemoveUnitRole(Meta.DescriptionOfWork);
		}



		virtual public global::System.Decimal? AgreedUponPrice 
		{
			get
			{
				return (global::System.Decimal?) Strategy.GetUnitRole(Meta.AgreedUponPrice);
			}
			set
			{
				Strategy.SetUnitRole(Meta.AgreedUponPrice, value);
			}
		}

		virtual public bool ExistAgreedUponPrice{
			get
			{
				return Strategy.ExistUnitRole(Meta.AgreedUponPrice);
			}
		}

		virtual public void RemoveAgreedUponPrice()
		{
			Strategy.RemoveUnitRole(Meta.AgreedUponPrice);
		}


		virtual public QuoteItem QuoteItem
		{ 
			get
			{
				return (QuoteItem) Strategy.GetCompositeRole(Meta.QuoteItem);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.QuoteItem ,value);
			}
		}

		virtual public bool ExistQuoteItem
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.QuoteItem);
			}
		}

		virtual public void RemoveQuoteItem()
		{
			Strategy.RemoveCompositeRole(Meta.QuoteItem);
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



		virtual public global::System.DateTime? ExpectedStartDate 
		{
			get
			{
				return (global::System.DateTime?) Strategy.GetUnitRole(Meta.ExpectedStartDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ExpectedStartDate, value);
			}
		}

		virtual public bool ExistExpectedStartDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.ExpectedStartDate);
			}
		}

		virtual public void RemoveExpectedStartDate()
		{
			Strategy.RemoveUnitRole(Meta.ExpectedStartDate);
		}



		virtual public global::System.DateTime? ExpectedEndDate 
		{
			get
			{
				return (global::System.DateTime?) Strategy.GetUnitRole(Meta.ExpectedEndDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ExpectedEndDate, value);
			}
		}

		virtual public bool ExistExpectedEndDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.ExpectedEndDate);
			}
		}

		virtual public void RemoveExpectedEndDate()
		{
			Strategy.RemoveUnitRole(Meta.ExpectedEndDate);
		}


		virtual public WorkEffort EngagementWorkFulfillment
		{ 
			get
			{
				return (WorkEffort) Strategy.GetCompositeRole(Meta.EngagementWorkFulfillment);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.EngagementWorkFulfillment ,value);
			}
		}

		virtual public bool ExistEngagementWorkFulfillment
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.EngagementWorkFulfillment);
			}
		}

		virtual public void RemoveEngagementWorkFulfillment()
		{
			Strategy.RemoveCompositeRole(Meta.EngagementWorkFulfillment);
		}


		virtual public global::Allors.Extent<EngagementRate> EngagementRates
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.EngagementRate);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.EngagementRate, value);
			}
		}

		virtual public void AddEngagementRate (EngagementRate value)
		{
			Strategy.AddCompositeRole(Meta.EngagementRate, value);
		}

		virtual public void RemoveEngagementRate (EngagementRate value)
		{
			Strategy.RemoveCompositeRole(Meta.EngagementRate,value);
		}

		virtual public bool ExistEngagementRates
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.EngagementRate);
			}
		}

		virtual public void RemoveEngagementRates()
		{
			Strategy.RemoveCompositeRoles(Meta.EngagementRate);
		}


		virtual public EngagementRate CurrentEngagementRate
		{ 
			get
			{
				return (EngagementRate) Strategy.GetCompositeRole(Meta.CurrentEngagementRate);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.CurrentEngagementRate ,value);
			}
		}

		virtual public bool ExistCurrentEngagementRate
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.CurrentEngagementRate);
			}
		}

		virtual public void RemoveCurrentEngagementRate()
		{
			Strategy.RemoveCompositeRole(Meta.CurrentEngagementRate);
		}


		virtual public global::Allors.Extent<EngagementItem> OrderedWiths
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.OrderedWith);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.OrderedWith, value);
			}
		}

		virtual public void AddOrderedWith (EngagementItem value)
		{
			Strategy.AddCompositeRole(Meta.OrderedWith, value);
		}

		virtual public void RemoveOrderedWith (EngagementItem value)
		{
			Strategy.RemoveCompositeRole(Meta.OrderedWith,value);
		}

		virtual public bool ExistOrderedWiths
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.OrderedWith);
			}
		}

		virtual public void RemoveOrderedWiths()
		{
			Strategy.RemoveCompositeRoles(Meta.OrderedWith);
		}


		virtual public Person CurrentAssignedProfessional
		{ 
			get
			{
				return (Person) Strategy.GetCompositeRole(Meta.CurrentAssignedProfessional);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.CurrentAssignedProfessional ,value);
			}
		}

		virtual public bool ExistCurrentAssignedProfessional
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.CurrentAssignedProfessional);
			}
		}

		virtual public void RemoveCurrentAssignedProfessional()
		{
			Strategy.RemoveCompositeRole(Meta.CurrentAssignedProfessional);
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


		virtual public ProductFeature ProductFeature
		{ 
			get
			{
				return (ProductFeature) Strategy.GetCompositeRole(Meta.ProductFeature);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.ProductFeature ,value);
			}
		}

		virtual public bool ExistProductFeature
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.ProductFeature);
			}
		}

		virtual public void RemoveProductFeature()
		{
			Strategy.RemoveCompositeRole(Meta.ProductFeature);
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



		virtual public global::Allors.Extent<ServiceEntry> ServiceEntriesWhereEngagementItem
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ServiceEntriesWhereEngagementItem);
			}
		}

		virtual public bool ExistServiceEntriesWhereEngagementItem
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ServiceEntriesWhereEngagementItem);
			}
		}


		virtual public Engagement EngagementWhereEngagementItem
		{ 
			get
			{
				return (Engagement) Strategy.GetCompositeAssociation(Meta.EngagementWhereEngagementItem);
			}
		} 

		virtual public bool ExistEngagementWhereEngagementItem
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.EngagementWhereEngagementItem);
			}
		}


		virtual public global::Allors.Extent<ProfessionalAssignment> ProfessionalAssignmentsWhereEngagementItem
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProfessionalAssignmentsWhereEngagementItem);
			}
		}

		virtual public bool ExistProfessionalAssignmentsWhereEngagementItem
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProfessionalAssignmentsWhereEngagementItem);
			}
		}


		virtual public EngagementItem EngagementItemWhereOrderedWith
		{ 
			get
			{
				return (EngagementItem) Strategy.GetCompositeAssociation(Meta.EngagementItemWhereOrderedWith);
			}
		} 

		virtual public bool ExistEngagementItemWhereOrderedWith
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.EngagementItemWhereOrderedWith);
			}
		}

	}

	public class CustomEngagementItemMeta
	{
		public static readonly CustomEngagementItemMeta Instance = new CustomEngagementItemMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.CustomEngagementItem;

		public global::Allors.Meta.RoleType DescriptionOfWork 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CustomEngagementItemDescriptionOfWork;
			}
		} 
		public global::Allors.Meta.RoleType AgreedUponPrice 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CustomEngagementItemAgreedUponPrice;
			}
		} 
		public global::Allors.Meta.RoleType QuoteItem 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EngagementItemQuoteItem;
			}
		} 
		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EngagementItemDescription;
			}
		} 
		public global::Allors.Meta.RoleType ExpectedStartDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EngagementItemExpectedStartDate;
			}
		} 
		public global::Allors.Meta.RoleType ExpectedEndDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EngagementItemExpectedEndDate;
			}
		} 
		public global::Allors.Meta.RoleType EngagementWorkFulfillment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EngagementItemEngagementWorkFulfillment;
			}
		} 
		public global::Allors.Meta.RoleType EngagementRate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EngagementItemEngagementRate;
			}
		} 
		public global::Allors.Meta.RoleType CurrentEngagementRate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EngagementItemCurrentEngagementRate;
			}
		} 
		public global::Allors.Meta.RoleType OrderedWith 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EngagementItemOrderedWith;
			}
		} 
		public global::Allors.Meta.RoleType CurrentAssignedProfessional 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EngagementItemCurrentAssignedProfessional;
			}
		} 
		public global::Allors.Meta.RoleType Product 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EngagementItemProduct;
			}
		} 
		public global::Allors.Meta.RoleType ProductFeature 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EngagementItemProductFeature;
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

		public global::Allors.Meta.AssociationType ServiceEntriesWhereEngagementItem 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ServiceEntryEngagementItem;
			}
		} 
		public global::Allors.Meta.AssociationType EngagementWhereEngagementItem 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.EngagementEngagementItem;
			}
		} 
		public global::Allors.Meta.AssociationType ProfessionalAssignmentsWhereEngagementItem 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProfessionalAssignmentEngagementItem;
			}
		} 
		public global::Allors.Meta.AssociationType EngagementItemWhereOrderedWith 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.EngagementItemOrderedWith;
			}
		} 

	}
}