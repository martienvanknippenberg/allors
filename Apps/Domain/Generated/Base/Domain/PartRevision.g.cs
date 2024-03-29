// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class PartRevision
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (PartRevisionBuilder)objectBuilder;

			this.Reason = builder.Reason;
					

			if(builder.FromDate.HasValue)
			{
				this.FromDate = builder.FromDate.Value;
			}			
					

			if(builder.ThroughDate.HasValue)
			{
				this.ThroughDate = builder.ThroughDate.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
		

			this.SupersededByPart = builder.SupersededByPart;



			this.Part = builder.Part;


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

	public partial class PartRevisionBuilder : Allors.ObjectBuilder<PartRevision> , PeriodBuilder, UserInterfaceableBuilder, global::System.IDisposable
	{		
		public PartRevisionBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.String Reason {get; set;}

				/// <exclude/>
				public PartRevisionBuilder WithReason(global::System.String value)
		        {
				    if(this.Reason!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Reason = value;
		            return this;
		        }	

				public Part SupersededByPart {get; set;}

				/// <exclude/>
				public PartRevisionBuilder WithSupersededByPart(Part value)
		        {
		            if(this.SupersededByPart!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SupersededByPart = value;
		            return this;
		        }		

				
				public Part Part {get; set;}

				/// <exclude/>
				public PartRevisionBuilder WithPart(Part value)
		        {
		            if(this.Part!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Part = value;
		            return this;
		        }		

				
				public global::System.DateTime? FromDate {get; set;}

				/// <exclude/>
				public PartRevisionBuilder WithFromDate(global::System.DateTime? value)
		        {
				    if(this.FromDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.FromDate = value;
		            return this;
		        }	

				public global::System.DateTime? ThroughDate {get; set;}

				/// <exclude/>
				public PartRevisionBuilder WithThroughDate(global::System.DateTime? value)
		        {
				    if(this.ThroughDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ThroughDate = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public PartRevisionBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public PartRevisionBuilder WithDeniedPermission(Permission value)
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
				public PartRevisionBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class PartRevisions : global::Allors.ObjectsBase<PartRevision>
	{
		public static readonly PartRevisionMeta Meta = PartRevisionMeta.Instance;

		public PartRevisions(Allors.ISession session) : base(session)
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