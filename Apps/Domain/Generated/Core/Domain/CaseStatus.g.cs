// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class CaseStatus : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly CaseStatusMeta Meta = CaseStatusMeta.Instance;

		public CaseStatus(Allors.IStrategy allors) : base(allors) {}

		public static CaseStatus Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (CaseStatus) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.DateTime StartDateTime 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.StartDateTime);
			}
			set
			{
				Strategy.SetUnitRole(Meta.StartDateTime, value);
			}
		}

		virtual public bool ExistStartDateTime{
			get
			{
				return Strategy.ExistUnitRole(Meta.StartDateTime);
			}
		}

		virtual public void RemoveStartDateTime()
		{
			Strategy.RemoveUnitRole(Meta.StartDateTime);
		}


		virtual public CaseObjectState CaseObjectState
		{ 
			get
			{
				return (CaseObjectState) Strategy.GetCompositeRole(Meta.CaseObjectState);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.CaseObjectState ,value);
			}
		}

		virtual public bool ExistCaseObjectState
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.CaseObjectState);
			}
		}

		virtual public void RemoveCaseObjectState()
		{
			Strategy.RemoveCompositeRole(Meta.CaseObjectState);
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



		virtual public Case CaseWhereCurrentCaseStatus
		{ 
			get
			{
				return (Case) Strategy.GetCompositeAssociation(Meta.CaseWhereCurrentCaseStatus);
			}
		} 

		virtual public bool ExistCaseWhereCurrentCaseStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.CaseWhereCurrentCaseStatus);
			}
		}


		virtual public Case CaseWhereCaseStatus
		{ 
			get
			{
				return (Case) Strategy.GetCompositeAssociation(Meta.CaseWhereCaseStatus);
			}
		} 

		virtual public bool ExistCaseWhereCaseStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.CaseWhereCaseStatus);
			}
		}

	}

	public class CaseStatusMeta
	{
		public static readonly CaseStatusMeta Instance = new CaseStatusMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.CaseStatus;

		public global::Allors.Meta.RoleType StartDateTime 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CaseStatusStartDateTime;
			}
		} 
		public global::Allors.Meta.RoleType CaseObjectState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CaseStatusCaseObjectState;
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

		public global::Allors.Meta.AssociationType CaseWhereCurrentCaseStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CaseCurrentCaseStatus;
			}
		} 
		public global::Allors.Meta.AssociationType CaseWhereCaseStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CaseCaseStatus;
			}
		} 

	}
}