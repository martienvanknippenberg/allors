// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class ManufacturingBom : Allors.ObjectBase , PartBillOfMaterial
	{
		public static readonly ManufacturingBomMeta Meta = ManufacturingBomMeta.Instance;

		public ManufacturingBom(Allors.IStrategy allors) : base(allors) {}

		public static ManufacturingBom Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (ManufacturingBom) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public Part Part
		{ 
			get
			{
				return (Part) Strategy.GetCompositeRole(Meta.Part);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Part ,value);
			}
		}

		virtual public bool ExistPart
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Part);
			}
		}

		virtual public void RemovePart()
		{
			Strategy.RemoveCompositeRole(Meta.Part);
		}



		virtual public global::System.String Instruction 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Instruction);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Instruction, value);
			}
		}

		virtual public bool ExistInstruction{
			get
			{
				return Strategy.ExistUnitRole(Meta.Instruction);
			}
		}

		virtual public void RemoveInstruction()
		{
			Strategy.RemoveUnitRole(Meta.Instruction);
		}



		virtual public global::System.Int32 QuantityUsed 
		{
			get
			{
				return (global::System.Int32) Strategy.GetUnitRole(Meta.QuantityUsed);
			}
			set
			{
				Strategy.SetUnitRole(Meta.QuantityUsed, value);
			}
		}

		virtual public bool ExistQuantityUsed{
			get
			{
				return Strategy.ExistUnitRole(Meta.QuantityUsed);
			}
		}

		virtual public void RemoveQuantityUsed()
		{
			Strategy.RemoveUnitRole(Meta.QuantityUsed);
		}


		virtual public Part ComponentPart
		{ 
			get
			{
				return (Part) Strategy.GetCompositeRole(Meta.ComponentPart);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.ComponentPart ,value);
			}
		}

		virtual public bool ExistComponentPart
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.ComponentPart);
			}
		}

		virtual public void RemoveComponentPart()
		{
			Strategy.RemoveCompositeRole(Meta.ComponentPart);
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



		virtual public global::System.DateTime FromDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.FromDate);
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



		virtual public global::System.DateTime ThroughDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.ThroughDate);
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



		virtual public global::Allors.Extent<PartBillOfMaterialSubstitute> PartBillOfMaterialSubstitutesWhereSubstitutionPartBillOfMaterial
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartBillOfMaterialSubstitutesWhereSubstitutionPartBillOfMaterial);
			}
		}

		virtual public bool ExistPartBillOfMaterialSubstitutesWhereSubstitutionPartBillOfMaterial
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartBillOfMaterialSubstitutesWhereSubstitutionPartBillOfMaterial);
			}
		}


		virtual public global::Allors.Extent<PartBillOfMaterialSubstitute> PartBillOfMaterialSubstitutesWherePartBillOfMaterial
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartBillOfMaterialSubstitutesWherePartBillOfMaterial);
			}
		}

		virtual public bool ExistPartBillOfMaterialSubstitutesWherePartBillOfMaterial
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartBillOfMaterialSubstitutesWherePartBillOfMaterial);
			}
		}


		virtual public global::Allors.Extent<EngineeringChange> EngineeringChangesWherePartBillOfMaterial
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.EngineeringChangesWherePartBillOfMaterial);
			}
		}

		virtual public bool ExistEngineeringChangesWherePartBillOfMaterial
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.EngineeringChangesWherePartBillOfMaterial);
			}
		}

	}

	public class ManufacturingBomMeta
	{
		public static readonly ManufacturingBomMeta Instance = new ManufacturingBomMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.ManufacturingBom;

		public global::Allors.Meta.RoleType Part 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartBillOfMaterialPart;
			}
		} 
		public global::Allors.Meta.RoleType Instruction 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartBillOfMaterialInstruction;
			}
		} 
		public global::Allors.Meta.RoleType QuantityUsed 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartBillOfMaterialQuantityUsed;
			}
		} 
		public global::Allors.Meta.RoleType ComponentPart 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PartBillOfMaterialComponentPart;
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
		public global::Allors.Meta.RoleType SearchData 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SearchableSearchData;
			}
		} 

		public global::Allors.Meta.AssociationType PartBillOfMaterialSubstitutesWhereSubstitutionPartBillOfMaterial 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartBillOfMaterialSubstituteSubstitutionPartBillOfMaterial;
			}
		} 
		public global::Allors.Meta.AssociationType PartBillOfMaterialSubstitutesWherePartBillOfMaterial 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartBillOfMaterialSubstitutePartBillOfMaterial;
			}
		} 
		public global::Allors.Meta.AssociationType EngineeringChangesWherePartBillOfMaterial 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.EngineeringChangePartBillOfMaterial;
			}
		} 

	}
}