// --------------------------------------------------------------------------------------------------------------------
// <copyright file="domain.g.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Domain
{
    using System;

    using Allors.Meta;

    public static class M
    {
        public static readonly Domain D;

        #region Unit Types

        public static readonly Unit AllorsString;

        public static readonly Unit AllorsInteger;

        public static readonly Unit AllorsLong;

        public static readonly Unit AllorsDecimal;

        public static readonly Unit AllorsDouble;

        public static readonly Unit AllorsBoolean;

        public static readonly Unit AllorsDateTime;

        public static readonly Unit AllorsUnique;

        public static readonly Unit AllorsBinary;

        #endregion

        #region Composite Types

        public static readonly Class ClassWithoutUnitRoles;

        public static readonly Class User;

        public static readonly Interface S1;

        public static readonly Class LT32UnitGT32Composite;

        public static readonly Interface I2;

        public static readonly Class C4;

        public static readonly Interface ILT32Unit;

        public static readonly Interface I23;

        public static readonly Class C3;

        public static readonly Interface I3;

        public static readonly Interface InterfaceWithoutConcreteClass;

        public static readonly Interface ILT32Composite;

        public static readonly Class GT32;

        public static readonly Interface IGT32Unit;

        public static readonly Interface S3;

        public static readonly Interface S4;

        public static readonly Class LT32;

        public static readonly Class Person;

        public static readonly Class C1;

        public static readonly Class C2;

        public static readonly Class Sandbox;

        public static readonly Class GT32UnitLT32Composite;

        public static readonly Interface I4;

        public static readonly Interface ISandbox;

        public static readonly Interface I12;

        public static readonly Class Company;

        public static readonly Interface S1234;

        public static readonly Class SingleUnit;

        public static readonly Interface S12;

        public static readonly Class ClassWithoutRoles;

        public static readonly Interface I34;

        public static readonly Interface IGT32Composite;

        public static readonly Interface Named;

        public static readonly Interface S2;

        public static readonly Interface I1;

        #endregion

        #region RelationTypes

        public static readonly RelationType I1I34one2many;

        public static readonly RelationType I3C4many2many;

        public static readonly RelationType IGT32CompositeSelf13;

        public static readonly RelationType S1234AllorsDouble;

        public static readonly RelationType C1DecimalBetweenA;

        public static readonly RelationType IGT32CompositeSelf31;

        public static readonly RelationType C3AllorsString;

        public static readonly RelationType C1LongLessThan;

        public static readonly RelationType I1I2one2many;

        public static readonly RelationType IGT32CompositeSelf14;

        public static readonly RelationType C1I2one2one;

        public static readonly RelationType I23AllorsString;

        public static readonly RelationType S12AllorsString;

        public static readonly RelationType C2AllorsDecimal;

        public static readonly RelationType CompanyManager;

        public static readonly RelationType C2C1many2many;

        public static readonly RelationType C1DecimalBetweenB;

        public static readonly RelationType I1I2many2one;

        public static readonly RelationType I1C2many2one;

        public static readonly RelationType C3C2many2many;

        public static readonly RelationType SandboxInvisibleMany;

        public static readonly RelationType C1Argument;

        public static readonly RelationType C2C2many2one;

        public static readonly RelationType C1S1one2many;

        public static readonly RelationType IGT32UnitAllorsString2;

        public static readonly RelationType IGT32CompositeSelf21;

        public static readonly RelationType SandboxInvisibleOne;

        public static readonly RelationType C1I12one2one;

        public static readonly RelationType I1C2one2one;

        public static readonly RelationType IGT32UnitAllorsString5;

        public static readonly RelationType IGT32UnitAllorsString19;

        public static readonly RelationType I1DecimalBetweenA;

        public static readonly RelationType I12AllorsBoolean;

        public static readonly RelationType EmployerEmployee;

        public static readonly RelationType S2AllorsString;

        public static readonly RelationType I1S1one2one;

        public static readonly RelationType IGT32CompositeSelf2;

        public static readonly RelationType S2AllorsInteger;

        public static readonly RelationType UserSelect;

        public static readonly RelationType C1AllorsString;

        public static readonly RelationType IGT32UnitAllorsString18;

        public static readonly RelationType IGT32UnitAllorsString21;

        public static readonly RelationType I12AllorsInteger;

        public static readonly RelationType I3AllorsString;

        public static readonly RelationType PersonNextPerson;

        public static readonly RelationType C2AllorsDouble;

        public static readonly RelationType IGT32UnitAllorsString31;

        public static readonly RelationType CompanyFirstPerson;

        public static readonly RelationType I1I12many2one;

        public static readonly RelationType I1AllorsString;

        public static readonly RelationType I1DateTimeLessThan;

        public static readonly RelationType S1AllorsDecimal;

        public static readonly RelationType C3I4one2one;

        public static readonly RelationType S1234AllorsDecimal;

        public static readonly RelationType I3I4one2many;

        public static readonly RelationType I12I34one2many;

        public static readonly RelationType I1C2one2many;

        public static readonly RelationType C1C1many2one;

        public static readonly RelationType C1S2many2one;

        public static readonly RelationType I1StringLarge;

        public static readonly RelationType S12AllorsDateTime;

        public static readonly RelationType I1DoubleLessThan;

        public static readonly RelationType CompanyNamedOneSort2;

        public static readonly RelationType C1DoubleBetweenA;

        public static readonly RelationType C1Many2One;

        public static readonly RelationType C1C1many2many;

        public static readonly RelationType I1AllorsDateTime;

        public static readonly RelationType I12C3many2one;

        public static readonly RelationType I1C1many2one;

        public static readonly RelationType I2AllorsBoolean;

        public static readonly RelationType I1LongBetweenB;

        public static readonly RelationType I12C2many2one;

        public static readonly RelationType C1S1many2many;

        public static readonly RelationType IGT32UnitAllorsString15;

        public static readonly RelationType I34AllorsDecimal;

        public static readonly RelationType I1I12one2one;

        public static readonly RelationType ISandboxInvisibleValue;

        public static readonly RelationType C1DoubleBetweenB;

        public static readonly RelationType C3C4many2one;

        public static readonly RelationType I1DecimalGreaterThan;

        public static readonly RelationType S12C2many2many;

        public static readonly RelationType I3C4one2many;

        public static readonly RelationType IGT32CompositeSelf23;

        public static readonly RelationType IGT32CompositeSelf22;

        public static readonly RelationType I3I4many2many;

        public static readonly RelationType C1I1one2one;

        public static readonly RelationType C2AllorsLong;

        public static readonly RelationType C2AllorsInteger;

        public static readonly RelationType I1C1one2one;

        public static readonly RelationType CompanyOwner;

        public static readonly RelationType S1234AllorsInteger;

        public static readonly RelationType I1LongLessThan;

        public static readonly RelationType C1IntegerLessThan;

        public static readonly RelationType C2C2many2many;

        public static readonly RelationType I1I2many2many;

        public static readonly RelationType I34AllorsBoolean;

        public static readonly RelationType S1234S1234many2one;

        public static readonly RelationType C1StringLarge;

        public static readonly RelationType C1I2one2many;

        public static readonly RelationType IGT32UnitAllorsString6;

        public static readonly RelationType C1C1one2one;

        public static readonly RelationType I12AllorsDouble;

        public static readonly RelationType C1DoubleGreaterThan;

        public static readonly RelationType S1AllorsInteger;

        public static readonly RelationType C1I2many2one;

        public static readonly RelationType I2AllorsDecimal;

        public static readonly RelationType IGT32CompositeSelf18;

        public static readonly RelationType IGT32UnitAllorsString27;

        public static readonly RelationType CompanyIndexedMany2ManyPerson;

        public static readonly RelationType I1IntegerBetweenA;

        public static readonly RelationType I1I34many2one;

        public static readonly RelationType S1AllorsBinary;

        public static readonly RelationType I3I4many2one;

        public static readonly RelationType S1234C2one2one;

        public static readonly RelationType I1DoubleBetweenA;

        public static readonly RelationType I1IntegerLessThan;

        public static readonly RelationType C1I12many2one;

        public static readonly RelationType I1AllorsInteger;

        public static readonly RelationType C3C4many2many;

        public static readonly RelationType SandboxInvisibleValue;

        public static readonly RelationType IGT32UnitAllorsString11;

        public static readonly RelationType C2AllorsBoolean;

        public static readonly RelationType S12C2many2one;

        public static readonly RelationType I12I34many2one;

        public static readonly RelationType CompanyPersonOneSort1;

        public static readonly RelationType IGT32UnitAllorsString33;

        public static readonly RelationType C1DateTimeLessThan;

        public static readonly RelationType S1AllorsUnique;

        public static readonly RelationType CompanyPersonManySort1;

        public static readonly RelationType S1StringLarge;

        public static readonly RelationType ILT32UnitAllorsString1;

        public static readonly RelationType I1S2one2one;

        public static readonly RelationType S1S2many2one;

        public static readonly RelationType C1DateTimeBetweenA;

        public static readonly RelationType I1AllorsBoolean;

        public static readonly RelationType PersonCompany;

        public static readonly RelationType IGT32CompositeSelf17;

        public static readonly RelationType I1I1many2one;

        public static readonly RelationType S1S2one2many;

        public static readonly RelationType IGT32CompositeSelf3;

        public static readonly RelationType IGT32UnitAllorsString32;

        public static readonly RelationType I1C1many2many;

        public static readonly RelationType S1AllorsDouble;

        public static readonly RelationType I1I2one2one;

        public static readonly RelationType S1AllorsString;

        public static readonly RelationType I12I34many2many;

        public static readonly RelationType C1C2many2many;

        public static readonly RelationType C1S1many2one;

        public static readonly RelationType S1234C2many2many;

        public static readonly RelationType I12C3one2one;

        public static readonly RelationType S2AllorsDouble;

        public static readonly RelationType I1AllorsLong;

        public static readonly RelationType S1C1many2one;

        public static readonly RelationType IGT32CompositeSelf29;

        public static readonly RelationType IGT32UnitAllorsString25;

        public static readonly RelationType ISandboxInvisibleMany;

        public static readonly RelationType C1I1many2many;

        public static readonly RelationType IGT32UnitAllorsString8;

        public static readonly RelationType C1DoubleLessThan;

        public static readonly RelationType IGT32CompositeSelf26;

        public static readonly RelationType C2C1many2one;

        public static readonly RelationType I12C2many2many;

        public static readonly RelationType C1I1many2one;

        public static readonly RelationType I1AllorsDecimal;

        public static readonly RelationType IGT32UnitAllorsString28;

        public static readonly RelationType I2AllorsDateTime;

        public static readonly RelationType I1S1many2many;

        public static readonly RelationType S12C2one2one;

        public static readonly RelationType IGT32UnitAllorsString29;

        public static readonly RelationType SandboxTest;

        public static readonly RelationType C1LongGreaterThan;

        public static readonly RelationType C1DecimalGreaterThan;

        public static readonly RelationType C1AllorsDecimal;

        public static readonly RelationType IGT32UnitAllorsString20;

        public static readonly RelationType IGT32CompositeSelf4;

        public static readonly RelationType IGT32UnitAllorsString16;

        public static readonly RelationType IGT32CompositeSelf8;

        public static readonly RelationType C3I4many2many;

        public static readonly RelationType IGT32UnitAllorsString30;

        public static readonly RelationType S1C1one2one;

        public static readonly RelationType S1234S1234one2many;

        public static readonly RelationType I1DateTimeGreaterThan;

        public static readonly RelationType IGT32CompositeSelf24;

        public static readonly RelationType IGT32CompositeSelf12;

        public static readonly RelationType I1I34many2many;

        public static readonly RelationType C1AllorsLong;

        public static readonly RelationType C3C2one2many;

        public static readonly RelationType I1I34one2one;

        public static readonly RelationType C1S2one2one;

        public static readonly RelationType C1DateTimeBetweenB;

        public static readonly RelationType S1234C2one2many;

        public static readonly RelationType I12AllorsLong;

        public static readonly RelationType C2C1one2one;

        public static readonly RelationType C3C2many2one;

        public static readonly RelationType I1I1one2many;

        public static readonly RelationType IGT32UnitAllorsString12;

        public static readonly RelationType I1I1many2many;

        public static readonly RelationType I1S2many2many;

        public static readonly RelationType C1AllorsBinary;

        public static readonly RelationType IGT32CompositeSelf7;

        public static readonly RelationType CompanyNamedManySort1;

        public static readonly RelationType S2AllorsBoolean;

        public static readonly RelationType I1I12many2many;

        public static readonly RelationType I34AllorsDouble;

        public static readonly RelationType C2AllorsString;

        public static readonly RelationType S2AllorsDecimal;

        public static readonly RelationType C1DateTimeGreaterThan;

        public static readonly RelationType C1S1one2one;

        public static readonly RelationType C2C2one2one;

        public static readonly RelationType C4AllorsString;

        public static readonly RelationType I1StringEquals;

        public static readonly RelationType I2AllorsString;

        public static readonly RelationType I12AllorsDecimal;

        public static readonly RelationType S1AllorsBoolean;

        public static readonly RelationType IGT32UnitAllorsString26;

        public static readonly RelationType IGT32CompositeSelf6;

        public static readonly RelationType S1234S1234many2many;

        public static readonly RelationType S2AllorsDateTime;

        public static readonly RelationType S12C2one2many;

        public static readonly RelationType I1LongGreaterThan;

        public static readonly RelationType I1I12one2many;

        public static readonly RelationType IGT32UnitAllorsString17;

        public static readonly RelationType IGT32UnitAllorsString4;

        public static readonly RelationType I1S2one2many;

        public static readonly RelationType IGT32UnitAllorsString10;

        public static readonly RelationType C2C2one2many;

        public static readonly RelationType S12AllorsBoolean;

        public static readonly RelationType CompanyPersonManySort2;

        public static readonly RelationType C1C1one2many;

        public static readonly RelationType IGT32UnitAllorsString23;

        public static readonly RelationType C1I1one2many;

        public static readonly RelationType C1C2many2one;

        public static readonly RelationType S12AllorsDouble;

        public static readonly RelationType SingleUnitAllorsInteger;

        public static readonly RelationType C1I12one2many;

        public static readonly RelationType IGT32CompositeSelf25;

        public static readonly RelationType I12C2one2one;

        public static readonly RelationType S1234AllorsLong;

        public static readonly RelationType I12C3one2many;

        public static readonly RelationType C1S2many2many;

        public static readonly RelationType ILT32UnitAllorsString3;

        public static readonly RelationType S1234ClassName;

        public static readonly RelationType IGT32UnitAllorsString24;

        public static readonly RelationType InterfaceWithoutConcreteClassAllorsBoolean;

        public static readonly RelationType C1C2one2one;

        public static readonly RelationType C1AllorsBoolean;

        public static readonly RelationType I1C2many2many;

        public static readonly RelationType IGT32CompositeSelf20;

        public static readonly RelationType C3I4many2one;

        public static readonly RelationType I12C3many2many;

        public static readonly RelationType IGT32UnitAllorsString1;

        public static readonly RelationType I1AllorsBinary;

        public static readonly RelationType IGT32CompositeSelf9;

        public static readonly RelationType S2AllorsLong;

        public static readonly RelationType UserFrom;

        public static readonly RelationType CompanyPersonOneSort2;

        public static readonly RelationType ILT32CompositeSelf3;

        public static readonly RelationType ILT32CompositeSelf2;

        public static readonly RelationType I1DecimalBetweenB;

        public static readonly RelationType S1C1many2many;

        public static readonly RelationType I1LongBetweenA;

        public static readonly RelationType S1234AllorsDateTime;

        public static readonly RelationType CompanyNamedManySort2;

        public static readonly RelationType I12PrefetchTest;

        public static readonly RelationType S1234S1234one2one;

        public static readonly RelationType I1DoubleGreaterThan;

        public static readonly RelationType I12AllorsDateTime;

        public static readonly RelationType CompanyMany2ManyPerson;

        public static readonly RelationType C1I12many2many;

        public static readonly RelationType IGT32CompositeSelf11;

        public static readonly RelationType IGT32CompositeSelf32;

        public static readonly RelationType IGT32CompositeSelf28;

        public static readonly RelationType S1S2many2many;

        public static readonly RelationType SandboxAllorsString;

        public static readonly RelationType I1IntegerBetweenB;

        public static readonly RelationType C1I2many2many;

        public static readonly RelationType I1DateTimeBetweenA;

        public static readonly RelationType IGT32CompositeSelf33;

        public static readonly RelationType IGT32UnitAllorsString14;

        public static readonly RelationType IGT32CompositeSelf27;

        public static readonly RelationType I3C4one2one;

        public static readonly RelationType I34AllorsInteger;

        public static readonly RelationType IGT32UnitAllorsString13;

        public static readonly RelationType I1AllorsDouble;

        public static readonly RelationType CompanyChild;

        public static readonly RelationType CompanyNamedOneSort1;

        public static readonly RelationType C2AllorsDateTime;

        public static readonly RelationType NamedName;

        public static readonly RelationType IGT32UnitAllorsString22;

        public static readonly RelationType ILT32UnitAllorsString2;

        public static readonly RelationType C1AllorsUnique;

        public static readonly RelationType S12AllorsInteger;

        public static readonly RelationType I2AllorsLong;

        public static readonly RelationType ILT32CompositeSelf1;

        public static readonly RelationType C3C4one2many;

        public static readonly RelationType I1S1one2many;

        public static readonly RelationType IGT32CompositeSelf30;

        public static readonly RelationType I2AllorsInteger;

        public static readonly RelationType I3I4one2one;

        public static readonly RelationType C1C3one2one;

        public static readonly RelationType I3C4many2one;

        public static readonly RelationType I34AllorsString;

        public static readonly RelationType C3C2one2one;

        public static readonly RelationType C2C1one2many;

        public static readonly RelationType C2C3Many2Many;

        public static readonly RelationType C3C4one2one;

        public static readonly RelationType C1C3many2many;

        public static readonly RelationType IGT32UnitAllorsString3;

        public static readonly RelationType ISandboxInvisibleOne;

        public static readonly RelationType S1S2one2one;

        public static readonly RelationType C1StringEquals;

        public static readonly RelationType C3StringEquals;

        public static readonly RelationType I1I1one2one;

        public static readonly RelationType S1AllorsLong;

        public static readonly RelationType S1234C2many2one;

        public static readonly RelationType I3StringEquals;

        public static readonly RelationType C1LongBetweenA;

        public static readonly RelationType C1IntegerGreaterThan;

        public static readonly RelationType I12AllorsString;

        public static readonly RelationType S1AllorsDateTime;

        public static readonly RelationType IGT32UnitAllorsString7;

        public static readonly RelationType C1C3may2one;

        public static readonly RelationType C1IntegerBetweenB;

        public static readonly RelationType IGT32CompositeSelf1;

        public static readonly RelationType IGT32UnitAllorsString9;

        public static readonly RelationType S1234AllorsString;

        public static readonly RelationType I1IntegerGreaterThan;

        public static readonly RelationType IGT32CompositeSelf15;

        public static readonly RelationType C3I4one2many;

        public static readonly RelationType I1S1many2one;

        public static readonly RelationType I1DoubleBetweenB;

        public static readonly RelationType S1234AllorsBoolean;

        public static readonly RelationType C1AllorsDateTime;

        public static readonly RelationType C1IntegerBetweenA;

        public static readonly RelationType S1C1one2many;

        public static readonly RelationType IGT32CompositeSelf5;

        public static readonly RelationType I1DecimalLessThan;

        public static readonly RelationType C1AllorsDouble;

        public static readonly RelationType C1LongBetweenB;

        public static readonly RelationType I12I34one2one;

        public static readonly RelationType C2C3Many2One;

        public static readonly RelationType I12C2one2many;

        public static readonly RelationType C1C2one2many;

        public static readonly RelationType C1S2one2many;

        public static readonly RelationType C1AllorsInteger;

        public static readonly RelationType I1DateTimeBetweenB;

        public static readonly RelationType S12AllorsDecimal;

        public static readonly RelationType I1AllorsUnique;

        public static readonly RelationType I3C1one2one;

        public static readonly RelationType I2AllorsDouble;

        public static readonly RelationType I1C1one2many;

        public static readonly RelationType C1DecimalLessThan;

        public static readonly RelationType NamedIndex;

        public static readonly RelationType IGT32CompositeSelf19;

        public static readonly RelationType I1S2many2one;

        public static readonly RelationType C1C3one2many;

        public static readonly RelationType IGT32CompositeSelf10;

        public static readonly RelationType IGT32CompositeSelf16;

        #endregion

        static M()
        {
            D = new Domain(new Guid("26B81EE6-08B6-48E8-931C-B8D944ED1C42")) { Name = "WithoutPart" };

            AllorsString = (Unit)D.Find(new Guid("ad7f5ddc-bedb-4aaa-97ac-d6693a009ba9"));
            AllorsInteger = (Unit)D.Find(new Guid("ccd6f134-26de-4103-bff9-a37ec3e997a3"));
            AllorsLong = (Unit)D.Find(new Guid("e8989069-024b-4389-ac77-a98c4dfff25a"));
            AllorsDecimal = (Unit)D.Find(new Guid("da866d8e-2c40-41a8-ae5b-5f6dae0b89c8"));
            AllorsDouble = (Unit)D.Find(new Guid("ffcabd07-f35f-4083-bef6-f6c47970ca5d"));
            AllorsBoolean = (Unit)D.Find(new Guid("b5ee6cea-4e2b-498e-a5dd-24671d896477"));
            AllorsDateTime = (Unit)D.Find(new Guid("c4c09343-61d3-418c-ade2-fe6fd588f128"));
            AllorsUnique = (Unit)D.Find(new Guid("6dc0a1a8-88a4-4614-adb4-92dd3d017c0e"));
            AllorsBinary = (Unit)D.Find(new Guid("c28e515b-cae8-4d6b-95bf-062aec8042fc"));

            ClassWithoutUnitRoles = new Class(D, new Guid("071d291d-fcc6-4511-8aa2-2d30fdeede8f"))
                                        {
                                            SingularName = "ClassWithoutUnitRoles",
                                            PluralName = "ClassesWithoutUnitRoles"
                                        };

            User = new Class(D, new Guid("0d6bc154-112b-4a58-aa96-3b2a96f82523")) { SingularName = "User", PluralName = "Users" };

            S1 = new Interface(D, new Guid("15c3bb71-075d-48ad-8a00-250c2f627092")) { SingularName = "S1", PluralName = "S1s" };

            LT32UnitGT32Composite = new Class(D, new Guid("15ea889f-21d6-4682-aca2-c2987f592f0e")) { SingularName = "LT32UnitGT32Composite", PluralName = "LT32UnitGT32Composites" };

            I2 = new Interface(D, new Guid("19bb2bc3-d53a-4d15-86d0-b250fdbcb0a0")) { SingularName = "I2", PluralName = "I2s" };

            C4 = new Class(D, new Guid("20049a79-20c7-478b-a5ba-c54b1e615168")) { SingularName = "C4", PluralName = "C4s" };

            ILT32Unit = new Interface(D, new Guid("228fa79f-afa7-418c-968e-8c0d38fb3ad2")) { SingularName = "ILT32Unit", PluralName = "ILT32Units"};

            I23 = new Interface(D, new Guid("29cb9717-2452-4da0-9a29-8bd5d815307a")) { SingularName = "I23", PluralName = "I23s" };

            C3 = new Class(D, new Guid("2a9b5a77-6065-4f2a-bbc3-655426f0f97b")) { SingularName = "C3", PluralName = "C3s" };

            I3 = new Interface(D, new Guid("2d86277f-3993-4831-a7de-3640166d3d50")) { SingularName = "I3", PluralName = "I3s" };

            InterfaceWithoutConcreteClass = new Interface(D, new Guid("2f4bc713-47c9-4e07-9f2b-1d22a0cb4fad"))
                                                {
                                                    SingularName = "InterfaceWithoutConcreteClass",
                                                    PluralName = "InterfacesWithoutConcreteClass",
                                                };

            ILT32Composite = new Interface(D, new Guid("4f53e1e7-e88a-4161-969c-1fed0b3a24a2"))
                                 {
                                     SingularName = "ILT32Composite",
                                     PluralName = "ILT32Composites",
                                 };

            GT32 = new Class(D, new Guid("4f6301b3-6f0a-40c2-8267-4f8631bae706")) { SingularName = "GT32", PluralName = "GT32s" };

            IGT32Unit = new Interface(D, new Guid("584681af-90f0-45b1-a80e-6a73c3592600")) { SingularName = "IGT32Unit", PluralName = "IGT32Units" };

            S3 = new Interface(D, new Guid("5b24107d-f5e8-499b-94f7-2bf712493546")) { SingularName = "S3", PluralName = "S3s" };

            S4 = new Interface(D, new Guid("5b348bcb-823d-4cbe-b3ac-a18b1cd96581")) { SingularName = "S4", PluralName = "S4s" };

            LT32 = new Class(D, new Guid("67c8d19f-1947-487c-8884-dbd76033aab0")) { SingularName = "LT32", PluralName = "LT32s" };

            Person = new Class(D, new Guid("6a082a25-a8f2-4acd-a1a3-ba4461b729f1")) { SingularName = "Person", PluralName = "Persons" };

            C1 = new Class(D, new Guid("7041c691-d896-4628-8f50-1c24f5d03414")) { SingularName = "C1", PluralName = "C1s" };

            C2 = new Class(D, new Guid("72c07e8a-03f5-4da8-ab37-236333d4f74e")) { SingularName = "C2", PluralName = "C2s" };

            Sandbox = new Class(D, new Guid("73970b0f-1ff4-4d39-aad8-fdbfbaae472f")) { SingularName = "Sandbox", PluralName = "Sandboxes" };

            GT32UnitLT32Composite = new Class(D, new Guid("7683eb7f-cbac-4947-ac29-4ef15ae47597")) { SingularName = "GT32UnitLT32Composite", PluralName = "GT32UnitLT32Composites" };

            I4 = new Interface(D, new Guid("7a49be0e-cb91-4e1e-b113-ac67ec969935")) { SingularName = "I4", PluralName = "I4s" };

            ISandbox = new Interface(D, new Guid("7ba2ab26-491b-49eb-944c-26f6bb66e50f")) { SingularName = "ISandbox", PluralName = "ISandboxes" };

            I12 = new Interface(D, new Guid("97755724-b934-4cc5-beb4-3d49a7a4b27e")) { SingularName = "I12", PluralName = "I12s" };

            Company = new Class(D, new Guid("b1b6361e-5ee5-434c-9c92-46c6166195c4")) { SingularName = "Company", PluralName = "Companies" };

            S1234 = new Interface(D, new Guid("c3c0ecf3-9f8d-4701-854f-8ddea1bd69fd")) { SingularName = "S1234", PluralName = "S1234s" };

            SingleUnit = new Class(D, new Guid("c3e82ab0-f586-4913-acb0-838ffd6701f8")) { SingularName = "SingleUnit", PluralName = "SingleUnits" };

            S12 = new Interface(D, new Guid("c5747a64-f468-4d0d-80f3-6463bd32b0ca")) { SingularName = "S12", PluralName = "S12s" };

            ClassWithoutRoles = new Class(D, new Guid("e1008840-6d7c-4d44-b2ad-1545d23f90d8")) { SingularName = "ClassWithoutRoles", PluralName = "ClassesWithoutRoles" };

            I34 = new Interface(D, new Guid("ebc22540-54c8-4601-a43d-2ed6da9f3e79")) { SingularName = "I34", PluralName = "I34s" };

            IGT32Composite = new Interface(D, new Guid("ee84609f-e165-4037-b8ce-f7c8b826e603"))
                                 {
                                     SingularName = "IGT32Composite",
                                     PluralName = "IGT32Composites",
                                 };

            Named = new Interface(D, new Guid("fcaa52e3-4a90-4981-b45d-d158e2589506")) { SingularName = "Named", PluralName = "Nameds" };

            S2 = new Interface(D, new Guid("feeb7027-7c6c-4cb5-8718-93e6e8a4afd8")) { SingularName = "S2", PluralName = "S2s" };

            I1 = new Interface(D, new Guid("fefcf1b6-ac8f-47b0-bed5-939207a2833e")) { SingularName = "I1", PluralName = "I1s" };

            new Inheritance(D, new Guid("10d59b2a-9b59-43e3-a63d-2a5dda8f2921")) { Subtype = I2, Supertype = S1234 };

            new Inheritance(D, new Guid("1fa71df5-71a2-49f9-98eb-813f3992c4d5")) { Subtype = C2, Supertype = I2 };

            new Inheritance(D, new Guid("280e235b-f17a-4505-917e-e51647ca6928")) { Subtype = I1, Supertype = S1 };

            new Inheritance(D, new Guid("2dea90ce-fa75-45db-bba2-4713fafd061c")) { Subtype = I4, Supertype = S4 };

            new Inheritance(D, new Guid("3fea8f15-6a9e-425b-9064-3efd9b7b809a")) { Subtype = Person, Supertype = Named };

            new Inheritance(D, new Guid("44af67b9-26ae-43c1-ba80-3e8298e4bed8")) { Subtype = C3, Supertype = I3 };

            new Inheritance(D, new Guid("51509eb9-02f4-494b-ab30-04acd4286b42")) { Subtype = C4, Supertype = I4 };

            new Inheritance(D, new Guid("614c5332-4836-44fe-80c0-3196fcdbad51")) { Subtype = I3, Supertype = S1234 };

            new Inheritance(D, new Guid("71862815-beba-495c-9d30-47b5d248da34")) { Subtype = C3, Supertype = I23 };

            new Inheritance(D, new Guid("782b5d64-91f9-4e27-ad92-6a1f0a8c7e07")) { Subtype = C4, Supertype = I34 };

            new Inheritance(D, new Guid("7ba9043d-2307-4d81-b56d-b1ddbd3070e4")) { Subtype = C1, Supertype = I1 };

            new Inheritance(D, new Guid("8007d524-40f1-4a2d-9299-6fd8d53692c1")) { Subtype = C2, Supertype = I23 };

            new Inheritance(D, new Guid("941aa988-3890-420d-bd6a-515f2bc3a7f8")) { Subtype = C1, Supertype = I12 };

            new Inheritance(D, new Guid("a1c0ac5b-cffa-4a5d-8812-9383a3e1cadc")) { Subtype = I1, Supertype = S1234 };

            new Inheritance(D, new Guid("a7b5f53e-1e73-48ff-a313-16c9ebc0609d")) { Subtype = Company, Supertype = Named };

            new Inheritance(D, new Guid("ad06478b-1756-46a4-a0a2-14f0f237eb4f")) { Subtype = C2, Supertype = I12 };

            new Inheritance(D, new Guid("c53f1f14-2a22-4b6d-8e3c-3c50c07e5299")) { Subtype = I2, Supertype = S2 };

            new Inheritance(D, new Guid("c54b5dd3-1228-4ad5-9dda-8827f2d93df0")) { Subtype = S1, Supertype = S1234 };

            new Inheritance(D, new Guid("c78ab091-6fd4-4ca1-a245-525f84bff02b")) { Subtype = I3, Supertype = S3 };

            new Inheritance(D, new Guid("cef6e9fb-c5a9-473a-a25e-23bc60115012")) { Subtype = I12, Supertype = S12 };

            new Inheritance(D, new Guid("ecd3bb16-7221-440b-8ab5-01880fdd4dee")) { Subtype = I4, Supertype = S1234 };

            new Inheritance(D, new Guid("f90bfd4b-d610-46ab-a02d-5f4f2590bbcb")) { Subtype = C3, Supertype = I34 };

            I1I34one2many = new RelationType(
                D,
                new Guid("00a70a04-4fc8-4585-83ce-0f7f0e0db7ab"),
                new Guid("50a8e3e6-093e-46b9-9818-456507ca86a9"),
                new Guid("9ffd70c8-f440-47b7-9e24-3b561b03f001"))
                                {
                                    AssociationType = { ObjectType = I1 },
                                    RoleType =
                                        {
                                            ObjectType = I34,
                                            AssignedSingularName = "I34one2many",
                                            AssignedPluralName = "I34one2manies",
                                            IsMany = true
                                        }
                                };

            I3C4many2many = new RelationType(
                D,
                new Guid("00b706bb-681e-44ce-bbf3-c3b01bb11269"),
                new Guid("e1b2e665-2459-4864-a2ef-bfbb6b17e59c"),
                new Guid("6f15395d-0754-45b2-82d3-bb172c716b67"))
                                {
                                    AssociationType = { ObjectType = I3, IsMany = true },
                                    RoleType =
                                        {
                                            ObjectType = C4,
                                            AssignedSingularName = "C4many2many",
                                            AssignedPluralName = "C4many2manies",
                                            IsMany = true
                                        }
                                };

            IGT32CompositeSelf13 = new RelationType(
                D,
                new Guid("010bc5d7-9e1e-4ca7-a146-33b73252c4c8"),
                new Guid("20869686-dc42-4b08-939e-f090f5a48652"),
                new Guid("906f1f8c-348e-4eda-9f80-d8be049b921b"))
                                       {
                                           AssociationType = { ObjectType = IGT32Composite },
                                           RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self13", AssignedPluralName = "Selfs13" }
                                       };

            S1234AllorsDouble = new RelationType(
                D,
                new Guid("012a43d3-e1e0-4693-a771-1526c29b7ac4"),
                new Guid("88f61f13-20e0-4ef0-a42c-80ee1c8e001b"),
                new Guid("e77d108f-e8db-4e8c-89ae-574c7362a159")) { AssociationType = { ObjectType = S1234 }, RoleType = { ObjectType = AllorsDouble } };

            C1DecimalBetweenA = new RelationType(
                D,
                new Guid("024db9e0-b51f-4d8b-a2d0-0a041dcebd62"),
                new Guid("0498b5fc-62c0-4f80-ac09-4567929e387f"),
                new Guid("1b372270-7d7e-46ba-9840-f3143bd38afe"))
                                    {
                                        AssociationType = { ObjectType = C1 },
                                        RoleType =
                                            {
                                                ObjectType = AllorsDecimal,
                                                AssignedSingularName = "DecimalBetweenA",
                                                AssignedPluralName = "DecimalsBetweenA",
                                                Scale = 2,
                                                Precision = 19
                                            }
                                    };

            IGT32CompositeSelf31 = new RelationType(
                D,
                new Guid("02894576-278f-4cbe-9c19-346187f9006f"),
                new Guid("4adbcdce-3b81-4f30-935e-1c2bb5b1edc5"),
                new Guid("41643464-181e-4a62-bac7-f7e090e533cd"))
                                       {
                                           AssociationType = { ObjectType = IGT32Composite },
                                           RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self31", AssignedPluralName = "Selfs31" }
                                       };

            C3AllorsString = new RelationType(
                D,
                new Guid("02a07b71-a40d-4600-ae12-370be7e973f5"),
                new Guid("590d3c5a-1732-48db-ab12-d194a8cb94a9"),
                new Guid("f7e26d33-558d-4e5e-8b12-3116c110cf1f")) { AssociationType = { ObjectType = C3 }, RoleType = { ObjectType = AllorsString, Size = 256 } };

            C1LongLessThan = new RelationType(
                D,
                new Guid("03245a2b-be79-4cd5-a3fb-40ca784c108d"),
                new Guid("bb59dd46-3d4f-400c-8d6a-31f0766da775"),
                new Guid("4c182c87-8e1c-4675-b9ed-dd52cd7a5623"))
                                 {
                                     AssociationType = { ObjectType = C1 },
                                     RoleType =
                                         {
                                             ObjectType = AllorsLong,
                                             AssignedSingularName = "LongLessThan",
                                             AssignedPluralName = "LongsLessThan"
                                         }
                                 };

            I1I2one2many = new RelationType(
                D,
                new Guid("036e3008-07f8-4a15-bca2-eb21837778a0"),
                new Guid("10444cb0-848c-4253-b7e2-4323cef98699"),
                new Guid("6a8eefe5-fe39-4345-bd5e-f97851c4a086"))
                               {
                                   AssociationType = { ObjectType = I1 },
                                   RoleType =
                                       {
                                           ObjectType = I2,
                                           AssignedSingularName = "I2one2many",
                                           AssignedPluralName = "I2one2manies",
                                           IsMany = true
                                       }
                               };

            IGT32CompositeSelf14 = new RelationType(
                D,
                new Guid("03f0e0ab-d24d-4eae-9b05-0ce153055530"),
                new Guid("46026f19-4ec7-45fa-8c54-2fde42f68029"),
                new Guid("ffcee48e-209b-4178-b8ad-09bca1d76b3d"))
                                       {
                                           AssociationType = { ObjectType = IGT32Composite },
                                           RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self14", AssignedPluralName = "Selfs14" }
                                       };

            C1I2one2one = new RelationType(
                D,
                new Guid("03fc18eb-46be-411a-9b1e-4a1953843d92"),
                new Guid("dbd53cdf-83bf-4401-a1ef-f239984892e4"),
                new Guid("04d17334-dac3-48b3-83fe-214436908185"))
                              {
                                  AssociationType = { ObjectType = C1 },
                                  RoleType = { ObjectType = I2, AssignedSingularName = "I2one2one", AssignedPluralName = "I2one2ones" }
                              };

            I23AllorsString = new RelationType(
                D,
                new Guid("0407c93e-f2ea-49e4-8779-44b42c554e60"),
                new Guid("9eda27ec-db3f-420a-b9ed-4742b7105bf5"),
                new Guid("1c1d8356-9240-4582-a3ab-a8a1a2553869")) { AssociationType = { ObjectType = I23 }, RoleType = { ObjectType = AllorsString, Size = 256 } };

            S12AllorsString = new RelationType(
                D,
                new Guid("06fabe71-737a-4cff-ac10-2d15dafce503"),
                new Guid("f3b1ecf3-95d6-4b96-893e-4ffa0c69bc72"),
                new Guid("cb10aafe-0330-482c-8782-4c50fc56b00e")) { AssociationType = { ObjectType = S12 }, RoleType = { ObjectType = AllorsString, Size = 256 } };

            C2AllorsDecimal = new RelationType(
                D,
                new Guid("07eaa992-322a-40e9-bf2c-aa33b69f54cd"),
                new Guid("610f93b1-e108-4a4f-8285-a5fca8600ee3"),
                new Guid("54370233-2451-4ba1-bbd6-e573cc885b84")) { AssociationType = { ObjectType = C2 }, RoleType = { ObjectType = AllorsDecimal, Scale = 2, Precision = 19 } };

            CompanyManager = new RelationType(
                D,
                new Guid("08ab248d-bdb1-49c5-a2da-d6485f49239f"),
                new Guid("ad0ef93c-be37-48a6-97c6-fd252d66fbac"),
                new Guid("f2b72cff-9208-41c0-9c5c-09ed0725f107"))
                                 {
                                     AssociationType = { ObjectType = Company, IsMany = true },
                                     RoleType = { ObjectType = Person, AssignedSingularName = "Manager", AssignedPluralName = "Managers" }
                                 };

            C2C1many2many = new RelationType(
                D,
                new Guid("0947eb06-5511-475f-8d68-06cfb812678e"),
                new Guid("9a759774-19ae-437d-b5cb-320720a901db"),
                new Guid("402141f3-3124-42fa-904f-9ed5c0ed1e6a"))
                                {
                                    AssociationType = { ObjectType = C2, IsMany = true },
                                    RoleType =
                                        {
                                            ObjectType = C1,
                                            AssignedSingularName = "C1many2many",
                                            AssignedPluralName = "C1many2manies",
                                            IsMany = true
                                        }
                                };

            C1DecimalBetweenB = new RelationType(
                D,
                new Guid("0aefa669-9c8a-4fbf-98a4-230d93df8341"),
                new Guid("f969b93b-0e2d-4b39-889b-c079e37ef5fe"),
                new Guid("ef5ba41b-41f2-44ba-8bc0-079d738a9463"))
                                    {
                                        AssociationType = { ObjectType = C1 },
                                        RoleType =
                                            {
                                                ObjectType = AllorsDecimal,
                                                AssignedSingularName = "DecimalBetweenB",
                                                AssignedPluralName = "DecimalsBetweenB",
                                                Scale = 2,
                                                Precision = 19
                                            }
                                    };

            I1I2many2one = new RelationType(
                D,
                new Guid("0b0f8c40-266c-424a-8276-0e8e2673d1a7"),
                new Guid("c2ead9ab-c2c3-4fc0-8285-0f07b6351384"),
                new Guid("3ea290ce-f353-418c-b15a-ece3b29a7ec7"))
                               {
                                   AssociationType = { ObjectType = I1, IsMany = true },
                                   RoleType = { ObjectType = I2, AssignedSingularName = "I2many2one", AssignedPluralName = "I2many2ones" }
                               };

            I1C2many2one = new RelationType(
                D,
                new Guid("0d63e4c7-28de-4d47-8f23-7ee1d3606751"),
                new Guid("913230df-5047-4e95-9706-84d78c1270aa"),
                new Guid("73c62ba0-88b8-46eb-a2b7-350b5ba3fff9"))
                               {
                                   AssociationType = { ObjectType = I1, IsMany = true },
                                   RoleType = { ObjectType = C2, AssignedSingularName = "C2many2one", AssignedPluralName = "C2many2ones" }
                               };

            C3C2many2many = new RelationType(
                D,
                new Guid("0e06c403-2a29-4f40-b7b6-3e4fed28aeba"),
                new Guid("e64ba775-20d8-46f7-9777-e5f754d58428"),
                new Guid("8221f87c-a4b0-49fa-88cc-47aa9814d4af"))
                                {
                                    AssociationType = { ObjectType = C3, IsMany = true },
                                    RoleType =
                                        {
                                            ObjectType = C2,
                                            AssignedSingularName = "C2many2many",
                                            AssignedPluralName = "C2many2manies",
                                            IsMany = true
                                        }
                                };

            SandboxInvisibleMany = new RelationType(
                D,
                new Guid("0e0ee030-8fb5-42fb-82b5-5daade2aca9d"),
                new Guid("209d7177-b6bc-4a13-ae35-ea14e37da038"),
                new Guid("f0032ab2-d086-4d52-aa30-e295d640ed90"))
                                       {
                                           AssociationType = { ObjectType = Sandbox, IsMany = true },
                                           RoleType =
                                               {
                                                   ObjectType = Sandbox,
                                                   AssignedSingularName = "InvisibleMany",
                                                   AssignedPluralName = "InvisibleManies",
                                                   IsMany = true
                                               }
                                       };

            C1Argument = new RelationType(
                D,
                new Guid("0e57dd07-bb58-4620-a898-3060af007f60"),
                new Guid("2979d83b-03bf-4ef0-a5a5-61ffd01505f7"),
                new Guid("3f2df5f5-325f-48d0-becf-e1cb49b44770"))
                             {
                                 AssociationType = { ObjectType = C1 },
                                 RoleType =
                                     {
                                         ObjectType = AllorsString,
                                         AssignedSingularName = "Argument",
                                         AssignedPluralName = "Arguments",
                                         Size = 256
                                     }
                             };

            C2C2many2one = new RelationType(
                D,
                new Guid("0ecc2d3b-f813-44db-b349-3e67d7e0b2d7"),
                new Guid("86606949-6646-4b1e-bf65-acea7f33fd55"),
                new Guid("c9ad84d3-8328-4432-bd15-b4d88cb4f357"))
                               {
                                   AssociationType = { ObjectType = C2, IsMany = true },
                                   RoleType = { ObjectType = C2, AssignedSingularName = "C2many2one", AssignedPluralName = "C2many2ones" }
                               };

            C1S1one2many = new RelationType(
                D,
                new Guid("10df748e-3b9c-48f4-82dc-85498f199567"),
                new Guid("775863d7-ea9a-4b2c-a8f2-792bbf88288b"),
                new Guid("53e32337-f227-4a13-8fda-fa9cd0f0d2e6"))
                               {
                                   AssociationType = { ObjectType = C1 },
                                   RoleType =
                                       {
                                           ObjectType = S1,
                                           AssignedSingularName = "S1one2many",
                                           AssignedPluralName = "S1one2manies",
                                           IsMany = true
                                       }
                               };

            IGT32UnitAllorsString2 = new RelationType(
                D,
                new Guid("113ea45f-0e8a-423d-b650-30ab4ac85ebd"),
                new Guid("64072434-e5c8-438a-9027-5df836586255"),
                new Guid("bd9af785-d0e5-4455-93f5-2ff0c5d01ec9"))
                                         {
                                             AssociationType = { ObjectType = IGT32Unit },
                                             RoleType =
                                                 {
                                                     ObjectType = AllorsString,
                                                     AssignedSingularName = "AllorsString2",
                                                     AssignedPluralName = "AllorsStrings2",
                                                     Size = 256
                                                 }
                                         };

            IGT32CompositeSelf21 = new RelationType(
                D,
                new Guid("11eb24d1-0c4d-4060-8373-e2f53da416d4"),
                new Guid("0905b54f-fd9a-4c7a-ad66-4e1e74355d0f"),
                new Guid("5a2bd896-04fe-48d2-9a4b-f88f1f7e4367"))
                                       {
                                           AssociationType = { ObjectType = IGT32Composite },
                                           RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self21", AssignedPluralName = "Selfs21" }
                                       };

            SandboxInvisibleOne = new RelationType(
                D,
                new Guid("122b0376-8d1a-4d46-b8a0-9f4ea94c9e96"),
                new Guid("0d1e81f3-9025-42f3-b7a6-e2da3268667c"),
                new Guid("d4ee88a8-5404-43ae-87b4-8d8755ebe2d2"))
                                      {
                                          AssociationType = { ObjectType = Sandbox },
                                          RoleType = { ObjectType = Sandbox, AssignedSingularName = "InvisibleOne", AssignedPluralName = "InvisibleOnes" }
                                      };

            C1I12one2one = new RelationType(
                D,
                new Guid("13761939-4842-45ba-af73-2a5976e2d6e3"),
                new Guid("94f67011-ef73-44bc-bcf4-6c45b793dec3"),
                new Guid("84ab3497-a2c7-4a60-a278-b24686e6a9fa"))
                               {
                                   AssociationType = { ObjectType = C1 },
                                   RoleType = { ObjectType = I12, AssignedSingularName = "I12one2one", AssignedPluralName = "I12one2ones" }
                               };

            I1C2one2one = new RelationType(
                D,
                new Guid("14a93943-13f6-481d-98c7-19fb55625af9"),
                new Guid("729272d3-09c5-4e55-8d65-126f03e99fd2"),
                new Guid("4009851b-5819-414e-a0f2-6d9141ecdfa8"))
                              {
                                  AssociationType = { ObjectType = I1 },
                                  RoleType = { ObjectType = C2, AssignedSingularName = "C2one2one", AssignedPluralName = "C2one2ones" }
                              };

            IGT32UnitAllorsString5 = new RelationType(
                D,
                new Guid("163739dd-60aa-48b3-8566-43accb24cf0f"),
                new Guid("64a1bef9-83e7-46d7-8ebe-33632e8278e7"),
                new Guid("90fe5518-7bab-482e-84c6-f9dd3be2d849"))
                                         {
                                             AssociationType = { ObjectType = IGT32Unit },
                                             RoleType =
                                                 {
                                                     ObjectType = AllorsString,
                                                     AssignedSingularName = "AllorsString5",
                                                     AssignedPluralName = "AllorsStrings5",
                                                     Size = 256
                                                 }
                                         };

            IGT32UnitAllorsString19 = new RelationType(
                D,
                new Guid("18bf90a6-2954-4e4f-bfa9-78ede63314bf"),
                new Guid("6a876bed-11d4-4d9f-abab-f6f650ce80eb"),
                new Guid("26bdbe43-a2bc-44e3-a8a2-f84d17f57470"))
                                          {
                                              AssociationType = { ObjectType = IGT32Unit },
                                              RoleType =
                                                  {
                                                      ObjectType = AllorsString,
                                                      AssignedSingularName = "AllorsString19",
                                                      AssignedPluralName = "AllorsStrings19",
                                                      Size = 256
                                                  }
                                          };

            I1DecimalBetweenA = new RelationType(
                D,
                new Guid("19e09e31-31ac-44cc-ad1e-a015f4747aeb"),
                new Guid("c9cc42f1-4a1b-4c93-a82b-0e19ed88242a"),
                new Guid("908f646c-af46-49b2-981c-b0fe97986f0c"))
                                    {
                                        AssociationType = { ObjectType = I1 },
                                        RoleType =
                                            {
                                                ObjectType = AllorsDecimal,
                                                AssignedSingularName = "DecimalBetweenA",
                                                AssignedPluralName = "DecimalsBetweenA",
                                                Scale = 2,
                                                Precision = 19
                                            }
                                    };

            I12AllorsBoolean = new RelationType(
                D,
                new Guid("1a0eb6ea-d877-42c9-a35a-889fb347f883"),
                new Guid("4a18e24c-e031-49e4-b77a-51ebdc29952b"),
                new Guid("cf993b81-671e-44f9-b7fc-96a4f0ac8522")) { AssociationType = { ObjectType = I12 }, RoleType = { ObjectType = AllorsBoolean } };

            EmployerEmployee = new RelationType(
                D,
                new Guid("1a4087de-f116-4f79-9441-31faee8054f3"),
                new Guid("9c0ec4ba-9ef4-4d82-a94f-4984808c47cd"),
                new Guid("978f3cdd-55d9-4086-b448-c313731604d8"))
                                   {
                                       AssociationType = { ObjectType = Company },
                                       RoleType =
                                           {
                                               ObjectType = Person,
                                               AssignedSingularName = "Employee",
                                               AssignedPluralName = "Employees",
                                               IsMany = true
                                           }
                                   };

            S2AllorsString = new RelationType(
                D,
                new Guid("1c758737-140a-49f0-badc-29658b4bc55f"),
                new Guid("66f34737-9d65-4c20-a3d3-85a6b8c00891"),
                new Guid("8fedfe1b-10d0-4be8-ae87-177b77b8d36f")) { AssociationType = { ObjectType = S2 }, RoleType = { ObjectType = AllorsString, Size = 256 } };

            I1S1one2one = new RelationType(
                D,
                new Guid("1d41941b-3b1d-48d7-bc6f-e8811cbd96e4"),
                new Guid("20d5d1d7-3451-4831-870d-4dabb4ed53b0"),
                new Guid("43142b12-ccbf-4675-8893-bef0b48ffd4b"))
                              {
                                  AssociationType = { ObjectType = I1 },
                                  RoleType = { ObjectType = S1, AssignedSingularName = "S1one2one", AssignedPluralName = "S1one2one" }
                              };

            IGT32CompositeSelf2 = new RelationType(
                D,
                new Guid("1d4d3282-f7bc-4619-ae32-d987b4bd87b7"),
                new Guid("a02df71e-dcbd-422f-b82f-f5f1f62900de"),
                new Guid("aa5790c1-04f9-4114-b4a3-ae61ea7f44ad"))
                                      {
                                          AssociationType = { ObjectType = IGT32Composite },
                                          RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self2", AssignedPluralName = "Selfs2" }
                                      };

            S2AllorsInteger = new RelationType(
                D,
                new Guid("1f5a6afe-f458-43db-bea0-8c90074b5abf"),
                new Guid("3370eb80-a77b-448b-9653-d9de382481c3"),
                new Guid("a4da55d6-e7ac-4889-8479-0bd1a41c6817")) { AssociationType = { ObjectType = S2 }, RoleType = { ObjectType = AllorsInteger } };

            UserSelect = new RelationType(
                D,
                new Guid("1ffa3cb7-41f0-406a-a3a5-2f3a4c5ad59c"),
                new Guid("5b87b0d4-3bad-499d-96f1-9d39ab58d1e8"),
                new Guid("939e2772-0bf6-4867-ae7d-3331ab395ba7"))
                             {
                                 IsIndexed = true,
                                 AssociationType = { ObjectType = User, IsMany = true },
                                 RoleType = { ObjectType = User, AssignedSingularName = "Select", AssignedPluralName = "Selects", IsMany = true }
                             };

            C1AllorsString = new RelationType(
                D,
                new Guid("20713860-8abd-4d71-8ccc-2b4d1b88bce3"),
                new Guid("91cd1f90-9173-44ed-899a-c2d8f29979af"),
                new Guid("73131747-7ce6-4801-a6ad-1a6f65b00ebe")) { AssociationType = { ObjectType = C1 }, RoleType = { ObjectType = AllorsString, Size = 256 } };

            IGT32UnitAllorsString18 = new RelationType(
                D,
                new Guid("209d428f-87b5-49d9-b3b6-9ef357889f2a"),
                new Guid("d04c55c0-e61a-4ee3-8e81-30098054f900"),
                new Guid("86f90baa-01bd-4c8c-9f5e-0bdf1b34c34b"))
                                          {
                                              AssociationType = { ObjectType = IGT32Unit },
                                              RoleType =
                                                  {
                                                      ObjectType = AllorsString,
                                                      AssignedSingularName = "AllorsString18",
                                                      AssignedPluralName = "AllorsStrings18",
                                                      Size = 256
                                                  }
                                          };

            IGT32UnitAllorsString21 = new RelationType(
                D,
                new Guid("2279e1c7-1f8d-4daf-b686-aee9c143ce5d"),
                new Guid("19b642fa-a3b6-4a29-869c-e95838e6f6af"),
                new Guid("40e5e607-5068-43a1-a97b-3c1480f0760f"))
                                          {
                                              AssociationType = { ObjectType = IGT32Unit },
                                              RoleType =
                                                  {
                                                      ObjectType = AllorsString,
                                                      AssignedSingularName = "AllorsString21",
                                                      AssignedPluralName = "AllorsStrings21",
                                                      Size = 256
                                                  }
                                          };

            I12AllorsInteger = new RelationType(
                D,
                new Guid("249ff221-9261-4219-b0a8-0dc2a8dac8db"),
                new Guid("7b0b63ac-66e1-4192-b2a4-7f49be11cb92"),
                new Guid("d42bc583-ec2c-4154-9697-132e96e38030")) { AssociationType = { ObjectType = I12 }, RoleType = { ObjectType = AllorsInteger } };

            I3AllorsString = new RelationType(
                D,
                new Guid("25a3bcbf-cd9a-4735-879d-c5415b19cf88"),
                new Guid("fb67b815-0a57-4e62-ab96-7980bd6e5c64"),
                new Guid("f0ee9b2a-f757-40bf-a300-3d307cdfe671")) { AssociationType = { ObjectType = I3 }, RoleType = { ObjectType = AllorsString, Size = 256 } };

            PersonNextPerson = new RelationType(
                D,
                new Guid("25ff791d-9547-41ba-ac34-f2fe501ef217"),
                new Guid("1a7f499a-86cc-4db1-89b7-decd4362c178"),
                new Guid("36743f8f-afc2-4b8b-b9e2-eb0f0e725b72"))
                                   {
                                       AssociationType = { ObjectType = Person },
                                       RoleType = { ObjectType = Person, AssignedSingularName = "NextPerson", AssignedPluralName = "NextPersons" }
                                   };

            C2AllorsDouble = new RelationType(
                D,
                new Guid("262ad367-a52c-4d8b-94e2-b477bb098423"),
                new Guid("3ab98f7a-f38f-45ff-a15e-205974aaf8c6"),
                new Guid("8aaedaa7-bea2-43cf-b0be-1401ef1b92d4")) { AssociationType = { ObjectType = C2 }, RoleType = { ObjectType = AllorsDouble } };

            IGT32UnitAllorsString31 = new RelationType(
                D,
                new Guid("26a72acf-af4e-48b5-af95-b3fa78bfbcf8"),
                new Guid("8b1a4102-6fb2-4515-a793-ff619df2aeeb"),
                new Guid("083a94b4-46de-4ea9-8c4d-db8dd841415a"))
                                          {
                                              AssociationType = { ObjectType = IGT32Unit },
                                              RoleType =
                                                  {
                                                      ObjectType = AllorsString,
                                                      AssignedSingularName = "AllorsString31",
                                                      AssignedPluralName = "AllorsStrings31",
                                                      Size = 256
                                                  }
                                          };

            CompanyFirstPerson = new RelationType(
                D,
                new Guid("28021756-f15f-4671-aa01-a40d3707d61a"),
                new Guid("eb38cf15-c545-4aa1-995b-f9d60508b87d"),
                new Guid("1189280f-7a02-4f8d-b524-69e5728e03de"))
                                     {
                                         AssociationType = { ObjectType = Company },
                                         RoleType = { ObjectType = Person, AssignedSingularName = "FirstPerson", AssignedPluralName = "FirstPersons" }
                                     };

            I1I12many2one = new RelationType(
                D,
                new Guid("28b92468-27e5-4471-b3a5-37b8ec4f794e"),
                new Guid("8ccd89ce-ae46-45f3-b06b-6a6f5415ca39"),
                new Guid("35f9c368-08b8-4516-9f40-d659ba17e35f"))
                                {
                                    AssociationType = { ObjectType = I1, IsMany = true },
                                    RoleType = { ObjectType = I12, AssignedSingularName = "I12many2one", AssignedPluralName = "I12many2ones" }
                                };

            I1AllorsString = new RelationType(
                D,
                new Guid("28ceffc2-c776-4a0a-9825-a6d1bcb265dc"),
                new Guid("9dc2a58d-4e7d-418d-98ba-3ffe725de9ad"),
                new Guid("ba8195d0-5c26-4402-97d7-54024f9f547c")) { AssociationType = { ObjectType = I1 }, RoleType = { ObjectType = AllorsString, Size = 256 } };

            I1DateTimeLessThan = new RelationType(
                D,
                new Guid("29244f33-6d79-44aa-9ed2-8cc01b5070b7"),
                new Guid("c2007753-31aa-4e75-91cd-7e581a593bc4"),
                new Guid("a9c4e920-08b2-45e2-bb28-faf2ee495067"))
                                     {
                                         AssociationType = { ObjectType = I1 },
                                         RoleType =
                                             {
                                                 ObjectType = AllorsDateTime,
                                                 AssignedSingularName = "DateTimeLessThan",
                                                 AssignedPluralName = "DateTimesLessThan"
                                             }
                                     };

            S1AllorsDecimal = new RelationType(
                D,
                new Guid("294e7ce3-1b0b-490a-a5e8-6149885d4943"),
                new Guid("35b9e89a-2962-47a6-87be-5c3e6a5c553a"),
                new Guid("eeb24332-c825-4e1b-9d65-4e7f93062aae")) { AssociationType = { ObjectType = S1 }, RoleType = { ObjectType = AllorsDecimal, Scale = 2, Precision = 19 } };

            C3I4one2one = new RelationType(
                D,
                new Guid("29e76785-f3eb-48b9-a9bf-c44e64762631"),
                new Guid("09a88684-7e1c-4aab-9636-bc00e90d80bc"),
                new Guid("cd5e8d50-2aa8-4604-8e9d-28d9b29dece4"))
                              {
                                  AssociationType = { ObjectType = C3 },
                                  RoleType = { ObjectType = I4, AssignedSingularName = "I4one2one", AssignedPluralName = "I4one2ones" }
                              };

            S1234AllorsDecimal = new RelationType(
                D,
                new Guid("2ac36edd-d718-4252-b7cf-74849e1fca6e"),
                new Guid("c932a3da-ab1f-4a99-9d04-7d2a00425328"),
                new Guid("54eac29a-4aee-4fd2-b6e5-4f70e9d04c2f")) { AssociationType = { ObjectType = S1234 }, RoleType = { ObjectType = AllorsDecimal, Scale = 2, Precision = 19 } };

            I3I4one2many = new RelationType(
                D,
                new Guid("2b273c39-cc85-4585-806f-d991f43dda29"),
                new Guid("b6a50007-d627-4d8e-aa22-d683581b8b79"),
                new Guid("fbd1c026-ed93-4ba5-905b-20047e891445"))
                               {
                                   AssociationType = { ObjectType = I3 },
                                   RoleType =
                                       {
                                           ObjectType = I4,
                                           AssignedSingularName = "I4one2many",
                                           AssignedPluralName = "I4one2manies",
                                           IsMany = true
                                       }
                               };

            I12I34one2many = new RelationType(
                D,
                new Guid("2c05b90e-a036-450a-8b4e-ee70c8146fed"),
                new Guid("886f5fe7-29ea-41ff-a982-8e6763ba2d04"),
                new Guid("99086a40-8ca7-4b26-a067-9801223c9bc3"))
                                 {
                                     AssociationType = { ObjectType = I12 },
                                     RoleType =
                                         {
                                             ObjectType = I34,
                                             AssignedSingularName = "I34one2many",
                                             AssignedPluralName = "I34one2manies",
                                             IsMany = true
                                         }
                                 };

            I1C2one2many = new RelationType(
                D,
                new Guid("2cd562b6-7f54-49af-b853-2244f10ec60e"),
                new Guid("826b8178-01ec-431e-9f9d-6c1b47bac805"),
                new Guid("34dd065a-9973-44ca-8106-9ebc83c9c879"))
                               {
                                   AssociationType = { ObjectType = I1 },
                                   RoleType =
                                       {
                                           ObjectType = C2,
                                           AssignedSingularName = "C2one2many",
                                           AssignedPluralName = "C2one2manies",
                                           IsMany = true
                                       }
                               };

            C1C1many2one = new RelationType(
                D,
                new Guid("2cd8b843-f1f5-413d-9d6d-0d2b9b3c5cf6"),
                new Guid("aeae79d4-1981-4784-be1c-09937fcb4f81"),
                new Guid("443257a7-ca1d-4e34-bb25-00ad68debf48"))
                               {
                                   AssociationType = { ObjectType = C1, IsMany = true },
                                   RoleType = { ObjectType = C1, AssignedSingularName = "C1many2one", AssignedPluralName = "C1many2ones" }
                               };

            C1S2many2one = new RelationType(
                D,
                new Guid("2cee32ad-4e62-4112-9775-f84b0298e93a"),
                new Guid("9d262256-759f-4809-9c99-a8f6f41990d1"),
                new Guid("302ba7eb-b6f3-41e3-bc26-4927bec900a7"))
                               {
                                   AssociationType = { ObjectType = C1, IsMany = true },
                                   RoleType = { ObjectType = S2, AssignedSingularName = "S2many2one", AssignedPluralName = "S2many2ones" }
                               };

            I1StringLarge = new RelationType(
                D,
                new Guid("2e98ec7e-486f-4b96-ac15-5149fe6c4e0e"),
                new Guid("7a9005f0-c244-4797-98bd-7ea613edb0fe"),
                new Guid("46c7a9a7-5e8e-4177-8835-be8fbd886d9e"))
                                {
                                    AssociationType = { ObjectType = I1 },
                                    RoleType =
                                        {
                                            ObjectType = AllorsString,
                                            AssignedSingularName = "StringLarge",
                                            AssignedPluralName = "StringsLarge",
                                            Size = 100000
                                        }
                                };

            S12AllorsDateTime = new RelationType(
                D,
                new Guid("2eb9e232-4ed4-4997-a21a-f11bb0fe3b0e"),
                new Guid("7d0f87c2-8309-4bb2-afac-e6f311127f8e"),
                new Guid("d4003255-3083-428a-b2af-9456313cd765")) { AssociationType = { ObjectType = S12 }, RoleType = { ObjectType = AllorsDateTime } };

            I1DoubleLessThan = new RelationType(
                D,
                new Guid("2f739fa2-c169-4721-8d2d-79f27a6e57c6"),
                new Guid("31b9b9af-df6c-425e-835c-ceb2d512afb6"),
                new Guid("6aee72d6-be71-4560-baf2-97e64cfd3eb8"))
                                   {
                                       AssociationType = { ObjectType = I1 },
                                       RoleType =
                                           {
                                               ObjectType = AllorsDouble,
                                               AssignedSingularName = "DoubleLessThan",
                                               AssignedPluralName = "DoublesLessThan"
                                           }
                                   };

            CompanyNamedOneSort2 = new RelationType(
                D,
                new Guid("2f9fc05e-c904-4056-83f0-a7081762594a"),
                new Guid("b16d4eb4-1e3a-45d7-8c46-2b8bf8b5bc3f"),
                new Guid("afea2d18-06e5-48e5-9fb9-3fd1daf65caf"))
                                       {
                                           AssociationType = { ObjectType = Company },
                                           RoleType =
                                               {
                                                   ObjectType = Named,
                                                   AssignedSingularName = "NamedOneSort2",
                                                   AssignedPluralName = "NamedsOneSort2",
                                                   IsMany = true
                                               }
                                       };

            C1DoubleBetweenA = new RelationType(
                D,
                new Guid("2fa10f1e-d7f6-4f75-92a8-15d7b02b8c19"),
                new Guid("287d5a30-a910-434d-a005-9af604fe6fd2"),
                new Guid("f199e3bc-a801-418b-99ea-7e693fe86f2b"))
                                   {
                                       AssociationType = { ObjectType = C1 },
                                       RoleType =
                                           {
                                               ObjectType = AllorsDouble,
                                               AssignedSingularName = "DoubleBetweenA",
                                               AssignedPluralName = "DoublesBetweenA"
                                           }
                                   };

            C1Many2One = new RelationType(
                D,
                new Guid("2fc66f19-7fd4-4dc1-95ef-7931864ad083"),
                new Guid("55e9a302-365d-4ae8-b735-8ebe16d487df"),
                new Guid("37ec9021-267f-4722-b651-2a31be381f88"))
                             {
                                 IsIndexed = true,
                                 AssociationType = { ObjectType = C1, IsMany = true },
                                 RoleType = { ObjectType = C1, AssignedSingularName = "Many2One", AssignedPluralName = "Many2Ones" }
                             };

            C1C1many2many = new RelationType(
                D,
                new Guid("2ff1c9ba-0017-466e-9f11-776086e6d0b0"),
                new Guid("b93df650-406c-4eb6-8352-dfdb6db0eefc"),
                new Guid("b2faf733-aba6-46c6-84a0-bbf6aafeb613"))
                                {
                                    AssociationType = { ObjectType = C1, IsMany = true },
                                    RoleType =
                                        {
                                            ObjectType = C1,
                                            AssignedSingularName = "C1many2many",
                                            AssignedPluralName = "C1many2manies",
                                            IsMany = true
                                        }
                                };

            I1AllorsDateTime = new RelationType(
                D,
                new Guid("32fc21cc-4be7-4a0e-ac71-df135be95e68"),
                new Guid("cd473438-a39c-4c21-acf3-9394a0037434"),
                new Guid("6131d63e-e7fa-4859-bbd0-be684f203a3e")) { AssociationType = { ObjectType = I1 }, RoleType = { ObjectType = AllorsDateTime } };

            I12C3many2one = new RelationType(
                D,
                new Guid("3327e14d-5601-4806-b6c5-b740a2c3aa38"),
                new Guid("e400d752-2b35-4b8f-b4cb-12fc6c9ba4ab"),
                new Guid("de5b73d9-3ea5-461a-8c82-e22c314e23e4"))
                                {
                                    AssociationType = { ObjectType = I12, IsMany = true },
                                    RoleType = { ObjectType = C3, AssignedSingularName = "C3many2one", AssignedPluralName = "C3many2ones" }
                                };

            I1C1many2one = new RelationType(
                D,
                new Guid("33f13167-3a14-4b06-a1d8-87076918b285"),
                new Guid("d138c296-e332-414c-9dc4-9eeff746e7ec"),
                new Guid("13fa334e-a315-4dbb-9d2a-1a8979254754"))
                               {
                                   AssociationType = { ObjectType = I1, IsMany = true },
                                   RoleType = { ObjectType = C1, AssignedSingularName = "C1many2one", AssignedPluralName = "C1many2ones" }
                               };

            I2AllorsBoolean = new RelationType(
                D,
                new Guid("35040d7c-ab7f-4a99-9d09-e01e24ca3cb9"),
                new Guid("3aa841fd-a95d-4ddc-b994-5e432fd9f2ef"),
                new Guid("c39a79f1-3b54-45bb-ad24-3cec889691fc")) { AssociationType = { ObjectType = I2 }, RoleType = { ObjectType = AllorsBoolean } };

            I1LongBetweenB = new RelationType(
                D,
                new Guid("350e73e2-5a0c-4b07-ae27-a16dbb19080d"),
                new Guid("912a2843-274a-4268-b95a-01e5f74599bc"),
                new Guid("ca3d9977-8b0b-4409-b570-509cbba46d56"))
                                 {
                                     AssociationType = { ObjectType = I1 },
                                     RoleType =
                                         {
                                             ObjectType = AllorsLong,
                                             AssignedSingularName = "LongBetweenB",
                                             AssignedPluralName = "LongsBetweenB"
                                         }
                                 };

            I12C2many2one = new RelationType(
                D,
                new Guid("3589d5bc-3338-449a-bd14-34a19d92251e"),
                new Guid("72892ef3-e425-400b-af3d-9ebde3d15747"),
                new Guid("c145f01d-f08a-461a-a323-ce20caf59cc5"))
                                {
                                    AssociationType = { ObjectType = I12, IsMany = true },
                                    RoleType = { ObjectType = C2, AssignedSingularName = "C2many2one", AssignedPluralName = "C2many2ones" }
                                };

            C1S1many2many = new RelationType(
                D,
                new Guid("3673e4f6-8b40-44e7-be25-d73907b5806a"),
                new Guid("f9ba3e92-f1df-418d-94de-9ad0ddcbd24a"),
                new Guid("fc639289-9a1e-449e-832a-9b7dda4a80be"))
                                {
                                    AssociationType = { ObjectType = C1, IsMany = true },
                                    RoleType =
                                        {
                                            ObjectType = S1,
                                            AssignedSingularName = "S1many2many",
                                            AssignedPluralName = "S1many2manies",
                                            IsMany = true
                                        }
                                };

            IGT32UnitAllorsString15 = new RelationType(
                D,
                new Guid("36daace4-f9d1-453d-9caf-90173b13017b"),
                new Guid("899dd11c-3467-4f03-86ef-5534b0eadbfb"),
                new Guid("2e5c06e4-dcaa-4aa8-b6ec-8eb6fea2d7d6"))
                                          {
                                              AssociationType = { ObjectType = IGT32Unit },
                                              RoleType =
                                                  {
                                                      ObjectType = AllorsString,
                                                      AssignedSingularName = "AllorsString15",
                                                      AssignedPluralName = "AllorsStrings15",
                                                      Size = 256
                                                  }
                                          };

            I34AllorsDecimal = new RelationType(
                D,
                new Guid("37e8d764-bfeb-40d8-b7e9-d94e455dcc11"),
                new Guid("fd9a1d7e-913e-4fce-88b3-320ab6bbce96"),
                new Guid("d079cba2-c2af-4dc5-abf3-46abeb8b4928")) { AssociationType = { ObjectType = I34 }, RoleType = { ObjectType = AllorsDecimal, Scale = 2, Precision = 19 } };

            I1I12one2one = new RelationType(
                D,
                new Guid("381c61c1-312d-47ea-8314-8ac051378a81"),
                new Guid("fa0426fa-bf13-4437-928c-691d60b67472"),
                new Guid("3cfdc695-8713-426a-8050-87de8e608f44"))
                               {
                                   AssociationType = { ObjectType = I1 },
                                   RoleType = { ObjectType = I12, AssignedSingularName = "I12one2one", AssignedPluralName = "I12one2ones" }
                               };

            ISandboxInvisibleValue = new RelationType(
                D,
                new Guid("38361bff-62b3-4607-8291-cfdaeedbd36d"),
                new Guid("f5403207-14c6-422e-9139-92e1c46ea15b"),
                new Guid("675e80d6-5718-4a84-aef0-92ccf07dcdc7"))
                                         {
                                             AssociationType = { ObjectType = ISandbox },
                                             RoleType =
                                                 {
                                                     ObjectType = AllorsString,
                                                     AssignedSingularName = "InvisibleValue",
                                                     AssignedPluralName = "InvisibleValues",
                                                     Size = 256
                                                 }
                                         };

            C1DoubleBetweenB = new RelationType(
                D,
                new Guid("392e8c95-bbfc-4d24-b751-36c17a7b0ee6"),
                new Guid("180c4969-ae4d-4c94-a65a-72ad2c827ffd"),
                new Guid("b00db511-b17b-41fc-a670-4801a17343f5"))
                                   {
                                       AssociationType = { ObjectType = C1 },
                                       RoleType =
                                           {
                                               ObjectType = AllorsDouble,
                                               AssignedSingularName = "DoubleBetweenB",
                                               AssignedPluralName = "DoublesBetweenB"
                                           }
                                   };

            C3C4many2one = new RelationType(
                D,
                new Guid("39313684-8ea1-4f15-aada-2a16feb148ea"),
                new Guid("1835fdd6-314c-4fa3-8fb1-e48076f3ad2a"),
                new Guid("64491eca-3962-419b-847b-f7da095a8637"))
                               {
                                   AssociationType = { ObjectType = C3, IsMany = true },
                                   RoleType = { ObjectType = C4, AssignedSingularName = "C4many2one", AssignedPluralName = "C4many2ones" }
                               };

            I1DecimalGreaterThan = new RelationType(
                D,
                new Guid("39f1c13c-7d77-429f-ac9b-1491e949aa3a"),
                new Guid("b7839acd-88b5-4b28-b4e4-0e9f107e9ffd"),
                new Guid("81f5b98b-c108-41d3-866b-879e00a431cb"))
                                       {
                                           AssociationType = { ObjectType = I1 },
                                           RoleType =
                                               {
                                                   ObjectType = AllorsDecimal,
                                                   AssignedSingularName = "DecimalGreaterThan",
                                                   AssignedPluralName = "DecimalsGreaterThan",
                                                   Scale = 2,
                                                   Precision = 19
                                               }
                                       };

            S12C2many2many = new RelationType(
                D,
                new Guid("39f50108-df59-455d-8371-fc07f3dbb7ef"),
                new Guid("458190b2-3823-4b79-a17f-94a30daf1c35"),
                new Guid("c2cc8dd6-7154-47cd-a182-bd0034701c4f"))
                                 {
                                     AssociationType = { ObjectType = S12, IsMany = true },
                                     RoleType =
                                         {
                                             ObjectType = C2,
                                             AssignedSingularName = "C2many2many",
                                             AssignedPluralName = "C2many2manies",
                                             IsMany = true
                                         }
                                 };

            I3C4one2many = new RelationType(
                D,
                new Guid("3a55d57f-768f-4c11-9c18-baa5f3eeda8c"),
                new Guid("5024f9c4-f1e7-43e6-b228-4a36b0f2377a"),
                new Guid("7d3716d2-a9a7-484a-84d4-5e3367c745bb"))
                               {
                                   AssociationType = { ObjectType = I3 },
                                   RoleType =
                                       {
                                           ObjectType = C4,
                                           AssignedSingularName = "C4one2many",
                                           AssignedPluralName = "C4one2manies",
                                           IsMany = true
                                       }
                               };

            IGT32CompositeSelf23 = new RelationType(
                D,
                new Guid("3a691474-812c-4631-9909-0864297c9e86"),
                new Guid("8241bd59-99c2-4c7e-9b22-843b180bb849"),
                new Guid("4da8edc4-9880-445c-9944-c1a0e3a7f41d"))
                                       {
                                           AssociationType = { ObjectType = IGT32Composite },
                                           RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self23", AssignedPluralName = "Selfs23" }
                                       };

            IGT32CompositeSelf22 = new RelationType(
                D,
                new Guid("3b523d8e-2163-401a-9ccf-7d85777e216f"),
                new Guid("31071edf-cafe-43f6-823f-ca7ed6c679f8"),
                new Guid("5ebc4149-562a-4ff9-a427-f99bc321adaa"))
                                       {
                                           AssociationType = { ObjectType = IGT32Composite },
                                           RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self22", AssignedPluralName = "Selfs22" }
                                       };

            I3I4many2many = new RelationType(
                D,
                new Guid("3f553db3-b490-4de5-b388-5d096d83de0d"),
                new Guid("8d7b37bb-8524-4930-a33b-d14b5bdf126b"),
                new Guid("551eb2b5-a9b1-4e82-b74e-187f2b90fd09"))
                                {
                                    AssociationType = { ObjectType = I3, IsMany = true },
                                    RoleType =
                                        {
                                            ObjectType = I4,
                                            AssignedSingularName = "I4many2many",
                                            AssignedPluralName = "I4many2manies",
                                            IsMany = true
                                        }
                                };

            C1I1one2one = new RelationType(
                D,
                new Guid("3fea182f-07b0-4c36-8170-960b484801f6"),
                new Guid("7e11a549-e213-4e62-8fe5-db6f591ad355"),
                new Guid("dd5acc79-e2c5-4c0c-b054-4fd6deae1c39"))
                              {
                                  AssociationType = { ObjectType = C1 },
                                  RoleType = { ObjectType = I1, AssignedSingularName = "I1one2one", AssignedPluralName = "I1one2one" }
                              };

            C2AllorsLong = new RelationType(
                D,
                new Guid("41cd7805-0f93-460f-8572-9c479f3db206"),
                new Guid("4c22e550-9249-4c9b-883a-3eacf75ea1ff"),
                new Guid("a2585517-50e0-4168-9158-12cdd466b14a")) { AssociationType = { ObjectType = C2 }, RoleType = { ObjectType = AllorsLong } };

            C2AllorsInteger = new RelationType(
                D,
                new Guid("42f9f4b6-3b35-4168-93cb-35171dbf83f4"),
                new Guid("bb11267f-3214-4456-8a49-1a350dbabb4f"),
                new Guid("15d1699c-3c37-4f75-8b91-6082288053ec")) { AssociationType = { ObjectType = C2 }, RoleType = { ObjectType = AllorsInteger } };

            I1C1one2one = new RelationType(
                D,
                new Guid("4401d0b8-2450-45a8-92d2-ff3961e129b2"),
                new Guid("a4c7fc6f-75ee-43cc-ae9d-cf9d95aa0c37"),
                new Guid("3ba6e068-4da7-4cf0-a901-ac894dde7085"))
                              {
                                  AssociationType = { ObjectType = I1 },
                                  RoleType = { ObjectType = C1, AssignedSingularName = "C1one2one", AssignedPluralName = "C1one2ones" }
                              };

            CompanyOwner = new RelationType(
                D,
                new Guid("44abca14-9fb2-42a7-b8ab-a1ca87d87b2e"),
                new Guid("c212abeb-9a22-4577-98c2-3792ddb20ad9"),
                new Guid("480debbc-ddb8-467d-bc3a-062a5c452b9f"))
                               {
                                   IsIndexed = true,
                                   AssociationType = { ObjectType = Company, IsMany = true },
                                   RoleType = { ObjectType = Person, AssignedSingularName = "Owner", AssignedPluralName = "Owners", IsMany = true }
                               };

            S1234AllorsInteger = new RelationType(
                D,
                new Guid("46263379-afd4-4472-bb05-057fb88163ab"),
                new Guid("1675c94a-b570-4d27-a765-652ba71cbb4e"),
                new Guid("e7793a66-e307-420e-9fb6-6a057fcf8094")) { AssociationType = { ObjectType = S1234 }, RoleType = { ObjectType = AllorsInteger } };

            I1LongLessThan = new RelationType(
                D,
                new Guid("47c5ef75-a428-4444-afdb-1d5ef89a7a71"),
                new Guid("84827132-2f2b-4f87-817f-6655558cf934"),
                new Guid("e1829829-721a-4bfa-a9cd-185da405fa9e"))
                                 {
                                     AssociationType = { ObjectType = I1 },
                                     RoleType =
                                         {
                                             ObjectType = AllorsLong,
                                             AssignedSingularName = "LongLessThan",
                                             AssignedPluralName = "LongsLessThan"
                                         }
                                 };

            C1IntegerLessThan = new RelationType(
                D,
                new Guid("49970761-ebe1-4623-a822-5ee1d1f3fafc"),
                new Guid("a95f82ab-19e7-464b-9a5a-9458e22c6da3"),
                new Guid("c3cf4120-65e4-4069-a357-714774ce208f"))
                                    {
                                        AssociationType = { ObjectType = C1 },
                                        RoleType =
                                            {
                                                ObjectType = AllorsInteger,
                                                AssignedSingularName = "IntegerLessThan",
                                                AssignedPluralName = "IntegersLessThan"
                                            }
                                    };

            C2C2many2many = new RelationType(
                D,
                new Guid("49d04b6f-6393-49f6-bb6b-2dd634d6b9ee"),
                new Guid("43fff719-2350-41dd-91cb-e48f44ef3887"),
                new Guid("4440c0ed-5057-4ee6-a690-f92f70dfa715"))
                                {
                                    AssociationType = { ObjectType = C2, IsMany = true },
                                    RoleType =
                                        {
                                            ObjectType = C2,
                                            AssignedSingularName = "C2many2many",
                                            AssignedPluralName = "C2many2manies",
                                            IsMany = true
                                        }
                                };

            I1I2many2many = new RelationType(
                D,
                new Guid("4a30d40e-ade3-4304-b17b-185abc8b7fde"),
                new Guid("74d59fed-2449-4b6e-8667-0a93cebc1368"),
                new Guid("3e854566-3741-4067-b86f-5977a40c9fc8"))
                                {
                                    AssociationType = { ObjectType = I1, IsMany = true },
                                    RoleType =
                                        {
                                            ObjectType = I2,
                                            AssignedSingularName = "I2many2many",
                                            AssignedPluralName = "I2many2manies",
                                            IsMany = true
                                        }
                                };

            I34AllorsBoolean = new RelationType(
                D,
                new Guid("4a6db64f-aeeb-4657-a24c-7997129f3efa"),
                new Guid("16ce6c74-b457-4a3b-b173-c7fec74b8178"),
                new Guid("77f678c6-93ee-465a-b252-7e0530ed19ea")) { AssociationType = { ObjectType = I34 }, RoleType = { ObjectType = AllorsBoolean } };

            S1234S1234many2one = new RelationType(
                D,
                new Guid("4b846355-000b-4651-bff2-51f1275c1461"),
                new Guid("e5bba0bd-a176-48c5-8b8f-b172b0712804"),
                new Guid("f9d2c447-1b98-4473-b9e3-d4c3a5cdf954"))
                                     {
                                         AssociationType = { ObjectType = S1234, IsMany = true },
                                         RoleType = { ObjectType = S1234, AssignedSingularName = "S1234many2one", AssignedPluralName = "S1234many2one" }
                                     };

            C1StringLarge = new RelationType(
                D,
                new Guid("4b970db5-d0ec-4765-9f9b-6e9aafc9dbcc"),
                new Guid("f3f72266-709b-4ca7-a40b-ec47616c1758"),
                new Guid("42b7d196-d105-4e0b-ba8c-8b95dd1c9039"))
                                {
                                    AssociationType = { ObjectType = C1 },
                                    RoleType =
                                        {
                                            ObjectType = AllorsString,
                                            AssignedSingularName = "StringLarge",
                                            AssignedPluralName = "StringsLarge",
                                            Size = 100000
                                        }
                                };

            C1I2one2many = new RelationType(
                D,
                new Guid("4c0362ad-4d0e-4e57-a057-1852ddd8eed8"),
                new Guid("c3103e76-c1e2-49d5-bea8-94eccf855934"),
                new Guid("34ad3d07-3545-44b4-96f0-55d186a933a5"))
                               {
                                   AssociationType = { ObjectType = C1 },
                                   RoleType =
                                       {
                                           ObjectType = I2,
                                           AssignedSingularName = "I2one2many",
                                           AssignedPluralName = "I2one2manies",
                                           IsMany = true
                                       }
                               };

            IGT32UnitAllorsString6 = new RelationType(
                D,
                new Guid("4c0539d2-2ef3-4572-8098-3e161c338316"),
                new Guid("73a1d8cf-46f7-489c-af47-df7705ba377e"),
                new Guid("6adc8687-44fb-4064-a6d4-667d78ef8d8c"))
                                         {
                                             AssociationType = { ObjectType = IGT32Unit },
                                             RoleType =
                                                 {
                                                     ObjectType = AllorsString,
                                                     AssignedSingularName = "AllorsString6",
                                                     AssignedPluralName = "AllorsStrings6",
                                                     Size = 256
                                                 }
                                         };

            C1C1one2one = new RelationType(
                D,
                new Guid("4c776502-77d7-45d9-b101-62dee27c0c2e"),
                new Guid("e7ae4683-03c7-4c79-96ed-0b0cfea26672"),
                new Guid("bcd957f3-a9bd-41eb-bb2f-2ae595d6e5f1"))
                              {
                                  AssociationType = { ObjectType = C1 },
                                  RoleType = { ObjectType = C1, AssignedSingularName = "C1one2one", AssignedPluralName = "C1one2ones" }
                              };

            I12AllorsDouble = new RelationType(
                D,
                new Guid("4c7dd6a2-db16-4477-9b21-34dcb8f50738"),
                new Guid("24538f44-5ea8-49f8-a67f-55b585acdcb4"),
                new Guid("ee7dfee2-bc14-498e-b9e5-6d25bb5fafb1")) { AssociationType = { ObjectType = I12 }, RoleType = { ObjectType = AllorsDouble } };

            C1DoubleGreaterThan = new RelationType(
                D,
                new Guid("4c95279f-fb68-49d1-b9c2-27c612c4c28e"),
                new Guid("d4d5cb0d-098a-41bd-80ed-7e0b6f9a6038"),
                new Guid("47dfabc0-a7b6-4152-aa74-f42c2cde35ac"))
                                      {
                                          AssociationType = { ObjectType = C1 },
                                          RoleType =
                                              {
                                                  ObjectType = AllorsDouble,
                                                  AssignedSingularName = "DoubleGreaterThan",
                                                  AssignedPluralName = "DoublesGreaterThan"
                                              }
                                      };

            S1AllorsInteger = new RelationType(
                D,
                new Guid("4cd28d56-ffd6-461c-b9ed-ca0e4bae51df"),
                new Guid("a0dd3d9e-d722-43c4-be7c-27a63995a4bb"),
                new Guid("592c39ed-47f8-4f42-8ab4-26279627c5d4")) { AssociationType = { ObjectType = S1 }, RoleType = { ObjectType = AllorsInteger } };

            C1I2many2one = new RelationType(
                D,
                new Guid("4dab4e16-b8a2-46c1-949d-62aead9a9c9f"),
                new Guid("0fc84cfc-8dd2-47e8-bafa-08163a12aa44"),
                new Guid("aa0d80fc-2aa0-43a7-bad1-2b08e6d95b2d"))
                               {
                                   AssociationType = { ObjectType = C1, IsMany = true },
                                   RoleType = { ObjectType = I2, AssignedSingularName = "I2many2one", AssignedPluralName = "I2many2one" }
                               };

            I2AllorsDecimal = new RelationType(
                D,
                new Guid("4f095abd-8803-4610-87f0-2847ddd5e9f4"),
                new Guid("e1a86fa0-c857-4be0-8abc-704339bbdc82"),
                new Guid("c7cb9a8b-7df5-4677-902f-b6f4b9aec802")) { AssociationType = { ObjectType = I2 }, RoleType = { ObjectType = AllorsDecimal, Scale = 2, Precision = 19 } };

            IGT32CompositeSelf18 = new RelationType(
                D,
                new Guid("4f4eaf7d-cc6c-4279-b371-d569fc07f148"),
                new Guid("45472e52-bde6-4b6c-b092-290b12ee5897"),
                new Guid("69bfb7e4-0d30-4ffb-8415-9bc630ad0a42"))
                                       {
                                           AssociationType = { ObjectType = IGT32Composite },
                                           RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self18", AssignedPluralName = "Selfs18" }
                                       };

            IGT32UnitAllorsString27 = new RelationType(
                D,
                new Guid("505b67b2-6e0b-45cc-9474-5782ab40f0a7"),
                new Guid("8af4b3eb-016a-460e-95cc-d78a76b5c9f2"),
                new Guid("3223b7d6-9676-4b2c-8aef-937822991bc7"))
                                          {
                                              AssociationType = { ObjectType = IGT32Unit },
                                              RoleType =
                                                  {
                                                      ObjectType = AllorsString,
                                                      AssignedSingularName = "AllorsString27",
                                                      AssignedPluralName = "AllorsStrings27",
                                                      Size = 256
                                                  }
                                          };

            CompanyIndexedMany2ManyPerson = new RelationType(
                D,
                new Guid("509c5341-3d87-4da4-a807-5567d897169b"),
                new Guid("f769d260-4f19-44fd-8986-34f29d395bb1"),
                new Guid("eba712df-716d-4c2d-aeaf-d877a25a4d0b"))
                                                {
                                                    IsIndexed = true,
                                                    AssociationType = { ObjectType = Company, IsMany = true },
                                                    RoleType =
                                                        {
                                                            ObjectType = Person,
                                                            AssignedSingularName = "IndexedMany2ManyPerson",
                                                            AssignedPluralName = "IndexedMany2ManyPersons",
                                                            IsMany = true
                                                        }
                                                };

            I1IntegerBetweenA = new RelationType(
                D,
                new Guid("518da995-1f6b-4632-94f1-11cea5e72717"),
                new Guid("11fe4c27-f656-46aa-bc30-341fe88d682a"),
                new Guid("730be644-122c-45d0-96b3-73c68a9846c2"))
                                    {
                                        AssociationType = { ObjectType = I1 },
                                        RoleType =
                                            {
                                                ObjectType = AllorsInteger,
                                                AssignedSingularName = "IntegerBetweenA",
                                                AssignedPluralName = "IntegersBetweenA"
                                            }
                                    };

            I1I34many2one = new RelationType(
                D,
                new Guid("528ece9c-81f2-4ea4-8d42-50d9a3fe1eea"),
                new Guid("737aa4c0-5bdb-4871-b79d-1c57b5373835"),
                new Guid("0c896206-a7e3-4800-955d-1fbb61f49610"))
                                {
                                    AssociationType = { ObjectType = I1, IsMany = true },
                                    RoleType = { ObjectType = I34, AssignedSingularName = "I34many2one", AssignedPluralName = "I34many2ones" }
                                };

            S1AllorsBinary = new RelationType(
                D,
                new Guid("55ab6cfa-651b-48ec-bc33-ad3a381d2260"),
                new Guid("3abf073d-bbbb-4f97-bfa3-df6b07c233d2"),
                new Guid("e6b89bb6-dfd9-4605-afff-21f1360bc5cb")) { AssociationType = { ObjectType = S1 }, RoleType = { ObjectType = AllorsBinary, Size = -1 } };

            I3I4many2one = new RelationType(
                D,
                new Guid("57f8f305-e1a9-452b-bcc1-febf7ccc346a"),
                new Guid("9f17390d-c9cb-4241-adb5-b363a1d8d0de"),
                new Guid("2549ff17-6eb6-4d93-8d22-78aa3c4394b3"))
                               {
                                   AssociationType = { ObjectType = I3, IsMany = true },
                                   RoleType = { ObjectType = I4, AssignedSingularName = "I4many2one", AssignedPluralName = "I4many2one" }
                               };

            S1234C2one2one = new RelationType(
                D,
                new Guid("58a56dee-c613-4d76-ab99-5608e7709cd8"),
                new Guid("1066981e-8c9b-44fa-b759-fa3bf62bc195"),
                new Guid("9a580256-37b9-45f5-9c77-6c13454e8fb1"))
                                 {
                                     AssociationType = { ObjectType = S1234 },
                                     RoleType = { ObjectType = C2, AssignedSingularName = "C2one2one", AssignedPluralName = "C2one2ones" }
                                 };

            I1DoubleBetweenA = new RelationType(
                D,
                new Guid("58d75a73-61d3-4ad7-bd1a-b3e673d8ee31"),
                new Guid("44d71cd6-e6fd-4629-84c0-d1240eeb3d4a"),
                new Guid("47be578b-ce67-47d8-8bd7-4810210c60bd"))
                                   {
                                       AssociationType = { ObjectType = I1 },
                                       RoleType =
                                           {
                                               ObjectType = AllorsDouble,
                                               AssignedSingularName = "DoubleBetweenA",
                                               AssignedPluralName = "DoublesBetweenA"
                                           }
                                   };

            I1IntegerLessThan = new RelationType(
                D,
                new Guid("5901c4d4-420f-47a3-87e3-ac04b4601efc"),
                new Guid("b5fca65e-55e3-48b2-8cf8-e14d8d8894b1"),
                new Guid("1cfea0c3-1627-45f1-ac5a-43bfdfe29211"))
                                    {
                                        AssociationType = { ObjectType = I1 },
                                        RoleType =
                                            {
                                                ObjectType = AllorsInteger,
                                                AssignedSingularName = "IntegerLessThan",
                                                AssignedPluralName = "IntegersLessThan"
                                            }
                                    };

            C1I12many2one = new RelationType(
                D,
                new Guid("599420c6-0757-49f6-8ae7-4cb0714ca791"),
                new Guid("74d7cb73-963f-48d1-9519-5578337ece83"),
                new Guid("4b4223f6-5c83-40a7-8ecb-6d403d501b0d"))
                                {
                                    AssociationType = { ObjectType = C1, IsMany = true },
                                    RoleType = { ObjectType = I12, AssignedSingularName = "I12many2one", AssignedPluralName = "I12many2ones" }
                                };

            I1AllorsInteger = new RelationType(
                D,
                new Guid("5cb44331-fd8c-4f73-8994-161f702849b6"),
                new Guid("fc1f2194-baa6-4fd8-9c62-b1f61f5ad634"),
                new Guid("aaf7057e-faa9-43d6-8364-08e381155719")) { AssociationType = { ObjectType = I1 }, RoleType = { ObjectType = AllorsInteger } };

            C3C4many2many = new RelationType(
                D,
                new Guid("5e6c2802-3dc5-405a-a2f7-03c9361d4562"),
                new Guid("710ae2d8-711b-4122-9b57-946fd3d815c2"),
                new Guid("6011796c-9fc6-4e40-be46-b5f937267057"))
                                {
                                    IsIndexed = true,
                                    AssociationType = { ObjectType = C3, IsMany = true },
                                    RoleType =
                                        {
                                            ObjectType = C4,
                                            AssignedSingularName = "C4many2many",
                                            AssignedPluralName = "C4many2manies",
                                            IsMany = true
                                        }
                                };

            SandboxInvisibleValue = new RelationType(
                D,
                new Guid("5eec5096-d8ba-424e-988f-b50828fc7b51"),
                new Guid("3db5ada7-52b4-47fa-bf55-d7641b1e9202"),
                new Guid("3758b6fd-ab8f-43d5-ad3c-906a69682976"))
                                        {
                                            AssociationType = { ObjectType = Sandbox },
                                            RoleType =
                                                {
                                                    ObjectType = AllorsString,
                                                    AssignedSingularName = "InvisibleValue",
                                                    AssignedPluralName = "InvisibleValues",
                                                    Size = 256
                                                }
                                        };

            IGT32UnitAllorsString11 = new RelationType(
                D,
                new Guid("60be7e02-6c19-4f55-a67d-041c0c29c7b1"),
                new Guid("4aa293c3-d182-4bc2-983e-45ffb2a6d91d"),
                new Guid("9fefa909-8a34-4916-a31d-d94ba82bf672"))
                                          {
                                              AssociationType = { ObjectType = IGT32Unit },
                                              RoleType =
                                                  {
                                                      ObjectType = AllorsString,
                                                      AssignedSingularName = "AllorsString11",
                                                      AssignedPluralName = "AllorsStrings11",
                                                      Size = 256
                                                  }
                                          };

            C2AllorsBoolean = new RelationType(
                D,
                new Guid("61daaaae-dd22-405e-aa98-6321d2f8af04"),
                new Guid("f8465b8a-da28-4aa3-a09c-b5ce6f02324c"),
                new Guid("261c56b2-6096-44dd-bf1d-4750ef29b9d6")) { AssociationType = { ObjectType = C2 }, RoleType = { ObjectType = AllorsBoolean } };

            S12C2many2one = new RelationType(
                D,
                new Guid("61e8c425-407e-408b-9f2e-c95548833004"),
                new Guid("e48a6ba4-1b90-43e4-ae17-2cef1209cc2c"),
                new Guid("dcab1da2-1e9c-4019-bc72-16af5e6e791b"))
                                {
                                    AssociationType = { ObjectType = S12, IsMany = true },
                                    RoleType = { ObjectType = C2, AssignedSingularName = "C2many2one", AssignedPluralName = "C2many2ones" }
                                };

            I12I34many2one = new RelationType(
                D,
                new Guid("61fc731f-d769-4eb9-bf87-983e73e403e4"),
                new Guid("fa9c5986-648a-4c6d-867b-4d5089885b76"),
                new Guid("ca503649-1e95-42aa-8bb7-6d6cd1708ba8"))
                                 {
                                     AssociationType = { ObjectType = I12, IsMany = true },
                                     RoleType = { ObjectType = I34, AssignedSingularName = "I34many2one", AssignedPluralName = "I34many2ones" }
                                 };

            CompanyPersonOneSort1 = new RelationType(
                D,
                new Guid("62b4ddac-efd7-4fc9-bbed-91c831a62f01"),
                new Guid("64358266-9014-4aa4-a34f-7c6cf2e87e5c"),
                new Guid("0e47b601-ac16-4873-9544-07fb9404785b"))
                                        {
                                            AssociationType = { ObjectType = Company },
                                            RoleType =
                                                {
                                                    ObjectType = Person,
                                                    AssignedSingularName = "PersonOneSort1",
                                                    AssignedPluralName = "PersonsOneSort1",
                                                    IsMany = true
                                                }
                                        };

            IGT32UnitAllorsString33 = new RelationType(
                D,
                new Guid("63e19c51-8721-4a53-a129-fff09429498e"),
                new Guid("1aac82b2-d1af-4635-8d02-51b4d6191a21"),
                new Guid("418a59ba-ddd3-4022-98e8-05f8d8d76ce0"))
                                          {
                                              AssociationType = { ObjectType = IGT32Unit },
                                              RoleType =
                                                  {
                                                      ObjectType = AllorsString,
                                                      AssignedSingularName = "AllorsString33",
                                                      AssignedPluralName = "AllorsStrings33",
                                                      Size = 256
                                                  }
                                          };

            C1DateTimeLessThan = new RelationType(
                D,
                new Guid("6459deba-24e6-4867-a555-75f672f33893"),
                new Guid("9b5c74c8-6b73-494e-8e84-6163463e6860"),
                new Guid("4bf1e140-447b-4d05-95ab-4c7b5b27da46"))
                                     {
                                         AssociationType = { ObjectType = C1 },
                                         RoleType =
                                             {
                                                 ObjectType = AllorsDateTime,
                                                 AssignedSingularName = "DateTimeLessThan",
                                                 AssignedPluralName = "DateTimesLessThan"
                                             }
                                     };

            S1AllorsUnique = new RelationType(
                D,
                new Guid("645c20ac-5b4f-40db-8d11-d2b07123dabe"),
                new Guid("2d19869d-592e-4e14-bc5f-3557266ed8c1"),
                new Guid("7121814d-81c8-4224-a77c-f873cae73b74")) { AssociationType = { ObjectType = S1 }, RoleType = { ObjectType = AllorsUnique } };

            CompanyPersonManySort1 = new RelationType(
                D,
                new Guid("64c1be0a-0636-4da0-8404-2a93ab600cd9"),
                new Guid("f27225cb-2326-4997-b730-d280d6279d06"),
                new Guid("70292538-4116-48c0-89bc-ca8185e4e253"))
                                         {
                                             AssociationType = { ObjectType = Company, IsMany = true },
                                             RoleType =
                                                 {
                                                     ObjectType = Person,
                                                     AssignedSingularName = "PersonManySort1",
                                                     AssignedPluralName = "PersonsManySort1",
                                                     IsMany = true
                                                 }
                                         };

            S1StringLarge = new RelationType(
                D,
                new Guid("678b14c4-b5ae-48e3-ac06-2459cab66c34"),
                new Guid("69651335-2e01-432f-af18-4f61c9c0edcf"),
                new Guid("22b95a80-c349-46a3-88cf-01a8fa6faeee"))
                                {
                                    AssociationType = { ObjectType = S1 },
                                    RoleType =
                                        {
                                            ObjectType = AllorsString,
                                            AssignedSingularName = "StringLarge",
                                            AssignedPluralName = "StringsLarge",
                                            Size = 100000
                                        }
                                };

            ILT32UnitAllorsString1 = new RelationType(
                D,
                new Guid("6822f677-7249-4c28-9b9c-18b21ba6f597"),
                new Guid("def04d80-9003-4b5a-bd92-331f7781b2be"),
                new Guid("c11b4173-37b3-4d0e-8f4b-254c22f95fb3"))
                                         {
                                             AssociationType = { ObjectType = ILT32Unit },
                                             RoleType =
                                                 {
                                                     ObjectType = AllorsString,
                                                     AssignedSingularName = "AllorsString1",
                                                     AssignedPluralName = "AllorsStrings1",
                                                     Size = 256
                                                 }
                                         };

            I1S2one2one = new RelationType(
                D,
                new Guid("68549750-b8f9-4a29-a078-803e7348e142"),
                new Guid("fe93fafe-0b9d-4184-ac89-6c42e0e983cc"),
                new Guid("b4630a88-e49e-4a76-93cf-d3861902d69a"))
                              {
                                  AssociationType = { ObjectType = I1 },
                                  RoleType = { ObjectType = S2, AssignedSingularName = "S2one2one", AssignedPluralName = "S2one2ones" }
                              };

            S1S2many2one = new RelationType(
                D,
                new Guid("6a166388-5bca-4cd9-bfee-0da27cbc3073"),
                new Guid("0532c685-8ee2-44c3-b7a1-46f3717c76d5"),
                new Guid("ac61e38a-fdfb-41a1-88f1-565b77079122"))
                               {
                                   AssociationType = { ObjectType = S1, IsMany = true },
                                   RoleType = { ObjectType = S2, AssignedSingularName = "S2many2one", AssignedPluralName = "S2many2ones" }
                               };

            C1DateTimeBetweenA = new RelationType(
                D,
                new Guid("6aadb05d-6b80-47c5-b625-18b86e762c94"),
                new Guid("5ea6c4e9-2b4e-470d-9052-f67f80975268"),
                new Guid("c07633eb-a03e-44ba-ae2f-cd4bfa3898f5"))
                                     {
                                         AssociationType = { ObjectType = C1 },
                                         RoleType =
                                             {
                                                 ObjectType = AllorsDateTime,
                                                 AssignedSingularName = "DateTimeBetweenA",
                                                 AssignedPluralName = "DateTimesBetweenA"
                                             }
                                     };

            I1AllorsBoolean = new RelationType(
                D,
                new Guid("6c3d04be-6f95-44b8-863a-245e150e3110"),
                new Guid("b06e8d7f-2cc7-486e-9e72-428965f335ab"),
                new Guid("1ed86e48-fa9c-4590-ba1b-f2a6345ff572")) { AssociationType = { ObjectType = I1 }, RoleType = { ObjectType = AllorsBoolean } };

            PersonCompany = new RelationType(
                D,
                new Guid("6cc83cb8-cb94-4716-bb7d-e25201f06b20"),
                new Guid("1074f507-e2d7-4b5f-8170-f7ca54a946c8"),
                new Guid("9959f5b6-cf68-48f9-91ae-ed98f691f16c"))
                                {
                                    IsIndexed = true,
                                    AssociationType = { ObjectType = Person, IsMany = true },
                                    RoleType = { ObjectType = Company }
                                };

            IGT32CompositeSelf17 = new RelationType(
                D,
                new Guid("6e2f60b4-ee37-4c66-9425-aee146f51bc8"),
                new Guid("c7fea1ff-7748-4316-948b-90bc64bd0218"),
                new Guid("7406c2a2-1c85-45df-a7f1-107f3ea8526b"))
                                       {
                                           AssociationType = { ObjectType = IGT32Composite },
                                           RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self17", AssignedPluralName = "Selfs17" }
                                       };

            I1I1many2one = new RelationType(
                D,
                new Guid("6e7c286c-42e0-45d7-8ad8-ac0ed91dbbb5"),
                new Guid("21938cf4-639c-47a1-a0f8-0c8015dfea39"),
                new Guid("ed80c525-937e-4f2f-8e80-fa259912d7ab"))
                               {
                                   AssociationType = { ObjectType = I1, IsMany = true },
                                   RoleType = { ObjectType = I1, AssignedSingularName = "I1many2one", AssignedPluralName = "I1many2ones" }
                               };

            S1S2one2many = new RelationType(
                D,
                new Guid("6ee98698-15dc-4998-88c3-d2a4d1c19e8c"),
                new Guid("0b75718e-1648-438c-b0fe-70e4f05623c8"),
                new Guid("e88fdde4-a3e8-4ee0-85d6-7e5fc3047b48"))
                               {
                                   AssociationType = { ObjectType = S1 },
                                   RoleType =
                                       {
                                           ObjectType = S2,
                                           AssignedSingularName = "S2one2many",
                                           AssignedPluralName = "S2one2manies",
                                           IsMany = true
                                       }
                               };

            IGT32CompositeSelf3 = new RelationType(
                D,
                new Guid("6f1e2848-b27f-4ccc-a35e-467d77577a29"),
                new Guid("ef2f0261-e63a-421d-935d-45d0c76f70eb"),
                new Guid("a91b23ee-432f-4608-8311-040a8459e000"))
                                      {
                                          AssociationType = { ObjectType = IGT32Composite },
                                          RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self3", AssignedPluralName = "Selfs3" }
                                      };

            IGT32UnitAllorsString32 = new RelationType(
                D,
                new Guid("6facb71c-1399-41c3-94cd-e51b2ace2d49"),
                new Guid("4303266a-32cf-460b-a6d0-e8b8daea2da3"),
                new Guid("e6563b0d-35c6-4d75-9edc-415a6f49e161"))
                                          {
                                              AssociationType = { ObjectType = IGT32Unit },
                                              RoleType =
                                                  {
                                                      ObjectType = AllorsString,
                                                      AssignedSingularName = "AllorsString32",
                                                      AssignedPluralName = "AllorsStrings32",
                                                      Size = 256
                                                  }
                                          };

            I1C1many2many = new RelationType(
                D,
                new Guid("7014e84c-62c4-48ba-b4ec-ab52a897f443"),
                new Guid("b131af64-a3d7-406d-98eb-7f7ed084e119"),
                new Guid("c78ad636-2e8f-4a97-b68f-e9ed09876115"))
                                {
                                    AssociationType = { ObjectType = I1, IsMany = true },
                                    RoleType =
                                        {
                                            ObjectType = C1,
                                            AssignedSingularName = "C1many2many",
                                            AssignedPluralName = "C1many2manies",
                                            IsMany = true
                                        }
                                };

            S1AllorsDouble = new RelationType(
                D,
                new Guid("701ca57d-241f-470c-b690-9045c0f76c8f"),
                new Guid("1310f3cf-dfc3-4a28-846a-1b2a32e73930"),
                new Guid("0c610a6d-839f-4578-9ede-23afa29c3205")) { AssociationType = { ObjectType = S1 }, RoleType = { ObjectType = AllorsDouble } };

            I1I2one2one = new RelationType(
                D,
                new Guid("70312f37-52e9-4cf6-9dd6-b357628ea3ed"),
                new Guid("d2e511e6-68df-46e2-a342-18073b892909"),
                new Guid("74935b78-53ed-4598-b45b-f491d197998d"))
                              {
                                  AssociationType = { ObjectType = I1 },
                                  RoleType = { ObjectType = I2, AssignedSingularName = "I2one2one", AssignedPluralName = "I2one2ones" }
                              };

            S1AllorsString = new RelationType(
                D,
                new Guid("70815e0c-11d4-41ac-b0b2-105f8ede6d27"),
                new Guid("76f42563-7820-49e4-90dc-24d7a6c96254"),
                new Guid("c5bc1216-fcfb-4e84-bd7c-5ad9f64de637")) { AssociationType = { ObjectType = S1 }, RoleType = { ObjectType = AllorsString, Size = 256 } };

            I12I34many2many = new RelationType(
                D,
                new Guid("716d13fc-f608-41a8-ac9e-824890c585b5"),
                new Guid("14da4483-1238-414d-8e2a-4a61d2730b82"),
                new Guid("9d9840b6-ac0d-460a-8ae4-974e86bce32d"))
                                  {
                                      AssociationType = { ObjectType = I12, IsMany = true },
                                      RoleType =
                                          {
                                              ObjectType = I34,
                                              AssignedSingularName = "I34many2many",
                                              AssignedPluralName = "I34many2manies",
                                              IsMany = true
                                          }
                                  };

            C1C2many2many = new RelationType(
                D,
                new Guid("71abe169-dea4-4834-8d37-34cbcffa6cee"),
                new Guid("d3c1edf3-a518-43fc-874c-034b96a4315f"),
                new Guid("e20dbd0c-169d-4aa3-8bdf-a1b6888fc809"))
                                {
                                    AssociationType = { ObjectType = C1, IsMany = true },
                                    RoleType =
                                        {
                                            ObjectType = C2,
                                            AssignedSingularName = "C2many2many",
                                            AssignedPluralName = "C2many2manies",
                                            IsMany = true
                                        }
                                };

            C1S1many2one = new RelationType(
                D,
                new Guid("724f101c-db45-44f3-b9ca-c8f3b0c28d29"),
                new Guid("0eeff5f8-e436-47f9-bd61-f5d4484fb609"),
                new Guid("79e7fd13-f39a-48d1-a0f0-c67b1565e9f2"))
                               {
                                   AssociationType = { ObjectType = C1, IsMany = true },
                                   RoleType = { ObjectType = S1, AssignedSingularName = "S1many2one", AssignedPluralName = "S1many2ones" }
                               };

            S1234C2many2many = new RelationType(
                D,
                new Guid("73302b50-8526-40ae-a202-5b17e1093629"),
                new Guid("4548670a-0f02-4760-b325-229d3f74213e"),
                new Guid("21509a16-a977-4fe8-a413-34c6da8d77c0"))
                                   {
                                       AssociationType = { ObjectType = S1234, IsMany = true },
                                       RoleType =
                                           {
                                               ObjectType = C2,
                                               AssignedSingularName = "C2many2many",
                                               AssignedPluralName = "C2many2manies",
                                               IsMany = true
                                           }
                                   };

            I12C3one2one = new RelationType(
                D,
                new Guid("74a22498-ec2c-441b-a42c-0c248ace685d"),
                new Guid("41fe122c-2f8a-4b1c-bb56-9d918ecfc05c"),
                new Guid("4d857d4a-5ba1-4bcb-81d4-06ec0093bb98"))
                               {
                                   AssociationType = { ObjectType = I12 },
                                   RoleType = { ObjectType = C3, AssignedSingularName = "C3one2one", AssignedPluralName = "C3one2ones" }
                               };

            S2AllorsDouble = new RelationType(
                D,
                new Guid("74dd2b7b-e647-4967-9838-46c701baf3a7"),
                new Guid("23e975f9-7eff-4dd0-8ecf-317fb59b6c6a"),
                new Guid("9d0f4a5c-a8c7-41a7-9d92-0a9b4ff788ce")) { AssociationType = { ObjectType = S2 }, RoleType = { ObjectType = AllorsDouble } };

            I1AllorsLong = new RelationType(
                D,
                new Guid("75fb2012-0b49-4442-a9b4-8239cffb1d37"),
                new Guid("c3899f29-3f66-4667-8225-aeb7e0fbca1d"),
                new Guid("e234f895-42b2-42e4-a051-323534b1f23e")) { AssociationType = { ObjectType = I1 }, RoleType = { ObjectType = AllorsLong } };

            S1C1many2one = new RelationType(
                D,
                new Guid("77afee4a-08b7-4231-aa73-575145efd1e3"),
                new Guid("fd26d004-ed7a-4561-b370-737c37e2c3b3"),
                new Guid("bb03281d-aa61-4411-a696-df294b5c6bfe"))
                               {
                                   AssociationType = { ObjectType = S1, IsMany = true },
                                   RoleType = { ObjectType = C1, AssignedSingularName = "C1many2one", AssignedPluralName = "C1many2ones" }
                               };

            IGT32CompositeSelf29 = new RelationType(
                D,
                new Guid("77fccc90-38f2-48f6-b834-58f7f972823b"),
                new Guid("ad0d4234-b1bc-44f6-a322-bcd666d2aaed"),
                new Guid("827806c3-c712-41f5-84a2-b16a1b6d987d"))
                                       {
                                           AssociationType = { ObjectType = IGT32Composite },
                                           RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self29", AssignedPluralName = "Selfs29" }
                                       };

            IGT32UnitAllorsString25 = new RelationType(
                D,
                new Guid("7890180e-3ea8-490d-a360-16f04ef567dd"),
                new Guid("24fbf81e-f88a-4153-936a-a3a4d5ccdd32"),
                new Guid("4ebcc6fb-7684-44f6-9d0b-58fd8ad7bbdd"))
                                          {
                                              AssociationType = { ObjectType = IGT32Unit },
                                              RoleType =
                                                  {
                                                      ObjectType = AllorsString,
                                                      AssignedSingularName = "AllorsString25",
                                                      AssignedPluralName = "AllorsStrings25",
                                                      Size = 256
                                                  }
                                          };

            ISandboxInvisibleMany = new RelationType(
                D,
                new Guid("796ab057-88a0-4d71-bc4a-2673a209161b"),
                new Guid("34a3ba9b-6ba6-4cbd-977b-bb22b0ea7c10"),
                new Guid("26fa08b3-598d-4985-9021-02c422fa4494"))
                                        {
                                            AssociationType = { ObjectType = ISandbox, IsMany = true },
                                            RoleType =
                                                {
                                                    ObjectType = ISandbox,
                                                    AssignedSingularName = "InvisibleMany",
                                                    AssignedPluralName = "InvisibleManies",
                                                    IsMany = true
                                                }
                                        };

            C1I1many2many = new RelationType(
                D,
                new Guid("79fbfbc3-50e3-4e45-a5bf-8a253bb6f0c6"),
                new Guid("441a45da-fe17-4aab-8ba7-8f8471d08138"),
                new Guid("456eb032-135b-4fc9-a154-f17f514b2730"))
                                {
                                    AssociationType = { ObjectType = C1, IsMany = true },
                                    RoleType =
                                        {
                                            ObjectType = I1,
                                            AssignedSingularName = "I1many2many",
                                            AssignedPluralName = "I1many2manies",
                                            IsMany = true
                                        }
                                };

            IGT32UnitAllorsString8 = new RelationType(
                D,
                new Guid("7a653b33-2ea5-483f-903d-6f13891e6c44"),
                new Guid("abdb7488-48c4-46ab-b043-bcf7367a052d"),
                new Guid("e26f43f3-9b8e-4442-998a-a8373bc914ec"))
                                         {
                                             AssociationType = { ObjectType = IGT32Unit },
                                             RoleType =
                                                 {
                                                     ObjectType = AllorsString,
                                                     AssignedSingularName = "AllorsString8",
                                                     AssignedPluralName = "AllorsStrings8",
                                                     Size = 256
                                                 }
                                         };

            C1DoubleLessThan = new RelationType(
                D,
                new Guid("7b058b52-dc6b-4f8c-af72-28c9b0c0fde4"),
                new Guid("39b2eaf5-a229-4a08-9adb-7046ee1a8ee4"),
                new Guid("c641a991-9526-43bd-b064-a47e0b490a06"))
                                   {
                                       AssociationType = { ObjectType = C1 },
                                       RoleType =
                                           {
                                               ObjectType = AllorsDouble,
                                               AssignedSingularName = "DoubleLessThan",
                                               AssignedPluralName = "DoublesLessThan"
                                           }
                                   };

            IGT32CompositeSelf26 = new RelationType(
                D,
                new Guid("7d18345c-7754-4ad7-96fa-e83460fa6235"),
                new Guid("e9bd2c8a-bed8-447a-a8ba-338268547186"),
                new Guid("3a1299e6-ca4e-4ddc-a616-abd171954a2e"))
                                       {
                                           AssociationType = { ObjectType = IGT32Composite },
                                           RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self26", AssignedPluralName = "Selfs26" }
                                       };

            C2C1many2one = new RelationType(
                D,
                new Guid("7ee9d97c-8ae3-438c-adfd-6a35b3ff645b"),
                new Guid("56c55810-c2d0-4f58-b03e-9deeac23c369"),
                new Guid("5a4899a0-730b-455e-98cb-e1f2b778fea6"))
                               {
                                   AssociationType = { ObjectType = C2, IsMany = true },
                                   RoleType = { ObjectType = C1, AssignedSingularName = "C1many2one", AssignedPluralName = "C1many2ones" }
                               };

            I12C2many2many = new RelationType(
                D,
                new Guid("7f373030-657a-4c6b-a086-ac4de33e4648"),
                new Guid("f71c20be-c628-4ce2-b4a1-0c0519c7488b"),
                new Guid("b932ffb4-70ad-4f1a-a497-dffa8b165b10"))
                                 {
                                     AssociationType = { ObjectType = I12, IsMany = true },
                                     RoleType =
                                         {
                                             ObjectType = C2,
                                             AssignedSingularName = "C2many2many",
                                             AssignedPluralName = "C2many2manies",
                                             IsMany = true
                                         }
                                 };

            C1I1many2one = new RelationType(
                D,
                new Guid("7fce490e-78af-46a9-a87d-de233073ab3c"),
                new Guid("f974c30a-b37f-4ce3-9cc6-a1931d0455f8"),
                new Guid("40b9821b-bb3d-4dc7-b62e-fdf5f4a9c03e"))
                               {
                                   AssociationType = { ObjectType = C1, IsMany = true },
                                   RoleType = { ObjectType = I1, AssignedSingularName = "I1many2one", AssignedPluralName = "I1many2ones" }
                               };

            I1AllorsDecimal = new RelationType(
                D,
                new Guid("818b4013-5ef1-4455-9f0d-9a39fa3425bb"),
                new Guid("7dae54a7-847a-4b7e-b965-e4597f44905a"),
                new Guid("680be670-2b68-4a46-b34c-2056f9e0f31a")) { AssociationType = { ObjectType = I1 }, RoleType = { ObjectType = AllorsDecimal, Scale = 2, Precision = 10 } };

            IGT32UnitAllorsString28 = new RelationType(
                D,
                new Guid("81d16484-71fd-445b-a681-0363a6d95325"),
                new Guid("285a3cfd-bf87-45cd-987a-84bc5487f381"),
                new Guid("eea88232-c7ef-4303-ba87-daf980819244"))
                                          {
                                              AssociationType = { ObjectType = IGT32Unit },
                                              RoleType =
                                                  {
                                                      ObjectType = AllorsString,
                                                      AssignedSingularName = "AllorsString28",
                                                      AssignedPluralName = "AllorsStrings28",
                                                      Size = 256
                                                  }
                                          };

            I2AllorsDateTime = new RelationType(
                D,
                new Guid("81d9eb2f-55a7-4d1c-853d-4369eb691ba5"),
                new Guid("fa701a92-ee96-4194-8ea9-3da451b2c775"),
                new Guid("f4c841cb-821e-4e9c-ab2a-dc56aa3234ab")) { AssociationType = { ObjectType = I2 }, RoleType = { ObjectType = AllorsDateTime } };

            I1S1many2many = new RelationType(
                D,
                new Guid("82a81e9e-7a13-43d3-bb8f-227edfe26a1f"),
                new Guid("e9da0489-5ce1-48e2-8911-4088830a6762"),
                new Guid("451523e4-942d-48c0-8959-48e51ea438db"))
                                {
                                    AssociationType = { ObjectType = I1, IsMany = true },
                                    RoleType =
                                        {
                                            ObjectType = S1,
                                            AssignedSingularName = "S1many2many",
                                            AssignedPluralName = "S1many2manies",
                                            IsMany = true
                                        }
                                };

            S12C2one2one = new RelationType(
                D,
                new Guid("830117d4-fbe1-4944-bacf-54331e8451d7"),
                new Guid("f66241ad-4692-4907-92cf-f7a49aa6fe70"),
                new Guid("179225dd-73a2-4695-b21f-0d4070d90bdf"))
                               {
                                   AssociationType = { ObjectType = S12 },
                                   RoleType = { ObjectType = C2, AssignedSingularName = "C2one2one", AssignedPluralName = "C2one2ones" }
                               };

            IGT32UnitAllorsString29 = new RelationType(
                D,
                new Guid("84670520-d8c9-407f-82e3-6eb53f1fb290"),
                new Guid("d88c9784-5399-471b-bf4f-77d448181a8a"),
                new Guid("d8429d37-b8f8-4c09-8102-cc79916aa2db"))
                                          {
                                              AssociationType = { ObjectType = IGT32Unit },
                                              RoleType =
                                                  {
                                                      ObjectType = AllorsString,
                                                      AssignedSingularName = "AllorsString29",
                                                      AssignedPluralName = "AllorsStrings29",
                                                      Size = 256
                                                  }
                                          };

            SandboxTest = new RelationType(
                D,
                new Guid("856a0161-2a46-428a-bae5-95d6a86a89e8"),
                new Guid("0c22274b-c5c3-4b6e-883a-e375f25fd500"),
                new Guid("2f108584-41f9-48df-93f5-d442ce92a2a2"))
                              {
                                  AssociationType = { ObjectType = Sandbox },
                                  RoleType =
                                      {
                                          ObjectType = AllorsString,
                                          AssignedSingularName = "Test",
                                          AssignedPluralName = "Tests",
                                          Size = 256
                                      }
                              };

            C1LongGreaterThan = new RelationType(
                D,
                new Guid("8592bb21-c3cc-4f70-bf2b-442269a01104"),
                new Guid("dd154e0e-80c5-443e-9264-1bf6551c097d"),
                new Guid("b33c3ace-d137-4a1e-a393-c2025223696f"))
                                    {
                                        AssociationType = { ObjectType = C1 },
                                        RoleType =
                                            {
                                                ObjectType = AllorsLong,
                                                AssignedSingularName = "LongGreaterThan",
                                                AssignedPluralName = "LongsGreaterThan"
                                            }
                                    };

            C1DecimalGreaterThan = new RelationType(
                D,
                new Guid("8679b3aa-cdad-4ee1-b4fb-edcefd660edb"),
                new Guid("0bb934fe-7da6-4a71-be93-c0a9708d73b5"),
                new Guid("f3d4ce2d-20d7-47ff-98ea-198fccd853d8"))
                                       {
                                           AssociationType = { ObjectType = C1 },
                                           RoleType =
                                               {
                                                   ObjectType = AllorsDecimal,
                                                   AssignedSingularName = "DecimalGreaterThan",
                                                   AssignedPluralName = "DecimalsGreaterThan",
                                                   Scale = 2,
                                                   Precision = 19
                                               }
                                       };

            C1AllorsDecimal = new RelationType(
                D,
                new Guid("87eb0d19-73a7-4aae-aeed-66dc9163233c"),
                new Guid("4572bf9c-50ea-4783-ab76-b88b7c46adbc"),
                new Guid("5568fb11-4cda-4528-82e3-9ebc8d2c4d2c")) { AssociationType = { ObjectType = C1 }, RoleType = { ObjectType = AllorsDecimal, Scale = 2, Precision = 10 } };

            IGT32UnitAllorsString20 = new RelationType(
                D,
                new Guid("88324671-7170-4798-8cc0-d2b25212f7a1"),
                new Guid("5519bf4c-2519-4cc2-b26b-22de78e244d4"),
                new Guid("566e60d8-c033-4a7a-acc6-cf6534a13f93"))
                                          {
                                              AssociationType = { ObjectType = IGT32Unit },
                                              RoleType =
                                                  {
                                                      ObjectType = AllorsString,
                                                      AssignedSingularName = "AllorsString20",
                                                      AssignedPluralName = "AllorsStrings20",
                                                      Size = 256
                                                  }
                                          };

            IGT32CompositeSelf4 = new RelationType(
                D,
                new Guid("8ca8e840-1bf7-4131-b5a3-0abb66ba4e36"),
                new Guid("4050332e-a0de-4e30-96c7-e66d839382fb"),
                new Guid("2a498e47-d085-4601-823a-48f5531d819d"))
                                      {
                                          AssociationType = { ObjectType = IGT32Composite },
                                          RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self4", AssignedPluralName = "Selfs4" }
                                      };

            IGT32UnitAllorsString16 = new RelationType(
                D,
                new Guid("8d97b1d0-304a-4e8a-b62f-f425e9327ad8"),
                new Guid("1f340b45-a1cd-40e5-ac24-4390830b6236"),
                new Guid("2cf744c1-e357-4238-b55b-21b4567ca6b2"))
                                          {
                                              AssociationType = { ObjectType = IGT32Unit },
                                              RoleType =
                                                  {
                                                      ObjectType = AllorsString,
                                                      AssignedSingularName = "AllorsString16",
                                                      AssignedPluralName = "AllorsStrings16",
                                                      Size = 256
                                                  }
                                          };

            IGT32CompositeSelf8 = new RelationType(
                D,
                new Guid("8e898953-b166-4573-a56c-3be50b9c651d"),
                new Guid("aebde42b-3b60-4bb3-9a27-e5c9d70ff464"),
                new Guid("75ff9e3e-5fc3-4db0-a82c-d77735b5a277"))
                                      {
                                          AssociationType = { ObjectType = IGT32Composite },
                                          RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self8", AssignedPluralName = "Selfs8" }
                                      };

            C3I4many2many = new RelationType(
                D,
                new Guid("8f2225b7-8c15-414a-a9be-50c757f80b3e"),
                new Guid("b75bb087-63c3-475f-8e47-07d2d63ac499"),
                new Guid("a3f58a75-df00-4c97-8124-2a002864bdb4"))
                                {
                                    AssociationType = { ObjectType = C3, IsMany = true },
                                    RoleType =
                                        {
                                            ObjectType = I4,
                                            AssignedSingularName = "I4many2many",
                                            AssignedPluralName = "I4many2manies",
                                            IsMany = true
                                        }
                                };

            IGT32UnitAllorsString30 = new RelationType(
                D,
                new Guid("8f538538-785f-4cdc-9106-2137644f36ae"),
                new Guid("6fd9341d-223a-4313-a643-c8b1ad8465e8"),
                new Guid("fbe6646b-3323-4eea-8542-4283a097c3cb"))
                                          {
                                              AssociationType = { ObjectType = IGT32Unit },
                                              RoleType =
                                                  {
                                                      ObjectType = AllorsString,
                                                      AssignedSingularName = "AllorsString30",
                                                      AssignedPluralName = "AllorsStrings30",
                                                      Size = 256
                                                  }
                                          };

            S1C1one2one = new RelationType(
                D,
                new Guid("8f5485ba-5a82-4d01-809e-52b467f958d8"),
                new Guid("57120147-1a4b-4328-8ca0-4cd44e5a157e"),
                new Guid("8c79f471-118e-4f05-9069-7be505b2af71"))
                              {
                                  AssociationType = { ObjectType = S1 },
                                  RoleType = { ObjectType = C1, AssignedSingularName = "C1one2one", AssignedPluralName = "C1one2ones" }
                              };

            S1234S1234one2many = new RelationType(
                D,
                new Guid("8fb24e1c-9e04-4b3d-8a97-153d3c0ea7ec"),
                new Guid("468742f0-6fb4-4ca6-9b35-9a08f208ca8a"),
                new Guid("67068383-1966-4bcc-a0da-3fe42278a263"))
                                     {
                                         AssociationType = { ObjectType = S1234 },
                                         RoleType =
                                             {
                                                 ObjectType = S1234,
                                                 AssignedSingularName = "S1234one2many",
                                                 AssignedPluralName = "S1234one2manies",
                                                 IsMany = true
                                             }
                                     };

            I1DateTimeGreaterThan = new RelationType(
                D,
                new Guid("9095f55b-de23-49d7-a28e-918c22c5cfd2"),
                new Guid("969b2592-6bde-4af3-b75a-7e1a4d1fd2f6"),
                new Guid("00ff69ce-c661-4aa7-88a6-1883ed06295c"))
                                        {
                                            AssociationType = { ObjectType = I1 },
                                            RoleType =
                                                {
                                                    ObjectType = AllorsDateTime,
                                                    AssignedSingularName = "DateTimeGreaterThan",
                                                    AssignedPluralName = "DateTimesGreaterThan"
                                                }
                                        };

            IGT32CompositeSelf24 = new RelationType(
                D,
                new Guid("90bb79e0-d32b-49e9-8c05-b02505a31858"),
                new Guid("4d753be1-9e9b-4b4c-8ce8-c65351bf44e9"),
                new Guid("b1a2759f-4b17-4f65-9a7b-5973902d73da"))
                                       {
                                           AssociationType = { ObjectType = IGT32Composite },
                                           RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self24", AssignedPluralName = "Selfs24" }
                                       };

            IGT32CompositeSelf12 = new RelationType(
                D,
                new Guid("90fe5360-126b-4b2d-a7ba-b29c026883a4"),
                new Guid("13d05d0b-ee32-44fe-b4bb-18a3f9bcaa6e"),
                new Guid("2db881ee-b76b-4adc-95fa-b2b9b598ef19"))
                                       {
                                           AssociationType = { ObjectType = IGT32Composite },
                                           RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self12", AssignedPluralName = "Selfs12" }
                                       };

            I1I34many2many = new RelationType(
                D,
                new Guid("912eeb1b-c5d6-4ea3-9e66-6d92cc455ef6"),
                new Guid("96696293-9326-4a9b-9a85-97897d517007"),
                new Guid("4b1de97f-e65e-44a0-bbfd-f0fd6c9b7297"))
                                 {
                                     AssociationType = { ObjectType = I1, IsMany = true },
                                     RoleType =
                                         {
                                             ObjectType = I34,
                                             AssignedSingularName = "I34many2many",
                                             AssignedPluralName = "I34many2manies",
                                             IsMany = true
                                         }
                                 };

            C1AllorsLong = new RelationType(
                D,
                new Guid("91e8b23b-48fb-4d20-8a71-89c5630f1c78"),
                new Guid("2bc55292-aea1-44f5-b90a-e6b76962ba69"),
                new Guid("dd7ec053-d621-44c4-9975-18bcc487bda0")) { AssociationType = { ObjectType = C1 }, RoleType = { ObjectType = AllorsLong } };

            C3C2one2many = new RelationType(
                D,
                new Guid("92505f70-3611-4ed6-bd27-71030299e176"),
                new Guid("c817ff5f-b31f-43e5-b04d-72d28c666085"),
                new Guid("7a9e571f-beea-47a9-9bdc-d498d5bef2ae"))
                               {
                                   AssociationType = { ObjectType = C3 },
                                   RoleType =
                                       {
                                           ObjectType = C2,
                                           AssignedSingularName = "C2one2many",
                                           AssignedPluralName = "C2one2manies",
                                           IsMany = true
                                       }
                               };

            I1I34one2one = new RelationType(
                D,
                new Guid("9291fb85-9d1f-4c5d-96ec-797be51557ce"),
                new Guid("f89a79a7-c333-4b65-ac59-5e298cd60a65"),
                new Guid("441a8475-351f-4500-a2ba-784b87d66bc5"))
                               {
                                   AssociationType = { ObjectType = I1 },
                                   RoleType = { ObjectType = I34, AssignedSingularName = "I34one2one", AssignedPluralName = "I34one2ones" }
                               };

            C1S2one2one = new RelationType(
                D,
                new Guid("92cbd254-9763-41e1-9c73-4a378aab4b8e"),
                new Guid("b45956b3-634f-4620-83e2-4606c6002e47"),
                new Guid("a8cd0a6a-3d77-48ab-85f4-5064e0e57074"))
                              {
                                  AssociationType = { ObjectType = C1 },
                                  RoleType = { ObjectType = S2, AssignedSingularName = "S2one2one", AssignedPluralName = "S2one2ones" }
                              };

            C1DateTimeBetweenB = new RelationType(
                D,
                new Guid("934421bd-6cac-4e99-9457-43117a9f3c52"),
                new Guid("c5f79c2e-99bf-42fc-aecd-344f43dc01fe"),
                new Guid("9362ace7-c31e-4077-a1eb-97548d2392a8"))
                                     {
                                         AssociationType = { ObjectType = C1 },
                                         RoleType =
                                             {
                                                 ObjectType = AllorsDateTime,
                                                 AssignedSingularName = "DateTimeBetweenB",
                                                 AssignedPluralName = "DateTimesBetweenB"
                                             }
                                     };

            S1234C2one2many = new RelationType(
                D,
                new Guid("94a49847-273f-4e9b-b07b-d615d994757a"),
                new Guid("a9421230-08a7-4ad0-8206-4732ac3f3413"),
                new Guid("3d8fee19-54b4-4ee9-8de6-8fc267fd4daf"))
                                  {
                                      AssociationType = { ObjectType = S1234 },
                                      RoleType =
                                          {
                                              ObjectType = C2,
                                              AssignedSingularName = "C2one2many",
                                              AssignedPluralName = "C2one2manies",
                                              IsMany = true
                                          }
                                  };

            I12AllorsLong = new RelationType(
                D,
                new Guid("94b55cec-cf78-420b-b4c9-1bca8a8af9dc"),
                new Guid("ff92ccd6-70c9-4a26-95ce-5e1f0012cc80"),
                new Guid("33f6448e-1aef-4fea-be23-aa1cb16c8908")) { AssociationType = { ObjectType = I12 }, RoleType = { ObjectType = AllorsLong } };

            C2C1one2one = new RelationType(
                D,
                new Guid("9540e8d3-9fe3-4aea-9918-fc31210f2622"),
                new Guid("dbac8142-7278-4a5c-9b99-be065fa4bf60"),
                new Guid("ab18bbdb-96b8-4a03-a797-246bcd8bb16b"))
                              {
                                  AssociationType = { ObjectType = C2 },
                                  RoleType = { ObjectType = C1, AssignedSingularName = "C1one2one", AssignedPluralName = "C1one2ones" }
                              };

            C3C2many2one = new RelationType(
                D,
                new Guid("958bc7c6-d609-4407-ba92-50726c9af5d5"),
                new Guid("6ec989ea-a41e-46ac-b754-617c204a314c"),
                new Guid("7e9f33f4-28a2-4abd-bb10-6acab5c6ab94"))
                               {
                                   AssociationType = { ObjectType = C3, IsMany = true },
                                   RoleType = { ObjectType = C2, AssignedSingularName = "C2many2one", AssignedPluralName = "C2many2ones" }
                               };

            I1I1one2many = new RelationType(
                D,
                new Guid("95fff847-922f-4d6f-9e98-37013bdf6b06"),
                new Guid("8faa2719-125a-40e5-837d-c69b1e31fec1"),
                new Guid("bd8cc57b-d61c-4712-a25e-897c545f1d80"))
                               {
                                   AssociationType = { ObjectType = I1 },
                                   RoleType =
                                       {
                                           ObjectType = I1,
                                           AssignedSingularName = "I1one2many",
                                           AssignedPluralName = "I1one2manies",
                                           IsMany = true
                                       }
                               };

            IGT32UnitAllorsString12 = new RelationType(
                D,
                new Guid("96f9bb98-8658-4903-9b97-7dbb50ac258d"),
                new Guid("8f93a34b-90c5-4a75-90c1-3ccab5201d7a"),
                new Guid("9a14e339-cb71-40db-8967-b132d7d503cf"))
                                          {
                                              AssociationType = { ObjectType = IGT32Unit },
                                              RoleType =
                                                  {
                                                      ObjectType = AllorsString,
                                                      AssignedSingularName = "AllorsString12",
                                                      AssignedPluralName = "AllorsStrings12",
                                                      Size = 256
                                                  }
                                          };

            I1I1many2many = new RelationType(
                D,
                new Guid("9735d027-4249-4540-9658-f3ec06d3b868"),
                new Guid("82864251-210d-43b3-9fc7-47c7cdf012a2"),
                new Guid("0d008a4b-9396-4fa1-b020-4ddf06d0a0ca"))
                                {
                                    AssociationType = { ObjectType = I1, IsMany = true },
                                    RoleType =
                                        {
                                            ObjectType = I1,
                                            AssignedSingularName = "I1many2many",
                                            AssignedPluralName = "I1many2manies",
                                            IsMany = true
                                        }
                                };

            I1S2many2many = new RelationType(
                D,
                new Guid("973d6e4f-57ff-454a-9621-bd5dccb65525"),
                new Guid("2db0a4fd-f65b-460c-b286-ac8558e2acfc"),
                new Guid("87593b08-18e6-4358-bbae-5766cc2e59d8"))
                                {
                                    AssociationType = { ObjectType = I1, IsMany = true },
                                    RoleType =
                                        {
                                            ObjectType = S2,
                                            AssignedSingularName = "S2many2many",
                                            AssignedPluralName = "S2many2manies",
                                            IsMany = true
                                        }
                                };

            C1AllorsBinary = new RelationType(
                D,
                new Guid("97f31053-0e7b-42a0-90c2-ce6f09c56e86"),
                new Guid("86e72d26-4ea6-4637-9959-c0f4aceba0e6"),
                new Guid("850808bb-fac8-4a90-af6c-321e4722f92f")) { AssociationType = { ObjectType = C1 }, RoleType = { ObjectType = AllorsBinary, Size = -1 } };

            IGT32CompositeSelf7 = new RelationType(
                D,
                new Guid("991b59d1-9225-4534-a86e-8668068c9d45"),
                new Guid("8e12bc0e-f6a5-4386-9a8e-b0418ff303f0"),
                new Guid("2079ca25-28f9-45c7-993f-f98dbfd1dbe7"))
                                      {
                                          AssociationType = { ObjectType = IGT32Composite },
                                          RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self7", AssignedPluralName = "Selfs7" }
                                      };

            CompanyNamedManySort1 = new RelationType(
                D,
                new Guid("996d27ff-3615-4a51-9214-944fac566a11"),
                new Guid("63ba9dd7-8a6c-4072-a6bb-b6f7229b90a7"),
                new Guid("1c2a03e6-30f3-4257-bc6c-744b01d3a264"))
                                        {
                                            AssociationType = { ObjectType = Company, IsMany = true },
                                            RoleType =
                                                {
                                                    ObjectType = Named,
                                                    AssignedSingularName = "NamedManySort1",
                                                    AssignedPluralName = "NamedsManySort1",
                                                    IsMany = true
                                                }
                                        };

            S2AllorsBoolean = new RelationType(
                D,
                new Guid("9a191c76-bd05-498f-91da-33184c72fe90"),
                new Guid("6dadca9c-e6b0-42be-b29d-ba40b19f4e4a"),
                new Guid("bd759535-1681-455f-b140-2dcfea268b0a")) { AssociationType = { ObjectType = S2 }, RoleType = { ObjectType = AllorsBoolean } };

            I1I12many2many = new RelationType(
                D,
                new Guid("9b05ecb0-c3d5-4b11-98dc-653aef9f65cc"),
                new Guid("f343fb09-2b0c-48fb-9bfa-826c19420b39"),
                new Guid("b32bfb71-9a4b-4a28-bb21-8e0886a28c39"))
                                 {
                                     AssociationType = { ObjectType = I1, IsMany = true },
                                     RoleType =
                                         {
                                             ObjectType = I12,
                                             AssignedSingularName = "I12many2many",
                                             AssignedPluralName = "I12many2manies",
                                             IsMany = true
                                         }
                                 };

            I34AllorsDouble = new RelationType(
                D,
                new Guid("9b774204-37f3-4663-9162-dc801ea200f6"),
                new Guid("f45e6b10-2b46-4100-93c3-d76f25526df3"),
                new Guid("e5b452ba-b29f-47f4-be48-029289e91345")) { AssociationType = { ObjectType = I34 }, RoleType = { ObjectType = AllorsDouble } };

            C2AllorsString = new RelationType(
                D,
                new Guid("9c7cde3f-9b61-4c79-a5d7-afe1067262ce"),
                new Guid("41604445-0c6e-4d20-ae20-43619232438d"),
                new Guid("757e03f2-be92-4af7-ba0b-fa0ce9f5bda2")) { AssociationType = { ObjectType = C2 }, RoleType = { ObjectType = AllorsString, Size = 256 } };

            S2AllorsDecimal = new RelationType(
                D,
                new Guid("9d70a5f5-ed72-4ba3-98ac-e50752f8fb79"),
                new Guid("329528a6-1712-4112-9797-761338248769"),
                new Guid("f155d4f3-bcda-47a2-8be2-ba24ba6648e5")) { AssociationType = { ObjectType = S2 }, RoleType = { ObjectType = AllorsDecimal, Scale = 2, Precision = 19 } };

            C1DateTimeGreaterThan = new RelationType(
                D,
                new Guid("9d8c9863-dd8d-4c85-a5e6-58042ff3619d"),
                new Guid("e8f5d99c-7dfb-44b4-8951-9cc37d84f5a6"),
                new Guid("708c391d-94a5-4c08-8cdc-ecb74cf7ac76"))
                                        {
                                            AssociationType = { ObjectType = C1 },
                                            RoleType =
                                                {
                                                    ObjectType = AllorsDateTime,
                                                    AssignedSingularName = "DateTimeGreaterThan",
                                                    AssignedPluralName = "DateTimesGreaterThan"
                                                }
                                        };

            C1S1one2one = new RelationType(
                D,
                new Guid("9df07ff8-7a29-4d41-a08e-d46efdd15e32"),
                new Guid("da3963b0-9ac1-4bab-bfac-5e29712b563e"),
                new Guid("e77e8e25-491c-448e-8792-6ba90c1a374a"))
                              {
                                  AssociationType = { ObjectType = C1 },
                                  RoleType = { ObjectType = S1, AssignedSingularName = "S1one2one", AssignedPluralName = "S1one2ones" }
                              };

            C2C2one2one = new RelationType(
                D,
                new Guid("9e9d1c6a-f647-4922-b5f4-874b8b6c1907"),
                new Guid("a0d30124-e214-4b76-9442-af893f14baca"),
                new Guid("5e574659-c186-4ab6-9e64-79eb8d32017c"))
                              {
                                  AssociationType = { ObjectType = C2 },
                                  RoleType = { ObjectType = C2, AssignedSingularName = "C2one2one", AssignedPluralName = "C2one2ones" }
                              };

            C4AllorsString = new RelationType(
                D,
                new Guid("9f24fc51-8568-4ffc-b47a-c5c317d00954"),
                new Guid("77d762d7-4676-4b02-8319-11600c4314f3"),
                new Guid("6e74ef8d-d748-4142-8073-afbf5534c43f")) { AssociationType = { ObjectType = C4 }, RoleType = { ObjectType = AllorsString, Size = 256 } };

            I1StringEquals = new RelationType(
                D,
                new Guid("9f70c4eb-2e36-4ae1-8ed2-b3fab908e392"),
                new Guid("6439b6c0-8fd8-4f62-a6c9-def7bd64e5e7"),
                new Guid("3ff3567a-41d1-447c-b6f1-1695a92e02c8"))
                                 {
                                     AssociationType = { ObjectType = I1 },
                                     RoleType =
                                         {
                                             ObjectType = AllorsString,
                                             AssignedSingularName = "StringEquals",
                                             AssignedPluralName = "StringsEquals",
                                             Size = 256
                                         }
                                 };

            I2AllorsString = new RelationType(
                D,
                new Guid("9f91841c-f63f-4ffa-bee6-62e100f3cd15"),
                new Guid("8841f638-0522-46b6-a6cf-797548264f0d"),
                new Guid("15ba5c39-5269-4f61-b595-7b8b6fcefe9a")) { AssociationType = { ObjectType = I2 }, RoleType = { ObjectType = AllorsString, Size = 256 } };

            I12AllorsDecimal = new RelationType(
                D,
                new Guid("9fbca845-1f98-4ac8-8117-fa66bbe287eb"),
                new Guid("ec0a4183-87a3-4755-b9f1-d887bf966605"),
                new Guid("5495d54b-111e-43a4-8fcf-0b3af218340c")) { AssociationType = { ObjectType = I12 }, RoleType = { ObjectType = AllorsDecimal, Scale = 2, Precision = 19 } };

            S1AllorsBoolean = new RelationType(
                D,
                new Guid("9fbcf7ce-3b59-458d-ab5e-9c48dd3842b3"),
                new Guid("6e426f4b-3dc1-4c13-a03f-3875997f7ba5"),
                new Guid("75f3149d-52c9-4aca-bee7-1d24a2a5751b")) { AssociationType = { ObjectType = S1 }, RoleType = { ObjectType = AllorsBoolean } };

            IGT32UnitAllorsString26 = new RelationType(
                D,
                new Guid("a0ce37ac-ec40-4215-9ff6-7b39121080af"),
                new Guid("489b3bb1-a4e5-4e19-af97-a69db6025671"),
                new Guid("eb6e341b-0a4d-4367-a341-b3480868f0c0"))
                                          {
                                              AssociationType = { ObjectType = IGT32Unit },
                                              RoleType =
                                                  {
                                                      ObjectType = AllorsString,
                                                      AssignedSingularName = "AllorsString26",
                                                      AssignedPluralName = "AllorsStrings26",
                                                      Size = 256
                                                  }
                                          };

            IGT32CompositeSelf6 = new RelationType(
                D,
                new Guid("a11bfd43-47a9-4f0f-a20a-ec60939a4de1"),
                new Guid("461777fc-08cd-472b-a1a5-ee85e23771d4"),
                new Guid("e75e4c7d-8dcc-49e5-bad6-623a221eb845"))
                                      {
                                          AssociationType = { ObjectType = IGT32Composite },
                                          RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self6", AssignedPluralName = "Selfs6" }
                                      };

            S1234S1234many2many = new RelationType(
                D,
                new Guid("a2e7c6f6-ca0d-4fb3-9431-8dd1be7ebdb7"),
                new Guid("44861773-ca9e-462f-b05b-0f2309208ebf"),
                new Guid("6534a951-0ee2-4574-b54f-3f2fdf8f694b"))
                                      {
                                          AssociationType = { ObjectType = S1234, IsMany = true },
                                          RoleType =
                                              {
                                                  ObjectType = S1234,
                                                  AssignedSingularName = "S1234many2many",
                                                  AssignedPluralName = "S1234many2manies",
                                                  IsMany = true
                                              }
                                      };

            S2AllorsDateTime = new RelationType(
                D,
                new Guid("a305d91a-5fe1-467d-9f24-6cce5dd30b1d"),
                new Guid("a50b4bfa-3a0e-411c-b9f5-2af203b58668"),
                new Guid("51f99d5f-bccf-4252-9475-dcf724e775d9")) { AssociationType = { ObjectType = S2 }, RoleType = { ObjectType = AllorsDateTime } };

            S12C2one2many = new RelationType(
                D,
                new Guid("a3aac482-aad0-4b59-9361-51b23867e5a2"),
                new Guid("f63d8a2d-257d-459b-98be-73847a54a91d"),
                new Guid("e3f037d9-70f7-4ab2-a14f-645efd1528b9"))
                                {
                                    AssociationType = { ObjectType = S12 },
                                    RoleType =
                                        {
                                            ObjectType = C2,
                                            AssignedSingularName = "C2one2many",
                                            AssignedPluralName = "C2one2manies",
                                            IsMany = true
                                        }
                                };

            I1LongGreaterThan = new RelationType(
                D,
                new Guid("a4001f82-570e-441a-8d74-bac9241f12f2"),
                new Guid("1ff07348-76bd-438c-a779-6b0b9828c381"),
                new Guid("96cb1073-a1fc-4425-8d97-2f43439ef047"))
                                    {
                                        AssociationType = { ObjectType = I1 },
                                        RoleType =
                                            {
                                                ObjectType = AllorsLong,
                                                AssignedSingularName = "LongGreaterThan",
                                                AssignedPluralName = "LongsAllors"
                                            }
                                    };

            I1I12one2many = new RelationType(
                D,
                new Guid("a458ad6e-0f4a-473b-a233-04b8e7fadf62"),
                new Guid("39d37d93-d921-4922-a73c-783ae90f7367"),
                new Guid("2ca3ff16-fb9e-4c70-bc0c-37805e6233e6"))
                                {
                                    AssociationType = { ObjectType = I1 },
                                    RoleType =
                                        {
                                            ObjectType = I12,
                                            AssignedSingularName = "I12one2many",
                                            AssignedPluralName = "I12one2manies",
                                            IsMany = true
                                        }
                                };

            IGT32UnitAllorsString17 = new RelationType(
                D,
                new Guid("a5ed3f77-5f87-4994-8f25-a35fad3f71fe"),
                new Guid("8d105340-71f2-4e8f-bd77-8eb9762e443f"),
                new Guid("c80e5722-43de-4cdd-9091-d464a14bc7ef"))
                                          {
                                              AssociationType = { ObjectType = IGT32Unit },
                                              RoleType =
                                                  {
                                                      ObjectType = AllorsString,
                                                      AssignedSingularName = "AllorsString17",
                                                      AssignedPluralName = "AllorsStrings17",
                                                      Size = 256
                                                  }
                                          };

            IGT32UnitAllorsString4 = new RelationType(
                D,
                new Guid("a6c3242f-aab8-481e-803e-67d7d45f15d3"),
                new Guid("07b8a6f0-13b8-4e2d-a9b5-59f2f25eb4ae"),
                new Guid("a97f68a2-1fe2-44f3-ab36-a4706753b3d8"))
                                         {
                                             AssociationType = { ObjectType = IGT32Unit },
                                             RoleType =
                                                 {
                                                     ObjectType = AllorsString,
                                                     AssignedSingularName = "AllorsString4",
                                                     AssignedPluralName = "AllorsStrings4",
                                                     Size = 256
                                                 }
                                         };

            I1S2one2many = new RelationType(
                D,
                new Guid("a77bcd80-82df-4b76-a1bc-8e78106d7d53"),
                new Guid("3ef21f1e-20fd-4046-9014-dcc5043ec2a3"),
                new Guid("c2ac2352-acec-4b8a-9569-9dd3e45a8fb6"))
                               {
                                   AssociationType = { ObjectType = I1 },
                                   RoleType =
                                       {
                                           ObjectType = S2,
                                           AssignedSingularName = "S2one2many",
                                           AssignedPluralName = "S2one2manies",
                                           IsMany = true
                                       }
                               };

            IGT32UnitAllorsString10 = new RelationType(
                D,
                new Guid("a91487f7-8b1a-454c-9adb-e14c3ac49271"),
                new Guid("560dfea9-81ce-479d-b676-3e9782e3f874"),
                new Guid("fe90b8f1-e3fa-414c-9273-1fd6de0759e3"))
                                          {
                                              AssociationType = { ObjectType = IGT32Unit },
                                              RoleType =
                                                  {
                                                      ObjectType = AllorsString,
                                                      AssignedSingularName = "AllorsString10",
                                                      AssignedPluralName = "AllorsStrings10",
                                                      Size = 256
                                                  }
                                          };

            C2C2one2many = new RelationType(
                D,
                new Guid("a95948a7-3f12-4b85-8823-82dea87740c0"),
                new Guid("72bd6031-935f-4280-8048-188ca54e602e"),
                new Guid("6248a324-04b8-423e-92ac-5ba38be3b72f"))
                               {
                                   AssociationType = { ObjectType = C2 },
                                   RoleType =
                                       {
                                           ObjectType = C2,
                                           AssignedSingularName = "C2one2many",
                                           AssignedPluralName = "C2one2manies",
                                           IsMany = true
                                       }
                               };

            S12AllorsBoolean = new RelationType(
                D,
                new Guid("a97eca8e-807b-4a06-9587-6240f6150203"),
                new Guid("d2c367ed-8001-4f16-882c-64d3e30da8d1"),
                new Guid("e86db1ff-d072-42eb-9493-bc01984b7d8d")) { AssociationType = { ObjectType = S12 }, RoleType = { ObjectType = AllorsBoolean } };

            CompanyPersonManySort2 = new RelationType(
                D,
                new Guid("a9f60154-6bd1-4c76-94eb-edfd5beb6749"),
                new Guid("268a1cbf-d0d8-42da-a5e3-fe55a139bdfd"),
                new Guid("18d5ae26-2d4c-452b-9b8b-f78fc30cf6b8"))
                                         {
                                             AssociationType = { ObjectType = Company, IsMany = true },
                                             RoleType =
                                                 {
                                                     ObjectType = Person,
                                                     AssignedSingularName = "PersonManySort2",
                                                     AssignedPluralName = "PersonsManySort2",
                                                     IsMany = true
                                                 }
                                         };

            C1C1one2many = new RelationType(
                D,
                new Guid("ab6d11cc-ec86-4828-8875-2e9a779ba627"),
                new Guid("47893ddf-f5c4-4f72-8be1-18366fcb190e"),
                new Guid("0ca9b283-3af4-421b-acf5-f4c26794461f"))
                               {
                                   AssociationType = { ObjectType = C1 },
                                   RoleType =
                                       {
                                           ObjectType = C1,
                                           AssignedSingularName = "C1one2many",
                                           AssignedPluralName = "C1one2manies",
                                           IsMany = true
                                       }
                               };

            IGT32UnitAllorsString23 = new RelationType(
                D,
                new Guid("abd8508a-e03a-4bee-ac5f-738551400205"),
                new Guid("e427e6d0-ac88-4692-8006-fdbcd2953bfb"),
                new Guid("3310f3d8-9a83-4530-9a35-c42a933bc354"))
                                          {
                                              AssociationType = { ObjectType = IGT32Unit },
                                              RoleType =
                                                  {
                                                      ObjectType = AllorsString,
                                                      AssignedSingularName = "AllorsString23",
                                                      AssignedPluralName = "AllorsStrings23",
                                                      Size = 256
                                                  }
                                          };

            C1I1one2many = new RelationType(
                D,
                new Guid("ac0cfbe2-a2ff-4781-83aa-5d4e459d939f"),
                new Guid("441e5063-314e-410f-a478-74f643f18924"),
                new Guid("59e3f607-eb50-474a-9738-9aa08bacb2f4"))
                               {
                                   AssociationType = { ObjectType = C1 },
                                   RoleType =
                                       {
                                           ObjectType = I1,
                                           AssignedSingularName = "I1one2many",
                                           AssignedPluralName = "I1one2manies",
                                           IsMany = true
                                       }
                               };

            C1C2many2one = new RelationType(
                D,
                new Guid("ac2096a9-b58b-41d3-a1d3-920f0b41cb2f"),
                new Guid("a75af8b0-b169-4dc0-af9f-9e779ed8ed79"),
                new Guid("b6f608f0-08a8-4af0-bb73-29508c1e7046"))
                               {
                                   AssociationType = { ObjectType = C1, IsMany = true },
                                   RoleType = { ObjectType = C2, AssignedSingularName = "C2many2one", AssignedPluralName = "C2many2ones" }
                               };

            S12AllorsDouble = new RelationType(
                D,
                new Guid("acc4ae39-2d5c-4485-be22-87b27e84b627"),
                new Guid("2b86671d-b870-4007-b564-bb0c10b40bc3"),
                new Guid("64d27877-edf1-4136-a810-19a5d5356110")) { AssociationType = { ObjectType = S12 }, RoleType = { ObjectType = AllorsDouble } };

            SingleUnitAllorsInteger = new RelationType(
                D,
                new Guid("acf7d284-2480-4a09-a13b-ba4ba96e0892"),
                new Guid("b15641e3-ad46-4c90-bc58-32758a27e53e"),
                new Guid("8e0df573-0931-4bf0-a3bb-1cf88a530d98")) { AssociationType = { ObjectType = SingleUnit }, RoleType = { ObjectType = AllorsInteger } };

            C1I12one2many = new RelationType(
                D,
                new Guid("ad1b1fb1-b30c-431f-b975-5505f6311a18"),
                new Guid("8def87bd-ae8e-46b5-a98a-a44f49c71650"),
                new Guid("181907ac-c5a3-446a-85af-b624c496e6c4"))
                                {
                                    AssociationType = { ObjectType = C1 },
                                    RoleType =
                                        {
                                            ObjectType = I12,
                                            AssignedSingularName = "I12one2many",
                                            AssignedPluralName = "I12one2manies",
                                            IsMany = true
                                        }
                                };

            IGT32CompositeSelf25 = new RelationType(
                D,
                new Guid("ae8fbd21-64dd-4667-b0d9-f6398e14364f"),
                new Guid("8212076e-9608-4544-9668-12875ccfcf42"),
                new Guid("b6bf3a92-b231-4dd7-8bc6-28a9a7ee4a6e"))
                                       {
                                           AssociationType = { ObjectType = IGT32Composite },
                                           RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self25", AssignedPluralName = "Selfs25" }
                                       };

            I12C2one2one = new RelationType(
                D,
                new Guid("afabb84c-f1b3-423b-9028-2ec5bb58e994"),
                new Guid("08c02665-ae9b-4662-848b-de19a5285a69"),
                new Guid("9333b3f8-9c12-4627-9196-b4b123b530b2"))
                               {
                                   AssociationType = { ObjectType = I12 },
                                   RoleType = { ObjectType = C2, AssignedSingularName = "C2one2one", AssignedPluralName = "C2one2ones" }
                               };

            S1234AllorsLong = new RelationType(
                D,
                new Guid("b0814062-4881-43ec-935e-c6b61ef0bcf6"),
                new Guid("367a7c52-5a76-4444-bdd8-fccc276560d5"),
                new Guid("fb2e5e27-790c-4a1e-bb31-1d2a80e9f785")) { AssociationType = { ObjectType = S1234 }, RoleType = { ObjectType = AllorsLong } };

            I12C3one2many = new RelationType(
                D,
                new Guid("b0fc73fb-fa74-4e8c-b9e1-17c01698f342"),
                new Guid("9fb686d0-2bad-4bba-be8f-0dab7d6b0106"),
                new Guid("c584f1da-431f-4d9c-8870-aad87e4f104b"))
                                {
                                    AssociationType = { ObjectType = I12 },
                                    RoleType =
                                        {
                                            ObjectType = C3,
                                            AssignedSingularName = "C3one2many",
                                            AssignedPluralName = "C3one2manies",
                                            IsMany = true
                                        }
                                };

            C1S2many2many = new RelationType(
                D,
                new Guid("b2071550-cc1b-4543-b98f-006e7564a74b"),
                new Guid("313bf740-637d-4f6a-af82-74a488bde357"),
                new Guid("2a00cf34-3dda-4c12-9adc-10843460df40"))
                                {
                                    AssociationType = { ObjectType = C1, IsMany = true },
                                    RoleType = { ObjectType = S2, AssignedSingularName = "S2many2many", AssignedPluralName = "S2many2manies" }
                                };

            ILT32UnitAllorsString3 = new RelationType(
                D,
                new Guid("b2734796-7140-4830-a0de-88df7d27b6a8"),
                new Guid("182f98a8-db0b-4809-bb02-d1f3dea4d55f"),
                new Guid("a89b3426-3e2b-450e-8137-a96a2563200d"))
                                         {
                                             AssociationType = { ObjectType = ILT32Unit },
                                             RoleType =
                                                 {
                                                     ObjectType = AllorsString,
                                                     AssignedSingularName = "AllorsString3",
                                                     AssignedPluralName = "AllorsStrings3",
                                                     Size = 256
                                                 }
                                         };

            S1234ClassName = new RelationType(
                D,
                new Guid("b299db28-1107-4120-946c-fbdad2271c5c"),
                new Guid("385dc31e-b277-484c-b448-9c532a0196ba"),
                new Guid("4716308c-67b8-492b-a9d5-0be18ade8344"))
                                 {
                                     AssociationType = { ObjectType = S1234 },
                                     RoleType =
                                         {
                                             ObjectType = AllorsString,
                                             AssignedSingularName = "ClassName",
                                             AssignedPluralName = "ClassNames",
                                             Size = 256
                                         }
                                 };

            IGT32UnitAllorsString24 = new RelationType(
                D,
                new Guid("b43ff179-22f1-47cb-a304-24e4ec977cf9"),
                new Guid("1e5c5833-a45c-47f7-8f51-a7139da933f7"),
                new Guid("a3f38c08-a6af-44f9-92b3-4ba091d47d03"))
                                          {
                                              AssociationType = { ObjectType = IGT32Unit },
                                              RoleType =
                                                  {
                                                      ObjectType = AllorsString,
                                                      AssignedSingularName = "AllorsString24",
                                                      AssignedPluralName = "AllorsStrings24",
                                                      Size = 256
                                                  }
                                          };

            InterfaceWithoutConcreteClassAllorsBoolean = new RelationType(
                D,
                new Guid("b490715d-e318-471b-bd37-1c1e12c0314e"),
                new Guid("6730e78c-e678-4763-aa98-a5de1be1500c"),
                new Guid("e7edc290-a280-40dc-acc6-a6b7ebbb09b0")) { AssociationType = { ObjectType = InterfaceWithoutConcreteClass }, RoleType = { ObjectType = AllorsBoolean } };

            C1C2one2one = new RelationType(
                D,
                new Guid("b4e3d3d1-65b2-4803-954f-1e09f39e5594"),
                new Guid("acace7a9-505a-4571-a984-9f92b73a974b"),
                new Guid("e59784f1-7943-4f5c-a8ca-30b3483949d0"))
                              {
                                  AssociationType = { ObjectType = C1 },
                                  RoleType = { ObjectType = C2, AssignedSingularName = "C2one2one", AssignedPluralName = "C2one2ones" }
                              };

            C1AllorsBoolean = new RelationType(
                D,
                new Guid("b4ee673f-bba0-4e24-9cda-3cf993c79a0a"),
                new Guid("228c0dcf-0f5a-4cde-8769-f91f2b4cc58d"),
                new Guid("1cb9182b-4cf7-4050-a4d2-4eea351712ab")) { AssociationType = { ObjectType = C1 }, RoleType = { ObjectType = AllorsBoolean } };

            I1C2many2many = new RelationType(
                D,
                new Guid("b4f171d3-1463-41bc-8230-e53e5a717b89"),
                new Guid("e56a1b63-1f5b-489a-8cc2-b56945875f97"),
                new Guid("13c15568-8869-4516-93bf-d962688e1195"))
                                {
                                    AssociationType = { ObjectType = I1, IsMany = true },
                                    RoleType =
                                        {
                                            ObjectType = C2,
                                            AssignedSingularName = "C2many2many",
                                            AssignedPluralName = "C2many2manies",
                                            IsMany = true
                                        }
                                };

            IGT32CompositeSelf20 = new RelationType(
                D,
                new Guid("b6e0754a-b271-4853-afa0-fddb96444249"),
                new Guid("eec8d684-94e4-4b52-bb28-fa68abef3f41"),
                new Guid("5abf2048-fd10-44dc-98d6-590f0f54225e"))
                                       {
                                           AssociationType = { ObjectType = IGT32Composite },
                                           RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self20", AssignedPluralName = "Selfs20" }
                                       };

            C3I4many2one = new RelationType(
                D,
                new Guid("b7745909-a63a-448a-b4bd-6caf614c4b12"),
                new Guid("7d073606-bcb1-4bd8-a4ee-5f7c24712638"),
                new Guid("9e354367-0938-489f-a5df-4d6c1dd95875"))
                               {
                                   AssociationType = { ObjectType = C3, IsMany = true },
                                   RoleType = { ObjectType = I4, AssignedSingularName = "I4many2one", AssignedPluralName = "I4many2ones" }
                               };

            I12C3many2many = new RelationType(
                D,
                new Guid("b889bc75-3d93-4577-a4d7-752393284220"),
                new Guid("7df93147-276f-419d-b4b2-ff6dba76c683"),
                new Guid("18a37e3c-539c-4cf5-9f75-05295f1bacda"))
                                 {
                                     AssociationType = { ObjectType = I12, IsMany = true },
                                     RoleType =
                                         {
                                             ObjectType = C3,
                                             AssignedSingularName = "C3many2many",
                                             AssignedPluralName = "C3many2manies",
                                             IsMany = true
                                         }
                                 };

            IGT32UnitAllorsString1 = new RelationType(
                D,
                new Guid("b9309d7a-9946-4462-93a8-51f78efe0696"),
                new Guid("5d473a52-c378-48fc-84cb-28b3b288e756"),
                new Guid("bb15fdc0-fa65-4950-8ef7-b195fce9c7c8"))
                                         {
                                             AssociationType = { ObjectType = IGT32Unit },
                                             RoleType =
                                                 {
                                                     ObjectType = AllorsString,
                                                     AssignedSingularName = "AllorsString1",
                                                     AssignedPluralName = "AllorsStrings1",
                                                     Size = 256
                                                 }
                                         };

            I1AllorsBinary = new RelationType(
                D,
                new Guid("b9c67658-4abc-41f3-9434-c8512a482179"),
                new Guid("689fc6d4-edb2-450d-8b05-98da35974a53"),
                new Guid("a19db58e-703d-408a-92d1-f2b7191b0b61")) { AssociationType = { ObjectType = I1 }, RoleType = { ObjectType = AllorsBinary, Size = -1 } };

            IGT32CompositeSelf9 = new RelationType(
                D,
                new Guid("b9d79c6c-46cb-4bd8-80a7-8bcae27a3d3c"),
                new Guid("1b612909-2242-464c-bb1d-65a50e736092"),
                new Guid("9548f95c-f759-42f7-a34b-cd18786bedc0"))
                                      {
                                          AssociationType = { ObjectType = IGT32Composite },
                                          RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self9", AssignedPluralName = "Selfs9" }
                                      };

            S2AllorsLong = new RelationType(
                D,
                new Guid("bbb8d0fa-fe1e-49a6-a18d-0c790e52bb0c"),
                new Guid("29ebc8d6-6acd-4334-9596-7c5d5ce9d037"),
                new Guid("6a019bf8-39fa-4a20-98e7-616021add661")) { AssociationType = { ObjectType = S2 }, RoleType = { ObjectType = AllorsLong } };

            UserFrom = new RelationType(
                D,
                new Guid("bc6b71a8-2a66-4b57-9c86-ecf521b973ba"),
                new Guid("36058495-3b0d-416b-b2fb-cfe06e88035c"),
                new Guid("4ed76e62-3de2-415f-896e-c90d1f32e129"))
                           {
                               AssociationType = { ObjectType = User },
                               RoleType =
                                   {
                                       ObjectType = AllorsString,
                                       AssignedSingularName = "From",
                                       AssignedPluralName = "Froms",
                                       Size = 256
                                   }
                           };

            CompanyPersonOneSort2 = new RelationType(
                D,
                new Guid("bdf71d38-8082-4a99-9636-4f4ec26fd45c"),
                new Guid("06c013e8-e053-40db-b39e-6dc2ba4ec634"),
                new Guid("7ede6afc-ded3-453c-bd4d-5bc7034ba7d0"))
                                        {
                                            AssociationType = { ObjectType = Company },
                                            RoleType =
                                                {
                                                    ObjectType = Person,
                                                    AssignedSingularName = "PersonOneSort2",
                                                    AssignedPluralName = "PersonsOneSort2",
                                                    IsMany = true
                                                }
                                        };

            ILT32CompositeSelf3 = new RelationType(
                D,
                new Guid("be3fc71d-66d8-411f-ab5f-4ed91e437852"),
                new Guid("a0cba3a2-b964-46c0-9c84-0dcf4b7e91f7"),
                new Guid("a418995c-57b6-4a7a-a619-bdf2a58a184f"))
                                      {
                                          AssociationType = { ObjectType = ILT32Composite, IsMany = true },
                                          RoleType = { ObjectType = ILT32Composite, AssignedSingularName = "Self3", AssignedPluralName = "Selfs3" }
                                      };

            ILT32CompositeSelf2 = new RelationType(
                D,
                new Guid("c03a8b50-7fd1-4304-9d45-2c699fcbee80"),
                new Guid("a0eb47f7-e308-4d59-b7ef-439def081e76"),
                new Guid("17a1cd9e-2d03-476e-8e82-ce87230358aa"))
                                      {
                                          AssociationType = { ObjectType = ILT32Composite, IsMany = true },
                                          RoleType = { ObjectType = ILT32Composite, AssignedSingularName = "Self2", AssignedPluralName = "Selfs2" }
                                      };

            I1DecimalBetweenB = new RelationType(
                D,
                new Guid("c04d1e56-2686-495b-a02d-cda84f7cd2ff"),
                new Guid("97561659-0ddd-42c3-a575-13d111c39bda"),
                new Guid("f1c5aefc-bb7f-4017-82d9-b077b8107adf"))
                                    {
                                        AssociationType = { ObjectType = I1 },
                                        RoleType =
                                            {
                                                ObjectType = AllorsDecimal,
                                                AssignedSingularName = "DecimalBetweenB",
                                                AssignedPluralName = "DecimalsBetweenB",
                                                Scale = 2,
                                                Precision = 19
                                            }
                                    };

            S1C1many2many = new RelationType(
                D,
                new Guid("c0cfe3ee-d184-40bd-8354-b0b0bd4e641c"),
                new Guid("8e91bf46-bbb9-4b70-93ba-1f0ebd24c38e"),
                new Guid("3c0b8c2c-bd01-4fa7-9902-50ecec0a76ee"))
                                {
                                    AssociationType = { ObjectType = S1, IsMany = true },
                                    RoleType =
                                        {
                                            ObjectType = C1,
                                            AssignedSingularName = "C1many2many",
                                            AssignedPluralName = "C1many2manies",
                                            IsMany = true
                                        }
                                };

            I1LongBetweenA = new RelationType(
                D,
                new Guid("c1021c10-9065-46f0-9cbf-30fa1e9e06ae"),
                new Guid("30ae2803-8e9e-408b-aae3-19a7f44ffef0"),
                new Guid("80536399-7229-474d-b8c0-c77e531435f5"))
                                 {
                                     AssociationType = { ObjectType = I1 },
                                     RoleType =
                                         {
                                             ObjectType = AllorsLong,
                                             AssignedSingularName = "LongBetweenA",
                                             AssignedPluralName = "LongsBetweenA"
                                         }
                                 };

            S1234AllorsDateTime = new RelationType(
                D,
                new Guid("c13e8484-75a3-40be-afd5-44a31aca3771"),
                new Guid("da6964f3-54fa-4467-bacd-48764783f413"),
                new Guid("29672f22-7d09-4bca-b8a2-4170a8a8a8b1")) { AssociationType = { ObjectType = S1234 }, RoleType = { ObjectType = AllorsDateTime } };

            CompanyNamedManySort2 = new RelationType(
                D,
                new Guid("c1f68661-4999-4851-9224-1878258b6a58"),
                new Guid("2923d509-2017-4906-80ab-058bc389eebf"),
                new Guid("a1af343d-ea94-4433-893f-561d76a8aa7f"))
                                        {
                                            AssociationType = { ObjectType = Company, IsMany = true },
                                            RoleType =
                                                {
                                                    ObjectType = Named,
                                                    AssignedSingularName = "NamedManySort2",
                                                    AssignedPluralName = "NamedsManySort2"
                                                }
                                        };

            I12PrefetchTest = new RelationType(
                D,
                new Guid("c2d1f044-b996-4b16-8fe3-1786f86973b1"),
                new Guid("802b30da-76ab-4518-b6d8-204366a26b5e"),
                new Guid("decf4aeb-6d1f-4f6d-b130-ba706a388326"))
                                  {
                                      AssociationType = { ObjectType = I12 },
                                      RoleType =
                                          {
                                              ObjectType = AllorsString,
                                              AssignedSingularName = "PrefetchTest",
                                              AssignedPluralName = "PrefetchesTest",
                                              Size = 256
                                          }
                                  };

            S1234S1234one2one = new RelationType(
                D,
                new Guid("c2fac2fc-14c6-4aa3-89ff-afba1316d06d"),
                new Guid("b334c35e-f8aa-4047-b8c1-111cd570b26a"),
                new Guid("e6dc50eb-0d05-4f9a-82c2-9af6bbc82eda"))
                                    {
                                        AssociationType = { ObjectType = S1234 },
                                        RoleType = { ObjectType = S1234, AssignedSingularName = "S1234one2one", AssignedPluralName = "S1234one2one" }
                                    };

            I1DoubleGreaterThan = new RelationType(
                D,
                new Guid("c3496e43-335b-43b8-9fed-44439c9ae0d1"),
                new Guid("92e14e06-fc51-4e01-bd8c-37d5d4b70621"),
                new Guid("147642e9-ebb7-470e-9e57-4a47f8d4dbf4"))
                                      {
                                          AssociationType = { ObjectType = I1 },
                                          RoleType =
                                              {
                                                  ObjectType = AllorsDouble,
                                                  AssignedSingularName = "DoubleGreaterThan",
                                                  AssignedPluralName = "DoublesGreaterThan"
                                              }
                                      };

            I12AllorsDateTime = new RelationType(
                D,
                new Guid("c3a2e1da-307c-4fad-ab34-6e9d07eea74f"),
                new Guid("227fc236-366e-41bd-b694-5bc4a98c2b48"),
                new Guid("48afb12e-a36e-43f1-b1f1-c8b4e36de8b8")) { AssociationType = { ObjectType = I12 }, RoleType = { ObjectType = AllorsDateTime } };

            CompanyMany2ManyPerson = new RelationType(
                D,
                new Guid("c53bdaea-c0a5-4179-bfbb-e12de45e2ae0"),
                new Guid("d9b8505c-48e0-4012-9f8a-623f18f8cd3b"),
                new Guid("45e1bb36-5d7c-43dd-a889-2bcd6f225136"))
                                         {
                                             AssociationType = { ObjectType = Company, IsMany = true },
                                             RoleType =
                                                 {
                                                     ObjectType = Person,
                                                     AssignedSingularName = "Many2ManyPerson",
                                                     AssignedPluralName = "Many2ManyPersons",
                                                     IsMany = true
                                                 }
                                         };

            C1I12many2many = new RelationType(
                D,
                new Guid("c58903fb-443b-4de9-b010-15f3f09ff5df"),
                new Guid("4fd8ee39-c718-4776-aa82-2c44f0926ab5"),
                new Guid("32595220-456a-411b-8cff-d0ab6622ba0d"))
                                 {
                                     AssociationType = { ObjectType = C1, IsMany = true },
                                     RoleType =
                                         {
                                             ObjectType = I12,
                                             AssignedSingularName = "I12many2many",
                                             AssignedPluralName = "I12many2manies",
                                             IsMany = true
                                         }
                                 };

            IGT32CompositeSelf11 = new RelationType(
                D,
                new Guid("c643a160-556b-44bb-b3e4-232d291ff1e2"),
                new Guid("76de7b03-d4a5-4cf8-9631-e59f42ddda21"),
                new Guid("c7fa0675-83f0-4b3a-9f6b-0fbc1360f12a"))
                                       {
                                           AssociationType = { ObjectType = IGT32Composite },
                                           RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self11", AssignedPluralName = "Selfs11" }
                                       };

            IGT32CompositeSelf32 = new RelationType(
                D,
                new Guid("c662f343-3859-4d04-8d4b-011087c72885"),
                new Guid("7db277e5-ea82-4dc8-a8f0-9eb800cd7a0a"),
                new Guid("f3326b8a-e7c0-47b9-9311-5f826d9fe02b"))
                                       {
                                           AssociationType = { ObjectType = IGT32Composite },
                                           RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self32", AssignedPluralName = "Selfs32" }
                                       };

            IGT32CompositeSelf28 = new RelationType(
                D,
                new Guid("c6932f0a-e1de-4d93-ab94-80a5eb0a315c"),
                new Guid("13edb577-873b-40b7-8d5e-6a70c48cb8f0"),
                new Guid("81b25bc2-b44a-448c-a944-163b813285a0"))
                                       {
                                           AssociationType = { ObjectType = IGT32Composite },
                                           RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self28", AssignedPluralName = "Selfs28" }
                                       };

            S1S2many2many = new RelationType(
                D,
                new Guid("c6f49460-a259-44de-b674-4d0585fe00cd"),
                new Guid("9c577162-b64e-4457-bb57-dbfe690bb36d"),
                new Guid("75d4eda9-54d4-49ae-8ba6-a1dc9af34937"))
                                {
                                    AssociationType = { ObjectType = S1, IsMany = true },
                                    RoleType =
                                        {
                                            ObjectType = S2,
                                            AssignedSingularName = "S2many2many",
                                            AssignedPluralName = "S2many2manies",
                                            IsMany = true
                                        }
                                };

            SandboxAllorsString = new RelationType(
                D,
                new Guid("c82d1693-7b88-4fab-8389-a43185c832ed"),
                new Guid("38d87065-0b21-42c2-92b7-a095b54b83be"),
                new Guid("d11ad34e-9079-4005-b803-90511894d73f")) { AssociationType = { ObjectType = Sandbox }, RoleType = { ObjectType = AllorsString, Size = 256 } };

            I1IntegerBetweenB = new RelationType(
                D,
                new Guid("c892a286-fe92-4b8b-98ba-c5e02fb96279"),
                new Guid("3de80cf6-a470-499e-b69c-fa42a3bb6f5f"),
                new Guid("0b658ec0-9440-4261-9d8b-b54a3540c492"))
                                    {
                                        AssociationType = { ObjectType = I1 },
                                        RoleType =
                                            {
                                                ObjectType = AllorsInteger,
                                                AssignedSingularName = "IntegerBetweenB",
                                                AssignedPluralName = "IntegersBetweenB"
                                            }
                                    };

            C1I2many2many = new RelationType(
                D,
                new Guid("c92fbc53-ae5e-450e-9681-ca17833e6e2f"),
                new Guid("4f0d537c-7880-475e-b924-c6ef99cd4f29"),
                new Guid("40c8a502-826d-4153-a373-581e2a24d4cd"))
                                {
                                    AssociationType = { ObjectType = C1, IsMany = true },
                                    RoleType =
                                        {
                                            ObjectType = I2,
                                            AssignedSingularName = "I2many2many",
                                            AssignedPluralName = "I2many2manies",
                                            IsMany = true
                                        }
                                };

            I1DateTimeBetweenA = new RelationType(
                D,
                new Guid("c95ac96b-4385-4e31-8719-f120c76ab67a"),
                new Guid("7d094e06-7b45-4cf9-a65c-ff111a44ecf0"),
                new Guid("761b1ac8-87b2-440c-ab1b-06be3a6d5ab1"))
                                     {
                                         AssociationType = { ObjectType = I1 },
                                         RoleType =
                                             {
                                                 ObjectType = AllorsDateTime,
                                                 AssignedSingularName = "DateTimeBetweenA",
                                                 AssignedPluralName = "DateTimesBetweenA"
                                             }
                                     };

            IGT32CompositeSelf33 = new RelationType(
                D,
                new Guid("c9f2803b-890d-4370-831b-83c65805b160"),
                new Guid("ca6f01d8-7da0-4368-8855-5e58f3719487"),
                new Guid("b4f8c7e3-f49a-4d26-9b30-ebc934529707"))
                                       {
                                           AssociationType = { ObjectType = IGT32Composite },
                                           RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self33", AssignedPluralName = "Selfs33" }
                                       };

            IGT32UnitAllorsString14 = new RelationType(
                D,
                new Guid("ca170e8c-5aef-452e-8a3e-1228054d9a85"),
                new Guid("6f0882bc-5254-470b-8631-6fb4a6f249f6"),
                new Guid("4b0dc58a-330f-4711-ae3d-e2018a24cdbb"))
                                          {
                                              AssociationType = { ObjectType = IGT32Unit },
                                              RoleType =
                                                  {
                                                      ObjectType = AllorsString,
                                                      AssignedSingularName = "AllorsString14",
                                                      AssignedPluralName = "AllorsStrings14",
                                                      Size = 256
                                                  }
                                          };

            IGT32CompositeSelf27 = new RelationType(
                D,
                new Guid("cb03691e-8483-4af4-9fc0-83d9ab358e12"),
                new Guid("5898abd5-2f4b-421a-9652-c3707d1c3cf5"),
                new Guid("0c102d47-c32a-41d4-b553-d9a9839e36ad"))
                                       {
                                           AssociationType = { ObjectType = IGT32Composite },
                                           RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self27", AssignedPluralName = "Selfs27" }
                                       };

            I3C4one2one = new RelationType(
                D,
                new Guid("cc48853e-46f3-4292-be9b-8a4937cea308"),
                new Guid("08ef8f7c-a9eb-4f7f-be48-7b286d4efff3"),
                new Guid("5c9157ec-adf2-4575-9b83-daf923811fcd"))
                              {
                                  AssociationType = { ObjectType = I3 },
                                  RoleType = { ObjectType = C4, AssignedSingularName = "C4one2one", AssignedPluralName = "C4one2ones" }
                              };

            I34AllorsInteger = new RelationType(
                D,
                new Guid("cd30dada-24c5-4b94-8f58-ab1018f087ea"),
                new Guid("dca9ffc6-4620-4b5f-888d-35ea77ba1ad8"),
                new Guid("0649567c-2942-4d6e-9fa5-3672f8eb77a3")) { AssociationType = { ObjectType = I34 }, RoleType = { ObjectType = AllorsInteger } };

            IGT32UnitAllorsString13 = new RelationType(
                D,
                new Guid("cdb2dbc9-e481-4d7b-8746-e931c7c75da5"),
                new Guid("35e2f488-e508-47b0-9cf5-b95b688380c4"),
                new Guid("90449ce3-157a-46d0-be3e-298e00e5cc53"))
                                          {
                                              AssociationType = { ObjectType = IGT32Unit },
                                              RoleType =
                                                  {
                                                      ObjectType = AllorsString,
                                                      AssignedSingularName = "AllorsString13",
                                                      AssignedPluralName = "AllorsStrings13",
                                                      Size = 256
                                                  }
                                          };

            I1AllorsDouble = new RelationType(
                D,
                new Guid("cdb758bf-ecaf-4d99-88fb-58df9258c13c"),
                new Guid("08f1b9c8-6afa-49f1-a5f6-c9c23dc37c33"),
                new Guid("cde919c6-3192-4337-8b53-6cc03b364368")) { AssociationType = { ObjectType = I1 }, RoleType = { ObjectType = AllorsDouble } };

            CompanyChild = new RelationType(
                D,
                new Guid("cde0a8e7-1a14-4f1a-a0ca-a305f0548df8"),
                new Guid("ba38ffe5-7075-4792-acb7-c5a07594a166"),
                new Guid("7f9ab9a3-4296-4b3b-aa04-ab9e27d1f003"))
                               {
                                   AssociationType = { ObjectType = Company },
                                   RoleType =
                                       {
                                           ObjectType = Company,
                                           AssignedSingularName = "Child",
                                           AssignedPluralName = "Children",
                                           IsMany = true
                                       }
                               };

            CompanyNamedOneSort1 = new RelationType(
                D,
                new Guid("cdf04399-aa37-4ea2-9ac8-bf6d19884933"),
                new Guid("15a7a418-5cc5-44a6-90b1-034620c08763"),
                new Guid("6112c9a2-a775-45b5-879a-9fad898e21ba"))
                                       {
                                           AssociationType = { ObjectType = Company },
                                           RoleType =
                                               {
                                                   ObjectType = Named,
                                                   AssignedSingularName = "NamedOneSort1",
                                                   AssignedPluralName = "NamedsOneSort1",
                                                   IsMany = true
                                               }
                                       };

            C2AllorsDateTime = new RelationType(
                D,
                new Guid("ce23482d-3a22-4202-98e7-5934fd9abd2d"),
                new Guid("e83be403-6722-450f-81ba-bd58bf2f8941"),
                new Guid("0443f179-b2dd-49da-9e15-d0b348aa2dd9")) { AssociationType = { ObjectType = C2 }, RoleType = { ObjectType = AllorsDateTime } };

            NamedName = new RelationType(
                D,
                new Guid("ce43ca5e-4dfb-4fe1-98ea-17d8382e9531"),
                new Guid("c7070936-66b1-4f94-af88-40833b35ce37"),
                new Guid("76de9af1-b334-4e13-ae62-954e6a431ce3"))
                            {
                                AssociationType = { ObjectType = Named },
                                RoleType =
                                    {
                                        ObjectType = AllorsString,
                                        AssignedSingularName = "Name",
                                        AssignedPluralName = "Names",
                                        Size = 256
                                    }
                            };

            IGT32UnitAllorsString22 = new RelationType(
                D,
                new Guid("ce493f43-d598-43fd-970f-042debdc0d67"),
                new Guid("c97a773a-3fd5-42c4-8c0d-4093892ec73e"),
                new Guid("2439ef2b-f217-42b4-8b7e-ed4b6682cbbd"))
                                          {
                                              AssociationType = { ObjectType = IGT32Unit },
                                              RoleType =
                                                  {
                                                      ObjectType = AllorsString,
                                                      AssignedSingularName = "AllorsString22",
                                                      AssignedPluralName = "AllorsStrings22",
                                                      Size = 256
                                                  }
                                          };

            ILT32UnitAllorsString2 = new RelationType(
                D,
                new Guid("ced16c48-6301-4652-8dcb-ed8a80ea7ce4"),
                new Guid("1ce2f53e-fa39-4f01-b808-685e1ad8d23a"),
                new Guid("47c7b66c-e3c2-46f6-bcb7-ad73f3a1a1ce"))
                                         {
                                             AssociationType = { ObjectType = ILT32Unit },
                                             RoleType =
                                                 {
                                                     ObjectType = AllorsString,
                                                     AssignedSingularName = "AllorsString2",
                                                     AssignedPluralName = "AllorsStrings2",
                                                     Size = 256
                                                 }
                                         };

            C1AllorsUnique = new RelationType(
                D,
                new Guid("cef13620-b7d7-4bfe-8d3b-c0f826da5989"),
                new Guid("b282abf5-a18a-484f-9c51-094c5ab3273c"),
                new Guid("6ff183b3-1859-4489-b459-8bddc8f50c8c")) { AssociationType = { ObjectType = C1 }, RoleType = { ObjectType = AllorsUnique } };

            S12AllorsInteger = new RelationType(
                D,
                new Guid("d07313ca-fd8d-4c74-928e-41274aa28de9"),
                new Guid("d48b29d7-3b17-4cb5-b8f8-e85bc86876cd"),
                new Guid("a4163284-3b87-46c0-9495-acf5e3240513")) { AssociationType = { ObjectType = S12 }, RoleType = { ObjectType = AllorsInteger } };

            I2AllorsLong = new RelationType(
                D,
                new Guid("d0c49b92-a108-48b5-bc95-72d2e6109ad2"),
                new Guid("d018b41d-1075-4d96-8fde-80310343ef43"),
                new Guid("6d96ffff-b781-43eb-9152-57caf15f09aa")) { AssociationType = { ObjectType = I2 }, RoleType = { ObjectType = AllorsLong } };

            ILT32CompositeSelf1 = new RelationType(
                D,
                new Guid("d0eeeb45-97a6-465e-9a05-7e0fa970a969"),
                new Guid("31d93345-8969-448f-a5bb-c61df5f0ab34"),
                new Guid("92ef1bdf-3c23-4f5a-a835-6f46f2ce49be"))
                                      {
                                          AssociationType = { ObjectType = ILT32Composite, IsMany = true },
                                          RoleType = { ObjectType = ILT32Composite, AssignedSingularName = "Self1", AssignedPluralName = "Selfs1" }
                                      };

            C3C4one2many = new RelationType(
                D,
                new Guid("d1601926-ae62-4592-b15b-6511e0d98355"),
                new Guid("4a8dd1f7-a02f-49cb-a078-77ad93e3887d"),
                new Guid("91874a28-56b7-4d5d-8fc9-33a59cabab95"))
                               {
                                   AssociationType = { ObjectType = C3 },
                                   RoleType =
                                       {
                                           ObjectType = C4,
                                           AssignedSingularName = "C4one2many",
                                           AssignedPluralName = "C4one2manies",
                                           IsMany = true
                                       }
                               };

            I1S1one2many = new RelationType(
                D,
                new Guid("d24b5b74-6ea2-4788-857c-90e0ba1433a5"),
                new Guid("61cb8d4d-4e16-4941-b1f4-baf345306959"),
                new Guid("551bf180-4c14-44ed-ad0c-4b17501ea50e"))
                               {
                                   AssociationType = { ObjectType = I1 },
                                   RoleType =
                                       {
                                           ObjectType = S1,
                                           AssignedSingularName = "S1one2many",
                                           AssignedPluralName = "S1one2manies",
                                           IsMany = true
                                       }
                               };

            IGT32CompositeSelf30 = new RelationType(
                D,
                new Guid("d2b6c061-927e-4db5-b419-ec7375d8845a"),
                new Guid("6deb5957-c2f5-48b2-ac7e-a64ba793f610"),
                new Guid("09673dc2-dd7b-4ba6-a8bc-4c235879dc63"))
                                       {
                                           AssociationType = { ObjectType = IGT32Composite },
                                           RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self30", AssignedPluralName = "Selfs30" }
                                       };

            I2AllorsInteger = new RelationType(
                D,
                new Guid("d30dd036-6d28-48df-873b-3a76da8c029e"),
                new Guid("ee50ff17-39d8-44f7-8d14-e63f4c822ed4"),
                new Guid("25cb17ec-01e2-4658-a06b-2a620f152923")) { AssociationType = { ObjectType = I2 }, RoleType = { ObjectType = AllorsInteger } };

            I3I4one2one = new RelationType(
                D,
                new Guid("d36e7cf1-08d1-4333-b539-e50503c10934"),
                new Guid("44136f72-586f-47c0-a84b-1505ff2723e2"),
                new Guid("f10c8012-b731-470b-af7a-28654e2d572e"))
                              {
                                  AssociationType = { ObjectType = I3 },
                                  RoleType = { ObjectType = I4, AssignedSingularName = "I4one2one", AssignedPluralName = "I4one2one" }
                              };

            C1C3one2one = new RelationType(
                D,
                new Guid("d3f73a6d-8f95-44c6-bbc8-ddc468b803f7"),
                new Guid("70e33bc7-18da-4a9d-ab35-17f5f58bb86c"),
                new Guid("65f82cbe-390c-4f01-bead-04ce52e404d3"))
                              {
                                  AssociationType = { ObjectType = C1 },
                                  RoleType = { ObjectType = C3, AssignedSingularName = "C3one2one", AssignedPluralName = "C3one2ones" }
                              };

            I3C4many2one = new RelationType(
                D,
                new Guid("d5ff5333-6bbc-4bb5-8208-44e1d4b53aee"),
                new Guid("683c30c4-22d4-4837-8e6f-f503351938ab"),
                new Guid("5d06be1b-e9a8-4793-afa0-63633d0552ed"))
                               {
                                   AssociationType = { ObjectType = I3, IsMany = true },
                                   RoleType = { ObjectType = C4, AssignedSingularName = "C4many2one", AssignedPluralName = "C4many2ones" }
                               };

            I34AllorsString = new RelationType(
                D,
                new Guid("d8125c69-1921-4e16-84bc-d3d174be7b83"),
                new Guid("0d74fad0-c0a0-4f3d-b6fc-706c6343f253"),
                new Guid("ad8c99c8-7628-4f82-8188-287b2dbfbf42")) { AssociationType = { ObjectType = I34 }, RoleType = { ObjectType = AllorsString, Size = 256 } };

            C3C2one2one = new RelationType(
                D,
                new Guid("d81da318-f954-42b4-b605-e011a92726ba"),
                new Guid("afd34195-4149-4070-9fb3-5e6509b5e503"),
                new Guid("5e68d25d-e630-4807-aab6-8bb015009cbe"))
                              {
                                  AssociationType = { ObjectType = C3 },
                                  RoleType = { ObjectType = C2, AssignedSingularName = "C2one2one", AssignedPluralName = "C2one2ones" }
                              };

            C2C1one2many = new RelationType(
                D,
                new Guid("d82be8f5-673a-466b-8abb-077be0bc6eb5"),
                new Guid("de720379-fc76-44b6-887c-00fe7916e4e5"),
                new Guid("2e985306-893b-4686-bb39-775e1a0f87a7"))
                               {
                                   AssociationType = { ObjectType = C2 },
                                   RoleType =
                                       {
                                           ObjectType = C1,
                                           AssignedSingularName = "C1one2many",
                                           AssignedPluralName = "C1one2manies",
                                           IsMany = true
                                       }
                               };

            C2C3Many2Many = new RelationType(
                D,
                new Guid("d92643c0-854c-40f8-92c8-93a0245e33c2"),
                new Guid("3df80a07-eb84-46e0-8c0f-53e64cf29d2c"),
                new Guid("6d2f1196-5a1a-439c-b743-fed5540ac49c"))
                                {
                                    IsIndexed = true,
                                    AssociationType = { ObjectType = C2, IsMany = true },
                                    RoleType =
                                        {
                                            ObjectType = C3,
                                            AssignedSingularName = "C3Many2Many",
                                            AssignedPluralName = "C3Many2Manies",
                                            IsMany = true
                                        }
                                };

            C3C4one2one = new RelationType(
                D,
                new Guid("da44bf79-b72e-4565-bd33-0eb278a6f4ec"),
                new Guid("f13c448a-e101-4da0-b79b-5e0efc6462b9"),
                new Guid("d833c0b7-bd97-44bc-a8f2-07d509d82a09"))
                              {
                                  AssociationType = { ObjectType = C3 },
                                  RoleType = { ObjectType = C4, AssignedSingularName = "C4one2one", AssignedPluralName = "C4one2ones" }
                              };

            C1C3many2many = new RelationType(
                D,
                new Guid("da4d6a24-6b0f-4841-b355-80ee1ba10c59"),
                new Guid("1c8f32c3-c0a3-41c0-998a-7b933c8985c2"),
                new Guid("fff5e5d3-82da-4bf6-86c0-9c2cc048b6f6"))
                                {
                                    AssociationType = { ObjectType = C1, IsMany = true },
                                    RoleType =
                                        {
                                            ObjectType = C3,
                                            AssignedSingularName = "C3many2many",
                                            AssignedPluralName = "C3many2manies",
                                            IsMany = true
                                        }
                                };

            IGT32UnitAllorsString3 = new RelationType(
                D,
                new Guid("db9ce637-26ba-4551-abc2-4199d91e7db5"),
                new Guid("f154eda3-3209-42cb-adc4-8fcc5995e343"),
                new Guid("1aeaf081-02f0-4a0e-a8d0-584d06497015"))
                                         {
                                             AssociationType = { ObjectType = IGT32Unit },
                                             RoleType =
                                                 {
                                                     ObjectType = AllorsString,
                                                     AssignedSingularName = "AllorsString3",
                                                     AssignedPluralName = "AllorsStrings3",
                                                     Size = 256
                                                 }
                                         };

            ISandboxInvisibleOne = new RelationType(
                D,
                new Guid("dba5deb2-880d-47f4-adae-0b3125ff1379"),
                new Guid("8ad9a7aa-095e-43d9-aa4e-f21f7c70fdbb"),
                new Guid("3e8d7881-8112-4001-a518-3fcef1a24615"))
                                       {
                                           AssociationType = { ObjectType = ISandbox },
                                           RoleType =
                                               {
                                                   ObjectType = ISandbox,
                                                   AssignedSingularName = "InvisibleOne",
                                                   AssignedPluralName = "InvisibleOnes"
                                               }
                                       };

            S1S2one2one = new RelationType(
                D,
                new Guid("dc22175f-185d-4cd3-b492-74b0a9389c91"),
                new Guid("d6e64cd0-1f37-4e70-acba-fbe0faee8f07"),
                new Guid("1505b48d-b4ce-406c-a5cb-69151b3d391e"))
                              {
                                  AssociationType = { ObjectType = S1 },
                                  RoleType = { ObjectType = S2, AssignedSingularName = "S2one2one", AssignedPluralName = "S2one2ones" }
                              };

            C1StringEquals = new RelationType(
                D,
                new Guid("dc55a574-5546-4a68-b886-706c39bc4e80"),
                new Guid("8c8974cb-bd1c-4508-84b5-24f1b2320ed0"),
                new Guid("e6426399-ae58-4565-94c9-bf610f39ff01"))
                                 {
                                     AssociationType = { ObjectType = C1 },
                                     RoleType =
                                         {
                                             ObjectType = AllorsString,
                                             AssignedSingularName = "StringEquals",
                                             AssignedPluralName = "StringsEquals",
                                             Size = 256
                                         }
                                 };

            C3StringEquals = new RelationType(
                D,
                new Guid("dd006700-a00c-4c67-819e-1d63df26a5b6"),
                new Guid("5d1441a6-f665-470d-8f7f-03d794e0ee06"),
                new Guid("3ad6a27f-4604-402a-a504-8ef3a3e7ccee"))
                                 {
                                     AssociationType = { ObjectType = C3 },
                                     RoleType =
                                         {
                                             ObjectType = AllorsString,
                                             AssignedSingularName = "StringEquals",
                                             AssignedPluralName = "StringsEquals",
                                             Size = 256
                                         }
                                 };

            I1I1one2one = new RelationType(
                D,
                new Guid("ddbfe021-3310-4d8e-a4ef-438306aaf191"),
                new Guid("f2901823-6eac-46d9-8590-b755bfa166e7"),
                new Guid("a7a81a4d-efca-4601-820e-7f1cd6584ad8"))
                              {
                                  AssociationType = { ObjectType = I1 },
                                  RoleType = { ObjectType = I1, AssignedSingularName = "I1one2one", AssignedPluralName = "I1one2ones" }
                              };

            S1AllorsLong = new RelationType(
                D,
                new Guid("de02a563-2c77-4936-ab07-d322b8dcaec9"),
                new Guid("3b93aafc-3b3b-434d-860c-3bcac6002d39"),
                new Guid("d2cfa173-6724-4b78-81e7-8dca0857819f")) { AssociationType = { ObjectType = S1 }, RoleType = { ObjectType = AllorsLong } };

            S1234C2many2one = new RelationType(
                D,
                new Guid("df9eb36a-366f-4a5a-a750-f2f23f681c74"),
                new Guid("479c2fd7-dda6-4efa-b031-e0584926f66a"),
                new Guid("4e227376-5396-4838-bc23-f6bf4f530b75"))
                                  {
                                      AssociationType = { ObjectType = S1234, IsMany = true },
                                      RoleType = { ObjectType = C2, AssignedSingularName = "C2many2one", AssignedPluralName = "C2many2ones" }
                                  };

            I3StringEquals = new RelationType(
                D,
                new Guid("e0cf6092-d865-4386-823b-a2906a3eab1a"),
                new Guid("4a1758c9-4cbe-4509-b0dd-da644ad61f15"),
                new Guid("7f3eee6c-dbd7-4287-9ba7-d0f3289ad0c6"))
                                 {
                                     AssociationType = { ObjectType = I3 },
                                     RoleType =
                                         {
                                             ObjectType = AllorsString,
                                             AssignedSingularName = "StringEquals",
                                             AssignedPluralName = "StringsEquals",
                                             Size = 256
                                         }
                                 };

            C1LongBetweenA = new RelationType(
                D,
                new Guid("e109ccb9-6469-4dd4-9b04-2a6fb5d6d6a8"),
                new Guid("51fa728f-6472-4d0a-9457-e088e3aef311"),
                new Guid("fa52ab03-1ab8-46f7-8bbe-16c64984cab6"))
                                 {
                                     AssociationType = { ObjectType = C1 },
                                     RoleType =
                                         {
                                             ObjectType = AllorsLong,
                                             AssignedSingularName = "LongBetweenA",
                                             AssignedPluralName = "LongsBetweenA"
                                         }
                                 };

            C1IntegerGreaterThan = new RelationType(
                D,
                new Guid("e2153298-73b0-4f5f-bba0-00c832b044b3"),
                new Guid("45d13e0f-e377-4579-9fcd-159de81707b3"),
                new Guid("1e0a3de9-1d97-4174-857a-ce2dc447a5c8"))
                                       {
                                           AssociationType = { ObjectType = C1 },
                                           RoleType =
                                               {
                                                   ObjectType = AllorsInteger,
                                                   AssignedSingularName = "IntegerGreaterThan",
                                                   AssignedPluralName = "IntegersGreaterThan"
                                               }
                                       };

            I12AllorsString = new RelationType(
                D,
                new Guid("e227ff6c-a4df-49cf-a02f-04e94af6eb4b"),
                new Guid("39578e21-cafc-4862-a5ad-3298f2472b3b"),
                new Guid("692c22ff-7c88-463b-9399-966ea41228a6")) { AssociationType = { ObjectType = I12 }, RoleType = { ObjectType = AllorsString, Size = 256 } };

            S1AllorsDateTime = new RelationType(
                D,
                new Guid("e263ac2b-822d-4aa4-8a8c-67db3f2b4bb0"),
                new Guid("dfb5ca2c-a44f-49a4-b967-c7eeab9d66fa"),
                new Guid("919db239-03a7-488f-81fd-4930a41fa42b")) { AssociationType = { ObjectType = S1 }, RoleType = { ObjectType = AllorsDateTime } };

            IGT32UnitAllorsString7 = new RelationType(
                D,
                new Guid("e27c59c0-a8ed-46c2-8fd6-707bb45b8af5"),
                new Guid("d6aafd82-a596-4527-8a58-4ff5d6290745"),
                new Guid("3c27d5c4-7338-4041-bdec-79837e25a4b5"))
                                         {
                                             AssociationType = { ObjectType = IGT32Unit },
                                             RoleType =
                                                 {
                                                     ObjectType = AllorsString,
                                                     AssignedSingularName = "AllorsString7",
                                                     AssignedPluralName = "AllorsStrings7",
                                                     Size = 256
                                                 }
                                         };

            C1C3may2one = new RelationType(
                D,
                new Guid("e3af3413-4631-4052-ac57-955651a319fc"),
                new Guid("d56f0a2e-0e55-4d9a-a5ff-e67186c3ff0a"),
                new Guid("f3d25497-5895-4a84-a10c-6537b232890d"))
                              {
                                  AssociationType = { ObjectType = C1, IsMany = true },
                                  RoleType = { ObjectType = C3, AssignedSingularName = "C3may2one", AssignedPluralName = "C3may2ones" }
                              };

            C1IntegerBetweenB = new RelationType(
                D,
                new Guid("e3dedb1d-6738-46f7-8a25-77213c90a8f9"),
                new Guid("5641c330-6cdb-4c2d-82cf-59520bc4a14f"),
                new Guid("233d4e00-4f1c-4b55-aef5-b13dd4f9861c"))
                                    {
                                        AssociationType = { ObjectType = C1 },
                                        RoleType =
                                            {
                                                ObjectType = AllorsInteger,
                                                AssignedSingularName = "IntegerBetweenB",
                                                AssignedPluralName = "IntegersBetweenB"
                                            }
                                    };

            IGT32CompositeSelf1 = new RelationType(
                D,
                new Guid("e50d68f0-ab9d-4a0e-8976-324037145aec"),
                new Guid("50828493-766d-4b18-89f1-66dc9485aa72"),
                new Guid("bae406f5-6dd2-490e-a534-06ab6deec2dc"))
                                      {
                                          AssociationType = { ObjectType = IGT32Composite },
                                          RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self1", AssignedPluralName = "Selfs1" }
                                      };

            IGT32UnitAllorsString9 = new RelationType(
                D,
                new Guid("e518ffe9-7a15-469d-9062-fb0f3e25fde3"),
                new Guid("b9a45793-e523-404d-9865-b7a76b7a5241"),
                new Guid("81f7839a-10a6-4aaa-9bc4-01275f45e090"))
                                         {
                                             AssociationType = { ObjectType = IGT32Unit },
                                             RoleType =
                                                 {
                                                     ObjectType = AllorsString,
                                                     AssignedSingularName = "AllorsString9",
                                                     AssignedPluralName = "AllorsStrings9",
                                                     Size = 256
                                                 }
                                         };

            S1234AllorsString = new RelationType(
                D,
                new Guid("e6164217-2f54-4134-8c53-4a45caa9dd11"),
                new Guid("f14300c4-bacf-4541-914e-ec5781ada1d9"),
                new Guid("986c626f-1bcb-480c-9e2d-0da297340fc9")) { AssociationType = { ObjectType = S1234 }, RoleType = { ObjectType = AllorsString, Size = 256 } };

            I1IntegerGreaterThan = new RelationType(
                D,
                new Guid("e8f1c37a-6bae-4ff5-b385-39bff287bf78"),
                new Guid("0c088e73-c60f-404d-8410-fc1b4aab3a30"),
                new Guid("9543f2dd-2475-4544-8d6c-eaf06e5bbb18"))
                                       {
                                           AssociationType = { ObjectType = I1 },
                                           RoleType =
                                               {
                                                   ObjectType = AllorsInteger,
                                                   AssignedSingularName = "IntegerGreaterThan",
                                                   AssignedPluralName = "IntegersGreaterThan"
                                               }
                                       };

            IGT32CompositeSelf15 = new RelationType(
                D,
                new Guid("ec22d147-fed5-40a7-9c85-4fccc0717127"),
                new Guid("772c151f-5c11-4356-ba40-ed80a8128c0c"),
                new Guid("fb7bcd45-d1df-4b33-8c3c-c7279a407b0c"))
                                       {
                                           AssociationType = { ObjectType = IGT32Composite },
                                           RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self15", AssignedPluralName = "Selfs15" }
                                       };

            C3I4one2many = new RelationType(
                D,
                new Guid("ed3267fb-fbc4-4e38-87f5-8e2ee91b1bac"),
                new Guid("9411ef61-3a6d-41bd-a9db-3d0f81db6382"),
                new Guid("8fdf96a7-73e7-418d-90c2-a6d72a1629a9"))
                               {
                                   AssociationType = { ObjectType = C3 },
                                   RoleType =
                                       {
                                           ObjectType = I4,
                                           AssignedSingularName = "I4one2many",
                                           AssignedPluralName = "I4one2manies",
                                           IsMany = true
                                       }
                               };

            I1S1many2one = new RelationType(
                D,
                new Guid("ee44a1bb-a5c7-4b05-a06b-8ff9ca9d4f98"),
                new Guid("7243691d-2788-480e-aa53-b77d03efed9b"),
                new Guid("104f0133-ef22-40e9-8db6-2671ad276d09"))
                               {
                                   AssociationType = { ObjectType = I1, IsMany = true },
                                   RoleType = { ObjectType = S1, AssignedSingularName = "S1many2one", AssignedPluralName = "S1many2one" }
                               };

            I1DoubleBetweenB = new RelationType(
                D,
                new Guid("eec19d8e-727c-437a-95db-b301cd1cd65a"),
                new Guid("75c77005-2e6c-464d-8e0c-530a6a9a43b5"),
                new Guid("2699f05a-4f69-4781-908a-57d43112bbf4"))
                                   {
                                       AssociationType = { ObjectType = I1 },
                                       RoleType =
                                           {
                                               ObjectType = AllorsDouble,
                                               AssignedSingularName = "DoubleBetweenB",
                                               AssignedPluralName = "DoublesBetweenB"
                                           }
                                   };

            S1234AllorsBoolean = new RelationType(
                D,
                new Guid("ef45cd72-2e16-47df-b949-c803a554b307"),
                new Guid("f5db9b49-cc7c-42d2-b818-8f9d0a16e2ae"),
                new Guid("ace6cdc5-e66f-40dd-bd37-45db231cc9e8")) { AssociationType = { ObjectType = S1234 }, RoleType = { ObjectType = AllorsBoolean } };

            C1AllorsDateTime = new RelationType(
                D,
                new Guid("ef75cc4e-8787-4f1c-ae5c-73577d721467"),
                new Guid("b61679b1-3118-4353-969a-8e0406d6b7db"),
                new Guid("d6e19a7c-23a8-4450-a0b7-c882111fb087")) { AssociationType = { ObjectType = C1 }, RoleType = { ObjectType = AllorsDateTime } };

            C1IntegerBetweenA = new RelationType(
                D,
                new Guid("ef909fec-7a03-4a3c-a3f4-6097a51ff1f0"),
                new Guid("ecf38e01-7977-459a-9beb-e5c1a32d4d6d"),
                new Guid("08030ead-35df-460c-be3e-a707d8e89ffb"))
                                    {
                                        AssociationType = { ObjectType = C1 },
                                        RoleType =
                                            {
                                                ObjectType = AllorsInteger,
                                                AssignedSingularName = "IntegerBetweenA",
                                                AssignedPluralName = "IntegersBetweenA"
                                            }
                                    };

            S1C1one2many = new RelationType(
                D,
                new Guid("ef918b82-87f4-4591-bf19-2fd5a1019ece"),
                new Guid("37261db2-118c-4c9a-a184-4956fe1e4c29"),
                new Guid("eed5fe88-d325-4567-b9db-95d139741920"))
                               {
                                   AssociationType = { ObjectType = S1 },
                                   RoleType =
                                       {
                                           ObjectType = C1,
                                           AssignedSingularName = "C1one2many",
                                           AssignedPluralName = "C1one2manies",
                                           IsMany = true
                                       }
                               };

            IGT32CompositeSelf5 = new RelationType(
                D,
                new Guid("f16b7de2-aed2-49c9-b1dc-618e919136a6"),
                new Guid("6b30db7a-a6c1-472c-ae0f-075d35a85026"),
                new Guid("4ee83cb4-b98f-421e-85db-d248f61d4d82"))
                                      {
                                          AssociationType = { ObjectType = IGT32Composite },
                                          RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self5", AssignedPluralName = "Selfs5" }
                                      };

            I1DecimalLessThan = new RelationType(
                D,
                new Guid("f1a1ef6a-8275-4b57-8cd0-8e79ee5a517d"),
                new Guid("987e84d3-9e09-46a4-83de-645cb58581b7"),
                new Guid("c80e5776-84d5-4854-bb0a-fd6c6977c1fd"))
                                    {
                                        AssociationType = { ObjectType = I1 },
                                        RoleType =
                                            {
                                                ObjectType = AllorsDecimal,
                                                AssignedSingularName = "DecimalLessThan",
                                                AssignedPluralName = "DecimalsLessThan",
                                                Scale = 2,
                                                Precision = 19
                                            }
                                    };

            C1AllorsDouble = new RelationType(
                D,
                new Guid("f268783d-42ed-41c1-b0b0-b8a60e30a601"),
                new Guid("3ef93ecb-bc60-4320-b735-4a5bf524a8e9"),
                new Guid("3492623a-7fe3-48ec-a95e-2690ced58f88")) { AssociationType = { ObjectType = C1 }, RoleType = { ObjectType = AllorsDouble } };

            C1LongBetweenB = new RelationType(
                D,
                new Guid("f31a140e-6e95-4c7b-bdd7-d58137061b85"),
                new Guid("ba4379ce-8cc8-4c5c-836c-5e2c85370831"),
                new Guid("a9a0e35d-2399-49e6-b7c9-b06c7fe77ee8"))
                                 {
                                     AssociationType = { ObjectType = C1 },
                                     RoleType =
                                         {
                                             ObjectType = AllorsLong,
                                             AssignedSingularName = "LongBetweenB",
                                             AssignedPluralName = "LongsBetweenB"
                                         }
                                 };

            I12I34one2one = new RelationType(
                D,
                new Guid("f31ace17-76b1-46db-9fc0-099b94fbada5"),
                new Guid("a44d261b-bda9-445f-b811-420bc411de51"),
                new Guid("e7c49ccf-53d1-468c-9f2a-fe31cd1d2a98"))
                                {
                                    AssociationType = { ObjectType = I12 },
                                    RoleType = { ObjectType = I34, AssignedSingularName = "I34one2one", AssignedPluralName = "I34one2ones" }
                                };

            C2C3Many2One = new RelationType(
                D,
                new Guid("f3482f88-4408-4e2e-b179-7f757bf0eb3d"),
                new Guid("9602ea68-e7f4-4c89-bad6-875813a4d59a"),
                new Guid("e1087401-fa0a-49ee-8242-0836c2476d06"))
                               {
                                   IsIndexed = true,
                                   AssociationType = { ObjectType = C2, IsMany = true },
                                   RoleType = { ObjectType = C3, AssignedSingularName = "C3Many2One", AssignedPluralName = "C3Many2Ones" }
                               };

            I12C2one2many = new RelationType(
                D,
                new Guid("f37b107e-74e5-401f-a7e8-8ac54ceb6c73"),
                new Guid("fca41bdf-2372-4115-aa46-b91b98b728b9"),
                new Guid("230b5ca6-7f6d-4153-b55a-b2d1a9d2b7da"))
                                {
                                    AssociationType = { ObjectType = I12 },
                                    RoleType =
                                        {
                                            ObjectType = C2,
                                            AssignedSingularName = "C2one2many",
                                            AssignedPluralName = "C2one2manies",
                                            IsMany = true
                                        }
                                };

            C1C2one2many = new RelationType(
                D,
                new Guid("f39739d2-e8fc-406e-be6a-c92acee07686"),
                new Guid("19596842-fb74-4af2-9be0-3da44d4a8e2c"),
                new Guid("fbf79604-b7c9-41c1-8f70-846b41f0cace"))
                               {
                                   AssociationType = { ObjectType = C1 },
                                   RoleType =
                                       {
                                           ObjectType = C2,
                                           AssignedSingularName = "C2one2many",
                                           AssignedPluralName = "C2one2manies",
                                           IsMany = true
                                       }
                               };

            C1S2one2many = new RelationType(
                D,
                new Guid("f47b9392-1391-416e-9a49-23ab0627133e"),
                new Guid("96459a63-0d8f-4cc5-a3f0-5b3268756c5c"),
                new Guid("b25a2c55-e620-48b4-8d29-dc3f94b493ec"))
                               {
                                   AssociationType = { ObjectType = C1 },
                                   RoleType =
                                       {
                                           ObjectType = S2,
                                           AssignedSingularName = "S2one2many",
                                           AssignedPluralName = "S2one2manies",
                                           IsMany = true
                                       }
                               };

            C1AllorsInteger = new RelationType(
                D,
                new Guid("f4920d94-8cd0-45b6-be00-f18d377368fd"),
                new Guid("0466f49d-b882-4a87-9f77-2f3b392a1d29"),
                new Guid("b6c919ad-97c9-4d08-a3ba-179d3c8a313c")) { IsIndexed = true, AssociationType = { ObjectType = C1 }, RoleType = { ObjectType = AllorsInteger } };

            I1DateTimeBetweenB = new RelationType(
                D,
                new Guid("f5a6b7d9-9f49-44a8-b303-1a2969195bd1"),
                new Guid("50959998-2354-4882-9a43-faccfdfc36af"),
                new Guid("beab6646-0eff-42fe-8d43-f5e788473b8b"))
                                     {
                                         AssociationType = { ObjectType = I1 },
                                         RoleType =
                                             {
                                                 ObjectType = AllorsDateTime,
                                                 AssignedSingularName = "DateTimeBetweenB",
                                                 AssignedPluralName = "DateTimesBetweenB"
                                             }
                                     };

            S12AllorsDecimal = new RelationType(
                D,
                new Guid("f7ace363-89bd-4ea5-a865-4a6e3de2d723"),
                new Guid("c67514c2-5b6f-4eb5-b730-eb74642ff6e7"),
                new Guid("68937f6c-9561-49e8-abb3-24e0eeabfcb1")) { AssociationType = { ObjectType = S12 }, RoleType = { ObjectType = AllorsDecimal, Scale = 2, Precision = 19 } };

            I1AllorsUnique = new RelationType(
                D,
                new Guid("f9d7411e-7993-4e43-a7e2-726f1e44e29c"),
                new Guid("15ba7641-40ed-47d3-ab5a-e3c1961932c3"),
                new Guid("9570a106-ceab-41d1-bcb5-b073e2ad82cf")) { AssociationType = { ObjectType = I1 }, RoleType = { ObjectType = AllorsUnique } };

            I3C1one2one = new RelationType(
                D,
                new Guid("fb90c539-a392-4618-bb0b-9809a3a673aa"),
                new Guid("cc3a7bd2-b6c0-4693-a68d-87b6627128d7"),
                new Guid("10b62caf-0cc3-40cb-a81a-e8aedd50a8e4"))
                              {
                                  AssociationType = { ObjectType = I3 },
                                  RoleType = { ObjectType = C1, AssignedSingularName = "C1one2one", AssignedPluralName = "C1one2ones" }
                              };

            I2AllorsDouble = new RelationType(
                D,
                new Guid("fbad33e7-ede1-41fc-97e9-ddf33a0f6459"),
                new Guid("a9f79b82-bb7c-4cdc-ac16-333a1b994387"),
                new Guid("81acc49f-16c9-4677-80f4-c3e768a7b9e3")) { AssociationType = { ObjectType = I2 }, RoleType = { ObjectType = AllorsDouble } };

            I1C1one2many = new RelationType(
                D,
                new Guid("fbc1fd9f-853a-4b7d-b618-447b765b3bcb"),
                new Guid("2cc6f888-93b0-42ac-b027-c2289ae8d19b"),
                new Guid("49a2ce37-3e19-4b1a-9825-32db34f6a9df"))
                               {
                                   AssociationType = { ObjectType = I1 },
                                   RoleType =
                                       {
                                           ObjectType = C1,
                                           AssignedSingularName = "C1one2many",
                                           AssignedPluralName = "C1one2manies",
                                           IsMany = true
                                       }
                               };

            C1DecimalLessThan = new RelationType(
                D,
                new Guid("fc56ca04-9737-4b51-939e-4854e5507953"),
                new Guid("de7f8997-c48e-48b9-9ea2-43fb6597a67b"),
                new Guid("27f4e9f4-07e2-462d-917c-66fe659b789a"))
                                    {
                                        AssociationType = { ObjectType = C1 },
                                        RoleType =
                                            {
                                                ObjectType = AllorsDecimal,
                                                AssignedSingularName = "DecimalLessThan",
                                                AssignedPluralName = "DecimalsLessThan",
                                                Scale = 2,
                                                Precision = 19
                                            }
                                    };

            NamedIndex = new RelationType(
                D,
                new Guid("fdad723a-f062-492a-989c-8d8727c52679"),
                new Guid("52a479f2-724b-4e02-9b36-c8c668cb22e6"),
                new Guid("5a4f9946-44fc-4770-88a4-6141bb1b249e"))
                             {
                                 AssociationType = { ObjectType = Named },
                                 RoleType = { ObjectType = AllorsInteger, AssignedSingularName = "Index", AssignedPluralName = "Indeces" }
                             };

            IGT32CompositeSelf19 = new RelationType(
                D,
                new Guid("fdcad358-8532-471a-a47e-1ad45a34a962"),
                new Guid("32b05582-163e-4174-8fa0-47eadcf6531d"),
                new Guid("9af14cfc-120c-4b5c-86a8-45d6d7f1077c"))
                                       {
                                           AssociationType = { ObjectType = IGT32Composite },
                                           RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self19", AssignedPluralName = "Selfs19" }
                                       };

            I1S2many2one = new RelationType(
                D,
                new Guid("fe51c02e-ed28-4628-9da1-7bc2131c8992"),
                new Guid("cc148e75-8f68-4e0c-9db4-4cb54616b74f"),
                new Guid("1767a4b7-365c-4fa4-8f5d-ff4d612dae5b"))
                               {
                                   AssociationType = { ObjectType = I1, IsMany = true },
                                   RoleType = { ObjectType = S2, AssignedSingularName = "S2many2one", AssignedPluralName = "S2many2ones" }
                               };

            C1C3one2many = new RelationType(
                D,
                new Guid("fee2d1a8-bb65-4bfe-b25f-407c629dec18"),
                new Guid("61b277c2-6e17-4b2f-b642-cf0a711f3edd"),
                new Guid("1cf5bfab-6bf7-4e04-bedd-0ac72ae6b30b"))
                               {
                                   AssociationType = { ObjectType = C1 },
                                   RoleType =
                                       {
                                           ObjectType = C3,
                                           AssignedSingularName = "C3one2many",
                                           AssignedPluralName = "C3one2manies",
                                           IsMany = true
                                       }
                               };

            IGT32CompositeSelf10 = new RelationType(
                D,
                new Guid("fee41b72-ace5-4cc4-bde5-e1df40b388e4"),
                new Guid("935a6b0c-242c-440a-8dbb-f7fb0e7cc04b"),
                new Guid("362fb00b-beed-4059-a6df-72268c9d87f8"))
                                       {
                                           AssociationType = { ObjectType = IGT32Composite },
                                           RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self10", AssignedPluralName = "Selfs10" }
                                       };

            IGT32CompositeSelf16 = new RelationType(
                D,
                new Guid("ffbe4164-497e-4b02-acc7-fefec48dc36e"),
                new Guid("f72f4ee0-665c-4276-aaee-52f861d022ce"),
                new Guid("e5f08273-047d-45f1-a6f9-ed3286df87b0"))
                                       {
                                           AssociationType = { ObjectType = IGT32Composite },
                                           RoleType = { ObjectType = IGT32Composite, AssignedSingularName = "Self16", AssignedPluralName = "Selfs16" }
                                       };


            var validationLog = D.Validate();
            if (validationLog.ContainsErrors)
            {
                throw new Exception(validationLog.ToString());
            }

            D.Derive();
        }
    }
}