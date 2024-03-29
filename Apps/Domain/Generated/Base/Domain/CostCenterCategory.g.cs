// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class CostCenterCategory
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (CostCenterCategoryBuilder)objectBuilder;

			this.Description = builder.Description;
		

			this.DisplayName = builder.DisplayName;
					

			if(builder.UniqueId.HasValue)
			{
				this.UniqueId = builder.UniqueId.Value;
			}			
		

			this.Parent = builder.Parent;


			if(builder.Ancestors!=null)
			{
				this.Ancestors = builder.Ancestors.ToArray();
			}

			if(builder.Children!=null)
			{
				this.Children = builder.Children.ToArray();
			}


			this.SearchData = builder.SearchData;


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

	public partial class CostCenterCategoryBuilder : Allors.ObjectBuilder<CostCenterCategory> , SearchableBuilder, UserInterfaceableBuilder, SearchResultBuilder, AccessControlledObjectBuilder, UniquelyIdentifiableBuilder, global::System.IDisposable
	{		
		public CostCenterCategoryBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public CostCenterCategory Parent {get; set;}

				/// <exclude/>
				public CostCenterCategoryBuilder WithParent(CostCenterCategory value)
		        {
		            if(this.Parent!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Parent = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<CostCenterCategory> Ancestors {get; set;}	

				/// <exclude/>
				public CostCenterCategoryBuilder WithAncestor(CostCenterCategory value)
		        {
					if(this.Ancestors == null)
					{
						this.Ancestors = new global::System.Collections.Generic.List<CostCenterCategory>(); 
					}
		            this.Ancestors.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<CostCenterCategory> Children {get; set;}	

				/// <exclude/>
				public CostCenterCategoryBuilder WithChild(CostCenterCategory value)
		        {
					if(this.Children == null)
					{
						this.Children = new global::System.Collections.Generic.List<CostCenterCategory>(); 
					}
		            this.Children.Add(value);
		            return this;
		        }		

				
				public global::System.String Description {get; set;}

				/// <exclude/>
				public CostCenterCategoryBuilder WithDescription(global::System.String value)
		        {
				    if(this.Description!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Description = value;
		            return this;
		        }	

				public SearchData SearchData {get; set;}

				/// <exclude/>
				public CostCenterCategoryBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public CostCenterCategoryBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public CostCenterCategoryBuilder WithDeniedPermission(Permission value)
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
				public CostCenterCategoryBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				
				public global::System.Guid? UniqueId {get; set;}

				/// <exclude/>
				public CostCenterCategoryBuilder WithUniqueId(global::System.Guid? value)
		        {
				    if(this.UniqueId!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UniqueId = value;
		            return this;
		        }	


	}

	public partial class CostCenterCategories : global::Allors.ObjectsBase<CostCenterCategory>
	{
		public static readonly CostCenterCategoryMeta Meta = CostCenterCategoryMeta.Instance;

		public CostCenterCategories(Allors.ISession session) : base(session)
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