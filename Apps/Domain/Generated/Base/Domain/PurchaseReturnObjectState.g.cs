// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class PurchaseReturnObjectState
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (PurchaseReturnObjectStateBuilder)objectBuilder;

			this.Name = builder.Name;
					

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

	public partial class PurchaseReturnObjectStateBuilder : Allors.ObjectBuilder<PurchaseReturnObjectState> , ObjectStateBuilder, global::System.IDisposable
	{		
		public PurchaseReturnObjectStateBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public PurchaseReturnObjectStateBuilder WithDeniedPermission(Permission value)
		        {
					if(this.DeniedPermissions == null)
					{
						this.DeniedPermissions = new global::System.Collections.Generic.List<Permission>(); 
					}
		            this.DeniedPermissions.Add(value);
		            return this;
		        }		

				
				public global::System.String Name {get; set;}

				/// <exclude/>
				public PurchaseReturnObjectStateBuilder WithName(global::System.String value)
		        {
				    if(this.Name!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Name = value;
		            return this;
		        }	

				public global::System.Guid? UniqueId {get; set;}

				/// <exclude/>
				public PurchaseReturnObjectStateBuilder WithUniqueId(global::System.Guid? value)
		        {
				    if(this.UniqueId!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UniqueId = value;
		            return this;
		        }	


	}

	public partial class PurchaseReturnObjectStates : global::Allors.ObjectsBase<PurchaseReturnObjectState>
	{
		public static readonly PurchaseReturnObjectStateMeta Meta = PurchaseReturnObjectStateMeta.Instance;

		public PurchaseReturnObjectStates(Allors.ISession session) : base(session)
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