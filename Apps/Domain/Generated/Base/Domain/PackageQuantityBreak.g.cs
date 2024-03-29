// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class PackageQuantityBreak
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (PackageQuantityBreakBuilder)objectBuilder;
			

			if(builder.From.HasValue)
			{
				this.From = builder.From.Value;
			}			
					

			if(builder.Through.HasValue)
			{
				this.Through = builder.Through.Value;
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

	public partial class PackageQuantityBreakBuilder : Allors.ObjectBuilder<PackageQuantityBreak> , UserInterfaceableBuilder, global::System.IDisposable
	{		
		public PackageQuantityBreakBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.Int32? From {get; set;}

				/// <exclude/>
				public PackageQuantityBreakBuilder WithFrom(global::System.Int32? value)
		        {
				    if(this.From!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.From = value;
		            return this;
		        }	

				public global::System.Int32? Through {get; set;}

				/// <exclude/>
				public PackageQuantityBreakBuilder WithThrough(global::System.Int32? value)
		        {
				    if(this.Through!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Through = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public PackageQuantityBreakBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public PackageQuantityBreakBuilder WithDeniedPermission(Permission value)
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
				public PackageQuantityBreakBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class PackageQuantityBreaks : global::Allors.ObjectsBase<PackageQuantityBreak>
	{
		public static readonly PackageQuantityBreakMeta Meta = PackageQuantityBreakMeta.Instance;

		public PackageQuantityBreaks(Allors.ISession session) : base(session)
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