// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Country.cs" company="Allors bvba">
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

    public partial class Country
    {
        protected override void AppsDerive(IDerivation derivation)
        {
            derivation.Log.AssertExists(this, Countries.Meta.Currency);

            if (this.ExistIsoCode)
            {
                this.EuMemberState = Countries.euMemberStates.Contains(this.IsoCode);

                IbanData ibanData;
                if (Countries.IbanDataByCountry.TryGetValue(this.IsoCode, out ibanData))
                {
                    this.IbanLength = ibanData.Lenght;
                    this.IbanRegex = ibanData.RegexStructure;
                }
                else
                {
                    this.RemoveIbanLength();
                    this.RemoveIbanRegex();
                }
            }
            else
            {
                this.RemoveEuMemberState();
                this.RemoveIbanLength();
                this.RemoveIbanRegex();
            }
        }

        private void AppsDeriveSearchDataCharacterBoundaryText()
        {
            // TODO:
        }

        private void AppsDeriveSearchDataWordBoundaryText()
        {
            // TODO:
        }

        private string AppsComposeSearchDataCharacterBoundaryText()
        {
            // TODO:
            return null;
        }

        private string AppsComposeSearchDataWordBoundaryText()
        {
            // TODO:
            return null;
        }
    }
}