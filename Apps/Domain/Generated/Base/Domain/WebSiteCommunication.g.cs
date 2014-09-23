// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class WebSiteCommunication
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (WebSiteCommunicationBuilder)objectBuilder;
			

			if(builder.ScheduledStart.HasValue)
			{
				this.ScheduledStart = builder.ScheduledStart.Value;
			}			
					

			if(builder.InitialScheduledStartDate.HasValue)
			{
				this.InitialScheduledStartDate = builder.InitialScheduledStartDate.Value;
			}			
		

			this.Description = builder.Description;
		

			this.Subject = builder.Subject;
					

			if(builder.ActualStart.HasValue)
			{
				this.ActualStart = builder.ActualStart.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
		

			this.Comment = builder.Comment;
					

			if(builder.UniqueId.HasValue)
			{
				this.UniqueId = builder.UniqueId.Value;
			}			
		

			this.Originator = builder.Originator;



			this.Receiver = builder.Receiver;


			if(builder.CommunicationEventStatuses!=null)
			{
				this.CommunicationEventStatuses = builder.CommunicationEventStatuses.ToArray();
			}

			if(builder.InvolvedParties!=null)
			{
				this.InvolvedParties = builder.InvolvedParties.ToArray();
			}


			this.CurrentObjectState = builder.CurrentObjectState;


			if(builder.EventPurposes!=null)
			{
				this.EventPurposes = builder.EventPurposes.ToArray();
			}

			if(builder.WorkEfforts!=null)
			{
				this.WorkEfforts = builder.WorkEfforts.ToArray();
			}


			this.PreviousObjectState = builder.PreviousObjectState;


			if(builder.Documents!=null)
			{
				this.Documents = builder.Documents.ToArray();
			}


			this.Case = builder.Case;



			this.Owner = builder.Owner;



			this.CurrentCommunicationEventStatus = builder.CurrentCommunicationEventStatus;


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

	public partial class WebSiteCommunicationBuilder : Allors.ObjectBuilder<WebSiteCommunication> , CommunicationEventBuilder, global::System.IDisposable
	{		
		public WebSiteCommunicationBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public Party Originator {get; set;}

				/// <exclude/>
				public WebSiteCommunicationBuilder WithOriginator(Party value)
		        {
		            if(this.Originator!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Originator = value;
		            return this;
		        }		

				
				public Party Receiver {get; set;}

				/// <exclude/>
				public WebSiteCommunicationBuilder WithReceiver(Party value)
		        {
		            if(this.Receiver!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Receiver = value;
		            return this;
		        }		

				
				public global::System.DateTime? ScheduledStart {get; set;}

				/// <exclude/>
				public WebSiteCommunicationBuilder WithScheduledStart(global::System.DateTime? value)
		        {
				    if(this.ScheduledStart!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ScheduledStart = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<CommunicationEventStatus> CommunicationEventStatuses {get; set;}	

				/// <exclude/>
				public WebSiteCommunicationBuilder WithCommunicationEventStatus(CommunicationEventStatus value)
		        {
					if(this.CommunicationEventStatuses == null)
					{
						this.CommunicationEventStatuses = new global::System.Collections.Generic.List<CommunicationEventStatus>(); 
					}
		            this.CommunicationEventStatuses.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<Party> InvolvedParties {get; set;}	

				/// <exclude/>
				public WebSiteCommunicationBuilder WithInvolvedParty(Party value)
		        {
					if(this.InvolvedParties == null)
					{
						this.InvolvedParties = new global::System.Collections.Generic.List<Party>(); 
					}
		            this.InvolvedParties.Add(value);
		            return this;
		        }		

				
				public global::System.DateTime? InitialScheduledStartDate {get; set;}

				/// <exclude/>
				public WebSiteCommunicationBuilder WithInitialScheduledStartDate(global::System.DateTime? value)
		        {
				    if(this.InitialScheduledStartDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.InitialScheduledStartDate = value;
		            return this;
		        }	

				public CommunicationEventObjectState CurrentObjectState {get; set;}

				/// <exclude/>
				public WebSiteCommunicationBuilder WithCurrentObjectState(CommunicationEventObjectState value)
		        {
		            if(this.CurrentObjectState!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.CurrentObjectState = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<CommunicationEventPurpose> EventPurposes {get; set;}	

				/// <exclude/>
				public WebSiteCommunicationBuilder WithEventPurpose(CommunicationEventPurpose value)
		        {
					if(this.EventPurposes == null)
					{
						this.EventPurposes = new global::System.Collections.Generic.List<CommunicationEventPurpose>(); 
					}
		            this.EventPurposes.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<WorkEffort> WorkEfforts {get; set;}	

				/// <exclude/>
				public WebSiteCommunicationBuilder WithWorkEffort(WorkEffort value)
		        {
					if(this.WorkEfforts == null)
					{
						this.WorkEfforts = new global::System.Collections.Generic.List<WorkEffort>(); 
					}
		            this.WorkEfforts.Add(value);
		            return this;
		        }		

				
				public global::System.String Description {get; set;}

				/// <exclude/>
				public WebSiteCommunicationBuilder WithDescription(global::System.String value)
		        {
				    if(this.Description!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Description = value;
		            return this;
		        }	

				public global::System.String Subject {get; set;}

				/// <exclude/>
				public WebSiteCommunicationBuilder WithSubject(global::System.String value)
		        {
				    if(this.Subject!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Subject = value;
		            return this;
		        }	

				public CommunicationEventObjectState PreviousObjectState {get; set;}

				/// <exclude/>
				public WebSiteCommunicationBuilder WithPreviousObjectState(CommunicationEventObjectState value)
		        {
		            if(this.PreviousObjectState!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.PreviousObjectState = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<Media> Documents {get; set;}	

				/// <exclude/>
				public WebSiteCommunicationBuilder WithDocument(Media value)
		        {
					if(this.Documents == null)
					{
						this.Documents = new global::System.Collections.Generic.List<Media>(); 
					}
		            this.Documents.Add(value);
		            return this;
		        }		

				
				public Case Case {get; set;}

				/// <exclude/>
				public WebSiteCommunicationBuilder WithCase(Case value)
		        {
		            if(this.Case!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Case = value;
		            return this;
		        }		

				
				public Person Owner {get; set;}

				/// <exclude/>
				public WebSiteCommunicationBuilder WithOwner(Person value)
		        {
		            if(this.Owner!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Owner = value;
		            return this;
		        }		

				
				public CommunicationEventStatus CurrentCommunicationEventStatus {get; set;}

				/// <exclude/>
				public WebSiteCommunicationBuilder WithCurrentCommunicationEventStatus(CommunicationEventStatus value)
		        {
		            if(this.CurrentCommunicationEventStatus!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.CurrentCommunicationEventStatus = value;
		            return this;
		        }		

				
				public global::System.DateTime? ActualStart {get; set;}

				/// <exclude/>
				public WebSiteCommunicationBuilder WithActualStart(global::System.DateTime? value)
		        {
				    if(this.ActualStart!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ActualStart = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public WebSiteCommunicationBuilder WithDeniedPermission(Permission value)
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
				public WebSiteCommunicationBuilder WithSecurityToken(SecurityToken value)
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
				public WebSiteCommunicationBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public SearchData SearchData {get; set;}

				/// <exclude/>
				public WebSiteCommunicationBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				
				public global::System.String Comment {get; set;}

				/// <exclude/>
				public WebSiteCommunicationBuilder WithComment(global::System.String value)
		        {
				    if(this.Comment!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Comment = value;
		            return this;
		        }	

				public global::System.Guid? UniqueId {get; set;}

				/// <exclude/>
				public WebSiteCommunicationBuilder WithUniqueId(global::System.Guid? value)
		        {
				    if(this.UniqueId!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UniqueId = value;
		            return this;
		        }	


	}

	public partial class WebSiteCommunications : global::Allors.ObjectsBase<WebSiteCommunication>
	{
		public static readonly WebSiteCommunicationMeta Meta = WebSiteCommunicationMeta.Instance;

		public WebSiteCommunications(Allors.ISession session) : base(session)
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