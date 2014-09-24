// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class InventoryItemKind : Allors.ObjectBase , Enumeration
	{
		public static readonly InventoryItemKindMeta Meta = InventoryItemKindMeta.Instance;

		public InventoryItemKind(Allors.IStrategy allors) : base(allors) {}

		public static InventoryItemKind Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (InventoryItemKind) allorsSession.Instantiate(allorsObjectId);		
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



		virtual public global::Allors.Extent<InternalOrganisationAccountingPreference> InternalOrganisationAccountingPreferencesWhereInventoryItemKind
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.InternalOrganisationAccountingPreferencesWhereInventoryItemKind);
			}
		}

		virtual public bool ExistInternalOrganisationAccountingPreferencesWhereInventoryItemKind
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.InternalOrganisationAccountingPreferencesWhereInventoryItemKind);
			}
		}


		virtual public global::Allors.Extent<Part> PartsWhereInventoryItemKind
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartsWhereInventoryItemKind);
			}
		}

		virtual public bool ExistPartsWhereInventoryItemKind
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartsWhereInventoryItemKind);
			}
		}


		virtual public global::Allors.Extent<Good> GoodsWhereInventoryItemKind
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.GoodsWhereInventoryItemKind);
			}
		}

		virtual public bool ExistGoodsWhereInventoryItemKind
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.GoodsWhereInventoryItemKind);
			}
		}

	}

	public class InventoryItemKindMeta
	{
		public static readonly InventoryItemKindMeta Instance = new InventoryItemKindMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.InventoryItemKind;

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

		public global::Allors.Meta.AssociationType InternalOrganisationAccountingPreferencesWhereInventoryItemKind 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InternalOrganisationAccountingPreferenceInventoryItemKind;
			}
		} 
		public global::Allors.Meta.AssociationType PartsWhereInventoryItemKind 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartInventoryItemKind;
			}
		} 
		public global::Allors.Meta.AssociationType GoodsWhereInventoryItemKind 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.GoodInventoryItemKind;
			}
		} 

	}
}