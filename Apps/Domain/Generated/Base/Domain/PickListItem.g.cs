// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class PickListItem
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (PickListItemBuilder)objectBuilder;
			

			if(builder.RequestedQuantity.HasValue)
			{
				this.RequestedQuantity = builder.RequestedQuantity.Value;
			}			
					

			if(builder.ActualQuantity.HasValue)
			{
				this.ActualQuantity = builder.ActualQuantity.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
		

			this.InventoryItem = builder.InventoryItem;


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

	public partial class PickListItemBuilder : Allors.ObjectBuilder<PickListItem> , UserInterfaceableBuilder, global::System.IDisposable
	{		
		public PickListItemBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.Decimal? RequestedQuantity {get; set;}

				/// <exclude/>
				public PickListItemBuilder WithRequestedQuantity(global::System.Decimal? value)
		        {
				    if(this.RequestedQuantity!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.RequestedQuantity = value;
		            return this;
		        }	

				public InventoryItem InventoryItem {get; set;}

				/// <exclude/>
				public PickListItemBuilder WithInventoryItem(InventoryItem value)
		        {
		            if(this.InventoryItem!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.InventoryItem = value;
		            return this;
		        }		

				
				public global::System.Decimal? ActualQuantity {get; set;}

				/// <exclude/>
				public PickListItemBuilder WithActualQuantity(global::System.Decimal? value)
		        {
				    if(this.ActualQuantity!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ActualQuantity = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public PickListItemBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public PickListItemBuilder WithDeniedPermission(Permission value)
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
				public PickListItemBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class PickListItems : global::Allors.ObjectsBase<PickListItem>
	{
		public static readonly PickListItemMeta Meta = PickListItemMeta.Instance;

		public PickListItems(Allors.ISession session) : base(session)
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