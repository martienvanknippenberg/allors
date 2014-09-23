// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class PurchaseShipmentStatus
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (PurchaseShipmentStatusBuilder)objectBuilder;
			

			if(builder.StartDateTime.HasValue)
			{
				this.StartDateTime = builder.StartDateTime.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
		

			this.PurchaseShipmentObjectState = builder.PurchaseShipmentObjectState;


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

	public partial class PurchaseShipmentStatusBuilder : Allors.ObjectBuilder<PurchaseShipmentStatus> , UserInterfaceableBuilder, global::System.IDisposable
	{		
		public PurchaseShipmentStatusBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public PurchaseShipmentObjectState PurchaseShipmentObjectState {get; set;}

				/// <exclude/>
				public PurchaseShipmentStatusBuilder WithPurchaseShipmentObjectState(PurchaseShipmentObjectState value)
		        {
		            if(this.PurchaseShipmentObjectState!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.PurchaseShipmentObjectState = value;
		            return this;
		        }		

				
				public global::System.DateTime? StartDateTime {get; set;}

				/// <exclude/>
				public PurchaseShipmentStatusBuilder WithStartDateTime(global::System.DateTime? value)
		        {
				    if(this.StartDateTime!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.StartDateTime = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public PurchaseShipmentStatusBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public PurchaseShipmentStatusBuilder WithDeniedPermission(Permission value)
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
				public PurchaseShipmentStatusBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class PurchaseShipmentStatuses : global::Allors.ObjectsBase<PurchaseShipmentStatus>
	{
		public static readonly PurchaseShipmentStatusMeta Meta = PurchaseShipmentStatusMeta.Instance;

		public PurchaseShipmentStatuses(Allors.ISession session) : base(session)
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