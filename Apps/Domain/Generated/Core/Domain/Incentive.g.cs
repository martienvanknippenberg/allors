// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class Incentive : Allors.ObjectBase , AgreementTerm
	{
		public static readonly IncentiveMeta Meta = IncentiveMeta.Instance;

		public Incentive(Allors.IStrategy allors) : base(allors) {}

		public static Incentive Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (Incentive) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.String TermValue 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.TermValue);
			}
			set
			{
				Strategy.SetUnitRole(Meta.TermValue, value);
			}
		}

		virtual public bool ExistTermValue{
			get
			{
				return Strategy.ExistUnitRole(Meta.TermValue);
			}
		}

		virtual public void RemoveTermValue()
		{
			Strategy.RemoveUnitRole(Meta.TermValue);
		}


		virtual public TermType TermType
		{ 
			get
			{
				return (TermType) Strategy.GetCompositeRole(Meta.TermType);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.TermType ,value);
			}
		}

		virtual public bool ExistTermType
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.TermType);
			}
		}

		virtual public void RemoveTermType()
		{
			Strategy.RemoveCompositeRole(Meta.TermType);
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



		virtual public Agreement AgreementWhereAgreementTerm
		{ 
			get
			{
				return (Agreement) Strategy.GetCompositeAssociation(Meta.AgreementWhereAgreementTerm);
			}
		} 

		virtual public bool ExistAgreementWhereAgreementTerm
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.AgreementWhereAgreementTerm);
			}
		}


		virtual public AgreementItem AgreementItemWhereAgreementTerm
		{ 
			get
			{
				return (AgreementItem) Strategy.GetCompositeAssociation(Meta.AgreementItemWhereAgreementTerm);
			}
		} 

		virtual public bool ExistAgreementItemWhereAgreementTerm
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.AgreementItemWhereAgreementTerm);
			}
		}


		virtual public InvoiceItem InvoiceItemWhereInvoiceTerm
		{ 
			get
			{
				return (InvoiceItem) Strategy.GetCompositeAssociation(Meta.InvoiceItemWhereInvoiceTerm);
			}
		} 

		virtual public bool ExistInvoiceItemWhereInvoiceTerm
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.InvoiceItemWhereInvoiceTerm);
			}
		}

	}

	public class IncentiveMeta
	{
		public static readonly IncentiveMeta Instance = new IncentiveMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.Incentive;

		public global::Allors.Meta.RoleType TermValue 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AgreementTermTermValue;
			}
		} 
		public global::Allors.Meta.RoleType TermType 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AgreementTermTermType;
			}
		} 
		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AgreementTermDescription;
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

		public global::Allors.Meta.AssociationType AgreementWhereAgreementTerm 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.AgreementAgreementTerm;
			}
		} 
		public global::Allors.Meta.AssociationType AgreementItemWhereAgreementTerm 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.AgreementItemAgreementTerm;
			}
		} 
		public global::Allors.Meta.AssociationType InvoiceItemWhereInvoiceTerm 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InvoiceItemInvoiceTerm;
			}
		} 

	}
}