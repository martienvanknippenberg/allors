// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class Incentive
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (IncentiveBuilder)objectBuilder;

			this.TermValue = builder.TermValue;
		

			this.Description = builder.Description;
		

			this.DisplayName = builder.DisplayName;
		

			this.TermType = builder.TermType;


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

	public partial class IncentiveBuilder : Allors.ObjectBuilder<Incentive> , AgreementTermBuilder, global::System.IDisposable
	{		
		public IncentiveBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.String TermValue {get; set;}

				/// <exclude/>
				public IncentiveBuilder WithTermValue(global::System.String value)
		        {
				    if(this.TermValue!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.TermValue = value;
		            return this;
		        }	

				public TermType TermType {get; set;}

				/// <exclude/>
				public IncentiveBuilder WithTermType(TermType value)
		        {
		            if(this.TermType!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.TermType = value;
		            return this;
		        }		

				
				public global::System.String Description {get; set;}

				/// <exclude/>
				public IncentiveBuilder WithDescription(global::System.String value)
		        {
				    if(this.Description!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Description = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public IncentiveBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public IncentiveBuilder WithDeniedPermission(Permission value)
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
				public IncentiveBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class Incentives : global::Allors.ObjectsBase<Incentive>
	{
		public static readonly IncentiveMeta Meta = IncentiveMeta.Instance;

		public Incentives(Allors.ISession session) : base(session)
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