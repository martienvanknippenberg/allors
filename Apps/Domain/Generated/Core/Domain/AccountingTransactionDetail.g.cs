// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class AccountingTransactionDetail : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly AccountingTransactionDetailMeta Meta = AccountingTransactionDetailMeta.Instance;

		public AccountingTransactionDetail(Allors.IStrategy allors) : base(allors) {}

		public static AccountingTransactionDetail Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (AccountingTransactionDetail) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public AccountingTransactionDetail AssociatedWith
		{ 
			get
			{
				return (AccountingTransactionDetail) Strategy.GetCompositeRole(Meta.AssociatedWith);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.AssociatedWith ,value);
			}
		}

		virtual public bool ExistAssociatedWith
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.AssociatedWith);
			}
		}

		virtual public void RemoveAssociatedWith()
		{
			Strategy.RemoveCompositeRole(Meta.AssociatedWith);
		}


		virtual public OrganisationGlAccountBalance OrganisationGlAccountBalance
		{ 
			get
			{
				return (OrganisationGlAccountBalance) Strategy.GetCompositeRole(Meta.OrganisationGlAccountBalance);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.OrganisationGlAccountBalance ,value);
			}
		}

		virtual public bool ExistOrganisationGlAccountBalance
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.OrganisationGlAccountBalance);
			}
		}

		virtual public void RemoveOrganisationGlAccountBalance()
		{
			Strategy.RemoveCompositeRole(Meta.OrganisationGlAccountBalance);
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



		virtual public global::System.Boolean? Debit 
		{
			get
			{
				return (global::System.Boolean?) Strategy.GetUnitRole(Meta.Debit);
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



		virtual public AccountingTransaction AccountingTransactionWhereAccountingTransactionDetail
		{ 
			get
			{
				return (AccountingTransaction) Strategy.GetCompositeAssociation(Meta.AccountingTransactionWhereAccountingTransactionDetail);
			}
		} 

		virtual public bool ExistAccountingTransactionWhereAccountingTransactionDetail
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.AccountingTransactionWhereAccountingTransactionDetail);
			}
		}


		virtual public global::Allors.Extent<AccountingTransactionDetail> AccountingTransactionDetailsWhereAssociatedWith
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.AccountingTransactionDetailsWhereAssociatedWith);
			}
		}

		virtual public bool ExistAccountingTransactionDetailsWhereAssociatedWith
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.AccountingTransactionDetailsWhereAssociatedWith);
			}
		}

	}

	public class AccountingTransactionDetailMeta
	{
		public static readonly AccountingTransactionDetailMeta Instance = new AccountingTransactionDetailMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.AccountingTransactionDetail;

		public global::Allors.Meta.RoleType AssociatedWith 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AccountingTransactionDetailAssociatedWith;
			}
		} 
		public global::Allors.Meta.RoleType OrganisationGlAccountBalance 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AccountingTransactionDetailOrganisationGlAccountBalance;
			}
		} 
		public global::Allors.Meta.RoleType Amount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AccountingTransactionDetailAmount;
			}
		} 
		public global::Allors.Meta.RoleType Debit 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AccountingTransactionDetailDebit;
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

		public global::Allors.Meta.AssociationType AccountingTransactionWhereAccountingTransactionDetail 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.AccountingTransactionAccountingTransactionDetail;
			}
		} 
		public global::Allors.Meta.AssociationType AccountingTransactionDetailsWhereAssociatedWith 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.AccountingTransactionDetailAssociatedWith;
			}
		} 

	}
}