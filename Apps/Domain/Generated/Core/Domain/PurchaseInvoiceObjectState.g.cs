// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class PurchaseInvoiceObjectState : Allors.ObjectBase , ObjectState
	{
		public static readonly PurchaseInvoiceObjectStateMeta Meta = PurchaseInvoiceObjectStateMeta.Instance;

		public PurchaseInvoiceObjectState(Allors.IStrategy allors) : base(allors) {}

		public static PurchaseInvoiceObjectState Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (PurchaseInvoiceObjectState) allorsSession.Instantiate(allorsObjectId);		
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



		virtual public global::Allors.Extent<PurchaseInvoiceStatus> PurchaseInvoiceStatusesWherePurchaseInvoiceObjectState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PurchaseInvoiceStatusesWherePurchaseInvoiceObjectState);
			}
		}

		virtual public bool ExistPurchaseInvoiceStatusesWherePurchaseInvoiceObjectState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PurchaseInvoiceStatusesWherePurchaseInvoiceObjectState);
			}
		}


		virtual public global::Allors.Extent<PurchaseInvoice> PurchaseInvoicesWherePreviousObjectState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PurchaseInvoicesWherePreviousObjectState);
			}
		}

		virtual public bool ExistPurchaseInvoicesWherePreviousObjectState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PurchaseInvoicesWherePreviousObjectState);
			}
		}


		virtual public global::Allors.Extent<PurchaseInvoice> PurchaseInvoicesWhereCurrentObjectState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PurchaseInvoicesWhereCurrentObjectState);
			}
		}

		virtual public bool ExistPurchaseInvoicesWhereCurrentObjectState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PurchaseInvoicesWhereCurrentObjectState);
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

	public class PurchaseInvoiceObjectStateMeta
	{
		public static readonly PurchaseInvoiceObjectStateMeta Instance = new PurchaseInvoiceObjectStateMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.PurchaseInvoiceObjectState;

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

		public global::Allors.Meta.AssociationType PurchaseInvoiceStatusesWherePurchaseInvoiceObjectState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseInvoiceStatusPurchaseInvoiceObjectState;
			}
		} 
		public global::Allors.Meta.AssociationType PurchaseInvoicesWherePreviousObjectState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseInvoicePreviousObjectState;
			}
		} 
		public global::Allors.Meta.AssociationType PurchaseInvoicesWhereCurrentObjectState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PurchaseInvoiceCurrentObjectState;
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