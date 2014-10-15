// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface S2 : Allors.IObjectBase
	{


		global::System.String S2AllorsString 
		{
			get;
			set;
		}

		bool ExistS2AllorsString{get;}

		void RemoveS2AllorsString();


		global::System.Int32 S2AllorsInteger 
		{
			get;
			set;
		}

		bool ExistS2AllorsInteger{get;}

		void RemoveS2AllorsInteger();


		global::System.Double S2AllorsDouble 
		{
			get;
			set;
		}

		bool ExistS2AllorsDouble{get;}

		void RemoveS2AllorsDouble();


		global::System.Boolean S2AllorsBoolean 
		{
			get;
			set;
		}

		bool ExistS2AllorsBoolean{get;}

		void RemoveS2AllorsBoolean();


		global::System.Decimal S2AllorsDecimal 
		{
			get;
			set;
		}

		bool ExistS2AllorsDecimal{get;}

		void RemoveS2AllorsDecimal();


		global::System.DateTime S2AllorsDate 
		{
			get;
			set;
		}

		bool ExistS2AllorsDate{get;}

		void RemoveS2AllorsDate();


		global::System.Int64 S2AllorsLong 
		{
			get;
			set;
		}

		bool ExistS2AllorsLong{get;}

		void RemoveS2AllorsLong();



		global::Allors.Extent<S1> S1sWhereS2many2one
		{ 
			get;
		}

		bool ExistS1sWhereS2many2one
		{
			get;
		}


		S1 S1WhereS2one2many
		{
			get;
		}

		bool ExistS1WhereS2one2many
		{
			get;
		}


		global::Allors.Extent<S1> S1sWhereS2many2many
		{ 
			get;
		}

		bool ExistS1sWhereS2many2many
		{
			get;
		}


		S1 S1WhereS2one2one
		{
			get;
		}

		bool ExistS1WhereS2one2one
		{
			get;
		}


		global::Allors.Extent<C1> C1sWhereS2many2one
		{ 
			get;
		}

		bool ExistC1sWhereS2many2one
		{
			get;
		}


		C1 C1WhereS2one2one
		{
			get;
		}

		bool ExistC1WhereS2one2one
		{
			get;
		}


		global::Allors.Extent<C1> C1sWhereS2many2many
		{ 
			get;
		}

		bool ExistC1sWhereS2many2many
		{
			get;
		}


		C1 C1WhereS2one2many
		{
			get;
		}

		bool ExistC1WhereS2one2many
		{
			get;
		}


		I1 I1WhereS2one2one
		{
			get;
		}

		bool ExistI1WhereS2one2one
		{
			get;
		}


		global::Allors.Extent<I1> I1sWhereS2many2many
		{ 
			get;
		}

		bool ExistI1sWhereS2many2many
		{
			get;
		}


		I1 I1WhereS2one2many
		{
			get;
		}

		bool ExistI1WhereS2one2many
		{
			get;
		}


		global::Allors.Extent<I1> I1sWhereS2many2one
		{ 
			get;
		}

		bool ExistI1sWhereS2many2one
		{
			get;
		}

	}

	public class S2Meta
	{
		public static readonly S2Meta Instance = new S2Meta();

		public global::Allors.Meta.Interface ObjectType = global::Allors.Meta.Interfaces.S2;

		public global::Allors.Meta.RoleType S2AllorsString 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.S2AllorsString;
			}
		} 
		public global::Allors.Meta.RoleType S2AllorsInteger 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.S2AllorsInteger;
			}
		} 
		public global::Allors.Meta.RoleType S2AllorsDouble 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.S2AllorsDouble;
			}
		} 
		public global::Allors.Meta.RoleType S2AllorsBoolean 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.S2AllorsBoolean;
			}
		} 
		public global::Allors.Meta.RoleType S2AllorsDecimal 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.S2AllorsDecimal;
			}
		} 
		public global::Allors.Meta.RoleType S2AllorsDate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.S2AllorsDate;
			}
		} 
		public global::Allors.Meta.RoleType S2AllorsLong 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.S2AllorsLong;
			}
		} 

		public global::Allors.Meta.IAssociationType S1sWhereS2many2one 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.S1S2many2one;
			}
		} 
		public global::Allors.Meta.IAssociationType S1WhereS2one2many 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.S1S2one2many;
			}
		} 
		public global::Allors.Meta.IAssociationType S1sWhereS2many2many 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.S1S2many2many;
			}
		} 
		public global::Allors.Meta.IAssociationType S1WhereS2one2one 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.S1S2one2one;
			}
		} 
		public global::Allors.Meta.IAssociationType C1sWhereS2many2one 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.C1S2many2one;
			}
		} 
		public global::Allors.Meta.IAssociationType C1WhereS2one2one 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.C1S2one2one;
			}
		} 
		public global::Allors.Meta.IAssociationType C1sWhereS2many2many 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.C1S2many2many;
			}
		} 
		public global::Allors.Meta.IAssociationType C1WhereS2one2many 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.C1S2one2many;
			}
		} 
		public global::Allors.Meta.IAssociationType I1WhereS2one2one 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.I1S2one2one;
			}
		} 
		public global::Allors.Meta.IAssociationType I1sWhereS2many2many 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.I1S2many2many;
			}
		} 
		public global::Allors.Meta.IAssociationType I1WhereS2one2many 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.I1S2one2many;
			}
		} 
		public global::Allors.Meta.IAssociationType I1sWhereS2many2one 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.I1S2many2one;
			}
		} 

	}
}