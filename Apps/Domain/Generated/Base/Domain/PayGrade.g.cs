// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class PayGrade
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (PayGradeBuilder)objectBuilder;

			this.Name = builder.Name;
		

			this.DisplayName = builder.DisplayName;
		

			this.Comment = builder.Comment;
		
			if(builder.SalarySteps!=null)
			{
				this.SalarySteps = builder.SalarySteps.ToArray();
			}

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

	public partial class PayGradeBuilder : Allors.ObjectBuilder<PayGrade> , UserInterfaceableBuilder, CommentableBuilder, global::System.IDisposable
	{		
		public PayGradeBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.String Name {get; set;}

				/// <exclude/>
				public PayGradeBuilder WithName(global::System.String value)
		        {
				    if(this.Name!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Name = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<SalaryStep> SalarySteps {get; set;}	

				/// <exclude/>
				public PayGradeBuilder WithSalaryStep(SalaryStep value)
		        {
					if(this.SalarySteps == null)
					{
						this.SalarySteps = new global::System.Collections.Generic.List<SalaryStep>(); 
					}
		            this.SalarySteps.Add(value);
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public PayGradeBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public PayGradeBuilder WithDeniedPermission(Permission value)
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
				public PayGradeBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				
				public global::System.String Comment {get; set;}

				/// <exclude/>
				public PayGradeBuilder WithComment(global::System.String value)
		        {
				    if(this.Comment!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Comment = value;
		            return this;
		        }	


	}

	public partial class PayGrades : global::Allors.ObjectsBase<PayGrade>
	{
		public static readonly PayGradeMeta Meta = PayGradeMeta.Instance;

		public PayGrades(Allors.ISession session) : base(session)
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