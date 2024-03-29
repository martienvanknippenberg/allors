// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class NonSerializedInventoryItemObjectState : Allors.ObjectBase , ObjectState
	{
		public static readonly NonSerializedInventoryItemObjectStateMeta Meta = NonSerializedInventoryItemObjectStateMeta.Instance;

		public NonSerializedInventoryItemObjectState(Allors.IStrategy allors) : base(allors) {}

		public static NonSerializedInventoryItemObjectState Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (NonSerializedInventoryItemObjectState) allorsSession.Instantiate(allorsObjectId);		
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



		virtual public global::Allors.Extent<NonSerializedInventoryItem> NonSerializedInventoryItemsWhereCurrentObjectState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.NonSerializedInventoryItemsWhereCurrentObjectState);
			}
		}

		virtual public bool ExistNonSerializedInventoryItemsWhereCurrentObjectState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.NonSerializedInventoryItemsWhereCurrentObjectState);
			}
		}


		virtual public global::Allors.Extent<NonSerializedInventoryItem> NonSerializedInventoryItemsWherePreviousObjectState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.NonSerializedInventoryItemsWherePreviousObjectState);
			}
		}

		virtual public bool ExistNonSerializedInventoryItemsWherePreviousObjectState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.NonSerializedInventoryItemsWherePreviousObjectState);
			}
		}


		virtual public global::Allors.Extent<NonSerializedInventoryItemStatus> NonSerializedInventoryItemStatusesWhereNonSerializedInventoryItemObjectState
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.NonSerializedInventoryItemStatusesWhereNonSerializedInventoryItemObjectState);
			}
		}

		virtual public bool ExistNonSerializedInventoryItemStatusesWhereNonSerializedInventoryItemObjectState
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.NonSerializedInventoryItemStatusesWhereNonSerializedInventoryItemObjectState);
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

	public class NonSerializedInventoryItemObjectStateMeta
	{
		public static readonly NonSerializedInventoryItemObjectStateMeta Instance = new NonSerializedInventoryItemObjectStateMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.NonSerializedInventoryItemObjectState;

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

		public global::Allors.Meta.AssociationType NonSerializedInventoryItemsWhereCurrentObjectState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.NonSerializedInventoryItemCurrentObjectState;
			}
		} 
		public global::Allors.Meta.AssociationType NonSerializedInventoryItemsWherePreviousObjectState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.NonSerializedInventoryItemPreviousObjectState;
			}
		} 
		public global::Allors.Meta.AssociationType NonSerializedInventoryItemStatusesWhereNonSerializedInventoryItemObjectState 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.NonSerializedInventoryItemStatusNonSerializedInventoryItemObjectState;
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