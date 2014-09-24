// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class JournalEntryNumber : Allors.ObjectBase , UserInterfaceable, AccessControlledObject
	{
		public static readonly JournalEntryNumberMeta Meta = JournalEntryNumberMeta.Instance;

		public JournalEntryNumber(Allors.IStrategy allors) : base(allors) {}

		public static JournalEntryNumber Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (JournalEntryNumber) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public JournalType JournalType
		{ 
			get
			{
				return (JournalType) Strategy.GetCompositeRole(Meta.JournalType);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.JournalType ,value);
			}
		}

		virtual public bool ExistJournalType
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.JournalType);
			}
		}

		virtual public void RemoveJournalType()
		{
			Strategy.RemoveCompositeRole(Meta.JournalType);
		}



		virtual public global::System.Int64 Number 
		{
			get
			{
				return (global::System.Int64) Strategy.GetUnitRole(Meta.Number);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Number, value);
			}
		}

		virtual public bool ExistNumber{
			get
			{
				return Strategy.ExistUnitRole(Meta.Number);
			}
		}

		virtual public void RemoveNumber()
		{
			Strategy.RemoveUnitRole(Meta.Number);
		}



		virtual public global::System.Int32 Year 
		{
			get
			{
				return (global::System.Int32) Strategy.GetUnitRole(Meta.Year);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Year, value);
			}
		}

		virtual public bool ExistYear{
			get
			{
				return Strategy.ExistUnitRole(Meta.Year);
			}
		}

		virtual public void RemoveYear()
		{
			Strategy.RemoveUnitRole(Meta.Year);
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



		virtual public InternalOrganisation InternalOrganisationWhereJournalEntryNumber
		{ 
			get
			{
				return (InternalOrganisation) Strategy.GetCompositeAssociation(Meta.InternalOrganisationWhereJournalEntryNumber);
			}
		} 

		virtual public bool ExistInternalOrganisationWhereJournalEntryNumber
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.InternalOrganisationWhereJournalEntryNumber);
			}
		}

	}

	public class JournalEntryNumberMeta
	{
		public static readonly JournalEntryNumberMeta Instance = new JournalEntryNumberMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.JournalEntryNumber;

		public global::Allors.Meta.RoleType JournalType 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.JournalEntryNumberJournalType;
			}
		} 
		public global::Allors.Meta.RoleType Number 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.JournalEntryNumberNumber;
			}
		} 
		public global::Allors.Meta.RoleType Year 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.JournalEntryNumberYear;
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

		public global::Allors.Meta.AssociationType InternalOrganisationWhereJournalEntryNumber 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InternalOrganisationJournalEntryNumber;
			}
		} 

	}
}