// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class AccessControl : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly AccessControlMeta Meta = AccessControlMeta.Instance;

		public AccessControl(Allors.IStrategy allors) : base(allors) {}

		public static AccessControl Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (AccessControl) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public global::Allors.Extent<UserGroup> SubjectGroups
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.SubjectGroup);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.SubjectGroup, value);
			}
		}

		virtual public void AddSubjectGroup (UserGroup value)
		{
			Strategy.AddCompositeRole(Meta.SubjectGroup, value);
		}

		virtual public void RemoveSubjectGroup (UserGroup value)
		{
			Strategy.RemoveCompositeRole(Meta.SubjectGroup,value);
		}

		virtual public bool ExistSubjectGroups
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.SubjectGroup);
			}
		}

		virtual public void RemoveSubjectGroups()
		{
			Strategy.RemoveCompositeRoles(Meta.SubjectGroup);
		}


		virtual public global::Allors.Extent<User> Subjects
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.Subject);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.Subject, value);
			}
		}

		virtual public void AddSubject (User value)
		{
			Strategy.AddCompositeRole(Meta.Subject, value);
		}

		virtual public void RemoveSubject (User value)
		{
			Strategy.RemoveCompositeRole(Meta.Subject,value);
		}

		virtual public bool ExistSubjects
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.Subject);
			}
		}

		virtual public void RemoveSubjects()
		{
			Strategy.RemoveCompositeRoles(Meta.Subject);
		}


		virtual public global::Allors.Extent<SecurityToken> Objects
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.Object);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.Object, value);
			}
		}

		virtual public void AddObject (SecurityToken value)
		{
			Strategy.AddCompositeRole(Meta.Object, value);
		}

		virtual public void RemoveObject (SecurityToken value)
		{
			Strategy.RemoveCompositeRole(Meta.Object,value);
		}

		virtual public bool ExistObjects
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.Object);
			}
		}

		virtual public void RemoveObjects()
		{
			Strategy.RemoveCompositeRoles(Meta.Object);
		}


		virtual public Role Role
		{ 
			get
			{
				return (Role) Strategy.GetCompositeRole(Meta.Role);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Role ,value);
			}
		}

		virtual public bool ExistRole
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Role);
			}
		}

		virtual public void RemoveRole()
		{
			Strategy.RemoveCompositeRole(Meta.Role);
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

	public class AccessControlMeta
	{
		public static readonly AccessControlMeta Instance = new AccessControlMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.AccessControl;

		public global::Allors.Meta.RoleType SubjectGroup 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AccessControlSubjectGroup;
			}
		} 
		public global::Allors.Meta.RoleType Subject 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AccessControlSubject;
			}
		} 
		public global::Allors.Meta.RoleType Object 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AccessControlObject;
			}
		} 
		public global::Allors.Meta.RoleType Role 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.AccessControlRole;
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


	public partial class AccessControlBuilder : Allors.ObjectBuilder<AccessControl> , UserInterfaceableBuilder, global::System.IDisposable
	{		
		public AccessControlBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.Collections.Generic.List<UserGroup> SubjectGroup {get; set;}	

				/// <exclude/>
				public AccessControlBuilder WithSubjectGroup(UserGroup value)
		        {
					if(this.SubjectGroup == null)
					{
						this.SubjectGroup = new global::System.Collections.Generic.List<UserGroup>(); 
					}
		            this.SubjectGroup.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<User> Subject {get; set;}	

				/// <exclude/>
				public AccessControlBuilder WithSubject(User value)
		        {
					if(this.Subject == null)
					{
						this.Subject = new global::System.Collections.Generic.List<User>(); 
					}
		            this.Subject.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<SecurityToken> Object {get; set;}	

				/// <exclude/>
				public AccessControlBuilder WithObject(SecurityToken value)
		        {
					if(this.Object == null)
					{
						this.Object = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.Object.Add(value);
		            return this;
		        }		

				
				public Role Role {get; set;}

				/// <exclude/>
				public AccessControlBuilder WithRole(Role value)
		        {
		            if(this.Role!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Role = value;
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public AccessControlBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermission {get; set;}	

				/// <exclude/>
				public AccessControlBuilder WithDeniedPermission(Permission value)
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
				public AccessControlBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityToken == null)
					{
						this.SecurityToken = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityToken.Add(value);
		            return this;
		        }		

				

	}

	public partial class AccessControls : global::Allors.ObjectsBase<AccessControl>
	{
		public static readonly AccessControlMeta Meta = AccessControlMeta.Instance;

		public AccessControls(Allors.ISession session) : base(session)
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