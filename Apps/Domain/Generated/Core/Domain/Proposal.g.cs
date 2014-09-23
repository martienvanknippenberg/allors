// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class Proposal : Allors.ObjectBase , Quote
	{
		public static readonly ProposalMeta Meta = ProposalMeta.Instance;

		public Proposal(Allors.IStrategy allors) : base(allors) {}

		public static Proposal Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (Proposal) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.DateTime? ValidFromDate 
		{
			get
			{
				return (global::System.DateTime?) Strategy.GetUnitRole(Meta.ValidFromDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ValidFromDate, value);
			}
		}

		virtual public bool ExistValidFromDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.ValidFromDate);
			}
		}

		virtual public void RemoveValidFromDate()
		{
			Strategy.RemoveUnitRole(Meta.ValidFromDate);
		}


		virtual public global::Allors.Extent<QuoteTerm> QuoteTerms
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.QuoteTerm);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.QuoteTerm, value);
			}
		}

		virtual public void AddQuoteTerm (QuoteTerm value)
		{
			Strategy.AddCompositeRole(Meta.QuoteTerm, value);
		}

		virtual public void RemoveQuoteTerm (QuoteTerm value)
		{
			Strategy.RemoveCompositeRole(Meta.QuoteTerm,value);
		}

		virtual public bool ExistQuoteTerms
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.QuoteTerm);
			}
		}

		virtual public void RemoveQuoteTerms()
		{
			Strategy.RemoveCompositeRoles(Meta.QuoteTerm);
		}


		virtual public Party Issuer
		{ 
			get
			{
				return (Party) Strategy.GetCompositeRole(Meta.Issuer);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Issuer ,value);
			}
		}

		virtual public bool ExistIssuer
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Issuer);
			}
		}

		virtual public void RemoveIssuer()
		{
			Strategy.RemoveCompositeRole(Meta.Issuer);
		}



		virtual public global::System.DateTime? ValidThroughDate 
		{
			get
			{
				return (global::System.DateTime?) Strategy.GetUnitRole(Meta.ValidThroughDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ValidThroughDate, value);
			}
		}

		virtual public bool ExistValidThroughDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.ValidThroughDate);
			}
		}

		virtual public void RemoveValidThroughDate()
		{
			Strategy.RemoveUnitRole(Meta.ValidThroughDate);
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


		virtual public Party Receiver
		{ 
			get
			{
				return (Party) Strategy.GetCompositeRole(Meta.Receiver);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Receiver ,value);
			}
		}

		virtual public bool ExistReceiver
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Receiver);
			}
		}

		virtual public void RemoveReceiver()
		{
			Strategy.RemoveCompositeRole(Meta.Receiver);
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



		virtual public global::System.DateTime? IssueDate 
		{
			get
			{
				return (global::System.DateTime?) Strategy.GetUnitRole(Meta.IssueDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.IssueDate, value);
			}
		}

		virtual public bool ExistIssueDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.IssueDate);
			}
		}

		virtual public void RemoveIssueDate()
		{
			Strategy.RemoveUnitRole(Meta.IssueDate);
		}


		virtual public global::Allors.Extent<QuoteItem> QuoteItems
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.QuoteItem);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.QuoteItem, value);
			}
		}

		virtual public void AddQuoteItem (QuoteItem value)
		{
			Strategy.AddCompositeRole(Meta.QuoteItem, value);
		}

		virtual public void RemoveQuoteItem (QuoteItem value)
		{
			Strategy.RemoveCompositeRole(Meta.QuoteItem,value);
		}

		virtual public bool ExistQuoteItems
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.QuoteItem);
			}
		}

		virtual public void RemoveQuoteItems()
		{
			Strategy.RemoveCompositeRoles(Meta.QuoteItem);
		}



		virtual public global::System.String QuoteNumber 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.QuoteNumber);
			}
			set
			{
				Strategy.SetUnitRole(Meta.QuoteNumber, value);
			}
		}

		virtual public bool ExistQuoteNumber{
			get
			{
				return Strategy.ExistUnitRole(Meta.QuoteNumber);
			}
		}

		virtual public void RemoveQuoteNumber()
		{
			Strategy.RemoveUnitRole(Meta.QuoteNumber);
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

	}

	public class ProposalMeta
	{
		public static readonly ProposalMeta Instance = new ProposalMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.Proposal;

		public global::Allors.Meta.RoleType ValidFromDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.QuoteValidFromDate;
			}
		} 
		public global::Allors.Meta.RoleType QuoteTerm 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.QuoteQuoteTerm;
			}
		} 
		public global::Allors.Meta.RoleType Issuer 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.QuoteIssuer;
			}
		} 
		public global::Allors.Meta.RoleType ValidThroughDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.QuoteValidThroughDate;
			}
		} 
		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.QuoteDescription;
			}
		} 
		public global::Allors.Meta.RoleType Receiver 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.QuoteReceiver;
			}
		} 
		public global::Allors.Meta.RoleType Amount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.QuoteAmount;
			}
		} 
		public global::Allors.Meta.RoleType IssueDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.QuoteIssueDate;
			}
		} 
		public global::Allors.Meta.RoleType QuoteItem 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.QuoteQuoteItem;
			}
		} 
		public global::Allors.Meta.RoleType QuoteNumber 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.QuoteQuoteNumber;
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

	}
}