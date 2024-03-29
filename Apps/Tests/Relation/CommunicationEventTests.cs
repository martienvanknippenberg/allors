//------------------------------------------------------------------------------------------------- 
// <copyright file="CommunicationEventTests.cs" company="Allors bvba">
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
    public class CommunicationEventTests : DomainTest
    {
        [Test]
        public void GivenFaceToFaceCommunication_WhenBuild_ThenPreviousObjectStateEqualsCurrencObjectState()
        {
            var communication = new FaceToFaceCommunicationBuilder(this.DatabaseSession)
                .WithDescription("Hello")
                .WithActualStart(DateTime.Now)
                .Build();

            this.DatabaseSession.Derive(true);

            Assert.AreEqual(new CommunicationEventObjectStates(this.DatabaseSession).Opened, communication.CurrentObjectState);
            Assert.IsNotNull(communication.PreviousObjectState);
            Assert.AreEqual(communication.PreviousObjectState, communication.CurrentObjectState);
        }

        [Test]
        public void GivenFaceToFaceCommunication_WhenConfirmed_ThenCurrentCommunicationEventStatusMustBeDerived()
        {
            var communication = new FaceToFaceCommunicationBuilder(this.DatabaseSession)
                .WithDescription("Hello")
                .WithActualStart(DateTime.Now)
                .Build();

            this.DatabaseSession.Derive(true);

            Assert.AreEqual(1, communication.CommunicationEventStatuses.Count);
            Assert.AreEqual(new CommunicationEventObjectStates(this.DatabaseSession).Opened, communication.CurrentCommunicationEventStatus.CommunicationEventObjectState);

            communication.Close();
            
            this.DatabaseSession.Derive(true);

            this.DatabaseSession.Derive(true);
            Assert.AreEqual(2, communication.CommunicationEventStatuses.Count);
            Assert.AreEqual(new CommunicationEventObjectStates(this.DatabaseSession).Closed, communication.CurrentCommunicationEventStatus.CommunicationEventObjectState);
        }
    }
}