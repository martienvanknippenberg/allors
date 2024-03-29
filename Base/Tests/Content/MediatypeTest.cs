//------------------------------------------------------------------------------------------------- 
// <copyright file="MediatypeTest.cs" company="Allors bvba">
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
    public class MediatypeTest : DomainTest
    {
        [Test]
        public void GivenMimeType_WhenDeriving_ThenNameIsRequired()
        {
            var builder = new MediaTypeBuilder(this.DatabaseSession);
            var mediaType = builder.Build();

            Assert.IsTrue(this.DatabaseSession.Derive().HasErrors);

            this.DatabaseSession.Rollback();

            builder.WithName("image/gif");
            mediaType = builder.Build();

            Assert.IsFalse(this.DatabaseSession.Derive().HasErrors);
        }

        [Test]
        public void GivenMimeType_WhenDeriving_ThenDisplayNameIsSet()
        {
            var mediaType = new MediaTypeBuilder(this.DatabaseSession)
                .WithName("image/gif")
                .Build();

            this.DatabaseSession.Derive(true);
            
            Assert.AreEqual("image/gif", mediaType.DisplayName);
        }
    }
}