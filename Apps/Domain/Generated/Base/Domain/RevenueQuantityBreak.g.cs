// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class RevenueQuantityBreak
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (RevenueQuantityBreakBuilder)objectBuilder;
			

			if(builder.Through.HasValue)
			{
				this.Through = builder.Through.Value;
			}			
					

			if(builder.From.HasValue)
			{
				this.From = builder.From.Value;
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

	public partial class RevenueQuantityBreakBuilder : Allors.ObjectBuilder<RevenueQuantityBreak> , UserInterfaceableBuilder, global::System.IDisposable
	{		
		public RevenueQuantityBreakBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.Decimal? Through {get; set;}

				/// <exclude/>
				public RevenueQuantityBreakBuilder WithThrough(global::System.Decimal? value)
		        {
				    if(this.Through!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Through = value;
		            return this;
		        }	

				public global::System.Decimal? From {get; set;}

				/// <exclude/>
				public RevenueQuantityBreakBuilder WithFrom(global::System.Decimal? value)
		        {
				    if(this.From!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.From = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public RevenueQuantityBreakBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public RevenueQuantityBreakBuilder WithDeniedPermission(Permission value)
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
				public RevenueQuantityBreakBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class RevenueQuantityBreaks : global::Allors.ObjectsBase<RevenueQuantityBreak>
	{
		public static readonly RevenueQuantityBreakMeta Meta = RevenueQuantityBreakMeta.Instance;

		public RevenueQuantityBreaks(Allors.ISession session) : base(session)
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