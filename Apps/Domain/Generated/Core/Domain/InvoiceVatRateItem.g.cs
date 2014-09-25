// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class InvoiceVatRateItem : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly InvoiceVatRateItemMeta Meta = InvoiceVatRateItemMeta.Instance;

		public InvoiceVatRateItem(Allors.IStrategy allors) : base(allors) {}

		public static InvoiceVatRateItem Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (InvoiceVatRateItem) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.Decimal BaseAmount 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.BaseAmount);
			}
			set
			{
				Strategy.SetUnitRole(Meta.BaseAmount, value);
			}
		}

		virtual public bool ExistBaseAmount{
			get
			{
				return Strategy.ExistUnitRole(Meta.BaseAmount);
			}
		}

		virtual public void RemoveBaseAmount()
		{
			Strategy.RemoveUnitRole(Meta.BaseAmount);
		}


		virtual public global::Allors.Extent<VatRate> VatRates
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.VatRate);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.VatRate, value);
			}
		}

		virtual public void AddVatRate (VatRate value)
		{
			Strategy.AddCompositeRole(Meta.VatRate, value);
		}

		virtual public void RemoveVatRate (VatRate value)
		{
			Strategy.RemoveCompositeRole(Meta.VatRate,value);
		}

		virtual public bool ExistVatRates
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.VatRate);
			}
		}

		virtual public void RemoveVatRates()
		{
			Strategy.RemoveCompositeRoles(Meta.VatRate);
		}



		virtual public global::System.Decimal VatAmount 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.VatAmount);
			}
			set
			{
				Strategy.SetUnitRole(Meta.VatAmount, value);
			}
		}

		virtual public bool ExistVatAmount{
			get
			{
				return Strategy.ExistUnitRole(Meta.VatAmount);
			}
		}

		virtual public void RemoveVatAmount()
		{
			Strategy.RemoveUnitRole(Meta.VatAmount);
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



		virtual public InvoiceItem InvoiceItemWhereInvoiceVatRateItem
		{ 
			get
			{
				return (InvoiceItem) Strategy.GetCompositeAssociation(Meta.InvoiceItemWhereInvoiceVatRateItem);
			}
		} 

		virtual public bool ExistInvoiceItemWhereInvoiceVatRateItem
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.InvoiceItemWhereInvoiceVatRateItem);
			}
		}

	}

	public class InvoiceVatRateItemMeta
	{
		public static readonly InvoiceVatRateItemMeta Instance = new InvoiceVatRateItemMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.InvoiceVatRateItem;

		public global::Allors.Meta.RoleType BaseAmount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceVatRateItemBaseAmount;
			}
		} 
		public global::Allors.Meta.RoleType VatRate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceVatRateItemVatRate;
			}
		} 
		public global::Allors.Meta.RoleType VatAmount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.InvoiceVatRateItemVatAmount;
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

		public global::Allors.Meta.AssociationType InvoiceItemWhereInvoiceVatRateItem 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InvoiceItemInvoiceVatRateItem;
			}
		} 

	}
}