// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TimeAndMaterialsService.cs" company="Allors bvba">
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
    

    

    public partial class TimeAndMaterialsService
    {
        public void AddToBasePrice(BasePrice basePrice)
        {
            this.AddBasePrice(basePrice);
        }

        public void RemoveFromBasePrices(BasePrice basePrice)
        {
            this.RemoveBasePrice(basePrice);
        }

        protected override void AppsOnPostBuild(IObjectBuilder builder)
        {
            base.AppsOnPostBuild(builder);

            if (!this.ExistSoldBy)
            {
                this.SoldBy = Domain.Singleton.Instance(this.Session).DefaultInternalOrganisation;
            }

            if (!this.ExistSearchData)
            {
                this.SearchData = new SearchDataBuilder(this.Session).Build();
            }
        }

        protected override void AppsDerive(IDerivation derivation)
        {
            

            derivation.Log.AssertExists(this, TimeAndMaterialsServices.Meta.Name);
            derivation.Log.AssertExists(this, TimeAndMaterialsServices.Meta.VatRate);

            if (this.ProductCategories.Count == 1 && !this.ExistPrimaryProductCategory)
            {
                this.PrimaryProductCategory = this.ProductCategories.First;
            }

            if (this.ExistPrimaryProductCategory && !this.ExistProductCategories)
            {
                this.AddProductCategory(PrimaryProductCategory);
            }

            this.DeriveDisplayName();
            this.DeriveSearchDataCharacterBoundaryText();
            this.DeriveSearchDataWordBoundaryText();

            this.DeriveVirtualProductPriceComponent();
            this.DeriveProductCategoryExpanded();
        }

        private void AppsDeriveVirtualProductPriceComponent()
        {
            if (!this.ExistProductWhereVariant)
            {
                this.RemoveVirtualProductPriceComponents();
            }

            if (this.ExistVariants)
            {
                this.RemoveVirtualProductPriceComponents();

                var priceComponents = this.PriceComponentsWhereProduct;

                foreach (TimeAndMaterialsService product in this.Variants)
                {
                    foreach (PriceComponent priceComponent in priceComponents)
                    {
                        product.AddVirtualProductPriceComponent(priceComponent);

                        var basePrice = priceComponent as BasePrice;
                        if (basePrice != null && !priceComponent.ExistProductFeature)
                        {
                            product.AddToBasePrice(basePrice);
                        }
                    }
                }
            }
        }

        private void AppsDeriveProductCategoryExpanded()
        {
            this.RemoveProductCategoriesExpanded();

            if (this.ExistPrimaryProductCategory)
            {
                this.AddProductCategoryExpanded(this.PrimaryProductCategory);
                foreach (ProductCategory ancestor in this.PrimaryProductCategory.Ancestors)
                {
                    this.AddProductCategoryExpanded(ancestor);
                }
            }

            foreach (ProductCategory productCategory in this.ProductCategories)
            {
                this.AddProductCategoryExpanded(productCategory);
                foreach (ProductCategory ancestor in productCategory.Ancestors)
                {
                    this.AddProductCategoryExpanded(ancestor);
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
            return this.Name;
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