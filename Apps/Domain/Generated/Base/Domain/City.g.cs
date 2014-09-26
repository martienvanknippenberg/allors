// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class City
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (CityBuilder)objectBuilder;

			this.Name = builder.Name;
		

			this.Abbreviation = builder.Abbreviation;
					

			if(builder.Latitude.HasValue)
			{
				this.Latitude = builder.Latitude.Value;
			}			
					

			if(builder.Longitude.HasValue)
			{
				this.Longitude = builder.Longitude.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
					

			if(builder.UniqueId.HasValue)
			{
				this.UniqueId = builder.UniqueId.Value;
			}			
		

			this.State = builder.State;



			this.SearchData = builder.SearchData;


			if(builder.DeniedPermissions!=null)
			{
				this.DeniedPermissions = builder.DeniedPermissions.ToArray();
			}

			if(builder.SecurityTokens!=null)
			{
				this.SecurityTokens = builder.SecurityTokens.ToArray();
			}


			this.Country = builder.Country;


		}
	}

	public partial class CityBuilder : Allors.ObjectBuilder<City> , GeographicBoundaryBuilder, UserInterfaceableBuilder, CountryBoundBuilder, global::System.IDisposable
	{		
		public CityBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.String Name {get; set;}

				/// <exclude/>
				public CityBuilder WithName(global::System.String value)
		        {
				    if(this.Name!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Name = value;
		            return this;
		        }	

				public State State {get; set;}

				/// <exclude/>
				public CityBuilder WithState(State value)
		        {
		            if(this.State!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.State = value;
		            return this;
		        }		

				
				public global::System.String Abbreviation {get; set;}

				/// <exclude/>
				public CityBuilder WithAbbreviation(global::System.String value)
		        {
				    if(this.Abbreviation!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Abbreviation = value;
		            return this;
		        }	

				public SearchData SearchData {get; set;}

				/// <exclude/>
				public CityBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				
				public global::System.Decimal? Latitude {get; set;}

				/// <exclude/>
				public CityBuilder WithLatitude(global::System.Decimal? value)
		        {
				    if(this.Latitude!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Latitude = value;
		            return this;
		        }	

				public global::System.Decimal? Longitude {get; set;}

				/// <exclude/>
				public CityBuilder WithLongitude(global::System.Decimal? value)
		        {
				    if(this.Longitude!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Longitude = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public CityBuilder WithDeniedPermission(Permission value)
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
				public CityBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public CityBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Guid? UniqueId {get; set;}

				/// <exclude/>
				public CityBuilder WithUniqueId(global::System.Guid? value)
		        {
				    if(this.UniqueId!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UniqueId = value;
		            return this;
		        }	

				public Country Country {get; set;}

				/// <exclude/>
				public CityBuilder WithCountry(Country value)
		        {
		            if(this.Country!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Country = value;
		            return this;
		        }		

				

	}

	public partial class Cities : global::Allors.ObjectsBase<City>
	{
		public static readonly CityMeta Meta = CityMeta.Instance;

		public Cities(Allors.ISession session) : base(session)
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