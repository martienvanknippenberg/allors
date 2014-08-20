// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Domain
{
	public abstract partial class A1 : A1Allors , global::Domain.AI1
	{
		public A1(Allors.IStrategy allors) : base(allors) {}

		public static A1 Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (A1) allorsSession.Instantiate(allorsObjectId);		
		}
	}

	[System.Diagnostics.DebuggerNonUserCode]
	public abstract class A1Allors :  Allors.ObjectBase 
	{
		protected A1Allors(Allors.IStrategy allors) : base(allors){}


		virtual public Allors.Extent<global::Domain.A2> A2One2Manies
		{ 
			get
			{
				return Strategy.GetCompositeRoles(A1Meta.A2One2Many);
			}
			set
			{
				Strategy.SetCompositeRoles(A1Meta.A2One2Many, value);
			}
		}

		virtual public void AddA2One2Many (global::Domain.A2 value)
		{
			Strategy.AddCompositeRole(A1Meta.A2One2Many, value);
		}

		virtual public void RemoveA2One2Many (global::Domain.A2 value)
		{
			Strategy.RemoveCompositeRole(A1Meta.A2One2Many,value);
		}

		virtual public bool ExistA2One2Manies
		{
			get
			{
				return Strategy.ExistCompositeRoles(A1Meta.A2One2Many);
			}
		}

		virtual public void RemoveA2One2Manies()
		{
			Strategy.RemoveCompositeRoles(A1Meta.A2One2Many);
		}



		virtual public global::System.Guid? A1AllorsUnique 
		{
			get
			{
				return (global::System.Guid?) Strategy.GetUnitRole(A1Meta.A1AllorsUnique);
			}
			set
			{
				Strategy.SetUnitRole(A1Meta.A1AllorsUnique, value);
			}
		}

		virtual public bool ExistA1AllorsUnique{
			get
			{
				return Strategy.ExistUnitRole(A1Meta.A1AllorsUnique);
			}
		}

		virtual public void RemoveA1AllorsUnique()
		{
			Strategy.RemoveUnitRole(A1Meta.A1AllorsUnique);
		}


		virtual public global::Domain.A2 A2Many2One
		{ 
			get
			{
				return (global::Domain.A2) Strategy.GetCompositeRole(A1Meta.A2Many2One);
			}
			set
			{
				Strategy.SetCompositeRole(A1Meta.A2Many2One ,value);
			}
		}

		virtual public bool ExistA2Many2One
		{
			get
			{
				return Strategy.ExistCompositeRole(A1Meta.A2Many2One);
			}
		}

		virtual public void RemoveA2Many2One()
		{
			Strategy.RemoveCompositeRole(A1Meta.A2Many2One);
		}



		virtual public global::System.String A1AllorsString 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(A1Meta.A1AllorsString);
			}
			set
			{
				Strategy.SetUnitRole(A1Meta.A1AllorsString, value);
			}
		}

		virtual public bool ExistA1AllorsString{
			get
			{
				return Strategy.ExistUnitRole(A1Meta.A1AllorsString);
			}
		}

		virtual public void RemoveA1AllorsString()
		{
			Strategy.RemoveUnitRole(A1Meta.A1AllorsString);
		}



		virtual public global::System.Double? A1AllorsDouble 
		{
			get
			{
				return (global::System.Double?) Strategy.GetUnitRole(A1Meta.A1AllorsDouble);
			}
			set
			{
				Strategy.SetUnitRole(A1Meta.A1AllorsDouble, value);
			}
		}

		virtual public bool ExistA1AllorsDouble{
			get
			{
				return Strategy.ExistUnitRole(A1Meta.A1AllorsDouble);
			}
		}

		virtual public void RemoveA1AllorsDouble()
		{
			Strategy.RemoveUnitRole(A1Meta.A1AllorsDouble);
		}


		virtual public global::Domain.A2 A2One2One
		{ 
			get
			{
				return (global::Domain.A2) Strategy.GetCompositeRole(A1Meta.A2One2One);
			}
			set
			{
				Strategy.SetCompositeRole(A1Meta.A2One2One ,value);
			}
		}

		virtual public bool ExistA2One2One
		{
			get
			{
				return Strategy.ExistCompositeRole(A1Meta.A2One2One);
			}
		}

		virtual public void RemoveA2One2One()
		{
			Strategy.RemoveCompositeRole(A1Meta.A2One2One);
		}



		virtual public global::System.DateTime? A1AllorsDateTime 
		{
			get
			{
				return (global::System.DateTime?) Strategy.GetUnitRole(A1Meta.A1AllorsDateTime);
			}
			set
			{
				Strategy.SetUnitRole(A1Meta.A1AllorsDateTime, value);
			}
		}

		virtual public bool ExistA1AllorsDateTime{
			get
			{
				return Strategy.ExistUnitRole(A1Meta.A1AllorsDateTime);
			}
		}

		virtual public void RemoveA1AllorsDateTime()
		{
			Strategy.RemoveUnitRole(A1Meta.A1AllorsDateTime);
		}



		virtual public global::System.Byte[] A1AllorsBinary 
		{
			get
			{
				return (global::System.Byte[]) Strategy.GetUnitRole(A1Meta.A1AllorsBinary);
			}
			set
			{
				Strategy.SetUnitRole(A1Meta.A1AllorsBinary, value);
			}
		}

		virtual public bool ExistA1AllorsBinary{
			get
			{
				return Strategy.ExistUnitRole(A1Meta.A1AllorsBinary);
			}
		}

		virtual public void RemoveA1AllorsBinary()
		{
			Strategy.RemoveUnitRole(A1Meta.A1AllorsBinary);
		}



		virtual public global::System.Int64? A1AllorsLong 
		{
			get
			{
				return (global::System.Int64?) Strategy.GetUnitRole(A1Meta.A1AllorsLong);
			}
			set
			{
				Strategy.SetUnitRole(A1Meta.A1AllorsLong, value);
			}
		}

		virtual public bool ExistA1AllorsLong{
			get
			{
				return Strategy.ExistUnitRole(A1Meta.A1AllorsLong);
			}
		}

		virtual public void RemoveA1AllorsLong()
		{
			Strategy.RemoveUnitRole(A1Meta.A1AllorsLong);
		}



		virtual public global::System.Boolean? A1AllorsBoolean 
		{
			get
			{
				return (global::System.Boolean?) Strategy.GetUnitRole(A1Meta.A1AllorsBoolean);
			}
			set
			{
				Strategy.SetUnitRole(A1Meta.A1AllorsBoolean, value);
			}
		}

		virtual public bool ExistA1AllorsBoolean{
			get
			{
				return Strategy.ExistUnitRole(A1Meta.A1AllorsBoolean);
			}
		}

		virtual public void RemoveA1AllorsBoolean()
		{
			Strategy.RemoveUnitRole(A1Meta.A1AllorsBoolean);
		}


		virtual public Allors.Extent<global::Domain.A2> A2Many2Manies
		{ 
			get
			{
				return Strategy.GetCompositeRoles(A1Meta.A2Many2Many);
			}
			set
			{
				Strategy.SetCompositeRoles(A1Meta.A2Many2Many, value);
			}
		}

		virtual public void AddA2Many2Many (global::Domain.A2 value)
		{
			Strategy.AddCompositeRole(A1Meta.A2Many2Many, value);
		}

		virtual public void RemoveA2Many2Many (global::Domain.A2 value)
		{
			Strategy.RemoveCompositeRole(A1Meta.A2Many2Many,value);
		}

		virtual public bool ExistA2Many2Manies
		{
			get
			{
				return Strategy.ExistCompositeRoles(A1Meta.A2Many2Many);
			}
		}

		virtual public void RemoveA2Many2Manies()
		{
			Strategy.RemoveCompositeRoles(A1Meta.A2Many2Many);
		}



		virtual public global::System.Decimal? A1AllorsDecimal 
		{
			get
			{
				return (global::System.Decimal?) Strategy.GetUnitRole(A1Meta.A1AllorsDecimal);
			}
			set
			{
				Strategy.SetUnitRole(A1Meta.A1AllorsDecimal, value);
			}
		}

		virtual public bool ExistA1AllorsDecimal{
			get
			{
				return Strategy.ExistUnitRole(A1Meta.A1AllorsDecimal);
			}
		}

		virtual public void RemoveA1AllorsDecimal()
		{
			Strategy.RemoveUnitRole(A1Meta.A1AllorsDecimal);
		}



		virtual public global::System.Int32? A1AllorsInteger 
		{
			get
			{
				return (global::System.Int32?) Strategy.GetUnitRole(A1Meta.A1AllorsInteger);
			}
			set
			{
				Strategy.SetUnitRole(A1Meta.A1AllorsInteger, value);
			}
		}

		virtual public bool ExistA1AllorsInteger{
			get
			{
				return Strategy.ExistUnitRole(A1Meta.A1AllorsInteger);
			}
		}

		virtual public void RemoveA1AllorsInteger()
		{
			Strategy.RemoveUnitRole(A1Meta.A1AllorsInteger);
		}



		virtual public global::System.Decimal? AI1AllorsDecimal 
		{
			get
			{
				return (global::System.Decimal?) Strategy.GetUnitRole(A1Meta.AI1AllorsDecimal);
			}
			set
			{
				Strategy.SetUnitRole(A1Meta.AI1AllorsDecimal, value);
			}
		}

		virtual public bool ExistAI1AllorsDecimal{
			get
			{
				return Strategy.ExistUnitRole(A1Meta.AI1AllorsDecimal);
			}
		}

		virtual public void RemoveAI1AllorsDecimal()
		{
			Strategy.RemoveUnitRole(A1Meta.AI1AllorsDecimal);
		}



		virtual public global::System.Int32? AI1AllorsInteger 
		{
			get
			{
				return (global::System.Int32?) Strategy.GetUnitRole(A1Meta.AI1AllorsInteger);
			}
			set
			{
				Strategy.SetUnitRole(A1Meta.AI1AllorsInteger, value);
			}
		}

		virtual public bool ExistAI1AllorsInteger{
			get
			{
				return Strategy.ExistUnitRole(A1Meta.AI1AllorsInteger);
			}
		}

		virtual public void RemoveAI1AllorsInteger()
		{
			Strategy.RemoveUnitRole(A1Meta.AI1AllorsInteger);
		}



		virtual public global::System.DateTime? AI1AllorsDateTime 
		{
			get
			{
				return (global::System.DateTime?) Strategy.GetUnitRole(A1Meta.AI1AllorsDateTime);
			}
			set
			{
				Strategy.SetUnitRole(A1Meta.AI1AllorsDateTime, value);
			}
		}

		virtual public bool ExistAI1AllorsDateTime{
			get
			{
				return Strategy.ExistUnitRole(A1Meta.AI1AllorsDateTime);
			}
		}

		virtual public void RemoveAI1AllorsDateTime()
		{
			Strategy.RemoveUnitRole(A1Meta.AI1AllorsDateTime);
		}



		virtual public global::System.Boolean? AI1AllorsBoolean 
		{
			get
			{
				return (global::System.Boolean?) Strategy.GetUnitRole(A1Meta.AI1AllorsBoolean);
			}
			set
			{
				Strategy.SetUnitRole(A1Meta.AI1AllorsBoolean, value);
			}
		}

		virtual public bool ExistAI1AllorsBoolean{
			get
			{
				return Strategy.ExistUnitRole(A1Meta.AI1AllorsBoolean);
			}
		}

		virtual public void RemoveAI1AllorsBoolean()
		{
			Strategy.RemoveUnitRole(A1Meta.AI1AllorsBoolean);
		}



		virtual public global::System.String AI1AllorsString 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(A1Meta.AI1AllorsString);
			}
			set
			{
				Strategy.SetUnitRole(A1Meta.AI1AllorsString, value);
			}
		}

		virtual public bool ExistAI1AllorsString{
			get
			{
				return Strategy.ExistUnitRole(A1Meta.AI1AllorsString);
			}
		}

		virtual public void RemoveAI1AllorsString()
		{
			Strategy.RemoveUnitRole(A1Meta.AI1AllorsString);
		}



		virtual public global::System.Double? AI1AllorsDouble 
		{
			get
			{
				return (global::System.Double?) Strategy.GetUnitRole(A1Meta.AI1AllorsDouble);
			}
			set
			{
				Strategy.SetUnitRole(A1Meta.AI1AllorsDouble, value);
			}
		}

		virtual public bool ExistAI1AllorsDouble{
			get
			{
				return Strategy.ExistUnitRole(A1Meta.AI1AllorsDouble);
			}
		}

		virtual public void RemoveAI1AllorsDouble()
		{
			Strategy.RemoveUnitRole(A1Meta.AI1AllorsDouble);
		}



		virtual public global::System.String AS1AllorsString 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(A1Meta.AS1AllorsString);
			}
			set
			{
				Strategy.SetUnitRole(A1Meta.AS1AllorsString, value);
			}
		}

		virtual public bool ExistAS1AllorsString{
			get
			{
				return Strategy.ExistUnitRole(A1Meta.AS1AllorsString);
			}
		}

		virtual public void RemoveAS1AllorsString()
		{
			Strategy.RemoveUnitRole(A1Meta.AS1AllorsString);
		}



		virtual public global::System.Int32? AS1AllorsInteger 
		{
			get
			{
				return (global::System.Int32?) Strategy.GetUnitRole(A1Meta.AS1AllorsInteger);
			}
			set
			{
				Strategy.SetUnitRole(A1Meta.AS1AllorsInteger, value);
			}
		}

		virtual public bool ExistAS1AllorsInteger{
			get
			{
				return Strategy.ExistUnitRole(A1Meta.AS1AllorsInteger);
			}
		}

		virtual public void RemoveAS1AllorsInteger()
		{
			Strategy.RemoveUnitRole(A1Meta.AS1AllorsInteger);
		}



		virtual public global::System.DateTime? AS1AllorsDateTime 
		{
			get
			{
				return (global::System.DateTime?) Strategy.GetUnitRole(A1Meta.AS1AllorsDateTime);
			}
			set
			{
				Strategy.SetUnitRole(A1Meta.AS1AllorsDateTime, value);
			}
		}

		virtual public bool ExistAS1AllorsDateTime{
			get
			{
				return Strategy.ExistUnitRole(A1Meta.AS1AllorsDateTime);
			}
		}

		virtual public void RemoveAS1AllorsDateTime()
		{
			Strategy.RemoveUnitRole(A1Meta.AS1AllorsDateTime);
		}



		virtual public global::System.Decimal? AS1AllorsDecimal 
		{
			get
			{
				return (global::System.Decimal?) Strategy.GetUnitRole(A1Meta.AS1AllorsDecimal);
			}
			set
			{
				Strategy.SetUnitRole(A1Meta.AS1AllorsDecimal, value);
			}
		}

		virtual public bool ExistAS1AllorsDecimal{
			get
			{
				return Strategy.ExistUnitRole(A1Meta.AS1AllorsDecimal);
			}
		}

		virtual public void RemoveAS1AllorsDecimal()
		{
			Strategy.RemoveUnitRole(A1Meta.AS1AllorsDecimal);
		}



		virtual public global::System.Boolean? AS1AllorsBoolean 
		{
			get
			{
				return (global::System.Boolean?) Strategy.GetUnitRole(A1Meta.AS1AllorsBoolean);
			}
			set
			{
				Strategy.SetUnitRole(A1Meta.AS1AllorsBoolean, value);
			}
		}

		virtual public bool ExistAS1AllorsBoolean{
			get
			{
				return Strategy.ExistUnitRole(A1Meta.AS1AllorsBoolean);
			}
		}

		virtual public void RemoveAS1AllorsBoolean()
		{
			Strategy.RemoveUnitRole(A1Meta.AS1AllorsBoolean);
		}



		virtual public global::System.Double? AS1AllorsDouble 
		{
			get
			{
				return (global::System.Double?) Strategy.GetUnitRole(A1Meta.AS1AllorsDouble);
			}
			set
			{
				Strategy.SetUnitRole(A1Meta.AS1AllorsDouble, value);
			}
		}

		virtual public bool ExistAS1AllorsDouble{
			get
			{
				return Strategy.ExistUnitRole(A1Meta.AS1AllorsDouble);
			}
		}

		virtual public void RemoveAS1AllorsDouble()
		{
			Strategy.RemoveUnitRole(A1Meta.AS1AllorsDouble);
		}



		virtual public global::Domain.C1 C1WhereA1
		{ 
			get
			{
				return (global::Domain.C1) Strategy.GetCompositeAssociation(A1Meta.C1WhereA1);
			}
		} 

		virtual public bool ExistC1WhereA1
		{
			get
			{
				return Strategy.ExistCompositeAssociation(A1Meta.C1WhereA1);
			}
		}


		virtual public Allors.Extent<global::Domain.C3> C3sWhereA1
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(A1Meta.C3sWhereA1);
			}
		}

		virtual public bool ExistC3sWhereA1
		{
			get
			{
				return Strategy.ExistCompositeAssociations(A1Meta.C3sWhereA1);
			}
		}

	}
}