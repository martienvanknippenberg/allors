// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface PrintableBuilder : UserInterfaceableBuilder ,UniquelyIdentifiableBuilder , global::System.IDisposable
	{	

		global::System.String PrintContent {get;}

		
	}

	public partial class Printables : global::Allors.ObjectsBase<Printable>
	{
		public static readonly PrintableMeta Meta = PrintableMeta.Instance;

		public Printables(Allors.ISession session) : base(session)
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