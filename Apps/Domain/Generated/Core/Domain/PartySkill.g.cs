// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class PartySkill : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly PartySkillMeta Meta = PartySkillMeta.Instance;

		public PartySkill(Allors.IStrategy allors) : base(allors) {}

		public static PartySkill Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (PartySkill) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.Decimal YearsExperience 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.YearsExperience);
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



		virtual public global::System.DateTime StartedUsingDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.StartedUsingDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.StartedUsingDate, value);
			}
		}

		virtual public bool ExistStartedUsingDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.StartedUsingDate);
			}
		}

		virtual public void RemoveStartedUsingDate()
		{
			Strategy.RemoveUnitRole(Meta.StartedUsingDate);
		}


		virtual public SkillRating SkillRating
		{ 
			get
			{
				return (SkillRating) Strategy.GetCompositeRole(Meta.SkillRating);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.SkillRating ,value);
			}
		}

		virtual public bool ExistSkillRating
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.SkillRating);
			}
		}

		virtual public void RemoveSkillRating()
		{
			Strategy.RemoveCompositeRole(Meta.SkillRating);
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



		virtual public global::Allors.Extent<Party> PartiesWherePartySkill
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartiesWherePartySkill);
			}
		}

		virtual public bool ExistPartiesWherePartySkill
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartiesWherePartySkill);
			}
		}

	}

	public class PartySkillMeta
	{
		public static readonly PartySkillMeta Instance = new PartySkillMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.PartySkill;

		public global::Allors.Meta.RoleType YearsExperience 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartySkillYearsExperience;
			}
		} 
		public global::Allors.Meta.RoleType StartedUsingDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartySkillStartedUsingDate;
			}
		} 
		public global::Allors.Meta.RoleType SkillRating 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartySkillSkillRating;
			}
		} 
		public global::Allors.Meta.RoleType SkillLevel 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartySkillSkillLevel;
			}
		} 
		public global::Allors.Meta.RoleType Skill 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartySkillSkill;
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

		public global::Allors.Meta.AssociationType PartiesWherePartySkill 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyPartySkill;
			}
		} 

	}
}