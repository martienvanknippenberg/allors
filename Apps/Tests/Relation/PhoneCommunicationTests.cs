//------------------------------------------------------------------------------------------------- 
// <copyright file="PhoneCommunicationTests.cs" company="Allors bvba">
// Copyright 2002-2009 Allors bvba.
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
// <summary>Defines the MediaTests type.</summary>
//-------------------------------------------------------------------------------------------------

namespace Allors.Domain
{
    using System;

    using NUnit.Framework;

    [TestFixture]
    public class PhoneCommunicationTests : DomainTest
    {
        [Test]
        public void GivenPhoneCommunication_WhenDeriving_ThenRequiredRelationsMustExist()
        {
            var builder = new PhoneCommunicationBuilder(this.DatabaseSession);
            var communication = builder.Build();

            Assert.IsTrue(this.DatabaseSession.Derive().HasErrors);

            builder.WithDescription("Phonecommunication");
            communication = builder.Build();

            this.DatabaseSession.Derive(true);

            Assert.IsFalse(this.DatabaseSession.Derive().HasErrors);

            Assert.AreEqual(communication.CurrentCommunicationEventStatus.CommunicationEventObjectState, new CommunicationEventObjectStates(this.DatabaseSession).Opened);
            Assert.AreEqual(communication.CurrentObjectState, new CommunicationEventObjectStates(this.DatabaseSession).Opened);
            Assert.AreEqual(communication.CurrentObjectState, communication.PreviousObjectState);
        }

        [Test]
        public void GivenPhoneCommunication_WhenDeriving_ThenDisplayNameIsSet()
        {
            var caller = new PersonBuilder(this.DatabaseSession).WithLastName("caller").Build();
            var receiver1 = new PersonBuilder(this.DatabaseSession).WithLastName("receiver1").Build();
            var receiver2 = new PersonBuilder(this.DatabaseSession).WithLastName("receiver2").Build();

            this.DatabaseSession.Derive(true);
            this.DatabaseSession.Commit();

            var communication = new PhoneCommunicationBuilder(this.DatabaseSession)
                .WithDescription("Phonecommunication")
                .WithReceiver(receiver1)
                .WithReceiver(receiver2)
                .WithCaller(caller)
                .WithActualStart(DateTime.Now)
                .Build();

            var uiText = string.Format("Phone conversation from: {0} with: {1} {2}", caller.DisplayName, receiver1.DisplayName, receiver2.DisplayName);

            this.DatabaseSession.Derive(true);

            Assert.AreEqual(uiText, communication.DisplayName);
        }

        [Test]
        public void GivenPhoneCommunication_WhenDeriving_ThenInvolvedPartiesAreDerived()
        {
            var owner = new PersonBuilder(this.DatabaseSession).WithLastName("owner").Build();
            var caller = new PersonBuilder(this.DatabaseSession).WithLastName("caller").Build();
            var receiver = new PersonBuilder(this.DatabaseSession).WithLastName("receiver").Build();

            this.DatabaseSession.Derive(true);
            this.DatabaseSession.Commit();

            var communication = new PhoneCommunicationBuilder(this.DatabaseSession)
                .WithDescription("Hello world!")
                .WithOwner(owner)
                .WithCaller(caller)
                .WithReceiver(receiver)
                .Build();

            this.DatabaseSession.Derive(true);

            Assert.AreEqual(3, communication.InvolvedParties.Count);
            Assert.Contains(owner, communication.InvolvedParties);
            Assert.Contains(caller, communication.InvolvedParties);
            Assert.Contains(receiver, communication.InvolvedParties);
        }
    }
}