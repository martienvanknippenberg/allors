// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class PayGrade : Allors.ObjectBase , UserInterfaceable, Commentable
	{
		public static readonly PayGradeMeta Meta = PayGradeMeta.Instance;

		public PayGrade(Allors.IStrategy allors) : base(allors) {}

		public static PayGrade Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (PayGrade) allorsSession.Instantiate(allorsObjectId);		
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


		virtual public global::Allors.Extent<SalaryStep> SalarySteps
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.SalaryStep);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.SalaryStep, value);
			}
		}

		virtual public void AddSalaryStep (SalaryStep value)
		{
			Strategy.AddCompositeRole(Meta.SalaryStep, value);
		}

		virtual public void RemoveSalaryStep (SalaryStep value)
		{
			Strategy.RemoveCompositeRole(Meta.SalaryStep,value);
		}

		virtual public bool ExistSalarySteps
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.SalaryStep);
			}
		}

		virtual public void RemoveSalarySteps()
		{
			Strategy.RemoveCompositeRoles(Meta.SalaryStep);
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

	public class PayGradeMeta
	{
		public static readonly PayGradeMeta Instance = new PayGradeMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.PayGrade;

		public global::Allors.Meta.RoleType Name 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PayGradeName;
			}
		} 
		public global::Allors.Meta.RoleType SalaryStep 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PayGradeSalaryStep;
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