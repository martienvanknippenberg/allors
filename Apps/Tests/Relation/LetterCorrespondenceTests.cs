//------------------------------------------------------------------------------------------------- 
// <copyright file="LetterCorrespondenceTests.cs" company="Allors bvba">
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
    public class LetterCorrespondenceTests : DomainTest
    {
        [Test]
        public void GivenLetterCorrespondence_WhenDeriving_ThenRequiredRelationsMustExist()
        {
            var builder = new LetterCorrespondenceBuilder(this.DatabaseSession);
            var communication = builder.Build();

            Assert.IsTrue(this.DatabaseSession.Derive().HasErrors);

            this.DatabaseSession.Rollback();

            builder.WithDescription("Letter correspondence");
            communication = builder.Build();

            Assert.IsFalse(this.DatabaseSession.Derive().HasErrors);

            Assert.AreEqual(communication.CurrentCommunicationEventStatus.CommunicationEventObjectState, new CommunicationEventObjectStates(this.DatabaseSession).Opened);
            Assert.AreEqual(communication.CurrentObjectState, new CommunicationEventObjectStates(this.DatabaseSession).Opened);
            Assert.AreEqual(communication.CurrentObjectState, communication.PreviousObjectState);
        }

        [Test]
        public void GivenLetterCorrespondence_WhenDeriving_ThenDisplayNameIsSet()
        {
            var originator = new PersonBuilder(this.DatabaseSession).WithLastName("originator").Build();
            var receiver1 = new PersonBuilder(this.DatabaseSession).WithLastName("receiver1").Build();
            var receiver2 = new PersonBuilder(this.DatabaseSession).WithLastName("receiver2").Build();

            this.DatabaseSession.Derive(true);
            this.DatabaseSession.Commit();

            var communication = new LetterCorrespondenceBuilder(this.DatabaseSession)
                .WithDescription("Letter correspondence")
                .WithOriginator(originator)
                .WithReceiver(receiver1)
                .WithReceiver(receiver2)
                .WithActualStart(DateTime.Now)
                .Build();

            this.DatabaseSession.Derive(true);
            
            var uiText = string.Format("Letter from: {0} to: {1} {2}", originator.DisplayName, receiver1.DisplayName, receiver2.DisplayName);
            Assert.AreEqual(uiText, communication.DisplayName);
        }

        [Test]
        public void GivenLetterCorrespondence_WhenDeriving_ThenInvolvedPartiesAreDerived()
        {
            var owner = new PersonBuilder(this.DatabaseSession).WithLastName("owner").Build();
            var originator = new PersonBuilder(this.DatabaseSession).WithLastName("originator").Build();
            var receiver = new PersonBuilder(this.DatabaseSession).WithLastName("receiver").Build();

            this.DatabaseSession.Derive(true);
            this.DatabaseSession.Commit();

            var communication = new LetterCorrespondenceBuilder(this.DatabaseSession)
                .WithDescription("Hello world!")
                .WithOwner(owner)
                .WithOriginator(originator)
                .WithReceiver(receiver)
                .Build();

            this.DatabaseSession.Derive(true);
            
            Assert.AreEqual(3, communication.InvolvedParties.Count);
            Assert.Contains(owner, communication.InvolvedParties);
            Assert.Contains(originator, communication.InvolvedParties);
            Assert.Contains(receiver, communication.InvolvedParties);
        }
    }
}