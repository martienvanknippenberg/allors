// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class OperatingCondition : Allors.ObjectBase , PartSpecification
	{
		public static readonly OperatingConditionMeta Meta = OperatingConditionMeta.Instance;

		public OperatingCondition(Allors.IStrategy allors) : base(allors) {}

		public static OperatingCondition Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (OperatingCondition) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public global::Allors.Extent<PartSpecificationStatus> PartSpecificationStatuses
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.PartSpecificationStatus);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.PartSpecificationStatus, value);
			}
		}

		virtual public void AddPartSpecificationStatus (PartSpecificationStatus value)
		{
			Strategy.AddCompositeRole(Meta.PartSpecificationStatus, value);
		}

		virtual public void RemovePartSpecificationStatus (PartSpecificationStatus value)
		{
			Strategy.RemoveCompositeRole(Meta.PartSpecificationStatus,value);
		}

		virtual public bool ExistPartSpecificationStatuses
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.PartSpecificationStatus);
			}
		}

		virtual public void RemovePartSpecificationStatuses()
		{
			Strategy.RemoveCompositeRoles(Meta.PartSpecificationStatus);
		}


		virtual public PartSpecificationObjectState CurrentObjectState
		{ 
			get
			{
				return (PartSpecificationObjectState) Strategy.GetCompositeRole(Meta.CurrentObjectState);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.CurrentObjectState ,value);
			}
		}

		virtual public bool ExistCurrentObjectState
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.CurrentObjectState);
			}
		}

		virtual public void RemoveCurrentObjectState()
		{
			Strategy.RemoveCompositeRole(Meta.CurrentObjectState);
		}



		virtual public global::System.DateTime DocumentationDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.DocumentationDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.DocumentationDate, value);
			}
		}

		virtual public bool ExistDocumentationDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.DocumentationDate);
			}
		}

		virtual public void RemoveDocumentationDate()
		{
			Strategy.RemoveUnitRole(Meta.DocumentationDate);
		}


		virtual public PartSpecificationStatus CurrentPartSpecificationStatus
		{ 
			get
			{
				return (PartSpecificationStatus) Strategy.GetCompositeRole(Meta.CurrentPartSpecificationStatus);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.CurrentPartSpecificationStatus ,value);
			}
		}

		virtual public bool ExistCurrentPartSpecificationStatus
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.CurrentPartSpecificationStatus);
			}
		}

		virtual public void RemoveCurrentPartSpecificationStatus()
		{
			Strategy.RemoveCompositeRole(Meta.CurrentPartSpecificationStatus);
		}


		virtual public PartSpecificationObjectState PreviousObjectState
		{ 
			get
			{
				return (PartSpecificationObjectState) Strategy.GetCompositeRole(Meta.PreviousObjectState);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.PreviousObjectState ,value);
			}
		}

		virtual public bool ExistPreviousObjectState
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.PreviousObjectState);
			}
		}

		virtual public void RemovePreviousObjectState()
		{
			Strategy.RemoveCompositeRole(Meta.PreviousObjectState);
		}



		virtual public global::System.String Description 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Description);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Description, value);
			}
		}

		virtual public bool ExistDescription{
			get
			{
				return Strategy.ExistUnitRole(Meta.Description);
			}
		}

		virtual public void RemoveDescription()
		{
			Strategy.RemoveUnitRole(Meta.Description);
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



		virtual public Part PartWherePartSpecification
		{ 
			get
			{
				return (Part) Strategy.GetCompositeAssociation(Meta.PartWherePartSpecification);
			}
		} 

		virtual public bool ExistPartWherePartSpecification
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.PartWherePartSpecification);
			}
		}


		virtual public global::Allors.Extent<EngineeringChange> EngineeringChangesWherePartSpecification
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.EngineeringChangesWherePartSpecification);
			}
		}

		virtual public bool ExistEngineeringChangesWherePartSpecification
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.EngineeringChangesWherePartSpecification);
			}
		}

	}

	public class OperatingConditionMeta
	{
		public static readonly OperatingConditionMeta Instance = new OperatingConditionMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.OperatingCondition;

		public global::Allors.Meta.RoleType PartSpecificationStatus 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartSpecificationPartSpecificationStatus;
			}
		} 
		public global::Allors.Meta.RoleType CurrentObjectState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartSpecificationCurrentObjectState;
			}
		} 
		public global::Allors.Meta.RoleType DocumentationDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartSpecificationDocumentationDate;
			}
		} 
		public global::Allors.Meta.RoleType CurrentPartSpecificationStatus 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartSpecificationCurrentPartSpecificationStatus;
			}
		} 
		public global::Allors.Meta.RoleType PreviousObjectState 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartSpecificationPreviousObjectState;
			}
		} 
		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartSpecificationDescription;
			}
		} 
		public global::Allors.Meta.RoleType UniqueId 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UniquelyIdentifiableUniqueId;
			}
		} 
		public global::Allors.Meta.RoleType Comment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommentableComment;
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
		public global::Allors.Meta.RoleType DisplayName 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UserInterfaceableDisplayName;
			}
		} 

		public global::Allors.Meta.AssociationType PartWherePartSpecification 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartPartSpecification;
			}
		} 
		public global::Allors.Meta.AssociationType EngineeringChangesWherePartSpecification 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.EngineeringChangePartSpecification;
			}
		} 

		public global::Allors.Meta.MethodType Approve 
		{
			get
			{
				return global::Allors.Meta.MethodTypes.PartSpecificationApprove;
			}
		} 

	}
}