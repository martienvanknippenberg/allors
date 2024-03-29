// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class RequestItem
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (RequestItemBuilder)objectBuilder;

			this.Description = builder.Description;
					

			if(builder.Quantity.HasValue)
			{
				this.Quantity = builder.Quantity.Value;
			}			
					

			if(builder.MaximumAllowedPrice.HasValue)
			{
				this.MaximumAllowedPrice = builder.MaximumAllowedPrice.Value;
			}			
					

			if(builder.RequiredByDate.HasValue)
			{
				this.RequiredByDate = builder.RequiredByDate.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
		

			this.Comment = builder.Comment;
		
			if(builder.Requirements!=null)
			{
				this.Requirements = builder.Requirements.ToArray();
			}


			this.Deliverable = builder.Deliverable;



			this.ProductFeature = builder.ProductFeature;



			this.NeededSkill = builder.NeededSkill;



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

	public partial class RequestItemBuilder : Allors.ObjectBuilder<RequestItem> , UserInterfaceableBuilder, CommentableBuilder, global::System.IDisposable
	{		
		public RequestItemBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.String Description {get; set;}

				/// <exclude/>
				public RequestItemBuilder WithDescription(global::System.String value)
		        {
				    if(this.Description!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Description = value;
		            return this;
		        }	

				public global::System.Int32? Quantity {get; set;}

				/// <exclude/>
				public RequestItemBuilder WithQuantity(global::System.Int32? value)
		        {
				    if(this.Quantity!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Quantity = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Requirement> Requirements {get; set;}	

				/// <exclude/>
				public RequestItemBuilder WithRequirement(Requirement value)
		        {
					if(this.Requirements == null)
					{
						this.Requirements = new global::System.Collections.Generic.List<Requirement>(); 
					}
		            this.Requirements.Add(value);
		            return this;
		        }		

				
				public Deliverable Deliverable {get; set;}

				/// <exclude/>
				public RequestItemBuilder WithDeliverable(Deliverable value)
		        {
		            if(this.Deliverable!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Deliverable = value;
		            return this;
		        }		

				
				public ProductFeature ProductFeature {get; set;}

				/// <exclude/>
				public RequestItemBuilder WithProductFeature(ProductFeature value)
		        {
		            if(this.ProductFeature!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.ProductFeature = value;
		            return this;
		        }		

				
				public NeededSkill NeededSkill {get; set;}

				/// <exclude/>
				public RequestItemBuilder WithNeededSkill(NeededSkill value)
		        {
		            if(this.NeededSkill!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.NeededSkill = value;
		            return this;
		        }		

				
				public Product Product {get; set;}

				/// <exclude/>
				public RequestItemBuilder WithProduct(Product value)
		        {
		            if(this.Product!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Product = value;
		            return this;
		        }		

				
				public global::System.Decimal? MaximumAllowedPrice {get; set;}

				/// <exclude/>
				public RequestItemBuilder WithMaximumAllowedPrice(global::System.Decimal? value)
		        {
				    if(this.MaximumAllowedPrice!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.MaximumAllowedPrice = value;
		            return this;
		        }	

				public global::System.DateTime? RequiredByDate {get; set;}

				/// <exclude/>
				public RequestItemBuilder WithRequiredByDate(global::System.DateTime? value)
		        {
				    if(this.RequiredByDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.RequiredByDate = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public RequestItemBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public RequestItemBuilder WithDeniedPermission(Permission value)
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
				public RequestItemBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				
				public global::System.String Comment {get; set;}

				/// <exclude/>
				public RequestItemBuilder WithComment(global::System.String value)
		        {
				    if(this.Comment!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Comment = value;
		            return this;
		        }	


	}

	public partial class RequestItems : global::Allors.ObjectsBase<RequestItem>
	{
		public static readonly RequestItemMeta Meta = RequestItemMeta.Instance;

		public RequestItems(Allors.ISession session) : base(session)
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