// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface InterfaceWithoutConcreteClass : Allors.IObject
	{


		global::System.Boolean? InterfaceWithoutConcreteClassAllorsBoolean 
		{
			get;
			set;
		}

		bool ExistInterfaceWithoutConcreteClassAllorsBoolean{get;}

		void RemoveInterfaceWithoutConcreteClassAllorsBoolean();

	}

	public class InterfaceWithoutConcreteClassMeta
	{
		public static readonly InterfaceWithoutConcreteClassMeta Instance = new InterfaceWithoutConcreteClassMeta();

		public global::Allors.Meta.Interface ObjectType = global::Allors.Meta.Interfaces.InterfaceWithoutConcreteClass;

		public global::Allors.Meta.RoleType InterfaceWithoutConcreteClassAllorsBoolean 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InterfaceWithoutConcreteClassAllorsBoolean;
			}
		} 

	}
}