// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class PurchaseInvoiceStatus
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (PurchaseInvoiceStatusBuilder)objectBuilder;
			

			if(builder.StartDateTime.HasValue)
			{
				this.StartDateTime = builder.StartDateTime.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
		

			this.PurchaseInvoiceObjectState = builder.PurchaseInvoiceObjectState;


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

	public partial class PurchaseInvoiceStatusBuilder : Allors.ObjectBuilder<PurchaseInvoiceStatus> , UserInterfaceableBuilder, global::System.IDisposable
	{		
		public PurchaseInvoiceStatusBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.DateTime? StartDateTime {get; set;}

				/// <exclude/>
				public PurchaseInvoiceStatusBuilder WithStartDateTime(global::System.DateTime? value)
		        {
				    if(this.StartDateTime!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.StartDateTime = value;
		            return this;
		        }	

				public PurchaseInvoiceObjectState PurchaseInvoiceObjectState {get; set;}

				/// <exclude/>
				public PurchaseInvoiceStatusBuilder WithPurchaseInvoiceObjectState(PurchaseInvoiceObjectState value)
		        {
		            if(this.PurchaseInvoiceObjectState!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.PurchaseInvoiceObjectState = value;
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public PurchaseInvoiceStatusBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public PurchaseInvoiceStatusBuilder WithDeniedPermission(Permission value)
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
				public PurchaseInvoiceStatusBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class PurchaseInvoiceStatuses : global::Allors.ObjectsBase<PurchaseInvoiceStatus>
	{
		public static readonly PurchaseInvoiceStatusMeta Meta = PurchaseInvoiceStatusMeta.Instance;

		public PurchaseInvoiceStatuses(Allors.ISession session) : base(session)
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