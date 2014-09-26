// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class PurchaseAgreement
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (PurchaseAgreementBuilder)objectBuilder;
			

			if(builder.AgreementDate.HasValue)
			{
				this.AgreementDate = builder.AgreementDate.Value;
			}			
		

			this.Description = builder.Description;
		

			this.Text = builder.Text;
		

			this.AgreementNumber = builder.AgreementNumber;
		

			this.DisplayName = builder.DisplayName;
					

			if(builder.UniqueId.HasValue)
			{
				this.UniqueId = builder.UniqueId.Value;
			}			
					

			if(builder.FromDate.HasValue)
			{
				this.FromDate = builder.FromDate.Value;
			}			
					

			if(builder.ThroughDate.HasValue)
			{
				this.ThroughDate = builder.ThroughDate.Value;
			}			
		
			if(builder.Addenda!=null)
			{
				this.Addenda = builder.Addenda.ToArray();
			}

			if(builder.AgreementTerms!=null)
			{
				this.AgreementTerms = builder.AgreementTerms.ToArray();
			}

			if(builder.AgreementItems!=null)
			{
				this.AgreementItems = builder.AgreementItems.ToArray();
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

	public partial class PurchaseAgreementBuilder : Allors.ObjectBuilder<PurchaseAgreement> , AgreementBuilder, global::System.IDisposable
	{		
		public PurchaseAgreementBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.DateTime? AgreementDate {get; set;}

				/// <exclude/>
				public PurchaseAgreementBuilder WithAgreementDate(global::System.DateTime? value)
		        {
				    if(this.AgreementDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.AgreementDate = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Addendum> Addenda {get; set;}	

				/// <exclude/>
				public PurchaseAgreementBuilder WithAddendum(Addendum value)
		        {
					if(this.Addenda == null)
					{
						this.Addenda = new global::System.Collections.Generic.List<Addendum>(); 
					}
		            this.Addenda.Add(value);
		            return this;
		        }		

				
				public global::System.String Description {get; set;}

				/// <exclude/>
				public PurchaseAgreementBuilder WithDescription(global::System.String value)
		        {
				    if(this.Description!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Description = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<AgreementTerm> AgreementTerms {get; set;}	

				/// <exclude/>
				public PurchaseAgreementBuilder WithAgreementTerm(AgreementTerm value)
		        {
					if(this.AgreementTerms == null)
					{
						this.AgreementTerms = new global::System.Collections.Generic.List<AgreementTerm>(); 
					}
		            this.AgreementTerms.Add(value);
		            return this;
		        }		

				
				public global::System.String Text {get; set;}

				/// <exclude/>
				public PurchaseAgreementBuilder WithText(global::System.String value)
		        {
				    if(this.Text!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Text = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<AgreementItem> AgreementItems {get; set;}	

				/// <exclude/>
				public PurchaseAgreementBuilder WithAgreementItem(AgreementItem value)
		        {
					if(this.AgreementItems == null)
					{
						this.AgreementItems = new global::System.Collections.Generic.List<AgreementItem>(); 
					}
		            this.AgreementItems.Add(value);
		            return this;
		        }		

				
				public global::System.String AgreementNumber {get; set;}

				/// <exclude/>
				public PurchaseAgreementBuilder WithAgreementNumber(global::System.String value)
		        {
				    if(this.AgreementNumber!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.AgreementNumber = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public PurchaseAgreementBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public PurchaseAgreementBuilder WithDeniedPermission(Permission value)
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
				public PurchaseAgreementBuilder WithSecurityToken(SecurityToken value)
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
				public PurchaseAgreementBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				
				public global::System.Guid? UniqueId {get; set;}

				/// <exclude/>
				public PurchaseAgreementBuilder WithUniqueId(global::System.Guid? value)
		        {
				    if(this.UniqueId!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UniqueId = value;
		            return this;
		        }	

				public global::System.DateTime? FromDate {get; set;}

				/// <exclude/>
				public PurchaseAgreementBuilder WithFromDate(global::System.DateTime? value)
		        {
				    if(this.FromDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.FromDate = value;
		            return this;
		        }	

				public global::System.DateTime? ThroughDate {get; set;}

				/// <exclude/>
				public PurchaseAgreementBuilder WithThroughDate(global::System.DateTime? value)
		        {
				    if(this.ThroughDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ThroughDate = value;
		            return this;
		        }	


	}

	public partial class PurchaseAgreements : global::Allors.ObjectsBase<PurchaseAgreement>
	{
		public static readonly PurchaseAgreementMeta Meta = PurchaseAgreementMeta.Instance;

		public PurchaseAgreements(Allors.ISession session) : base(session)
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