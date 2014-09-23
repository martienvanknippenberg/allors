// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface IUnitOfMeasureBuilder : UserInterfaceableBuilder ,UniquelyIdentifiableBuilder ,AccessControlledObjectBuilder ,SearchableBuilder , global::System.IDisposable
	{	

		global::System.String Description {get;}

		

		global::System.Collections.Generic.List<UnitOfMeasureConversion> UnitOfMeasureConversions {get;}		

		

		global::System.String Abbreviation {get;}

		
	}

	public partial class IUnitsOfMeasure : global::Allors.ObjectsBase<IUnitOfMeasure>
	{
		public static readonly IUnitOfMeasureMeta Meta = IUnitOfMeasureMeta.Instance;

		public IUnitsOfMeasure(Allors.ISession session) : base(session)
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