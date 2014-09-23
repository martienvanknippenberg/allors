// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class Resume
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (ResumeBuilder)objectBuilder;
			

			if(builder.ResumeDate.HasValue)
			{
				this.ResumeDate = builder.ResumeDate.Value;
			}			
		

			this.ResumeText = builder.ResumeText;
		

			this.DisplayName = builder.DisplayName;
		

			this.SearchData = builder.SearchData;


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

	public partial class ResumeBuilder : Allors.ObjectBuilder<Resume> , SearchableBuilder, UserInterfaceableBuilder, global::System.IDisposable
	{		
		public ResumeBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.DateTime? ResumeDate {get; set;}

				/// <exclude/>
				public ResumeBuilder WithResumeDate(global::System.DateTime? value)
		        {
				    if(this.ResumeDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ResumeDate = value;
		            return this;
		        }	

				public global::System.String ResumeText {get; set;}

				/// <exclude/>
				public ResumeBuilder WithResumeText(global::System.String value)
		        {
				    if(this.ResumeText!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ResumeText = value;
		            return this;
		        }	

				public SearchData SearchData {get; set;}

				/// <exclude/>
				public ResumeBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public ResumeBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public ResumeBuilder WithDeniedPermission(Permission value)
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
				public ResumeBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class Resumes : global::Allors.ObjectsBase<Resume>
	{
		public static readonly ResumeMeta Meta = ResumeMeta.Instance;

		public Resumes(Allors.ISession session) : base(session)
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