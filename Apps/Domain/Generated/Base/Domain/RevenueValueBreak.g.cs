// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class RevenueValueBreak
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (RevenueValueBreakBuilder)objectBuilder;
			

			if(builder.ThroughAmount.HasValue)
			{
				this.ThroughAmount = builder.ThroughAmount.Value;
			}			
					

			if(builder.FromAmount.HasValue)
			{
				this.FromAmount = builder.FromAmount.Value;
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

	public partial class RevenueValueBreakBuilder : Allors.ObjectBuilder<RevenueValueBreak> , UserInterfaceableBuilder, global::System.IDisposable
	{		
		public RevenueValueBreakBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.Decimal? ThroughAmount {get; set;}

				/// <exclude/>
				public RevenueValueBreakBuilder WithThroughAmount(global::System.Decimal? value)
		        {
				    if(this.ThroughAmount!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ThroughAmount = value;
		            return this;
		        }	

				public global::System.Decimal? FromAmount {get; set;}

				/// <exclude/>
				public RevenueValueBreakBuilder WithFromAmount(global::System.Decimal? value)
		        {
				    if(this.FromAmount!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.FromAmount = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public RevenueValueBreakBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public RevenueValueBreakBuilder WithDeniedPermission(Permission value)
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
				public RevenueValueBreakBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class RevenueValueBreaks : global::Allors.ObjectsBase<RevenueValueBreak>
	{
		public static readonly RevenueValueBreakMeta Meta = RevenueValueBreakMeta.Instance;

		public RevenueValueBreaks(Allors.ISession session) : base(session)
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