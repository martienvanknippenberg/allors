// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class UserGroup : Allors.ObjectBase , UniquelyIdentifiable, UserInterfaceable, Searchable
	{
		public static readonly UserGroupMeta Meta = UserGroupMeta.Instance;

		public UserGroup(Allors.IStrategy allors) : base(allors) {}

		public static UserGroup Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (UserGroup) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public Role Role
		{ 
			get
			{
				return (Role) Strategy.GetCompositeRole(Meta.Role);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Role ,value);
			}
		}

		virtual public bool ExistRole
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Role);
			}
		}

		virtual public void RemoveRole()
		{
			Strategy.RemoveCompositeRole(Meta.Role);
		}


		virtual public global::Allors.Extent<User> Members
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.Member);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.Member, value);
			}
		}

		virtual public void AddMember (User value)
		{
			Strategy.AddCompositeRole(Meta.Member, value);
		}

		virtual public void RemoveMember (User value)
		{
			Strategy.RemoveCompositeRole(Meta.Member,value);
		}

		virtual public bool ExistMembers
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.Member);
			}
		}

		virtual public void RemoveMembers()
		{
			Strategy.RemoveCompositeRoles(Meta.Member);
		}


		virtual public UserGroup Parent
		{ 
			get
			{
				return (UserGroup) Strategy.GetCompositeRole(Meta.Parent);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Parent ,value);
			}
		}

		virtual public bool ExistParent
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Parent);
			}
		}

		virtual public void RemoveParent()
		{
			Strategy.RemoveCompositeRole(Meta.Parent);
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


		virtual public Party Party
		{ 
			get
			{
				return (Party) Strategy.GetCompositeRole(Meta.Party);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Party ,value);
			}
		}

		virtual public bool ExistParty
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Party);
			}
		}

		virtual public void RemoveParty()
		{
			Strategy.RemoveCompositeRole(Meta.Party);
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


		virtual public SearchData SearchData
		{ 
			get
			{
				return (SearchData) Strategy.GetCompositeRole(Meta.SearchData);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.SearchData ,value);
			}
		}

		virtual public bool ExistSearchData
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.SearchData);
			}
		}

		virtual public void RemoveSearchData()
		{
			Strategy.RemoveCompositeRole(Meta.SearchData);
		}



		virtual public global::Allors.Extent<UserGroup> UserGroupsWhereParent
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.UserGroupsWhereParent);
			}
		}

		virtual public bool ExistUserGroupsWhereParent
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.UserGroupsWhereParent);
			}
		}


		virtual public global::Allors.Extent<AccessControl> AccessControlsWhereSubjectGroup
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.AccessControlsWhereSubjectGroup);
			}
		}

		virtual public bool ExistAccessControlsWhereSubjectGroup
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.AccessControlsWhereSubjectGroup);
			}
		}


		virtual public Organisation OrganisationWhereCustomerContactUserGroup
		{ 
			get
			{
				return (Organisation) Strategy.GetCompositeAssociation(Meta.OrganisationWhereCustomerContactUserGroup);
			}
		} 

		virtual public bool ExistOrganisationWhereCustomerContactUserGroup
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.OrganisationWhereCustomerContactUserGroup);
			}
		}


		virtual public Organisation OrganisationWherePartnerContactUserGroup
		{ 
			get
			{
				return (Organisation) Strategy.GetCompositeAssociation(Meta.OrganisationWherePartnerContactUserGroup);
			}
		} 

		virtual public bool ExistOrganisationWherePartnerContactUserGroup
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.OrganisationWherePartnerContactUserGroup);
			}
		}


		virtual public Organisation OrganisationWhereSupplierContactUserGroup
		{ 
			get
			{
				return (Organisation) Strategy.GetCompositeAssociation(Meta.OrganisationWhereSupplierContactUserGroup);
			}
		} 

		virtual public bool ExistOrganisationWhereSupplierContactUserGroup
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.OrganisationWhereSupplierContactUserGroup);
			}
		}

	}

	public class UserGroupMeta
	{
		public static readonly UserGroupMeta Instance = new UserGroupMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.UserGroup;

		public global::Allors.Meta.RoleType Role 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UserGroupRole;
			}
		} 
		public global::Allors.Meta.RoleType Member 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UserGroupMember;
			}
		} 
		public global::Allors.Meta.RoleType Parent 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UserGroupParent;
			}
		} 
		public global::Allors.Meta.RoleType Name 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UserGroupName;
			}
		} 
		public global::Allors.Meta.RoleType Party 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UserGroupParty;
			}
		} 
		public global::Allors.Meta.RoleType UniqueId 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UniquelyIdentifiableUniqueId;
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
		public global::Allors.Meta.RoleType SearchData 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SearchableSearchData;
			}
		} 

		public global::Allors.Meta.AssociationType UserGroupsWhereParent 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.UserGroupParent;
			}
		} 
		public global::Allors.Meta.AssociationType AccessControlsWhereSubjectGroup 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.AccessControlSubjectGroup;
			}
		} 
		public global::Allors.Meta.AssociationType OrganisationWhereCustomerContactUserGroup 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.OrganisationCustomerContactUserGroup;
			}
		} 
		public global::Allors.Meta.AssociationType OrganisationWherePartnerContactUserGroup 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.OrganisationPartnerContactUserGroup;
			}
		} 
		public global::Allors.Meta.AssociationType OrganisationWhereSupplierContactUserGroup 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.OrganisationSupplierContactUserGroup;
			}
		} 

	}
}