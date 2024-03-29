// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CounterTest.cs" company="Allors bvba">
//   Copyright 2002-2009 Allors bvba.
// 
// Dual Licensed under
//   a) the General Public Licence v3 (GPL)
//   b) the Allors License
// 
// The GPL License is included in the file gpl.txt.
// The Allors License is an addendum to your contract.
// 
// Allors Platform is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// For more information visit http://www.allors.com/legal
// </copyright>
// <summary>
//   Defines the ApplicationTests type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Allors.Common
{
    using System;
    using System.Data;

    using Allors.Adapters.Workspace.Memory.IntegerId;
    using Allors.Domain;
  
    using NUnit.Framework;

    [TestFixture]
    public class CounterTest : DomainTest
    {
        private IDatabase previousDatabase;
        private IDatabase previousSerializableDatabase;

        [Test]
        public void Meta()
        {
            var counterBuilder = new CounterBuilder(this.DatabaseSession).Build();

            Assert.IsTrue(counterBuilder.ExistUniqueId);
            Assert.AreNotEqual(Guid.Empty, counterBuilder.UniqueId);
            Assert.AreEqual(0, counterBuilder.Value);

            var secondCounterBuilder = new CounterBuilder(this.DatabaseSession).Build();

            Assert.AreNotEqual(counterBuilder.UniqueId, secondCounterBuilder.UniqueId);
        }

        [Test]
        public void NonShared()
        {
            this.SaveApplication();

            try
            {
                var configuration = new Adapters.Database.SqlClient.IntegerId.Configuration
                {
                    Id = Guid.NewGuid(),
                    ObjectFactory = Databases.ObjectFactory,
                    WorkspaceFactory = new WorkspaceFactory()
                };
                Databases.Default = new Adapters.Database.SqlClient.IntegerId.Database(configuration);
                Databases.Serializable = null;

                this.Init(true);

                var id = Guid.NewGuid();

                new CounterBuilder(DatabaseSession).WithUniqueId(id).Build();
                this.DatabaseSession.Derive(true);
                this.DatabaseSession.Commit();

                Assert.AreEqual(1, Counters.NextValue(this.DatabaseSession, id));
                Assert.AreEqual(2, Counters.NextValue(this.DatabaseSession, id));
                Assert.AreEqual(3, Counters.NextValue(this.DatabaseSession, id));
                Assert.AreEqual(4, Counters.NextValue(this.DatabaseSession, id));
            }
            finally
            {
                this.RestoreApplication();
            }
        }

        [Test]
        public void Shared()
        {
            this.SaveApplication();

            try
            {
                var configuration = new Adapters.Database.SqlClient.IntegerId.Configuration
                                        {
                                            Id = Guid.NewGuid(),
                                            ObjectFactory = Databases.ObjectFactory,
                                            WorkspaceFactory = new WorkspaceFactory()
                                        };
                Databases.Default = new Adapters.Database.SqlClient.IntegerId.Database(configuration);
                Databases.Serializable = null;

                this.Init(true);

                var id = Guid.NewGuid();

                new CounterBuilder(DatabaseSession).WithUniqueId(id).Build();
                this.DatabaseSession.Derive(true);
                this.DatabaseSession.Commit();

                Assert.AreEqual(1, Counters.NextValue(this.DatabaseSession, id));
                Assert.AreEqual(2, Counters.NextValue(this.DatabaseSession, id));
                Assert.AreEqual(3, Counters.NextValue(this.DatabaseSession, id));
                Assert.AreEqual(4, Counters.NextValue(this.DatabaseSession, id));
            }
            finally
            {
                this.RestoreApplication();
            }
        }

        [Test]
        public void Serializable()
        {
            this.SaveApplication();

            try
            {
                var workspaceFactory = new WorkspaceFactory();
                Databases.Default = new Adapters.Database.SqlClient.IntegerId.Database(new Adapters.Database.SqlClient.IntegerId.Configuration
                                                                                                    {
                                                                                                        Id = Guid.NewGuid(),
                                                                                                        ObjectFactory = Databases.ObjectFactory,
                                                                                                        WorkspaceFactory = workspaceFactory
                                                                                                    });
                Databases.Serializable = new Adapters.Database.SqlClient.IntegerId.Database(new Adapters.Database.SqlClient.IntegerId.Configuration
                                                                                                {
                                                                                                    Id = Guid.NewGuid(),
                                                                                                    ObjectFactory = Databases.ObjectFactory,
                                                                                                    WorkspaceFactory = workspaceFactory,
                                                                                                    IsolationLevel = IsolationLevel.Serializable
                                                                                                });

                this.Init(true);

                var id = Guid.NewGuid();

                new CounterBuilder(DatabaseSession).WithUniqueId(id).Build();
                this.DatabaseSession.Derive(true);
                this.DatabaseSession.Commit();

                Assert.AreEqual(1, Counters.NextValue(this.DatabaseSession, id));
                Assert.AreEqual(2, Counters.NextValue(this.DatabaseSession, id));
                Assert.AreEqual(3, Counters.NextValue(this.DatabaseSession, id));
                Assert.AreEqual(4, Counters.NextValue(this.DatabaseSession, id));
            }
            finally
            {
                this.RestoreApplication();
            }
        }

        private void SaveApplication()
        {
            this.previousDatabase = Databases.Default;
            this.previousSerializableDatabase = Databases.Serializable;
        }

        private void RestoreApplication()
        {
            Databases.Default = this.previousDatabase;
            Databases.Serializable = this.previousSerializableDatabase;
        }
    }
}