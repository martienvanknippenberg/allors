// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class ClassWithoutUnitRoles : Allors.ObjectBase 
	{
		public static readonly ClassWithoutUnitRolesMeta Meta = ClassWithoutUnitRolesMeta.Instance;

		public ClassWithoutUnitRoles(Allors.IStrategy allors) : base(allors) {}

		public static ClassWithoutUnitRoles Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (ClassWithoutUnitRoles) allorsSession.Instantiate(allorsObjectId);		
		}

	}

	public class ClassWithoutUnitRolesMeta
	{
		public static readonly ClassWithoutUnitRolesMeta Instance = new ClassWithoutUnitRolesMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.ClassWithoutUnitRoles;

	}
}