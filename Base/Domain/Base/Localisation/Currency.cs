// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Currency.cs" company="Allors bvba">
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
    using System.Linq;

    using Allors.Domain;

    public partial class Currency
    {
        public string GetName()
        {
            return this.Name;
        }

        public string GetLocalisedName(Locale locale)
        {
            var localisedName = this.LocalisedNames.FirstOrDefault(localizedText => localizedText.Locale.Equals(locale));
            return localisedName != null ? localisedName.Text : this.Name;
        }

        public void SetLocalisedName(Locale locale, string name)
        {
            var localisedName = this.LocalisedNames.FirstOrDefault(localizedText => localizedText.Locale.Equals(locale));
            if (localisedName == null)
            {
                localisedName = new LocalisedTextBuilder(this.Session).WithText(name).WithLocale(locale).Build();
                this.AddLocalisedName(localisedName);
            }
            else
            {
                localisedName.Text = name;
            }
        }

        protected override void BaseDerive(IDerivation derivation)
        {
            base.BaseDerive(derivation);

            derivation.Log.AssertExists(this, Currencies.Meta.IsoCode);
            derivation.Log.AssertExists(this, Currencies.Meta.Symbol);
            derivation.Log.AssertExists(this, Currencies.Meta.Name);

            this.DisplayName = string.Format("{0} ({1})", this.Name, this.IsoCode);
        }
    }
}