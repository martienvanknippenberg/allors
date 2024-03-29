// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class SalesChannelRevenue
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (SalesChannelRevenueBuilder)objectBuilder;
			

			if(builder.Year.HasValue)
			{
				this.Year = builder.Year.Value;
			}			
					

			if(builder.Month.HasValue)
			{
				this.Month = builder.Month.Value;
			}			
		

			this.SalesChannelName = builder.SalesChannelName;
					

			if(builder.Revenue.HasValue)
			{
				this.Revenue = builder.Revenue.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
		

			this.Currency = builder.Currency;



			this.SalesChannel = builder.SalesChannel;



			this.InternalOrganisation = builder.InternalOrganisation;


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

	public partial class SalesChannelRevenueBuilder : Allors.ObjectBuilder<SalesChannelRevenue> , UserInterfaceableBuilder, global::System.IDisposable
	{		
		public SalesChannelRevenueBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.Int32? Year {get; set;}

				/// <exclude/>
				public SalesChannelRevenueBuilder WithYear(global::System.Int32? value)
		        {
				    if(this.Year!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Year = value;
		            return this;
		        }	

				public global::System.Int32? Month {get; set;}

				/// <exclude/>
				public SalesChannelRevenueBuilder WithMonth(global::System.Int32? value)
		        {
				    if(this.Month!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Month = value;
		            return this;
		        }	

				public Currency Currency {get; set;}

				/// <exclude/>
				public SalesChannelRevenueBuilder WithCurrency(Currency value)
		        {
		            if(this.Currency!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Currency = value;
		            return this;
		        }		

				
				public SalesChannel SalesChannel {get; set;}

				/// <exclude/>
				public SalesChannelRevenueBuilder WithSalesChannel(SalesChannel value)
		        {
		            if(this.SalesChannel!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SalesChannel = value;
		            return this;
		        }		

				
				public global::System.String SalesChannelName {get; set;}

				/// <exclude/>
				public SalesChannelRevenueBuilder WithSalesChannelName(global::System.String value)
		        {
				    if(this.SalesChannelName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.SalesChannelName = value;
		            return this;
		        }	

				public global::System.Decimal? Revenue {get; set;}

				/// <exclude/>
				public SalesChannelRevenueBuilder WithRevenue(global::System.Decimal? value)
		        {
				    if(this.Revenue!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Revenue = value;
		            return this;
		        }	

				public InternalOrganisation InternalOrganisation {get; set;}

				/// <exclude/>
				public SalesChannelRevenueBuilder WithInternalOrganisation(InternalOrganisation value)
		        {
		            if(this.InternalOrganisation!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.InternalOrganisation = value;
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public SalesChannelRevenueBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public SalesChannelRevenueBuilder WithDeniedPermission(Permission value)
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
				public SalesChannelRevenueBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class SalesChannelRevenues : global::Allors.ObjectsBase<SalesChannelRevenue>
	{
		public static readonly SalesChannelRevenueMeta Meta = SalesChannelRevenueMeta.Instance;

		public SalesChannelRevenues(Allors.ISession session) : base(session)
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