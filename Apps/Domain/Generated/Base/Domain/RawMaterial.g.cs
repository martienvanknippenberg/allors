// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class RawMaterial
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (RawMaterialBuilder)objectBuilder;

			this.Name = builder.Name;
		

			this.ManufacturerId = builder.ManufacturerId;
					

			if(builder.ReorderLevel.HasValue)
			{
				this.ReorderLevel = builder.ReorderLevel.Value;
			}			
					

			if(builder.ReorderQuantity.HasValue)
			{
				this.ReorderQuantity = builder.ReorderQuantity.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
					

			if(builder.UniqueId.HasValue)
			{
				this.UniqueId = builder.UniqueId.Value;
			}			
		

			this.OwnedByParty = builder.OwnedByParty;


			if(builder.PartSpecifications!=null)
			{
				this.PartSpecifications = builder.PartSpecifications.ToArray();
			}


			this.UnitOfMeasure = builder.UnitOfMeasure;


			if(builder.Documents!=null)
			{
				this.Documents = builder.Documents.ToArray();
			}

			if(builder.PriceComponents!=null)
			{
				this.PriceComponents = builder.PriceComponents.ToArray();
			}


			this.InventoryItemKind = builder.InventoryItemKind;


			if(builder.DeniedPermissions!=null)
			{
				this.DeniedPermissions = builder.DeniedPermissions.ToArray();
			}

			if(builder.SecurityTokens!=null)
			{
				this.SecurityTokens = builder.SecurityTokens.ToArray();
			}


			this.SearchData = builder.SearchData;


		}
	}

	public partial class RawMaterialBuilder : Allors.ObjectBuilder<RawMaterial> , PartBuilder, global::System.IDisposable
	{		
		public RawMaterialBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public InternalOrganisation OwnedByParty {get; set;}

				/// <exclude/>
				public RawMaterialBuilder WithOwnedByParty(InternalOrganisation value)
		        {
		            if(this.OwnedByParty!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.OwnedByParty = value;
		            return this;
		        }		

				
				public global::System.String Name {get; set;}

				/// <exclude/>
				public RawMaterialBuilder WithName(global::System.String value)
		        {
				    if(this.Name!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Name = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<PartSpecification> PartSpecifications {get; set;}	

				/// <exclude/>
				public RawMaterialBuilder WithPartSpecification(PartSpecification value)
		        {
					if(this.PartSpecifications == null)
					{
						this.PartSpecifications = new global::System.Collections.Generic.List<PartSpecification>(); 
					}
		            this.PartSpecifications.Add(value);
		            return this;
		        }		

				
				public UnitOfMeasure UnitOfMeasure {get; set;}

				/// <exclude/>
				public RawMaterialBuilder WithUnitOfMeasure(UnitOfMeasure value)
		        {
		            if(this.UnitOfMeasure!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.UnitOfMeasure = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<Document> Documents {get; set;}	

				/// <exclude/>
				public RawMaterialBuilder WithDocument(Document value)
		        {
					if(this.Documents == null)
					{
						this.Documents = new global::System.Collections.Generic.List<Document>(); 
					}
		            this.Documents.Add(value);
		            return this;
		        }		

				
				public global::System.String ManufacturerId {get; set;}

				/// <exclude/>
				public RawMaterialBuilder WithManufacturerId(global::System.String value)
		        {
				    if(this.ManufacturerId!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ManufacturerId = value;
		            return this;
		        }	

				public global::System.Int32? ReorderLevel {get; set;}

				/// <exclude/>
				public RawMaterialBuilder WithReorderLevel(global::System.Int32? value)
		        {
				    if(this.ReorderLevel!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ReorderLevel = value;
		            return this;
		        }	

				public global::System.Int32? ReorderQuantity {get; set;}

				/// <exclude/>
				public RawMaterialBuilder WithReorderQuantity(global::System.Int32? value)
		        {
				    if(this.ReorderQuantity!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ReorderQuantity = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<PriceComponent> PriceComponents {get; set;}	

				/// <exclude/>
				public RawMaterialBuilder WithPriceComponent(PriceComponent value)
		        {
					if(this.PriceComponents == null)
					{
						this.PriceComponents = new global::System.Collections.Generic.List<PriceComponent>(); 
					}
		            this.PriceComponents.Add(value);
		            return this;
		        }		

				
				public InventoryItemKind InventoryItemKind {get; set;}

				/// <exclude/>
				public RawMaterialBuilder WithInventoryItemKind(InventoryItemKind value)
		        {
		            if(this.InventoryItemKind!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.InventoryItemKind = value;
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public RawMaterialBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public RawMaterialBuilder WithDeniedPermission(Permission value)
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
				public RawMaterialBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				
				public SearchData SearchData {get; set;}

				/// <exclude/>
				public RawMaterialBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				
				public global::System.Guid? UniqueId {get; set;}

				/// <exclude/>
				public RawMaterialBuilder WithUniqueId(global::System.Guid? value)
		        {
				    if(this.UniqueId!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UniqueId = value;
		            return this;
		        }	


	}

	public partial class RawMaterials : global::Allors.ObjectsBase<RawMaterial>
	{
		public static readonly RawMaterialMeta Meta = RawMaterialMeta.Instance;

		public RawMaterials(Allors.ISession session) : base(session)
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