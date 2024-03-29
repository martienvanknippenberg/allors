// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class AgreementSection : Allors.ObjectBase , AgreementItem
	{
		public static readonly AgreementSectionMeta Meta = AgreementSectionMeta.Instance;

		public AgreementSection(Allors.IStrategy allors) : base(allors) {}

		public static AgreementSection Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (AgreementSection) allorsSession.Instantiate(allorsObjectId);		
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


		virtual public global::Allors.Extent<AgreementItem> Children
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.Child);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.Child, value);
			}
		}

		virtual public void AddChild (AgreementItem value)
		{
			Strategy.AddCompositeRole(Meta.Child, value);
		}

		virtual public void RemoveChild (AgreementItem value)
		{
			Strategy.RemoveCompositeRole(Meta.Child,value);
		}

		virtual public bool ExistChildren
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.Child);
			}
		}

		virtual public void RemoveChildren()
		{
			Strategy.RemoveCompositeRoles(Meta.Child);
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



		virtual public Agreement AgreementWhereAgreementItem
		{ 
			get
			{
				return (Agreement) Strategy.GetCompositeAssociation(Meta.AgreementWhereAgreementItem);
			}
		} 

		virtual public bool ExistAgreementWhereAgreementItem
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.AgreementWhereAgreementItem);
			}
		}


		virtual public AgreementItem AgreementItemWhereChild
		{ 
			get
			{
				return (AgreementItem) Strategy.GetCompositeAssociation(Meta.AgreementItemWhereChild);
			}
		} 

		virtual public bool ExistAgreementItemWhereChild
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.AgreementItemWhereChild);
			}
		}

	}

	public class AgreementSectionMeta
	{
		public static readonly AgreementSectionMeta Instance = new AgreementSectionMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.AgreementSection;

		public global::Allors.Meta.RoleType Text 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AgreementItemText;
			}
		} 
		public global::Allors.Meta.RoleType Addendum 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AgreementItemAddendum;
			}
		} 
		public global::Allors.Meta.RoleType Child 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AgreementItemChild;
			}
		} 
		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AgreementItemDescription;
			}
		} 
		public global::Allors.Meta.RoleType AgreementTerm 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AgreementItemAgreementTerm;
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

		public global::Allors.Meta.AssociationType AgreementWhereAgreementItem 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.AgreementAgreementItem;
			}
		} 
		public global::Allors.Meta.AssociationType AgreementItemWhereChild 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.AgreementItemChild;
			}
		} 

	}
}