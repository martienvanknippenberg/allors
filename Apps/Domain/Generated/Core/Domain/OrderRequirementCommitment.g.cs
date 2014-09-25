// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class OrderRequirementCommitment : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly OrderRequirementCommitmentMeta Meta = OrderRequirementCommitmentMeta.Instance;

		public OrderRequirementCommitment(Allors.IStrategy allors) : base(allors) {}

		public static OrderRequirementCommitment Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (OrderRequirementCommitment) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.Int32 Quantity 
		{
			get
			{
				return (global::System.Int32) Strategy.GetUnitRole(Meta.Quantity);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Quantity, value);
			}
		}

		virtual public bool ExistQuantity{
			get
			{
				return Strategy.ExistUnitRole(Meta.Quantity);
			}
		}

		virtual public void RemoveQuantity()
		{
			Strategy.RemoveUnitRole(Meta.Quantity);
		}


		virtual public OrderItem OrderItem
		{ 
			get
			{
				return (OrderItem) Strategy.GetCompositeRole(Meta.OrderItem);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.OrderItem ,value);
			}
		}

		virtual public bool ExistOrderItem
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.OrderItem);
			}
		}

		virtual public void RemoveOrderItem()
		{
			Strategy.RemoveCompositeRole(Meta.OrderItem);
		}


		virtual public Requirement Requirement
		{ 
			get
			{
				return (Requirement) Strategy.GetCompositeRole(Meta.Requirement);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Requirement ,value);
			}
		}

		virtual public bool ExistRequirement
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Requirement);
			}
		}

		virtual public void RemoveRequirement()
		{
			Strategy.RemoveCompositeRole(Meta.Requirement);
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

	}

	public class OrderRequirementCommitmentMeta
	{
		public static readonly OrderRequirementCommitmentMeta Instance = new OrderRequirementCommitmentMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.OrderRequirementCommitment;

		public global::Allors.Meta.RoleType Quantity 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderRequirementCommitmentQuantity;
			}
		} 
		public global::Allors.Meta.RoleType OrderItem 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderRequirementCommitmentOrderItem;
			}
		} 
		public global::Allors.Meta.RoleType Requirement 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderRequirementCommitmentRequirement;
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

	}
}