// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class JournalEntryDetail : Allors.ObjectBase , AccessControlledObject, UserInterfaceable
	{
		public static readonly JournalEntryDetailMeta Meta = JournalEntryDetailMeta.Instance;

		public JournalEntryDetail(Allors.IStrategy allors) : base(allors) {}

		public static JournalEntryDetail Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (JournalEntryDetail) allorsSession.Instantiate(allorsObjectId);		
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



		virtual public global::System.Decimal Amount 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.Amount);
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



		virtual public global::System.Boolean Debit 
		{
			get
			{
				return (global::System.Boolean) Strategy.GetUnitRole(Meta.Debit);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Debit, value);
			}
		}

		virtual public bool ExistDebit{
			get
			{
				return Strategy.ExistUnitRole(Meta.Debit);
			}
		}

		virtual public void RemoveDebit()
		{
			Strategy.RemoveUnitRole(Meta.Debit);
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



		virtual public JournalEntry JournalEntryWhereJournalEntryDetail
		{ 
			get
			{
				return (JournalEntry) Strategy.GetCompositeAssociation(Meta.JournalEntryWhereJournalEntryDetail);
			}
		} 

		virtual public bool ExistJournalEntryWhereJournalEntryDetail
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.JournalEntryWhereJournalEntryDetail);
			}
		}

	}

	public class JournalEntryDetailMeta
	{
		public static readonly JournalEntryDetailMeta Instance = new JournalEntryDetailMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.JournalEntryDetail;

		public global::Allors.Meta.RoleType GeneralLedgerAccount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.JournalEntryDetailGeneralLedgerAccount;
			}
		} 
		public global::Allors.Meta.RoleType Amount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.JournalEntryDetailAmount;
			}
		} 
		public global::Allors.Meta.RoleType Debit 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.JournalEntryDetailDebit;
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
		public global::Allors.Meta.RoleType DisplayName 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UserInterfaceableDisplayName;
			}
		} 

		public global::Allors.Meta.AssociationType JournalEntryWhereJournalEntryDetail 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.JournalEntryJournalEntryDetail;
			}
		} 

	}
}