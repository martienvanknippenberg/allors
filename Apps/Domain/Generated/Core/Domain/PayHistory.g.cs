// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class PayHistory : Allors.ObjectBase , UserInterfaceable, Period
	{
		public static readonly PayHistoryMeta Meta = PayHistoryMeta.Instance;

		public PayHistory(Allors.IStrategy allors) : base(allors) {}

		public static PayHistory Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (PayHistory) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public Employment Employment
		{ 
			get
			{
				return (Employment) Strategy.GetCompositeRole(Meta.Employment);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Employment ,value);
			}
		}

		virtual public bool ExistEmployment
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Employment);
			}
		}

		virtual public void RemoveEmployment()
		{
			Strategy.RemoveCompositeRole(Meta.Employment);
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


		virtual public SalaryStep SalaryStep
		{ 
			get
			{
				return (SalaryStep) Strategy.GetCompositeRole(Meta.SalaryStep);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.SalaryStep ,value);
			}
		}

		virtual public bool ExistSalaryStep
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.SalaryStep);
			}
		}

		virtual public void RemoveSalaryStep()
		{
			Strategy.RemoveCompositeRole(Meta.SalaryStep);
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



		virtual public global::System.DateTime? FromDate 
		{
			get
			{
				return (global::System.DateTime?) Strategy.GetUnitRole(Meta.FromDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.FromDate, value);
			}
		}

		virtual public bool ExistFromDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.FromDate);
			}
		}

		virtual public void RemoveFromDate()
		{
			Strategy.RemoveUnitRole(Meta.FromDate);
		}



		virtual public global::System.DateTime? ThroughDate 
		{
			get
			{
				return (global::System.DateTime?) Strategy.GetUnitRole(Meta.ThroughDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ThroughDate, value);
			}
		}

		virtual public bool ExistThroughDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.ThroughDate);
			}
		}

		virtual public void RemoveThroughDate()
		{
			Strategy.RemoveUnitRole(Meta.ThroughDate);
		}



		virtual public global::Allors.Extent<PerformanceReview> PerformanceReviewsWherePayHistory
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PerformanceReviewsWherePayHistory);
			}
		}

		virtual public bool ExistPerformanceReviewsWherePayHistory
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PerformanceReviewsWherePayHistory);
			}
		}

	}

	public class PayHistoryMeta
	{
		public static readonly PayHistoryMeta Instance = new PayHistoryMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.PayHistory;

		public global::Allors.Meta.RoleType Employment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PayHistoryEmployment;
			}
		} 
		public global::Allors.Meta.RoleType TimeFrequency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PayHistoryTimeFrequency;
			}
		} 
		public global::Allors.Meta.RoleType SalaryStep 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PayHistorySalaryStep;
			}
		} 
		public global::Allors.Meta.RoleType Amount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PayHistoryAmount;
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
		public global::Allors.Meta.RoleType FromDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PeriodFromDate;
			}
		} 
		public global::Allors.Meta.RoleType ThroughDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PeriodThroughDate;
			}
		} 

		public global::Allors.Meta.AssociationType PerformanceReviewsWherePayHistory 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PerformanceReviewPayHistory;
			}
		} 

	}
}