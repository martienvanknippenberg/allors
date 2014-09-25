// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class BillingAccount : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly BillingAccountMeta Meta = BillingAccountMeta.Instance;

		public BillingAccount(Allors.IStrategy allors) : base(allors) {}

		public static BillingAccount Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (BillingAccount) allorsSession.Instantiate(allorsObjectId);		
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


		virtual public ContactMechanism ContactMechanism
		{ 
			get
			{
				return (ContactMechanism) Strategy.GetCompositeRole(Meta.ContactMechanism);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.ContactMechanism ,value);
			}
		}

		virtual public bool ExistContactMechanism
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.ContactMechanism);
			}
		}

		virtual public void RemoveContactMechanism()
		{
			Strategy.RemoveCompositeRole(Meta.ContactMechanism);
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



		virtual public Party PartyWhereBillingAccount
		{ 
			get
			{
				return (Party) Strategy.GetCompositeAssociation(Meta.PartyWhereBillingAccount);
			}
		} 

		virtual public bool ExistPartyWhereBillingAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.PartyWhereBillingAccount);
			}
		}


		virtual public global::Allors.Extent<PaymentApplication> PaymentApplicationsWhereBillingAccount
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PaymentApplicationsWhereBillingAccount);
			}
		}

		virtual public bool ExistPaymentApplicationsWhereBillingAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PaymentApplicationsWhereBillingAccount);
			}
		}


		virtual public global::Allors.Extent<Invoice> InvoicesWhereBillingAccount
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.InvoicesWhereBillingAccount);
			}
		}

		virtual public bool ExistInvoicesWhereBillingAccount
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.InvoicesWhereBillingAccount);
			}
		}

	}

	public class BillingAccountMeta
	{
		public static readonly BillingAccountMeta Instance = new BillingAccountMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.BillingAccount;

		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BillingAccountDescription;
			}
		} 
		public global::Allors.Meta.RoleType ContactMechanism 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BillingAccountContactMechanism;
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

		public global::Allors.Meta.AssociationType PartyWhereBillingAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartyBillingAccount;
			}
		} 
		public global::Allors.Meta.AssociationType PaymentApplicationsWhereBillingAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PaymentApplicationBillingAccount;
			}
		} 
		public global::Allors.Meta.AssociationType InvoicesWhereBillingAccount 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InvoiceBillingAccount;
			}
		} 

	}
}