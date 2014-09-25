// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class PerformanceNote : Allors.ObjectBase , Searchable, UserInterfaceable, Commentable, SearchResult
	{
		public static readonly PerformanceNoteMeta Meta = PerformanceNoteMeta.Instance;

		public PerformanceNote(Allors.IStrategy allors) : base(allors) {}

		public static PerformanceNote Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (PerformanceNote) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.String Description 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Description);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Description, value);
			}
		}

		virtual public bool ExistDescription{
			get
			{
				return Strategy.ExistUnitRole(Meta.Description);
			}
		}

		virtual public void RemoveDescription()
		{
			Strategy.RemoveUnitRole(Meta.Description);
		}



		virtual public global::System.DateTime CommunicationDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.CommunicationDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.CommunicationDate, value);
			}
		}

		virtual public bool ExistCommunicationDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.CommunicationDate);
			}
		}

		virtual public void RemoveCommunicationDate()
		{
			Strategy.RemoveUnitRole(Meta.CommunicationDate);
		}


		virtual public Person GivenByManager
		{ 
			get
			{
				return (Person) Strategy.GetCompositeRole(Meta.GivenByManager);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.GivenByManager ,value);
			}
		}

		virtual public bool ExistGivenByManager
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.GivenByManager);
			}
		}

		virtual public void RemoveGivenByManager()
		{
			Strategy.RemoveCompositeRole(Meta.GivenByManager);
		}


		virtual public Person Employee
		{ 
			get
			{
				return (Person) Strategy.GetCompositeRole(Meta.Employee);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Employee ,value);
			}
		}

		virtual public bool ExistEmployee
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Employee);
			}
		}

		virtual public void RemoveEmployee()
		{
			Strategy.RemoveCompositeRole(Meta.Employee);
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



		virtual public global::System.String Comment 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Comment);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Comment, value);
			}
		}

		virtual public bool ExistComment{
			get
			{
				return Strategy.ExistUnitRole(Meta.Comment);
			}
		}

		virtual public void RemoveComment()
		{
			Strategy.RemoveUnitRole(Meta.Comment);
		}

	}

	public class PerformanceNoteMeta
	{
		public static readonly PerformanceNoteMeta Instance = new PerformanceNoteMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.PerformanceNote;

		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PerformanceNoteDescription;
			}
		} 
		public global::Allors.Meta.RoleType CommunicationDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PerformanceNoteCommunicationDate;
			}
		} 
		public global::Allors.Meta.RoleType GivenByManager 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PerformanceNoteGivenByManager;
			}
		} 
		public global::Allors.Meta.RoleType Employee 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PerformanceNoteEmployee;
			}
		} 
		public global::Allors.Meta.RoleType SearchData 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SearchableSearchData;
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
		public global::Allors.Meta.RoleType Comment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommentableComment;
			}
		} 

	}
}