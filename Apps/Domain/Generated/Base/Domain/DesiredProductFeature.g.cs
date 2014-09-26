// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class DesiredProductFeature
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (DesiredProductFeatureBuilder)objectBuilder;
			

			if(builder.Required.HasValue)
			{
				this.Required = builder.Required.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
		

			this.ProductFeature = builder.ProductFeature;


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

	public partial class DesiredProductFeatureBuilder : Allors.ObjectBuilder<DesiredProductFeature> , UserInterfaceableBuilder, SearchableBuilder, global::System.IDisposable
	{		
		public DesiredProductFeatureBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.Boolean? Required {get; set;}

				/// <exclude/>
				public DesiredProductFeatureBuilder WithRequired(global::System.Boolean? value)
		        {
				    if(this.Required!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Required = value;
		            return this;
		        }	

				public ProductFeature ProductFeature {get; set;}

				/// <exclude/>
				public DesiredProductFeatureBuilder WithProductFeature(ProductFeature value)
		        {
		            if(this.ProductFeature!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.ProductFeature = value;
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public DesiredProductFeatureBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public DesiredProductFeatureBuilder WithDeniedPermission(Permission value)
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
				public DesiredProductFeatureBuilder WithSecurityToken(SecurityToken value)
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
				public DesiredProductFeatureBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				

	}

	public partial class DesiredProductFeatures : global::Allors.ObjectsBase<DesiredProductFeature>
	{
		public static readonly DesiredProductFeatureMeta Meta = DesiredProductFeatureMeta.Instance;

		public DesiredProductFeatures(Allors.ISession session) : base(session)
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