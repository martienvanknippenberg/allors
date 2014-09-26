// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class Country
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (CountryBuilder)objectBuilder;

			this.Name = builder.Name;
		

			this.IsoCode = builder.IsoCode;
					

			if(builder.IbanLength.HasValue)
			{
				this.IbanLength = builder.IbanLength.Value;
			}			
					

			if(builder.EuMemberState.HasValue)
			{
				this.EuMemberState = builder.EuMemberState.Value;
			}			
		

			this.TelephoneCode = builder.TelephoneCode;
		

			this.IbanRegex = builder.IbanRegex;
		

			this.UriExtension = builder.UriExtension;
		

			this.DisplayName = builder.DisplayName;
		

			this.Abbreviation = builder.Abbreviation;
					

			if(builder.Latitude.HasValue)
			{
				this.Latitude = builder.Latitude.Value;
			}			
					

			if(builder.Longitude.HasValue)
			{
				this.Longitude = builder.Longitude.Value;
			}			
					

			if(builder.UniqueId.HasValue)
			{
				this.UniqueId = builder.UniqueId.Value;
			}			
		

			this.Currency = builder.Currency;


			if(builder.LocalisedNames!=null)
			{
				this.LocalisedNames = builder.LocalisedNames.ToArray();
			}

			if(builder.VatRates!=null)
			{
				this.VatRates = builder.VatRates.ToArray();
			}


			this.VatForm = builder.VatForm;


			if(builder.DeniedPermissions!=null)
			{
				this.DeniedPermissions = builder.DeniedPermissions.ToArray();
			}

			if(builder.SecurityTokens!=null)
			{
				this.SecurityTokens = builder.SecurityTokens.ToArray();
			}


			this.SearchData = builder.SearchData;


			if(builder.Cities!=null)
			{
				this.Cities = builder.Cities.ToArray();
			}

		}
	}

	public partial class CountryBuilder : Allors.ObjectBuilder<Country> , UserInterfaceableBuilder, SearchableBuilder, GeographicBoundaryBuilder, CityBoundBuilder, global::System.IDisposable
	{		
		public CountryBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public Currency Currency {get; set;}

				/// <exclude/>
				public CountryBuilder WithCurrency(Currency value)
		        {
		            if(this.Currency!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Currency = value;
		            return this;
		        }		

				
				public global::System.String Name {get; set;}

				/// <exclude/>
				public CountryBuilder WithName(global::System.String value)
		        {
				    if(this.Name!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Name = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<LocalisedText> LocalisedNames {get; set;}	

				/// <exclude/>
				public CountryBuilder WithLocalisedName(LocalisedText value)
		        {
					if(this.LocalisedNames == null)
					{
						this.LocalisedNames = new global::System.Collections.Generic.List<LocalisedText>(); 
					}
		            this.LocalisedNames.Add(value);
		            return this;
		        }		

				
				public global::System.String IsoCode {get; set;}

				/// <exclude/>
				public CountryBuilder WithIsoCode(global::System.String value)
		        {
				    if(this.IsoCode!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.IsoCode = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<VatRate> VatRates {get; set;}	

				/// <exclude/>
				public CountryBuilder WithVatRate(VatRate value)
		        {
					if(this.VatRates == null)
					{
						this.VatRates = new global::System.Collections.Generic.List<VatRate>(); 
					}
		            this.VatRates.Add(value);
		            return this;
		        }		

				
				public global::System.Int32? IbanLength {get; set;}

				/// <exclude/>
				public CountryBuilder WithIbanLength(global::System.Int32? value)
		        {
				    if(this.IbanLength!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.IbanLength = value;
		            return this;
		        }	

				public global::System.Boolean? EuMemberState {get; set;}

				/// <exclude/>
				public CountryBuilder WithEuMemberState(global::System.Boolean? value)
		        {
				    if(this.EuMemberState!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.EuMemberState = value;
		            return this;
		        }	

				public global::System.String TelephoneCode {get; set;}

				/// <exclude/>
				public CountryBuilder WithTelephoneCode(global::System.String value)
		        {
				    if(this.TelephoneCode!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.TelephoneCode = value;
		            return this;
		        }	

				public global::System.String IbanRegex {get; set;}

				/// <exclude/>
				public CountryBuilder WithIbanRegex(global::System.String value)
		        {
				    if(this.IbanRegex!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.IbanRegex = value;
		            return this;
		        }	

				public VatForm VatForm {get; set;}

				/// <exclude/>
				public CountryBuilder WithVatForm(VatForm value)
		        {
		            if(this.VatForm!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.VatForm = value;
		            return this;
		        }		

				
				public global::System.String UriExtension {get; set;}

				/// <exclude/>
				public CountryBuilder WithUriExtension(global::System.String value)
		        {
				    if(this.UriExtension!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UriExtension = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public CountryBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public CountryBuilder WithDeniedPermission(Permission value)
		        {
					if(this.DeniedPermissions == null)
					{
						this.DeniedPermissions = new global::System.Collections.Generic.List<Permission>(); 
					}
		            this.DeniedPermissions.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<SecurityToken> SecurityTokens {get; set;}	

				/// <exclude/>
				public CountryBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				
				public SearchData SearchData {get; set;}

				/// <exclude/>
				public CountryBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				
				public global::System.String Abbreviation {get; set;}

				/// <exclude/>
				public CountryBuilder WithAbbreviation(global::System.String value)
		        {
				    if(this.Abbreviation!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Abbreviation = value;
		            return this;
		        }	

				public global::System.Decimal? Latitude {get; set;}

				/// <exclude/>
				public CountryBuilder WithLatitude(global::System.Decimal? value)
		        {
				    if(this.Latitude!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Latitude = value;
		            return this;
		        }	

				public global::System.Decimal? Longitude {get; set;}

				/// <exclude/>
				public CountryBuilder WithLongitude(global::System.Decimal? value)
		        {
				    if(this.Longitude!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Longitude = value;
		            return this;
		        }	

				public global::System.Guid? UniqueId {get; set;}

				/// <exclude/>
				public CountryBuilder WithUniqueId(global::System.Guid? value)
		        {
				    if(this.UniqueId!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UniqueId = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<City> Cities {get; set;}	

				/// <exclude/>
				public CountryBuilder WithCity(City value)
		        {
					if(this.Cities == null)
					{
						this.Cities = new global::System.Collections.Generic.List<City>(); 
					}
		            this.Cities.Add(value);
		            return this;
		        }		

				

	}

	public partial class Countries : global::Allors.ObjectsBase<Country>
	{
		public static readonly CountryMeta Meta = CountryMeta.Instance;

		public Countries(Allors.ISession session) : base(session)
		{
		}

		public override Allors.Meta.Composite ObjectType
		{
			get
			{
				return Meta.ObjectType;
			}
		}
	}

}