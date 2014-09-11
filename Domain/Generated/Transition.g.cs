// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class Transition : Allors.ObjectBase 
	{
		public static readonly TransitionMeta Meta = TransitionMeta.Instance;

		public Transition(Allors.IStrategy allors) : base(allors) {}

		public static Transition Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (Transition) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public global::Allors.Extent<ObjectState> FromStates
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.FromState);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.FromState, value);
			}
		}

		virtual public void AddFromState (ObjectState value)
		{
			Strategy.AddCompositeRole(Meta.FromState, value);
		}

		virtual public void RemoveFromState (ObjectState value)
		{
			Strategy.RemoveCompositeRole(Meta.FromState,value);
		}

		virtual public bool ExistFromStates
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.FromState);
			}
		}

		virtual public void RemoveFromStates()
		{
			Strategy.RemoveCompositeRoles(Meta.FromState);
		}


		virtual public ObjectState ToState
		{ 
			get
			{
				return (ObjectState) Strategy.GetCompositeRole(Meta.ToState);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.ToState ,value);
			}
		}

		virtual public bool ExistToState
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.ToState);
			}
		}

		virtual public void RemoveToState()
		{
			Strategy.RemoveCompositeRole(Meta.ToState);
		}

	}

	public class TransitionMeta
	{
		public static readonly TransitionMeta Instance = new TransitionMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.Transition;

		public global::Allors.Meta.RoleType FromState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.TransitionFromState;
			}
		} 
		public global::Allors.Meta.RoleType ToState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.TransitionToState;
			}
		} 

	}


	public partial class TransitionBuilder : Allors.ObjectBuilder<Transition> , global::System.IDisposable
	{		
		public TransitionBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.Collections.Generic.List<ObjectState> FromState {get; set;}	

				/// <exclude/>
				public TransitionBuilder WithFromState(ObjectState value)
		        {
					if(this.FromState == null)
					{
						this.FromState = new global::System.Collections.Generic.List<ObjectState>(); 
					}
		            this.FromState.Add(value);
		            return this;
		        }		

				
				public ObjectState ToState {get; set;}

				/// <exclude/>
				public TransitionBuilder WithToState(ObjectState value)
		        {
		            if(this.ToState!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.ToState = value;
		            return this;
		        }		

				

	}

	public partial class Transitions : global::Allors.ObjectsBase<Transition>
	{
		public static readonly TransitionMeta Meta = TransitionMeta.Instance;

		public Transitions(Allors.ISession session) : base(session)
		{
		}

		public override Allors.Meta.Composite ObjectType
		{
			get
			{
				return Meta.ObjectType;
			}
		}
	}

}