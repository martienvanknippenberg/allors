// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class GT32 : Allors.ObjectBase 
	{
		public static readonly GT32Meta Meta = GT32Meta.Instance;

		public GT32(Allors.IStrategy allors) : base(allors) {}

		public static GT32 Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (GT32) allorsSession.Instantiate(allorsObjectId);		
		}

	}

	public class GT32Meta
	{
		public static readonly GT32Meta Instance = new GT32Meta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.GT32;

	}
}