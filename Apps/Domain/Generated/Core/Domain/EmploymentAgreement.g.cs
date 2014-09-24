// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class EmploymentAgreement : Allors.ObjectBase , Agreement
	{
		public static readonly EmploymentAgreementMeta Meta = EmploymentAgreementMeta.Instance;

		public EmploymentAgreement(Allors.IStrategy allors) : base(allors) {}

		public static EmploymentAgreement Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (EmploymentAgreement) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.DateTime AgreementDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.AgreementDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.AgreementDate, value);
			}
		}

		virtual public bool ExistAgreementDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.AgreementDate);
			}
		}

		virtual public void RemoveAgreementDate()
		{
			Strategy.RemoveUnitRole(Meta.AgreementDate);
		}


		virtual public global::Allors.Extent<Addendum> Addenda
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.Addendum);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.Addendum, value);
			}
		}

		virtual public void AddAddendum (Addendum value)
		{
			Strategy.AddCompositeRole(Meta.Addendum, value);
		}

		virtual public void RemoveAddendum (Addendum value)
		{
			Strategy.RemoveCompositeRole(Meta.Addendum,value);
		}

		virtual public bool ExistAddenda
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.Addendum);
			}
		}

		virtual public void RemoveAddenda()
		{
			Strategy.RemoveCompositeRoles(Meta.Addendum);
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


		virtual public global::Allors.Extent<AgreementTerm> AgreementTerms
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.AgreementTerm);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.AgreementTerm, value);
			}
		}

		virtual public void AddAgreementTerm (AgreementTerm value)
		{
			Strategy.AddCompositeRole(Meta.AgreementTerm, value);
		}

		virtual public void RemoveAgreementTerm (AgreementTerm value)
		{
			Strategy.RemoveCompositeRole(Meta.AgreementTerm,value);
		}

		virtual public bool ExistAgreementTerms
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.AgreementTerm);
			}
		}

		virtual public void RemoveAgreementTerms()
		{
			Strategy.RemoveCompositeRoles(Meta.AgreementTerm);
		}



		virtual public global::System.String Text 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Text);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Text, value);
			}
		}

		virtual public bool ExistText{
			get
			{
				return Strategy.ExistUnitRole(Meta.Text);
			}
		}

		virtual public void RemoveText()
		{
			Strategy.RemoveUnitRole(Meta.Text);
		}


		virtual public global::Allors.Extent<AgreementItem> AgreementItems
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.AgreementItem);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.AgreementItem, value);
			}
		}

		virtual public void AddAgreementItem (AgreementItem value)
		{
			Strategy.AddCompositeRole(Meta.AgreementItem, value);
		}

		virtual public void RemoveAgreementItem (AgreementItem value)
		{
			Strategy.RemoveCompositeRole(Meta.AgreementItem,value);
		}

		virtual public bool ExistAgreementItems
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.AgreementItem);
			}
		}

		virtual public void RemoveAgreementItems()
		{
			Strategy.RemoveCompositeRoles(Meta.AgreementItem);
		}



		virtual public global::System.String AgreementNumber 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.AgreementNumber);
			}
			set
			{
				Strategy.SetUnitRole(Meta.AgreementNumber, value);
			}
		}

		virtual public bool ExistAgreementNumber{
			get
			{
				return Strategy.ExistUnitRole(Meta.AgreementNumber);
			}
		}

		virtual public void RemoveAgreementNumber()
		{
			Strategy.RemoveUnitRole(Meta.AgreementNumber);
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



		virtual public global::System.DateTime FromDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.FromDate);
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



		virtual public global::System.DateTime ThroughDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.ThroughDate);
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



		virtual public PartyRelationship PartyRelationshipWhereAgreement
		{ 
			get
			{
				return (PartyRelationship) Strategy.GetCompositeAssociation(Meta.PartyRelationshipWhereAgreement);
			}
		} 

		virtual public bool ExistPartyRelationshipWhereAgreement
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.PartyRelationshipWhereAgreement);
			}
		}


		virtual public global::Allors.Extent<Engagement> EngagementsWhereAgreement
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.EngagementsWhereAgreement);
			}
		}

		virtual public bool ExistEngagementsWhereAgreement
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.EngagementsWhereAgreement);
			}
		}

	}

	public class EmploymentAgreementMeta
	{
		public static readonly EmploymentAgreementMeta Instance = new EmploymentAgreementMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.EmploymentAgreement;

		public global::Allors.Meta.RoleType AgreementDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AgreementAgreementDate;
			}
		} 
		public global::Allors.Meta.RoleType Addendum 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AgreementAddendum;
			}
		} 
		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AgreementDescription;
			}
		} 
		public global::Allors.Meta.RoleType AgreementTerm 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AgreementAgreementTerm;
			}
		} 
		public global::Allors.Meta.RoleType Text 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AgreementText;
			}
		} 
		public global::Allors.Meta.RoleType AgreementItem 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AgreementAgreementItem;
			}
		} 
		public global::Allors.Meta.RoleType AgreementNumber 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AgreementAgreementNumber;
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
		public global::Allors.Meta.RoleType UniqueId 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UniquelyIdentifiableUniqueId;
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

		public global::Allors.Meta.AssociationType PartyRelationshipWhereAgreement 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyRelationshipAgreement;
			}
		} 
		public global::Allors.Meta.AssociationType EngagementsWhereAgreement 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.EngagementAgreement;
			}
		} 

	}
}