// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class PayCheck : Allors.ObjectBase , Payment
	{
		public static readonly PayCheckMeta Meta = PayCheckMeta.Instance;

		public PayCheck(Allors.IStrategy allors) : base(allors) {}

		public static PayCheck Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (PayCheck) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public global::Allors.Extent<Deduction> Deductions
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.Deduction);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.Deduction, value);
			}
		}

		virtual public void AddDeduction (Deduction value)
		{
			Strategy.AddCompositeRole(Meta.Deduction, value);
		}

		virtual public void RemoveDeduction (Deduction value)
		{
			Strategy.RemoveCompositeRole(Meta.Deduction,value);
		}

		virtual public bool ExistDeductions
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.Deduction);
			}
		}

		virtual public void RemoveDeductions()
		{
			Strategy.RemoveCompositeRoles(Meta.Deduction);
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



		virtual public global::System.DateTime EffectiveDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.EffectiveDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.EffectiveDate, value);
			}
		}

		virtual public bool ExistEffectiveDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.EffectiveDate);
			}
		}

		virtual public void RemoveEffectiveDate()
		{
			Strategy.RemoveUnitRole(Meta.EffectiveDate);
		}


		virtual public Party SendingParty
		{ 
			get
			{
				return (Party) Strategy.GetCompositeRole(Meta.SendingParty);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.SendingParty ,value);
			}
		}

		virtual public bool ExistSendingParty
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.SendingParty);
			}
		}

		virtual public void RemoveSendingParty()
		{
			Strategy.RemoveCompositeRole(Meta.SendingParty);
		}


		virtual public global::Allors.Extent<PaymentApplication> PaymentApplications
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.PaymentApplication);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.PaymentApplication, value);
			}
		}

		virtual public void AddPaymentApplication (PaymentApplication value)
		{
			Strategy.AddCompositeRole(Meta.PaymentApplication, value);
		}

		virtual public void RemovePaymentApplication (PaymentApplication value)
		{
			Strategy.RemoveCompositeRole(Meta.PaymentApplication,value);
		}

		virtual public bool ExistPaymentApplications
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.PaymentApplication);
			}
		}

		virtual public void RemovePaymentApplications()
		{
			Strategy.RemoveCompositeRoles(Meta.PaymentApplication);
		}



		virtual public global::System.String ReferenceNumber 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.ReferenceNumber);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ReferenceNumber, value);
			}
		}

		virtual public bool ExistReferenceNumber{
			get
			{
				return Strategy.ExistUnitRole(Meta.ReferenceNumber);
			}
		}

		virtual public void RemoveReferenceNumber()
		{
			Strategy.RemoveUnitRole(Meta.ReferenceNumber);
		}


		virtual public Party ReceivingParty
		{ 
			get
			{
				return (Party) Strategy.GetCompositeRole(Meta.ReceivingParty);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.ReceivingParty ,value);
			}
		}

		virtual public bool ExistReceivingParty
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.ReceivingParty);
			}
		}

		virtual public void RemoveReceivingParty()
		{
			Strategy.RemoveCompositeRole(Meta.ReceivingParty);
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



		virtual public global::Allors.Extent<PerformanceReview> PerformanceReviewsWhereBonusPayCheck
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PerformanceReviewsWhereBonusPayCheck);
			}
		}

		virtual public bool ExistPerformanceReviewsWhereBonusPayCheck
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PerformanceReviewsWhereBonusPayCheck);
			}
		}


		virtual public global::Allors.Extent<PaymentBudgetAllocation> PaymentBudgetAllocationsWherePayment
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PaymentBudgetAllocationsWherePayment);
			}
		}

		virtual public bool ExistPaymentBudgetAllocationsWherePayment
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PaymentBudgetAllocationsWherePayment);
			}
		}

	}

	public class PayCheckMeta
	{
		public static readonly PayCheckMeta Instance = new PayCheckMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.PayCheck;

		public global::Allors.Meta.RoleType Deduction 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PayCheckDeduction;
			}
		} 
		public global::Allors.Meta.RoleType Employment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PayCheckEmployment;
			}
		} 
		public global::Allors.Meta.RoleType Amount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PaymentAmount;
			}
		} 
		public global::Allors.Meta.RoleType PaymentMethod 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PaymentPaymentMethod;
			}
		} 
		public global::Allors.Meta.RoleType EffectiveDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PaymentEffectiveDate;
			}
		} 
		public global::Allors.Meta.RoleType SendingParty 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PaymentSendingParty;
			}
		} 
		public global::Allors.Meta.RoleType PaymentApplication 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PaymentPaymentApplication;
			}
		} 
		public global::Allors.Meta.RoleType ReferenceNumber 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PaymentReferenceNumber;
			}
		} 
		public global::Allors.Meta.RoleType ReceivingParty 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PaymentReceivingParty;
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
		public global::Allors.Meta.RoleType Comment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommentableComment;
			}
		} 
		public global::Allors.Meta.RoleType UniqueId 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UniquelyIdentifiableUniqueId;
			}
		} 

		public global::Allors.Meta.AssociationType PerformanceReviewsWhereBonusPayCheck 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PerformanceReviewBonusPayCheck;
			}
		} 
		public global::Allors.Meta.AssociationType PaymentBudgetAllocationsWherePayment 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PaymentBudgetAllocationPayment;
			}
		} 

	}
}