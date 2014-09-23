// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class FinancialAccountAdjustment : Allors.ObjectBase , FinancialAccountTransaction
	{
		public static readonly FinancialAccountAdjustmentMeta Meta = FinancialAccountAdjustmentMeta.Instance;

		public FinancialAccountAdjustment(Allors.IStrategy allors) : base(allors) {}

		public static FinancialAccountAdjustment Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (FinancialAccountAdjustment) allorsSession.Instantiate(allorsObjectId);		
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



		virtual public global::System.DateTime? EntryDate 
		{
			get
			{
				return (global::System.DateTime?) Strategy.GetUnitRole(Meta.EntryDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.EntryDate, value);
			}
		}

		virtual public bool ExistEntryDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.EntryDate);
			}
		}

		virtual public void RemoveEntryDate()
		{
			Strategy.RemoveUnitRole(Meta.EntryDate);
		}



		virtual public global::System.DateTime? TransactionDate 
		{
			get
			{
				return (global::System.DateTime?) Strategy.GetUnitRole(Meta.TransactionDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.TransactionDate, value);
			}
		}

		virtual public bool ExistTransactionDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.TransactionDate);
			}
		}

		virtual public void RemoveTransactionDate()
		{
			Strategy.RemoveUnitRole(Meta.TransactionDate);
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



		virtual public FinancialAccount FinancialAccountWhereFinancialAccountTransaction
		{ 
			get
			{
				return (FinancialAccount) Strategy.GetCompositeAssociation(Meta.FinancialAccountWhereFinancialAccountTransaction);
			}
		} 

		virtual public bool ExistFinancialAccountWhereFinancialAccountTransaction
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.FinancialAccountWhereFinancialAccountTransaction);
			}
		}

	}

	public class FinancialAccountAdjustmentMeta
	{
		public static readonly FinancialAccountAdjustmentMeta Instance = new FinancialAccountAdjustmentMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.FinancialAccountAdjustment;

		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.FinancialAccountTransactionDescription;
			}
		} 
		public global::Allors.Meta.RoleType EntryDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.FinancialAccountTransactionEntryDate;
			}
		} 
		public global::Allors.Meta.RoleType TransactionDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.FinancialAccountTransactionTransactionDate;
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

		public global::Allors.Meta.AssociationType FinancialAccountWhereFinancialAccountTransaction 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.FinancialAccountFinancialAccountTransaction;
			}
		} 

	}
}