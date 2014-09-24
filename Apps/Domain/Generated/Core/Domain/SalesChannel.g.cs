// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class SalesChannel : Allors.ObjectBase , Searchable, Enumeration
	{
		public static readonly SalesChannelMeta Meta = SalesChannelMeta.Instance;

		public SalesChannel(Allors.IStrategy allors) : base(allors) {}

		public static SalesChannel Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (SalesChannel) allorsSession.Instantiate(allorsObjectId);		
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


		virtual public global::Allors.Extent<LocalisedText> LocalisedNames
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.LocalisedName);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.LocalisedName, value);
			}
		}

		virtual public void AddLocalisedName (LocalisedText value)
		{
			Strategy.AddCompositeRole(Meta.LocalisedName, value);
		}

		virtual public void RemoveLocalisedName (LocalisedText value)
		{
			Strategy.RemoveCompositeRole(Meta.LocalisedName,value);
		}

		virtual public bool ExistLocalisedNames
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.LocalisedName);
			}
		}

		virtual public void RemoveLocalisedNames()
		{
			Strategy.RemoveCompositeRoles(Meta.LocalisedName);
		}



		virtual public global::System.Boolean IsActive 
		{
			get
			{
				return (global::System.Boolean) Strategy.GetUnitRole(Meta.IsActive);
			}
			set
			{
				Strategy.SetUnitRole(Meta.IsActive, value);
			}
		}

		virtual public bool ExistIsActive{
			get
			{
				return Strategy.ExistUnitRole(Meta.IsActive);
			}
		}

		virtual public void RemoveIsActive()
		{
			Strategy.RemoveUnitRole(Meta.IsActive);
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



		virtual public global::Allors.Extent<SalesChannelRevenue> SalesChannelRevenuesWhereSalesChannel
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesChannelRevenuesWhereSalesChannel);
			}
		}

		virtual public bool ExistSalesChannelRevenuesWhereSalesChannel
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesChannelRevenuesWhereSalesChannel);
			}
		}


		virtual public global::Allors.Extent<SalesChannelRevenueHistory> SalesChannelRevenueHistoriesWhereSalesChannel
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesChannelRevenueHistoriesWhereSalesChannel);
			}
		}

		virtual public bool ExistSalesChannelRevenueHistoriesWhereSalesChannel
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesChannelRevenueHistoriesWhereSalesChannel);
			}
		}


		virtual public global::Allors.Extent<PriceComponent> PriceComponentsWhereSalesChannel
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PriceComponentsWhereSalesChannel);
			}
		}

		virtual public bool ExistPriceComponentsWhereSalesChannel
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PriceComponentsWhereSalesChannel);
			}
		}


		virtual public global::Allors.Extent<SalesInvoice> SalesInvoicesWhereSalesChannel
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesInvoicesWhereSalesChannel);
			}
		}

		virtual public bool ExistSalesInvoicesWhereSalesChannel
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesInvoicesWhereSalesChannel);
			}
		}


		virtual public global::Allors.Extent<SalesOrder> SalesOrdersWhereSalesChannel
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SalesOrdersWhereSalesChannel);
			}
		}

		virtual public bool ExistSalesOrdersWhereSalesChannel
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SalesOrdersWhereSalesChannel);
			}
		}

	}

	public class SalesChannelMeta
	{
		public static readonly SalesChannelMeta Instance = new SalesChannelMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.SalesChannel;

		public global::Allors.Meta.RoleType SearchData 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SearchableSearchData;
			}
		} 
		public global::Allors.Meta.RoleType LocalisedName 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EnumerationLocalisedName;
			}
		} 
		public global::Allors.Meta.RoleType IsActive 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EnumerationIsActive;
			}
		} 
		public global::Allors.Meta.RoleType Name 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EnumerationName;
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

		public global::Allors.Meta.AssociationType SalesChannelRevenuesWhereSalesChannel 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesChannelRevenueSalesChannel;
			}
		} 
		public global::Allors.Meta.AssociationType SalesChannelRevenueHistoriesWhereSalesChannel 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesChannelRevenueHistorySalesChannel;
			}
		} 
		public global::Allors.Meta.AssociationType PriceComponentsWhereSalesChannel 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PriceComponentSalesChannel;
			}
		} 
		public global::Allors.Meta.AssociationType SalesInvoicesWhereSalesChannel 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesInvoiceSalesChannel;
			}
		} 
		public global::Allors.Meta.AssociationType SalesOrdersWhereSalesChannel 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.SalesOrderSalesChannel;
			}
		} 

	}
}