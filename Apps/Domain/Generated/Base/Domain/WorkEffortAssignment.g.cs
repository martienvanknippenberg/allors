// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class WorkEffortAssignment
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (WorkEffortAssignmentBuilder)objectBuilder;
			

			if(builder.FromDate.HasValue)
			{
				this.FromDate = builder.FromDate.Value;
			}			
					

			if(builder.ThroughDate.HasValue)
			{
				this.ThroughDate = builder.ThroughDate.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
		

			this.Comment = builder.Comment;
		

			this.Professional = builder.Professional;



			this.Assignment = builder.Assignment;


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

	public partial class WorkEffortAssignmentBuilder : Allors.ObjectBuilder<WorkEffortAssignment> , PeriodBuilder, UserInterfaceableBuilder, CommentableBuilder, global::System.IDisposable
	{		
		public WorkEffortAssignmentBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public Person Professional {get; set;}

				/// <exclude/>
				public WorkEffortAssignmentBuilder WithProfessional(Person value)
		        {
		            if(this.Professional!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Professional = value;
		            return this;
		        }		

				
				public WorkEffort Assignment {get; set;}

				/// <exclude/>
				public WorkEffortAssignmentBuilder WithAssignment(WorkEffort value)
		        {
		            if(this.Assignment!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Assignment = value;
		            return this;
		        }		

				
				public global::System.DateTime? FromDate {get; set;}

				/// <exclude/>
				public WorkEffortAssignmentBuilder WithFromDate(global::System.DateTime? value)
		        {
				    if(this.FromDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.FromDate = value;
		            return this;
		        }	

				public global::System.DateTime? ThroughDate {get; set;}

				/// <exclude/>
				public WorkEffortAssignmentBuilder WithThroughDate(global::System.DateTime? value)
		        {
				    if(this.ThroughDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ThroughDate = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public WorkEffortAssignmentBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public WorkEffortAssignmentBuilder WithDeniedPermission(Permission value)
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
				public WorkEffortAssignmentBuilder WithSecurityToken(SecurityToken value)
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
				public WorkEffortAssignmentBuilder WithComment(global::System.String value)
		        {
				    if(this.Comment!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Comment = value;
		            return this;
		        }	


	}

	public partial class WorkEffortAssignments : global::Allors.ObjectsBase<WorkEffortAssignment>
	{
		public static readonly WorkEffortAssignmentMeta Meta = WorkEffortAssignmentMeta.Instance;

		public WorkEffortAssignments(Allors.ISession session) : base(session)
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