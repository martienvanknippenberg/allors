// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class Brand
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (BrandBuilder)objectBuilder;

			this.Name = builder.Name;
		

			this.DisplayName = builder.DisplayName;
		
			if(builder.ProductCategories!=null)
			{
				this.ProductCategories = builder.ProductCategories.ToArray();
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

	public partial class BrandBuilder : Allors.ObjectBuilder<Brand> , UserInterfaceableBuilder, AccessControlledObjectBuilder, SearchableBuilder, global::System.IDisposable
	{		
		public BrandBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.String Name {get; set;}

				/// <exclude/>
				public BrandBuilder WithName(global::System.String value)
		        {
				    if(this.Name!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Name = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<ProductCategory> ProductCategories {get; set;}	

				/// <exclude/>
				public BrandBuilder WithProductCategory(ProductCategory value)
		        {
					if(this.ProductCategories == null)
					{
						this.ProductCategories = new global::System.Collections.Generic.List<ProductCategory>(); 
					}
		            this.ProductCategories.Add(value);
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public BrandBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public BrandBuilder WithDeniedPermission(Permission value)
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
				public BrandBuilder WithSecurityToken(SecurityToken value)
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
				public BrandBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				

	}

	public partial class Brands : global::Allors.ObjectsBase<Brand>
	{
		public static readonly BrandMeta Meta = BrandMeta.Instance;

		public Brands(Allors.ISession session) : base(session)
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