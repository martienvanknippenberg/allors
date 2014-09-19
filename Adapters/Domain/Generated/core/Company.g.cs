// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class Company : Allors.ObjectBase , Named
	{
		public static readonly CompanyMeta Meta = CompanyMeta.Instance;

		public Company(Allors.IStrategy allors) : base(allors) {}

		public static Company Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (Company) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public Person Manager
		{ 
			get
			{
				return (Person) Strategy.GetCompositeRole(Meta.Manager);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Manager ,value);
			}
		}

		virtual public bool ExistManager
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Manager);
			}
		}

		virtual public void RemoveManager()
		{
			Strategy.RemoveCompositeRole(Meta.Manager);
		}


		virtual public global::Allors.Extent<Person> Employees
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.Employee);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.Employee, value);
			}
		}

		virtual public void AddEmployee (Person value)
		{
			Strategy.AddCompositeRole(Meta.Employee, value);
		}

		virtual public void RemoveEmployee (Person value)
		{
			Strategy.RemoveCompositeRole(Meta.Employee,value);
		}

		virtual public bool ExistEmployees
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.Employee);
			}
		}

		virtual public void RemoveEmployees()
		{
			Strategy.RemoveCompositeRoles(Meta.Employee);
		}


		virtual public Person FirstPerson
		{ 
			get
			{
				return (Person) Strategy.GetCompositeRole(Meta.FirstPerson);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.FirstPerson ,value);
			}
		}

		virtual public bool ExistFirstPerson
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.FirstPerson);
			}
		}

		virtual public void RemoveFirstPerson()
		{
			Strategy.RemoveCompositeRole(Meta.FirstPerson);
		}


		virtual public global::Allors.Extent<Named> NamedsOneSort2
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.NamedOneSort2);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.NamedOneSort2, value);
			}
		}

		virtual public void AddNamedOneSort2 (Named value)
		{
			Strategy.AddCompositeRole(Meta.NamedOneSort2, value);
		}

		virtual public void RemoveNamedOneSort2 (Named value)
		{
			Strategy.RemoveCompositeRole(Meta.NamedOneSort2,value);
		}

		virtual public bool ExistNamedsOneSort2
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.NamedOneSort2);
			}
		}

		virtual public void RemoveNamedsOneSort2()
		{
			Strategy.RemoveCompositeRoles(Meta.NamedOneSort2);
		}


		virtual public global::Allors.Extent<Person> Owners
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.Owner);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.Owner, value);
			}
		}

		virtual public void AddOwner (Person value)
		{
			Strategy.AddCompositeRole(Meta.Owner, value);
		}

		virtual public void RemoveOwner (Person value)
		{
			Strategy.RemoveCompositeRole(Meta.Owner,value);
		}

		virtual public bool ExistOwners
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.Owner);
			}
		}

		virtual public void RemoveOwners()
		{
			Strategy.RemoveCompositeRoles(Meta.Owner);
		}


		virtual public global::Allors.Extent<Person> IndexedMany2ManyPersons
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.IndexedMany2ManyPerson);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.IndexedMany2ManyPerson, value);
			}
		}

		virtual public void AddIndexedMany2ManyPerson (Person value)
		{
			Strategy.AddCompositeRole(Meta.IndexedMany2ManyPerson, value);
		}

		virtual public void RemoveIndexedMany2ManyPerson (Person value)
		{
			Strategy.RemoveCompositeRole(Meta.IndexedMany2ManyPerson,value);
		}

		virtual public bool ExistIndexedMany2ManyPersons
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.IndexedMany2ManyPerson);
			}
		}

		virtual public void RemoveIndexedMany2ManyPersons()
		{
			Strategy.RemoveCompositeRoles(Meta.IndexedMany2ManyPerson);
		}


		virtual public global::Allors.Extent<Person> PersonsOneSort1
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.PersonOneSort1);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.PersonOneSort1, value);
			}
		}

		virtual public void AddPersonOneSort1 (Person value)
		{
			Strategy.AddCompositeRole(Meta.PersonOneSort1, value);
		}

		virtual public void RemovePersonOneSort1 (Person value)
		{
			Strategy.RemoveCompositeRole(Meta.PersonOneSort1,value);
		}

		virtual public bool ExistPersonsOneSort1
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.PersonOneSort1);
			}
		}

		virtual public void RemovePersonsOneSort1()
		{
			Strategy.RemoveCompositeRoles(Meta.PersonOneSort1);
		}


		virtual public global::Allors.Extent<Person> PersonsManySort1
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.PersonManySort1);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.PersonManySort1, value);
			}
		}

		virtual public void AddPersonManySort1 (Person value)
		{
			Strategy.AddCompositeRole(Meta.PersonManySort1, value);
		}

		virtual public void RemovePersonManySort1 (Person value)
		{
			Strategy.RemoveCompositeRole(Meta.PersonManySort1,value);
		}

		virtual public bool ExistPersonsManySort1
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.PersonManySort1);
			}
		}

		virtual public void RemovePersonsManySort1()
		{
			Strategy.RemoveCompositeRoles(Meta.PersonManySort1);
		}


		virtual public global::Allors.Extent<Named> NamedsManySort1
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.NamedManySort1);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.NamedManySort1, value);
			}
		}

		virtual public void AddNamedManySort1 (Named value)
		{
			Strategy.AddCompositeRole(Meta.NamedManySort1, value);
		}

		virtual public void RemoveNamedManySort1 (Named value)
		{
			Strategy.RemoveCompositeRole(Meta.NamedManySort1,value);
		}

		virtual public bool ExistNamedsManySort1
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.NamedManySort1);
			}
		}

		virtual public void RemoveNamedsManySort1()
		{
			Strategy.RemoveCompositeRoles(Meta.NamedManySort1);
		}


		virtual public global::Allors.Extent<Person> PersonsManySort2
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.PersonManySort2);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.PersonManySort2, value);
			}
		}

		virtual public void AddPersonManySort2 (Person value)
		{
			Strategy.AddCompositeRole(Meta.PersonManySort2, value);
		}

		virtual public void RemovePersonManySort2 (Person value)
		{
			Strategy.RemoveCompositeRole(Meta.PersonManySort2,value);
		}

		virtual public bool ExistPersonsManySort2
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.PersonManySort2);
			}
		}

		virtual public void RemovePersonsManySort2()
		{
			Strategy.RemoveCompositeRoles(Meta.PersonManySort2);
		}


		virtual public global::Allors.Extent<Person> PersonsOneSort2
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.PersonOneSort2);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.PersonOneSort2, value);
			}
		}

		virtual public void AddPersonOneSort2 (Person value)
		{
			Strategy.AddCompositeRole(Meta.PersonOneSort2, value);
		}

		virtual public void RemovePersonOneSort2 (Person value)
		{
			Strategy.RemoveCompositeRole(Meta.PersonOneSort2,value);
		}

		virtual public bool ExistPersonsOneSort2
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.PersonOneSort2);
			}
		}

		virtual public void RemovePersonsOneSort2()
		{
			Strategy.RemoveCompositeRoles(Meta.PersonOneSort2);
		}


		virtual public Named NamedManySort2
		{ 
			get
			{
				return (Named) Strategy.GetCompositeRole(Meta.NamedManySort2);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.NamedManySort2 ,value);
			}
		}

		virtual public bool ExistNamedManySort2
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.NamedManySort2);
			}
		}

		virtual public void RemoveNamedManySort2()
		{
			Strategy.RemoveCompositeRole(Meta.NamedManySort2);
		}


		virtual public global::Allors.Extent<Person> Many2ManyPersons
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.Many2ManyPerson);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.Many2ManyPerson, value);
			}
		}

		virtual public void AddMany2ManyPerson (Person value)
		{
			Strategy.AddCompositeRole(Meta.Many2ManyPerson, value);
		}

		virtual public void RemoveMany2ManyPerson (Person value)
		{
			Strategy.RemoveCompositeRole(Meta.Many2ManyPerson,value);
		}

		virtual public bool ExistMany2ManyPersons
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.Many2ManyPerson);
			}
		}

		virtual public void RemoveMany2ManyPersons()
		{
			Strategy.RemoveCompositeRoles(Meta.Many2ManyPerson);
		}


		virtual public global::Allors.Extent<Company> Children
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.Child);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.Child, value);
			}
		}

		virtual public void AddChild (Company value)
		{
			Strategy.AddCompositeRole(Meta.Child, value);
		}

		virtual public void RemoveChild (Company value)
		{
			Strategy.RemoveCompositeRole(Meta.Child,value);
		}

		virtual public bool ExistChildren
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.Child);
			}
		}

		virtual public void RemoveChildren()
		{
			Strategy.RemoveCompositeRoles(Meta.Child);
		}


		virtual public global::Allors.Extent<Named> NamedsOneSort1
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.NamedOneSort1);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.NamedOneSort1, value);
			}
		}

		virtual public void AddNamedOneSort1 (Named value)
		{
			Strategy.AddCompositeRole(Meta.NamedOneSort1, value);
		}

		virtual public void RemoveNamedOneSort1 (Named value)
		{
			Strategy.RemoveCompositeRole(Meta.NamedOneSort1,value);
		}

		virtual public bool ExistNamedsOneSort1
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.NamedOneSort1);
			}
		}

		virtual public void RemoveNamedsOneSort1()
		{
			Strategy.RemoveCompositeRoles(Meta.NamedOneSort1);
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



		virtual public global::System.Int32? Index 
		{
			get
			{
				return (global::System.Int32?) Strategy.GetUnitRole(Meta.Index);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Index, value);
			}
		}

		virtual public bool ExistIndex{
			get
			{
				return Strategy.ExistUnitRole(Meta.Index);
			}
		}

		virtual public void RemoveIndex()
		{
			Strategy.RemoveUnitRole(Meta.Index);
		}



		virtual public global::Allors.Extent<Person> PersonsWhereCompany
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PersonsWhereCompany);
			}
		}

		virtual public bool ExistPersonsWhereCompany
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PersonsWhereCompany);
			}
		}


		virtual public Company CompanyWhereChild
		{ 
			get
			{
				return (Company) Strategy.GetCompositeAssociation(Meta.CompanyWhereChild);
			}
		} 

		virtual public bool ExistCompanyWhereChild
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.CompanyWhereChild);
			}
		}


		virtual public Company CompanyWhereNamedOneSort2
		{ 
			get
			{
				return (Company) Strategy.GetCompositeAssociation(Meta.CompanyWhereNamedOneSort2);
			}
		} 

		virtual public bool ExistCompanyWhereNamedOneSort2
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.CompanyWhereNamedOneSort2);
			}
		}


		virtual public global::Allors.Extent<Company> CompaniesWhereNamedManySort1
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.CompaniesWhereNamedManySort1);
			}
		}

		virtual public bool ExistCompaniesWhereNamedManySort1
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.CompaniesWhereNamedManySort1);
			}
		}


		virtual public global::Allors.Extent<Company> CompaniesWhereNamedManySort2
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.CompaniesWhereNamedManySort2);
			}
		}

		virtual public bool ExistCompaniesWhereNamedManySort2
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.CompaniesWhereNamedManySort2);
			}
		}


		virtual public Company CompanyWhereNamedOneSort1
		{ 
			get
			{
				return (Company) Strategy.GetCompositeAssociation(Meta.CompanyWhereNamedOneSort1);
			}
		} 

		virtual public bool ExistCompanyWhereNamedOneSort1
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.CompanyWhereNamedOneSort1);
			}
		}

	}

	public class CompanyMeta
	{
		public static readonly CompanyMeta Instance = new CompanyMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.Company;

		public global::Allors.Meta.RoleType Manager 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CompanyManager;
			}
		} 
		public global::Allors.Meta.RoleType Employee 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CompanyEmployee;
			}
		} 
		public global::Allors.Meta.RoleType FirstPerson 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CompanyFirstPerson;
			}
		} 
		public global::Allors.Meta.RoleType NamedOneSort2 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CompanyNamedOneSort2;
			}
		} 
		public global::Allors.Meta.RoleType Owner 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CompanyOwner;
			}
		} 
		public global::Allors.Meta.RoleType IndexedMany2ManyPerson 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CompanyIndexedMany2ManyPerson;
			}
		} 
		public global::Allors.Meta.RoleType PersonOneSort1 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CompanyPersonOneSort1;
			}
		} 
		public global::Allors.Meta.RoleType PersonManySort1 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CompanyPersonManySort1;
			}
		} 
		public global::Allors.Meta.RoleType NamedManySort1 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CompanyNamedManySort1;
			}
		} 
		public global::Allors.Meta.RoleType PersonManySort2 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CompanyPersonManySort2;
			}
		} 
		public global::Allors.Meta.RoleType PersonOneSort2 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CompanyPersonOneSort2;
			}
		} 
		public global::Allors.Meta.RoleType NamedManySort2 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CompanyNamedManySort2;
			}
		} 
		public global::Allors.Meta.RoleType Many2ManyPerson 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CompanyMany2ManyPerson;
			}
		} 
		public global::Allors.Meta.RoleType Child 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CompanyChild;
			}
		} 
		public global::Allors.Meta.RoleType NamedOneSort1 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CompanyNamedOneSort1;
			}
		} 
		public global::Allors.Meta.RoleType Name 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.NamedName;
			}
		} 
		public global::Allors.Meta.RoleType Index 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.NamedIndex;
			}
		} 

		public global::Allors.Meta.AssociationType PersonsWhereCompany 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PersonCompany;
			}
		} 
		public global::Allors.Meta.AssociationType CompanyWhereChild 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CompanyChild;
			}
		} 
		public global::Allors.Meta.AssociationType CompanyWhereNamedOneSort2 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CompanyNamedOneSort2;
			}
		} 
		public global::Allors.Meta.AssociationType CompaniesWhereNamedManySort1 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CompanyNamedManySort1;
			}
		} 
		public global::Allors.Meta.AssociationType CompaniesWhereNamedManySort2 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CompanyNamedManySort2;
			}
		} 
		public global::Allors.Meta.AssociationType CompanyWhereNamedOneSort1 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.CompanyNamedOneSort1;
			}
		} 

	}
}