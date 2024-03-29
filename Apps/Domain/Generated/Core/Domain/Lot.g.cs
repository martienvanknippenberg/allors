// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class Lot : Allors.ObjectBase , Searchable, UserInterfaceable
	{
		public static readonly LotMeta Meta = LotMeta.Instance;

		public Lot(Allors.IStrategy allors) : base(allors) {}

		public static Lot Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (Lot) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.DateTime ExpirationDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.ExpirationDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ExpirationDate, value);
			}
		}

		virtual public bool ExistExpirationDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.ExpirationDate);
			}
		}

		virtual public void RemoveExpirationDate()
		{
			Strategy.RemoveUnitRole(Meta.ExpirationDate);
		}



		virtual public global::System.Int32 Quantity 
		{
			get
			{
				return (global::System.Int32) Strategy.GetUnitRole(Meta.Quantity);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Quantity, value);
			}
		}

		virtual public bool ExistQuantity{
			get
			{
				return Strategy.ExistUnitRole(Meta.Quantity);
			}
		}

		virtual public void RemoveQuantity()
		{
			Strategy.RemoveUnitRole(Meta.Quantity);
		}



		virtual public global::System.String LotNumber 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.LotNumber);
			}
			set
			{
				Strategy.SetUnitRole(Meta.LotNumber, value);
			}
		}

		virtual public bool ExistLotNumber{
			get
			{
				return Strategy.ExistUnitRole(Meta.LotNumber);
			}
		}

		virtual public void RemoveLotNumber()
		{
			Strategy.RemoveUnitRole(Meta.LotNumber);
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



		virtual public global::Allors.Extent<InventoryItem> InventoryItemsWhereLot
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.InventoryItemsWhereLot);
			}
		}

		virtual public bool ExistInventoryItemsWhereLot
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.InventoryItemsWhereLot);
			}
		}

	}

	public class LotMeta
	{
		public static readonly LotMeta Instance = new LotMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.Lot;

		public global::Allors.Meta.RoleType ExpirationDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.LotExpirationDate;
			}
		} 
		public global::Allors.Meta.RoleType Quantity 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.LotQuantity;
			}
		} 
		public global::Allors.Meta.RoleType LotNumber 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.LotLotNumber;
			}
		} 
		public global::Allors.Meta.RoleType SearchData 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SearchableSearchData;
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

		public global::Allors.Meta.AssociationType InventoryItemsWhereLot 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.InventoryItemLot;
			}
		} 

	}
}