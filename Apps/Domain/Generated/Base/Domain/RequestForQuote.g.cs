// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class RequestForQuote
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (RequestForQuoteBuilder)objectBuilder;

			this.Description = builder.Description;
					

			if(builder.RequiredResponseDate.HasValue)
			{
				this.RequiredResponseDate = builder.RequiredResponseDate.Value;
			}			
		

			this.RequestNumber = builder.RequestNumber;
		

			this.DisplayName = builder.DisplayName;
		

			this.Comment = builder.Comment;
		
			if(builder.RequestItems!=null)
			{
				this.RequestItems = builder.RequestItems.ToArray();
			}

			if(builder.RespondingParties!=null)
			{
				this.RespondingParties = builder.RespondingParties.ToArray();
			}


			this.Originator = builder.Originator;


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

	public partial class RequestForQuoteBuilder : Allors.ObjectBuilder<RequestForQuote> , RequestBuilder, global::System.IDisposable
	{		
		public RequestForQuoteBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.String Description {get; set;}

				/// <exclude/>
				public RequestForQuoteBuilder WithDescription(global::System.String value)
		        {
				    if(this.Description!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Description = value;
		            return this;
		        }	

				public global::System.DateTime? RequiredResponseDate {get; set;}

				/// <exclude/>
				public RequestForQuoteBuilder WithRequiredResponseDate(global::System.DateTime? value)
		        {
				    if(this.RequiredResponseDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.RequiredResponseDate = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<RequestItem> RequestItems {get; set;}	

				/// <exclude/>
				public RequestForQuoteBuilder WithRequestItem(RequestItem value)
		        {
					if(this.RequestItems == null)
					{
						this.RequestItems = new global::System.Collections.Generic.List<RequestItem>(); 
					}
		            this.RequestItems.Add(value);
		            return this;
		        }		

				
				public global::System.String RequestNumber {get; set;}

				/// <exclude/>
				public RequestForQuoteBuilder WithRequestNumber(global::System.String value)
		        {
				    if(this.RequestNumber!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.RequestNumber = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<RespondingParty> RespondingParties {get; set;}	

				/// <exclude/>
				public RequestForQuoteBuilder WithRespondingParty(RespondingParty value)
		        {
					if(this.RespondingParties == null)
					{
						this.RespondingParties = new global::System.Collections.Generic.List<RespondingParty>(); 
					}
		            this.RespondingParties.Add(value);
		            return this;
		        }		

				
				public Party Originator {get; set;}

				/// <exclude/>
				public RequestForQuoteBuilder WithOriginator(Party value)
		        {
		            if(this.Originator!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Originator = value;
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public RequestForQuoteBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public RequestForQuoteBuilder WithDeniedPermission(Permission value)
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
				public RequestForQuoteBuilder WithSecurityToken(SecurityToken value)
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
				public RequestForQuoteBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				
				public global::System.String Comment {get; set;}

				/// <exclude/>
				public RequestForQuoteBuilder WithComment(global::System.String value)
		        {
				    if(this.Comment!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Comment = value;
		            return this;
		        }	


	}

	public partial class RequestsForQuote : global::Allors.ObjectsBase<RequestForQuote>
	{
		public static readonly RequestForQuoteMeta Meta = RequestForQuoteMeta.Instance;

		public RequestsForQuote(Allors.ISession session) : base(session)
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