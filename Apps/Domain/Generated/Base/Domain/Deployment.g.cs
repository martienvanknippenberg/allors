// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class Deployment
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (DeploymentBuilder)objectBuilder;

			this.DisplayName = builder.DisplayName;
					

			if(builder.FromDate.HasValue)
			{
				this.FromDate = builder.FromDate.Value;
			}			
					

			if(builder.ThroughDate.HasValue)
			{
				this.ThroughDate = builder.ThroughDate.Value;
			}			
		

			this.ProductOffering = builder.ProductOffering;



			this.DeploymentUsage = builder.DeploymentUsage;



			this.SerializedInventoryItem = builder.SerializedInventoryItem;



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

	public partial class DeploymentBuilder : Allors.ObjectBuilder<Deployment> , SearchableBuilder, UserInterfaceableBuilder, PeriodBuilder, SearchResultBuilder, global::System.IDisposable
	{		
		public DeploymentBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public Good ProductOffering {get; set;}

				/// <exclude/>
				public DeploymentBuilder WithProductOffering(Good value)
		        {
		            if(this.ProductOffering!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.ProductOffering = value;
		            return this;
		        }		

				
				public DeploymentUsage DeploymentUsage {get; set;}

				/// <exclude/>
				public DeploymentBuilder WithDeploymentUsage(DeploymentUsage value)
		        {
		            if(this.DeploymentUsage!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.DeploymentUsage = value;
		            return this;
		        }		

				
				public SerializedInventoryItem SerializedInventoryItem {get; set;}

				/// <exclude/>
				public DeploymentBuilder WithSerializedInventoryItem(SerializedInventoryItem value)
		        {
		            if(this.SerializedInventoryItem!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SerializedInventoryItem = value;
		            return this;
		        }		

				
				public SearchData SearchData {get; set;}

				/// <exclude/>
				public DeploymentBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public DeploymentBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public DeploymentBuilder WithDeniedPermission(Permission value)
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
				public DeploymentBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				
				public global::System.DateTime? FromDate {get; set;}

				/// <exclude/>
				public DeploymentBuilder WithFromDate(global::System.DateTime? value)
		        {
				    if(this.FromDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.FromDate = value;
		            return this;
		        }	

				public global::System.DateTime? ThroughDate {get; set;}

				/// <exclude/>
				public DeploymentBuilder WithThroughDate(global::System.DateTime? value)
		        {
				    if(this.ThroughDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ThroughDate = value;
		            return this;
		        }	


	}

	public partial class Deployments : global::Allors.ObjectsBase<Deployment>
	{
		public static readonly DeploymentMeta Meta = DeploymentMeta.Instance;

		public Deployments(Allors.ISession session) : base(session)
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