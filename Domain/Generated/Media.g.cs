// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	[System.Diagnostics.DebuggerNonUserCode]
	public partial class Media : Allors.ObjectBase , UniquelyIdentifiable, UserInterfaceable
	{
		public static readonly MediaMeta Meta = MediaMeta.Instance;

		public Media(Allors.IStrategy allors) : base(allors) {}

		public static Media Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (Media) allorsSession.Instantiate(allorsObjectId);		
		}



		virtual public MediaType MediaType
		{ 
			get
			{
				return (MediaType) Strategy.GetCompositeRole(Meta.MediaType);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.MediaType ,value);
			}
		}

		virtual public bool ExistMediaType
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.MediaType);
			}
		}

		virtual public void RemoveMediaType()
		{
			Strategy.RemoveCompositeRole(Meta.MediaType);
		}


		virtual public MediaContent MediaContent
		{ 
			get
			{
				return (MediaContent) Strategy.GetCompositeRole(Meta.MediaContent);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.MediaContent ,value);
			}
		}

		virtual public bool ExistMediaContent
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.MediaContent);
			}
		}

		virtual public void RemoveMediaContent()
		{
			Strategy.RemoveCompositeRole(Meta.MediaContent);
		}



		virtual public global::System.Guid? UniqueId 
		{
			get
			{
				return (global::System.Guid?) Strategy.GetUnitRole(Meta.UniqueId);
			}
			set
			{
				Strategy.SetUnitRole(Meta.UniqueId, value);
			}
		}

		virtual public bool ExistUniqueId{
			get
			{
				return Strategy.ExistUnitRole(Meta.UniqueId);
			}
		}

		virtual public void RemoveUniqueId()
		{
			Strategy.RemoveUnitRole(Meta.UniqueId);
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



		virtual public global::Allors.Extent<Image> ImagesWhereOriginal
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.ImagesWhereOriginal);
			}
		}

		virtual public bool ExistImagesWhereOriginal
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.ImagesWhereOriginal);
			}
		}


		virtual public Image ImageWhereResponsive
		{ 
			get
			{
				return (Image) Strategy.GetCompositeAssociation(Meta.ImageWhereResponsive);
			}
		} 

		virtual public bool ExistImageWhereResponsive
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.ImageWhereResponsive);
			}
		}


		virtual public global::Allors.Extent<Organisation> OrganisationsWhereLogo
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.OrganisationsWhereLogo);
			}
		}

		virtual public bool ExistOrganisationsWhereLogo
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.OrganisationsWhereLogo);
			}
		}


		virtual public global::Allors.Extent<Person> PersonsWherePhoto
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.PersonsWherePhoto);
			}
		}

		virtual public bool ExistPersonsWherePhoto
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.PersonsWherePhoto);
			}
		}

	}

	public class MediaMeta
	{
		public static readonly MediaMeta Instance = new MediaMeta();

		public global::Allors.Meta.Class ObjectType = global::Allors.Meta.Classes.Media;

		public global::Allors.Meta.RoleType MediaType 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.MediaMediaType;
			}
		} 
		public global::Allors.Meta.RoleType MediaContent 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.MediaMediaContent;
			}
		} 
		public global::Allors.Meta.RoleType UniqueId 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.UniquelyIdentifiableUniqueId;
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

		public global::Allors.Meta.AssociationType ImagesWhereOriginal 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ImageOriginal;
			}
		} 
		public global::Allors.Meta.AssociationType ImageWhereResponsive 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ImageResponsive;
			}
		} 
		public global::Allors.Meta.AssociationType OrganisationsWhereLogo 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.OrganisationLogo;
			}
		} 
		public global::Allors.Meta.AssociationType PersonsWherePhoto 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.PersonPhoto;
			}
		} 

	}


	public partial class MediaBuilder : Allors.ObjectBuilder<Media> , UniquelyIdentifiableBuilder, UserInterfaceableBuilder, global::System.IDisposable
	{		
		public MediaBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public MediaType MediaType {get; set;}

				/// <exclude/>
				public MediaBuilder WithMediaType(MediaType value)
		        {
		            if(this.MediaType!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.MediaType = value;
		            return this;
		        }		

				
				public MediaContent MediaContent {get; set;}

				/// <exclude/>
				public MediaBuilder WithMediaContent(MediaContent value)
		        {
		            if(this.MediaContent!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.MediaContent = value;
		            return this;
		        }		

				
				public global::System.Guid? UniqueId {get; set;}

				/// <exclude/>
				public MediaBuilder WithUniqueId(global::System.Guid? value)
		        {
				    if(this.UniqueId!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UniqueId = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public MediaBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermission {get; set;}	

				/// <exclude/>
				public MediaBuilder WithDeniedPermission(Permission value)
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
				public MediaBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityToken == null)
					{
						this.SecurityToken = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityToken.Add(value);
		            return this;
		        }		

				

	}

	public partial class Medias : global::Allors.ObjectsBase<Media>
	{
		public static readonly MediaMeta Meta = MediaMeta.Instance;

		public Medias(Allors.ISession session) : base(session)
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