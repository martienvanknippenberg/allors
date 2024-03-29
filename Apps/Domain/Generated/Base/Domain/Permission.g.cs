// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class Permission
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (PermissionBuilder)objectBuilder;
			

			if(builder.OperandTypePointer.HasValue)
			{
				this.OperandTypePointer = builder.OperandTypePointer.Value;
			}			
					

			if(builder.ConcreteClassPointer.HasValue)
			{
				this.ConcreteClassPointer = builder.ConcreteClassPointer.Value;
			}			
					

			if(builder.OperationEnum.HasValue)
			{
				this.OperationEnum = builder.OperationEnum.Value;
			}			
		

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

	public partial class PermissionBuilder : Allors.ObjectBuilder<Permission> , UserInterfaceableBuilder, global::System.IDisposable
	{		
		public PermissionBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.Guid? OperandTypePointer {get; set;}

				/// <exclude/>
				public PermissionBuilder WithOperandTypePointer(global::System.Guid? value)
		        {
				    if(this.OperandTypePointer!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.OperandTypePointer = value;
		            return this;
		        }	

				public global::System.Guid? ConcreteClassPointer {get; set;}

				/// <exclude/>
				public PermissionBuilder WithConcreteClassPointer(global::System.Guid? value)
		        {
				    if(this.ConcreteClassPointer!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ConcreteClassPointer = value;
		            return this;
		        }	

				public global::System.Int32? OperationEnum {get; set;}

				/// <exclude/>
				public PermissionBuilder WithOperationEnum(global::System.Int32? value)
		        {
				    if(this.OperationEnum!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.OperationEnum = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public PermissionBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public PermissionBuilder WithDeniedPermission(Permission value)
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
				public PermissionBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class Permissions : global::Allors.ObjectsBase<Permission>
	{
		public static readonly PermissionMeta Meta = PermissionMeta.Instance;

		public Permissions(Allors.ISession session) : base(session)
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