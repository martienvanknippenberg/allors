// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class PurchaseReturnObjectState : Allors.ObjectBase , ObjectState
	{
		public static readonly PurchaseReturnObjectStateMeta Meta = PurchaseReturnObjectStateMeta.Instance;

		public PurchaseReturnObjectState(Allors.IStrategy allors) : base(allors) {}

		public static PurchaseReturnObjectState Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (PurchaseReturnObjectState) allorsSession.Instantiate(allorsObjectId);		
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



		virtual public global::Allors.Extent<PurchaseReturnStatus> PurchaseReturnStatusesWherePurchaseReturnObjectState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PurchaseReturnStatusesWherePurchaseReturnObjectState);
			}
		}

		virtual public bool ExistPurchaseReturnStatusesWherePurchaseReturnObjectState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PurchaseReturnStatusesWherePurchaseReturnObjectState);
			}
		}


		virtual public global::Allors.Extent<PurchaseReturn> PurchaseReturnsWhereCurrentObjectState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PurchaseReturnsWhereCurrentObjectState);
			}
		}

		virtual public bool ExistPurchaseReturnsWhereCurrentObjectState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PurchaseReturnsWhereCurrentObjectState);
			}
		}


		virtual public global::Allors.Extent<PurchaseReturn> PurchaseReturnsWherePreviousObjectState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PurchaseReturnsWherePreviousObjectState);
			}
		}

		virtual public bool ExistPurchaseReturnsWherePreviousObjectState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PurchaseReturnsWherePreviousObjectState);
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

	public class PurchaseReturnObjectStateMeta
	{
		public static readonly PurchaseReturnObjectStateMeta Instance = new PurchaseReturnObjectStateMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.PurchaseReturnObjectState;

		public global::Allors.Meta.RoleType DeniedPermission 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ObjectStateDeniedPermission;
			}
		} 
		public global::Allors.Meta.RoleType UniqueId 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UniquelyIdentifiableUniqueId;
			}
		} 

		public global::Allors.Meta.AssociationType PurchaseReturnStatusesWherePurchaseReturnObjectState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseReturnStatusPurchaseReturnObjectState;
			}
		} 
		public global::Allors.Meta.AssociationType PurchaseReturnsWhereCurrentObjectState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseReturnCurrentObjectState;
			}
		} 
		public global::Allors.Meta.AssociationType PurchaseReturnsWherePreviousObjectState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseReturnPreviousObjectState;
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