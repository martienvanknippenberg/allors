// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class TelecommunicationsNumber
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (TelecommunicationsNumberBuilder)objectBuilder;

			this.AreaCode = builder.AreaCode;
		

			this.CountryCode = builder.CountryCode;
		

			this.ContactNumber = builder.ContactNumber;
		

			this.Description = builder.Description;
		

			this.DisplayName = builder.DisplayName;
		
			if(builder.FollowTo!=null)
			{
				this.FollowTo = builder.FollowTo.ToArray();
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


		}
	}

	public partial class TelecommunicationsNumberBuilder : Allors.ObjectBuilder<TelecommunicationsNumber> , ContactMechanismBuilder, global::System.IDisposable
	{		
		public TelecommunicationsNumberBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.String AreaCode {get; set;}

				/// <exclude/>
				public TelecommunicationsNumberBuilder WithAreaCode(global::System.String value)
		        {
				    if(this.AreaCode!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.AreaCode = value;
		            return this;
		        }	

				public global::System.String CountryCode {get; set;}

				/// <exclude/>
				public TelecommunicationsNumberBuilder WithCountryCode(global::System.String value)
		        {
				    if(this.CountryCode!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.CountryCode = value;
		            return this;
		        }	

				public global::System.String ContactNumber {get; set;}

				/// <exclude/>
				public TelecommunicationsNumberBuilder WithContactNumber(global::System.String value)
		        {
				    if(this.ContactNumber!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ContactNumber = value;
		            return this;
		        }	

				public global::System.String Description {get; set;}

				/// <exclude/>
				public TelecommunicationsNumberBuilder WithDescription(global::System.String value)
		        {
				    if(this.Description!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Description = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<ContactMechanism> FollowTo {get; set;}	

				/// <exclude/>
				public TelecommunicationsNumberBuilder WithFollowTo(ContactMechanism value)
		        {
					if(this.FollowTo == null)
					{
						this.FollowTo = new global::System.Collections.Generic.List<ContactMechanism>(); 
					}
		            this.FollowTo.Add(value);
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public TelecommunicationsNumberBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public TelecommunicationsNumberBuilder WithDeniedPermission(Permission value)
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
				public TelecommunicationsNumberBuilder WithSecurityToken(SecurityToken value)
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
				public TelecommunicationsNumberBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				

	}

	public partial class TelecommunicationsNumbers : global::Allors.ObjectsBase<TelecommunicationsNumber>
	{
		public static readonly TelecommunicationsNumberMeta Meta = TelecommunicationsNumberMeta.Instance;

		public TelecommunicationsNumbers(Allors.ISession session) : base(session)
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