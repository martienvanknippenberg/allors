// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class Locale
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (LocaleBuilder)objectBuilder;

			this.Name = builder.Name;
		

			this.DisplayName = builder.DisplayName;
		

			this.Language = builder.Language;



			this.Country = builder.Country;


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

	public partial class LocaleBuilder : Allors.ObjectBuilder<Locale> , UserInterfaceableBuilder, global::System.IDisposable
	{		
		public LocaleBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.String Name {get; set;}

				/// <exclude/>
				public LocaleBuilder WithName(global::System.String value)
		        {
				    if(this.Name!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Name = value;
		            return this;
		        }	

				public Language Language {get; set;}

				/// <exclude/>
				public LocaleBuilder WithLanguage(Language value)
		        {
		            if(this.Language!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Language = value;
		            return this;
		        }		

				
				public Country Country {get; set;}

				/// <exclude/>
				public LocaleBuilder WithCountry(Country value)
		        {
		            if(this.Country!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Country = value;
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public LocaleBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public LocaleBuilder WithDeniedPermission(Permission value)
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
				public LocaleBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class Locales : global::Allors.ObjectsBase<Locale>
	{
		public static readonly LocaleMeta Meta = LocaleMeta.Instance;

		public Locales(Allors.ISession session) : base(session)
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