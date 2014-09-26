// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class PurchaseOrderObjectState : Allors.ObjectBase , ObjectState
	{
		public static readonly PurchaseOrderObjectStateMeta Meta = PurchaseOrderObjectStateMeta.Instance;

		public PurchaseOrderObjectState(Allors.IStrategy allors) : base(allors) {}

		public static PurchaseOrderObjectState Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (PurchaseOrderObjectState) allorsSession.Instantiate(allorsObjectId);		
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



		virtual public global::Allors.Extent<PurchaseOrder> PurchaseOrdersWhereCurrentObjectState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PurchaseOrdersWhereCurrentObjectState);
			}
		}

		virtual public bool ExistPurchaseOrdersWhereCurrentObjectState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PurchaseOrdersWhereCurrentObjectState);
			}
		}


		virtual public global::Allors.Extent<PurchaseOrder> PurchaseOrdersWherePreviousObjectState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PurchaseOrdersWherePreviousObjectState);
			}
		}

		virtual public bool ExistPurchaseOrdersWherePreviousObjectState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PurchaseOrdersWherePreviousObjectState);
			}
		}


		virtual public global::Allors.Extent<PurchaseOrderStatus> PurchaseOrderStatusesWherePurchaseOrderObjectState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PurchaseOrderStatusesWherePurchaseOrderObjectState);
			}
		}

		virtual public bool ExistPurchaseOrderStatusesWherePurchaseOrderObjectState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PurchaseOrderStatusesWherePurchaseOrderObjectState);
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

	public class PurchaseOrderObjectStateMeta
	{
		public static readonly PurchaseOrderObjectStateMeta Instance = new PurchaseOrderObjectStateMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.PurchaseOrderObjectState;

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

		public global::Allors.Meta.AssociationType PurchaseOrdersWhereCurrentObjectState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseOrderCurrentObjectState;
			}
		} 
		public global::Allors.Meta.AssociationType PurchaseOrdersWherePreviousObjectState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseOrderPreviousObjectState;
			}
		} 
		public global::Allors.Meta.AssociationType PurchaseOrderStatusesWherePurchaseOrderObjectState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseOrderStatusPurchaseOrderObjectState;
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