// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Domain
{
	public partial class ClassWithoutRoles : ClassWithoutRolesAllors 
	{
		public ClassWithoutRoles(Allors.IStrategy allors) : base(allors) {}

		public static ClassWithoutRoles Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (ClassWithoutRoles) allorsSession.Instantiate(allorsObjectId);		
		}
	}

	[System.Diagnostics.DebuggerNonUserCode]
	public abstract class ClassWithoutRolesAllors : Allors.ObjectBase
	{
		protected ClassWithoutRolesAllors(Allors.IStrategy allors) : base(allors){}
	}

	public static class ClassWithoutRolesMeta
	{
		public static readonly global::Allors.Meta.Class ObjectType = (Allors.Meta.Class)global::Domain.M.D.Find( new System.Guid("e1008840-6d7c-4d44-b2ad-1545d23f90d8") );

	}
}