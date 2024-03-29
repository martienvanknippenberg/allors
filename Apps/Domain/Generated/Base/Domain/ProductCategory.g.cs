// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class ProductCategory
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (ProductCategoryBuilder)objectBuilder;

			this.Code = builder.Code;
		

			this.Description = builder.Description;
		

			this.Name = builder.Name;
		

			this.DisplayName = builder.DisplayName;
					

			if(builder.UniqueId.HasValue)
			{
				this.UniqueId = builder.UniqueId.Value;
			}			
		

			this.Package = builder.Package;



			this.NoImageAvailableImage = builder.NoImageAvailableImage;


			if(builder.Parents!=null)
			{
				this.Parents = builder.Parents.ToArray();
			}

			if(builder.Children!=null)
			{
				this.Children = builder.Children.ToArray();
			}


			this.CategoryImage = builder.CategoryImage;


			if(builder.Ancestors!=null)
			{
				this.Ancestors = builder.Ancestors.ToArray();
			}

			if(builder.DeniedPermissions!=null)
			{
				this.DeniedPermissions = builder.DeniedPermissions.ToArray();
			}

			if(builder.SecurityTokens!=null)
			{
				this.SecurityTokens = builder.SecurityTokens.ToArray();
			}


			this.SearchData = builder.SearchData;


		}
	}

	public partial class ProductCategoryBuilder : Allors.ObjectBuilder<ProductCategory> , UserInterfaceableBuilder, SearchableBuilder, SearchResultBuilder, UniquelyIdentifiableBuilder, global::System.IDisposable
	{		
		public ProductCategoryBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public Package Package {get; set;}

				/// <exclude/>
				public ProductCategoryBuilder WithPackage(Package value)
		        {
		            if(this.Package!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Package = value;
		            return this;
		        }		

				
				public global::System.String Code {get; set;}

				/// <exclude/>
				public ProductCategoryBuilder WithCode(global::System.String value)
		        {
				    if(this.Code!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Code = value;
		            return this;
		        }	

				public Media NoImageAvailableImage {get; set;}

				/// <exclude/>
				public ProductCategoryBuilder WithNoImageAvailableImage(Media value)
		        {
		            if(this.NoImageAvailableImage!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.NoImageAvailableImage = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<ProductCategory> Parents {get; set;}	

				/// <exclude/>
				public ProductCategoryBuilder WithParent(ProductCategory value)
		        {
					if(this.Parents == null)
					{
						this.Parents = new global::System.Collections.Generic.List<ProductCategory>(); 
					}
		            this.Parents.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<ProductCategory> Children {get; set;}	

				/// <exclude/>
				public ProductCategoryBuilder WithChild(ProductCategory value)
		        {
					if(this.Children == null)
					{
						this.Children = new global::System.Collections.Generic.List<ProductCategory>(); 
					}
		            this.Children.Add(value);
		            return this;
		        }		

				
				public global::System.String Description {get; set;}

				/// <exclude/>
				public ProductCategoryBuilder WithDescription(global::System.String value)
		        {
				    if(this.Description!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Description = value;
		            return this;
		        }	

				public global::System.String Name {get; set;}

				/// <exclude/>
				public ProductCategoryBuilder WithName(global::System.String value)
		        {
				    if(this.Name!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Name = value;
		            return this;
		        }	

				public Media CategoryImage {get; set;}

				/// <exclude/>
				public ProductCategoryBuilder WithCategoryImage(Media value)
		        {
		            if(this.CategoryImage!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.CategoryImage = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<ProductCategory> Ancestors {get; set;}	

				/// <exclude/>
				public ProductCategoryBuilder WithAncestor(ProductCategory value)
		        {
					if(this.Ancestors == null)
					{
						this.Ancestors = new global::System.Collections.Generic.List<ProductCategory>(); 
					}
		            this.Ancestors.Add(value);
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public ProductCategoryBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public ProductCategoryBuilder WithDeniedPermission(Permission value)
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
				public ProductCategoryBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				
				public SearchData SearchData {get; set;}

				/// <exclude/>
				public ProductCategoryBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				
				public global::System.Guid? UniqueId {get; set;}

				/// <exclude/>
				public ProductCategoryBuilder WithUniqueId(global::System.Guid? value)
		        {
				    if(this.UniqueId!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UniqueId = value;
		            return this;
		        }	


	}

	public partial class ProductCategories : global::Allors.ObjectsBase<ProductCategory>
	{
		public static readonly ProductCategoryMeta Meta = ProductCategoryMeta.Instance;

		public ProductCategories(Allors.ISession session) : base(session)
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