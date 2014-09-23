// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class ProductPurchasePrice
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (ProductPurchasePriceBuilder)objectBuilder;
			

			if(builder.Price.HasValue)
			{
				this.Price = builder.Price.Value;
			}			
					

			if(builder.FromDate.HasValue)
			{
				this.FromDate = builder.FromDate.Value;
			}			
					

			if(builder.ThroughDate.HasValue)
			{
				this.ThroughDate = builder.ThroughDate.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
		

			this.UnitOfMeasure = builder.UnitOfMeasure;



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

	public partial class ProductPurchasePriceBuilder : Allors.ObjectBuilder<ProductPurchasePrice> , AccessControlledObjectBuilder, PeriodBuilder, UserInterfaceableBuilder, global::System.IDisposable
	{		
		public ProductPurchasePriceBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.Decimal? Price {get; set;}

				/// <exclude/>
				public ProductPurchasePriceBuilder WithPrice(global::System.Decimal? value)
		        {
				    if(this.Price!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Price = value;
		            return this;
		        }	

				public UnitOfMeasure UnitOfMeasure {get; set;}

				/// <exclude/>
				public ProductPurchasePriceBuilder WithUnitOfMeasure(UnitOfMeasure value)
		        {
		            if(this.UnitOfMeasure!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.UnitOfMeasure = value;
		            return this;
		        }		

				
				public Currency Currency {get; set;}

				/// <exclude/>
				public ProductPurchasePriceBuilder WithCurrency(Currency value)
		        {
		            if(this.Currency!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Currency = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public ProductPurchasePriceBuilder WithDeniedPermission(Permission value)
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
				public ProductPurchasePriceBuilder WithSecurityToken(SecurityToken value)
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
				public ProductPurchasePriceBuilder WithFromDate(global::System.DateTime? value)
		        {
				    if(this.FromDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.FromDate = value;
		            return this;
		        }	

				public global::System.DateTime? ThroughDate {get; set;}

				/// <exclude/>
				public ProductPurchasePriceBuilder WithThroughDate(global::System.DateTime? value)
		        {
				    if(this.ThroughDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ThroughDate = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public ProductPurchasePriceBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	


	}

	public partial class ProductPurchasePrices : global::Allors.ObjectsBase<ProductPurchasePrice>
	{
		public static readonly ProductPurchasePriceMeta Meta = ProductPurchasePriceMeta.Instance;

		public ProductPurchasePrices(Allors.ISession session) : base(session)
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