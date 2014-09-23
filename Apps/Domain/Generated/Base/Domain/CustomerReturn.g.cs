// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class CustomerReturn
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (CustomerReturnBuilder)objectBuilder;

			this.ShipmentNumber = builder.ShipmentNumber;
					

			if(builder.EstimatedShipCost.HasValue)
			{
				this.EstimatedShipCost = builder.EstimatedShipCost.Value;
			}			
					

			if(builder.EstimatedShipDate.HasValue)
			{
				this.EstimatedShipDate = builder.EstimatedShipDate.Value;
			}			
					

			if(builder.LatestCancelDate.HasValue)
			{
				this.LatestCancelDate = builder.LatestCancelDate.Value;
			}			
					

			if(builder.EstimatedReadyDate.HasValue)
			{
				this.EstimatedReadyDate = builder.EstimatedReadyDate.Value;
			}			
		

			this.HandlingInstruction = builder.HandlingInstruction;
					

			if(builder.EstimatedArrivalDate.HasValue)
			{
				this.EstimatedArrivalDate = builder.EstimatedArrivalDate.Value;
			}			
		

			this.PrintContent = builder.PrintContent;
		

			this.DisplayName = builder.DisplayName;
					

			if(builder.UniqueId.HasValue)
			{
				this.UniqueId = builder.UniqueId.Value;
			}			
		

			this.CurrentShipmentStatus = builder.CurrentShipmentStatus;



			this.PreviousObjectState = builder.PreviousObjectState;


			if(builder.ShipmentStatuses!=null)
			{
				this.ShipmentStatuses = builder.ShipmentStatuses.ToArray();
			}


			this.CurrentObjectState = builder.CurrentObjectState;



			this.ShipmentMethod = builder.ShipmentMethod;



			this.BillToContactMechanism = builder.BillToContactMechanism;


			if(builder.ShipmentPackages!=null)
			{
				this.ShipmentPackages = builder.ShipmentPackages.ToArray();
			}

			if(builder.Documents!=null)
			{
				this.Documents = builder.Documents.ToArray();
			}


			this.BillToParty = builder.BillToParty;



			this.ShipToParty = builder.ShipToParty;


			if(builder.ShipmentItems!=null)
			{
				this.ShipmentItems = builder.ShipmentItems.ToArray();
			}


			this.BillFromInternalOrganisation = builder.BillFromInternalOrganisation;



			this.ReceiverContactMechanism = builder.ReceiverContactMechanism;



			this.ShipToAddress = builder.ShipToAddress;



			this.Carrier = builder.Carrier;



			this.InquireAboutContactMechanism = builder.InquireAboutContactMechanism;



			this.ShipFromAddress = builder.ShipFromAddress;



			this.BillFromContactMechanism = builder.BillFromContactMechanism;



			this.Store = builder.Store;



			this.ShipFromParty = builder.ShipFromParty;


			if(builder.ShipmentRouteSegments!=null)
			{
				this.ShipmentRouteSegments = builder.ShipmentRouteSegments.ToArray();
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

	public partial class CustomerReturnBuilder : Allors.ObjectBuilder<CustomerReturn> , ShipmentBuilder, global::System.IDisposable
	{		
		public CustomerReturnBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public CustomerReturnStatus CurrentShipmentStatus {get; set;}

				/// <exclude/>
				public CustomerReturnBuilder WithCurrentShipmentStatus(CustomerReturnStatus value)
		        {
		            if(this.CurrentShipmentStatus!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.CurrentShipmentStatus = value;
		            return this;
		        }		

				
				public CustomerReturnObjectState PreviousObjectState {get; set;}

				/// <exclude/>
				public CustomerReturnBuilder WithPreviousObjectState(CustomerReturnObjectState value)
		        {
		            if(this.PreviousObjectState!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.PreviousObjectState = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<CustomerReturnStatus> ShipmentStatuses {get; set;}	

				/// <exclude/>
				public CustomerReturnBuilder WithShipmentStatus(CustomerReturnStatus value)
		        {
					if(this.ShipmentStatuses == null)
					{
						this.ShipmentStatuses = new global::System.Collections.Generic.List<CustomerReturnStatus>(); 
					}
		            this.ShipmentStatuses.Add(value);
		            return this;
		        }		

				
				public CustomerReturnObjectState CurrentObjectState {get; set;}

				/// <exclude/>
				public CustomerReturnBuilder WithCurrentObjectState(CustomerReturnObjectState value)
		        {
		            if(this.CurrentObjectState!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.CurrentObjectState = value;
		            return this;
		        }		

				
				public ShipmentMethod ShipmentMethod {get; set;}

				/// <exclude/>
				public CustomerReturnBuilder WithShipmentMethod(ShipmentMethod value)
		        {
		            if(this.ShipmentMethod!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.ShipmentMethod = value;
		            return this;
		        }		

				
				public ContactMechanism BillToContactMechanism {get; set;}

				/// <exclude/>
				public CustomerReturnBuilder WithBillToContactMechanism(ContactMechanism value)
		        {
		            if(this.BillToContactMechanism!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.BillToContactMechanism = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<ShipmentPackage> ShipmentPackages {get; set;}	

				/// <exclude/>
				public CustomerReturnBuilder WithShipmentPackage(ShipmentPackage value)
		        {
					if(this.ShipmentPackages == null)
					{
						this.ShipmentPackages = new global::System.Collections.Generic.List<ShipmentPackage>(); 
					}
		            this.ShipmentPackages.Add(value);
		            return this;
		        }		

				
				public global::System.String ShipmentNumber {get; set;}

				/// <exclude/>
				public CustomerReturnBuilder WithShipmentNumber(global::System.String value)
		        {
				    if(this.ShipmentNumber!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ShipmentNumber = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Document> Documents {get; set;}	

				/// <exclude/>
				public CustomerReturnBuilder WithDocument(Document value)
		        {
					if(this.Documents == null)
					{
						this.Documents = new global::System.Collections.Generic.List<Document>(); 
					}
		            this.Documents.Add(value);
		            return this;
		        }		

				
				public Party BillToParty {get; set;}

				/// <exclude/>
				public CustomerReturnBuilder WithBillToParty(Party value)
		        {
		            if(this.BillToParty!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.BillToParty = value;
		            return this;
		        }		

				
				public Party ShipToParty {get; set;}

				/// <exclude/>
				public CustomerReturnBuilder WithShipToParty(Party value)
		        {
		            if(this.ShipToParty!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.ShipToParty = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<ShipmentItem> ShipmentItems {get; set;}	

				/// <exclude/>
				public CustomerReturnBuilder WithShipmentItem(ShipmentItem value)
		        {
					if(this.ShipmentItems == null)
					{
						this.ShipmentItems = new global::System.Collections.Generic.List<ShipmentItem>(); 
					}
		            this.ShipmentItems.Add(value);
		            return this;
		        }		

				
				public InternalOrganisation BillFromInternalOrganisation {get; set;}

				/// <exclude/>
				public CustomerReturnBuilder WithBillFromInternalOrganisation(InternalOrganisation value)
		        {
		            if(this.BillFromInternalOrganisation!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.BillFromInternalOrganisation = value;
		            return this;
		        }		

				
				public ContactMechanism ReceiverContactMechanism {get; set;}

				/// <exclude/>
				public CustomerReturnBuilder WithReceiverContactMechanism(ContactMechanism value)
		        {
		            if(this.ReceiverContactMechanism!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.ReceiverContactMechanism = value;
		            return this;
		        }		

				
				public PostalAddress ShipToAddress {get; set;}

				/// <exclude/>
				public CustomerReturnBuilder WithShipToAddress(PostalAddress value)
		        {
		            if(this.ShipToAddress!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.ShipToAddress = value;
		            return this;
		        }		

				
				public global::System.Decimal? EstimatedShipCost {get; set;}

				/// <exclude/>
				public CustomerReturnBuilder WithEstimatedShipCost(global::System.Decimal? value)
		        {
				    if(this.EstimatedShipCost!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.EstimatedShipCost = value;
		            return this;
		        }	

				public global::System.DateTime? EstimatedShipDate {get; set;}

				/// <exclude/>
				public CustomerReturnBuilder WithEstimatedShipDate(global::System.DateTime? value)
		        {
				    if(this.EstimatedShipDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.EstimatedShipDate = value;
		            return this;
		        }	

				public global::System.DateTime? LatestCancelDate {get; set;}

				/// <exclude/>
				public CustomerReturnBuilder WithLatestCancelDate(global::System.DateTime? value)
		        {
				    if(this.LatestCancelDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.LatestCancelDate = value;
		            return this;
		        }	

				public Carrier Carrier {get; set;}

				/// <exclude/>
				public CustomerReturnBuilder WithCarrier(Carrier value)
		        {
		            if(this.Carrier!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Carrier = value;
		            return this;
		        }		

				
				public ContactMechanism InquireAboutContactMechanism {get; set;}

				/// <exclude/>
				public CustomerReturnBuilder WithInquireAboutContactMechanism(ContactMechanism value)
		        {
		            if(this.InquireAboutContactMechanism!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.InquireAboutContactMechanism = value;
		            return this;
		        }		

				
				public global::System.DateTime? EstimatedReadyDate {get; set;}

				/// <exclude/>
				public CustomerReturnBuilder WithEstimatedReadyDate(global::System.DateTime? value)
		        {
				    if(this.EstimatedReadyDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.EstimatedReadyDate = value;
		            return this;
		        }	

				public PostalAddress ShipFromAddress {get; set;}

				/// <exclude/>
				public CustomerReturnBuilder WithShipFromAddress(PostalAddress value)
		        {
		            if(this.ShipFromAddress!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.ShipFromAddress = value;
		            return this;
		        }		

				
				public ContactMechanism BillFromContactMechanism {get; set;}

				/// <exclude/>
				public CustomerReturnBuilder WithBillFromContactMechanism(ContactMechanism value)
		        {
		            if(this.BillFromContactMechanism!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.BillFromContactMechanism = value;
		            return this;
		        }		

				
				public global::System.String HandlingInstruction {get; set;}

				/// <exclude/>
				public CustomerReturnBuilder WithHandlingInstruction(global::System.String value)
		        {
				    if(this.HandlingInstruction!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.HandlingInstruction = value;
		            return this;
		        }	

				public Store Store {get; set;}

				/// <exclude/>
				public CustomerReturnBuilder WithStore(Store value)
		        {
		            if(this.Store!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Store = value;
		            return this;
		        }		

				
				public Party ShipFromParty {get; set;}

				/// <exclude/>
				public CustomerReturnBuilder WithShipFromParty(Party value)
		        {
		            if(this.ShipFromParty!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.ShipFromParty = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<ShipmentRouteSegment> ShipmentRouteSegments {get; set;}	

				/// <exclude/>
				public CustomerReturnBuilder WithShipmentRouteSegment(ShipmentRouteSegment value)
		        {
					if(this.ShipmentRouteSegments == null)
					{
						this.ShipmentRouteSegments = new global::System.Collections.Generic.List<ShipmentRouteSegment>(); 
					}
		            this.ShipmentRouteSegments.Add(value);
		            return this;
		        }		

				
				public global::System.DateTime? EstimatedArrivalDate {get; set;}

				/// <exclude/>
				public CustomerReturnBuilder WithEstimatedArrivalDate(global::System.DateTime? value)
		        {
				    if(this.EstimatedArrivalDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.EstimatedArrivalDate = value;
		            return this;
		        }	

				public global::System.String PrintContent {get; set;}

				/// <exclude/>
				public CustomerReturnBuilder WithPrintContent(global::System.String value)
		        {
				    if(this.PrintContent!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.PrintContent = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public CustomerReturnBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public CustomerReturnBuilder WithDeniedPermission(Permission value)
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
				public CustomerReturnBuilder WithSecurityToken(SecurityToken value)
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
				public CustomerReturnBuilder WithUniqueId(global::System.Guid? value)
		        {
				    if(this.UniqueId!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UniqueId = value;
		            return this;
		        }	

				public SearchData SearchData {get; set;}

				/// <exclude/>
				public CustomerReturnBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				

	}

	public partial class CustomerReturns : global::Allors.ObjectsBase<CustomerReturn>
	{
		public static readonly CustomerReturnMeta Meta = CustomerReturnMeta.Instance;

		public CustomerReturns(Allors.ISession session) : base(session)
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