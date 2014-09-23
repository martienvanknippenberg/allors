// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class WorkEffortBilling
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (WorkEffortBillingBuilder)objectBuilder;
			

			if(builder.Percentage.HasValue)
			{
				this.Percentage = builder.Percentage.Value;
			}			
		

			this.WorkEffort = builder.WorkEffort;



			this.InvoiceItem = builder.InvoiceItem;


		}
	}

	public partial class WorkEffortBillingBuilder : Allors.ObjectBuilder<WorkEffortBilling> , global::System.IDisposable
	{		
		public WorkEffortBillingBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public WorkEffort WorkEffort {get; set;}

				/// <exclude/>
				public WorkEffortBillingBuilder WithWorkEffort(WorkEffort value)
		        {
		            if(this.WorkEffort!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.WorkEffort = value;
		            return this;
		        }		

				
				public global::System.Decimal? Percentage {get; set;}

				/// <exclude/>
				public WorkEffortBillingBuilder WithPercentage(global::System.Decimal? value)
		        {
				    if(this.Percentage!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Percentage = value;
		            return this;
		        }	

				public InvoiceItem InvoiceItem {get; set;}

				/// <exclude/>
				public WorkEffortBillingBuilder WithInvoiceItem(InvoiceItem value)
		        {
		            if(this.InvoiceItem!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.InvoiceItem = value;
		            return this;
		        }		

				

	}

	public partial class WorkEffortBillings : global::Allors.ObjectsBase<WorkEffortBilling>
	{
		public static readonly WorkEffortBillingMeta Meta = WorkEffortBillingMeta.Instance;

		public WorkEffortBillings(Allors.ISession session) : base(session)
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