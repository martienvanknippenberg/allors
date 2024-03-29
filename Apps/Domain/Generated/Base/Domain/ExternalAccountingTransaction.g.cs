// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface ExternalAccountingTransactionBuilder : AccountingTransactionBuilder , global::System.IDisposable
	{	
		Party FromParty {get;}

		
		Party ToParty {get;}

		
	}

	public partial class ExternalAccountingTransactions : global::Allors.ObjectsBase<ExternalAccountingTransaction>
	{
		public static readonly ExternalAccountingTransactionMeta Meta = ExternalAccountingTransactionMeta.Instance;

		public ExternalAccountingTransactions(Allors.ISession session) : base(session)
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