// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class InternalOrganisationAccountingPreference : Allors.ObjectBase , AccessControlledObject, UserInterfaceable, Searchable
	{
		public static readonly InternalOrganisationAccountingPreferenceMeta Meta = InternalOrganisationAccountingPreferenceMeta.Instance;

		public InternalOrganisationAccountingPreference(Allors.IStrategy allors) : base(allors) {}

		public static InternalOrganisationAccountingPreference Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (InternalOrganisationAccountingPreference) allorsSession.Instantiate(allorsObjectId);		
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


		virtual public InventoryItemKind InventoryItemKind
		{ 
			get
			{
				return (InventoryItemKind) Strategy.GetCompositeRole(Meta.InventoryItemKind);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.InventoryItemKind ,value);
			}
		}

		virtual public bool ExistInventoryItemKind
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.InventoryItemKind);
			}
		}

		virtual public void RemoveInventoryItemKind()
		{
			Strategy.RemoveCompositeRole(Meta.InventoryItemKind);
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


		virtual public Receipt Receipt
		{ 
			get
			{
				return (Receipt) Strategy.GetCompositeRole(Meta.Receipt);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Receipt ,value);
			}
		}

		virtual public bool ExistReceipt
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Receipt);
			}
		}

		virtual public void RemoveReceipt()
		{
			Strategy.RemoveCompositeRole(Meta.Receipt);
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

	}

	public class InternalOrganisationAccountingPreferenceMeta
	{
		public static readonly InternalOrganisationAccountingPreferenceMeta Instance = new InternalOrganisationAccountingPreferenceMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.InternalOrganisationAccountingPreference;

		public global::Allors.Meta.RoleType GeneralLedgerAccount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InternalOrganisationAccountingPreferenceGeneralLedgerAccount;
			}
		} 
		public global::Allors.Meta.RoleType InventoryItemKind 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InternalOrganisationAccountingPreferenceInventoryItemKind;
			}
		} 
		public global::Allors.Meta.RoleType PaymentMethod 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InternalOrganisationAccountingPreferencePaymentMethod;
			}
		} 
		public global::Allors.Meta.RoleType Receipt 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InternalOrganisationAccountingPreferenceReceipt;
			}
		} 
		public global::Allors.Meta.RoleType InternalOrganisation 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InternalOrganisationAccountingPreferenceInternalOrganisation;
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
		public global::Allors.Meta.RoleType SearchData 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SearchableSearchData;
			}
		} 

	}
}