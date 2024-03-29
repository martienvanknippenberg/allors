// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class DropShipmentObjectState : Allors.ObjectBase , ObjectState
	{
		public static readonly DropShipmentObjectStateMeta Meta = DropShipmentObjectStateMeta.Instance;

		public DropShipmentObjectState(Allors.IStrategy allors) : base(allors) {}

		public static DropShipmentObjectState Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (DropShipmentObjectState) allorsSession.Instantiate(allorsObjectId);		
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



		virtual public global::Allors.Extent<DropShipmentStatus> DropShipmentStatusesWhereDropShipmentObjectState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.DropShipmentStatusesWhereDropShipmentObjectState);
			}
		}

		virtual public bool ExistDropShipmentStatusesWhereDropShipmentObjectState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.DropShipmentStatusesWhereDropShipmentObjectState);
			}
		}


		virtual public global::Allors.Extent<DropShipment> DropShipmentsWherePreviousObjectState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.DropShipmentsWherePreviousObjectState);
			}
		}

		virtual public bool ExistDropShipmentsWherePreviousObjectState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.DropShipmentsWherePreviousObjectState);
			}
		}


		virtual public global::Allors.Extent<DropShipment> DropShipmentsWhereCurrentObjectState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.DropShipmentsWhereCurrentObjectState);
			}
		}

		virtual public bool ExistDropShipmentsWhereCurrentObjectState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.DropShipmentsWhereCurrentObjectState);
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

	public class DropShipmentObjectStateMeta
	{
		public static readonly DropShipmentObjectStateMeta Instance = new DropShipmentObjectStateMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.DropShipmentObjectState;

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

		public global::Allors.Meta.AssociationType DropShipmentStatusesWhereDropShipmentObjectState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.DropShipmentStatusDropShipmentObjectState;
			}
		} 
		public global::Allors.Meta.AssociationType DropShipmentsWherePreviousObjectState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.DropShipmentPreviousObjectState;
			}
		} 
		public global::Allors.Meta.AssociationType DropShipmentsWhereCurrentObjectState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.DropShipmentCurrentObjectState;
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