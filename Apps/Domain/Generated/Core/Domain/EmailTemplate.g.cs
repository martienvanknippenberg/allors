// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class EmailTemplate : Allors.ObjectBase , UserInterfaceable
	{
		public static readonly EmailTemplateMeta Meta = EmailTemplateMeta.Instance;

		public EmailTemplate(Allors.IStrategy allors) : base(allors) {}

		public static EmailTemplate Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (EmailTemplate) allorsSession.Instantiate(allorsObjectId);		
		}




		virtual public global::System.String Description 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.Description);
			}
			set
			{
				Strategy.SetUnitRole(Meta.Description, value);
			}
		}

		virtual public bool ExistDescription{
			get
			{
				return Strategy.ExistUnitRole(Meta.Description);
			}
		}

		virtual public void RemoveDescription()
		{
			Strategy.RemoveUnitRole(Meta.Description);
		}



		virtual public global::System.String BodyTemplate 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.BodyTemplate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.BodyTemplate, value);
			}
		}

		virtual public bool ExistBodyTemplate{
			get
			{
				return Strategy.ExistUnitRole(Meta.BodyTemplate);
			}
		}

		virtual public void RemoveBodyTemplate()
		{
			Strategy.RemoveUnitRole(Meta.BodyTemplate);
		}



		virtual public global::System.String SubjectTemplate 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(Meta.SubjectTemplate);
			}
			set
			{
				Strategy.SetUnitRole(Meta.SubjectTemplate, value);
			}
		}

		virtual public bool ExistSubjectTemplate{
			get
			{
				return Strategy.ExistUnitRole(Meta.SubjectTemplate);
			}
		}

		virtual public void RemoveSubjectTemplate()
		{
			Strategy.RemoveUnitRole(Meta.SubjectTemplate);
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



		virtual public global::Allors.Extent<EmailCommunication> EmailCommunicationsWhereEmailTemplate
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.EmailCommunicationsWhereEmailTemplate);
			}
		}

		virtual public bool ExistEmailCommunicationsWhereEmailTemplate
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.EmailCommunicationsWhereEmailTemplate);
			}
		}

	}

	public class EmailTemplateMeta
	{
		public static readonly EmailTemplateMeta Instance = new EmailTemplateMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.EmailTemplate;

		public global::Allors.Meta.RoleType Description 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EmailTemplateDescription;
			}
		} 
		public global::Allors.Meta.RoleType BodyTemplate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EmailTemplateBodyTemplate;
			}
		} 
		public global::Allors.Meta.RoleType SubjectTemplate 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.EmailTemplateSubjectTemplate;
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

		public global::Allors.Meta.AssociationType EmailCommunicationsWhereEmailTemplate 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.EmailCommunicationEmailTemplate;
			}
		} 

	}
}