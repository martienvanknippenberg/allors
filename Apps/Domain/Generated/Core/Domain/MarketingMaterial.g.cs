// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class MarketingMaterial : Allors.ObjectBase , Document
	{
		public static readonly MarketingMaterialMeta Meta = MarketingMaterialMeta.Instance;

		public MarketingMaterial(Allors.IStrategy allors) : base(allors) {}

		public static MarketingMaterial Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (MarketingMaterial) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.String Name 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Name);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Name, value);
			}
		}

		virtual public bool ExistName{
			get
			{
				return Strategy.ExistUnitRole(Meta.Name);
			}
		}

		virtual public void RemoveName()
		{
			Strategy.RemoveUnitRole(Meta.Name);
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



		virtual public global::System.String Text 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Text);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Text, value);
			}
		}

		virtual public bool ExistText{
			get
			{
				return Strategy.ExistUnitRole(Meta.Text);
			}
		}

		virtual public void RemoveText()
		{
			Strategy.RemoveUnitRole(Meta.Text);
		}



		virtual public global::System.String DocumentLocation 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.DocumentLocation);
			}
			set
			{
				Strategy.SetUnitRole(Meta.DocumentLocation, value);
			}
		}

		virtual public bool ExistDocumentLocation{
			get
			{
				return Strategy.ExistUnitRole(Meta.DocumentLocation);
			}
		}

		virtual public void RemoveDocumentLocation()
		{
			Strategy.RemoveUnitRole(Meta.DocumentLocation);
		}



		virtual public global::System.String PrintContent 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.PrintContent);
			}
			set
			{
				Strategy.SetUnitRole(Meta.PrintContent, value);
			}
		}

		virtual public bool ExistPrintContent{
			get
			{
				return Strategy.ExistUnitRole(Meta.PrintContent);
			}
		}

		virtual public void RemovePrintContent()
		{
			Strategy.RemoveUnitRole(Meta.PrintContent);
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



		virtual public global::System.Guid? UniqueId 
		{
			get
			{
				return (global::System.Guid?) Strategy.GetUnitRole(Meta.UniqueId);
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



		virtual public ShipmentPackage ShipmentPackageWhereDocument
		{ 
			get
			{
				return (ShipmentPackage) Strategy.GetCompositeAssociation(Meta.ShipmentPackageWhereDocument);
			}
		} 

		virtual public bool ExistShipmentPackageWhereDocument
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.ShipmentPackageWhereDocument);
			}
		}


		virtual public global::Allors.Extent<Product> ProductsWhereDocument
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ProductsWhereDocument);
			}
		}

		virtual public bool ExistProductsWhereDocument
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ProductsWhereDocument);
			}
		}


		virtual public global::Allors.Extent<Part> PartsWhereDocument
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PartsWhereDocument);
			}
		}

		virtual public bool ExistPartsWhereDocument
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PartsWhereDocument);
			}
		}


		virtual public Shipment ShipmentWhereDocument
		{ 
			get
			{
				return (Shipment) Strategy.GetCompositeAssociation(Meta.ShipmentWhereDocument);
			}
		} 

		virtual public bool ExistShipmentWhereDocument
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.ShipmentWhereDocument);
			}
		}


		virtual public ShipmentItem ShipmentItemWhereDocument
		{ 
			get
			{
				return (ShipmentItem) Strategy.GetCompositeAssociation(Meta.ShipmentItemWhereDocument);
			}
		} 

		virtual public bool ExistShipmentItemWhereDocument
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.ShipmentItemWhereDocument);
			}
		}


		virtual public global::Allors.Extent<PrintQueue> PrintQueuesWherePrintable
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PrintQueuesWherePrintable);
			}
		}

		virtual public bool ExistPrintQueuesWherePrintable
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PrintQueuesWherePrintable);
			}
		}

	}

	public class MarketingMaterialMeta
	{
		public static readonly MarketingMaterialMeta Instance = new MarketingMaterialMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.MarketingMaterial;

		public global::Allors.Meta.RoleType Name 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.DocumentName;
			}
		} 
		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.DocumentDescription;
			}
		} 
		public global::Allors.Meta.RoleType Text 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.DocumentText;
			}
		} 
		public global::Allors.Meta.RoleType DocumentLocation 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.DocumentDocumentLocation;
			}
		} 
		public global::Allors.Meta.RoleType PrintContent 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PrintablePrintContent;
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
		public global::Allors.Meta.RoleType SearchData 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SearchableSearchData;
			}
		} 

		public global::Allors.Meta.AssociationType ShipmentPackageWhereDocument 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ShipmentPackageDocument;
			}
		} 
		public global::Allors.Meta.AssociationType ProductsWhereDocument 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ProductDocument;
			}
		} 
		public global::Allors.Meta.AssociationType PartsWhereDocument 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PartDocument;
			}
		} 
		public global::Allors.Meta.AssociationType ShipmentWhereDocument 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ShipmentDocument;
			}
		} 
		public global::Allors.Meta.AssociationType ShipmentItemWhereDocument 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ShipmentItemDocument;
			}
		} 
		public global::Allors.Meta.AssociationType PrintQueuesWherePrintable 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PrintQueuePrintable;
			}
		} 

	}
}