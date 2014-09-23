// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class NeededSkill : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly NeededSkillMeta Meta = NeededSkillMeta.Instance;

		public NeededSkill(Allors.IStrategy allors) : base(allors) {}

		public static NeededSkill Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (NeededSkill) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public SkillLevel SkillLevel
		{ 
			get
			{
				return (SkillLevel) Strategy.GetCompositeRole(Meta.SkillLevel);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.SkillLevel ,value);
			}
		}

		virtual public bool ExistSkillLevel
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.SkillLevel);
			}
		}

		virtual public void RemoveSkillLevel()
		{
			Strategy.RemoveCompositeRole(Meta.SkillLevel);
		}



		virtual public global::System.Decimal? YearsExperience 
		{
			get
			{
				return (global::System.Decimal?) Strategy.GetUnitRole(Meta.YearsExperience);
			}
			set
			{
				Strategy.SetUnitRole(Meta.YearsExperience, value);
			}
		}

		virtual public bool ExistYearsExperience{
			get
			{
				return Strategy.ExistUnitRole(Meta.YearsExperience);
			}
		}

		virtual public void RemoveYearsExperience()
		{
			Strategy.RemoveUnitRole(Meta.YearsExperience);
		}


		virtual public Skill Skill
		{ 
			get
			{
				return (Skill) Strategy.GetCompositeRole(Meta.Skill);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Skill ,value);
			}
		}

		virtual public bool ExistSkill
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Skill);
			}
		}

		virtual public void RemoveSkill()
		{
			Strategy.RemoveCompositeRole(Meta.Skill);
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



		virtual public ResourceRequirement ResourceRequirementWhereNeededSkill
		{ 
			get
			{
				return (ResourceRequirement) Strategy.GetCompositeAssociation(Meta.ResourceRequirementWhereNeededSkill);
			}
		} 

		virtual public bool ExistResourceRequirementWhereNeededSkill
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.ResourceRequirementWhereNeededSkill);
			}
		}


		virtual public global::Allors.Extent<RequestItem> RequestItemsWhereNeededSkill
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.RequestItemsWhereNeededSkill);
			}
		}

		virtual public bool ExistRequestItemsWhereNeededSkill
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.RequestItemsWhereNeededSkill);
			}
		}

	}

	public class NeededSkillMeta
	{
		public static readonly NeededSkillMeta Instance = new NeededSkillMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.NeededSkill;

		public global::Allors.Meta.RoleType SkillLevel 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.NeededSkillSkillLevel;
			}
		} 
		public global::Allors.Meta.RoleType YearsExperience 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.NeededSkillYearsExperience;
			}
		} 
		public global::Allors.Meta.RoleType Skill 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.NeededSkillSkill;
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

		public global::Allors.Meta.AssociationType ResourceRequirementWhereNeededSkill 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ResourceRequirementNeededSkill;
			}
		} 
		public global::Allors.Meta.AssociationType RequestItemsWhereNeededSkill 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.RequestItemNeededSkill;
			}
		} 

	}
}