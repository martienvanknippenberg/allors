// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class RequirementStatus
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (RequirementStatusBuilder)objectBuilder;
			

			if(builder.StartDateTime.HasValue)
			{
				this.StartDateTime = builder.StartDateTime.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
		

			this.RequirementObjectState = builder.RequirementObjectState;


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

	public partial class RequirementStatusBuilder : Allors.ObjectBuilder<RequirementStatus> , UserInterfaceableBuilder, global::System.IDisposable
	{		
		public RequirementStatusBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public RequirementObjectState RequirementObjectState {get; set;}

				/// <exclude/>
				public RequirementStatusBuilder WithRequirementObjectState(RequirementObjectState value)
		        {
		            if(this.RequirementObjectState!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.RequirementObjectState = value;
		            return this;
		        }		

				
				public global::System.DateTime? StartDateTime {get; set;}

				/// <exclude/>
				public RequirementStatusBuilder WithStartDateTime(global::System.DateTime? value)
		        {
				    if(this.StartDateTime!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.StartDateTime = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public RequirementStatusBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public RequirementStatusBuilder WithDeniedPermission(Permission value)
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
				public RequirementStatusBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class RequirementStatuses : global::Allors.ObjectsBase<RequirementStatus>
	{
		public static readonly RequirementStatusMeta Meta = RequirementStatusMeta.Instance;

		public RequirementStatuses(Allors.ISession session) : base(session)
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