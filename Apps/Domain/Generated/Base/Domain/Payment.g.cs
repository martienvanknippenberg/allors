// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface PaymentBuilder : UserInterfaceableBuilder ,SearchResultBuilder ,SearchableBuilder ,CommentableBuilder ,UniquelyIdentifiableBuilder , global::System.IDisposable
	{	

		global::System.Decimal? Amount {get;}

		
		PaymentMethod PaymentMethod {get;}

		

		global::System.DateTime? EffectiveDate {get;}

		
		Party SendingParty {get;}

		

		global::System.Collections.Generic.List<PaymentApplication> PaymentApplications {get;}		

		

		global::System.String ReferenceNumber {get;}

		
		Party ReceivingParty {get;}

		
	}

	public partial class Payments : global::Allors.ObjectsBase<Payment>
	{
		public static readonly PaymentMeta Meta = PaymentMeta.Instance;

		public Payments(Allors.ISession session) : base(session)
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