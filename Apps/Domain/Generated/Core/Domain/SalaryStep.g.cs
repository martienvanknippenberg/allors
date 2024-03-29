// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class SalaryStep : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly SalaryStepMeta Meta = SalaryStepMeta.Instance;

		public SalaryStep(Allors.IStrategy allors) : base(allors) {}

		public static SalaryStep Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (SalaryStep) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.DateTime ModifiedDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.ModifiedDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ModifiedDate, value);
			}
		}

		virtual public bool ExistModifiedDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.ModifiedDate);
			}
		}

		virtual public void RemoveModifiedDate()
		{
			Strategy.RemoveUnitRole(Meta.ModifiedDate);
		}



		virtual public global::System.Decimal Amount 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.Amount);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Amount, value);
			}
		}

		virtual public bool ExistAmount{
			get
			{
				return Strategy.ExistUnitRole(Meta.Amount);
			}
		}

		virtual public void RemoveAmount()
		{
			Strategy.RemoveUnitRole(Meta.Amount);
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



		virtual public PayGrade PayGradeWhereSalaryStep
		{ 
			get
			{
				return (PayGrade) Strategy.GetCompositeAssociation(Meta.PayGradeWhereSalaryStep);
			}
		} 

		virtual public bool ExistPayGradeWhereSalaryStep
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.PayGradeWhereSalaryStep);
			}
		}


		virtual public global::Allors.Extent<PayHistory> PayHistoriesWhereSalaryStep
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PayHistoriesWhereSalaryStep);
			}
		}

		virtual public bool ExistPayHistoriesWhereSalaryStep
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PayHistoriesWhereSalaryStep);
			}
		}

	}

	public class SalaryStepMeta
	{
		public static readonly SalaryStepMeta Instance = new SalaryStepMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.SalaryStep;

		public global::Allors.Meta.RoleType ModifiedDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SalaryStepModifiedDate;
			}
		} 
		public global::Allors.Meta.RoleType Amount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SalaryStepAmount;
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

		public global::Allors.Meta.AssociationType PayGradeWhereSalaryStep 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PayGradeSalaryStep;
			}
		} 
		public global::Allors.Meta.AssociationType PayHistoriesWhereSalaryStep 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PayHistorySalaryStep;
			}
		} 

	}
}