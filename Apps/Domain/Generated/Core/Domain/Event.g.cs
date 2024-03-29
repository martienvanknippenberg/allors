// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class Event : Allors.ObjectBase 
	{
		public static readonly EventMeta Meta = EventMeta.Instance;

		public Event(Allors.IStrategy allors) : base(allors) {}

		public static Event Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (Event) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.Boolean RegistrationRequired 
		{
			get
			{
				return (global::System.Boolean) Strategy.GetUnitRole(Meta.RegistrationRequired);
			}
			set
			{
				Strategy.SetUnitRole(Meta.RegistrationRequired, value);
			}
		}

		virtual public bool ExistRegistrationRequired{
			get
			{
				return Strategy.ExistUnitRole(Meta.RegistrationRequired);
			}
		}

		virtual public void RemoveRegistrationRequired()
		{
			Strategy.RemoveUnitRole(Meta.RegistrationRequired);
		}



		virtual public global::System.String Link 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Link);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Link, value);
			}
		}

		virtual public bool ExistLink{
			get
			{
				return Strategy.ExistUnitRole(Meta.Link);
			}
		}

		virtual public void RemoveLink()
		{
			Strategy.RemoveUnitRole(Meta.Link);
		}



		virtual public global::System.String Location 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Location);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Location, value);
			}
		}

		virtual public bool ExistLocation{
			get
			{
				return Strategy.ExistUnitRole(Meta.Location);
			}
		}

		virtual public void RemoveLocation()
		{
			Strategy.RemoveUnitRole(Meta.Location);
		}



		virtual public global::System.String Text 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Text);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Text, value);
			}
		}

		virtual public bool ExistText{
			get
			{
				return Strategy.ExistUnitRole(Meta.Text);
			}
		}

		virtual public void RemoveText()
		{
			Strategy.RemoveUnitRole(Meta.Text);
		}



		virtual public global::System.String AnnouncementText 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.AnnouncementText);
			}
			set
			{
				Strategy.SetUnitRole(Meta.AnnouncementText, value);
			}
		}

		virtual public bool ExistAnnouncementText{
			get
			{
				return Strategy.ExistUnitRole(Meta.AnnouncementText);
			}
		}

		virtual public void RemoveAnnouncementText()
		{
			Strategy.RemoveUnitRole(Meta.AnnouncementText);
		}



		virtual public global::System.DateTime From 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.From);
			}
			set
			{
				Strategy.SetUnitRole(Meta.From, value);
			}
		}

		virtual public bool ExistFrom{
			get
			{
				return Strategy.ExistUnitRole(Meta.From);
			}
		}

		virtual public void RemoveFrom()
		{
			Strategy.RemoveUnitRole(Meta.From);
		}


		virtual public Locale Locale
		{ 
			get
			{
				return (Locale) Strategy.GetCompositeRole(Meta.Locale);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Locale ,value);
			}
		}

		virtual public bool ExistLocale
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Locale);
			}
		}

		virtual public void RemoveLocale()
		{
			Strategy.RemoveCompositeRole(Meta.Locale);
		}



		virtual public global::System.String Title 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Title);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Title, value);
			}
		}

		virtual public bool ExistTitle{
			get
			{
				return Strategy.ExistUnitRole(Meta.Title);
			}
		}

		virtual public void RemoveTitle()
		{
			Strategy.RemoveUnitRole(Meta.Title);
		}


		virtual public Media Photo
		{ 
			get
			{
				return (Media) Strategy.GetCompositeRole(Meta.Photo);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Photo ,value);
			}
		}

		virtual public bool ExistPhoto
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Photo);
			}
		}

		virtual public void RemovePhoto()
		{
			Strategy.RemoveCompositeRole(Meta.Photo);
		}



		virtual public global::System.Boolean Announce 
		{
			get
			{
				return (global::System.Boolean) Strategy.GetUnitRole(Meta.Announce);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Announce, value);
			}
		}

		virtual public bool ExistAnnounce{
			get
			{
				return Strategy.ExistUnitRole(Meta.Announce);
			}
		}

		virtual public void RemoveAnnounce()
		{
			Strategy.RemoveUnitRole(Meta.Announce);
		}



		virtual public global::System.DateTime To 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.To);
			}
			set
			{
				Strategy.SetUnitRole(Meta.To, value);
			}
		}

		virtual public bool ExistTo{
			get
			{
				return Strategy.ExistUnitRole(Meta.To);
			}
		}

		virtual public void RemoveTo()
		{
			Strategy.RemoveUnitRole(Meta.To);
		}



		virtual public global::Allors.Extent<EventRegistration> EventRegistrationsWhereEvent
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.EventRegistrationsWhereEvent);
			}
		}

		virtual public bool ExistEventRegistrationsWhereEvent
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.EventRegistrationsWhereEvent);
			}
		}

	}

	public class EventMeta
	{
		public static readonly EventMeta Instance = new EventMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.Event;

		public global::Allors.Meta.RoleType RegistrationRequired 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EventRegistrationRequired;
			}
		} 
		public global::Allors.Meta.RoleType Link 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EventLink;
			}
		} 
		public global::Allors.Meta.RoleType Location 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EventLocation;
			}
		} 
		public global::Allors.Meta.RoleType Text 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EventText;
			}
		} 
		public global::Allors.Meta.RoleType AnnouncementText 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EventAnnouncementText;
			}
		} 
		public global::Allors.Meta.RoleType From 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EventFrom;
			}
		} 
		public global::Allors.Meta.RoleType Locale 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EventLocale;
			}
		} 
		public global::Allors.Meta.RoleType Title 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EventTitle;
			}
		} 
		public global::Allors.Meta.RoleType Photo 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EventPhoto;
			}
		} 
		public global::Allors.Meta.RoleType Announce 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EventAnnounce;
			}
		} 
		public global::Allors.Meta.RoleType To 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EventTo;
			}
		} 

		public global::Allors.Meta.AssociationType EventRegistrationsWhereEvent 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.EventRegistrationEvent;
			}
		} 

	}
}