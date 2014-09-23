// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class EventRegistration : Allors.ObjectBase 
	{
		public static readonly EventRegistrationMeta Meta = EventRegistrationMeta.Instance;

		public EventRegistration(Allors.IStrategy allors) : base(allors) {}

		public static EventRegistration Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (EventRegistration) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public Person Person
		{ 
			get
			{
				return (Person) Strategy.GetCompositeRole(Meta.Person);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Person ,value);
			}
		}

		virtual public bool ExistPerson
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Person);
			}
		}

		virtual public void RemovePerson()
		{
			Strategy.RemoveCompositeRole(Meta.Person);
		}


		virtual public Event Event
		{ 
			get
			{
				return (Event) Strategy.GetCompositeRole(Meta.Event);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Event ,value);
			}
		}

		virtual public bool ExistEvent
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Event);
			}
		}

		virtual public void RemoveEvent()
		{
			Strategy.RemoveCompositeRole(Meta.Event);
		}



		virtual public global::System.DateTime? AllorsDateTime 
		{
			get
			{
				return (global::System.DateTime?) Strategy.GetUnitRole(Meta.AllorsDateTime);
			}
			set
			{
				Strategy.SetUnitRole(Meta.AllorsDateTime, value);
			}
		}

		virtual public bool ExistAllorsDateTime{
			get
			{
				return Strategy.ExistUnitRole(Meta.AllorsDateTime);
			}
		}

		virtual public void RemoveAllorsDateTime()
		{
			Strategy.RemoveUnitRole(Meta.AllorsDateTime);
		}

	}

	public class EventRegistrationMeta
	{
		public static readonly EventRegistrationMeta Instance = new EventRegistrationMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.EventRegistration;

		public global::Allors.Meta.RoleType Person 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EventRegistrationPerson;
			}
		} 
		public global::Allors.Meta.RoleType Event 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EventRegistrationEvent;
			}
		} 
		public global::Allors.Meta.RoleType AllorsDateTime 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EventRegistrationAllorsDateTime;
			}
		} 

	}
}