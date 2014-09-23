// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class ProductRequirement
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (ProductRequirementBuilder)objectBuilder;
			

			if(builder.RequiredByDate.HasValue)
			{
				this.RequiredByDate = builder.RequiredByDate.Value;
			}			
		

			this.Reason = builder.Reason;
					

			if(builder.EstimatedBudget.HasValue)
			{
				this.EstimatedBudget = builder.EstimatedBudget.Value;
			}			
		

			this.Description = builder.Description;
					

			if(builder.Quantity.HasValue)
			{
				this.Quantity = builder.Quantity.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
					

			if(builder.UniqueId.HasValue)
			{
				this.UniqueId = builder.UniqueId.Value;
			}			
		

			this.Product = builder.Product;


			if(builder.DesiredProductFeatures!=null)
			{
				this.DesiredProductFeatures = builder.DesiredProductFeatures.ToArray();
			}


			this.PreviousObjectState = builder.PreviousObjectState;



			this.Authorizer = builder.Authorizer;


			if(builder.RequirementStatuses!=null)
			{
				this.RequirementStatuses = builder.RequirementStatuses.ToArray();
			}

			if(builder.Children!=null)
			{
				this.Children = builder.Children.ToArray();
			}


			this.NeededFor = builder.NeededFor;



			this.Originator = builder.Originator;



			this.CurrentObjectState = builder.CurrentObjectState;



			this.CurrentRequirementStatus = builder.CurrentRequirementStatus;



			this.Facility = builder.Facility;



			this.ServicedBy = builder.ServicedBy;


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

	public partial class ProductRequirementBuilder : Allors.ObjectBuilder<ProductRequirement> , RequirementBuilder, global::System.IDisposable
	{		
		public ProductRequirementBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public Product Product {get; set;}

				/// <exclude/>
				public ProductRequirementBuilder WithProduct(Product value)
		        {
		            if(this.Product!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Product = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<DesiredProductFeature> DesiredProductFeatures {get; set;}	

				/// <exclude/>
				public ProductRequirementBuilder WithDesiredProductFeature(DesiredProductFeature value)
		        {
					if(this.DesiredProductFeatures == null)
					{
						this.DesiredProductFeatures = new global::System.Collections.Generic.List<DesiredProductFeature>(); 
					}
		            this.DesiredProductFeatures.Add(value);
		            return this;
		        }		

				
				public global::System.DateTime? RequiredByDate {get; set;}

				/// <exclude/>
				public ProductRequirementBuilder WithRequiredByDate(global::System.DateTime? value)
		        {
				    if(this.RequiredByDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.RequiredByDate = value;
		            return this;
		        }	

				public RequirementObjectState PreviousObjectState {get; set;}

				/// <exclude/>
				public ProductRequirementBuilder WithPreviousObjectState(RequirementObjectState value)
		        {
		            if(this.PreviousObjectState!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.PreviousObjectState = value;
		            return this;
		        }		

				
				public Party Authorizer {get; set;}

				/// <exclude/>
				public ProductRequirementBuilder WithAuthorizer(Party value)
		        {
		            if(this.Authorizer!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Authorizer = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<RequirementStatus> RequirementStatuses {get; set;}	

				/// <exclude/>
				public ProductRequirementBuilder WithRequirementStatus(RequirementStatus value)
		        {
					if(this.RequirementStatuses == null)
					{
						this.RequirementStatuses = new global::System.Collections.Generic.List<RequirementStatus>(); 
					}
		            this.RequirementStatuses.Add(value);
		            return this;
		        }		

				
				public global::System.String Reason {get; set;}

				/// <exclude/>
				public ProductRequirementBuilder WithReason(global::System.String value)
		        {
				    if(this.Reason!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Reason = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Requirement> Children {get; set;}	

				/// <exclude/>
				public ProductRequirementBuilder WithChild(Requirement value)
		        {
					if(this.Children == null)
					{
						this.Children = new global::System.Collections.Generic.List<Requirement>(); 
					}
		            this.Children.Add(value);
		            return this;
		        }		

				
				public Party NeededFor {get; set;}

				/// <exclude/>
				public ProductRequirementBuilder WithNeededFor(Party value)
		        {
		            if(this.NeededFor!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.NeededFor = value;
		            return this;
		        }		

				
				public Party Originator {get; set;}

				/// <exclude/>
				public ProductRequirementBuilder WithOriginator(Party value)
		        {
		            if(this.Originator!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Originator = value;
		            return this;
		        }		

				
				public RequirementObjectState CurrentObjectState {get; set;}

				/// <exclude/>
				public ProductRequirementBuilder WithCurrentObjectState(RequirementObjectState value)
		        {
		            if(this.CurrentObjectState!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.CurrentObjectState = value;
		            return this;
		        }		

				
				public RequirementStatus CurrentRequirementStatus {get; set;}

				/// <exclude/>
				public ProductRequirementBuilder WithCurrentRequirementStatus(RequirementStatus value)
		        {
		            if(this.CurrentRequirementStatus!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.CurrentRequirementStatus = value;
		            return this;
		        }		

				
				public Facility Facility {get; set;}

				/// <exclude/>
				public ProductRequirementBuilder WithFacility(Facility value)
		        {
		            if(this.Facility!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Facility = value;
		            return this;
		        }		

				
				public Party ServicedBy {get; set;}

				/// <exclude/>
				public ProductRequirementBuilder WithServicedBy(Party value)
		        {
		            if(this.ServicedBy!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.ServicedBy = value;
		            return this;
		        }		

				
				public global::System.Decimal? EstimatedBudget {get; set;}

				/// <exclude/>
				public ProductRequirementBuilder WithEstimatedBudget(global::System.Decimal? value)
		        {
				    if(this.EstimatedBudget!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.EstimatedBudget = value;
		            return this;
		        }	

				public global::System.String Description {get; set;}

				/// <exclude/>
				public ProductRequirementBuilder WithDescription(global::System.String value)
		        {
				    if(this.Description!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Description = value;
		            return this;
		        }	

				public global::System.Int32? Quantity {get; set;}

				/// <exclude/>
				public ProductRequirementBuilder WithQuantity(global::System.Int32? value)
		        {
				    if(this.Quantity!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Quantity = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public ProductRequirementBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public ProductRequirementBuilder WithDeniedPermission(Permission value)
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
				public ProductRequirementBuilder WithSecurityToken(SecurityToken value)
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
				public ProductRequirementBuilder WithUniqueId(global::System.Guid? value)
		        {
				    if(this.UniqueId!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UniqueId = value;
		            return this;
		        }	

				public SearchData SearchData {get; set;}

				/// <exclude/>
				public ProductRequirementBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				

	}

	public partial class ProductRequirements : global::Allors.ObjectsBase<ProductRequirement>
	{
		public static readonly ProductRequirementMeta Meta = ProductRequirementMeta.Instance;

		public ProductRequirements(Allors.ISession session) : base(session)
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