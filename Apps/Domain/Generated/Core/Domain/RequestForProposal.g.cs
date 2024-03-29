// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class RequestForProposal : Allors.ObjectBase , Request
	{
		public static readonly RequestForProposalMeta Meta = RequestForProposalMeta.Instance;

		public RequestForProposal(Allors.IStrategy allors) : base(allors) {}

		public static RequestForProposal Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (RequestForProposal) allorsSession.Instantiate(allorsObjectId);		
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



		virtual public global::System.DateTime RequiredResponseDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.RequiredResponseDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.RequiredResponseDate, value);
			}
		}

		virtual public bool ExistRequiredResponseDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.RequiredResponseDate);
			}
		}

		virtual public void RemoveRequiredResponseDate()
		{
			Strategy.RemoveUnitRole(Meta.RequiredResponseDate);
		}


		virtual public global::Allors.Extent<RequestItem> RequestItems
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.RequestItem);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.RequestItem, value);
			}
		}

		virtual public void AddRequestItem (RequestItem value)
		{
			Strategy.AddCompositeRole(Meta.RequestItem, value);
		}

		virtual public void RemoveRequestItem (RequestItem value)
		{
			Strategy.RemoveCompositeRole(Meta.RequestItem,value);
		}

		virtual public bool ExistRequestItems
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.RequestItem);
			}
		}

		virtual public void RemoveRequestItems()
		{
			Strategy.RemoveCompositeRoles(Meta.RequestItem);
		}



		virtual public global::System.String RequestNumber 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.RequestNumber);
			}
			set
			{
				Strategy.SetUnitRole(Meta.RequestNumber, value);
			}
		}

		virtual public bool ExistRequestNumber{
			get
			{
				return Strategy.ExistUnitRole(Meta.RequestNumber);
			}
		}

		virtual public void RemoveRequestNumber()
		{
			Strategy.RemoveUnitRole(Meta.RequestNumber);
		}


		virtual public global::Allors.Extent<RespondingParty> RespondingParties
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.RespondingParty);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.RespondingParty, value);
			}
		}

		virtual public void AddRespondingParty (RespondingParty value)
		{
			Strategy.AddCompositeRole(Meta.RespondingParty, value);
		}

		virtual public void RemoveRespondingParty (RespondingParty value)
		{
			Strategy.RemoveCompositeRole(Meta.RespondingParty,value);
		}

		virtual public bool ExistRespondingParties
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.RespondingParty);
			}
		}

		virtual public void RemoveRespondingParties()
		{
			Strategy.RemoveCompositeRoles(Meta.RespondingParty);
		}


		virtual public Party Originator
		{ 
			get
			{
				return (Party) Strategy.GetCompositeRole(Meta.Originator);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Originator ,value);
			}
		}

		virtual public bool ExistOriginator
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Originator);
			}
		}

		virtual public void RemoveOriginator()
		{
			Strategy.RemoveCompositeRole(Meta.Originator);
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

	}

	public class RequestForProposalMeta
	{
		public static readonly RequestForProposalMeta Instance = new RequestForProposalMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.RequestForProposal;

		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.RequestDescription;
			}
		} 
		public global::Allors.Meta.RoleType RequiredResponseDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.RequestRequiredResponseDate;
			}
		} 
		public global::Allors.Meta.RoleType RequestItem 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.RequestRequestItem;
			}
		} 
		public global::Allors.Meta.RoleType RequestNumber 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.RequestRequestNumber;
			}
		} 
		public global::Allors.Meta.RoleType RespondingParty 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.RequestRespondingParty;
			}
		} 
		public global::Allors.Meta.RoleType Originator 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.RequestOriginator;
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

	}
}