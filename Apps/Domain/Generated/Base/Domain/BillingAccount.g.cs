// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class BillingAccount
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (BillingAccountBuilder)objectBuilder;

			this.Description = builder.Description;
		

			this.DisplayName = builder.DisplayName;
		

			this.ContactMechanism = builder.ContactMechanism;


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

	public partial class BillingAccountBuilder : Allors.ObjectBuilder<BillingAccount> , UserInterfaceableBuilder, global::System.IDisposable
	{		
		public BillingAccountBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.String Description {get; set;}

				/// <exclude/>
				public BillingAccountBuilder WithDescription(global::System.String value)
		        {
				    if(this.Description!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Description = value;
		            return this;
		        }	

				public ContactMechanism ContactMechanism {get; set;}

				/// <exclude/>
				public BillingAccountBuilder WithContactMechanism(ContactMechanism value)
		        {
		            if(this.ContactMechanism!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.ContactMechanism = value;
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public BillingAccountBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public BillingAccountBuilder WithDeniedPermission(Permission value)
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
				public BillingAccountBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class BillingAccounts : global::Allors.ObjectsBase<BillingAccount>
	{
		public static readonly BillingAccountMeta Meta = BillingAccountMeta.Instance;

		public BillingAccounts(Allors.ISession session) : base(session)
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