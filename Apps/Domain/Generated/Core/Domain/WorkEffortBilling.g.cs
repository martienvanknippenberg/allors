// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class WorkEffortBilling : Allors.ObjectBase 
	{
		public static readonly WorkEffortBillingMeta Meta = WorkEffortBillingMeta.Instance;

		public WorkEffortBilling(Allors.IStrategy allors) : base(allors) {}

		public static WorkEffortBilling Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (WorkEffortBilling) allorsSession.Instantiate(allorsObjectId);		
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



		virtual public global::System.Decimal? Percentage 
		{
			get
			{
				return (global::System.Decimal?) Strategy.GetUnitRole(Meta.Percentage);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Percentage, value);
			}
		}

		virtual public bool ExistPercentage{
			get
			{
				return Strategy.ExistUnitRole(Meta.Percentage);
			}
		}

		virtual public void RemovePercentage()
		{
			Strategy.RemoveUnitRole(Meta.Percentage);
		}


		virtual public InvoiceItem InvoiceItem
		{ 
			get
			{
				return (InvoiceItem) Strategy.GetCompositeRole(Meta.InvoiceItem);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.InvoiceItem ,value);
			}
		}

		virtual public bool ExistInvoiceItem
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.InvoiceItem);
			}
		}

		virtual public void RemoveInvoiceItem()
		{
			Strategy.RemoveCompositeRole(Meta.InvoiceItem);
		}

	}

	public class WorkEffortBillingMeta
	{
		public static readonly WorkEffortBillingMeta Instance = new WorkEffortBillingMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.WorkEffortBilling;

		public global::Allors.Meta.RoleType WorkEffort 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortBillingWorkEffort;
			}
		} 
		public global::Allors.Meta.RoleType Percentage 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortBillingPercentage;
			}
		} 
		public global::Allors.Meta.RoleType InvoiceItem 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.WorkEffortBillingInvoiceItem;
			}
		} 

	}
}