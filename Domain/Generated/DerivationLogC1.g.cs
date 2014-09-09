// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
    using Allors.Meta;

    [System.Diagnostics.DebuggerNonUserCode]
	public partial class DerivationLogC1 : Allors.ObjectBase , DerivationLogI12
	{
		public static readonly DerivationLogC1Meta Meta = DerivationLogC1Meta.Instance;

		public DerivationLogC1(Allors.IStrategy allors) : base(allors) {}

		public static DerivationLogC1 Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (DerivationLogC1) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.Guid? UniqueId 
		{
			get
			{
				return (global::System.Guid?) Strategy.GetUnitRole(Meta.UniqueId);
			}
			set
			{
				Strategy.SetUnitRole(Meta.UniqueId, value);
			}
		}

		virtual public bool ExistUniqueId{
			get
			{
				return Strategy.ExistUnitRole(Meta.UniqueId);
			}
		}

		virtual public void RemoveUniqueId()
		{
			Strategy.RemoveUnitRole(Meta.UniqueId);
		}

	}

	public class DerivationLogC1Meta
	{
		public static readonly DerivationLogC1Meta Instance = new DerivationLogC1Meta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.DerivationLogC1;

		public global::Allors.Meta.RoleType UniqueId 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.DerivationLogI12UniqueId;
			}
		} 

	}


	public partial class DerivationLogC1Builder : Allors.ObjectBuilder<DerivationLogC1> , DerivationLogI12Builder, global::System.IDisposable
	{		
		public DerivationLogC1Builder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.Guid? UniqueId {get; set;}

				/// <exclude/>
				public DerivationLogC1Builder WithUniqueId(global::System.Guid? value)
		        {
				    if(this.UniqueId!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UniqueId = value;
		            return this;
		        }	


	}

	public partial class DerivationLogC1s : global::Allors.ObjectsBase<DerivationLogC1>
	{
		public static readonly DerivationLogC1Meta Meta = DerivationLogC1Meta.Instance;

		public DerivationLogC1s(Allors.ISession session) : base(session)
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