// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class ShipmentPackage : Allors.ObjectBase , UserInterfaceable, UniquelyIdentifiable, Printable
	{
		public static readonly ShipmentPackageMeta Meta = ShipmentPackageMeta.Instance;

		public ShipmentPackage(Allors.IStrategy allors) : base(allors) {}

		public static ShipmentPackage Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (ShipmentPackage) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public global::Allors.Extent<PackagingContent> PackagingContents
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.PackagingContent);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.PackagingContent, value);
			}
		}

		virtual public void AddPackagingContent (PackagingContent value)
		{
			Strategy.AddCompositeRole(Meta.PackagingContent, value);
		}

		virtual public void RemovePackagingContent (PackagingContent value)
		{
			Strategy.RemoveCompositeRole(Meta.PackagingContent,value);
		}

		virtual public bool ExistPackagingContents
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.PackagingContent);
			}
		}

		virtual public void RemovePackagingContents()
		{
			Strategy.RemoveCompositeRoles(Meta.PackagingContent);
		}


		virtual public global::Allors.Extent<Document> Documents
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.Document);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.Document, value);
			}
		}

		virtual public void AddDocument (Document value)
		{
			Strategy.AddCompositeRole(Meta.Document, value);
		}

		virtual public void RemoveDocument (Document value)
		{
			Strategy.RemoveCompositeRole(Meta.Document,value);
		}

		virtual public bool ExistDocuments
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.Document);
			}
		}

		virtual public void RemoveDocuments()
		{
			Strategy.RemoveCompositeRoles(Meta.Document);
		}



		virtual public global::System.DateTime CreationDate 
		{
			get
			{
				return (global::System.DateTime) Strategy.GetUnitRole(Meta.CreationDate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.CreationDate, value);
			}
		}

		virtual public bool ExistCreationDate{
			get
			{
				return Strategy.ExistUnitRole(Meta.CreationDate);
			}
		}

		virtual public void RemoveCreationDate()
		{
			Strategy.RemoveUnitRole(Meta.CreationDate);
		}



		virtual public global::System.Int32 SequenceNumber 
		{
			get
			{
				return (global::System.Int32) Strategy.GetUnitRole(Meta.SequenceNumber);
			}
			set
			{
				Strategy.SetUnitRole(Meta.SequenceNumber, value);
			}
		}

		virtual public bool ExistSequenceNumber{
			get
			{
				return Strategy.ExistUnitRole(Meta.SequenceNumber);
			}
		}

		virtual public void RemoveSequenceNumber()
		{
			Strategy.RemoveUnitRole(Meta.SequenceNumber);
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



		virtual public Shipment ShipmentWhereShipmentPackage
		{ 
			get
			{
				return (Shipment) Strategy.GetCompositeAssociation(Meta.ShipmentWhereShipmentPackage);
			}
		} 

		virtual public bool ExistShipmentWhereShipmentPackage
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.ShipmentWhereShipmentPackage);
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

	public class ShipmentPackageMeta
	{
		public static readonly ShipmentPackageMeta Instance = new ShipmentPackageMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.ShipmentPackage;

		public global::Allors.Meta.RoleType PackagingContent 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentPackagePackagingContent;
			}
		} 
		public global::Allors.Meta.RoleType Document 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentPackageDocument;
			}
		} 
		public global::Allors.Meta.RoleType CreationDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentPackageCreationDate;
			}
		} 
		public global::Allors.Meta.RoleType SequenceNumber 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ShipmentPackageSequenceNumber;
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
		public global::Allors.Meta.RoleType PrintContent 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PrintablePrintContent;
			}
		} 

		public global::Allors.Meta.AssociationType ShipmentWhereShipmentPackage 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ShipmentShipmentPackage;
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