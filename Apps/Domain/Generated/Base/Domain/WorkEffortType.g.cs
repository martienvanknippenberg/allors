// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class WorkEffortType
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (WorkEffortTypeBuilder)objectBuilder;

			this.Description = builder.Description;
					

			if(builder.StandardWorkHours.HasValue)
			{
				this.StandardWorkHours = builder.StandardWorkHours.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
		
			if(builder.WorkEffortFixedAssetStandards!=null)
			{
				this.WorkEffortFixedAssetStandards = builder.WorkEffortFixedAssetStandards.ToArray();
			}

			if(builder.WorkEffortGoodStandards!=null)
			{
				this.WorkEffortGoodStandards = builder.WorkEffortGoodStandards.ToArray();
			}

			if(builder.Children!=null)
			{
				this.Children = builder.Children.ToArray();
			}


			this.FixedAssetToRepair = builder.FixedAssetToRepair;


			if(builder.Dependencies!=null)
			{
				this.Dependencies = builder.Dependencies.ToArray();
			}


			this.WorkEffortTypeKind = builder.WorkEffortTypeKind;


			if(builder.WorkEffortPartStandards!=null)
			{
				this.WorkEffortPartStandards = builder.WorkEffortPartStandards.ToArray();
			}

			if(builder.WorkEffortSkillStandards!=null)
			{
				this.WorkEffortSkillStandards = builder.WorkEffortSkillStandards.ToArray();
			}


			this.ProductToProduce = builder.ProductToProduce;



			this.DeliverableToProduce = builder.DeliverableToProduce;



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

	public partial class WorkEffortTypeBuilder : Allors.ObjectBuilder<WorkEffortType> , SearchableBuilder, UserInterfaceableBuilder, global::System.IDisposable
	{		
		public WorkEffortTypeBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.Collections.Generic.List<WorkEffortFixedAssetStandard> WorkEffortFixedAssetStandards {get; set;}	

				/// <exclude/>
				public WorkEffortTypeBuilder WithWorkEffortFixedAssetStandard(WorkEffortFixedAssetStandard value)
		        {
					if(this.WorkEffortFixedAssetStandards == null)
					{
						this.WorkEffortFixedAssetStandards = new global::System.Collections.Generic.List<WorkEffortFixedAssetStandard>(); 
					}
		            this.WorkEffortFixedAssetStandards.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<WorkEffortGoodStandard> WorkEffortGoodStandards {get; set;}	

				/// <exclude/>
				public WorkEffortTypeBuilder WithWorkEffortGoodStandard(WorkEffortGoodStandard value)
		        {
					if(this.WorkEffortGoodStandards == null)
					{
						this.WorkEffortGoodStandards = new global::System.Collections.Generic.List<WorkEffortGoodStandard>(); 
					}
		            this.WorkEffortGoodStandards.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<WorkEffortType> Children {get; set;}	

				/// <exclude/>
				public WorkEffortTypeBuilder WithChild(WorkEffortType value)
		        {
					if(this.Children == null)
					{
						this.Children = new global::System.Collections.Generic.List<WorkEffortType>(); 
					}
		            this.Children.Add(value);
		            return this;
		        }		

				
				public FixedAsset FixedAssetToRepair {get; set;}

				/// <exclude/>
				public WorkEffortTypeBuilder WithFixedAssetToRepair(FixedAsset value)
		        {
		            if(this.FixedAssetToRepair!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.FixedAssetToRepair = value;
		            return this;
		        }		

				
				public global::System.String Description {get; set;}

				/// <exclude/>
				public WorkEffortTypeBuilder WithDescription(global::System.String value)
		        {
				    if(this.Description!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Description = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<WorkEffortType> Dependencies {get; set;}	

				/// <exclude/>
				public WorkEffortTypeBuilder WithDependency(WorkEffortType value)
		        {
					if(this.Dependencies == null)
					{
						this.Dependencies = new global::System.Collections.Generic.List<WorkEffortType>(); 
					}
		            this.Dependencies.Add(value);
		            return this;
		        }		

				
				public WorkEffortTypeKind WorkEffortTypeKind {get; set;}

				/// <exclude/>
				public WorkEffortTypeBuilder WithWorkEffortTypeKind(WorkEffortTypeKind value)
		        {
		            if(this.WorkEffortTypeKind!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.WorkEffortTypeKind = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<WorkEffortPartStandard> WorkEffortPartStandards {get; set;}	

				/// <exclude/>
				public WorkEffortTypeBuilder WithWorkEffortPartStandard(WorkEffortPartStandard value)
		        {
					if(this.WorkEffortPartStandards == null)
					{
						this.WorkEffortPartStandards = new global::System.Collections.Generic.List<WorkEffortPartStandard>(); 
					}
		            this.WorkEffortPartStandards.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<WorkEffortSkillStandard> WorkEffortSkillStandards {get; set;}	

				/// <exclude/>
				public WorkEffortTypeBuilder WithWorkEffortSkillStandard(WorkEffortSkillStandard value)
		        {
					if(this.WorkEffortSkillStandards == null)
					{
						this.WorkEffortSkillStandards = new global::System.Collections.Generic.List<WorkEffortSkillStandard>(); 
					}
		            this.WorkEffortSkillStandards.Add(value);
		            return this;
		        }		

				
				public global::System.Decimal? StandardWorkHours {get; set;}

				/// <exclude/>
				public WorkEffortTypeBuilder WithStandardWorkHours(global::System.Decimal? value)
		        {
				    if(this.StandardWorkHours!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.StandardWorkHours = value;
		            return this;
		        }	

				public Product ProductToProduce {get; set;}

				/// <exclude/>
				public WorkEffortTypeBuilder WithProductToProduce(Product value)
		        {
		            if(this.ProductToProduce!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.ProductToProduce = value;
		            return this;
		        }		

				
				public Deliverable DeliverableToProduce {get; set;}

				/// <exclude/>
				public WorkEffortTypeBuilder WithDeliverableToProduce(Deliverable value)
		        {
		            if(this.DeliverableToProduce!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.DeliverableToProduce = value;
		            return this;
		        }		

				
				public SearchData SearchData {get; set;}

				/// <exclude/>
				public WorkEffortTypeBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public WorkEffortTypeBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public WorkEffortTypeBuilder WithDeniedPermission(Permission value)
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
				public WorkEffortTypeBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class WorkEffortTypes : global::Allors.ObjectsBase<WorkEffortType>
	{
		public static readonly WorkEffortTypeMeta Meta = WorkEffortTypeMeta.Instance;

		public WorkEffortTypes(Allors.ISession session) : base(session)
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