// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FinishedGood.cs" company="Allors bvba">
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
    

    

    public partial class FinishedGood
    {
        protected override void AppsOnPostBuild(IObjectBuilder builder)
        {
            base.AppsOnPostBuild(builder);

            if (!this.ExistInventoryItemKind)
            {
                this.InventoryItemKind = new InventoryItemKinds(this.Session).NonSerialized;
            }

            if (!this.ExistOwnedByParty)
            {
                this.OwnedByParty = Domain.Singleton.Instance(this.Session).DefaultInternalOrganisation;
            }

            if (!this.ExistSearchData)
            {
                this.SearchData = new SearchDataBuilder(this.Session).Build();
            }
        }

        protected override void AppsPrepareDerivation(IDerivation derivation)
        {
            base.AppsPrepareDerivation(derivation);

            // TODO:
            if (derivation.ChangeSet.Associations.Contains(this.Id))
            {
                if (this.ExistInventoryItemsWherePart)
                {
                    foreach (InventoryItem inventoryItem in InventoryItemsWherePart)
                    {
                        derivation.AddDependency((Derivable)inventoryItem, this);
                    }
                }
            }
        }

        protected override void AppsDerive(IDerivation derivation)
        {
            

            derivation.Log.AssertExists(this, Parts.Meta.Name);

            this.DeriveDisplayName();
            this.DeriveSearchDataCharacterBoundaryText();
            this.DeriveSearchDataWordBoundaryText();

            this.DeriveInventoryItem(derivation);
        }

        private void AppsDeriveInventoryItem(IDerivation derivation)
        {
            if (this.ExistInventoryItemKind && this.InventoryItemKind.Equals(new InventoryItemKinds(this.Session).NonSerialized))
            {
                if (!ExistInventoryItemsWherePart)
                {
                    new NonSerializedInventoryItemBuilder(this.Session)
                        .WithFacility(this.OwnedByParty.DefaultFacility)
                        .WithPart(this)
                        .Build();
                }
            }
        }

        private void AppsDeriveDisplayName()
        {
            this.DisplayName = this.ComposeDisplayName();
        }

        private void AppsDeriveSearchDataCharacterBoundaryText()
        {
            this.SearchData.CharacterBoundaryText = this.AppsComposeSearchDataCharacterBoundaryText();
        }

        private void AppsDeriveSearchDataWordBoundaryText()
        {
            this.SearchData.WordBoundaryText = this.AppsComposeSearchDataWordBoundaryText();
        }

        private string AppsComposeDisplayName()
        {
            return string.Format("{0}, Id: {1}", this.ExistName ? this.Name : null, this.ExistManufacturerId ? this.ManufacturerId : null);
        }

        private string AppsComposeSearchDataCharacterBoundaryText()
        {
            return this.Name;
        }

        private string AppsComposeSearchDataWordBoundaryText()
        {
            return null;
        }
    }
}