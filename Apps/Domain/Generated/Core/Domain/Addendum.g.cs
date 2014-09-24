// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class Addendum : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly AddendumMeta Meta = AddendumMeta.Instance;

		public Addendum(Allors.IStrategy allors) : base(allors) {}

		public static Addendum Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (Addendum) allorsSession.Instantiate(allorsObjectId);		
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



		virtual public global::System.DateTime EffictiveDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.EffictiveDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.EffictiveDate, value);
			}
		}

		virtual public bool ExistEffictiveDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.EffictiveDate);
			}
		}

		virtual public void RemoveEffictiveDate()
		{
			Strategy.RemoveUnitRole(Meta.EffictiveDate);
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



		virtual public global::System.DateTime CreationDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.CreationDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.CreationDate, value);
			}
		}

		virtual public bool ExistCreationDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.CreationDate);
			}
		}

		virtual public void RemoveCreationDate()
		{
			Strategy.RemoveUnitRole(Meta.CreationDate);
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



		virtual public Agreement AgreementWhereAddendum
		{ 
			get
			{
				return (Agreement) Strategy.GetCompositeAssociation(Meta.AgreementWhereAddendum);
			}
		} 

		virtual public bool ExistAgreementWhereAddendum
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.AgreementWhereAddendum);
			}
		}


		virtual public AgreementItem AgreementItemWhereAddendum
		{ 
			get
			{
				return (AgreementItem) Strategy.GetCompositeAssociation(Meta.AgreementItemWhereAddendum);
			}
		} 

		virtual public bool ExistAgreementItemWhereAddendum
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.AgreementItemWhereAddendum);
			}
		}

	}

	public class AddendumMeta
	{
		public static readonly AddendumMeta Instance = new AddendumMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.Addendum;

		public global::Allors.Meta.RoleType Text 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AddendumText;
			}
		} 
		public global::Allors.Meta.RoleType EffictiveDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AddendumEffictiveDate;
			}
		} 
		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AddendumDescription;
			}
		} 
		public global::Allors.Meta.RoleType CreationDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AddendumCreationDate;
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

		public global::Allors.Meta.AssociationType AgreementWhereAddendum 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.AgreementAddendum;
			}
		} 
		public global::Allors.Meta.AssociationType AgreementItemWhereAddendum 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.AgreementItemAddendum;
			}
		} 

	}
}