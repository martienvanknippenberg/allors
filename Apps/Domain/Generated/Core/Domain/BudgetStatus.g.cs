// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class BudgetStatus : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly BudgetStatusMeta Meta = BudgetStatusMeta.Instance;

		public BudgetStatus(Allors.IStrategy allors) : base(allors) {}

		public static BudgetStatus Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (BudgetStatus) allorsSession.Instantiate(allorsObjectId);		
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


		virtual public BudgetObjectState BudgetObjectState
		{ 
			get
			{
				return (BudgetObjectState) Strategy.GetCompositeRole(Meta.BudgetObjectState);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.BudgetObjectState ,value);
			}
		}

		virtual public bool ExistBudgetObjectState
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.BudgetObjectState);
			}
		}

		virtual public void RemoveBudgetObjectState()
		{
			Strategy.RemoveCompositeRole(Meta.BudgetObjectState);
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



		virtual public Budget BudgetWhereBudgetStatus
		{ 
			get
			{
				return (Budget) Strategy.GetCompositeAssociation(Meta.BudgetWhereBudgetStatus);
			}
		} 

		virtual public bool ExistBudgetWhereBudgetStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.BudgetWhereBudgetStatus);
			}
		}


		virtual public Budget BudgetWhereCurrentBudgetStatus
		{ 
			get
			{
				return (Budget) Strategy.GetCompositeAssociation(Meta.BudgetWhereCurrentBudgetStatus);
			}
		} 

		virtual public bool ExistBudgetWhereCurrentBudgetStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.BudgetWhereCurrentBudgetStatus);
			}
		}

	}

	public class BudgetStatusMeta
	{
		public static readonly BudgetStatusMeta Instance = new BudgetStatusMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.BudgetStatus;

		public global::Allors.Meta.RoleType StartDateTime 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BudgetStatusStartDateTime;
			}
		} 
		public global::Allors.Meta.RoleType BudgetObjectState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BudgetStatusBudgetObjectState;
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

		public global::Allors.Meta.AssociationType BudgetWhereBudgetStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.BudgetBudgetStatus;
			}
		} 
		public global::Allors.Meta.AssociationType BudgetWhereCurrentBudgetStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.BudgetCurrentBudgetStatus;
			}
		} 

	}
}