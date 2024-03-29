// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class InternalOrganisationRevenue
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (InternalOrganisationRevenueBuilder)objectBuilder;
			

			if(builder.Month.HasValue)
			{
				this.Month = builder.Month.Value;
			}			
					

			if(builder.Year.HasValue)
			{
				this.Year = builder.Year.Value;
			}			
					

			if(builder.Revenue.HasValue)
			{
				this.Revenue = builder.Revenue.Value;
			}			
		

			this.PartyName = builder.PartyName;
		

			this.DisplayName = builder.DisplayName;
		

			this.Currency = builder.Currency;



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

	public partial class InternalOrganisationRevenueBuilder : Allors.ObjectBuilder<InternalOrganisationRevenue> , UserInterfaceableBuilder, global::System.IDisposable
	{		
		public InternalOrganisationRevenueBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.Int32? Month {get; set;}

				/// <exclude/>
				public InternalOrganisationRevenueBuilder WithMonth(global::System.Int32? value)
		        {
				    if(this.Month!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Month = value;
		            return this;
		        }	

				public global::System.Int32? Year {get; set;}

				/// <exclude/>
				public InternalOrganisationRevenueBuilder WithYear(global::System.Int32? value)
		        {
				    if(this.Year!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Year = value;
		            return this;
		        }	

				public global::System.Decimal? Revenue {get; set;}

				/// <exclude/>
				public InternalOrganisationRevenueBuilder WithRevenue(global::System.Decimal? value)
		        {
				    if(this.Revenue!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Revenue = value;
		            return this;
		        }	

				public Currency Currency {get; set;}

				/// <exclude/>
				public InternalOrganisationRevenueBuilder WithCurrency(Currency value)
		        {
		            if(this.Currency!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Currency = value;
		            return this;
		        }		

				
				public global::System.String PartyName {get; set;}

				/// <exclude/>
				public InternalOrganisationRevenueBuilder WithPartyName(global::System.String value)
		        {
				    if(this.PartyName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.PartyName = value;
		            return this;
		        }	

				public InternalOrganisation InternalOrganisation {get; set;}

				/// <exclude/>
				public InternalOrganisationRevenueBuilder WithInternalOrganisation(InternalOrganisation value)
		        {
		            if(this.InternalOrganisation!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.InternalOrganisation = value;
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public InternalOrganisationRevenueBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public InternalOrganisationRevenueBuilder WithDeniedPermission(Permission value)
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
				public InternalOrganisationRevenueBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class InternalOrganisationRevenues : global::Allors.ObjectsBase<InternalOrganisationRevenue>
	{
		public static readonly InternalOrganisationRevenueMeta Meta = InternalOrganisationRevenueMeta.Instance;

		public InternalOrganisationRevenues(Allors.ISession session) : base(session)
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