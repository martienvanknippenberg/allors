// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
    using Allors.Meta;

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


	public partial class ExtenderBuilder : Allors.ObjectBuilder<Extender> , global::System.IDisposable
	{		
		public ExtenderBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.String AllorsString {get; set;}

				/// <exclude/>
				public ExtenderBuilder WithAllorsString(global::System.String value)
		        {
				    if(this.AllorsString!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.AllorsString = value;
		            return this;
		        }	


	}

	public partial class Extenders : global::Allors.ObjectsBase<Extender>
	{
		public static readonly ExtenderMeta Meta = ExtenderMeta.Instance;

		public Extenders(Allors.ISession session) : base(session)
		{
		}

		public override Composite ObjectType
		{
			get
			{
				return Meta.ObjectType;
			}
		}
	}

}