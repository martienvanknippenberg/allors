// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class PartyRevenueHistory
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (PartyRevenueHistoryBuilder)objectBuilder;
			

			if(builder.Revenue.HasValue)
			{
				this.Revenue = builder.Revenue.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
		

			this.Currency = builder.Currency;



			this.Party = builder.Party;



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

	public partial class PartyRevenueHistoryBuilder : Allors.ObjectBuilder<PartyRevenueHistory> , UserInterfaceableBuilder, global::System.IDisposable
	{		
		public PartyRevenueHistoryBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public Currency Currency {get; set;}

				/// <exclude/>
				public PartyRevenueHistoryBuilder WithCurrency(Currency value)
		        {
		            if(this.Currency!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Currency = value;
		            return this;
		        }		

				
				public global::System.Decimal? Revenue {get; set;}

				/// <exclude/>
				public PartyRevenueHistoryBuilder WithRevenue(global::System.Decimal? value)
		        {
				    if(this.Revenue!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Revenue = value;
		            return this;
		        }	

				public Party Party {get; set;}

				/// <exclude/>
				public PartyRevenueHistoryBuilder WithParty(Party value)
		        {
		            if(this.Party!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Party = value;
		            return this;
		        }		

				
				public InternalOrganisation InternalOrganisation {get; set;}

				/// <exclude/>
				public PartyRevenueHistoryBuilder WithInternalOrganisation(InternalOrganisation value)
		        {
		            if(this.InternalOrganisation!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.InternalOrganisation = value;
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public PartyRevenueHistoryBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public PartyRevenueHistoryBuilder WithDeniedPermission(Permission value)
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
				public PartyRevenueHistoryBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class PartyRevenueHistories : global::Allors.ObjectsBase<PartyRevenueHistory>
	{
		public static readonly PartyRevenueHistoryMeta Meta = PartyRevenueHistoryMeta.Instance;

		public PartyRevenueHistories(Allors.ISession session) : base(session)
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