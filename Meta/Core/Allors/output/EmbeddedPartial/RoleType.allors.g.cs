// Allors generated file. 
// Do not edit this file, changes will be overwritten.

namespace Allors.Meta
{
    using Allors.Meta.AllorsGenerated;

    public  partial class RoleType : global::Allors.Meta.AllorsGenerated.AllorsClassRoleType, global::Allors.Meta.AllorsGenerated.AllorsInterfaceRoleType
	{		
		public RoleType(AllorsEmbeddedSession session, System.Int32 id) : base(session, id) {}

		public new static RoleType Instantiate (global::Allors.Meta.AllorsGenerated.AllorsEmbeddedSession session, System.Int32 id)
		{
			return (RoleType) session.Instantiate(id);		
		}
	}
}