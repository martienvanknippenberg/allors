// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class UnitOfMeasure
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (UnitOfMeasureBuilder)objectBuilder;

			this.Description = builder.Description;
		

			this.Abbreviation = builder.Abbreviation;
		

			this.DisplayName = builder.DisplayName;
					

			if(builder.UniqueId.HasValue)
			{
				this.UniqueId = builder.UniqueId.Value;
			}			
					

			if(builder.IsActive.HasValue)
			{
				this.IsActive = builder.IsActive.Value;
			}			
		

			this.Name = builder.Name;
		
			if(builder.UnitOfMeasureConversions!=null)
			{
				this.UnitOfMeasureConversions = builder.UnitOfMeasureConversions.ToArray();
			}

			if(builder.DeniedPermissions!=null)
			{
				this.DeniedPermissions = builder.DeniedPermissions.ToArray();
			}

			if(builder.SecurityTokens!=null)
			{
				this.SecurityTokens = builder.SecurityTokens.ToArray();
			}


			this.SearchData = builder.SearchData;


			if(builder.LocalisedNames!=null)
			{
				this.LocalisedNames = builder.LocalisedNames.ToArray();
			}

		}
	}

	public partial class UnitOfMeasureBuilder : Allors.ObjectBuilder<UnitOfMeasure> , IUnitOfMeasureBuilder, UniquelyIdentifiableBuilder, UserInterfaceableBuilder, SearchableBuilder, EnumerationBuilder, global::System.IDisposable
	{		
		public UnitOfMeasureBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.String Description {get; set;}

				/// <exclude/>
				public UnitOfMeasureBuilder WithDescription(global::System.String value)
		        {
				    if(this.Description!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Description = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<UnitOfMeasureConversion> UnitOfMeasureConversions {get; set;}	

				/// <exclude/>
				public UnitOfMeasureBuilder WithUnitOfMeasureConversion(UnitOfMeasureConversion value)
		        {
					if(this.UnitOfMeasureConversions == null)
					{
						this.UnitOfMeasureConversions = new global::System.Collections.Generic.List<UnitOfMeasureConversion>(); 
					}
		            this.UnitOfMeasureConversions.Add(value);
		            return this;
		        }		

				
				public global::System.String Abbreviation {get; set;}

				/// <exclude/>
				public UnitOfMeasureBuilder WithAbbreviation(global::System.String value)
		        {
				    if(this.Abbreviation!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Abbreviation = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public UnitOfMeasureBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public UnitOfMeasureBuilder WithDeniedPermission(Permission value)
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
				public UnitOfMeasureBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				
				public global::System.Guid? UniqueId {get; set;}

				/// <exclude/>
				public UnitOfMeasureBuilder WithUniqueId(global::System.Guid? value)
		        {
				    if(this.UniqueId!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UniqueId = value;
		            return this;
		        }	

				public SearchData SearchData {get; set;}

				/// <exclude/>
				public UnitOfMeasureBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<LocalisedText> LocalisedNames {get; set;}	

				/// <exclude/>
				public UnitOfMeasureBuilder WithLocalisedName(LocalisedText value)
		        {
					if(this.LocalisedNames == null)
					{
						this.LocalisedNames = new global::System.Collections.Generic.List<LocalisedText>(); 
					}
		            this.LocalisedNames.Add(value);
		            return this;
		        }		

				
				public global::System.Boolean? IsActive {get; set;}

				/// <exclude/>
				public UnitOfMeasureBuilder WithIsActive(global::System.Boolean? value)
		        {
				    if(this.IsActive!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.IsActive = value;
		            return this;
		        }	

				public global::System.String Name {get; set;}

				/// <exclude/>
				public UnitOfMeasureBuilder WithName(global::System.String value)
		        {
				    if(this.Name!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Name = value;
		            return this;
		        }	


	}

	public partial class UnitsOfMeasure : global::Allors.ObjectsBase<UnitOfMeasure>
	{
		public static readonly UnitOfMeasureMeta Meta = UnitOfMeasureMeta.Instance;

		public UnitsOfMeasure(Allors.ISession session) : base(session)
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