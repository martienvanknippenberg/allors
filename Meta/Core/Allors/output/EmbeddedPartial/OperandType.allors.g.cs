// Allors generated file. 
// Do not edit this file, changes will be overwritten.

namespace Allors.Meta
{
    using Allors.Meta.AllorsGenerated;

    public abstract partial class OperandType : global::Allors.Meta.AllorsGenerated.AllorsClassOperandType, global::Allors.Meta.AllorsGenerated.AllorsInterfaceOperandType
	{		
		public OperandType(AllorsEmbeddedSession session, System.Int32 id) : base(session, id) {}

		public new static OperandType Instantiate (global::Allors.Meta.AllorsGenerated.AllorsEmbeddedSession session, System.Int32 id)
		{
			return (OperandType) session.Instantiate(id);		
		}
	}
}