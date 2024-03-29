// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class Extender : Allors.ObjectBase 
	{
		public static readonly ExtenderMeta Meta = ExtenderMeta.Instance;

		public Extender(Allors.IStrategy allors) : base(allors) {}

		public static Extender Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (Extender) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.String AllorsString 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.AllorsString);
			}
			set
			{
				Strategy.SetUnitRole(Meta.AllorsString, value);
			}
		}

		virtual public bool ExistAllorsString{
			get
			{
				return Strategy.ExistUnitRole(Meta.AllorsString);
			}
		}

		virtual public void RemoveAllorsString()
		{
			Strategy.RemoveUnitRole(Meta.AllorsString);
		}

	}

	public class ExtenderMeta
	{
		public static readonly ExtenderMeta Instance = new ExtenderMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.Extender;

		public global::Allors.Meta.RoleType AllorsString 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ExtenderAllorsString;
			}
		} 

	}
}