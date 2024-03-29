// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class PayHistory
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (PayHistoryBuilder)objectBuilder;
			

			if(builder.Amount.HasValue)
			{
				this.Amount = builder.Amount.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
					

			if(builder.FromDate.HasValue)
			{
				this.FromDate = builder.FromDate.Value;
			}			
					

			if(builder.ThroughDate.HasValue)
			{
				this.ThroughDate = builder.ThroughDate.Value;
			}			
		

			this.Employment = builder.Employment;



			this.TimeFrequency = builder.TimeFrequency;



			this.SalaryStep = builder.SalaryStep;


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

	public partial class PayHistoryBuilder : Allors.ObjectBuilder<PayHistory> , UserInterfaceableBuilder, PeriodBuilder, global::System.IDisposable
	{		
		public PayHistoryBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public Employment Employment {get; set;}

				/// <exclude/>
				public PayHistoryBuilder WithEmployment(Employment value)
		        {
		            if(this.Employment!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Employment = value;
		            return this;
		        }		

				
				public TimeFrequency TimeFrequency {get; set;}

				/// <exclude/>
				public PayHistoryBuilder WithTimeFrequency(TimeFrequency value)
		        {
		            if(this.TimeFrequency!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.TimeFrequency = value;
		            return this;
		        }		

				
				public SalaryStep SalaryStep {get; set;}

				/// <exclude/>
				public PayHistoryBuilder WithSalaryStep(SalaryStep value)
		        {
		            if(this.SalaryStep!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SalaryStep = value;
		            return this;
		        }		

				
				public global::System.Decimal? Amount {get; set;}

				/// <exclude/>
				public PayHistoryBuilder WithAmount(global::System.Decimal? value)
		        {
				    if(this.Amount!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Amount = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public PayHistoryBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public PayHistoryBuilder WithDeniedPermission(Permission value)
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
				public PayHistoryBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				
				public global::System.DateTime? FromDate {get; set;}

				/// <exclude/>
				public PayHistoryBuilder WithFromDate(global::System.DateTime? value)
		        {
				    if(this.FromDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.FromDate = value;
		            return this;
		        }	

				public global::System.DateTime? ThroughDate {get; set;}

				/// <exclude/>
				public PayHistoryBuilder WithThroughDate(global::System.DateTime? value)
		        {
				    if(this.ThroughDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ThroughDate = value;
		            return this;
		        }	


	}

	public partial class PayHistories : global::Allors.ObjectsBase<PayHistory>
	{
		public static readonly PayHistoryMeta Meta = PayHistoryMeta.Instance;

		public PayHistories(Allors.ISession session) : base(session)
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