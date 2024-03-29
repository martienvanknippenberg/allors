// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class FinishedGood
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (FinishedGoodBuilder)objectBuilder;

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

	public partial class FinishedGoodBuilder : Allors.ObjectBuilder<FinishedGood> , PartBuilder, global::System.IDisposable
	{		
		public FinishedGoodBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public InternalOrganisation OwnedByParty {get; set;}

				/// <exclude/>
				public FinishedGoodBuilder WithOwnedByParty(InternalOrganisation value)
		        {
		            if(this.OwnedByParty!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.OwnedByParty = value;
		            return this;
		        }		

				
				public global::System.String Name {get; set;}

				/// <exclude/>
				public FinishedGoodBuilder WithName(global::System.String value)
		        {
				    if(this.Name!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Name = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<PartSpecification> PartSpecifications {get; set;}	

				/// <exclude/>
				public FinishedGoodBuilder WithPartSpecification(PartSpecification value)
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
				public FinishedGoodBuilder WithUnitOfMeasure(UnitOfMeasure value)
		        {
		            if(this.UnitOfMeasure!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.UnitOfMeasure = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<Document> Documents {get; set;}	

				/// <exclude/>
				public FinishedGoodBuilder WithDocument(Document value)
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
				public FinishedGoodBuilder WithManufacturerId(global::System.String value)
		        {
				    if(this.ManufacturerId!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ManufacturerId = value;
		            return this;
		        }	

				public global::System.Int32? ReorderLevel {get; set;}

				/// <exclude/>
				public FinishedGoodBuilder WithReorderLevel(global::System.Int32? value)
		        {
				    if(this.ReorderLevel!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ReorderLevel = value;
		            return this;
		        }	

				public global::System.Int32? ReorderQuantity {get; set;}

				/// <exclude/>
				public FinishedGoodBuilder WithReorderQuantity(global::System.Int32? value)
		        {
				    if(this.ReorderQuantity!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ReorderQuantity = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<PriceComponent> PriceComponents {get; set;}	

				/// <exclude/>
				public FinishedGoodBuilder WithPriceComponent(PriceComponent value)
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
				public FinishedGoodBuilder WithInventoryItemKind(InventoryItemKind value)
		        {
		            if(this.InventoryItemKind!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.InventoryItemKind = value;
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public FinishedGoodBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public FinishedGoodBuilder WithDeniedPermission(Permission value)
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
				public FinishedGoodBuilder WithSecurityToken(SecurityToken value)
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
				public FinishedGoodBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				
				public global::System.Guid? UniqueId {get; set;}

				/// <exclude/>
				public FinishedGoodBuilder WithUniqueId(global::System.Guid? value)
		        {
				    if(this.UniqueId!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UniqueId = value;
		            return this;
		        }	


	}

	public partial class FinishedGoods : global::Allors.ObjectsBase<FinishedGood>
	{
		public static readonly FinishedGoodMeta Meta = FinishedGoodMeta.Instance;

		public FinishedGoods(Allors.ISession session) : base(session)
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