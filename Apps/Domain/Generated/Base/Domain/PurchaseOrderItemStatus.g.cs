// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class PurchaseOrderItemStatus
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (PurchaseOrderItemStatusBuilder)objectBuilder;
			

			if(builder.StartDateTime.HasValue)
			{
				this.StartDateTime = builder.StartDateTime.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
		

			this.PurchaseOrderItemObjectState = builder.PurchaseOrderItemObjectState;


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

	public partial class PurchaseOrderItemStatusBuilder : Allors.ObjectBuilder<PurchaseOrderItemStatus> , UserInterfaceableBuilder, global::System.IDisposable
	{		
		public PurchaseOrderItemStatusBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.DateTime? StartDateTime {get; set;}

				/// <exclude/>
				public PurchaseOrderItemStatusBuilder WithStartDateTime(global::System.DateTime? value)
		        {
				    if(this.StartDateTime!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.StartDateTime = value;
		            return this;
		        }	

				public PurchaseOrderItemObjectState PurchaseOrderItemObjectState {get; set;}

				/// <exclude/>
				public PurchaseOrderItemStatusBuilder WithPurchaseOrderItemObjectState(PurchaseOrderItemObjectState value)
		        {
		            if(this.PurchaseOrderItemObjectState!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.PurchaseOrderItemObjectState = value;
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public PurchaseOrderItemStatusBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public PurchaseOrderItemStatusBuilder WithDeniedPermission(Permission value)
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
				public PurchaseOrderItemStatusBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class PurchaseOrderItemStatuses : global::Allors.ObjectsBase<PurchaseOrderItemStatus>
	{
		public static readonly PurchaseOrderItemStatusMeta Meta = PurchaseOrderItemStatusMeta.Instance;

		public PurchaseOrderItemStatuses(Allors.ISession session) : base(session)
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