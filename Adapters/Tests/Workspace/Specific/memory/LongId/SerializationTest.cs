// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerializationTest.cs" company="Allors bvba">
//   Copyright 2002-2012 Allors bvba.
// 
// Dual Licensed under
//   a) the Lesser General Public Licence v3 (LGPL)
//   b) the Allors License
// 
// The LGPL License is included in the file lgpl.txt.
// The Allors License is an addendum to your contract.
// 
// Allors Platform is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// For more information visit http://www.allors.com/legal
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Allors.Special.Memory.LongId
{
    using Allors;

    using NUnit.Framework;

    [TestFixture]
    public class SerializationTest : Adapters.Special.SerializationTest
    {
        private readonly Profile profile = new Profile();

        protected override IPopulation Population
        {
            get { return this.profile.Population; }
        }

        protected override IPopulation CreatePopulation()
        {
            return this.profile.CreatePopulation();
        }

        [TearDown]
        protected void Dispose()
        {
            this.profile.Dispose();
        }

        [SetUp]
        protected void Init()
        {
            this.profile.Init();
        }
    }
}