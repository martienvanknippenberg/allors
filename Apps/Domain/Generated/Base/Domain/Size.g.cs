// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class Size
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (SizeBuilder)objectBuilder;
			

			if(builder.IsActive.HasValue)
			{
				this.IsActive = builder.IsActive.Value;
			}			
		

			this.Name = builder.Name;
		

			this.DisplayName = builder.DisplayName;
					

			if(builder.UniqueId.HasValue)
			{
				this.UniqueId = builder.UniqueId.Value;
			}			
		

			this.Description = builder.Description;
		
			if(builder.LocalisedNames!=null)
			{
				this.LocalisedNames = builder.LocalisedNames.ToArray();
			}

			if(builder.DeniedPermissions!=null)
			{
				this.DeniedPermissions = builder.DeniedPermissions.ToArray();
			}

			if(builder.SecurityTokens!=null)
			{
				this.SecurityTokens = builder.SecurityTokens.ToArray();
			}

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


		}
	}

	public partial class SizeBuilder : Allors.ObjectBuilder<Size> , EnumerationBuilder, ProductFeatureBuilder, global::System.IDisposable
	{		
		public SizeBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.Collections.Generic.List<LocalisedText> LocalisedNames {get; set;}	

				/// <exclude/>
				public SizeBuilder WithLocalisedName(LocalisedText value)
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
				public SizeBuilder WithIsActive(global::System.Boolean? value)
		        {
				    if(this.IsActive!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.IsActive = value;
		            return this;
		        }	

				public global::System.String Name {get; set;}

				/// <exclude/>
				public SizeBuilder WithName(global::System.String value)
		        {
				    if(this.Name!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Name = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public SizeBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public SizeBuilder WithDeniedPermission(Permission value)
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
				public SizeBuilder WithSecurityToken(SecurityToken value)
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
				public SizeBuilder WithUniqueId(global::System.Guid? value)
		        {
				    if(this.UniqueId!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UniqueId = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<EstimatedProductCost> EstimatedProductCosts {get; set;}	

				/// <exclude/>
				public SizeBuilder WithEstimatedProductCost(EstimatedProductCost value)
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
				public SizeBuilder WithBasePrice(PriceComponent value)
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
				public SizeBuilder WithDescription(global::System.String value)
		        {
				    if(this.Description!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Description = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<ProductFeature> DependentFeatures {get; set;}	

				/// <exclude/>
				public SizeBuilder WithDependentFeature(ProductFeature value)
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
				public SizeBuilder WithIncompatibleFeature(ProductFeature value)
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
				public SizeBuilder WithVatRate(VatRate value)
		        {
		            if(this.VatRate!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.VatRate = value;
		            return this;
		        }		

				
				public SearchData SearchData {get; set;}

				/// <exclude/>
				public SizeBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				

	}

	public partial class Sizes : global::Allors.ObjectsBase<Size>
	{
		public static readonly SizeMeta Meta = SizeMeta.Instance;

		public Sizes(Allors.ISession session) : base(session)
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