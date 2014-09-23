// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class SalesRepPartyRevenue
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (SalesRepPartyRevenueBuilder)objectBuilder;
			

			if(builder.Revenue.HasValue)
			{
				this.Revenue = builder.Revenue.Value;
			}			
					

			if(builder.Year.HasValue)
			{
				this.Year = builder.Year.Value;
			}			
		

			this.SalesRepName = builder.SalesRepName;
					

			if(builder.Month.HasValue)
			{
				this.Month = builder.Month.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
		

			this.SalesRep = builder.SalesRep;



			this.InternalOrganisation = builder.InternalOrganisation;



			this.Party = builder.Party;



			this.Currency = builder.Currency;


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

	public partial class SalesRepPartyRevenueBuilder : Allors.ObjectBuilder<SalesRepPartyRevenue> , UserInterfaceableBuilder, global::System.IDisposable
	{		
		public SalesRepPartyRevenueBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.Decimal? Revenue {get; set;}

				/// <exclude/>
				public SalesRepPartyRevenueBuilder WithRevenue(global::System.Decimal? value)
		        {
				    if(this.Revenue!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Revenue = value;
		            return this;
		        }	

				public global::System.Int32? Year {get; set;}

				/// <exclude/>
				public SalesRepPartyRevenueBuilder WithYear(global::System.Int32? value)
		        {
				    if(this.Year!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Year = value;
		            return this;
		        }	

				public Person SalesRep {get; set;}

				/// <exclude/>
				public SalesRepPartyRevenueBuilder WithSalesRep(Person value)
		        {
		            if(this.SalesRep!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SalesRep = value;
		            return this;
		        }		

				
				public global::System.String SalesRepName {get; set;}

				/// <exclude/>
				public SalesRepPartyRevenueBuilder WithSalesRepName(global::System.String value)
		        {
				    if(this.SalesRepName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.SalesRepName = value;
		            return this;
		        }	

				public InternalOrganisation InternalOrganisation {get; set;}

				/// <exclude/>
				public SalesRepPartyRevenueBuilder WithInternalOrganisation(InternalOrganisation value)
		        {
		            if(this.InternalOrganisation!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.InternalOrganisation = value;
		            return this;
		        }		

				
				public Party Party {get; set;}

				/// <exclude/>
				public SalesRepPartyRevenueBuilder WithParty(Party value)
		        {
		            if(this.Party!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Party = value;
		            return this;
		        }		

				
				public Currency Currency {get; set;}

				/// <exclude/>
				public SalesRepPartyRevenueBuilder WithCurrency(Currency value)
		        {
		            if(this.Currency!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Currency = value;
		            return this;
		        }		

				
				public global::System.Int32? Month {get; set;}

				/// <exclude/>
				public SalesRepPartyRevenueBuilder WithMonth(global::System.Int32? value)
		        {
				    if(this.Month!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Month = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public SalesRepPartyRevenueBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public SalesRepPartyRevenueBuilder WithDeniedPermission(Permission value)
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
				public SalesRepPartyRevenueBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class SalesRepPartyRevenues : global::Allors.ObjectsBase<SalesRepPartyRevenue>
	{
		public static readonly SalesRepPartyRevenueMeta Meta = SalesRepPartyRevenueMeta.Instance;

		public SalesRepPartyRevenues(Allors.ISession session) : base(session)
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