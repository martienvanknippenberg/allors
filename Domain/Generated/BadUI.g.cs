// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class BadUI : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly BadUIMeta Meta = BadUIMeta.Instance;

		public BadUI(Allors.IStrategy allors) : base(allors) {}

		public static BadUI Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (BadUI) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public global::Allors.Extent<Person> PersonsMany
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.PersonMany);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.PersonMany, value);
			}
		}

		virtual public void AddPersonMany (Person value)
		{
			Strategy.AddCompositeRole(Meta.PersonMany, value);
		}

		virtual public void RemovePersonMany (Person value)
		{
			Strategy.RemoveCompositeRole(Meta.PersonMany,value);
		}

		virtual public bool ExistPersonsMany
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.PersonMany);
			}
		}

		virtual public void RemovePersonsMany()
		{
			Strategy.RemoveCompositeRoles(Meta.PersonMany);
		}


		virtual public Organisation CompanyOne
		{ 
			get
			{
				return (Organisation) Strategy.GetCompositeRole(Meta.CompanyOne);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.CompanyOne ,value);
			}
		}

		virtual public bool ExistCompanyOne
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.CompanyOne);
			}
		}

		virtual public void RemoveCompanyOne()
		{
			Strategy.RemoveCompositeRole(Meta.CompanyOne);
		}


		virtual public Person PersonOne
		{ 
			get
			{
				return (Person) Strategy.GetCompositeRole(Meta.PersonOne);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.PersonOne ,value);
			}
		}

		virtual public bool ExistPersonOne
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.PersonOne);
			}
		}

		virtual public void RemovePersonOne()
		{
			Strategy.RemoveCompositeRole(Meta.PersonOne);
		}


		virtual public Organisation CompanyMany
		{ 
			get
			{
				return (Organisation) Strategy.GetCompositeRole(Meta.CompanyMany);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.CompanyMany ,value);
			}
		}

		virtual public bool ExistCompanyMany
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.CompanyMany);
			}
		}

		virtual public void RemoveCompanyMany()
		{
			Strategy.RemoveCompositeRole(Meta.CompanyMany);
		}



		virtual public global::System.String AllorsString 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.AllorsString);
			}
			set
			{
				Strategy.SetUnitRole(Meta.AllorsString, value);
			}
		}

		virtual public bool ExistAllorsString{
			get
			{
				return Strategy.ExistUnitRole(Meta.AllorsString);
			}
		}

		virtual public void RemoveAllorsString()
		{
			Strategy.RemoveUnitRole(Meta.AllorsString);
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

	}

	public class BadUIMeta
	{
		public static readonly BadUIMeta Instance = new BadUIMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.BadUI;

		public global::Allors.Meta.RoleType PersonMany 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BadUIPersonMany;
			}
		} 
		public global::Allors.Meta.RoleType CompanyOne 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BadUICompanyOne;
			}
		} 
		public global::Allors.Meta.RoleType PersonOne 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BadUIPersonOne;
			}
		} 
		public global::Allors.Meta.RoleType CompanyMany 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BadUICompanyMany;
			}
		} 
		public global::Allors.Meta.RoleType AllorsString 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.BadUIAllorsString;
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

	}


	public partial class BadUIBuilder : Allors.ObjectBuilder<BadUI> , UserInterfaceableBuilder, global::System.IDisposable
	{		
		public BadUIBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.Collections.Generic.List<Person> PersonMany {get; set;}	

				/// <exclude/>
				public BadUIBuilder WithPersonMany(Person value)
		        {
					if(this.PersonMany == null)
					{
						this.PersonMany = new global::System.Collections.Generic.List<Person>(); 
					}
		            this.PersonMany.Add(value);
		            return this;
		        }		

				
				public Organisation CompanyOne {get; set;}

				/// <exclude/>
				public BadUIBuilder WithCompanyOne(Organisation value)
		        {
		            if(this.CompanyOne!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.CompanyOne = value;
		            return this;
		        }		

				
				public Person PersonOne {get; set;}

				/// <exclude/>
				public BadUIBuilder WithPersonOne(Person value)
		        {
		            if(this.PersonOne!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.PersonOne = value;
		            return this;
		        }		

				
				public Organisation CompanyMany {get; set;}

				/// <exclude/>
				public BadUIBuilder WithCompanyMany(Organisation value)
		        {
		            if(this.CompanyMany!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.CompanyMany = value;
		            return this;
		        }		

				
				public global::System.String AllorsString {get; set;}

				/// <exclude/>
				public BadUIBuilder WithAllorsString(global::System.String value)
		        {
				    if(this.AllorsString!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.AllorsString = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public BadUIBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermission {get; set;}	

				/// <exclude/>
				public BadUIBuilder WithDeniedPermission(Permission value)
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
				public BadUIBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityToken == null)
					{
						this.SecurityToken = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityToken.Add(value);
		            return this;
		        }		

				

	}

	public partial class BadUIs : global::Allors.ObjectsBase<BadUI>
	{
		public static readonly BadUIMeta Meta = BadUIMeta.Instance;

		public BadUIs(Allors.ISession session) : base(session)
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