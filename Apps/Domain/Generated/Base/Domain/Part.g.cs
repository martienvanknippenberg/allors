// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface PartBuilder : UserInterfaceableBuilder ,SearchableBuilder ,UniquelyIdentifiableBuilder ,SearchResultBuilder , global::System.IDisposable
	{	
		InternalOrganisation OwnedByParty {get;}

		

		global::System.String Name {get;}

		

		global::System.Collections.Generic.List<PartSpecification> PartSpecifications {get;}		

		
		UnitOfMeasure UnitOfMeasure {get;}

		

		global::System.Collections.Generic.List<Document> Documents {get;}		

		

		global::System.String ManufacturerId {get;}

		

		global::System.Int32? ReorderLevel {get;}

		

		global::System.Int32? ReorderQuantity {get;}

		

		global::System.Collections.Generic.List<PriceComponent> PriceComponents {get;}		

		
		InventoryItemKind InventoryItemKind {get;}

		
	}

	public partial class Parts : global::Allors.ObjectsBase<Part>
	{
		public static readonly PartMeta Meta = PartMeta.Instance;

		public Parts(Allors.ISession session) : base(session)
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