// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class SalesOrderObjectState
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (SalesOrderObjectStateBuilder)objectBuilder;
			

			if(builder.UniqueId.HasValue)
			{
				this.UniqueId = builder.UniqueId.Value;
			}			
		
			if(builder.DeniedPermissions!=null)
			{
				this.DeniedPermissions = builder.DeniedPermissions.ToArray();
			}

		}
	}

	public partial class SalesOrderObjectStateBuilder : Allors.ObjectBuilder<SalesOrderObjectState> , ObjectStateBuilder, global::System.IDisposable
	{		
		public SalesOrderObjectStateBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public SalesOrderObjectStateBuilder WithDeniedPermission(Permission value)
		        {
					if(this.DeniedPermissions == null)
					{
						this.DeniedPermissions = new global::System.Collections.Generic.List<Permission>(); 
					}
		            this.DeniedPermissions.Add(value);
		            return this;
		        }		

				
				public global::System.Guid? UniqueId {get; set;}

				/// <exclude/>
				public SalesOrderObjectStateBuilder WithUniqueId(global::System.Guid? value)
		        {
				    if(this.UniqueId!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UniqueId = value;
		            return this;
		        }	


	}

	public partial class SalesOrderObjectStates : global::Allors.ObjectsBase<SalesOrderObjectState>
	{
		public static readonly SalesOrderObjectStateMeta Meta = SalesOrderObjectStateMeta.Instance;

		public SalesOrderObjectStates(Allors.ISession session) : base(session)
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