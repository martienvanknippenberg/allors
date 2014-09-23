// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class SalesOrderItemStatus
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (SalesOrderItemStatusBuilder)objectBuilder;
			

			if(builder.StartDateTime.HasValue)
			{
				this.StartDateTime = builder.StartDateTime.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
		

			this.SalesOrderItemObjectState = builder.SalesOrderItemObjectState;


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

	public partial class SalesOrderItemStatusBuilder : Allors.ObjectBuilder<SalesOrderItemStatus> , UserInterfaceableBuilder, global::System.IDisposable
	{		
		public SalesOrderItemStatusBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public SalesOrderItemObjectState SalesOrderItemObjectState {get; set;}

				/// <exclude/>
				public SalesOrderItemStatusBuilder WithSalesOrderItemObjectState(SalesOrderItemObjectState value)
		        {
		            if(this.SalesOrderItemObjectState!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SalesOrderItemObjectState = value;
		            return this;
		        }		

				
				public global::System.DateTime? StartDateTime {get; set;}

				/// <exclude/>
				public SalesOrderItemStatusBuilder WithStartDateTime(global::System.DateTime? value)
		        {
				    if(this.StartDateTime!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.StartDateTime = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public SalesOrderItemStatusBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public SalesOrderItemStatusBuilder WithDeniedPermission(Permission value)
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
				public SalesOrderItemStatusBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class SalesOrderItemStatuses : global::Allors.ObjectsBase<SalesOrderItemStatus>
	{
		public static readonly SalesOrderItemStatusMeta Meta = SalesOrderItemStatusMeta.Instance;

		public SalesOrderItemStatuses(Allors.ISession session) : base(session)
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