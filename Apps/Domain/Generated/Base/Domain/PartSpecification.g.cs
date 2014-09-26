// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface PartSpecificationBuilder : UniquelyIdentifiableBuilder ,CommentableBuilder ,TransitionalBuilder ,UserInterfaceableBuilder , global::System.IDisposable
	{	

		global::System.Collections.Generic.List<PartSpecificationStatus> PartSpecificationStatuses {get;}		

		
		PartSpecificationObjectState CurrentObjectState {get;}

		

		global::System.DateTime? DocumentationDate {get;}

		
		PartSpecificationStatus CurrentPartSpecificationStatus {get;}

		
		PartSpecificationObjectState PreviousObjectState {get;}

		

		global::System.String Description {get;}

		
	}

	public partial class PartSpecifications : global::Allors.ObjectsBase<PartSpecification>
	{
		public static readonly PartSpecificationMeta Meta = PartSpecificationMeta.Instance;

		public PartSpecifications(Allors.ISession session) : base(session)
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