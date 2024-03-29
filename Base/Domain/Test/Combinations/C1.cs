// --------------------------------------------------------------------------------------------------------------------
// <copyright file="A1.cs" company="Allors bvba">
//   Copyright 2002-2013 Allors bvba.
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
// --------------------------------------------------------------------------------------------------------------------

namespace Allors.Domain
{
    using global::System.Collections.Generic;

    using Allors;

    public partial class C1
    {
        protected override void TestOnPostBuild(IObjectBuilder builder)
        {
            this.DisplayName = this.Name;
        }

        protected override void TestPrepareDerivation(IDerivation derivation)
        {
            foreach (Derivable dependency in this.Dependencies)
            {
                derivation.AddDependency(this, dependency);
            }
        }

        protected override void TestDerive(IDerivation derivation)
        {
            var sequence = (IList<IObject>)derivation["sequence"];
            if (sequence != null)
            {
                sequence.Add(this);
            }
        }
    }
}
