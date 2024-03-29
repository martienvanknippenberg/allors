// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContactMechanismPurpose.cs" company="Allors bvba">
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
    public partial class ContactMechanismPurpose
    {
        public bool IsHeadQuarters
        {
            get
            {
                return this.Equals(new ContactMechanismPurposes(this.Session).HeadQuarters);
            }
        }

        public bool IsSalesOffice
        {
            get
            {
                return this.Equals(new ContactMechanismPurposes(this.Session).SalesOffice);
            }
        }

        public bool IsHomeAddress
        {
            get
            {
                return this.Equals(new ContactMechanismPurposes(this.Session).HomeAddress);
            }
        }

        public bool IsGeneralFaxNumber
        {
            get
            {
                return this.Equals(new ContactMechanismPurposes(this.Session).GeneralFaxNumber);
            }
        }

        public bool IsGeneralPhoneNumber
        {
            get
            {
                return this.Equals(new ContactMechanismPurposes(this.Session).GeneralPhoneNumber);
            }
        }

        public bool IsBillingAddress
        {
            get
            {
                return this.Equals(new ContactMechanismPurposes(this.Session).BillingAddress);
            }
        }

        public bool IsInternetAddress
        {
            get
            {
                return this.Equals(new ContactMechanismPurposes(this.Session).InternetAddress);
            }
        }

        public bool IsOrderAddress
        {
            get
            {
                return this.Equals(new ContactMechanismPurposes(this.Session).OrderAddress);
            }
        }

        public bool IsShippingAddress
        {
            get
            {
                return this.Equals(new ContactMechanismPurposes(this.Session).ShippingAddress);
            }
        }

        public bool IsBillingInquiriesPhone
        {
            get
            {
                return this.Equals(new ContactMechanismPurposes(this.Session).BillingInquiriesPhone);
            }
        }

        public bool IsOrderInquiriesPhone
        {
            get
            {
                return this.Equals(new ContactMechanismPurposes(this.Session).OrderInquiriesPhone);
            }
        }

        public bool IsShippingInquiriesPhone
        {
            get
            {
                return this.Equals(new ContactMechanismPurposes(this.Session).ShippingInquiriesPhone);
            }
        }

        public bool IsBillingInquiriesFax
        {
            get
            {
                return this.Equals(new ContactMechanismPurposes(this.Session).BillingInquiriesFax);
            }
        }

        public bool IsOrderInquiriesFax
        {
            get
            {
                return this.Equals(new ContactMechanismPurposes(this.Session).OrderInquiriesFax);
            }
        }

        public bool IsShippingInquiriesFax
        {
            get
            {
                return this.Equals(new ContactMechanismPurposes(this.Session).ShippingInquiriesFax);
            }
        }

        public bool IsPersonalEmailAddress
        {
            get
            {
                return this.Equals(new ContactMechanismPurposes(this.Session).PersonalEmailAddress);
            }
        }

        public bool IsCellPhoneNumber
        {
            get
            {
                return this.Equals(new ContactMechanismPurposes(this.Session).CellPhoneNumber);
            }
        }

        protected override void AppsOnPostBuild(IObjectBuilder builder)
        {
            this.AppsEnumerationOnPostBuild(builder);
        }

        protected override void AppsDerive(IDerivation derivation)
        {
            this.AppsEnumerationDerive(derivation);
        }
    }
}