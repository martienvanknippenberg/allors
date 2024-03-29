//------------------------------------------------------------------------------------------------- 
// <copyright file="ContactMechanismPurposeTests.cs" company="Allors bvba">
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
    

    using NUnit.Framework;

    [TestFixture]
    public class ContactMechanismPurposeTests : DomainTest
    {
        [Test]
        public void GivenContactMechanismPurpose_WhenDeriving_ThenDisplayNameIsSet()
        {
            var contactMechanismPurpose = new ContactMechanismPurposes(this.DatabaseSession).GeneralPhoneNumber;
            Assert.AreEqual("General Phone Number", contactMechanismPurpose.DisplayName);
        }
    }
}