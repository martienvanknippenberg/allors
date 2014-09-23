// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class EngineeringChange
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (EngineeringChangeBuilder)objectBuilder;

			this.Description = builder.Description;
		

			this.DisplayName = builder.DisplayName;
		

			this.Requestor = builder.Requestor;



			this.Authorizer = builder.Authorizer;



			this.PreviousObjectState = builder.PreviousObjectState;



			this.Designer = builder.Designer;


			if(builder.PartSpecifications!=null)
			{
				this.PartSpecifications = builder.PartSpecifications.ToArray();
			}

			if(builder.PartBillOfMaterials!=null)
			{
				this.PartBillOfMaterials = builder.PartBillOfMaterials.ToArray();
			}


			this.CurrentObjectState = builder.CurrentObjectState;


			if(builder.EngineeringChangeStatuses!=null)
			{
				this.EngineeringChangeStatuses = builder.EngineeringChangeStatuses.ToArray();
			}


			this.Tester = builder.Tester;



			this.CurrentEngineeringChangeStatus = builder.CurrentEngineeringChangeStatus;



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

	public partial class EngineeringChangeBuilder : Allors.ObjectBuilder<EngineeringChange> , SearchableBuilder, TransitionalBuilder, UserInterfaceableBuilder, SearchResultBuilder, global::System.IDisposable
	{		
		public EngineeringChangeBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public Person Requestor {get; set;}

				/// <exclude/>
				public EngineeringChangeBuilder WithRequestor(Person value)
		        {
		            if(this.Requestor!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Requestor = value;
		            return this;
		        }		

				
				public Person Authorizer {get; set;}

				/// <exclude/>
				public EngineeringChangeBuilder WithAuthorizer(Person value)
		        {
		            if(this.Authorizer!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Authorizer = value;
		            return this;
		        }		

				
				public global::System.String Description {get; set;}

				/// <exclude/>
				public EngineeringChangeBuilder WithDescription(global::System.String value)
		        {
				    if(this.Description!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Description = value;
		            return this;
		        }	

				public EngineeringChangeObjectState PreviousObjectState {get; set;}

				/// <exclude/>
				public EngineeringChangeBuilder WithPreviousObjectState(EngineeringChangeObjectState value)
		        {
		            if(this.PreviousObjectState!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.PreviousObjectState = value;
		            return this;
		        }		

				
				public Person Designer {get; set;}

				/// <exclude/>
				public EngineeringChangeBuilder WithDesigner(Person value)
		        {
		            if(this.Designer!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Designer = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<PartSpecification> PartSpecifications {get; set;}	

				/// <exclude/>
				public EngineeringChangeBuilder WithPartSpecification(PartSpecification value)
		        {
					if(this.PartSpecifications == null)
					{
						this.PartSpecifications = new global::System.Collections.Generic.List<PartSpecification>(); 
					}
		            this.PartSpecifications.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<PartBillOfMaterial> PartBillOfMaterials {get; set;}	

				/// <exclude/>
				public EngineeringChangeBuilder WithPartBillOfMaterial(PartBillOfMaterial value)
		        {
					if(this.PartBillOfMaterials == null)
					{
						this.PartBillOfMaterials = new global::System.Collections.Generic.List<PartBillOfMaterial>(); 
					}
		            this.PartBillOfMaterials.Add(value);
		            return this;
		        }		

				
				public EngineeringChangeObjectState CurrentObjectState {get; set;}

				/// <exclude/>
				public EngineeringChangeBuilder WithCurrentObjectState(EngineeringChangeObjectState value)
		        {
		            if(this.CurrentObjectState!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.CurrentObjectState = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<EngineeringChangeStatus> EngineeringChangeStatuses {get; set;}	

				/// <exclude/>
				public EngineeringChangeBuilder WithEngineeringChangeStatus(EngineeringChangeStatus value)
		        {
					if(this.EngineeringChangeStatuses == null)
					{
						this.EngineeringChangeStatuses = new global::System.Collections.Generic.List<EngineeringChangeStatus>(); 
					}
		            this.EngineeringChangeStatuses.Add(value);
		            return this;
		        }		

				
				public Person Tester {get; set;}

				/// <exclude/>
				public EngineeringChangeBuilder WithTester(Person value)
		        {
		            if(this.Tester!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Tester = value;
		            return this;
		        }		

				
				public EngineeringChangeStatus CurrentEngineeringChangeStatus {get; set;}

				/// <exclude/>
				public EngineeringChangeBuilder WithCurrentEngineeringChangeStatus(EngineeringChangeStatus value)
		        {
		            if(this.CurrentEngineeringChangeStatus!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.CurrentEngineeringChangeStatus = value;
		            return this;
		        }		

				
				public SearchData SearchData {get; set;}

				/// <exclude/>
				public EngineeringChangeBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public EngineeringChangeBuilder WithDeniedPermission(Permission value)
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
				public EngineeringChangeBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public EngineeringChangeBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	


	}

	public partial class EngineeringChanges : global::Allors.ObjectsBase<EngineeringChange>
	{
		public static readonly EngineeringChangeMeta Meta = EngineeringChangeMeta.Instance;

		public EngineeringChanges(Allors.ISession session) : base(session)
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