// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class Passport : Allors.ObjectBase , UserInterfaceable, Searchable
	{
		public static readonly PassportMeta Meta = PassportMeta.Instance;

		public Passport(Allors.IStrategy allors) : base(allors) {}

		public static Passport Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (Passport) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.DateTime? IssueDate 
		{
			get
			{
				return (global::System.DateTime?) Strategy.GetUnitRole(Meta.IssueDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.IssueDate, value);
			}
		}

		virtual public bool ExistIssueDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.IssueDate);
			}
		}

		virtual public void RemoveIssueDate()
		{
			Strategy.RemoveUnitRole(Meta.IssueDate);
		}



		virtual public global::System.DateTime? ExpiriationDate 
		{
			get
			{
				return (global::System.DateTime?) Strategy.GetUnitRole(Meta.ExpiriationDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ExpiriationDate, value);
			}
		}

		virtual public bool ExistExpiriationDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.ExpiriationDate);
			}
		}

		virtual public void RemoveExpiriationDate()
		{
			Strategy.RemoveUnitRole(Meta.ExpiriationDate);
		}



		virtual public global::System.String Number 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Number);
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



		virtual public Citizenship CitizenshipWherePassport
		{ 
			get
			{
				return (Citizenship) Strategy.GetCompositeAssociation(Meta.CitizenshipWherePassport);
			}
		} 

		virtual public bool ExistCitizenshipWherePassport
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.CitizenshipWherePassport);
			}
		}


		virtual public Person PersonWherePassport
		{ 
			get
			{
				return (Person) Strategy.GetCompositeAssociation(Meta.PersonWherePassport);
			}
		} 

		virtual public bool ExistPersonWherePassport
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.PersonWherePassport);
			}
		}

	}

	public class PassportMeta
	{
		public static readonly PassportMeta Instance = new PassportMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.Passport;

		public global::Allors.Meta.RoleType IssueDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PassportIssueDate;
			}
		} 
		public global::Allors.Meta.RoleType ExpiriationDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PassportExpiriationDate;
			}
		} 
		public global::Allors.Meta.RoleType Number 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PassportNumber;
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

		public global::Allors.Meta.AssociationType CitizenshipWherePassport 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CitizenshipPassport;
			}
		} 
		public global::Allors.Meta.AssociationType PersonWherePassport 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PersonPassport;
			}
		} 

	}
}