// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class ExpenseEntry : Allors.ObjectBase , ServiceEntry
	{
		public static readonly ExpenseEntryMeta Meta = ExpenseEntryMeta.Instance;

		public ExpenseEntry(Allors.IStrategy allors) : base(allors) {}

		public static ExpenseEntry Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (ExpenseEntry) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.Decimal? Amount 
		{
			get
			{
				return (global::System.Decimal?) Strategy.GetUnitRole(Meta.Amount);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Amount, value);
			}
		}

		virtual public bool ExistAmount{
			get
			{
				return Strategy.ExistUnitRole(Meta.Amount);
			}
		}

		virtual public void RemoveAmount()
		{
			Strategy.RemoveUnitRole(Meta.Amount);
		}



		virtual public global::System.DateTime? ThroughDateTime 
		{
			get
			{
				return (global::System.DateTime?) Strategy.GetUnitRole(Meta.ThroughDateTime);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ThroughDateTime, value);
			}
		}

		virtual public bool ExistThroughDateTime{
			get
			{
				return Strategy.ExistUnitRole(Meta.ThroughDateTime);
			}
		}

		virtual public void RemoveThroughDateTime()
		{
			Strategy.RemoveUnitRole(Meta.ThroughDateTime);
		}


		virtual public EngagementItem EngagementItem
		{ 
			get
			{
				return (EngagementItem) Strategy.GetCompositeRole(Meta.EngagementItem);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.EngagementItem ,value);
			}
		}

		virtual public bool ExistEngagementItem
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.EngagementItem);
			}
		}

		virtual public void RemoveEngagementItem()
		{
			Strategy.RemoveCompositeRole(Meta.EngagementItem);
		}



		virtual public global::System.Boolean? IsBillable 
		{
			get
			{
				return (global::System.Boolean?) Strategy.GetUnitRole(Meta.IsBillable);
			}
			set
			{
				Strategy.SetUnitRole(Meta.IsBillable, value);
			}
		}

		virtual public bool ExistIsBillable{
			get
			{
				return Strategy.ExistUnitRole(Meta.IsBillable);
			}
		}

		virtual public void RemoveIsBillable()
		{
			Strategy.RemoveUnitRole(Meta.IsBillable);
		}



		virtual public global::System.DateTime? FromDateTime 
		{
			get
			{
				return (global::System.DateTime?) Strategy.GetUnitRole(Meta.FromDateTime);
			}
			set
			{
				Strategy.SetUnitRole(Meta.FromDateTime, value);
			}
		}

		virtual public bool ExistFromDateTime{
			get
			{
				return Strategy.ExistUnitRole(Meta.FromDateTime);
			}
		}

		virtual public void RemoveFromDateTime()
		{
			Strategy.RemoveUnitRole(Meta.FromDateTime);
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


		virtual public WorkEffort WorkEffort
		{ 
			get
			{
				return (WorkEffort) Strategy.GetCompositeRole(Meta.WorkEffort);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.WorkEffort ,value);
			}
		}

		virtual public bool ExistWorkEffort
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.WorkEffort);
			}
		}

		virtual public void RemoveWorkEffort()
		{
			Strategy.RemoveCompositeRole(Meta.WorkEffort);
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



		virtual public ServiceEntryHeader ServiceEntryHeaderWhereServiceEntry
		{ 
			get
			{
				return (ServiceEntryHeader) Strategy.GetCompositeAssociation(Meta.ServiceEntryHeaderWhereServiceEntry);
			}
		} 

		virtual public bool ExistServiceEntryHeaderWhereServiceEntry
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.ServiceEntryHeaderWhereServiceEntry);
			}
		}


		virtual public global::Allors.Extent<ServiceEntryBilling> ServiceEntryBillingsWhereServiceEntry
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ServiceEntryBillingsWhereServiceEntry);
			}
		}

		virtual public bool ExistServiceEntryBillingsWhereServiceEntry
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ServiceEntryBillingsWhereServiceEntry);
			}
		}

	}

	public class ExpenseEntryMeta
	{
		public static readonly ExpenseEntryMeta Instance = new ExpenseEntryMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.ExpenseEntry;

		public global::Allors.Meta.RoleType Amount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ExpenseEntryAmount;
			}
		} 
		public global::Allors.Meta.RoleType ThroughDateTime 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ServiceEntryThroughDateTime;
			}
		} 
		public global::Allors.Meta.RoleType EngagementItem 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ServiceEntryEngagementItem;
			}
		} 
		public global::Allors.Meta.RoleType IsBillable 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ServiceEntryIsBillable;
			}
		} 
		public global::Allors.Meta.RoleType FromDateTime 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ServiceEntryFromDateTime;
			}
		} 
		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ServiceEntryDescription;
			}
		} 
		public global::Allors.Meta.RoleType WorkEffort 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ServiceEntryWorkEffort;
			}
		} 
		public global::Allors.Meta.RoleType Comment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommentableComment;
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

		public global::Allors.Meta.AssociationType ServiceEntryHeaderWhereServiceEntry 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ServiceEntryHeaderServiceEntry;
			}
		} 
		public global::Allors.Meta.AssociationType ServiceEntryBillingsWhereServiceEntry 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ServiceEntryBillingServiceEntry;
			}
		} 

	}
}