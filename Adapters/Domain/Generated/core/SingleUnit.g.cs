// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class SingleUnit : Allors.ObjectBase 
	{
		public static readonly SingleUnitMeta Meta = SingleUnitMeta.Instance;

		public SingleUnit(Allors.IStrategy allors) : base(allors) {}

		public static SingleUnit Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (SingleUnit) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.Int32 AllorsInteger 
		{
			get
			{
				return (global::System.Int32) Strategy.GetUnitRole(Meta.AllorsInteger);
			}
			set
			{
				Strategy.SetUnitRole(Meta.AllorsInteger, value);
			}
		}

		virtual public bool ExistAllorsInteger{
			get
			{
				return Strategy.ExistUnitRole(Meta.AllorsInteger);
			}
		}

		virtual public void RemoveAllorsInteger()
		{
			Strategy.RemoveUnitRole(Meta.AllorsInteger);
		}

	}

	public class SingleUnitMeta
	{
		public static readonly SingleUnitMeta Instance = new SingleUnitMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.SingleUnit;

		public global::Allors.Meta.IRoleType AllorsInteger 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SingleUnitAllorsInteger;
			}
		} 

	}
}