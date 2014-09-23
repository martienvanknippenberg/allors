// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class Research
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (ResearchBuilder)objectBuilder;

			this.SpecialTerms = builder.SpecialTerms;
					

			if(builder.ActualHours.HasValue)
			{
				this.ActualHours = builder.ActualHours.Value;
			}			
		

			this.Description = builder.Description;
					

			if(builder.EstimatedHours.HasValue)
			{
				this.EstimatedHours = builder.EstimatedHours.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
					

			if(builder.UniqueId.HasValue)
			{
				this.UniqueId = builder.UniqueId.Value;
			}			
		

			this.CurrentWorkEffortStatus = builder.CurrentWorkEffortStatus;


			if(builder.Precendencies!=null)
			{
				this.Precendencies = builder.Precendencies.ToArray();
			}


			this.Facility = builder.Facility;


			if(builder.DeliverablesProduced!=null)
			{
				this.DeliverablesProduced = builder.DeliverablesProduced.ToArray();
			}

			if(builder.InventoryItemsNeeded!=null)
			{
				this.InventoryItemsNeeded = builder.InventoryItemsNeeded.ToArray();
			}

			if(builder.Children!=null)
			{
				this.Children = builder.Children.ToArray();
			}


			this.OrderItemFulfillment = builder.OrderItemFulfillment;


			if(builder.WorkEffortStatuses!=null)
			{
				this.WorkEffortStatuses = builder.WorkEffortStatuses.ToArray();
			}


			this.WorkEffortType = builder.WorkEffortType;


			if(builder.InventoryItemsProduced!=null)
			{
				this.InventoryItemsProduced = builder.InventoryItemsProduced.ToArray();
			}

			if(builder.RequirementFulfillments!=null)
			{
				this.RequirementFulfillments = builder.RequirementFulfillments.ToArray();
			}

			if(builder.Concurrencies!=null)
			{
				this.Concurrencies = builder.Concurrencies.ToArray();
			}


			this.PreviousObjectState = builder.PreviousObjectState;



			this.CurrentObjectState = builder.CurrentObjectState;



			this.SearchData = builder.SearchData;


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

	public partial class ResearchBuilder : Allors.ObjectBuilder<Research> , WorkEffortBuilder, global::System.IDisposable
	{		
		public ResearchBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public WorkEffortStatus CurrentWorkEffortStatus {get; set;}

				/// <exclude/>
				public ResearchBuilder WithCurrentWorkEffortStatus(WorkEffortStatus value)
		        {
		            if(this.CurrentWorkEffortStatus!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.CurrentWorkEffortStatus = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<WorkEffort> Precendencies {get; set;}	

				/// <exclude/>
				public ResearchBuilder WithPrecendency(WorkEffort value)
		        {
					if(this.Precendencies == null)
					{
						this.Precendencies = new global::System.Collections.Generic.List<WorkEffort>(); 
					}
		            this.Precendencies.Add(value);
		            return this;
		        }		

				
				public Facility Facility {get; set;}

				/// <exclude/>
				public ResearchBuilder WithFacility(Facility value)
		        {
		            if(this.Facility!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Facility = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<Deliverable> DeliverablesProduced {get; set;}	

				/// <exclude/>
				public ResearchBuilder WithDeliverableProduced(Deliverable value)
		        {
					if(this.DeliverablesProduced == null)
					{
						this.DeliverablesProduced = new global::System.Collections.Generic.List<Deliverable>(); 
					}
		            this.DeliverablesProduced.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<WorkEffortInventoryAssignment> InventoryItemsNeeded {get; set;}	

				/// <exclude/>
				public ResearchBuilder WithInventoryItemNeeded(WorkEffortInventoryAssignment value)
		        {
					if(this.InventoryItemsNeeded == null)
					{
						this.InventoryItemsNeeded = new global::System.Collections.Generic.List<WorkEffortInventoryAssignment>(); 
					}
		            this.InventoryItemsNeeded.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<WorkEffort> Children {get; set;}	

				/// <exclude/>
				public ResearchBuilder WithChild(WorkEffort value)
		        {
					if(this.Children == null)
					{
						this.Children = new global::System.Collections.Generic.List<WorkEffort>(); 
					}
		            this.Children.Add(value);
		            return this;
		        }		

				
				public OrderItem OrderItemFulfillment {get; set;}

				/// <exclude/>
				public ResearchBuilder WithOrderItemFulfillment(OrderItem value)
		        {
		            if(this.OrderItemFulfillment!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.OrderItemFulfillment = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<WorkEffortStatus> WorkEffortStatuses {get; set;}	

				/// <exclude/>
				public ResearchBuilder WithWorkEffortStatus(WorkEffortStatus value)
		        {
					if(this.WorkEffortStatuses == null)
					{
						this.WorkEffortStatuses = new global::System.Collections.Generic.List<WorkEffortStatus>(); 
					}
		            this.WorkEffortStatuses.Add(value);
		            return this;
		        }		

				
				public WorkEffortType WorkEffortType {get; set;}

				/// <exclude/>
				public ResearchBuilder WithWorkEffortType(WorkEffortType value)
		        {
		            if(this.WorkEffortType!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.WorkEffortType = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<InventoryItem> InventoryItemsProduced {get; set;}	

				/// <exclude/>
				public ResearchBuilder WithInventoryItemProduced(InventoryItem value)
		        {
					if(this.InventoryItemsProduced == null)
					{
						this.InventoryItemsProduced = new global::System.Collections.Generic.List<InventoryItem>(); 
					}
		            this.InventoryItemsProduced.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<Requirement> RequirementFulfillments {get; set;}	

				/// <exclude/>
				public ResearchBuilder WithRequirementFulfillment(Requirement value)
		        {
					if(this.RequirementFulfillments == null)
					{
						this.RequirementFulfillments = new global::System.Collections.Generic.List<Requirement>(); 
					}
		            this.RequirementFulfillments.Add(value);
		            return this;
		        }		

				
				public global::System.String SpecialTerms {get; set;}

				/// <exclude/>
				public ResearchBuilder WithSpecialTerms(global::System.String value)
		        {
				    if(this.SpecialTerms!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.SpecialTerms = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<WorkEffort> Concurrencies {get; set;}	

				/// <exclude/>
				public ResearchBuilder WithConcurrency(WorkEffort value)
		        {
					if(this.Concurrencies == null)
					{
						this.Concurrencies = new global::System.Collections.Generic.List<WorkEffort>(); 
					}
		            this.Concurrencies.Add(value);
		            return this;
		        }		

				
				public global::System.Decimal? ActualHours {get; set;}

				/// <exclude/>
				public ResearchBuilder WithActualHours(global::System.Decimal? value)
		        {
				    if(this.ActualHours!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ActualHours = value;
		            return this;
		        }	

				public global::System.String Description {get; set;}

				/// <exclude/>
				public ResearchBuilder WithDescription(global::System.String value)
		        {
				    if(this.Description!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Description = value;
		            return this;
		        }	

				public WorkEffortObjectState PreviousObjectState {get; set;}

				/// <exclude/>
				public ResearchBuilder WithPreviousObjectState(WorkEffortObjectState value)
		        {
		            if(this.PreviousObjectState!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.PreviousObjectState = value;
		            return this;
		        }		

				
				public WorkEffortObjectState CurrentObjectState {get; set;}

				/// <exclude/>
				public ResearchBuilder WithCurrentObjectState(WorkEffortObjectState value)
		        {
		            if(this.CurrentObjectState!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.CurrentObjectState = value;
		            return this;
		        }		

				
				public global::System.Decimal? EstimatedHours {get; set;}

				/// <exclude/>
				public ResearchBuilder WithEstimatedHours(global::System.Decimal? value)
		        {
				    if(this.EstimatedHours!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.EstimatedHours = value;
		            return this;
		        }	

				public SearchData SearchData {get; set;}

				/// <exclude/>
				public ResearchBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public ResearchBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public ResearchBuilder WithDeniedPermission(Permission value)
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
				public ResearchBuilder WithSecurityToken(SecurityToken value)
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
				public ResearchBuilder WithUniqueId(global::System.Guid? value)
		        {
				    if(this.UniqueId!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UniqueId = value;
		            return this;
		        }	


	}

	public partial class Researches : global::Allors.ObjectsBase<Research>
	{
		public static readonly ResearchMeta Meta = ResearchMeta.Instance;

		public Researches(Allors.ISession session) : base(session)
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