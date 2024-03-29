// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class ShipmentRouteSegment : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly ShipmentRouteSegmentMeta Meta = ShipmentRouteSegmentMeta.Instance;

		public ShipmentRouteSegment(Allors.IStrategy allors) : base(allors) {}

		public static ShipmentRouteSegment Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (ShipmentRouteSegment) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.Decimal EndKilometers 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.EndKilometers);
			}
			set
			{
				Strategy.SetUnitRole(Meta.EndKilometers, value);
			}
		}

		virtual public bool ExistEndKilometers{
			get
			{
				return Strategy.ExistUnitRole(Meta.EndKilometers);
			}
		}

		virtual public void RemoveEndKilometers()
		{
			Strategy.RemoveUnitRole(Meta.EndKilometers);
		}


		virtual public Facility FromFacility
		{ 
			get
			{
				return (Facility) Strategy.GetCompositeRole(Meta.FromFacility);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.FromFacility ,value);
			}
		}

		virtual public bool ExistFromFacility
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.FromFacility);
			}
		}

		virtual public void RemoveFromFacility()
		{
			Strategy.RemoveCompositeRole(Meta.FromFacility);
		}



		virtual public global::System.Decimal StartKilometers 
		{
			get
			{
				return (global::System.Decimal) Strategy.GetUnitRole(Meta.StartKilometers);
			}
			set
			{
				Strategy.SetUnitRole(Meta.StartKilometers, value);
			}
		}

		virtual public bool ExistStartKilometers{
			get
			{
				return Strategy.ExistUnitRole(Meta.StartKilometers);
			}
		}

		virtual public void RemoveStartKilometers()
		{
			Strategy.RemoveUnitRole(Meta.StartKilometers);
		}


		virtual public ShipmentMethod ShipmentMethod
		{ 
			get
			{
				return (ShipmentMethod) Strategy.GetCompositeRole(Meta.ShipmentMethod);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.ShipmentMethod ,value);
			}
		}

		virtual public bool ExistShipmentMethod
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.ShipmentMethod);
			}
		}

		virtual public void RemoveShipmentMethod()
		{
			Strategy.RemoveCompositeRole(Meta.ShipmentMethod);
		}



		virtual public global::System.DateTime EstimatedStartDateTime 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.EstimatedStartDateTime);
			}
			set
			{
				Strategy.SetUnitRole(Meta.EstimatedStartDateTime, value);
			}
		}

		virtual public bool ExistEstimatedStartDateTime{
			get
			{
				return Strategy.ExistUnitRole(Meta.EstimatedStartDateTime);
			}
		}

		virtual public void RemoveEstimatedStartDateTime()
		{
			Strategy.RemoveUnitRole(Meta.EstimatedStartDateTime);
		}


		virtual public Facility ToFacility
		{ 
			get
			{
				return (Facility) Strategy.GetCompositeRole(Meta.ToFacility);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.ToFacility ,value);
			}
		}

		virtual public bool ExistToFacility
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.ToFacility);
			}
		}

		virtual public void RemoveToFacility()
		{
			Strategy.RemoveCompositeRole(Meta.ToFacility);
		}



		virtual public global::System.DateTime EstimatedArrivalDateTime 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.EstimatedArrivalDateTime);
			}
			set
			{
				Strategy.SetUnitRole(Meta.EstimatedArrivalDateTime, value);
			}
		}

		virtual public bool ExistEstimatedArrivalDateTime{
			get
			{
				return Strategy.ExistUnitRole(Meta.EstimatedArrivalDateTime);
			}
		}

		virtual public void RemoveEstimatedArrivalDateTime()
		{
			Strategy.RemoveUnitRole(Meta.EstimatedArrivalDateTime);
		}


		virtual public Vehicle Vehicle
		{ 
			get
			{
				return (Vehicle) Strategy.GetCompositeRole(Meta.Vehicle);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Vehicle ,value);
			}
		}

		virtual public bool ExistVehicle
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Vehicle);
			}
		}

		virtual public void RemoveVehicle()
		{
			Strategy.RemoveCompositeRole(Meta.Vehicle);
		}



		virtual public global::System.DateTime ActualArrivalDateTime 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.ActualArrivalDateTime);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ActualArrivalDateTime, value);
			}
		}

		virtual public bool ExistActualArrivalDateTime{
			get
			{
				return Strategy.ExistUnitRole(Meta.ActualArrivalDateTime);
			}
		}

		virtual public void RemoveActualArrivalDateTime()
		{
			Strategy.RemoveUnitRole(Meta.ActualArrivalDateTime);
		}



		virtual public global::System.DateTime ActualStartDateTime 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.ActualStartDateTime);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ActualStartDateTime, value);
			}
		}

		virtual public bool ExistActualStartDateTime{
			get
			{
				return Strategy.ExistUnitRole(Meta.ActualStartDateTime);
			}
		}

		virtual public void RemoveActualStartDateTime()
		{
			Strategy.RemoveUnitRole(Meta.ActualStartDateTime);
		}


		virtual public Organisation Carrier
		{ 
			get
			{
				return (Organisation) Strategy.GetCompositeRole(Meta.Carrier);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Carrier ,value);
			}
		}

		virtual public bool ExistCarrier
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Carrier);
			}
		}

		virtual public void RemoveCarrier()
		{
			Strategy.RemoveCompositeRole(Meta.Carrier);
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



		virtual public Shipment ShipmentWhereShipmentRouteSegment
		{ 
			get
			{
				return (Shipment) Strategy.GetCompositeAssociation(Meta.ShipmentWhereShipmentRouteSegment);
			}
		} 

		virtual public bool ExistShipmentWhereShipmentRouteSegment
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.ShipmentWhereShipmentRouteSegment);
			}
		}

	}

	public class ShipmentRouteSegmentMeta
	{
		public static readonly ShipmentRouteSegmentMeta Instance = new ShipmentRouteSegmentMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.ShipmentRouteSegment;

		public global::Allors.Meta.RoleType EndKilometers 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentRouteSegmentEndKilometers;
			}
		} 
		public global::Allors.Meta.RoleType FromFacility 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentRouteSegmentFromFacility;
			}
		} 
		public global::Allors.Meta.RoleType StartKilometers 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentRouteSegmentStartKilometers;
			}
		} 
		public global::Allors.Meta.RoleType ShipmentMethod 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentRouteSegmentShipmentMethod;
			}
		} 
		public global::Allors.Meta.RoleType EstimatedStartDateTime 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentRouteSegmentEstimatedStartDateTime;
			}
		} 
		public global::Allors.Meta.RoleType ToFacility 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentRouteSegmentToFacility;
			}
		} 
		public global::Allors.Meta.RoleType EstimatedArrivalDateTime 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentRouteSegmentEstimatedArrivalDateTime;
			}
		} 
		public global::Allors.Meta.RoleType Vehicle 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentRouteSegmentVehicle;
			}
		} 
		public global::Allors.Meta.RoleType ActualArrivalDateTime 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentRouteSegmentActualArrivalDateTime;
			}
		} 
		public global::Allors.Meta.RoleType ActualStartDateTime 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentRouteSegmentActualStartDateTime;
			}
		} 
		public global::Allors.Meta.RoleType Carrier 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentRouteSegmentCarrier;
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

		public global::Allors.Meta.AssociationType ShipmentWhereShipmentRouteSegment 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ShipmentShipmentRouteSegment;
			}
		} 

	}
}