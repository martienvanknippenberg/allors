// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class Singleton : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly SingletonMeta Meta = SingletonMeta.Instance;

		public Singleton(Allors.IStrategy allors) : base(allors) {}

		public static Singleton Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (Singleton) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public SecurityToken AdministratorSecurityToken
		{ 
			get
			{
				return (SecurityToken) Strategy.GetCompositeRole(Meta.AdministratorSecurityToken);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.AdministratorSecurityToken ,value);
			}
		}

		virtual public bool ExistAdministratorSecurityToken
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.AdministratorSecurityToken);
			}
		}

		virtual public void RemoveAdministratorSecurityToken()
		{
			Strategy.RemoveCompositeRole(Meta.AdministratorSecurityToken);
		}


		virtual public User Guest
		{ 
			get
			{
				return (User) Strategy.GetCompositeRole(Meta.Guest);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Guest ,value);
			}
		}

		virtual public bool ExistGuest
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Guest);
			}
		}

		virtual public void RemoveGuest()
		{
			Strategy.RemoveCompositeRole(Meta.Guest);
		}


		virtual public SecurityToken DefaultSecurityToken
		{ 
			get
			{
				return (SecurityToken) Strategy.GetCompositeRole(Meta.DefaultSecurityToken);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.DefaultSecurityToken ,value);
			}
		}

		virtual public bool ExistDefaultSecurityToken
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.DefaultSecurityToken);
			}
		}

		virtual public void RemoveDefaultSecurityToken()
		{
			Strategy.RemoveCompositeRole(Meta.DefaultSecurityToken);
		}


		virtual public PrintQueue DefaultPrintQueue
		{ 
			get
			{
				return (PrintQueue) Strategy.GetCompositeRole(Meta.DefaultPrintQueue);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.DefaultPrintQueue ,value);
			}
		}

		virtual public bool ExistDefaultPrintQueue
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.DefaultPrintQueue);
			}
		}

		virtual public void RemoveDefaultPrintQueue()
		{
			Strategy.RemoveCompositeRole(Meta.DefaultPrintQueue);
		}


		virtual public Locale DefaultLocale
		{ 
			get
			{
				return (Locale) Strategy.GetCompositeRole(Meta.DefaultLocale);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.DefaultLocale ,value);
			}
		}

		virtual public bool ExistDefaultLocale
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.DefaultLocale);
			}
		}

		virtual public void RemoveDefaultLocale()
		{
			Strategy.RemoveCompositeRole(Meta.DefaultLocale);
		}


		virtual public global::Allors.Extent<Locale> Locales
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.Locale);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.Locale, value);
			}
		}

		virtual public void AddLocale (Locale value)
		{
			Strategy.AddCompositeRole(Meta.Locale, value);
		}

		virtual public void RemoveLocale (Locale value)
		{
			Strategy.RemoveCompositeRole(Meta.Locale,value);
		}

		virtual public bool ExistLocales
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.Locale);
			}
		}

		virtual public void RemoveLocales()
		{
			Strategy.RemoveCompositeRoles(Meta.Locale);
		}


		virtual public StringTemplate PersonTemplate
		{ 
			get
			{
				return (StringTemplate) Strategy.GetCompositeRole(Meta.PersonTemplate);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.PersonTemplate ,value);
			}
		}

		virtual public bool ExistPersonTemplate
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.PersonTemplate);
			}
		}

		virtual public void RemovePersonTemplate()
		{
			Strategy.RemoveCompositeRole(Meta.PersonTemplate);
		}



		virtual public global::System.String DisplayName 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.DisplayName);
			}
			set
			{
				Strategy.SetUnitRole(Meta.DisplayName, value);
			}
		}

		virtual public bool ExistDisplayName{
			get
			{
				return Strategy.ExistUnitRole(Meta.DisplayName);
			}
		}

		virtual public void RemoveDisplayName()
		{
			Strategy.RemoveUnitRole(Meta.DisplayName);
		}


		virtual public global::Allors.Extent<Permission> DeniedPermissions
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.DeniedPermission);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.DeniedPermission, value);
			}
		}

		virtual public void AddDeniedPermission (Permission value)
		{
			Strategy.AddCompositeRole(Meta.DeniedPermission, value);
		}

		virtual public void RemoveDeniedPermission (Permission value)
		{
			Strategy.RemoveCompositeRole(Meta.DeniedPermission,value);
		}

		virtual public bool ExistDeniedPermissions
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.DeniedPermission);
			}
		}

		virtual public void RemoveDeniedPermissions()
		{
			Strategy.RemoveCompositeRoles(Meta.DeniedPermission);
		}


		virtual public global::Allors.Extent<SecurityToken> SecurityTokens
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.SecurityToken);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.SecurityToken, value);
			}
		}

		virtual public void AddSecurityToken (SecurityToken value)
		{
			Strategy.AddCompositeRole(Meta.SecurityToken, value);
		}

		virtual public void RemoveSecurityToken (SecurityToken value)
		{
			Strategy.RemoveCompositeRole(Meta.SecurityToken,value);
		}

		virtual public bool ExistSecurityTokens
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.SecurityToken);
			}
		}

		virtual public void RemoveSecurityTokens()
		{
			Strategy.RemoveCompositeRoles(Meta.SecurityToken);
		}

	}

	public class SingletonMeta
	{
		public static readonly SingletonMeta Instance = new SingletonMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.Singleton;

		public global::Allors.Meta.RoleType AdministratorSecurityToken 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SingletonAdministratorSecurityToken;
			}
		} 
		public global::Allors.Meta.RoleType Guest 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SingletonGuest;
			}
		} 
		public global::Allors.Meta.RoleType DefaultSecurityToken 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SingletonDefaultSecurityToken;
			}
		} 
		public global::Allors.Meta.RoleType DefaultPrintQueue 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SingletonDefaultPrintQueue;
			}
		} 
		public global::Allors.Meta.RoleType DefaultLocale 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SingletonDefaultLocale;
			}
		} 
		public global::Allors.Meta.RoleType Locale 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SingletonLocale;
			}
		} 
		public global::Allors.Meta.RoleType PersonTemplate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SingletonPersonTemplate;
			}
		} 
		public global::Allors.Meta.RoleType DisplayName 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UserInterfaceableDisplayName;
			}
		} 
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