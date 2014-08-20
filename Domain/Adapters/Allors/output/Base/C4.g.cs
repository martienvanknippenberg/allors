// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Domain
{
	public  partial class C4 : C4Allors , global::Domain.I4, global::Domain.I34
	{
		public C4(Allors.IStrategy allors) : base(allors) {}

		public static new C4 Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (C4) allorsSession.Instantiate(allorsObjectId);		
		}
	}

	[System.Diagnostics.DebuggerNonUserCode]
	public abstract class C4Allors :  global::Domain.A4 
	{
		protected C4Allors(Allors.IStrategy allors) : base(allors){}



		virtual public global::System.String C4AllorsString 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(C4Meta.C4AllorsString);
			}
			set
			{
				Strategy.SetUnitRole(C4Meta.C4AllorsString, value);
			}
		}

		virtual public bool ExistC4AllorsString{
			get
			{
				return Strategy.ExistUnitRole(C4Meta.C4AllorsString);
			}
		}

		virtual public void RemoveC4AllorsString()
		{
			Strategy.RemoveUnitRole(C4Meta.C4AllorsString);
		}



		virtual public global::System.Double? S1234AllorsDouble 
		{
			get
			{
				return (global::System.Double?) Strategy.GetUnitRole(C4Meta.S1234AllorsDouble);
			}
			set
			{
				Strategy.SetUnitRole(C4Meta.S1234AllorsDouble, value);
			}
		}

		virtual public bool ExistS1234AllorsDouble{
			get
			{
				return Strategy.ExistUnitRole(C4Meta.S1234AllorsDouble);
			}
		}

		virtual public void RemoveS1234AllorsDouble()
		{
			Strategy.RemoveUnitRole(C4Meta.S1234AllorsDouble);
		}



		virtual public global::System.Decimal? S1234AllorsDecimal 
		{
			get
			{
				return (global::System.Decimal?) Strategy.GetUnitRole(C4Meta.S1234AllorsDecimal);
			}
			set
			{
				Strategy.SetUnitRole(C4Meta.S1234AllorsDecimal, value);
			}
		}

		virtual public bool ExistS1234AllorsDecimal{
			get
			{
				return Strategy.ExistUnitRole(C4Meta.S1234AllorsDecimal);
			}
		}

		virtual public void RemoveS1234AllorsDecimal()
		{
			Strategy.RemoveUnitRole(C4Meta.S1234AllorsDecimal);
		}



		virtual public global::System.Int32? S1234AllorsInteger 
		{
			get
			{
				return (global::System.Int32?) Strategy.GetUnitRole(C4Meta.S1234AllorsInteger);
			}
			set
			{
				Strategy.SetUnitRole(C4Meta.S1234AllorsInteger, value);
			}
		}

		virtual public bool ExistS1234AllorsInteger{
			get
			{
				return Strategy.ExistUnitRole(C4Meta.S1234AllorsInteger);
			}
		}

		virtual public void RemoveS1234AllorsInteger()
		{
			Strategy.RemoveUnitRole(C4Meta.S1234AllorsInteger);
		}


		virtual public global::Domain.S1234 S1234many2one
		{ 
			get
			{
				return (global::Domain.S1234) Strategy.GetCompositeRole(C4Meta.S1234many2one);
			}
			set
			{
				Strategy.SetCompositeRole(C4Meta.S1234many2one ,value);
			}
		}

		virtual public bool ExistS1234many2one
		{
			get
			{
				return Strategy.ExistCompositeRole(C4Meta.S1234many2one);
			}
		}

		virtual public void RemoveS1234many2one()
		{
			Strategy.RemoveCompositeRole(C4Meta.S1234many2one);
		}


		virtual public global::Domain.C2 S1234C2one2one
		{ 
			get
			{
				return (global::Domain.C2) Strategy.GetCompositeRole(C4Meta.S1234C2one2one);
			}
			set
			{
				Strategy.SetCompositeRole(C4Meta.S1234C2one2one ,value);
			}
		}

		virtual public bool ExistS1234C2one2one
		{
			get
			{
				return Strategy.ExistCompositeRole(C4Meta.S1234C2one2one);
			}
		}

		virtual public void RemoveS1234C2one2one()
		{
			Strategy.RemoveCompositeRole(C4Meta.S1234C2one2one);
		}


		virtual public Allors.Extent<global::Domain.C2> S1234C2many2manies
		{ 
			get
			{
				return Strategy.GetCompositeRoles(C4Meta.S1234C2many2many);
			}
			set
			{
				Strategy.SetCompositeRoles(C4Meta.S1234C2many2many, value);
			}
		}

		virtual public void AddS1234C2many2many (global::Domain.C2 value)
		{
			Strategy.AddCompositeRole(C4Meta.S1234C2many2many, value);
		}

		virtual public void RemoveS1234C2many2many (global::Domain.C2 value)
		{
			Strategy.RemoveCompositeRole(C4Meta.S1234C2many2many,value);
		}

		virtual public bool ExistS1234C2many2manies
		{
			get
			{
				return Strategy.ExistCompositeRoles(C4Meta.S1234C2many2many);
			}
		}

		virtual public void RemoveS1234C2many2manies()
		{
			Strategy.RemoveCompositeRoles(C4Meta.S1234C2many2many);
		}


		virtual public Allors.Extent<global::Domain.S1234> S1234one2manies
		{ 
			get
			{
				return Strategy.GetCompositeRoles(C4Meta.S1234one2many);
			}
			set
			{
				Strategy.SetCompositeRoles(C4Meta.S1234one2many, value);
			}
		}

		virtual public void AddS1234one2many (global::Domain.S1234 value)
		{
			Strategy.AddCompositeRole(C4Meta.S1234one2many, value);
		}

		virtual public void RemoveS1234one2many (global::Domain.S1234 value)
		{
			Strategy.RemoveCompositeRole(C4Meta.S1234one2many,value);
		}

		virtual public bool ExistS1234one2manies
		{
			get
			{
				return Strategy.ExistCompositeRoles(C4Meta.S1234one2many);
			}
		}

		virtual public void RemoveS1234one2manies()
		{
			Strategy.RemoveCompositeRoles(C4Meta.S1234one2many);
		}


		virtual public Allors.Extent<global::Domain.C2> S1234C2one2manies
		{ 
			get
			{
				return Strategy.GetCompositeRoles(C4Meta.S1234C2one2many);
			}
			set
			{
				Strategy.SetCompositeRoles(C4Meta.S1234C2one2many, value);
			}
		}

		virtual public void AddS1234C2one2many (global::Domain.C2 value)
		{
			Strategy.AddCompositeRole(C4Meta.S1234C2one2many, value);
		}

		virtual public void RemoveS1234C2one2many (global::Domain.C2 value)
		{
			Strategy.RemoveCompositeRole(C4Meta.S1234C2one2many,value);
		}

		virtual public bool ExistS1234C2one2manies
		{
			get
			{
				return Strategy.ExistCompositeRoles(C4Meta.S1234C2one2many);
			}
		}

		virtual public void RemoveS1234C2one2manies()
		{
			Strategy.RemoveCompositeRoles(C4Meta.S1234C2one2many);
		}


		virtual public Allors.Extent<global::Domain.S1234> S1234many2manies
		{ 
			get
			{
				return Strategy.GetCompositeRoles(C4Meta.S1234many2many);
			}
			set
			{
				Strategy.SetCompositeRoles(C4Meta.S1234many2many, value);
			}
		}

		virtual public void AddS1234many2many (global::Domain.S1234 value)
		{
			Strategy.AddCompositeRole(C4Meta.S1234many2many, value);
		}

		virtual public void RemoveS1234many2many (global::Domain.S1234 value)
		{
			Strategy.RemoveCompositeRole(C4Meta.S1234many2many,value);
		}

		virtual public bool ExistS1234many2manies
		{
			get
			{
				return Strategy.ExistCompositeRoles(C4Meta.S1234many2many);
			}
		}

		virtual public void RemoveS1234many2manies()
		{
			Strategy.RemoveCompositeRoles(C4Meta.S1234many2many);
		}



		virtual public global::System.Int64? S1234AllorsLong 
		{
			get
			{
				return (global::System.Int64?) Strategy.GetUnitRole(C4Meta.S1234AllorsLong);
			}
			set
			{
				Strategy.SetUnitRole(C4Meta.S1234AllorsLong, value);
			}
		}

		virtual public bool ExistS1234AllorsLong{
			get
			{
				return Strategy.ExistUnitRole(C4Meta.S1234AllorsLong);
			}
		}

		virtual public void RemoveS1234AllorsLong()
		{
			Strategy.RemoveUnitRole(C4Meta.S1234AllorsLong);
		}



		virtual public global::System.String ClassName 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(C4Meta.ClassName);
			}
			set
			{
				Strategy.SetUnitRole(C4Meta.ClassName, value);
			}
		}

		virtual public bool ExistClassName{
			get
			{
				return Strategy.ExistUnitRole(C4Meta.ClassName);
			}
		}

		virtual public void RemoveClassName()
		{
			Strategy.RemoveUnitRole(C4Meta.ClassName);
		}



		virtual public global::System.DateTime? S1234AllorsDateTime 
		{
			get
			{
				return (global::System.DateTime?) Strategy.GetUnitRole(C4Meta.S1234AllorsDateTime);
			}
			set
			{
				Strategy.SetUnitRole(C4Meta.S1234AllorsDateTime, value);
			}
		}

		virtual public bool ExistS1234AllorsDateTime{
			get
			{
				return Strategy.ExistUnitRole(C4Meta.S1234AllorsDateTime);
			}
		}

		virtual public void RemoveS1234AllorsDateTime()
		{
			Strategy.RemoveUnitRole(C4Meta.S1234AllorsDateTime);
		}


		virtual public global::Domain.S1234 S1234one2one
		{ 
			get
			{
				return (global::Domain.S1234) Strategy.GetCompositeRole(C4Meta.S1234one2one);
			}
			set
			{
				Strategy.SetCompositeRole(C4Meta.S1234one2one ,value);
			}
		}

		virtual public bool ExistS1234one2one
		{
			get
			{
				return Strategy.ExistCompositeRole(C4Meta.S1234one2one);
			}
		}

		virtual public void RemoveS1234one2one()
		{
			Strategy.RemoveCompositeRole(C4Meta.S1234one2one);
		}


		virtual public global::Domain.C2 S1234C2many2one
		{ 
			get
			{
				return (global::Domain.C2) Strategy.GetCompositeRole(C4Meta.S1234C2many2one);
			}
			set
			{
				Strategy.SetCompositeRole(C4Meta.S1234C2many2one ,value);
			}
		}

		virtual public bool ExistS1234C2many2one
		{
			get
			{
				return Strategy.ExistCompositeRole(C4Meta.S1234C2many2one);
			}
		}

		virtual public void RemoveS1234C2many2one()
		{
			Strategy.RemoveCompositeRole(C4Meta.S1234C2many2one);
		}



		virtual public global::System.String S1234AllorsString 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(C4Meta.S1234AllorsString);
			}
			set
			{
				Strategy.SetUnitRole(C4Meta.S1234AllorsString, value);
			}
		}

		virtual public bool ExistS1234AllorsString{
			get
			{
				return Strategy.ExistUnitRole(C4Meta.S1234AllorsString);
			}
		}

		virtual public void RemoveS1234AllorsString()
		{
			Strategy.RemoveUnitRole(C4Meta.S1234AllorsString);
		}



		virtual public global::System.Boolean? S1234AllorsBoolean 
		{
			get
			{
				return (global::System.Boolean?) Strategy.GetUnitRole(C4Meta.S1234AllorsBoolean);
			}
			set
			{
				Strategy.SetUnitRole(C4Meta.S1234AllorsBoolean, value);
			}
		}

		virtual public bool ExistS1234AllorsBoolean{
			get
			{
				return Strategy.ExistUnitRole(C4Meta.S1234AllorsBoolean);
			}
		}

		virtual public void RemoveS1234AllorsBoolean()
		{
			Strategy.RemoveUnitRole(C4Meta.S1234AllorsBoolean);
		}



		virtual public global::System.Decimal? I34AllorsDecimal 
		{
			get
			{
				return (global::System.Decimal?) Strategy.GetUnitRole(C4Meta.I34AllorsDecimal);
			}
			set
			{
				Strategy.SetUnitRole(C4Meta.I34AllorsDecimal, value);
			}
		}

		virtual public bool ExistI34AllorsDecimal{
			get
			{
				return Strategy.ExistUnitRole(C4Meta.I34AllorsDecimal);
			}
		}

		virtual public void RemoveI34AllorsDecimal()
		{
			Strategy.RemoveUnitRole(C4Meta.I34AllorsDecimal);
		}



		virtual public global::System.Boolean? I34AllorsBoolean 
		{
			get
			{
				return (global::System.Boolean?) Strategy.GetUnitRole(C4Meta.I34AllorsBoolean);
			}
			set
			{
				Strategy.SetUnitRole(C4Meta.I34AllorsBoolean, value);
			}
		}

		virtual public bool ExistI34AllorsBoolean{
			get
			{
				return Strategy.ExistUnitRole(C4Meta.I34AllorsBoolean);
			}
		}

		virtual public void RemoveI34AllorsBoolean()
		{
			Strategy.RemoveUnitRole(C4Meta.I34AllorsBoolean);
		}



		virtual public global::System.Double? I34AllorsDouble 
		{
			get
			{
				return (global::System.Double?) Strategy.GetUnitRole(C4Meta.I34AllorsDouble);
			}
			set
			{
				Strategy.SetUnitRole(C4Meta.I34AllorsDouble, value);
			}
		}

		virtual public bool ExistI34AllorsDouble{
			get
			{
				return Strategy.ExistUnitRole(C4Meta.I34AllorsDouble);
			}
		}

		virtual public void RemoveI34AllorsDouble()
		{
			Strategy.RemoveUnitRole(C4Meta.I34AllorsDouble);
		}



		virtual public global::System.Int32? I34AllorsInteger 
		{
			get
			{
				return (global::System.Int32?) Strategy.GetUnitRole(C4Meta.I34AllorsInteger);
			}
			set
			{
				Strategy.SetUnitRole(C4Meta.I34AllorsInteger, value);
			}
		}

		virtual public bool ExistI34AllorsInteger{
			get
			{
				return Strategy.ExistUnitRole(C4Meta.I34AllorsInteger);
			}
		}

		virtual public void RemoveI34AllorsInteger()
		{
			Strategy.RemoveUnitRole(C4Meta.I34AllorsInteger);
		}



		virtual public global::System.String I34AllorsString 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(C4Meta.I34AllorsString);
			}
			set
			{
				Strategy.SetUnitRole(C4Meta.I34AllorsString, value);
			}
		}

		virtual public bool ExistI34AllorsString{
			get
			{
				return Strategy.ExistUnitRole(C4Meta.I34AllorsString);
			}
		}

		virtual public void RemoveI34AllorsString()
		{
			Strategy.RemoveUnitRole(C4Meta.I34AllorsString);
		}



		virtual public Allors.Extent<global::Domain.I3> I3sWhereC4many2many
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(C4Meta.I3sWhereC4many2many);
			}
		}

		virtual public bool ExistI3sWhereC4many2many
		{
			get
			{
				return Strategy.ExistCompositeAssociations(C4Meta.I3sWhereC4many2many);
			}
		}


		virtual public Allors.Extent<global::Domain.C3> C3sWhereC4many2one
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(C4Meta.C3sWhereC4many2one);
			}
		}

		virtual public bool ExistC3sWhereC4many2one
		{
			get
			{
				return Strategy.ExistCompositeAssociations(C4Meta.C3sWhereC4many2one);
			}
		}


		virtual public global::Domain.I3 I3WhereC4one2many
		{ 
			get
			{
				return (global::Domain.I3) Strategy.GetCompositeAssociation(C4Meta.I3WhereC4one2many);
			}
		} 

		virtual public bool ExistI3WhereC4one2many
		{
			get
			{
				return Strategy.ExistCompositeAssociation(C4Meta.I3WhereC4one2many);
			}
		}


		virtual public Allors.Extent<global::Domain.A3> A3sWhereC4many2many
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(C4Meta.A3sWhereC4many2many);
			}
		}

		virtual public bool ExistA3sWhereC4many2many
		{
			get
			{
				return Strategy.ExistCompositeAssociations(C4Meta.A3sWhereC4many2many);
			}
		}


		virtual public Allors.Extent<global::Domain.C3> C3sWhereC4many2many
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(C4Meta.C3sWhereC4many2many);
			}
		}

		virtual public bool ExistC3sWhereC4many2many
		{
			get
			{
				return Strategy.ExistCompositeAssociations(C4Meta.C3sWhereC4many2many);
			}
		}


		virtual public global::Domain.I3 I3WhereC4one2one
		{ 
			get
			{
				return (global::Domain.I3) Strategy.GetCompositeAssociation(C4Meta.I3WhereC4one2one);
			}
		} 

		virtual public bool ExistI3WhereC4one2one
		{
			get
			{
				return Strategy.ExistCompositeAssociation(C4Meta.I3WhereC4one2one);
			}
		}


		virtual public global::Domain.C3 C3WhereC4one2many
		{ 
			get
			{
				return (global::Domain.C3) Strategy.GetCompositeAssociation(C4Meta.C3WhereC4one2many);
			}
		} 

		virtual public bool ExistC3WhereC4one2many
		{
			get
			{
				return Strategy.ExistCompositeAssociation(C4Meta.C3WhereC4one2many);
			}
		}


		virtual public Allors.Extent<global::Domain.I3> I3sWhereC4many2one
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(C4Meta.I3sWhereC4many2one);
			}
		}

		virtual public bool ExistI3sWhereC4many2one
		{
			get
			{
				return Strategy.ExistCompositeAssociations(C4Meta.I3sWhereC4many2one);
			}
		}


		virtual public global::Domain.C3 C3WhereC4one2one
		{ 
			get
			{
				return (global::Domain.C3) Strategy.GetCompositeAssociation(C4Meta.C3WhereC4one2one);
			}
		} 

		virtual public bool ExistC3WhereC4one2one
		{
			get
			{
				return Strategy.ExistCompositeAssociation(C4Meta.C3WhereC4one2one);
			}
		}


		virtual public global::Domain.C3 C3WhereI4one2one
		{ 
			get
			{
				return (global::Domain.C3) Strategy.GetCompositeAssociation(C4Meta.C3WhereI4one2one);
			}
		} 

		virtual public bool ExistC3WhereI4one2one
		{
			get
			{
				return Strategy.ExistCompositeAssociation(C4Meta.C3WhereI4one2one);
			}
		}


		virtual public global::Domain.I3 I3WhereI4one2many
		{ 
			get
			{
				return (global::Domain.I3) Strategy.GetCompositeAssociation(C4Meta.I3WhereI4one2many);
			}
		} 

		virtual public bool ExistI3WhereI4one2many
		{
			get
			{
				return Strategy.ExistCompositeAssociation(C4Meta.I3WhereI4one2many);
			}
		}


		virtual public Allors.Extent<global::Domain.I3> I3sWhereI4many2many
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(C4Meta.I3sWhereI4many2many);
			}
		}

		virtual public bool ExistI3sWhereI4many2many
		{
			get
			{
				return Strategy.ExistCompositeAssociations(C4Meta.I3sWhereI4many2many);
			}
		}


		virtual public Allors.Extent<global::Domain.I3> I3sWhereI4many2one
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(C4Meta.I3sWhereI4many2one);
			}
		}

		virtual public bool ExistI3sWhereI4many2one
		{
			get
			{
				return Strategy.ExistCompositeAssociations(C4Meta.I3sWhereI4many2one);
			}
		}


		virtual public Allors.Extent<global::Domain.C3> C3sWhereI4many2many
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(C4Meta.C3sWhereI4many2many);
			}
		}

		virtual public bool ExistC3sWhereI4many2many
		{
			get
			{
				return Strategy.ExistCompositeAssociations(C4Meta.C3sWhereI4many2many);
			}
		}


		virtual public Allors.Extent<global::Domain.C3> C3sWhereI4many2one
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(C4Meta.C3sWhereI4many2one);
			}
		}

		virtual public bool ExistC3sWhereI4many2one
		{
			get
			{
				return Strategy.ExistCompositeAssociations(C4Meta.C3sWhereI4many2one);
			}
		}


		virtual public global::Domain.I3 I3WhereI4one2one
		{ 
			get
			{
				return (global::Domain.I3) Strategy.GetCompositeAssociation(C4Meta.I3WhereI4one2one);
			}
		} 

		virtual public bool ExistI3WhereI4one2one
		{
			get
			{
				return Strategy.ExistCompositeAssociation(C4Meta.I3WhereI4one2one);
			}
		}


		virtual public global::Domain.C3 C3WhereI4one2many
		{ 
			get
			{
				return (global::Domain.C3) Strategy.GetCompositeAssociation(C4Meta.C3WhereI4one2many);
			}
		} 

		virtual public bool ExistC3WhereI4one2many
		{
			get
			{
				return Strategy.ExistCompositeAssociation(C4Meta.C3WhereI4one2many);
			}
		}


		virtual public Allors.Extent<global::Domain.S1234> S1234sWhereS1234many2one
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(C4Meta.S1234sWhereS1234many2one);
			}
		}

		virtual public bool ExistS1234sWhereS1234many2one
		{
			get
			{
				return Strategy.ExistCompositeAssociations(C4Meta.S1234sWhereS1234many2one);
			}
		}


		virtual public global::Domain.S1234 S1234WhereS1234one2many
		{ 
			get
			{
				return (global::Domain.S1234) Strategy.GetCompositeAssociation(C4Meta.S1234WhereS1234one2many);
			}
		} 

		virtual public bool ExistS1234WhereS1234one2many
		{
			get
			{
				return Strategy.ExistCompositeAssociation(C4Meta.S1234WhereS1234one2many);
			}
		}


		virtual public Allors.Extent<global::Domain.S1234> S1234sWhereS1234many2many
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(C4Meta.S1234sWhereS1234many2many);
			}
		}

		virtual public bool ExistS1234sWhereS1234many2many
		{
			get
			{
				return Strategy.ExistCompositeAssociations(C4Meta.S1234sWhereS1234many2many);
			}
		}


		virtual public global::Domain.S1234 S1234WhereS1234one2one
		{ 
			get
			{
				return (global::Domain.S1234) Strategy.GetCompositeAssociation(C4Meta.S1234WhereS1234one2one);
			}
		} 

		virtual public bool ExistS1234WhereS1234one2one
		{
			get
			{
				return Strategy.ExistCompositeAssociation(C4Meta.S1234WhereS1234one2one);
			}
		}


		virtual public global::Domain.I1 I1WhereI34one2many
		{ 
			get
			{
				return (global::Domain.I1) Strategy.GetCompositeAssociation(C4Meta.I1WhereI34one2many);
			}
		} 

		virtual public bool ExistI1WhereI34one2many
		{
			get
			{
				return Strategy.ExistCompositeAssociation(C4Meta.I1WhereI34one2many);
			}
		}


		virtual public global::Domain.I12 I12WhereI34one2many
		{ 
			get
			{
				return (global::Domain.I12) Strategy.GetCompositeAssociation(C4Meta.I12WhereI34one2many);
			}
		} 

		virtual public bool ExistI12WhereI34one2many
		{
			get
			{
				return Strategy.ExistCompositeAssociation(C4Meta.I12WhereI34one2many);
			}
		}


		virtual public Allors.Extent<global::Domain.I1> I1sWhereI34many2one
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(C4Meta.I1sWhereI34many2one);
			}
		}

		virtual public bool ExistI1sWhereI34many2one
		{
			get
			{
				return Strategy.ExistCompositeAssociations(C4Meta.I1sWhereI34many2one);
			}
		}


		virtual public Allors.Extent<global::Domain.I12> I12sWhereI34many2one
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(C4Meta.I12sWhereI34many2one);
			}
		}

		virtual public bool ExistI12sWhereI34many2one
		{
			get
			{
				return Strategy.ExistCompositeAssociations(C4Meta.I12sWhereI34many2one);
			}
		}


		virtual public Allors.Extent<global::Domain.I12> I12sWhereI34many2many
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(C4Meta.I12sWhereI34many2many);
			}
		}

		virtual public bool ExistI12sWhereI34many2many
		{
			get
			{
				return Strategy.ExistCompositeAssociations(C4Meta.I12sWhereI34many2many);
			}
		}


		virtual public Allors.Extent<global::Domain.I1> I1sWhereI34many2many
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(C4Meta.I1sWhereI34many2many);
			}
		}

		virtual public bool ExistI1sWhereI34many2many
		{
			get
			{
				return Strategy.ExistCompositeAssociations(C4Meta.I1sWhereI34many2many);
			}
		}


		virtual public global::Domain.I1 I1WhereI34one2one
		{ 
			get
			{
				return (global::Domain.I1) Strategy.GetCompositeAssociation(C4Meta.I1WhereI34one2one);
			}
		} 

		virtual public bool ExistI1WhereI34one2one
		{
			get
			{
				return Strategy.ExistCompositeAssociation(C4Meta.I1WhereI34one2one);
			}
		}


		virtual public global::Domain.I12 I12WhereI34one2one
		{ 
			get
			{
				return (global::Domain.I12) Strategy.GetCompositeAssociation(C4Meta.I12WhereI34one2one);
			}
		} 

		virtual public bool ExistI12WhereI34one2one
		{
			get
			{
				return Strategy.ExistCompositeAssociation(C4Meta.I12WhereI34one2one);
			}
		}

	}
}