// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class PartSpecificationStatus : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly PartSpecificationStatusMeta Meta = PartSpecificationStatusMeta.Instance;

		public PartSpecificationStatus(Allors.IStrategy allors) : base(allors) {}

		public static PartSpecificationStatus Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (PartSpecificationStatus) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.DateTime? StartDateTime 
		{
			get
			{
				return (global::System.DateTime?) Strategy.GetUnitRole(Meta.StartDateTime);
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


		virtual public PartSpecificationObjectState PartSpecificationObjectState
		{ 
			get
			{
				return (PartSpecificationObjectState) Strategy.GetCompositeRole(Meta.PartSpecificationObjectState);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.PartSpecificationObjectState ,value);
			}
		}

		virtual public bool ExistPartSpecificationObjectState
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.PartSpecificationObjectState);
			}
		}

		virtual public void RemovePartSpecificationObjectState()
		{
			Strategy.RemoveCompositeRole(Meta.PartSpecificationObjectState);
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



		virtual public PartSpecification PartSpecificationWherePartSpecificationStatus
		{ 
			get
			{
				return (PartSpecification) Strategy.GetCompositeAssociation(Meta.PartSpecificationWherePartSpecificationStatus);
			}
		} 

		virtual public bool ExistPartSpecificationWherePartSpecificationStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.PartSpecificationWherePartSpecificationStatus);
			}
		}


		virtual public PartSpecification PartSpecificationWhereCurrentPartSpecificationStatus
		{ 
			get
			{
				return (PartSpecification) Strategy.GetCompositeAssociation(Meta.PartSpecificationWhereCurrentPartSpecificationStatus);
			}
		} 

		virtual public bool ExistPartSpecificationWhereCurrentPartSpecificationStatus
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.PartSpecificationWhereCurrentPartSpecificationStatus);
			}
		}

	}

	public class PartSpecificationStatusMeta
	{
		public static readonly PartSpecificationStatusMeta Instance = new PartSpecificationStatusMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.PartSpecificationStatus;

		public global::Allors.Meta.RoleType StartDateTime 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartSpecificationStatusStartDateTime;
			}
		} 
		public global::Allors.Meta.RoleType PartSpecificationObjectState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartSpecificationStatusPartSpecificationObjectState;
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

		public global::Allors.Meta.AssociationType PartSpecificationWherePartSpecificationStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartSpecificationPartSpecificationStatus;
			}
		} 
		public global::Allors.Meta.AssociationType PartSpecificationWhereCurrentPartSpecificationStatus 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartSpecificationCurrentPartSpecificationStatus;
			}
		} 

	}
}