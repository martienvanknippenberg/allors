// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class BankAccount : Allors.ObjectBase , FinancialAccount
	{
		public static readonly BankAccountMeta Meta = BankAccountMeta.Instance;

		public BankAccount(Allors.IStrategy allors) : base(allors) {}

		public static BankAccount Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (BankAccount) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public Bank Bank
		{ 
			get
			{
				return (Bank) Strategy.GetCompositeRole(Meta.Bank);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Bank ,value);
			}
		}

		virtual public bool ExistBank
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Bank);
			}
		}

		virtual public void RemoveBank()
		{
			Strategy.RemoveCompositeRole(Meta.Bank);
		}



		virtual public global::System.String NameOnAccount 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.NameOnAccount);
			}
			set
			{
				Strategy.SetUnitRole(Meta.NameOnAccount, value);
			}
		}

		virtual public bool ExistNameOnAccount{
			get
			{
				return Strategy.ExistUnitRole(Meta.NameOnAccount);
			}
		}

		virtual public void RemoveNameOnAccount()
		{
			Strategy.RemoveUnitRole(Meta.NameOnAccount);
		}


		virtual public global::Allors.Extent<ContactMechanism> ContactMechanisms
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.ContactMechanism);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.ContactMechanism, value);
			}
		}

		virtual public void AddContactMechanism (ContactMechanism value)
		{
			Strategy.AddCompositeRole(Meta.ContactMechanism, value);
		}

		virtual public void RemoveContactMechanism (ContactMechanism value)
		{
			Strategy.RemoveCompositeRole(Meta.ContactMechanism,value);
		}

		virtual public bool ExistContactMechanisms
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.ContactMechanism);
			}
		}

		virtual public void RemoveContactMechanisms()
		{
			Strategy.RemoveCompositeRoles(Meta.ContactMechanism);
		}


		virtual public Currency Currency
		{ 
			get
			{
				return (Currency) Strategy.GetCompositeRole(Meta.Currency);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Currency ,value);
			}
		}

		virtual public bool ExistCurrency
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Currency);
			}
		}

		virtual public void RemoveCurrency()
		{
			Strategy.RemoveCompositeRole(Meta.Currency);
		}



		virtual public global::System.String Iban 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Iban);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Iban, value);
			}
		}

		virtual public bool ExistIban{
			get
			{
				return Strategy.ExistUnitRole(Meta.Iban);
			}
		}

		virtual public void RemoveIban()
		{
			Strategy.RemoveUnitRole(Meta.Iban);
		}



		virtual public global::System.String Branch 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Branch);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Branch, value);
			}
		}

		virtual public bool ExistBranch{
			get
			{
				return Strategy.ExistUnitRole(Meta.Branch);
			}
		}

		virtual public void RemoveBranch()
		{
			Strategy.RemoveUnitRole(Meta.Branch);
		}


		virtual public global::Allors.Extent<Person> ContactPersons
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.ContactPerson);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.ContactPerson, value);
			}
		}

		virtual public void AddContactPerson (Person value)
		{
			Strategy.AddCompositeRole(Meta.ContactPerson, value);
		}

		virtual public void RemoveContactPerson (Person value)
		{
			Strategy.RemoveCompositeRole(Meta.ContactPerson,value);
		}

		virtual public bool ExistContactPersons
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.ContactPerson);
			}
		}

		virtual public void RemoveContactPersons()
		{
			Strategy.RemoveCompositeRoles(Meta.ContactPerson);
		}


		virtual public global::Allors.Extent<FinancialAccountTransaction> FinancialAccountTransactions
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.FinancialAccountTransaction);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.FinancialAccountTransaction, value);
			}
		}

		virtual public void AddFinancialAccountTransaction (FinancialAccountTransaction value)
		{
			Strategy.AddCompositeRole(Meta.FinancialAccountTransaction, value);
		}

		virtual public void RemoveFinancialAccountTransaction (FinancialAccountTransaction value)
		{
			Strategy.RemoveCompositeRole(Meta.FinancialAccountTransaction,value);
		}

		virtual public bool ExistFinancialAccountTransactions
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.FinancialAccountTransaction);
			}
		}

		virtual public void RemoveFinancialAccountTransactions()
		{
			Strategy.RemoveCompositeRoles(Meta.FinancialAccountTransaction);
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



		virtual public Party PartyWhereBankAccount
		{ 
			get
			{
				return (Party) Strategy.GetCompositeAssociation(Meta.PartyWhereBankAccount);
			}
		} 

		virtual public bool ExistPartyWhereBankAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.PartyWhereBankAccount);
			}
		}


		virtual public global::Allors.Extent<AmountDue> AmountsDueWhereBankAccount
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.AmountsDueWhereBankAccount);
			}
		}

		virtual public bool ExistAmountsDueWhereBankAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.AmountsDueWhereBankAccount);
			}
		}


		virtual public global::Allors.Extent<OwnBankAccount> OwnBankAccountsWhereBankAccount
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.OwnBankAccountsWhereBankAccount);
			}
		}

		virtual public bool ExistOwnBankAccountsWhereBankAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.OwnBankAccountsWhereBankAccount);
			}
		}

	}

	public class BankAccountMeta
	{
		public static readonly BankAccountMeta Instance = new BankAccountMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.BankAccount;

		public global::Allors.Meta.RoleType Bank 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BankAccountBank;
			}
		} 
		public global::Allors.Meta.RoleType NameOnAccount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BankAccountNameOnAccount;
			}
		} 
		public global::Allors.Meta.RoleType ContactMechanism 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BankAccountContactMechanism;
			}
		} 
		public global::Allors.Meta.RoleType Currency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BankAccountCurrency;
			}
		} 
		public global::Allors.Meta.RoleType Iban 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BankAccountIban;
			}
		} 
		public global::Allors.Meta.RoleType Branch 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BankAccountBranch;
			}
		} 
		public global::Allors.Meta.RoleType ContactPerson 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BankAccountContactPerson;
			}
		} 
		public global::Allors.Meta.RoleType FinancialAccountTransaction 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.FinancialAccountFinancialAccountTransaction;
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

		public global::Allors.Meta.AssociationType PartyWhereBankAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyBankAccount;
			}
		} 
		public global::Allors.Meta.AssociationType AmountsDueWhereBankAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.AmountDueBankAccount;
			}
		} 
		public global::Allors.Meta.AssociationType OwnBankAccountsWhereBankAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.OwnBankAccountBankAccount;
			}
		} 

	}
}