// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class SalesOrderObjectState : Allors.ObjectBase , ObjectState
	{
		public static readonly SalesOrderObjectStateMeta Meta = SalesOrderObjectStateMeta.Instance;

		public SalesOrderObjectState(Allors.IStrategy allors) : base(allors) {}

		public static SalesOrderObjectState Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (SalesOrderObjectState) allorsSession.Instantiate(allorsObjectId);		
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



		virtual public global::System.Guid? UniqueId 
		{
			get
			{
				return (global::System.Guid?) Strategy.GetUnitRole(Meta.UniqueId);
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



		virtual public global::Allors.Extent<SalesOrderStatus> SalesOrderStatusesWhereSalesOrderObjectState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesOrderStatusesWhereSalesOrderObjectState);
			}
		}

		virtual public bool ExistSalesOrderStatusesWhereSalesOrderObjectState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesOrderStatusesWhereSalesOrderObjectState);
			}
		}


		virtual public global::Allors.Extent<SalesOrder> SalesOrdersWherePreviousObjectState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesOrdersWherePreviousObjectState);
			}
		}

		virtual public bool ExistSalesOrdersWherePreviousObjectState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesOrdersWherePreviousObjectState);
			}
		}


		virtual public global::Allors.Extent<SalesOrder> SalesOrdersWhereCurrentObjectState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesOrdersWhereCurrentObjectState);
			}
		}

		virtual public bool ExistSalesOrdersWhereCurrentObjectState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesOrdersWhereCurrentObjectState);
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

	public class SalesOrderObjectStateMeta
	{
		public static readonly SalesOrderObjectStateMeta Instance = new SalesOrderObjectStateMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.SalesOrderObjectState;

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

		public global::Allors.Meta.AssociationType SalesOrderStatusesWhereSalesOrderObjectState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesOrderStatusSalesOrderObjectState;
			}
		} 
		public global::Allors.Meta.AssociationType SalesOrdersWherePreviousObjectState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesOrderPreviousObjectState;
			}
		} 
		public global::Allors.Meta.AssociationType SalesOrdersWhereCurrentObjectState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesOrderCurrentObjectState;
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