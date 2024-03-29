// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class Skill : Allors.ObjectBase , Enumeration, Searchable
	{
		public static readonly SkillMeta Meta = SkillMeta.Instance;

		public Skill(Allors.IStrategy allors) : base(allors) {}

		public static Skill Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (Skill) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public global::Allors.Extent<LocalisedText> LocalisedNames
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.LocalisedName);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.LocalisedName, value);
			}
		}

		virtual public void AddLocalisedName (LocalisedText value)
		{
			Strategy.AddCompositeRole(Meta.LocalisedName, value);
		}

		virtual public void RemoveLocalisedName (LocalisedText value)
		{
			Strategy.RemoveCompositeRole(Meta.LocalisedName,value);
		}

		virtual public bool ExistLocalisedNames
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.LocalisedName);
			}
		}

		virtual public void RemoveLocalisedNames()
		{
			Strategy.RemoveCompositeRoles(Meta.LocalisedName);
		}



		virtual public global::System.Boolean IsActive 
		{
			get
			{
				return (global::System.Boolean) Strategy.GetUnitRole(Meta.IsActive);
			}
			set
			{
				Strategy.SetUnitRole(Meta.IsActive, value);
			}
		}

		virtual public bool ExistIsActive{
			get
			{
				return Strategy.ExistUnitRole(Meta.IsActive);
			}
		}

		virtual public void RemoveIsActive()
		{
			Strategy.RemoveUnitRole(Meta.IsActive);
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



		virtual public global::Allors.Extent<QuoteItem> QuoteItemsWhereSkill
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.QuoteItemsWhereSkill);
			}
		}

		virtual public bool ExistQuoteItemsWhereSkill
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.QuoteItemsWhereSkill);
			}
		}


		virtual public global::Allors.Extent<PartySkill> PartySkillsWhereSkill
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartySkillsWhereSkill);
			}
		}

		virtual public bool ExistPartySkillsWhereSkill
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartySkillsWhereSkill);
			}
		}


		virtual public global::Allors.Extent<NeededSkill> NeededSkillsWhereSkill
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.NeededSkillsWhereSkill);
			}
		}

		virtual public bool ExistNeededSkillsWhereSkill
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.NeededSkillsWhereSkill);
			}
		}


		virtual public global::Allors.Extent<WorkEffortSkillStandard> WorkEffortSkillStandardsWhereSkill
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.WorkEffortSkillStandardsWhereSkill);
			}
		}

		virtual public bool ExistWorkEffortSkillStandardsWhereSkill
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.WorkEffortSkillStandardsWhereSkill);
			}
		}


		virtual public global::Allors.Extent<ProductDeliverySkillRequirement> ProductDeliverySkillRequirementsWhereSkill
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductDeliverySkillRequirementsWhereSkill);
			}
		}

		virtual public bool ExistProductDeliverySkillRequirementsWhereSkill
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductDeliverySkillRequirementsWhereSkill);
			}
		}

	}

	public class SkillMeta
	{
		public static readonly SkillMeta Instance = new SkillMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.Skill;

		public global::Allors.Meta.RoleType LocalisedName 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EnumerationLocalisedName;
			}
		} 
		public global::Allors.Meta.RoleType IsActive 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EnumerationIsActive;
			}
		} 
		public global::Allors.Meta.RoleType Name 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EnumerationName;
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
		public global::Allors.Meta.RoleType UniqueId 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UniquelyIdentifiableUniqueId;
			}
		} 
		public global::Allors.Meta.RoleType SearchData 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SearchableSearchData;
			}
		} 

		public global::Allors.Meta.AssociationType QuoteItemsWhereSkill 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.QuoteItemSkill;
			}
		} 
		public global::Allors.Meta.AssociationType PartySkillsWhereSkill 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartySkillSkill;
			}
		} 
		public global::Allors.Meta.AssociationType NeededSkillsWhereSkill 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.NeededSkillSkill;
			}
		} 
		public global::Allors.Meta.AssociationType WorkEffortSkillStandardsWhereSkill 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.WorkEffortSkillStandardSkill;
			}
		} 
		public global::Allors.Meta.AssociationType ProductDeliverySkillRequirementsWhereSkill 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductDeliverySkillRequirementSkill;
			}
		} 

	}
}