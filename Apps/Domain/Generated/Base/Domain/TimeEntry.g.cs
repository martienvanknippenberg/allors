// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class TimeEntry
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (TimeEntryBuilder)objectBuilder;
			

			if(builder.Cost.HasValue)
			{
				this.Cost = builder.Cost.Value;
			}			
					

			if(builder.GrossMargin.HasValue)
			{
				this.GrossMargin = builder.GrossMargin.Value;
			}			
					

			if(builder.BillingRate.HasValue)
			{
				this.BillingRate = builder.BillingRate.Value;
			}			
					

			if(builder.AmountOfTime.HasValue)
			{
				this.AmountOfTime = builder.AmountOfTime.Value;
			}			
					

			if(builder.ThroughDateTime.HasValue)
			{
				this.ThroughDateTime = builder.ThroughDateTime.Value;
			}			
					

			if(builder.IsBillable.HasValue)
			{
				this.IsBillable = builder.IsBillable.Value;
			}			
					

			if(builder.FromDateTime.HasValue)
			{
				this.FromDateTime = builder.FromDateTime.Value;
			}			
		

			this.Description = builder.Description;
		

			this.Comment = builder.Comment;
		

			this.DisplayName = builder.DisplayName;
		

			this.QuoteTerm = builder.QuoteTerm;



			this.UnitOfMeasure = builder.UnitOfMeasure;



			this.EngagementItem = builder.EngagementItem;



			this.WorkEffort = builder.WorkEffort;


			if(builder.DeniedPermissions!=null)
			{
				this.DeniedPermissions = builder.DeniedPermissions.ToArray();
			}

			if(builder.SecurityTokens!=null)
			{
				this.SecurityTokens = builder.SecurityTokens.ToArray();
			}


			this.SearchData = builder.SearchData;


		}
	}

	public partial class TimeEntryBuilder : Allors.ObjectBuilder<TimeEntry> , ServiceEntryBuilder, global::System.IDisposable
	{		
		public TimeEntryBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.Decimal? Cost {get; set;}

				/// <exclude/>
				public TimeEntryBuilder WithCost(global::System.Decimal? value)
		        {
				    if(this.Cost!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Cost = value;
		            return this;
		        }	

				public global::System.Decimal? GrossMargin {get; set;}

				/// <exclude/>
				public TimeEntryBuilder WithGrossMargin(global::System.Decimal? value)
		        {
				    if(this.GrossMargin!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.GrossMargin = value;
		            return this;
		        }	

				public QuoteTerm QuoteTerm {get; set;}

				/// <exclude/>
				public TimeEntryBuilder WithQuoteTerm(QuoteTerm value)
		        {
		            if(this.QuoteTerm!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.QuoteTerm = value;
		            return this;
		        }		

				
				public global::System.Decimal? BillingRate {get; set;}

				/// <exclude/>
				public TimeEntryBuilder WithBillingRate(global::System.Decimal? value)
		        {
				    if(this.BillingRate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.BillingRate = value;
		            return this;
		        }	

				public UnitOfMeasure UnitOfMeasure {get; set;}

				/// <exclude/>
				public TimeEntryBuilder WithUnitOfMeasure(UnitOfMeasure value)
		        {
		            if(this.UnitOfMeasure!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.UnitOfMeasure = value;
		            return this;
		        }		

				
				public global::System.Decimal? AmountOfTime {get; set;}

				/// <exclude/>
				public TimeEntryBuilder WithAmountOfTime(global::System.Decimal? value)
		        {
				    if(this.AmountOfTime!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.AmountOfTime = value;
		            return this;
		        }	

				public global::System.DateTime? ThroughDateTime {get; set;}

				/// <exclude/>
				public TimeEntryBuilder WithThroughDateTime(global::System.DateTime? value)
		        {
				    if(this.ThroughDateTime!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ThroughDateTime = value;
		            return this;
		        }	

				public EngagementItem EngagementItem {get; set;}

				/// <exclude/>
				public TimeEntryBuilder WithEngagementItem(EngagementItem value)
		        {
		            if(this.EngagementItem!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.EngagementItem = value;
		            return this;
		        }		

				
				public global::System.Boolean? IsBillable {get; set;}

				/// <exclude/>
				public TimeEntryBuilder WithIsBillable(global::System.Boolean? value)
		        {
				    if(this.IsBillable!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.IsBillable = value;
		            return this;
		        }	

				public global::System.DateTime? FromDateTime {get; set;}

				/// <exclude/>
				public TimeEntryBuilder WithFromDateTime(global::System.DateTime? value)
		        {
				    if(this.FromDateTime!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.FromDateTime = value;
		            return this;
		        }	

				public global::System.String Description {get; set;}

				/// <exclude/>
				public TimeEntryBuilder WithDescription(global::System.String value)
		        {
				    if(this.Description!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Description = value;
		            return this;
		        }	

				public WorkEffort WorkEffort {get; set;}

				/// <exclude/>
				public TimeEntryBuilder WithWorkEffort(WorkEffort value)
		        {
		            if(this.WorkEffort!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.WorkEffort = value;
		            return this;
		        }		

				
				public global::System.String Comment {get; set;}

				/// <exclude/>
				public TimeEntryBuilder WithComment(global::System.String value)
		        {
				    if(this.Comment!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Comment = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public TimeEntryBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public TimeEntryBuilder WithDeniedPermission(Permission value)
		        {
					if(this.DeniedPermissions == null)
					{
						this.DeniedPermissions = new global::System.Collections.Generic.List<Permission>(); 
					}
		            this.DeniedPermissions.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<SecurityToken> SecurityTokens {get; set;}	

				/// <exclude/>
				public TimeEntryBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				
				public SearchData SearchData {get; set;}

				/// <exclude/>
				public TimeEntryBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				

	}

	public partial class TimeEntries : global::Allors.ObjectsBase<TimeEntry>
	{
		public static readonly TimeEntryMeta Meta = TimeEntryMeta.Instance;

		public TimeEntries(Allors.ISession session) : base(session)
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