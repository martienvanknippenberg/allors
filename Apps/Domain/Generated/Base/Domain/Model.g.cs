// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class Model
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (ModelBuilder)objectBuilder;

			this.Description = builder.Description;
					

			if(builder.UniqueId.HasValue)
			{
				this.UniqueId = builder.UniqueId.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
					

			if(builder.IsActive.HasValue)
			{
				this.IsActive = builder.IsActive.Value;
			}			
		

			this.Name = builder.Name;
		
			if(builder.EstimatedProductCosts!=null)
			{
				this.EstimatedProductCosts = builder.EstimatedProductCosts.ToArray();
			}

			if(builder.BasePrices!=null)
			{
				this.BasePrices = builder.BasePrices.ToArray();
			}

			if(builder.DependentFeatures!=null)
			{
				this.DependentFeatures = builder.DependentFeatures.ToArray();
			}

			if(builder.IncompatibleFeatures!=null)
			{
				this.IncompatibleFeatures = builder.IncompatibleFeatures.ToArray();
			}


			this.VatRate = builder.VatRate;



			this.SearchData = builder.SearchData;


			if(builder.DeniedPermissions!=null)
			{
				this.DeniedPermissions = builder.DeniedPermissions.ToArray();
			}

			if(builder.SecurityTokens!=null)
			{
				this.SecurityTokens = builder.SecurityTokens.ToArray();
			}

			if(builder.LocalisedNames!=null)
			{
				this.LocalisedNames = builder.LocalisedNames.ToArray();
			}

		}
	}

	public partial class ModelBuilder : Allors.ObjectBuilder<Model> , ProductFeatureBuilder, EnumerationBuilder, global::System.IDisposable
	{		
		public ModelBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.Collections.Generic.List<EstimatedProductCost> EstimatedProductCosts {get; set;}	

				/// <exclude/>
				public ModelBuilder WithEstimatedProductCost(EstimatedProductCost value)
		        {
					if(this.EstimatedProductCosts == null)
					{
						this.EstimatedProductCosts = new global::System.Collections.Generic.List<EstimatedProductCost>(); 
					}
		            this.EstimatedProductCosts.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<PriceComponent> BasePrices {get; set;}	

				/// <exclude/>
				public ModelBuilder WithBasePrice(PriceComponent value)
		        {
					if(this.BasePrices == null)
					{
						this.BasePrices = new global::System.Collections.Generic.List<PriceComponent>(); 
					}
		            this.BasePrices.Add(value);
		            return this;
		        }		

				
				public global::System.String Description {get; set;}

				/// <exclude/>
				public ModelBuilder WithDescription(global::System.String value)
		        {
				    if(this.Description!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Description = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<ProductFeature> DependentFeatures {get; set;}	

				/// <exclude/>
				public ModelBuilder WithDependentFeature(ProductFeature value)
		        {
					if(this.DependentFeatures == null)
					{
						this.DependentFeatures = new global::System.Collections.Generic.List<ProductFeature>(); 
					}
		            this.DependentFeatures.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<ProductFeature> IncompatibleFeatures {get; set;}	

				/// <exclude/>
				public ModelBuilder WithIncompatibleFeature(ProductFeature value)
		        {
					if(this.IncompatibleFeatures == null)
					{
						this.IncompatibleFeatures = new global::System.Collections.Generic.List<ProductFeature>(); 
					}
		            this.IncompatibleFeatures.Add(value);
		            return this;
		        }		

				
				public VatRate VatRate {get; set;}

				/// <exclude/>
				public ModelBuilder WithVatRate(VatRate value)
		        {
		            if(this.VatRate!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.VatRate = value;
		            return this;
		        }		

				
				public SearchData SearchData {get; set;}

				/// <exclude/>
				public ModelBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				
				public global::System.Guid? UniqueId {get; set;}

				/// <exclude/>
				public ModelBuilder WithUniqueId(global::System.Guid? value)
		        {
				    if(this.UniqueId!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UniqueId = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public ModelBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public ModelBuilder WithDeniedPermission(Permission value)
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
				public ModelBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<LocalisedText> LocalisedNames {get; set;}	

				/// <exclude/>
				public ModelBuilder WithLocalisedName(LocalisedText value)
		        {
					if(this.LocalisedNames == null)
					{
						this.LocalisedNames = new global::System.Collections.Generic.List<LocalisedText>(); 
					}
		            this.LocalisedNames.Add(value);
		            return this;
		        }		

				
				public global::System.Boolean? IsActive {get; set;}

				/// <exclude/>
				public ModelBuilder WithIsActive(global::System.Boolean? value)
		        {
				    if(this.IsActive!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.IsActive = value;
		            return this;
		        }	

				public global::System.String Name {get; set;}

				/// <exclude/>
				public ModelBuilder WithName(global::System.String value)
		        {
				    if(this.Name!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Name = value;
		            return this;
		        }	


	}

	public partial class Models : global::Allors.ObjectsBase<Model>
	{
		public static readonly ModelMeta Meta = ModelMeta.Instance;

		public Models(Allors.ISession session) : base(session)
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