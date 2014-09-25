// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class CaseObjectState : Allors.ObjectBase , ObjectState
	{
		public static readonly CaseObjectStateMeta Meta = CaseObjectStateMeta.Instance;

		public CaseObjectState(Allors.IStrategy allors) : base(allors) {}

		public static CaseObjectState Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (CaseObjectState) allorsSession.Instantiate(allorsObjectId);		
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



		virtual public global::Allors.Extent<Case> CasesWhereCurrentObjectState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.CasesWhereCurrentObjectState);
			}
		}

		virtual public bool ExistCasesWhereCurrentObjectState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.CasesWhereCurrentObjectState);
			}
		}


		virtual public global::Allors.Extent<Case> CasesWherePreviousObjectState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.CasesWherePreviousObjectState);
			}
		}

		virtual public bool ExistCasesWherePreviousObjectState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.CasesWherePreviousObjectState);
			}
		}


		virtual public global::Allors.Extent<CaseStatus> CaseStatusesWhereCaseObjectState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.CaseStatusesWhereCaseObjectState);
			}
		}

		virtual public bool ExistCaseStatusesWhereCaseObjectState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.CaseStatusesWhereCaseObjectState);
			}
		}


		virtual public global::Allors.Extent<Transition> TransitionsWhereFromState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.TransitionsWhereFromState);
			}
		}

		virtual public bool ExistTransitionsWhereFromState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.TransitionsWhereFromState);
			}
		}


		virtual public global::Allors.Extent<Transition> TransitionsWhereToState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.TransitionsWhereToState);
			}
		}

		virtual public bool ExistTransitionsWhereToState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.TransitionsWhereToState);
			}
		}

	}

	public class CaseObjectStateMeta
	{
		public static readonly CaseObjectStateMeta Instance = new CaseObjectStateMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.CaseObjectState;

		public global::Allors.Meta.RoleType DeniedPermission 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ObjectStateDeniedPermission;
			}
		} 
		public global::Allors.Meta.RoleType Name 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ObjectStateName;
			}
		} 
		public global::Allors.Meta.RoleType UniqueId 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UniquelyIdentifiableUniqueId;
			}
		} 

		public global::Allors.Meta.AssociationType CasesWhereCurrentObjectState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CaseCurrentObjectState;
			}
		} 
		public global::Allors.Meta.AssociationType CasesWherePreviousObjectState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CasePreviousObjectState;
			}
		} 
		public global::Allors.Meta.AssociationType CaseStatusesWhereCaseObjectState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CaseStatusCaseObjectState;
			}
		} 
		public global::Allors.Meta.AssociationType TransitionsWhereFromState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.TransitionFromState;
			}
		} 
		public global::Allors.Meta.AssociationType TransitionsWhereToState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.TransitionToState;
			}
		} 

	}
}