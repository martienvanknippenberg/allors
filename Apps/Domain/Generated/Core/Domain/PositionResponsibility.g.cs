// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class PositionResponsibility : Allors.ObjectBase , Commentable, UserInterfaceable
	{
		public static readonly PositionResponsibilityMeta Meta = PositionResponsibilityMeta.Instance;

		public PositionResponsibility(Allors.IStrategy allors) : base(allors) {}

		public static PositionResponsibility Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (PositionResponsibility) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public Position Position
		{ 
			get
			{
				return (Position) Strategy.GetCompositeRole(Meta.Position);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Position ,value);
			}
		}

		virtual public bool ExistPosition
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Position);
			}
		}

		virtual public void RemovePosition()
		{
			Strategy.RemoveCompositeRole(Meta.Position);
		}


		virtual public Responsibility Responsibility
		{ 
			get
			{
				return (Responsibility) Strategy.GetCompositeRole(Meta.Responsibility);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Responsibility ,value);
			}
		}

		virtual public bool ExistResponsibility
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Responsibility);
			}
		}

		virtual public void RemoveResponsibility()
		{
			Strategy.RemoveCompositeRole(Meta.Responsibility);
		}



		virtual public global::System.String Comment 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Comment);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Comment, value);
			}
		}

		virtual public bool ExistComment{
			get
			{
				return Strategy.ExistUnitRole(Meta.Comment);
			}
		}

		virtual public void RemoveComment()
		{
			Strategy.RemoveUnitRole(Meta.Comment);
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

	public class PositionResponsibilityMeta
	{
		public static readonly PositionResponsibilityMeta Instance = new PositionResponsibilityMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.PositionResponsibility;

		public global::Allors.Meta.RoleType Position 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PositionResponsibilityPosition;
			}
		} 
		public global::Allors.Meta.RoleType Responsibility 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PositionResponsibilityResponsibility;
			}
		} 
		public global::Allors.Meta.RoleType Comment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommentableComment;
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