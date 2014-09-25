// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class EngineeringChangeStatus : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly EngineeringChangeStatusMeta Meta = EngineeringChangeStatusMeta.Instance;

		public EngineeringChangeStatus(Allors.IStrategy allors) : base(allors) {}

		public static EngineeringChangeStatus Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (EngineeringChangeStatus) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.DateTime StartDateTime 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.StartDateTime);
			}
			set
			{
				Strategy.SetUnitRole(Meta.StartDateTime, value);
			}
		}

		virtual public bool ExistStartDateTime{
			get
			{
				return Strategy.ExistUnitRole(Meta.StartDateTime);
			}
		}

		virtual public void RemoveStartDateTime()
		{
			Strategy.RemoveUnitRole(Meta.StartDateTime);
		}


		virtual public EngineeringChangeObjectState EngineeringChangeObjectState
		{ 
			get
			{
				return (EngineeringChangeObjectState) Strategy.GetCompositeRole(Meta.EngineeringChangeObjectState);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.EngineeringChangeObjectState ,value);
			}
		}

		virtual public bool ExistEngineeringChangeObjectState
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.EngineeringChangeObjectState);
			}
		}

		virtual public void RemoveEngineeringChangeObjectState()
		{
			Strategy.RemoveCompositeRole(Meta.EngineeringChangeObjectState);
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



		virtual public EngineeringChange EngineeringChangeWhereEngineeringChangeStatus
		{ 
			get
			{
				return (EngineeringChange) Strategy.GetCompositeAssociation(Meta.EngineeringChangeWhereEngineeringChangeStatus);
			}
		} 

		virtual public bool ExistEngineeringChangeWhereEngineeringChangeStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.EngineeringChangeWhereEngineeringChangeStatus);
			}
		}


		virtual public EngineeringChange EngineeringChangeWhereCurrentEngineeringChangeStatus
		{ 
			get
			{
				return (EngineeringChange) Strategy.GetCompositeAssociation(Meta.EngineeringChangeWhereCurrentEngineeringChangeStatus);
			}
		} 

		virtual public bool ExistEngineeringChangeWhereCurrentEngineeringChangeStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.EngineeringChangeWhereCurrentEngineeringChangeStatus);
			}
		}

	}

	public class EngineeringChangeStatusMeta
	{
		public static readonly EngineeringChangeStatusMeta Instance = new EngineeringChangeStatusMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.EngineeringChangeStatus;

		public global::Allors.Meta.RoleType StartDateTime 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EngineeringChangeStatusStartDateTime;
			}
		} 
		public global::Allors.Meta.RoleType EngineeringChangeObjectState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EngineeringChangeStatusEngineeringChangeObjectState;
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

		public global::Allors.Meta.AssociationType EngineeringChangeWhereEngineeringChangeStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.EngineeringChangeEngineeringChangeStatus;
			}
		} 
		public global::Allors.Meta.AssociationType EngineeringChangeWhereCurrentEngineeringChangeStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.EngineeringChangeCurrentEngineeringChangeStatus;
			}
		} 

	}
}