// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface Transitional :  AccessControlledObject, Allors.IObject
	{
	}

	public class TransitionalMeta
	{
		public static readonly TransitionalMeta Instance = new TransitionalMeta();

		public global::Allors.Meta.Interface ObjectType = global::Allors.Meta.Interfaces.Transitional;

		public global::Allors.Meta.RoleType DeniedPermission 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AccessControlledObjectDeniedPermission;
			}
		} 
		public global::Allors.Meta.RoleType SecurityToken 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AccessControlledObjectSecurityToken;
			}
		} 

	}
}