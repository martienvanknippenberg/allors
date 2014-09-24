// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class Position : Allors.ObjectBase , UserInterfaceable, SearchResult, Searchable
	{
		public static readonly PositionMeta Meta = PositionMeta.Instance;

		public Position(Allors.IStrategy allors) : base(allors) {}

		public static Position Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (Position) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public Organisation Organisation
		{ 
			get
			{
				return (Organisation) Strategy.GetCompositeRole(Meta.Organisation);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Organisation ,value);
			}
		}

		virtual public bool ExistOrganisation
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Organisation);
			}
		}

		virtual public void RemoveOrganisation()
		{
			Strategy.RemoveCompositeRole(Meta.Organisation);
		}



		virtual public global::System.Boolean Temporary 
		{
			get
			{
				return (global::System.Boolean) Strategy.GetUnitRole(Meta.Temporary);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Temporary, value);
			}
		}

		virtual public bool ExistTemporary{
			get
			{
				return Strategy.ExistUnitRole(Meta.Temporary);
			}
		}

		virtual public void RemoveTemporary()
		{
			Strategy.RemoveUnitRole(Meta.Temporary);
		}



		virtual public global::System.DateTime EstimatedThroughDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.EstimatedThroughDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.EstimatedThroughDate, value);
			}
		}

		virtual public bool ExistEstimatedThroughDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.EstimatedThroughDate);
			}
		}

		virtual public void RemoveEstimatedThroughDate()
		{
			Strategy.RemoveUnitRole(Meta.EstimatedThroughDate);
		}



		virtual public global::System.DateTime EstimatedFromDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.EstimatedFromDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.EstimatedFromDate, value);
			}
		}

		virtual public bool ExistEstimatedFromDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.EstimatedFromDate);
			}
		}

		virtual public void RemoveEstimatedFromDate()
		{
			Strategy.RemoveUnitRole(Meta.EstimatedFromDate);
		}


		virtual public PositionType PositionType
		{ 
			get
			{
				return (PositionType) Strategy.GetCompositeRole(Meta.PositionType);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.PositionType ,value);
			}
		}

		virtual public bool ExistPositionType
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.PositionType);
			}
		}

		virtual public void RemovePositionType()
		{
			Strategy.RemoveCompositeRole(Meta.PositionType);
		}



		virtual public global::System.Boolean Fulltime 
		{
			get
			{
				return (global::System.Boolean) Strategy.GetUnitRole(Meta.Fulltime);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Fulltime, value);
			}
		}

		virtual public bool ExistFulltime{
			get
			{
				return Strategy.ExistUnitRole(Meta.Fulltime);
			}
		}

		virtual public void RemoveFulltime()
		{
			Strategy.RemoveUnitRole(Meta.Fulltime);
		}



		virtual public global::System.Boolean Salary 
		{
			get
			{
				return (global::System.Boolean) Strategy.GetUnitRole(Meta.Salary);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Salary, value);
			}
		}

		virtual public bool ExistSalary{
			get
			{
				return Strategy.ExistUnitRole(Meta.Salary);
			}
		}

		virtual public void RemoveSalary()
		{
			Strategy.RemoveUnitRole(Meta.Salary);
		}


		virtual public PositionStatus PositionStatus
		{ 
			get
			{
				return (PositionStatus) Strategy.GetCompositeRole(Meta.PositionStatus);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.PositionStatus ,value);
			}
		}

		virtual public bool ExistPositionStatus
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.PositionStatus);
			}
		}

		virtual public void RemovePositionStatus()
		{
			Strategy.RemoveCompositeRole(Meta.PositionStatus);
		}


		virtual public BudgetItem ApprovedBudgetItem
		{ 
			get
			{
				return (BudgetItem) Strategy.GetCompositeRole(Meta.ApprovedBudgetItem);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.ApprovedBudgetItem ,value);
			}
		}

		virtual public bool ExistApprovedBudgetItem
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.ApprovedBudgetItem);
			}
		}

		virtual public void RemoveApprovedBudgetItem()
		{
			Strategy.RemoveCompositeRole(Meta.ApprovedBudgetItem);
		}



		virtual public global::System.DateTime ActualFromDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.ActualFromDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ActualFromDate, value);
			}
		}

		virtual public bool ExistActualFromDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.ActualFromDate);
			}
		}

		virtual public void RemoveActualFromDate()
		{
			Strategy.RemoveUnitRole(Meta.ActualFromDate);
		}



		virtual public global::System.DateTime ActualThroughDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.ActualThroughDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.ActualThroughDate, value);
			}
		}

		virtual public bool ExistActualThroughDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.ActualThroughDate);
			}
		}

		virtual public void RemoveActualThroughDate()
		{
			Strategy.RemoveUnitRole(Meta.ActualThroughDate);
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


		virtual public SearchData SearchData
		{ 
			get
			{
				return (SearchData) Strategy.GetCompositeRole(Meta.SearchData);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.SearchData ,value);
			}
		}

		virtual public bool ExistSearchData
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.SearchData);
			}
		}

		virtual public void RemoveSearchData()
		{
			Strategy.RemoveCompositeRole(Meta.SearchData);
		}



		virtual public global::Allors.Extent<EmploymentApplication> EmploymentApplicationsWherePosition
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.EmploymentApplicationsWherePosition);
			}
		}

		virtual public bool ExistEmploymentApplicationsWherePosition
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.EmploymentApplicationsWherePosition);
			}
		}


		virtual public global::Allors.Extent<PositionFulfillment> PositionFulfillmentsWherePosition
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PositionFulfillmentsWherePosition);
			}
		}

		virtual public bool ExistPositionFulfillmentsWherePosition
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PositionFulfillmentsWherePosition);
			}
		}


		virtual public global::Allors.Extent<PerformanceReview> PerformanceReviewsWhereResultingPosition
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PerformanceReviewsWhereResultingPosition);
			}
		}

		virtual public bool ExistPerformanceReviewsWhereResultingPosition
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PerformanceReviewsWhereResultingPosition);
			}
		}


		virtual public global::Allors.Extent<PositionResponsibility> PositionResponsibilitiesWherePosition
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PositionResponsibilitiesWherePosition);
			}
		}

		virtual public bool ExistPositionResponsibilitiesWherePosition
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PositionResponsibilitiesWherePosition);
			}
		}


		virtual public global::Allors.Extent<PositionReportingStructure> PositionReportingStructuresWhereManagedByPosition
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PositionReportingStructuresWhereManagedByPosition);
			}
		}

		virtual public bool ExistPositionReportingStructuresWhereManagedByPosition
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PositionReportingStructuresWhereManagedByPosition);
			}
		}


		virtual public global::Allors.Extent<PositionReportingStructure> PositionReportingStructuresWherePosition
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PositionReportingStructuresWherePosition);
			}
		}

		virtual public bool ExistPositionReportingStructuresWherePosition
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PositionReportingStructuresWherePosition);
			}
		}

	}

	public class PositionMeta
	{
		public static readonly PositionMeta Instance = new PositionMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.Position;

		public global::Allors.Meta.RoleType Organisation 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PositionOrganisation;
			}
		} 
		public global::Allors.Meta.RoleType Temporary 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PositionTemporary;
			}
		} 
		public global::Allors.Meta.RoleType EstimatedThroughDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PositionEstimatedThroughDate;
			}
		} 
		public global::Allors.Meta.RoleType EstimatedFromDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PositionEstimatedFromDate;
			}
		} 
		public global::Allors.Meta.RoleType PositionType 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PositionPositionType;
			}
		} 
		public global::Allors.Meta.RoleType Fulltime 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PositionFulltime;
			}
		} 
		public global::Allors.Meta.RoleType Salary 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PositionSalary;
			}
		} 
		public global::Allors.Meta.RoleType PositionStatus 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PositionPositionStatus;
			}
		} 
		public global::Allors.Meta.RoleType ApprovedBudgetItem 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PositionApprovedBudgetItem;
			}
		} 
		public global::Allors.Meta.RoleType ActualFromDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PositionActualFromDate;
			}
		} 
		public global::Allors.Meta.RoleType ActualThroughDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PositionActualThroughDate;
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
		public global::Allors.Meta.RoleType SearchData 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SearchableSearchData;
			}
		} 

		public global::Allors.Meta.AssociationType EmploymentApplicationsWherePosition 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.EmploymentApplicationPosition;
			}
		} 
		public global::Allors.Meta.AssociationType PositionFulfillmentsWherePosition 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PositionFulfillmentPosition;
			}
		} 
		public global::Allors.Meta.AssociationType PerformanceReviewsWhereResultingPosition 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PerformanceReviewResultingPosition;
			}
		} 
		public global::Allors.Meta.AssociationType PositionResponsibilitiesWherePosition 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PositionResponsibilityPosition;
			}
		} 
		public global::Allors.Meta.AssociationType PositionReportingStructuresWhereManagedByPosition 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PositionReportingStructureManagedByPosition;
			}
		} 
		public global::Allors.Meta.AssociationType PositionReportingStructuresWherePosition 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PositionReportingStructurePosition;
			}
		} 

	}
}