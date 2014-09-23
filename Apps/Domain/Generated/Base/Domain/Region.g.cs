// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class Region
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (RegionBuilder)objectBuilder;

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
		
			if(builder.Associations!=null)
			{
				this.Associations = builder.Associations.ToArray();
			}


			this.SearchData = builder.SearchData;


			if(builder.DeniedPermissions!=null)
			{
				this.DeniedPermissions = builder.DeniedPermissions.ToArray();
			}

			if(builder.SecurityTokens!=null)
			{
				this.SecurityTokens = builder.SecurityTokens.ToArray();
			}

		}
	}

	public partial class RegionBuilder : Allors.ObjectBuilder<Region> , GeographicBoundaryCompositeBuilder, UserInterfaceableBuilder, global::System.IDisposable
	{		
		public RegionBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.String Name {get; set;}

				/// <exclude/>
				public RegionBuilder WithName(global::System.String value)
		        {
				    if(this.Name!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Name = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<GeographicBoundary> Associations {get; set;}	

				/// <exclude/>
				public RegionBuilder WithAssociation(GeographicBoundary value)
		        {
					if(this.Associations == null)
					{
						this.Associations = new global::System.Collections.Generic.List<GeographicBoundary>(); 
					}
		            this.Associations.Add(value);
		            return this;
		        }		

				
				public global::System.String Abbreviation {get; set;}

				/// <exclude/>
				public RegionBuilder WithAbbreviation(global::System.String value)
		        {
				    if(this.Abbreviation!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Abbreviation = value;
		            return this;
		        }	

				public SearchData SearchData {get; set;}

				/// <exclude/>
				public RegionBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				
				public global::System.Decimal? Latitude {get; set;}

				/// <exclude/>
				public RegionBuilder WithLatitude(global::System.Decimal? value)
		        {
				    if(this.Latitude!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Latitude = value;
		            return this;
		        }	

				public global::System.Decimal? Longitude {get; set;}

				/// <exclude/>
				public RegionBuilder WithLongitude(global::System.Decimal? value)
		        {
				    if(this.Longitude!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Longitude = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public RegionBuilder WithDeniedPermission(Permission value)
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
				public RegionBuilder WithSecurityToken(SecurityToken value)
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
				public RegionBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Guid? UniqueId {get; set;}

				/// <exclude/>
				public RegionBuilder WithUniqueId(global::System.Guid? value)
		        {
				    if(this.UniqueId!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UniqueId = value;
		            return this;
		        }	


	}

	public partial class Regions : global::Allors.ObjectsBase<Region>
	{
		public static readonly RegionMeta Meta = RegionMeta.Instance;

		public Regions(Allors.ISession session) : base(session)
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