// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface FinancialAccountBuilder : UserInterfaceableBuilder ,SearchResultBuilder ,SearchableBuilder , global::System.IDisposable
	{	

		global::System.Collections.Generic.List<FinancialAccountTransaction> FinancialAccountTransactions {get;}		

		
	}

	public partial class FinancialAccounts : global::Allors.ObjectsBase<FinancialAccount>
	{
		public static readonly FinancialAccountMeta Meta = FinancialAccountMeta.Instance;

		public FinancialAccounts(Allors.ISession session) : base(session)
		{
		}

		public override Allors.Meta.Composite ObjectType
		{
			get
			{
				return Meta.ObjectType;
			}
		}
	}

}