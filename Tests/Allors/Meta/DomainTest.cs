//------------------------------------------------------------------------------------------------- 
// <copyright file="DomainTest.cs" company="Allors bvba">
// Copyright 2002-2013 Allors bvba.
// Dual Licensed under
//   a) the Lesser General Public Licence v3 (LGPL)
//   b) the Allors License
// The LGPL License is included in the file lgpl.txt.
// The Allors License is an addendum to your contract.
// Allors Platform is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// For more information visit http://www.allors.com/legal
// </copyright>
// <summary>Defines the DomainTest type.</summary>
//-------------------------------------------------------------------------------------------------

namespace Allors.Meta.Static
{
    using System;
    using System.Linq;

    using NUnit.Framework;

    [TestFixture]
    public class DomainTest : AbstractTest
    {
        [Test]
        public void DefinedInheritances()
        {
            var domain = this.Domain;
            var superdomain = new Domain(this.MetaPopulation, Guid.NewGuid());
            domain.AddDirectSuperdomain(superdomain);

            var c1 = new ClassBuilder(domain, Guid.NewGuid()).WithSingularName("c1").WithPluralName("c1s").Build();
            var c2 = new ClassBuilder(superdomain, Guid.NewGuid()).WithSingularName("c2").WithPluralName("c2s").Build();

            var i1 = new InterfaceBuilder(domain, Guid.NewGuid()).WithSingularName("i1").WithPluralName("i1s").Build();
            var i2 = new InterfaceBuilder(superdomain, Guid.NewGuid()).WithSingularName("i2").WithPluralName("i2s").Build();

            Assert.AreEqual(0, domain.DefinedInheritances.Count());
            Assert.AreEqual(0, superdomain.DefinedInheritances.Count());

            new InheritanceBuilder(domain, Guid.NewGuid()).WithSubtype(c1).WithSupertype(i1).Build();

            Assert.AreEqual(1, this.Domain.DefinedInheritances.Count());
            Assert.AreEqual(0, superdomain.DefinedInheritances.Count());

            new InheritanceBuilder(superdomain, Guid.NewGuid()).WithSubtype(c2).WithSupertype(i2).Build();

            Assert.AreEqual(1, this.Domain.DefinedInheritances.Count());
            Assert.AreEqual(1, superdomain.DefinedInheritances.Count());

            new InheritanceBuilder(domain, Guid.NewGuid()).WithSubtype(c1).WithSupertype(i2).Build();

            Assert.AreEqual(2, this.Domain.DefinedInheritances.Count());
            Assert.AreEqual(1, superdomain.DefinedInheritances.Count());
        }


        [Test]
        public void DefinedClasses()
        {
            var domain = this.Domain;
            var superdomain = new Domain(this.MetaPopulation, Guid.NewGuid());
            domain.AddDirectSuperdomain(superdomain);

            Assert.AreEqual(0, domain.DefinedClasses.Count());
            Assert.AreEqual(0, superdomain.DefinedClasses.Count());

            var c1 = new ClassBuilder(domain, Guid.NewGuid()).WithSingularName("c1").WithPluralName("c1s").Build();

            Assert.AreEqual(1, domain.DefinedClasses.Count());
            Assert.AreEqual(0, superdomain.DefinedClasses.Count());

            var c2 = new ClassBuilder(superdomain, Guid.NewGuid()).WithSingularName("c2").WithPluralName("c2s").Build();

            Assert.AreEqual(1, domain.DefinedClasses.Count());
            Assert.AreEqual(1, superdomain.DefinedClasses.Count());
        }

        [Test]
        public void DefinedUnits()
        {
            var metaPopulation = new MetaPopulation();
            var domain = new Domain(metaPopulation, Guid.NewGuid());
            var superdomain = new Domain(metaPopulation, Guid.NewGuid());
            domain.AddDirectSuperdomain(superdomain);

            Assert.AreEqual(0, domain.DefinedUnits.Count());
            Assert.AreEqual(0, superdomain.DefinedUnits.Count());

            var allorsString = new UnitBuilder(domain, UnitIds.StringId).WithSingularName("AllorsString").WithPluralName("AllorsStrings").WithUnitTag(UnitTags.AllorsString).Build();

            Assert.AreEqual(1, domain.DefinedUnits.Count());
            Assert.AreEqual(0, superdomain.DefinedUnits.Count());

            var allorsInteger = new UnitBuilder(superdomain, UnitIds.IntegerId).WithSingularName("AllorsInteger").WithPluralName("AllorsIntegers").WithUnitTag(UnitTags.AllorsInteger).Build();

            Assert.AreEqual(1, domain.DefinedUnits.Count());
            Assert.AreEqual(1, superdomain.DefinedUnits.Count());
        }

        [Test]
        public void Create()
        {
            var metaPopulation = new MetaPopulation();
            var domain = new Domain(metaPopulation, Guid.NewGuid()) { Name = "Domain" };

            var validationReport = this.MetaPopulation.Validate();
            Assert.IsFalse(validationReport.ContainsErrors);

            Assert.AreEqual(1, metaPopulation.Domains.Count());

            Assert.AreEqual(0, domain.DirectSuperdomains.Count());
            Assert.AreEqual(0, domain.DefinedAssociationTypes.Count());
            Assert.AreEqual(0, domain.DefinedClasses.Count());
            Assert.AreEqual(0, domain.DefinedInheritances.Count());
            Assert.AreEqual(0, domain.DefinedInterfaces.Count());
            Assert.AreEqual(0, domain.DefinedMethodTypes.Count());
            Assert.AreEqual(0, domain.DefinedRelationTypes.Count());
            Assert.AreEqual(0, domain.DefinedRoleTypes.Count());
            Assert.AreEqual(0, domain.DefinedUnits.Count());

            var superdomain = new Domain(metaPopulation, Guid.NewGuid()) { Name = "Superdomain" };

            Assert.AreEqual(2, metaPopulation.Domains.Count());

            domain.AddDirectSuperdomain(superdomain);

            Assert.AreEqual(2, metaPopulation.Domains.Count());

            Assert.AreEqual(1, domain.DirectSuperdomains.Count());
            Assert.AreEqual(0, domain.DefinedAssociationTypes.Count());
            Assert.AreEqual(0, domain.DefinedClasses.Count());
            Assert.AreEqual(0, domain.DefinedInheritances.Count());
            Assert.AreEqual(0, domain.DefinedInterfaces.Count());
            Assert.AreEqual(0, domain.DefinedMethodTypes.Count());
            Assert.AreEqual(0, domain.DefinedRelationTypes.Count());
            Assert.AreEqual(0, domain.DefinedRoleTypes.Count());
            Assert.AreEqual(0, domain.DefinedUnits.Count());

            Assert.AreEqual(0, superdomain.DirectSuperdomains.Count());
            Assert.AreEqual(0, superdomain.DefinedAssociationTypes.Count());
            Assert.AreEqual(0, superdomain.DefinedClasses.Count());
            Assert.AreEqual(0, superdomain.DefinedInheritances.Count());
            Assert.AreEqual(0, superdomain.DefinedInterfaces.Count());
            Assert.AreEqual(0, superdomain.DefinedMethodTypes.Count());
            Assert.AreEqual(0, superdomain.DefinedRelationTypes.Count());
            Assert.AreEqual(0, superdomain.DefinedRoleTypes.Count());
            Assert.AreEqual(0, superdomain.DefinedUnits.Count());
        }

        //[Test]
        //public void Units()
        //{
        //    this.Populate();

        //    Assert.AreEqual(9, this.Domain.UnitObjectTypes.Length);
        //    Assert.AreEqual(9, this.Population.UnitTypes.Length);

        //    var unit = this.Population.SuperDomain.AddDeclaredObjectType(Guid.NewGuid());
        //    unit.IsUnit = true;

        //    Assert.AreEqual(10, this.Domain.UnitObjectTypes.Length);
        //    Assert.AreEqual(10, this.Population.UnitTypes.Length);

        //    var composite = this.Population.SuperDomain.AddDeclaredObjectType(Guid.NewGuid());
        //    composite.IsUnit = false;

        //    Assert.AreEqual(10, this.Domain.UnitObjectTypes.Length);
        //    Assert.AreEqual(10, this.Population.UnitTypes.Length);
        //}

        //[Test]
        //public void Validate()
        //{
        //    var domain = MetaDomain.Create();
        //    domain.Name = "MySuperDomain";

        //    var validationReport = domain.Validate();
        //    Assert.IsFalse(validationReport.ContainsErrors);

        //    domain.Name = string.Empty;

        //    validationReport = domain.Validate();
        //    Assert.IsTrue(validationReport.ContainsErrors);
        //    Assert.AreEqual(1, validationReport.Errors.Length);
        //    Assert.AreEqual(domain, validationReport.Errors[0].Source);
        //    Assert.AreEqual(1, validationReport.Errors[0].Members.Length);
        //    Assert.AreEqual(AllorsEmbeddedDomain.DomainName, validationReport.Errors[0].Members[0]);
        //    Assert.AreEqual(ValidationKind.Required, validationReport.Errors[0].Kind);

        //    domain.Name = "_";

        //    validationReport = domain.Validate();
        //    Assert.IsTrue(validationReport.ContainsErrors);
        //    Assert.AreEqual(1, validationReport.Errors.Length);
        //    Assert.AreEqual(domain, validationReport.Errors[0].Source);
        //    Assert.AreEqual(1, validationReport.Errors[0].Members.Length);
        //    Assert.AreEqual(AllorsEmbeddedDomain.DomainName, validationReport.Errors[0].Members[0]);
        //    Assert.AreEqual(ValidationKind.Format, validationReport.Errors[0].Kind);

        //    domain.Name = "a_";

        //    validationReport = domain.Validate();
        //    Assert.IsTrue(validationReport.ContainsErrors);
        //    Assert.AreEqual(1, validationReport.Errors.Length);
        //    Assert.AreEqual(domain, validationReport.Errors[0].Source);
        //    Assert.AreEqual(1, validationReport.Errors[0].Members.Length);
        //    Assert.AreEqual(AllorsEmbeddedDomain.DomainName, validationReport.Errors[0].Members[0]);
        //    Assert.AreEqual(ValidationKind.Format, validationReport.Errors[0].Kind);

        //    domain.Name = "1";

        //    validationReport = domain.Validate();
        //    Assert.IsTrue(validationReport.ContainsErrors);
        //    Assert.AreEqual(1, validationReport.Errors.Length);
        //    Assert.AreEqual(domain, validationReport.Errors[0].Source);
        //    Assert.AreEqual(1, validationReport.Errors[0].Members.Length);
        //    Assert.AreEqual(AllorsEmbeddedDomain.DomainName, validationReport.Errors[0].Members[0]);
        //    Assert.AreEqual(ValidationKind.Format, validationReport.Errors[0].Kind);

        //    domain.Name = "a1";

        //    validationReport = domain.Validate();
        //    Assert.IsFalse(validationReport.ContainsErrors);
        //    Assert.AreEqual(0, validationReport.Errors.Length);

        //    domain.Name = "a";

        //    validationReport = domain.Validate();
        //    Assert.IsFalse(validationReport.ContainsErrors);
        //    Assert.AreEqual(0, validationReport.Errors.Length);
        //}

        //[Test]
        //public void ValidateDuplicateRelationAndType()
        //{
        //    this.Populate();

        //    var relationType = this.Population.SuperDomain.AddDeclaredRelationType(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid());
        //    relationType.AssociationType.ObjectType = this.Population.C1;
        //    relationType.RoleType.ObjectType = this.Population.C2;
        //    relationType.RoleType.AssignedSingularName = "bb";
        //    relationType.RoleType.AssignedPluralName = "bbs";

        //    Assert.IsTrue(this.Domain.IsValid);

        //    var type = this.Population.SuperDomain.AddDeclaredObjectType(Guid.NewGuid());
        //    type.SingularName = "C1bb";

        //    Assert.IsFalse(this.Domain.IsValid);
        //}

        //[Test]
        //public void ValidateDuplicateReverseRelationAndType()
        //{
        //    this.Populate();

        //    var relationType = this.Population.SuperDomain.AddDeclaredRelationType(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid());
        //    relationType.AssociationType.ObjectType = this.Population.C1;
        //    relationType.RoleType.ObjectType = this.Population.C2;
        //    relationType.RoleType.AssignedSingularName = "aa";
        //    relationType.RoleType.AssignedPluralName = "aas";

        //    Assert.IsTrue(this.Domain.IsValid);

        //    var type = this.Population.SuperDomain.AddDeclaredObjectType(Guid.NewGuid());
        //    type.SingularName = "aaC1";

        //    Assert.IsFalse(this.Domain.IsValid);
        //}

        //[Test]
        //public void DerivedInheritances()
        //{
        //    var domain = this.Domain;

        //    var superDomain = this.Domain.AddDirectSuperDomain(Guid.NewGuid());
        //    superDomain.Name = "SuperDomain";

        //    Assert.AreEqual(0, domain.Inheritances.Length);
        //    Assert.AreEqual(0, superDomain.Inheritances.Length);

        //    var i1 = Population.CreateInterface(superDomain, "I1");
        //    var i2 = Population.CreateInterface(superDomain, "I2");
        //    var i3 = Population.CreateInterface(superDomain, "I3");
        //    var i4 = Population.CreateInterface(superDomain, "I4");
        //    var c1 = Population.CreateClass(superDomain, "C1");

        //    var domainC1I1 = domain.AddDeclaredInheritance(Guid.NewGuid());
        //    domainC1I1.Subtype = c1;
        //    domainC1I1.Supertype = i1;

        //    Assert.AreEqual(1, domain.Inheritances.Length);
        //    Assert.AreEqual(0, superDomain.Inheritances.Length);

        //    var superDomainC1I2 = superDomain.AddDeclaredInheritance(Guid.NewGuid());
        //    superDomainC1I2.Subtype = c1;
        //    superDomainC1I2.Supertype = i2;

        //    Assert.AreEqual(2, domain.Inheritances.Length);
        //    Assert.AreEqual(1, superDomain.Inheritances.Length);

        //    var domainC1I3 = domain.AddDeclaredInheritance(Guid.NewGuid());
        //    domainC1I3.Subtype = c1;
        //    domainC1I3.Supertype = i3;

        //    Assert.AreEqual(3, domain.Inheritances.Length);
        //    Assert.AreEqual(1, superDomain.Inheritances.Length);

        //    var superDomainC1I4 = superDomain.AddDeclaredInheritance(Guid.NewGuid());
        //    superDomainC1I4.Subtype = c1;
        //    superDomainC1I4.Supertype = i4;

        //    Assert.AreEqual(4, domain.Inheritances.Length);
        //    Assert.AreEqual(2, superDomain.Inheritances.Length);

        //    var reader = new XmlTextReader(new StringReader(domain.Xml));
        //    var copy = MetaDomain.Load(reader);
        //    var copySuperDomain = (MetaDomain)copy.MetaDomain.Find(superDomain.Id);

        //    Assert.AreEqual(4, copy.Inheritances.Length);
        //    Assert.AreEqual(2, copySuperDomain.Inheritances.Length);
        //}

        //[Test]
        //public void DerivedObjectTypes()
        //{
        //    var domain = this.Domain;

        //    var superDomain = this.Domain.AddDirectSuperDomain(Guid.NewGuid());
        //    superDomain.Name = "SuperDomain";

        //    Assert.AreEqual(9, domain.ObjectTypes.Length);
        //    Assert.AreEqual(9, domain.UnitObjectTypes.Length);
        //    Assert.AreEqual(0, domain.CompositeObjectTypes.Length);
        //    Assert.AreEqual(9, superDomain.ObjectTypes.Length);
        //    Assert.AreEqual(9, domain.UnitObjectTypes.Length);
        //    Assert.AreEqual(0, domain.CompositeObjectTypes.Length);

        //    Population.CreateClass(domain, "C1");

        //    Assert.AreEqual(10, domain.ObjectTypes.Length);
        //    Assert.AreEqual(9, domain.UnitObjectTypes.Length);
        //    Assert.AreEqual(1, domain.CompositeObjectTypes.Length);
        //    Assert.AreEqual(9, superDomain.ObjectTypes.Length);
        //    Assert.AreEqual(9, superDomain.UnitObjectTypes.Length);
        //    Assert.AreEqual(0, superDomain.CompositeObjectTypes.Length);

        //    Population.CreateClass(superDomain, "C2");

        //    Assert.AreEqual(11, domain.ObjectTypes.Length);
        //    Assert.AreEqual(9, domain.UnitObjectTypes.Length);
        //    Assert.AreEqual(2, domain.CompositeObjectTypes.Length);
        //    Assert.AreEqual(10, superDomain.ObjectTypes.Length);
        //    Assert.AreEqual(9, superDomain.UnitObjectTypes.Length);
        //    Assert.AreEqual(1, superDomain.CompositeObjectTypes.Length);

        //    Population.CreateClass(domain, "C3");

        //    Assert.AreEqual(12, domain.ObjectTypes.Length);
        //    Assert.AreEqual(9, domain.UnitObjectTypes.Length);
        //    Assert.AreEqual(3, domain.CompositeObjectTypes.Length);
        //    Assert.AreEqual(10, superDomain.ObjectTypes.Length);
        //    Assert.AreEqual(9, superDomain.UnitObjectTypes.Length);
        //    Assert.AreEqual(1, superDomain.CompositeObjectTypes.Length);

        //    Population.CreateClass(superDomain, "C4");

        //    Assert.AreEqual(13, domain.ObjectTypes.Length);
        //    Assert.AreEqual(9, domain.UnitObjectTypes.Length);
        //    Assert.AreEqual(4, domain.CompositeObjectTypes.Length);
        //    Assert.AreEqual(11, superDomain.ObjectTypes.Length);
        //    Assert.AreEqual(9, superDomain.UnitObjectTypes.Length);
        //    Assert.AreEqual(2, superDomain.CompositeObjectTypes.Length);

        //    var reader = new XmlTextReader(new StringReader(domain.Xml));
        //    var copy = MetaDomain.Load(reader);
        //    var copySuperDomain = (MetaDomain)copy.MetaDomain.Find(superDomain.Id);

        //    Assert.AreEqual(13, copy.ObjectTypes.Length);
        //    Assert.AreEqual(9, copy.UnitObjectTypes.Length);
        //    Assert.AreEqual(4, copy.CompositeObjectTypes.Length);
        //    Assert.AreEqual(11, copySuperDomain.ObjectTypes.Length);
        //    Assert.AreEqual(9, copySuperDomain.UnitObjectTypes.Length);
        //    Assert.AreEqual(2, copySuperDomain.CompositeObjectTypes.Length);
        //}

        //[Test]
        //public void DerivedRelationTypes()
        //{
        //    var domain = this.Domain;

        //    var superDomain = this.Domain.AddDirectSuperDomain(Guid.NewGuid());
        //    superDomain.Name = "SuperDomain";

        //    var i1 = Population.CreateInterface(superDomain, "I1");
        //    var i2 = Population.CreateInterface(superDomain, "I2");
        //    var i3 = Population.CreateInterface(superDomain, "I3");
        //    var i4 = Population.CreateInterface(superDomain, "I4");
        //    var c1 = Population.CreateClass(superDomain, "C1");

        //    Assert.AreEqual(0, domain.RelationTypes.Length);
        //    Assert.AreEqual(0, superDomain.RelationTypes.Length);

        //    var c1i1 = domain.AddDeclaredRelationType(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid());
        //    c1i1.AssociationType.ObjectType = c1;
        //    c1i1.RoleType.ObjectType = i1;

        //    Assert.AreEqual(1, domain.RelationTypes.Length);
        //    Assert.AreEqual(0, superDomain.RelationTypes.Length);

        //    var c1i2 = superDomain.AddDeclaredRelationType(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid());
        //    c1i1.AssociationType.ObjectType = c1;
        //    c1i1.RoleType.ObjectType = i1;

        //    Assert.AreEqual(2, domain.RelationTypes.Length);
        //    Assert.AreEqual(1, superDomain.RelationTypes.Length);

        //    var reader = new XmlTextReader(new StringReader(domain.Xml));
        //    var copy = MetaDomain.Load(reader);
        //    var copySuperDomain = (MetaDomain)copy.MetaDomain.Find(superDomain.Id);

        //    Assert.AreEqual(2, copy.RelationTypes.Length);
        //    Assert.AreEqual(1, copySuperDomain.RelationTypes.Length);
        //}

        //[Test]
        //public void DerivedMethodType()
        //{
        //    var domain = this.Domain;

        //    var superDomain = this.Domain.AddDirectSuperDomain(Guid.NewGuid());
        //    superDomain.Name = "SuperDomain";

        //    domain.AddDeclaredMethodType(Guid.NewGuid());

        //    Assert.AreEqual(1, domain.MethodTypes.Length);
        //    Assert.AreEqual(0, superDomain.MethodTypes.Length);

        //    superDomain.AddDeclaredMethodType(Guid.NewGuid());

        //    Assert.AreEqual(2, domain.MethodTypes.Length);
        //    Assert.AreEqual(1, superDomain.MethodTypes.Length);

        //    domain.AddDeclaredMethodType(Guid.NewGuid());

        //    Assert.AreEqual(3, domain.MethodTypes.Length);
        //    Assert.AreEqual(1, superDomain.MethodTypes.Length);

        //    superDomain.AddDeclaredMethodType(Guid.NewGuid());

        //    Assert.AreEqual(4, domain.MethodTypes.Length);
        //    Assert.AreEqual(2, superDomain.MethodTypes.Length);

        //    var reader = new XmlTextReader(new StringReader(domain.Xml));
        //    var copy = MetaDomain.Load(reader);
        //    var copySuperDomain = (MetaDomain)copy.MetaDomain.Find(superDomain.Id);

        //    Assert.AreEqual(4, copy.MethodTypes.Length);
        //    Assert.AreEqual(2, copySuperDomain.MethodTypes.Length);
        //}

        //[Test]
        //public void DerivedSuperDomains()
        //{
        //    var domain = MetaDomain.Create();
        //    domain.Name = "Domain";

        //    Assert.AreEqual(1, domain.SuperDomains.Length);
        //    Assert.AreEqual(domain.UnitDomain, domain.SuperDomains[0]);

        //    var parent = domain.AddDirectSuperDomain(Guid.NewGuid());
        //    parent.Name = "Parent";

        //    Assert.AreEqual(1, parent.SuperDomains.Length);
        //    Assert.AreEqual(parent.UnitDomain, parent.SuperDomains[0]);

        //    Assert.AreEqual(2, domain.SuperDomains.Length);
        //    Assert.Contains(domain.UnitDomain, domain.SuperDomains);
        //    Assert.Contains(parent, domain.SuperDomains);

        //    Assert.AreEqual(domain.UnitDomain, parent.UnitDomain);

        //    var grandParent = parent.AddDirectSuperDomain(Guid.NewGuid());
        //    grandParent.Name = "Grandparent";

        //    Assert.AreEqual(1, grandParent.SuperDomains.Length);
        //    Assert.AreEqual(grandParent.UnitDomain, grandParent.SuperDomains[0]);

        //    Assert.AreEqual(2, parent.SuperDomains.Length);
        //    Assert.Contains(parent.UnitDomain, parent.SuperDomains);
        //    Assert.Contains(grandParent, parent.SuperDomains);

        //    Assert.AreEqual(3, domain.SuperDomains.Length);
        //    Assert.Contains(domain.UnitDomain, domain.SuperDomains);
        //    Assert.Contains(parent, domain.SuperDomains);
        //    Assert.Contains(grandParent, domain.SuperDomains);

        //    Assert.AreEqual(domain.UnitDomain, parent.UnitDomain);
        //    Assert.AreEqual(domain.UnitDomain, grandParent.UnitDomain);

        //    var reader = new XmlTextReader(new StringReader(domain.Xml));
        //    var copy = MetaDomain.Load(reader);
        //    var copyParent = (MetaDomain)copy.MetaDomain.Find(parent.Id);
        //    var copyGrandparent = (MetaDomain)copy.MetaDomain.Find(grandParent.Id);

        //    Assert.AreEqual(3, copy.SuperDomains.Length);
        //    Assert.Contains(copy.UnitDomain, copy.SuperDomains);
        //    Assert.Contains(copyParent, copy.SuperDomains);
        //    Assert.Contains(copyGrandparent, copy.SuperDomains);
        //}

        //[Test]
        //public void CircularSuperDomains()
        //{
        //    var domain = MetaDomain.Create();
        //    domain.Name = "Domain";

        //    Assert.AreEqual(1, domain.SuperDomains.Length);
        //    Assert.AreEqual(domain.UnitDomain, domain.SuperDomains[0]);

        //    var parent = domain.AddDirectSuperDomain(Guid.NewGuid());
        //    parent.Name = "Parent";

        //    var exceptionThrown = false;
        //    try
        //    {
        //        parent.AddDirectSuperDomain(domain);
        //    }
        //    catch
        //    {
        //        exceptionThrown = true;
        //    }

        //    Assert.AreEqual(true, exceptionThrown);

        //    exceptionThrown = false;
        //    try
        //    {
        //        domain.AddDirectSuperDomain(domain);
        //    }
        //    catch
        //    {
        //        exceptionThrown = true;
        //    }

        //    Assert.AreEqual(true, exceptionThrown);
        //}
    }

    public class DomainTestWithSuperDomains : DomainTest
    {
        protected override void Populate()
        {
            this.Population.PopulateWithSuperDomains();
        }
    }
}