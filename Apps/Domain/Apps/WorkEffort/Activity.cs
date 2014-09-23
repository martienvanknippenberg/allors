// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Activity.cs" company="Allors bvba">
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
    public partial class Activity
    {
        protected override void AppsOnPostBuild(IObjectBuilder objectBuilder)
        {
            base.AppsOnPostBuild(objectBuilder);

            if (!this.ExistCurrentObjectState)
            {
                this.CurrentObjectState = new WorkEffortObjectStates(this.DatabaseSession).Created;
            }

            if (!this.ExistSearchData)
            {
                this.SearchData = new SearchDataBuilder(this.Session).Build();
            }
        }

        protected override void AppsDerive(IDerivation derivation)
        {
            base.AppsDerive(derivation);

            derivation.Log.AssertExists(this, WorkEfforts.Meta.Description);

            this.DeriveDisplayName();
            this.DeriveSearchDataCharacterBoundaryText();
            this.DeriveSearchDataWordBoundaryText();

            this.PreviousObjectState = this.CurrentObjectState;
        }

        protected override void AppsDeriveDisplayName()
        {
            this.DisplayName = this.ComposeDisplayName();
        }

        protected override void AppsDeriveSearchDataCharacterBoundaryText()
        {
            this.SearchData.CharacterBoundaryText = this.AppsComposeSearchDataCharacterBoundaryText();
        }

        protected override void AppsDeriveSearchDataWordBoundaryText()
        {
            this.SearchData.WordBoundaryText = this.AppsComposeSearchDataWordBoundaryText();
        }

        protected override string AppsComposeDisplayName()
        {
            return this.Description;
        }

        protected override string AppsComposeSearchDataCharacterBoundaryText()
        {
            return this.Description;
        }

        protected override string AppsComposeSearchDataWordBoundaryText()
        {
            return null;
        }
    }
}
