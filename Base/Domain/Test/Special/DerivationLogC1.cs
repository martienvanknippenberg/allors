// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DerivationLogC1.cs" company="Allors bvba">
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
    public partial class DerivationLogC1
    {
        protected override void TestDerive(Domain.IDerivation derivation)
        {
            base.TestDerive(derivation);

            derivation.Log.AssertIsUnique(this, DerivationLogC1s.Meta.UniqueId);
        }
    }
}