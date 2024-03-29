// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class FiscalYearInvoiceNumber
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (FiscalYearInvoiceNumberBuilder)objectBuilder;
			

			if(builder.NextSalesInvoiceNumber.HasValue)
			{
				this.NextSalesInvoiceNumber = builder.NextSalesInvoiceNumber.Value;
			}			
					

			if(builder.FiscalYear.HasValue)
			{
				this.FiscalYear = builder.FiscalYear.Value;
			}			
		
		}
	}

	public partial class FiscalYearInvoiceNumberBuilder : Allors.ObjectBuilder<FiscalYearInvoiceNumber> , global::System.IDisposable
	{		
		public FiscalYearInvoiceNumberBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.Int32? NextSalesInvoiceNumber {get; set;}

				/// <exclude/>
				public FiscalYearInvoiceNumberBuilder WithNextSalesInvoiceNumber(global::System.Int32? value)
		        {
				    if(this.NextSalesInvoiceNumber!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.NextSalesInvoiceNumber = value;
		            return this;
		        }	

				public global::System.Int32? FiscalYear {get; set;}

				/// <exclude/>
				public FiscalYearInvoiceNumberBuilder WithFiscalYear(global::System.Int32? value)
		        {
				    if(this.FiscalYear!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.FiscalYear = value;
		            return this;
		        }	


	}

	public partial class FiscalYearInvoiceNumbers : global::Allors.ObjectsBase<FiscalYearInvoiceNumber>
	{
		public static readonly FiscalYearInvoiceNumberMeta Meta = FiscalYearInvoiceNumberMeta.Instance;

		public FiscalYearInvoiceNumbers(Allors.ISession session) : base(session)
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