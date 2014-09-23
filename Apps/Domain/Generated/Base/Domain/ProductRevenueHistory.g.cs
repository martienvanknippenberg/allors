// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class ProductRevenueHistory
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (ProductRevenueHistoryBuilder)objectBuilder;
			

			if(builder.Revenue.HasValue)
			{
				this.Revenue = builder.Revenue.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
		

			this.InternalOrganisation = builder.InternalOrganisation;



			this.Currency = builder.Currency;



			this.Product = builder.Product;


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

	public partial class ProductRevenueHistoryBuilder : Allors.ObjectBuilder<ProductRevenueHistory> , UserInterfaceableBuilder, global::System.IDisposable
	{		
		public ProductRevenueHistoryBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public InternalOrganisation InternalOrganisation {get; set;}

				/// <exclude/>
				public ProductRevenueHistoryBuilder WithInternalOrganisation(InternalOrganisation value)
		        {
		            if(this.InternalOrganisation!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.InternalOrganisation = value;
		            return this;
		        }		

				
				public global::System.Decimal? Revenue {get; set;}

				/// <exclude/>
				public ProductRevenueHistoryBuilder WithRevenue(global::System.Decimal? value)
		        {
				    if(this.Revenue!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Revenue = value;
		            return this;
		        }	

				public Currency Currency {get; set;}

				/// <exclude/>
				public ProductRevenueHistoryBuilder WithCurrency(Currency value)
		        {
		            if(this.Currency!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Currency = value;
		            return this;
		        }		

				
				public Product Product {get; set;}

				/// <exclude/>
				public ProductRevenueHistoryBuilder WithProduct(Product value)
		        {
		            if(this.Product!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Product = value;
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public ProductRevenueHistoryBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public ProductRevenueHistoryBuilder WithDeniedPermission(Permission value)
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
				public ProductRevenueHistoryBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class ProductRevenueHistories : global::Allors.ObjectsBase<ProductRevenueHistory>
	{
		public static readonly ProductRevenueHistoryMeta Meta = ProductRevenueHistoryMeta.Instance;

		public ProductRevenueHistories(Allors.ISession session) : base(session)
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