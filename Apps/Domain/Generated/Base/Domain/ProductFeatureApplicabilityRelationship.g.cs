// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class ProductFeatureApplicabilityRelationship
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (ProductFeatureApplicabilityRelationshipBuilder)objectBuilder;

			this.DisplayName = builder.DisplayName;
		

			this.AvailableFor = builder.AvailableFor;



			this.UsedToDefine = builder.UsedToDefine;


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

	public partial class ProductFeatureApplicabilityRelationshipBuilder : Allors.ObjectBuilder<ProductFeatureApplicabilityRelationship> , UserInterfaceableBuilder, global::System.IDisposable
	{		
		public ProductFeatureApplicabilityRelationshipBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public Product AvailableFor {get; set;}

				/// <exclude/>
				public ProductFeatureApplicabilityRelationshipBuilder WithAvailableFor(Product value)
		        {
		            if(this.AvailableFor!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.AvailableFor = value;
		            return this;
		        }		

				
				public ProductFeature UsedToDefine {get; set;}

				/// <exclude/>
				public ProductFeatureApplicabilityRelationshipBuilder WithUsedToDefine(ProductFeature value)
		        {
		            if(this.UsedToDefine!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.UsedToDefine = value;
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public ProductFeatureApplicabilityRelationshipBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public ProductFeatureApplicabilityRelationshipBuilder WithDeniedPermission(Permission value)
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
				public ProductFeatureApplicabilityRelationshipBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class ProductFeatureApplicabilityRelationships : global::Allors.ObjectsBase<ProductFeatureApplicabilityRelationship>
	{
		public static readonly ProductFeatureApplicabilityRelationshipMeta Meta = ProductFeatureApplicabilityRelationshipMeta.Instance;

		public ProductFeatureApplicabilityRelationships(Allors.ISession session) : base(session)
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