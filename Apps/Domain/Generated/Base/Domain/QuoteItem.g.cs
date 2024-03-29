// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class QuoteItem
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (QuoteItemBuilder)objectBuilder;
			

			if(builder.EstimatedDeliveryDate.HasValue)
			{
				this.EstimatedDeliveryDate = builder.EstimatedDeliveryDate.Value;
			}			
					

			if(builder.UnitPrice.HasValue)
			{
				this.UnitPrice = builder.UnitPrice.Value;
			}			
					

			if(builder.Quantity.HasValue)
			{
				this.Quantity = builder.Quantity.Value;
			}			
		

			this.Comment = builder.Comment;
		

			this.DisplayName = builder.DisplayName;
		

			this.Authorizer = builder.Authorizer;



			this.Deliverable = builder.Deliverable;



			this.Product = builder.Product;



			this.UnitOfMeasure = builder.UnitOfMeasure;



			this.ProductFeature = builder.ProductFeature;



			this.Skill = builder.Skill;



			this.WorkEffort = builder.WorkEffort;


			if(builder.QuoteTerms!=null)
			{
				this.QuoteTerms = builder.QuoteTerms.ToArray();
			}


			this.RequestItem = builder.RequestItem;


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

	public partial class QuoteItemBuilder : Allors.ObjectBuilder<QuoteItem> , CommentableBuilder, UserInterfaceableBuilder, global::System.IDisposable
	{		
		public QuoteItemBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public Party Authorizer {get; set;}

				/// <exclude/>
				public QuoteItemBuilder WithAuthorizer(Party value)
		        {
		            if(this.Authorizer!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Authorizer = value;
		            return this;
		        }		

				
				public Deliverable Deliverable {get; set;}

				/// <exclude/>
				public QuoteItemBuilder WithDeliverable(Deliverable value)
		        {
		            if(this.Deliverable!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Deliverable = value;
		            return this;
		        }		

				
				public Product Product {get; set;}

				/// <exclude/>
				public QuoteItemBuilder WithProduct(Product value)
		        {
		            if(this.Product!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Product = value;
		            return this;
		        }		

				
				public global::System.DateTime? EstimatedDeliveryDate {get; set;}

				/// <exclude/>
				public QuoteItemBuilder WithEstimatedDeliveryDate(global::System.DateTime? value)
		        {
				    if(this.EstimatedDeliveryDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.EstimatedDeliveryDate = value;
		            return this;
		        }	

				public UnitOfMeasure UnitOfMeasure {get; set;}

				/// <exclude/>
				public QuoteItemBuilder WithUnitOfMeasure(UnitOfMeasure value)
		        {
		            if(this.UnitOfMeasure!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.UnitOfMeasure = value;
		            return this;
		        }		

				
				public ProductFeature ProductFeature {get; set;}

				/// <exclude/>
				public QuoteItemBuilder WithProductFeature(ProductFeature value)
		        {
		            if(this.ProductFeature!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.ProductFeature = value;
		            return this;
		        }		

				
				public global::System.Decimal? UnitPrice {get; set;}

				/// <exclude/>
				public QuoteItemBuilder WithUnitPrice(global::System.Decimal? value)
		        {
				    if(this.UnitPrice!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UnitPrice = value;
		            return this;
		        }	

				public Skill Skill {get; set;}

				/// <exclude/>
				public QuoteItemBuilder WithSkill(Skill value)
		        {
		            if(this.Skill!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Skill = value;
		            return this;
		        }		

				
				public WorkEffort WorkEffort {get; set;}

				/// <exclude/>
				public QuoteItemBuilder WithWorkEffort(WorkEffort value)
		        {
		            if(this.WorkEffort!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.WorkEffort = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<QuoteTerm> QuoteTerms {get; set;}	

				/// <exclude/>
				public QuoteItemBuilder WithQuoteTerm(QuoteTerm value)
		        {
					if(this.QuoteTerms == null)
					{
						this.QuoteTerms = new global::System.Collections.Generic.List<QuoteTerm>(); 
					}
		            this.QuoteTerms.Add(value);
		            return this;
		        }		

				
				public global::System.Int32? Quantity {get; set;}

				/// <exclude/>
				public QuoteItemBuilder WithQuantity(global::System.Int32? value)
		        {
				    if(this.Quantity!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Quantity = value;
		            return this;
		        }	

				public RequestItem RequestItem {get; set;}

				/// <exclude/>
				public QuoteItemBuilder WithRequestItem(RequestItem value)
		        {
		            if(this.RequestItem!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.RequestItem = value;
		            return this;
		        }		

				
				public global::System.String Comment {get; set;}

				/// <exclude/>
				public QuoteItemBuilder WithComment(global::System.String value)
		        {
				    if(this.Comment!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Comment = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public QuoteItemBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public QuoteItemBuilder WithDeniedPermission(Permission value)
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
				public QuoteItemBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class QuoteItems : global::Allors.ObjectsBase<QuoteItem>
	{
		public static readonly QuoteItemMeta Meta = QuoteItemMeta.Instance;

		public QuoteItems(Allors.ISession session) : base(session)
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