// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface ExternalAccountingTransaction :  AccountingTransaction, Allors.IObject
	{


		Party FromParty
		{ 
			get;
			set;
		}

		bool ExistFromParty
		{
			get;
		}

		void RemoveFromParty();


		Party ToParty
		{ 
			get;
			set;
		}

		bool ExistToParty
		{
			get;
		}

		void RemoveToParty();

	}

	public class ExternalAccountingTransactionMeta
	{
		public static readonly ExternalAccountingTransactionMeta Instance = new ExternalAccountingTransactionMeta();

		public global::Allors.Meta.Interface ObjectType = global::Allors.Meta.Interfaces.ExternalAccountingTransaction;

		public global::Allors.Meta.RoleType FromParty 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ExternalAccountingTransactionFromParty;
			}
		} 
		public global::Allors.Meta.RoleType ToParty 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ExternalAccountingTransactionToParty;
			}
		} 
		public global::Allors.Meta.RoleType AccountingTransactionDetail 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AccountingTransactionAccountingTransactionDetail;
			}
		} 
		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AccountingTransactionDescription;
			}
		} 
		public global::Allors.Meta.RoleType TransactionDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AccountingTransactionTransactionDate;
			}
		} 
		public global::Allors.Meta.RoleType DerivedTotalAmount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AccountingTransactionDerivedTotalAmount;
			}
		} 
		public global::Allors.Meta.RoleType AccountingTransactionNumber 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AccountingTransactionAccountingTransactionNumber;
			}
		} 
		public global::Allors.Meta.RoleType EntryDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AccountingTransactionEntryDate;
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

	}
}