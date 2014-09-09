// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
    using Allors.Meta;

    [System.Diagnostics.DebuggerNonUserCode]
	public partial class Language : Allors.ObjectBase , UserInterfaceable, Searchable
	{
		public static readonly LanguageMeta Meta = LanguageMeta.Instance;

		public Language(Allors.IStrategy allors) : base(allors) {}

		public static Language Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (Language) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.String Name 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Name);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Name, value);
			}
		}

		virtual public bool ExistName{
			get
			{
				return Strategy.ExistUnitRole(Meta.Name);
			}
		}

		virtual public void RemoveName()
		{
			Strategy.RemoveUnitRole(Meta.Name);
		}



		virtual public global::System.String IsoCode 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.IsoCode);
			}
			set
			{
				Strategy.SetUnitRole(Meta.IsoCode, value);
			}
		}

		virtual public bool ExistIsoCode{
			get
			{
				return Strategy.ExistUnitRole(Meta.IsoCode);
			}
		}

		virtual public void RemoveIsoCode()
		{
			Strategy.RemoveUnitRole(Meta.IsoCode);
		}


		virtual public global::Allors.Extent<LocalisedText> LocalisedNames
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.LocalisedName);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.LocalisedName, value);
			}
		}

		virtual public void AddLocalisedName (LocalisedText value)
		{
			Strategy.AddCompositeRole(Meta.LocalisedName, value);
		}

		virtual public void RemoveLocalisedName (LocalisedText value)
		{
			Strategy.RemoveCompositeRole(Meta.LocalisedName,value);
		}

		virtual public bool ExistLocalisedNames
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.LocalisedName);
			}
		}

		virtual public void RemoveLocalisedNames()
		{
			Strategy.RemoveCompositeRoles(Meta.LocalisedName);
		}



		virtual public global::System.String DisplayName 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.DisplayName);
			}
			set
			{
				Strategy.SetUnitRole(Meta.DisplayName, value);
			}
		}

		virtual public bool ExistDisplayName{
			get
			{
				return Strategy.ExistUnitRole(Meta.DisplayName);
			}
		}

		virtual public void RemoveDisplayName()
		{
			Strategy.RemoveUnitRole(Meta.DisplayName);
		}


		virtual public global::Allors.Extent<Permission> DeniedPermissions
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.DeniedPermission);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.DeniedPermission, value);
			}
		}

		virtual public void AddDeniedPermission (Permission value)
		{
			Strategy.AddCompositeRole(Meta.DeniedPermission, value);
		}

		virtual public void RemoveDeniedPermission (Permission value)
		{
			Strategy.RemoveCompositeRole(Meta.DeniedPermission,value);
		}

		virtual public bool ExistDeniedPermissions
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.DeniedPermission);
			}
		}

		virtual public void RemoveDeniedPermissions()
		{
			Strategy.RemoveCompositeRoles(Meta.DeniedPermission);
		}


		virtual public global::Allors.Extent<SecurityToken> SecurityTokens
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.SecurityToken);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.SecurityToken, value);
			}
		}

		virtual public void AddSecurityToken (SecurityToken value)
		{
			Strategy.AddCompositeRole(Meta.SecurityToken, value);
		}

		virtual public void RemoveSecurityToken (SecurityToken value)
		{
			Strategy.RemoveCompositeRole(Meta.SecurityToken,value);
		}

		virtual public bool ExistSecurityTokens
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.SecurityToken);
			}
		}

		virtual public void RemoveSecurityTokens()
		{
			Strategy.RemoveCompositeRoles(Meta.SecurityToken);
		}


		virtual public SearchData SearchData
		{ 
			get
			{
				return (SearchData) Strategy.GetCompositeRole(Meta.SearchData);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.SearchData ,value);
			}
		}

		virtual public bool ExistSearchData
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.SearchData);
			}
		}

		virtual public void RemoveSearchData()
		{
			Strategy.RemoveCompositeRole(Meta.SearchData);
		}



		virtual public global::Allors.Extent<Locale> LocalesWhereLanguage
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.LocalesWhereLanguage);
			}
		}

		virtual public bool ExistLocalesWhereLanguage
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.LocalesWhereLanguage);
			}
		}

	}

	public class LanguageMeta
	{
		public static readonly LanguageMeta Instance = new LanguageMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.Language;

		public global::Allors.Meta.RoleType Name 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.LanguageName;
			}
		} 
		public global::Allors.Meta.RoleType IsoCode 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.LanguageIsoCode;
			}
		} 
		public global::Allors.Meta.RoleType LocalisedName 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.LanguageLocalisedName;
			}
		} 
		public global::Allors.Meta.RoleType DisplayName 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UserInterfaceableDisplayName;
			}
		} 
		public global::Allors.Meta.RoleType DeniedPermission 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AccessControlledObjectDeniedPermission;
			}
		} 
		public global::Allors.Meta.RoleType SecurityToken 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AccessControlledObjectSecurityToken;
			}
		} 
		public global::Allors.Meta.RoleType SearchData 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.SearchableSearchData;
			}
		} 

		public global::Allors.Meta.AssociationType LocalesWhereLanguage 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.LocaleLanguage;
			}
		} 

	}


	public partial class LanguageBuilder : Allors.ObjectBuilder<Language> , UserInterfaceableBuilder, SearchableBuilder, global::System.IDisposable
	{		
		public LanguageBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.String Name {get; set;}

				/// <exclude/>
				public LanguageBuilder WithName(global::System.String value)
		        {
				    if(this.Name!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Name = value;
		            return this;
		        }	

				public global::System.String IsoCode {get; set;}

				/// <exclude/>
				public LanguageBuilder WithIsoCode(global::System.String value)
		        {
				    if(this.IsoCode!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.IsoCode = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<LocalisedText> LocalisedName {get; set;}	

				/// <exclude/>
				public LanguageBuilder WithLocalisedName(LocalisedText value)
		        {
					if(this.LocalisedName == null)
					{
						this.LocalisedName = new global::System.Collections.Generic.List<LocalisedText>(); 
					}
		            this.LocalisedName.Add(value);
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public LanguageBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermission {get; set;}	

				/// <exclude/>
				public LanguageBuilder WithDeniedPermission(Permission value)
		        {
					if(this.DeniedPermission == null)
					{
						this.DeniedPermission = new global::System.Collections.Generic.List<Permission>(); 
					}
		            this.DeniedPermission.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<SecurityToken> SecurityToken {get; set;}	

				/// <exclude/>
				public LanguageBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityToken == null)
					{
						this.SecurityToken = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityToken.Add(value);
		            return this;
		        }		

				
				public SearchData SearchData {get; set;}

				/// <exclude/>
				public LanguageBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				

	}

	public partial class Languages : global::Allors.ObjectsBase<Language>
	{
		public static readonly LanguageMeta Meta = LanguageMeta.Instance;

		public Languages(Allors.ISession session) : base(session)
		{
		}

		public override Composite ObjectType
		{
			get
			{
				return Meta.ObjectType;
			}
		}
	}

}