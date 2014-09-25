// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class PurchaseInvoiceItemObjectState : Allors.ObjectBase , ObjectState
	{
		public static readonly PurchaseInvoiceItemObjectStateMeta Meta = PurchaseInvoiceItemObjectStateMeta.Instance;

		public PurchaseInvoiceItemObjectState(Allors.IStrategy allors) : base(allors) {}

		public static PurchaseInvoiceItemObjectState Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (PurchaseInvoiceItemObjectState) allorsSession.Instantiate(allorsObjectId);		
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



		virtual public global::Allors.Extent<PurchaseInvoiceItem> PurchaseInvoiceItemsWherePreviousObjectState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PurchaseInvoiceItemsWherePreviousObjectState);
			}
		}

		virtual public bool ExistPurchaseInvoiceItemsWherePreviousObjectState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PurchaseInvoiceItemsWherePreviousObjectState);
			}
		}


		virtual public global::Allors.Extent<PurchaseInvoiceItem> PurchaseInvoiceItemsWhereCurrentObjectState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PurchaseInvoiceItemsWhereCurrentObjectState);
			}
		}

		virtual public bool ExistPurchaseInvoiceItemsWhereCurrentObjectState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PurchaseInvoiceItemsWhereCurrentObjectState);
			}
		}


		virtual public global::Allors.Extent<PurchaseInvoiceItemStatus> PurchaseInvoiceItemStatusesWherePurchaseInvoiceItemObjectState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PurchaseInvoiceItemStatusesWherePurchaseInvoiceItemObjectState);
			}
		}

		virtual public bool ExistPurchaseInvoiceItemStatusesWherePurchaseInvoiceItemObjectState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PurchaseInvoiceItemStatusesWherePurchaseInvoiceItemObjectState);
			}
		}


		virtual public global::Allors.Extent<Transition> TransitionsWhereFromState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.TransitionsWhereFromState);
			}
		}

		virtual public bool ExistTransitionsWhereFromState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.TransitionsWhereFromState);
			}
		}


		virtual public global::Allors.Extent<Transition> TransitionsWhereToState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.TransitionsWhereToState);
			}
		}

		virtual public bool ExistTransitionsWhereToState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.TransitionsWhereToState);
			}
		}

	}

	public class PurchaseInvoiceItemObjectStateMeta
	{
		public static readonly PurchaseInvoiceItemObjectStateMeta Instance = new PurchaseInvoiceItemObjectStateMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.PurchaseInvoiceItemObjectState;

		public global::Allors.Meta.RoleType DeniedPermission 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ObjectStateDeniedPermission;
			}
		} 
		public global::Allors.Meta.RoleType Name 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ObjectStateName;
			}
		} 
		public global::Allors.Meta.RoleType UniqueId 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UniquelyIdentifiableUniqueId;
			}
		} 

		public global::Allors.Meta.AssociationType PurchaseInvoiceItemsWherePreviousObjectState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseInvoiceItemPreviousObjectState;
			}
		} 
		public global::Allors.Meta.AssociationType PurchaseInvoiceItemsWhereCurrentObjectState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseInvoiceItemCurrentObjectState;
			}
		} 
		public global::Allors.Meta.AssociationType PurchaseInvoiceItemStatusesWherePurchaseInvoiceItemObjectState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseInvoiceItemStatusPurchaseInvoiceItemObjectState;
			}
		} 
		public global::Allors.Meta.AssociationType TransitionsWhereFromState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.TransitionFromState;
			}
		} 
		public global::Allors.Meta.AssociationType TransitionsWhereToState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.TransitionToState;
			}
		} 

	}
}