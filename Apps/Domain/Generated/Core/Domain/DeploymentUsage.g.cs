// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface DeploymentUsage :  UserInterfaceable,Commentable,Period, Allors.IObjectBase
	{


		TimeFrequency TimeFrequency
		{ 
			get;
			set;
		}

		bool ExistTimeFrequency
		{
			get;
		}

		void RemoveTimeFrequency();



		global::Allors.Extent<Deployment> DeploymentsWhereDeploymentUsage
		{ 
			get;
		}

		bool ExistDeploymentsWhereDeploymentUsage
		{
			get;
		}

	}

	public class DeploymentUsageMeta
	{
		public static readonly DeploymentUsageMeta Instance = new DeploymentUsageMeta();

		public global::Allors.Meta.Interface ObjectType = global::Allors.Meta.Interfaces.DeploymentUsage;

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