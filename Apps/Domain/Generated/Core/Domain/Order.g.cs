// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface Order :  UserInterfaceable,Printable,UniquelyIdentifiable,Transitional,Searchable,Commentable,Localised,SearchResult, Allors.IObjectBase
	{


		Currency CustomerCurrency
		{ 
			get;
			set;
		}

		bool ExistCustomerCurrency
		{
			get;
		}

		void RemoveCustomerCurrency();


		global::System.Decimal TotalBasePriceCustomerCurrency 
		{
			get;
			set;
		}

		bool ExistTotalBasePriceCustomerCurrency{get;}

		void RemoveTotalBasePriceCustomerCurrency();


		global::System.Decimal TotalIncVatCustomerCurrency 
		{
			get;
			set;
		}

		bool ExistTotalIncVatCustomerCurrency{get;}

		void RemoveTotalIncVatCustomerCurrency();


		global::System.Decimal TotalDiscountCustomerCurrency 
		{
			get;
			set;
		}

		bool ExistTotalDiscountCustomerCurrency{get;}

		void RemoveTotalDiscountCustomerCurrency();


		global::System.String CustomerReference 
		{
			get;
			set;
		}

		bool ExistCustomerReference{get;}

		void RemoveCustomerReference();


		Fee Fee
		{ 
			get;
			set;
		}

		bool ExistFee
		{
			get;
		}

		void RemoveFee();


		global::System.Decimal TotalExVat 
		{
			get;
			set;
		}

		bool ExistTotalExVat{get;}

		void RemoveTotalExVat();


		global::Allors.Extent<OrderTerm> OrderTerms
		{ 
			get;
			set;
		}

		void AddOrderTerm (OrderTerm value);

		void RemoveOrderTerm (OrderTerm value);

		bool ExistOrderTerms
		{
			get;
		}

		void RemoveOrderTerms();


		global::System.Decimal TotalVat 
		{
			get;
			set;
		}

		bool ExistTotalVat{get;}

		void RemoveTotalVat();


		global::System.Decimal TotalSurcharge 
		{
			get;
			set;
		}

		bool ExistTotalSurcharge{get;}

		void RemoveTotalSurcharge();


		global::Allors.Extent<OrderItem> ValidOrderItems
		{ 
			get;
			set;
		}

		void AddValidOrderItem (OrderItem value);

		void RemoveValidOrderItem (OrderItem value);

		bool ExistValidOrderItems
		{
			get;
		}

		void RemoveValidOrderItems();


		global::System.String OrderNumber 
		{
			get;
			set;
		}

		bool ExistOrderNumber{get;}

		void RemoveOrderNumber();


		global::System.Decimal TotalVatCustomerCurrency 
		{
			get;
			set;
		}

		bool ExistTotalVatCustomerCurrency{get;}

		void RemoveTotalVatCustomerCurrency();


		global::System.Decimal TotalDiscount 
		{
			get;
			set;
		}

		bool ExistTotalDiscount{get;}

		void RemoveTotalDiscount();


		global::System.String Message 
		{
			get;
			set;
		}

		bool ExistMessage{get;}

		void RemoveMessage();


		global::System.Decimal TotalShippingAndHandlingCustomerCurrency 
		{
			get;
			set;
		}

		bool ExistTotalShippingAndHandlingCustomerCurrency{get;}

		void RemoveTotalShippingAndHandlingCustomerCurrency();


		global::System.DateTime EntryDate 
		{
			get;
			set;
		}

		bool ExistEntryDate{get;}

		void RemoveEntryDate();


		DiscountAdjustment DiscountAdjustment
		{ 
			get;
			set;
		}

		bool ExistDiscountAdjustment
		{
			get;
		}

		void RemoveDiscountAdjustment();


		OrderKind OrderKind
		{ 
			get;
			set;
		}

		bool ExistOrderKind
		{
			get;
		}

		void RemoveOrderKind();


		global::System.Decimal TotalIncVat 
		{
			get;
			set;
		}

		bool ExistTotalIncVat{get;}

		void RemoveTotalIncVat();


		global::System.Decimal TotalSurchargeCustomerCurrency 
		{
			get;
			set;
		}

		bool ExistTotalSurchargeCustomerCurrency{get;}

		void RemoveTotalSurchargeCustomerCurrency();


		VatRegime VatRegime
		{ 
			get;
			set;
		}

		bool ExistVatRegime
		{
			get;
		}

		void RemoveVatRegime();


		global::System.Decimal TotalFeeCustomerCurrency 
		{
			get;
			set;
		}

		bool ExistTotalFeeCustomerCurrency{get;}

		void RemoveTotalFeeCustomerCurrency();


		global::System.Decimal TotalShippingAndHandling 
		{
			get;
			set;
		}

		bool ExistTotalShippingAndHandling{get;}

		void RemoveTotalShippingAndHandling();


		ShippingAndHandlingCharge ShippingAndHandlingCharge
		{ 
			get;
			set;
		}

		bool ExistShippingAndHandlingCharge
		{
			get;
		}

		void RemoveShippingAndHandlingCharge();


		global::System.DateTime OrderDate 
		{
			get;
			set;
		}

		bool ExistOrderDate{get;}

		void RemoveOrderDate();


		global::System.Decimal TotalExVatCustomerCurrency 
		{
			get;
			set;
		}

		bool ExistTotalExVatCustomerCurrency{get;}

		void RemoveTotalExVatCustomerCurrency();


		global::System.DateTime DeliveryDate 
		{
			get;
			set;
		}

		bool ExistDeliveryDate{get;}

		void RemoveDeliveryDate();


		global::System.Decimal TotalBasePrice 
		{
			get;
			set;
		}

		bool ExistTotalBasePrice{get;}

		void RemoveTotalBasePrice();


		global::System.Decimal TotalFee 
		{
			get;
			set;
		}

		bool ExistTotalFee{get;}

		void RemoveTotalFee();


		SurchargeAdjustment SurchargeAdjustment
		{ 
			get;
			set;
		}

		bool ExistSurchargeAdjustment
		{
			get;
		}

		void RemoveSurchargeAdjustment();

	}

	public class OrderMeta
	{
		public static readonly OrderMeta Instance = new OrderMeta();

		public global::Allors.Meta.Interface ObjectType = global::Allors.Meta.Interfaces.Order;

		public global::Allors.Meta.RoleType CustomerCurrency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderCustomerCurrency;
			}
		} 
		public global::Allors.Meta.RoleType TotalBasePriceCustomerCurrency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderTotalBasePriceCustomerCurrency;
			}
		} 
		public global::Allors.Meta.RoleType TotalIncVatCustomerCurrency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderTotalIncVatCustomerCurrency;
			}
		} 
		public global::Allors.Meta.RoleType TotalDiscountCustomerCurrency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderTotalDiscountCustomerCurrency;
			}
		} 
		public global::Allors.Meta.RoleType CustomerReference 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderCustomerReference;
			}
		} 
		public global::Allors.Meta.RoleType Fee 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderFee;
			}
		} 
		public global::Allors.Meta.RoleType TotalExVat 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderTotalExVat;
			}
		} 
		public global::Allors.Meta.RoleType OrderTerm 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderOrderTerm;
			}
		} 
		public global::Allors.Meta.RoleType TotalVat 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderTotalVat;
			}
		} 
		public global::Allors.Meta.RoleType TotalSurcharge 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderTotalSurcharge;
			}
		} 
		public global::Allors.Meta.RoleType ValidOrderItem 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderValidOrderItem;
			}
		} 
		public global::Allors.Meta.RoleType OrderNumber 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderOrderNumber;
			}
		} 
		public global::Allors.Meta.RoleType TotalVatCustomerCurrency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderTotalVatCustomerCurrency;
			}
		} 
		public global::Allors.Meta.RoleType TotalDiscount 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderTotalDiscount;
			}
		} 
		public global::Allors.Meta.RoleType Message 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderMessage;
			}
		} 
		public global::Allors.Meta.RoleType TotalShippingAndHandlingCustomerCurrency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderTotalShippingAndHandlingCustomerCurrency;
			}
		} 
		public global::Allors.Meta.RoleType EntryDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderEntryDate;
			}
		} 
		public global::Allors.Meta.RoleType DiscountAdjustment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderDiscountAdjustment;
			}
		} 
		public global::Allors.Meta.RoleType OrderKind 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderOrderKind;
			}
		} 
		public global::Allors.Meta.RoleType TotalIncVat 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderTotalIncVat;
			}
		} 
		public global::Allors.Meta.RoleType TotalSurchargeCustomerCurrency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderTotalSurchargeCustomerCurrency;
			}
		} 
		public global::Allors.Meta.RoleType VatRegime 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderVatRegime;
			}
		} 
		public global::Allors.Meta.RoleType TotalFeeCustomerCurrency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderTotalFeeCustomerCurrency;
			}
		} 
		public global::Allors.Meta.RoleType TotalShippingAndHandling 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderTotalShippingAndHandling;
			}
		} 
		public global::Allors.Meta.RoleType ShippingAndHandlingCharge 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderShippingAndHandlingCharge;
			}
		} 
		public global::Allors.Meta.RoleType OrderDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderOrderDate;
			}
		} 
		public global::Allors.Meta.RoleType TotalExVatCustomerCurrency 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderTotalExVatCustomerCurrency;
			}
		} 
		public global::Allors.Meta.RoleType DeliveryDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderDeliveryDate;
			}
		} 
		public global::Allors.Meta.RoleType TotalBasePrice 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderTotalBasePrice;
			}
		} 
		public global::Allors.Meta.RoleType TotalFee 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderTotalFee;
			}
		} 
		public global::Allors.Meta.RoleType SurchargeAdjustment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.OrderSurchargeAdjustment;
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
		public global::Allors.Meta.RoleType PrintContent 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.PrintablePrintContent;
			}
		} 
		public global::Allors.Meta.RoleType UniqueId 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UniquelyIdentifiableUniqueId;
			}
		} 
		public global::Allors.Meta.RoleType SearchData 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SearchableSearchData;
			}
		} 
		public global::Allors.Meta.RoleType Comment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommentableComment;
			}
		} 
		public global::Allors.Meta.RoleType Locale 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.LocalisedLocale;
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