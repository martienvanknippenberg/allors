// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface I12 :  S12, Allors.IObjectBase
	{


		global::System.Boolean I12AllorsBoolean 
		{
			get;
			set;
		}

		bool ExistI12AllorsBoolean{get;}

		void RemoveI12AllorsBoolean();


		global::System.Int32 I12AllorsInteger 
		{
			get;
			set;
		}

		bool ExistI12AllorsInteger{get;}

		void RemoveI12AllorsInteger();


		global::Allors.Extent<I34> I12I34one2manies
		{ 
			get;
			set;
		}

		void AddI12I34one2many (I34 value);

		void RemoveI12I34one2many (I34 value);

		bool ExistI12I34one2manies
		{
			get;
		}

		void RemoveI12I34one2manies();


		C3 C3many2one
		{ 
			get;
			set;
		}

		bool ExistC3many2one
		{
			get;
		}

		void RemoveC3many2one();


		C2 I12C2many2one
		{ 
			get;
			set;
		}

		bool ExistI12C2many2one
		{
			get;
		}

		void RemoveI12C2many2one();


		global::System.Double I12AllorsDouble 
		{
			get;
			set;
		}

		bool ExistI12AllorsDouble{get;}

		void RemoveI12AllorsDouble();


		I34 I12I34many2one
		{ 
			get;
			set;
		}

		bool ExistI12I34many2one
		{
			get;
		}

		void RemoveI12I34many2one();


		global::Allors.Extent<I34> I12I34many2manies
		{ 
			get;
			set;
		}

		void AddI12I34many2many (I34 value);

		void RemoveI12I34many2many (I34 value);

		bool ExistI12I34many2manies
		{
			get;
		}

		void RemoveI12I34many2manies();


		C3 I12C3one2one
		{ 
			get;
			set;
		}

		bool ExistI12C3one2one
		{
			get;
		}

		void RemoveI12C3one2one();


		global::Allors.Extent<C2> I12C2many2manies
		{ 
			get;
			set;
		}

		void AddI12C2many2many (C2 value);

		void RemoveI12C2many2many (C2 value);

		bool ExistI12C2many2manies
		{
			get;
		}

		void RemoveI12C2many2manies();


		global::System.Int64 I12AllorsLong 
		{
			get;
			set;
		}

		bool ExistI12AllorsLong{get;}

		void RemoveI12AllorsLong();


		global::System.Decimal I12AllorsDecimal 
		{
			get;
			set;
		}

		bool ExistI12AllorsDecimal{get;}

		void RemoveI12AllorsDecimal();


		C2 I12C2one2one
		{ 
			get;
			set;
		}

		bool ExistI12C2one2one
		{
			get;
		}

		void RemoveI12C2one2one();


		global::Allors.Extent<C3> I12C3one2manies
		{ 
			get;
			set;
		}

		void AddI12C3one2many (C3 value);

		void RemoveI12C3one2many (C3 value);

		bool ExistI12C3one2manies
		{
			get;
		}

		void RemoveI12C3one2manies();


		global::Allors.Extent<C3> I12C3many2manies
		{ 
			get;
			set;
		}

		void AddI12C3many2many (C3 value);

		void RemoveI12C3many2many (C3 value);

		bool ExistI12C3many2manies
		{
			get;
		}

		void RemoveI12C3many2manies();


		global::System.String PrefetchTest 
		{
			get;
			set;
		}

		bool ExistPrefetchTest{get;}

		void RemovePrefetchTest();


		global::System.DateTime I12AllorsDate 
		{
			get;
			set;
		}

		bool ExistI12AllorsDate{get;}

		void RemoveI12AllorsDate();


		global::System.String I12AllorsString 
		{
			get;
			set;
		}

		bool ExistI12AllorsString{get;}

		void RemoveI12AllorsString();


		I34 I12I34one2one
		{ 
			get;
			set;
		}

		bool ExistI12I34one2one
		{
			get;
		}

		void RemoveI12I34one2one();


		global::Allors.Extent<C2> I12C2one2manies
		{ 
			get;
			set;
		}

		void AddI12C2one2many (C2 value);

		void RemoveI12C2one2many (C2 value);

		bool ExistI12C2one2manies
		{
			get;
		}

		void RemoveI12C2one2manies();



		C1 C1WhereI12one2one
		{
			get;
		}

		bool ExistC1WhereI12one2one
		{
			get;
		}


		global::Allors.Extent<C1> C1sWhereI12many2one
		{ 
			get;
		}

		bool ExistC1sWhereI12many2one
		{
			get;
		}


		C1 C1WhereI12one2many
		{
			get;
		}

		bool ExistC1WhereI12one2many
		{
			get;
		}


		global::Allors.Extent<C1> C1sWhereI12many2many
		{ 
			get;
		}

		bool ExistC1sWhereI12many2many
		{
			get;
		}


		global::Allors.Extent<I1> I1sWhereI12many2one
		{ 
			get;
		}

		bool ExistI1sWhereI12many2one
		{
			get;
		}


		I1 I1WhereI12one2one
		{
			get;
		}

		bool ExistI1WhereI12one2one
		{
			get;
		}


		global::Allors.Extent<I1> I1sWhereI12many2many
		{ 
			get;
		}

		bool ExistI1sWhereI12many2many
		{
			get;
		}


		I1 I1WhereI12one2many
		{
			get;
		}

		bool ExistI1WhereI12one2many
		{
			get;
		}

	}

	public class I12Meta
	{
		public static readonly I12Meta Instance = new I12Meta();

		public global::Allors.Meta.Interface ObjectType = global::Allors.Meta.Interfaces.I12;

		public global::Allors.Meta.IRoleType I12AllorsBoolean 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.I12AllorsBoolean;
			}
		} 
		public global::Allors.Meta.IRoleType I12AllorsInteger 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.I12AllorsInteger;
			}
		} 
		public global::Allors.Meta.IRoleType I12I34one2many 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.I12I34one2many;
			}
		} 
		public global::Allors.Meta.IRoleType C3many2one 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.I12C3many2one;
			}
		} 
		public global::Allors.Meta.IRoleType I12C2many2one 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.I12C2many2one;
			}
		} 
		public global::Allors.Meta.IRoleType I12AllorsDouble 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.I12AllorsDouble;
			}
		} 
		public global::Allors.Meta.IRoleType I12I34many2one 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.I12I34many2one;
			}
		} 
		public global::Allors.Meta.IRoleType I12I34many2many 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.I12I34many2many;
			}
		} 
		public global::Allors.Meta.IRoleType I12C3one2one 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.I12C3one2one;
			}
		} 
		public global::Allors.Meta.IRoleType I12C2many2many 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.I12C2many2many;
			}
		} 
		public global::Allors.Meta.IRoleType I12AllorsLong 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.I12AllorsLong;
			}
		} 
		public global::Allors.Meta.IRoleType I12AllorsDecimal 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.I12AllorsDecimal;
			}
		} 
		public global::Allors.Meta.IRoleType I12C2one2one 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.I12C2one2one;
			}
		} 
		public global::Allors.Meta.IRoleType I12C3one2many 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.I12C3one2many;
			}
		} 
		public global::Allors.Meta.IRoleType I12C3many2many 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.I12C3many2many;
			}
		} 
		public global::Allors.Meta.IRoleType PrefetchTest 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.I12PrefetchTest;
			}
		} 
		public global::Allors.Meta.IRoleType I12AllorsDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.I12AllorsDate;
			}
		} 
		public global::Allors.Meta.IRoleType I12AllorsString 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.I12AllorsString;
			}
		} 
		public global::Allors.Meta.IRoleType I12I34one2one 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.I12I34one2one;
			}
		} 
		public global::Allors.Meta.IRoleType I12C2one2many 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.I12C2one2many;
			}
		} 
		public global::Allors.Meta.IRoleType S12AllorsString 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.S12AllorsString;
			}
		} 
		public global::Allors.Meta.IRoleType S12AllorsDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.S12AllorsDate;
			}
		} 
		public global::Allors.Meta.IRoleType S12C2many2many 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.S12C2many2many;
			}
		} 
		public global::Allors.Meta.IRoleType S12C2many2one 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.S12C2many2one;
			}
		} 
		public global::Allors.Meta.IRoleType S12C2one2one 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.S12C2one2one;
			}
		} 
		public global::Allors.Meta.IRoleType S12C2one2many 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.S12C2one2many;
			}
		} 
		public global::Allors.Meta.IRoleType S12AllorsBoolean 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.S12AllorsBoolean;
			}
		} 
		public global::Allors.Meta.IRoleType S12AllorsDouble 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.S12AllorsDouble;
			}
		} 
		public global::Allors.Meta.IRoleType S12AllorsInteger 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.S12AllorsInteger;
			}
		} 
		public global::Allors.Meta.IRoleType S12AllorsDecimal 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.S12AllorsDecimal;
			}
		} 

		public global::Allors.Meta.IAssociationType C1WhereI12one2one 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.C1I12one2one;
			}
		} 
		public global::Allors.Meta.IAssociationType C1sWhereI12many2one 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.C1I12many2one;
			}
		} 
		public global::Allors.Meta.IAssociationType C1WhereI12one2many 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.C1I12one2many;
			}
		} 
		public global::Allors.Meta.IAssociationType C1sWhereI12many2many 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.C1I12many2many;
			}
		} 
		public global::Allors.Meta.IAssociationType I1sWhereI12many2one 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.I1I12many2one;
			}
		} 
		public global::Allors.Meta.IAssociationType I1WhereI12one2one 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.I1I12one2one;
			}
		} 
		public global::Allors.Meta.IAssociationType I1sWhereI12many2many 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.I1I12many2many;
			}
		} 
		public global::Allors.Meta.IAssociationType I1WhereI12one2many 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.I1I12one2many;
			}
		} 

	}
}