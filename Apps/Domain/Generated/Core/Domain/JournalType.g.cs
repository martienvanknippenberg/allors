// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class JournalType : Allors.ObjectBase , Enumeration
	{
		public static readonly JournalTypeMeta Meta = JournalTypeMeta.Instance;

		public JournalType(Allors.IStrategy allors) : base(allors) {}

		public static JournalType Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (JournalType) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public global::Allors.Extent<LocalisedText> LocalisedNames
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.LocalisedName);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.LocalisedName, value);
			}
		}

		virtual public void AddLocalisedName (LocalisedText value)
		{
			Strategy.AddCompositeRole(Meta.LocalisedName, value);
		}

		virtual public void RemoveLocalisedName (LocalisedText value)
		{
			Strategy.RemoveCompositeRole(Meta.LocalisedName,value);
		}

		virtual public bool ExistLocalisedNames
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.LocalisedName);
			}
		}

		virtual public void RemoveLocalisedNames()
		{
			Strategy.RemoveCompositeRoles(Meta.LocalisedName);
		}



		virtual public global::System.Boolean IsActive 
		{
			get
			{
				return (global::System.Boolean) Strategy.GetUnitRole(Meta.IsActive);
			}
			set
			{
				Strategy.SetUnitRole(Meta.IsActive, value);
			}
		}

		virtual public bool ExistIsActive{
			get
			{
				return Strategy.ExistUnitRole(Meta.IsActive);
			}
		}

		virtual public void RemoveIsActive()
		{
			Strategy.RemoveUnitRole(Meta.IsActive);
		}



		virtual public global::System.String Name 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Name);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Name, value);
			}
		}

		virtual public bool ExistName{
			get
			{
				return Strategy.ExistUnitRole(Meta.Name);
			}
		}

		virtual public void RemoveName()
		{
			Strategy.RemoveUnitRole(Meta.Name);
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



		virtual public global::System.Guid UniqueId 
		{
			get
			{
				return (global::System.Guid) Strategy.GetUnitRole(Meta.UniqueId);
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



		virtual public global::Allors.Extent<JournalEntryNumber> JournalEntryNumbersWhereJournalType
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.JournalEntryNumbersWhereJournalType);
			}
		}

		virtual public bool ExistJournalEntryNumbersWhereJournalType
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.JournalEntryNumbersWhereJournalType);
			}
		}


		virtual public global::Allors.Extent<Journal> JournalsWhereJournalType
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.JournalsWhereJournalType);
			}
		}

		virtual public bool ExistJournalsWhereJournalType
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.JournalsWhereJournalType);
			}
		}


		virtual public global::Allors.Extent<Journal> JournalsWherePreviousJournalType
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.JournalsWherePreviousJournalType);
			}
		}

		virtual public bool ExistJournalsWherePreviousJournalType
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.JournalsWherePreviousJournalType);
			}
		}

	}

	public class JournalTypeMeta
	{
		public static readonly JournalTypeMeta Instance = new JournalTypeMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.JournalType;

		public global::Allors.Meta.RoleType LocalisedName 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EnumerationLocalisedName;
			}
		} 
		public global::Allors.Meta.RoleType IsActive 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EnumerationIsActive;
			}
		} 
		public global::Allors.Meta.RoleType Name 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EnumerationName;
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
		public global::Allors.Meta.RoleType UniqueId 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UniquelyIdentifiableUniqueId;
			}
		} 

		public global::Allors.Meta.AssociationType JournalEntryNumbersWhereJournalType 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.JournalEntryNumberJournalType;
			}
		} 
		public global::Allors.Meta.AssociationType JournalsWhereJournalType 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.JournalJournalType;
			}
		} 
		public global::Allors.Meta.AssociationType JournalsWherePreviousJournalType 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.JournalPreviousJournalType;
			}
		} 

	}
}