// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class CustomerRelationship
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (CustomerRelationshipBuilder)objectBuilder;
			

			if(builder.BlockedForDunning.HasValue)
			{
				this.BlockedForDunning = builder.BlockedForDunning.Value;
			}			
					

			if(builder.AmountOverDue.HasValue)
			{
				this.AmountOverDue = builder.AmountOverDue.Value;
			}			
					

			if(builder.AmountDue.HasValue)
			{
				this.AmountDue = builder.AmountDue.Value;
			}			
					

			if(builder.YTDRevenue.HasValue)
			{
				this.YTDRevenue = builder.YTDRevenue.Value;
			}			
					

			if(builder.LastReminderDate.HasValue)
			{
				this.LastReminderDate = builder.LastReminderDate.Value;
			}			
					

			if(builder.CreditLimit.HasValue)
			{
				this.CreditLimit = builder.CreditLimit.Value;
			}			
					

			if(builder.SubAccountNumber.HasValue)
			{
				this.SubAccountNumber = builder.SubAccountNumber.Value;
			}			
					

			if(builder.LastYearsRevenue.HasValue)
			{
				this.LastYearsRevenue = builder.LastYearsRevenue.Value;
			}			
					

			if(builder.SimpleMovingAverage.HasValue)
			{
				this.SimpleMovingAverage = builder.SimpleMovingAverage.Value;
			}			
					

			if(builder.FromDate.HasValue)
			{
				this.FromDate = builder.FromDate.Value;
			}			
					

			if(builder.ThroughDate.HasValue)
			{
				this.ThroughDate = builder.ThroughDate.Value;
			}			
		

			this.Comment = builder.Comment;
		

			this.DisplayName = builder.DisplayName;
		

			this.InternalOrganisation = builder.InternalOrganisation;



			this.Customer = builder.Customer;



			this.PartyRelationshipStatus = builder.PartyRelationshipStatus;


			if(builder.Agreements!=null)
			{
				this.Agreements = builder.Agreements.ToArray();
			}


			this.PartyRelationshipPriority = builder.PartyRelationshipPriority;


			if(builder.CommunicationEvents!=null)
			{
				this.CommunicationEvents = builder.CommunicationEvents.ToArray();
			}

			if(builder.DeniedPermissions!=null)
			{
				this.DeniedPermissions = builder.DeniedPermissions.ToArray();
			}

			if(builder.SecurityTokens!=null)
			{
				this.SecurityTokens = builder.SecurityTokens.ToArray();
			}

		}
	}

	public partial class CustomerRelationshipBuilder : Allors.ObjectBuilder<CustomerRelationship> , PartyRelationshipBuilder, global::System.IDisposable
	{		
		public CustomerRelationshipBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.Boolean? BlockedForDunning {get; set;}

				/// <exclude/>
				public CustomerRelationshipBuilder WithBlockedForDunning(global::System.Boolean? value)
		        {
				    if(this.BlockedForDunning!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.BlockedForDunning = value;
		            return this;
		        }	

				public InternalOrganisation InternalOrganisation {get; set;}

				/// <exclude/>
				public CustomerRelationshipBuilder WithInternalOrganisation(InternalOrganisation value)
		        {
		            if(this.InternalOrganisation!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.InternalOrganisation = value;
		            return this;
		        }		

				
				public global::System.Decimal? AmountOverDue {get; set;}

				/// <exclude/>
				public CustomerRelationshipBuilder WithAmountOverDue(global::System.Decimal? value)
		        {
				    if(this.AmountOverDue!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.AmountOverDue = value;
		            return this;
		        }	

				public Party Customer {get; set;}

				/// <exclude/>
				public CustomerRelationshipBuilder WithCustomer(Party value)
		        {
		            if(this.Customer!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Customer = value;
		            return this;
		        }		

				
				public global::System.Decimal? AmountDue {get; set;}

				/// <exclude/>
				public CustomerRelationshipBuilder WithAmountDue(global::System.Decimal? value)
		        {
				    if(this.AmountDue!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.AmountDue = value;
		            return this;
		        }	

				public global::System.Decimal? YTDRevenue {get; set;}

				/// <exclude/>
				public CustomerRelationshipBuilder WithYTDRevenue(global::System.Decimal? value)
		        {
				    if(this.YTDRevenue!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.YTDRevenue = value;
		            return this;
		        }	

				public global::System.DateTime? LastReminderDate {get; set;}

				/// <exclude/>
				public CustomerRelationshipBuilder WithLastReminderDate(global::System.DateTime? value)
		        {
				    if(this.LastReminderDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.LastReminderDate = value;
		            return this;
		        }	

				public global::System.Decimal? CreditLimit {get; set;}

				/// <exclude/>
				public CustomerRelationshipBuilder WithCreditLimit(global::System.Decimal? value)
		        {
				    if(this.CreditLimit!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.CreditLimit = value;
		            return this;
		        }	

				public global::System.Int32? SubAccountNumber {get; set;}

				/// <exclude/>
				public CustomerRelationshipBuilder WithSubAccountNumber(global::System.Int32? value)
		        {
				    if(this.SubAccountNumber!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.SubAccountNumber = value;
		            return this;
		        }	

				public global::System.Decimal? LastYearsRevenue {get; set;}

				/// <exclude/>
				public CustomerRelationshipBuilder WithLastYearsRevenue(global::System.Decimal? value)
		        {
				    if(this.LastYearsRevenue!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.LastYearsRevenue = value;
		            return this;
		        }	

				public PartyRelationshipStatus PartyRelationshipStatus {get; set;}

				/// <exclude/>
				public CustomerRelationshipBuilder WithPartyRelationshipStatus(PartyRelationshipStatus value)
		        {
		            if(this.PartyRelationshipStatus!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.PartyRelationshipStatus = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<Agreement> Agreements {get; set;}	

				/// <exclude/>
				public CustomerRelationshipBuilder WithAgreement(Agreement value)
		        {
					if(this.Agreements == null)
					{
						this.Agreements = new global::System.Collections.Generic.List<Agreement>(); 
					}
		            this.Agreements.Add(value);
		            return this;
		        }		

				
				public PartyRelationshipPriority PartyRelationshipPriority {get; set;}

				/// <exclude/>
				public CustomerRelationshipBuilder WithPartyRelationshipPriority(PartyRelationshipPriority value)
		        {
		            if(this.PartyRelationshipPriority!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.PartyRelationshipPriority = value;
		            return this;
		        }		

				
				public global::System.Decimal? SimpleMovingAverage {get; set;}

				/// <exclude/>
				public CustomerRelationshipBuilder WithSimpleMovingAverage(global::System.Decimal? value)
		        {
				    if(this.SimpleMovingAverage!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.SimpleMovingAverage = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<CommunicationEvent> CommunicationEvents {get; set;}	

				/// <exclude/>
				public CustomerRelationshipBuilder WithCommunicationEvent(CommunicationEvent value)
		        {
					if(this.CommunicationEvents == null)
					{
						this.CommunicationEvents = new global::System.Collections.Generic.List<CommunicationEvent>(); 
					}
		            this.CommunicationEvents.Add(value);
		            return this;
		        }		

				
				public global::System.DateTime? FromDate {get; set;}

				/// <exclude/>
				public CustomerRelationshipBuilder WithFromDate(global::System.DateTime? value)
		        {
				    if(this.FromDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.FromDate = value;
		            return this;
		        }	

				public global::System.DateTime? ThroughDate {get; set;}

				/// <exclude/>
				public CustomerRelationshipBuilder WithThroughDate(global::System.DateTime? value)
		        {
				    if(this.ThroughDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ThroughDate = value;
		            return this;
		        }	

				public global::System.String Comment {get; set;}

				/// <exclude/>
				public CustomerRelationshipBuilder WithComment(global::System.String value)
		        {
				    if(this.Comment!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Comment = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public CustomerRelationshipBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public CustomerRelationshipBuilder WithDeniedPermission(Permission value)
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
				public CustomerRelationshipBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class CustomerRelationships : global::Allors.ObjectsBase<CustomerRelationship>
	{
		public static readonly CustomerRelationshipMeta Meta = CustomerRelationshipMeta.Instance;

		public CustomerRelationships(Allors.ISession session) : base(session)
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