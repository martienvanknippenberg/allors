// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Cash.cs" company="Allors bvba">
//   Copyright 2002-2012 Allors bvba.
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
    using Allors.Domain;
    

    public partial class Cash
    {
        protected override void AppsOnPostBuild(IObjectBuilder builder)
        {
            base.AppsOnPostBuild(builder);

            if (!this.ExistIsActive)
            {
                this.IsActive = true;
            }

            if (!this.ExistSearchData)
            {
                this.SearchData = new SearchDataBuilder(this.Session).Build();
            }
        }

        protected override void AppsDerive(IDerivation derivation)
        {
            

            if (this.ExistInternalOrganisationWherePaymentMethod && this.InternalOrganisationWherePaymentMethod.DoAccounting)
            { 
                derivation.Log.AssertExists(this, Cashes.Meta.Creditor);
                derivation.Log.AssertAtLeastOne(this, Cashes.Meta.GeneralLedgerAccount, Cashes.Meta.Journal);
            }

            derivation.Log.AssertExists(this, Cashes.Meta.Description);
            derivation.Log.AssertExistsAtMostOne(this, Cashes.Meta.GeneralLedgerAccount, Cashes.Meta.Journal);

            this.DisplayName = this.ExistDescription? this.Description : null;

            var characterBoundaryText = this.ExistDescription ? this.Description : null;

            this.SearchData.CharacterBoundaryText = characterBoundaryText;
            this.SearchData.WordBoundaryText = null;
        }
    }
}