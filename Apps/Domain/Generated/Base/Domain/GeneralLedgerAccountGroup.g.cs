// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class GeneralLedgerAccountGroup
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (GeneralLedgerAccountGroupBuilder)objectBuilder;

			this.Description = builder.Description;
		

			this.DisplayName = builder.DisplayName;
		

			this.Parent = builder.Parent;


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

	public partial class GeneralLedgerAccountGroupBuilder : Allors.ObjectBuilder<GeneralLedgerAccountGroup> , AccessControlledObjectBuilder, UserInterfaceableBuilder, global::System.IDisposable
	{		
		public GeneralLedgerAccountGroupBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public GeneralLedgerAccountGroup Parent {get; set;}

				/// <exclude/>
				public GeneralLedgerAccountGroupBuilder WithParent(GeneralLedgerAccountGroup value)
		        {
		            if(this.Parent!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Parent = value;
		            return this;
		        }		

				
				public global::System.String Description {get; set;}

				/// <exclude/>
				public GeneralLedgerAccountGroupBuilder WithDescription(global::System.String value)
		        {
				    if(this.Description!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Description = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public GeneralLedgerAccountGroupBuilder WithDeniedPermission(Permission value)
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
				public GeneralLedgerAccountGroupBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public GeneralLedgerAccountGroupBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	


	}

	public partial class GeneralLedgerAccountGroups : global::Allors.ObjectsBase<GeneralLedgerAccountGroup>
	{
		public static readonly GeneralLedgerAccountGroupMeta Meta = GeneralLedgerAccountGroupMeta.Instance;

		public GeneralLedgerAccountGroups(Allors.ISession session) : base(session)
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