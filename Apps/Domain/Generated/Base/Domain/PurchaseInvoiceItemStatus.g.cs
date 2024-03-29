// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class PurchaseInvoiceItemStatus
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (PurchaseInvoiceItemStatusBuilder)objectBuilder;
			

			if(builder.StartDateTime.HasValue)
			{
				this.StartDateTime = builder.StartDateTime.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
		

			this.PurchaseInvoiceItemObjectState = builder.PurchaseInvoiceItemObjectState;


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

	public partial class PurchaseInvoiceItemStatusBuilder : Allors.ObjectBuilder<PurchaseInvoiceItemStatus> , UserInterfaceableBuilder, global::System.IDisposable
	{		
		public PurchaseInvoiceItemStatusBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public PurchaseInvoiceItemObjectState PurchaseInvoiceItemObjectState {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemStatusBuilder WithPurchaseInvoiceItemObjectState(PurchaseInvoiceItemObjectState value)
		        {
		            if(this.PurchaseInvoiceItemObjectState!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.PurchaseInvoiceItemObjectState = value;
		            return this;
		        }		

				
				public global::System.DateTime? StartDateTime {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemStatusBuilder WithStartDateTime(global::System.DateTime? value)
		        {
				    if(this.StartDateTime!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.StartDateTime = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public PurchaseInvoiceItemStatusBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public PurchaseInvoiceItemStatusBuilder WithDeniedPermission(Permission value)
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
				public PurchaseInvoiceItemStatusBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class PurchaseInvoiceItemStatuses : global::Allors.ObjectsBase<PurchaseInvoiceItemStatus>
	{
		public static readonly PurchaseInvoiceItemStatusMeta Meta = PurchaseInvoiceItemStatusMeta.Instance;

		public PurchaseInvoiceItemStatuses(Allors.ISession session) : base(session)
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