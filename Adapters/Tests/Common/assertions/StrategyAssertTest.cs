// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StrategyAssertTest.cs" company="Allors bvba">
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

namespace Allors.Adapters.Special.Assertions
{
    using Allors.Adapters.Database.Memory.IntegerId;
    using Allors;
    using Allors.Meta;

    using Allors.Domain;

    using NUnit.Framework;

    [TestFixture]
    public class StrategyAssertTest
    {
        private ISession session;

        [SetUp]
        protected void Init()
        {
            var configuration = new Configuration { ObjectFactory = new ObjectFactory(Repository.MetaPopulation, typeof(ObjectBase).Assembly, "Allors.Domain") };
            var database = new Database(configuration);
            this.session = database.CreateSession();
        }

        [TearDown]
        protected void Dispose()
        {
            this.session = null;
        }
    }
}