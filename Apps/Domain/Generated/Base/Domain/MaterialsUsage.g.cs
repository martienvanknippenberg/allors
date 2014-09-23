// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class MaterialsUsage
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (MaterialsUsageBuilder)objectBuilder;
			

			if(builder.Amount.HasValue)
			{
				this.Amount = builder.Amount.Value;
			}			
					

			if(builder.ThroughDateTime.HasValue)
			{
				this.ThroughDateTime = builder.ThroughDateTime.Value;
			}			
					

			if(builder.IsBillable.HasValue)
			{
				this.IsBillable = builder.IsBillable.Value;
			}			
					

			if(builder.FromDateTime.HasValue)
			{
				this.FromDateTime = builder.FromDateTime.Value;
			}			
		

			this.Description = builder.Description;
		

			this.Comment = builder.Comment;
		

			this.DisplayName = builder.DisplayName;
		

			this.EngagementItem = builder.EngagementItem;



			this.WorkEffort = builder.WorkEffort;


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

	public partial class MaterialsUsageBuilder : Allors.ObjectBuilder<MaterialsUsage> , ServiceEntryBuilder, global::System.IDisposable
	{		
		public MaterialsUsageBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.Decimal? Amount {get; set;}

				/// <exclude/>
				public MaterialsUsageBuilder WithAmount(global::System.Decimal? value)
		        {
				    if(this.Amount!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Amount = value;
		            return this;
		        }	

				public global::System.DateTime? ThroughDateTime {get; set;}

				/// <exclude/>
				public MaterialsUsageBuilder WithThroughDateTime(global::System.DateTime? value)
		        {
				    if(this.ThroughDateTime!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ThroughDateTime = value;
		            return this;
		        }	

				public EngagementItem EngagementItem {get; set;}

				/// <exclude/>
				public MaterialsUsageBuilder WithEngagementItem(EngagementItem value)
		        {
		            if(this.EngagementItem!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.EngagementItem = value;
		            return this;
		        }		

				
				public global::System.Boolean? IsBillable {get; set;}

				/// <exclude/>
				public MaterialsUsageBuilder WithIsBillable(global::System.Boolean? value)
		        {
				    if(this.IsBillable!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.IsBillable = value;
		            return this;
		        }	

				public global::System.DateTime? FromDateTime {get; set;}

				/// <exclude/>
				public MaterialsUsageBuilder WithFromDateTime(global::System.DateTime? value)
		        {
				    if(this.FromDateTime!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.FromDateTime = value;
		            return this;
		        }	

				public global::System.String Description {get; set;}

				/// <exclude/>
				public MaterialsUsageBuilder WithDescription(global::System.String value)
		        {
				    if(this.Description!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Description = value;
		            return this;
		        }	

				public WorkEffort WorkEffort {get; set;}

				/// <exclude/>
				public MaterialsUsageBuilder WithWorkEffort(WorkEffort value)
		        {
		            if(this.WorkEffort!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.WorkEffort = value;
		            return this;
		        }		

				
				public global::System.String Comment {get; set;}

				/// <exclude/>
				public MaterialsUsageBuilder WithComment(global::System.String value)
		        {
				    if(this.Comment!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Comment = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public MaterialsUsageBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public MaterialsUsageBuilder WithDeniedPermission(Permission value)
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
				public MaterialsUsageBuilder WithSecurityToken(SecurityToken value)
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
				public MaterialsUsageBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				

	}

	public partial class MaterialsUsages : global::Allors.ObjectsBase<MaterialsUsage>
	{
		public static readonly MaterialsUsageMeta Meta = MaterialsUsageMeta.Instance;

		public MaterialsUsages(Allors.ISession session) : base(session)
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