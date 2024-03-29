// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class ShipmentItem
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (ShipmentItemBuilder)objectBuilder;
			

			if(builder.Quantity.HasValue)
			{
				this.Quantity = builder.Quantity.Value;
			}			
		

			this.ContentsDescription = builder.ContentsDescription;
					

			if(builder.QuantityShipped.HasValue)
			{
				this.QuantityShipped = builder.QuantityShipped.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
		

			this.Part = builder.Part;


			if(builder.Documents!=null)
			{
				this.Documents = builder.Documents.ToArray();
			}

			if(builder.InResponseToShipmentItems!=null)
			{
				this.InResponseToShipmentItems = builder.InResponseToShipmentItems.ToArray();
			}

			if(builder.InventoryItems!=null)
			{
				this.InventoryItems = builder.InventoryItems.ToArray();
			}

			if(builder.ProductFeatures!=null)
			{
				this.ProductFeatures = builder.ProductFeatures.ToArray();
			}

			if(builder.InvoiceItems!=null)
			{
				this.InvoiceItems = builder.InvoiceItems.ToArray();
			}


			this.Good = builder.Good;


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

	public partial class ShipmentItemBuilder : Allors.ObjectBuilder<ShipmentItem> , UserInterfaceableBuilder, global::System.IDisposable
	{		
		public ShipmentItemBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.Decimal? Quantity {get; set;}

				/// <exclude/>
				public ShipmentItemBuilder WithQuantity(global::System.Decimal? value)
		        {
				    if(this.Quantity!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Quantity = value;
		            return this;
		        }	

				public Part Part {get; set;}

				/// <exclude/>
				public ShipmentItemBuilder WithPart(Part value)
		        {
		            if(this.Part!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Part = value;
		            return this;
		        }		

				
				public global::System.String ContentsDescription {get; set;}

				/// <exclude/>
				public ShipmentItemBuilder WithContentsDescription(global::System.String value)
		        {
				    if(this.ContentsDescription!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ContentsDescription = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Document> Documents {get; set;}	

				/// <exclude/>
				public ShipmentItemBuilder WithDocument(Document value)
		        {
					if(this.Documents == null)
					{
						this.Documents = new global::System.Collections.Generic.List<Document>(); 
					}
		            this.Documents.Add(value);
		            return this;
		        }		

				
				public global::System.Decimal? QuantityShipped {get; set;}

				/// <exclude/>
				public ShipmentItemBuilder WithQuantityShipped(global::System.Decimal? value)
		        {
				    if(this.QuantityShipped!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.QuantityShipped = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<ShipmentItem> InResponseToShipmentItems {get; set;}	

				/// <exclude/>
				public ShipmentItemBuilder WithInResponseToShipmentItem(ShipmentItem value)
		        {
					if(this.InResponseToShipmentItems == null)
					{
						this.InResponseToShipmentItems = new global::System.Collections.Generic.List<ShipmentItem>(); 
					}
		            this.InResponseToShipmentItems.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<InventoryItem> InventoryItems {get; set;}	

				/// <exclude/>
				public ShipmentItemBuilder WithInventoryItem(InventoryItem value)
		        {
					if(this.InventoryItems == null)
					{
						this.InventoryItems = new global::System.Collections.Generic.List<InventoryItem>(); 
					}
		            this.InventoryItems.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<ProductFeature> ProductFeatures {get; set;}	

				/// <exclude/>
				public ShipmentItemBuilder WithProductFeature(ProductFeature value)
		        {
					if(this.ProductFeatures == null)
					{
						this.ProductFeatures = new global::System.Collections.Generic.List<ProductFeature>(); 
					}
		            this.ProductFeatures.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<InvoiceItem> InvoiceItems {get; set;}	

				/// <exclude/>
				public ShipmentItemBuilder WithInvoiceItem(InvoiceItem value)
		        {
					if(this.InvoiceItems == null)
					{
						this.InvoiceItems = new global::System.Collections.Generic.List<InvoiceItem>(); 
					}
		            this.InvoiceItems.Add(value);
		            return this;
		        }		

				
				public Good Good {get; set;}

				/// <exclude/>
				public ShipmentItemBuilder WithGood(Good value)
		        {
		            if(this.Good!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Good = value;
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public ShipmentItemBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public ShipmentItemBuilder WithDeniedPermission(Permission value)
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
				public ShipmentItemBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class ShipmentItems : global::Allors.ObjectsBase<ShipmentItem>
	{
		public static readonly ShipmentItemMeta Meta = ShipmentItemMeta.Instance;

		public ShipmentItems(Allors.ISession session) : base(session)
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