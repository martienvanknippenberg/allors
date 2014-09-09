//------------------------------------------------------------------------------------------------- 
// <copyright file="MethodTypeTest.cs" company="Allors bvba">
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
// <summary>Defines the MethodTypeTest type.</summary>
//-------------------------------------------------------------------------------------------------

namespace Allors.Meta.Static
{
    using System;
    using System.Collections.Generic;

    using Allors.Meta.Events;

    using NUnit.Framework;

    [TestFixture]
    public class MethodTypeTest : AbstractTest
    {
        private readonly List<MetaObjectChangedEventArgs> metaObjectChangedEvents = new List<MetaObjectChangedEventArgs>();

        [Test]
        public void ValidateDuplicateMethod()
        {
            this.Populate();

            var methodType = this.Domain.AddDeclaredMethodType(Guid.NewGuid());
            methodType.ObjectType = this.Population.C1;
            methodType.Name = "MyName";

            Assert.IsTrue(this.Domain.IsValid);

            var otherMethodType = this.Domain.AddDeclaredMethodType(Guid.NewGuid());
            methodType.ObjectType = this.Population.C1;
            methodType.Name = "MyName";

            Assert.IsFalse(this.Domain.IsValid);
        }

        private void DomainMetaObjectChanged(object sender, MetaObjectChangedEventArgs args)
        {
            this.metaObjectChangedEvents.Add(args);
        }
    }

    public class MethodTypeTestWithSuperDomains : MethodTypeTest
    {
        protected override void Populate()
        {
            this.Population.PopulateWithSuperDomains();
        }
    }
}