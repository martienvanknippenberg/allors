// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class PayrollPreference : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly PayrollPreferenceMeta Meta = PayrollPreferenceMeta.Instance;

		public PayrollPreference(Allors.IStrategy allors) : base(allors) {}

		public static PayrollPreference Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (PayrollPreference) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.Decimal? Percentage 
		{
			get
			{
				return (global::System.Decimal?) Strategy.GetUnitRole(Meta.Percentage);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Percentage, value);
			}
		}

		virtual public bool ExistPercentage{
			get
			{
				return Strategy.ExistUnitRole(Meta.Percentage);
			}
		}

		virtual public void RemovePercentage()
		{
			Strategy.RemoveUnitRole(Meta.Percentage);
		}



		virtual public global::System.String AccountNumber 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.AccountNumber);
			}
			set
			{
				Strategy.SetUnitRole(Meta.AccountNumber, value);
			}
		}

		virtual public bool ExistAccountNumber{
			get
			{
				return Strategy.ExistUnitRole(Meta.AccountNumber);
			}
		}

		virtual public void RemoveAccountNumber()
		{
			Strategy.RemoveUnitRole(Meta.AccountNumber);
		}


		virtual public PaymentMethod PaymentMethod
		{ 
			get
			{
				return (PaymentMethod) Strategy.GetCompositeRole(Meta.PaymentMethod);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.PaymentMethod ,value);
			}
		}

		virtual public bool ExistPaymentMethod
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.PaymentMethod);
			}
		}

		virtual public void RemovePaymentMethod()
		{
			Strategy.RemoveCompositeRole(Meta.PaymentMethod);
		}


		virtual public TimeFrequency TimeFrequency
		{ 
			get
			{
				return (TimeFrequency) Strategy.GetCompositeRole(Meta.TimeFrequency);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.TimeFrequency ,value);
			}
		}

		virtual public bool ExistTimeFrequency
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.TimeFrequency);
			}
		}

		virtual public void RemoveTimeFrequency()
		{
			Strategy.RemoveCompositeRole(Meta.TimeFrequency);
		}


		virtual public DeductionType DeductionType
		{ 
			get
			{
				return (DeductionType) Strategy.GetCompositeRole(Meta.DeductionType);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.DeductionType ,value);
			}
		}

		virtual public bool ExistDeductionType
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.DeductionType);
			}
		}

		virtual public void RemoveDeductionType()
		{
			Strategy.RemoveCompositeRole(Meta.DeductionType);
		}



		virtual public global::System.Decimal? Amount 
		{
			get
			{
				return (global::System.Decimal?) Strategy.GetUnitRole(Meta.Amount);
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



		virtual public Employment EmploymentWherePayrollPreference
		{ 
			get
			{
				return (Employment) Strategy.GetCompositeAssociation(Meta.EmploymentWherePayrollPreference);
			}
		} 

		virtual public bool ExistEmploymentWherePayrollPreference
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.EmploymentWherePayrollPreference);
			}
		}

	}

	public class PayrollPreferenceMeta
	{
		public static readonly PayrollPreferenceMeta Instance = new PayrollPreferenceMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.PayrollPreference;

		public global::Allors.Meta.RoleType Percentage 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PayrollPreferencePercentage;
			}
		} 
		public global::Allors.Meta.RoleType AccountNumber 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PayrollPreferenceAccountNumber;
			}
		} 
		public global::Allors.Meta.RoleType PaymentMethod 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PayrollPreferencePaymentMethod;
			}
		} 
		public global::Allors.Meta.RoleType TimeFrequency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PayrollPreferenceTimeFrequency;
			}
		} 
		public global::Allors.Meta.RoleType DeductionType 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PayrollPreferenceDeductionType;
			}
		} 
		public global::Allors.Meta.RoleType Amount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PayrollPreferenceAmount;
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

		public global::Allors.Meta.AssociationType EmploymentWherePayrollPreference 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.EmploymentPayrollPreference;
			}
		} 

	}
}