// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class Benefit : Allors.ObjectBase , SearchResult, UserInterfaceable, Searchable
	{
		public static readonly BenefitMeta Meta = BenefitMeta.Instance;

		public Benefit(Allors.IStrategy allors) : base(allors) {}

		public static Benefit Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (Benefit) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.Decimal EmployerPaidPercentage 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.EmployerPaidPercentage);
			}
			set
			{
				Strategy.SetUnitRole(Meta.EmployerPaidPercentage, value);
			}
		}

		virtual public bool ExistEmployerPaidPercentage{
			get
			{
				return Strategy.ExistUnitRole(Meta.EmployerPaidPercentage);
			}
		}

		virtual public void RemoveEmployerPaidPercentage()
		{
			Strategy.RemoveUnitRole(Meta.EmployerPaidPercentage);
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



		virtual public global::System.Decimal AvailableTime 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.AvailableTime);
			}
			set
			{
				Strategy.SetUnitRole(Meta.AvailableTime, value);
			}
		}

		virtual public bool ExistAvailableTime{
			get
			{
				return Strategy.ExistUnitRole(Meta.AvailableTime);
			}
		}

		virtual public void RemoveAvailableTime()
		{
			Strategy.RemoveUnitRole(Meta.AvailableTime);
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



		virtual public global::Allors.Extent<PartyBenefit> PartyBenefitsWhereBenefit
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartyBenefitsWhereBenefit);
			}
		}

		virtual public bool ExistPartyBenefitsWhereBenefit
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartyBenefitsWhereBenefit);
			}
		}

	}

	public class BenefitMeta
	{
		public static readonly BenefitMeta Instance = new BenefitMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.Benefit;

		public global::Allors.Meta.RoleType EmployerPaidPercentage 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BenefitEmployerPaidPercentage;
			}
		} 
		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BenefitDescription;
			}
		} 
		public global::Allors.Meta.RoleType Name 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BenefitName;
			}
		} 
		public global::Allors.Meta.RoleType AvailableTime 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BenefitAvailableTime;
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

		public global::Allors.Meta.AssociationType PartyBenefitsWhereBenefit 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyBenefitBenefit;
			}
		} 

	}
}