// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class VatReturnBox
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (VatReturnBoxBuilder)objectBuilder;

			this.HeaderNumber = builder.HeaderNumber;
		

			this.Description = builder.Description;
		

			this.DisplayName = builder.DisplayName;
		
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

	public partial class VatReturnBoxBuilder : Allors.ObjectBuilder<VatReturnBox> , UserInterfaceableBuilder, AccessControlledObjectBuilder, global::System.IDisposable
	{		
		public VatReturnBoxBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.String HeaderNumber {get; set;}

				/// <exclude/>
				public VatReturnBoxBuilder WithHeaderNumber(global::System.String value)
		        {
				    if(this.HeaderNumber!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.HeaderNumber = value;
		            return this;
		        }	

				public global::System.String Description {get; set;}

				/// <exclude/>
				public VatReturnBoxBuilder WithDescription(global::System.String value)
		        {
				    if(this.Description!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Description = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public VatReturnBoxBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public VatReturnBoxBuilder WithDeniedPermission(Permission value)
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
				public VatReturnBoxBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class VatReturnBoxes : global::Allors.ObjectsBase<VatReturnBox>
	{
		public static readonly VatReturnBoxMeta Meta = VatReturnBoxMeta.Instance;

		public VatReturnBoxes(Allors.ISession session) : base(session)
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