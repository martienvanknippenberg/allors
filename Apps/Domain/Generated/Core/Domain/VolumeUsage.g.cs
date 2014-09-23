// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class VolumeUsage : Allors.ObjectBase , DeploymentUsage
	{
		public static readonly VolumeUsageMeta Meta = VolumeUsageMeta.Instance;

		public VolumeUsage(Allors.IStrategy allors) : base(allors) {}

		public static VolumeUsage Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (VolumeUsage) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.Decimal? Quantity 
		{
			get
			{
				return (global::System.Decimal?) Strategy.GetUnitRole(Meta.Quantity);
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


		virtual public UnitOfMeasure UnitOfMeasure
		{ 
			get
			{
				return (UnitOfMeasure) Strategy.GetCompositeRole(Meta.UnitOfMeasure);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.UnitOfMeasure ,value);
			}
		}

		virtual public bool ExistUnitOfMeasure
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.UnitOfMeasure);
			}
		}

		virtual public void RemoveUnitOfMeasure()
		{
			Strategy.RemoveCompositeRole(Meta.UnitOfMeasure);
		}


		virtual public TimeFrequency TimeFrequency
		{ 
			get
			{
				return (TimeFrequency) Strategy.GetCompositeRole(Meta.TimeFrequency);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.TimeFrequency ,value);
			}
		}

		virtual public bool ExistTimeFrequency
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.TimeFrequency);
			}
		}

		virtual public void RemoveTimeFrequency()
		{
			Strategy.RemoveCompositeRole(Meta.TimeFrequency);
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



		virtual public global::System.DateTime? FromDate 
		{
			get
			{
				return (global::System.DateTime?) Strategy.GetUnitRole(Meta.FromDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.FromDate, value);
			}
		}

		virtual public bool ExistFromDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.FromDate);
			}
		}

		virtual public void RemoveFromDate()
		{
			Strategy.RemoveUnitRole(Meta.FromDate);
		}



		virtual public global::System.DateTime? ThroughDate 
		{
			get
			{
				return (global::System.DateTime?) Strategy.GetUnitRole(Meta.ThroughDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ThroughDate, value);
			}
		}

		virtual public bool ExistThroughDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.ThroughDate);
			}
		}

		virtual public void RemoveThroughDate()
		{
			Strategy.RemoveUnitRole(Meta.ThroughDate);
		}



		virtual public global::Allors.Extent<Deployment> DeploymentsWhereDeploymentUsage
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.DeploymentsWhereDeploymentUsage);
			}
		}

		virtual public bool ExistDeploymentsWhereDeploymentUsage
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.DeploymentsWhereDeploymentUsage);
			}
		}

	}

	public class VolumeUsageMeta
	{
		public static readonly VolumeUsageMeta Instance = new VolumeUsageMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.VolumeUsage;

		public global::Allors.Meta.RoleType Quantity 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.VolumeUsageQuantity;
			}
		} 
		public global::Allors.Meta.RoleType UnitOfMeasure 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.VolumeUsageUnitOfMeasure;
			}
		} 
		public global::Allors.Meta.RoleType TimeFrequency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.DeploymentUsageTimeFrequency;
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
		public global::Allors.Meta.RoleType Comment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommentableComment;
			}
		} 
		public global::Allors.Meta.RoleType FromDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PeriodFromDate;
			}
		} 
		public global::Allors.Meta.RoleType ThroughDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PeriodThroughDate;
			}
		} 

		public global::Allors.Meta.AssociationType DeploymentsWhereDeploymentUsage 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.DeploymentDeploymentUsage;
			}
		} 

	}
}