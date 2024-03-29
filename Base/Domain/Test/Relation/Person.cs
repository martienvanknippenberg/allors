//------------------------------------------------------------------------------------------------- 
// <copyright file="Person.cs" company="Allors bvba">
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
// <summary>Defines the Person type.</summary>
//-------------------------------------------------------------------------------------------------

namespace Allors.Domain
{
    using global::System.Collections.Generic;

    using Allors;

    /// <summary>
    /// A living human being.
    /// </summary>
    public partial class Person
    {
        public static Extent<Person> ExtentByLastName(ISession session)
        {
            return session.Extent<Person>().AddSort(Persons.Meta.LastName);
        }

        public override string ToString()
        {
            if (this.ExistLastName)
            {
                if (this.ExistFirstName)
                {
                    return string.Concat(this.LastName, " ", this.FirstName);
                }

                return this.LastName;
            }

            return base.ToString();
        }

        protected override void TestOnPostBuild(IObjectBuilder objectBuilder)
        {
            base.TestOnPostBuild(objectBuilder);

            if (!this.ExistSearchData)
            {
                this.SearchData = new SearchDataBuilder(this.Session).Build();
            }
        }

        protected override void TestDerive(IDerivation derivation)
        {
            base.TestDerive(derivation);

            if (!this.ExistOwnerSecurityToken)
            {
                var mySecurityToken = new SecurityTokenBuilder(this.Session).Build();
                this.OwnerSecurityToken = mySecurityToken;
            }

            this.DisplayName = this.TestComposeDisplayName();

            this.SearchData.CharacterBoundaryText = this.DisplayName;
            this.SearchData.RemoveWordBoundaryText();

            derivation.Log.AssertExists(this, Persons.Meta.LastName);

            if (this.ExistFirstName && this.ExistLastName)
            {
                this.FullName = this.FirstName + " " + this.LastName;
            }
            else if (this.ExistFirstName)
            {
                this.FullName = this.FirstName;
            }
            else
            {
                this.FullName = this.LastName;
            }

            var template = Singleton.Instance(this.Session).PersonTemplate;
            this.PrintContent = template.Apply(new Dictionary<string, object> { { "this", this } });
        }

        private string TestComposeDisplayName()
        {
            if (this.ExistFirstName && this.ExistMiddleName && this.ExistLastName)
            {
                return this.FirstName + " " + this.MiddleName + " " + this.LastName;
            }

            if (this.ExistFirstName && this.ExistLastName)
            {
                return this.FirstName + " " + this.LastName;
            }

            if (this.ExistMiddleName && this.ExistLastName)
            {
                return this.MiddleName + " " + this.LastName;
            }

            if (this.ExistLastName)
            {
                return this.LastName;
            }

            if (this.ExistFirstName)
            {
                return FirstName;
            }

            if (this.ExistUniqueId)
            {
                return this.UniqueId.ToString();
            }

            return this.GetType() + "[" + this.Id + "]";
        }
    }
}
