// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class Amortization
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (AmortizationBuilder)objectBuilder;

			this.Description = builder.Description;
					

			if(builder.TransactionDate.HasValue)
			{
				this.TransactionDate = builder.TransactionDate.Value;
			}			
					

			if(builder.DerivedTotalAmount.HasValue)
			{
				this.DerivedTotalAmount = builder.DerivedTotalAmount.Value;
			}			
					

			if(builder.EntryDate.HasValue)
			{
				this.EntryDate = builder.EntryDate.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
		

			this.InternalOrganisation = builder.InternalOrganisation;


			if(builder.AccountingTransactionDetails!=null)
			{
				this.AccountingTransactionDetails = builder.AccountingTransactionDetails.ToArray();
			}


			this.AccountingTransactionNumber = builder.AccountingTransactionNumber;


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

	public partial class AmortizationBuilder : Allors.ObjectBuilder<Amortization> , InternalAccountingTransactionBuilder, global::System.IDisposable
	{		
		public AmortizationBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public InternalOrganisation InternalOrganisation {get; set;}

				/// <exclude/>
				public AmortizationBuilder WithInternalOrganisation(InternalOrganisation value)
		        {
		            if(this.InternalOrganisation!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.InternalOrganisation = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<AccountingTransactionDetail> AccountingTransactionDetails {get; set;}	

				/// <exclude/>
				public AmortizationBuilder WithAccountingTransactionDetail(AccountingTransactionDetail value)
		        {
					if(this.AccountingTransactionDetails == null)
					{
						this.AccountingTransactionDetails = new global::System.Collections.Generic.List<AccountingTransactionDetail>(); 
					}
		            this.AccountingTransactionDetails.Add(value);
		            return this;
		        }		

				
				public global::System.String Description {get; set;}

				/// <exclude/>
				public AmortizationBuilder WithDescription(global::System.String value)
		        {
				    if(this.Description!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Description = value;
		            return this;
		        }	

				public global::System.DateTime? TransactionDate {get; set;}

				/// <exclude/>
				public AmortizationBuilder WithTransactionDate(global::System.DateTime? value)
		        {
				    if(this.TransactionDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.TransactionDate = value;
		            return this;
		        }	

				public global::System.Decimal? DerivedTotalAmount {get; set;}

				/// <exclude/>
				public AmortizationBuilder WithDerivedTotalAmount(global::System.Decimal? value)
		        {
				    if(this.DerivedTotalAmount!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DerivedTotalAmount = value;
		            return this;
		        }	

				public AccountingTransactionNumber AccountingTransactionNumber {get; set;}

				/// <exclude/>
				public AmortizationBuilder WithAccountingTransactionNumber(AccountingTransactionNumber value)
		        {
		            if(this.AccountingTransactionNumber!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.AccountingTransactionNumber = value;
		            return this;
		        }		

				
				public global::System.DateTime? EntryDate {get; set;}

				/// <exclude/>
				public AmortizationBuilder WithEntryDate(global::System.DateTime? value)
		        {
				    if(this.EntryDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.EntryDate = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public AmortizationBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public AmortizationBuilder WithDeniedPermission(Permission value)
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
				public AmortizationBuilder WithSecurityToken(SecurityToken value)
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
				public AmortizationBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				

	}

	public partial class Amortizations : global::Allors.ObjectsBase<Amortization>
	{
		public static readonly AmortizationMeta Meta = AmortizationMeta.Instance;

		public Amortizations(Allors.ISession session) : base(session)
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