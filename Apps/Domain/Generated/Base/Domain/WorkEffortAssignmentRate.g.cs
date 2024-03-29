// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class WorkEffortAssignmentRate
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (WorkEffortAssignmentRateBuilder)objectBuilder;

			this.DisplayName = builder.DisplayName;
		

			this.RateType = builder.RateType;



			this.WorkEffortPartyAssignment = builder.WorkEffortPartyAssignment;


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

	public partial class WorkEffortAssignmentRateBuilder : Allors.ObjectBuilder<WorkEffortAssignmentRate> , UserInterfaceableBuilder, global::System.IDisposable
	{		
		public WorkEffortAssignmentRateBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public RateType RateType {get; set;}

				/// <exclude/>
				public WorkEffortAssignmentRateBuilder WithRateType(RateType value)
		        {
		            if(this.RateType!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.RateType = value;
		            return this;
		        }		

				
				public WorkEffortPartyAssignment WorkEffortPartyAssignment {get; set;}

				/// <exclude/>
				public WorkEffortAssignmentRateBuilder WithWorkEffortPartyAssignment(WorkEffortPartyAssignment value)
		        {
		            if(this.WorkEffortPartyAssignment!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.WorkEffortPartyAssignment = value;
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public WorkEffortAssignmentRateBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public WorkEffortAssignmentRateBuilder WithDeniedPermission(Permission value)
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
				public WorkEffortAssignmentRateBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class WorkEffortAssignmentRates : global::Allors.ObjectsBase<WorkEffortAssignmentRate>
	{
		public static readonly WorkEffortAssignmentRateMeta Meta = WorkEffortAssignmentRateMeta.Instance;

		public WorkEffortAssignmentRates(Allors.ISession session) : base(session)
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