//------------------------------------------------------------------------------------------------- 
// <copyright file="PermissionTests.cs" company="Allors bvba">
// Copyright 2002-2013 Allors bvba.
// 
// Dual Licensed under
//   a) the General Public Licence v3 (GPL)
//   b) the Allors License
// 
// The GPL License is included in the file gpl.txt.
// The Allors License is an addendum to your contract.
// 
// Allors Applications is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// For more information visit http://www.allors.com/legal
// </copyright>
// <summary>Defines the PermissionTests type.</summary>
//-------------------------------------------------------------------------------------------------

namespace Allors.Security
{
    using System;

    using Allors.Domain;
    using Allors.Meta;

    using NUnit.Framework;

    [TestFixture]
    public class PermissionTests : DomainTest
    {
        //[Test]
        //public void SyncMethod()
        //{
        //    var domain = (Domain)this.DatabaseSession.Population.MetaPopulation.Find(new Guid("AB41FD0C-C887-4A1D-BEDA-CED69527E69A"));
         
        //    var methodType = new MethodTypeBuilder(domain, Guid.NewGuid()).Build();
        //    methodType.ObjectType = Organisations.Meta.ObjectType;
        //    methodType.Name = "Method";

        //    var count = new Permissions(this.DatabaseSession).Extent().Count;

        //    new Permissions(this.DatabaseSession).Sync();

        //    Assert.AreEqual(count + 1, new Permissions(this.DatabaseSession).Extent().Count);

        //    var methodPermission = new Permissions(this.DatabaseSession).FindBy(Permissions.Meta.OperandTypePointer, methodType.Id);
        //    Assert.IsNotNull(methodPermission);
        //    Assert.AreEqual(Operation.Execute, methodPermission.Operation);
        //}

        //[Test]
        //public void SyncRelation()
        //{
        //    var domain = (Domain)this.DatabaseSession.Population.MetaPopulation.Find(new Guid("AB41FD0C-C887-4A1D-BEDA-CED69527E69A"));
            
        //    var count = new Permissions(this.DatabaseSession).Extent().Count;

        //    var relationType = new RelationTypeBuilder(domain, Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid()).Build();

        //    relationType.AssociationType.ObjectType = Organisations.Meta.ObjectType;
        //    relationType.RoleType.ObjectType = Persons.Meta.ObjectType;
        //    relationType.RoleType.AssignedSingularName = "Relation";
        //    relationType.RoleType.AssignedPluralName = "Relations";
                
        //    new Permissions(this.DatabaseSession).Sync();

        //    this.DatabaseSession.Derive(true);

        //    Assert.AreEqual(count + 3, new Permissions(this.DatabaseSession).Extent().Count);

        //    var roleTypePermissions = new Permissions(this.DatabaseSession).Extent();
        //    roleTypePermissions.Filter.AddEquals(Permissions.Meta.OperandTypePointer, relationType.RoleType.Id);
        //    Assert.AreEqual(2, roleTypePermissions.Count);

        //    var associationTypePermissions = new Permissions(this.DatabaseSession).Extent();
        //    associationTypePermissions.Filter.AddEquals(Permissions.Meta.OperandTypePointer, relationType.AssociationType.Id);
        //    Assert.AreEqual(1, associationTypePermissions.Count);
        //}

        [Test]
        public void WhenSyncingPermissionsThenObsolotePermissionsAreDeleted()
        {
            var domain = (Domain)this.DatabaseSession.Population.MetaPopulation.Find(new Guid("AB41FD0C-C887-4A1D-BEDA-CED69527E69A"));

            var count = new Permissions(this.DatabaseSession).Extent().Count;

            var permission = new PermissionBuilder(this.DatabaseSession).WithConcreteClassPointer(new Guid()).WithOperation(Operation.Execute).WithOperandTypePointer(new Guid()).Build();

            new Permissions(this.DatabaseSession).Sync();

            Assert.AreEqual(count, new Permissions(this.DatabaseSession).Extent().Count);
        }

        [Test]
        public void WhenSyncingPermissionsThenDanglingPermissionsAreDeleted()
        {
            var permission = new PermissionBuilder(this.DatabaseSession).Build();

            new Permissions(this.DatabaseSession).Sync();

            Assert.IsTrue(permission.Strategy.IsDeleted);
        }

        [Test]
        public void GivenSyncedPermissionsWhenRemovingAnOperationThenThatPermissionIsInvalid()
        {
            // TODO: Permission members should be write once
            //var permission = (Permission)this.DatabaseSession.Extent<Permission>().First;
            //permission.RemoveOperationEnum();

            //var derivationLog = this.DatabaseSession.Derive();

            //Assert.IsTrue(derivationLog.HasErrors);
            //Assert.AreEqual(1, derivationLog.Errors.Length);

            //var derivationError = derivationLog.Errors[0];

            //Assert.AreEqual(1, derivationError.Relations.Length);
            //Assert.AreEqual(typeof(DerivationErrorRequired), derivationError.GetType());
            //Assert.AreEqual((RoleType)Permissions.Meta.OperationEnum, derivationError.Relations[0].RoleType);
        }

        [Test]
        public void GivenSyncedPermissionsWhenRemovingAnAccessControlledMemberThenThatPermissionIsInvalid()
        {
            // TODO: Permission members should be write once
            //var permission = this.DatabaseSession.Extent<Permission>().First;
            //permission.RemoveOperandTypePointer();

            //var derivationLog = this.DatabaseSession.Derive();

            //Assert.IsTrue(derivationLog.HasErrors);
            //Assert.AreEqual(1, derivationLog.Errors.Length);

            //var derivationError = derivationLog.Errors[0];

            //Assert.AreEqual(1, derivationError.Relations.Length);
            //Assert.AreEqual(typeof(DerivationErrorRequired), derivationError.GetType());
            //Assert.AreEqual((RoleType)Permissions.Meta.OperandTypePointer, derivationError.Relations[0].RoleType);
        }
    }
}
