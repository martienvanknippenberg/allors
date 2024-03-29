// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DerivationErrorRequired.cs" company="Allors bvba">
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
// <summary>
//
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Allors.Domain
{
    using Allors;
    using Allors.Meta;

    using Resources;

    public class DerivationErrorRequired : DerivationError
    {
        public DerivationErrorRequired(DerivationLog derivationLog, DerivationRelation relation)
            : base(derivationLog, new[] { relation }, ErrorMessages.DerivationErrorRequired)
        {
        }

        public DerivationErrorRequired(DerivationLog derivationLog, IObject association, RoleType roleType) :
            this(derivationLog, new DerivationRelation(association, roleType))
        {
        }
    }
}