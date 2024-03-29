//------------------------------------------------------------------------------------------------- 
// <copyright file="Place.cs" company="Allors bvba">
// Copyright 2002-2013 Allors bvba.
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
// <summary>Defines the Place type.</summary>
//-------------------------------------------------------------------------------------------------

namespace Allors.Domain
{
    using global::System.Text;

    /// <summary>
    /// A Place is a fysical location somewhere on earth, defined as a postalcode/city and a country
    /// </summary>
    public partial class Place
    {
        public override string ToString()
        {
            return DisplayName;
        }

        protected override void TestOnPostBuild(Allors.IObjectBuilder builder)
        {
            if (!this.ExistSearchData)
            {
                this.SearchData = new SearchDataBuilder(this.Session).Build();
            }
        }

        protected override void TestDerive(IDerivation derivation)
        {
            derivation.Log.AssertExists(this, Places.Meta.PostalCode);
            derivation.Log.AssertNonEmptyString(this, Places.Meta.PostalCode);
            derivation.Log.AssertExists(this, Places.Meta.City);
            derivation.Log.AssertNonEmptyString(this, Places.Meta.City);

            var sb = new StringBuilder();
            if (this.ExistPostalCode)
            {
                sb.AppendFormat("{0} ", this.PostalCode);
            }

            if (this.ExistCity)
            {
                sb.Append(this.City);
            }

            this.DisplayName = sb.ToString();

            this.SearchData.CharacterBoundaryText = this.DisplayName;
            this.SearchData.RemoveWordBoundaryText();
        }
    }
}
