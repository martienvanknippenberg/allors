// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class AccountingTransactionDetail
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (AccountingTransactionDetailBuilder)objectBuilder;
			

			if(builder.Amount.HasValue)
			{
				this.Amount = builder.Amount.Value;
			}			
					

			if(builder.Debit.HasValue)
			{
				this.Debit = builder.Debit.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
		

			this.AssociatedWith = builder.AssociatedWith;



			this.OrganisationGlAccountBalance = builder.OrganisationGlAccountBalance;


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

	public partial class AccountingTransactionDetailBuilder : Allors.ObjectBuilder<AccountingTransactionDetail> , UserInterfaceableBuilder, global::System.IDisposable
	{		
		public AccountingTransactionDetailBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public AccountingTransactionDetail AssociatedWith {get; set;}

				/// <exclude/>
				public AccountingTransactionDetailBuilder WithAssociatedWith(AccountingTransactionDetail value)
		        {
		            if(this.AssociatedWith!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.AssociatedWith = value;
		            return this;
		        }		

				
				public OrganisationGlAccountBalance OrganisationGlAccountBalance {get; set;}

				/// <exclude/>
				public AccountingTransactionDetailBuilder WithOrganisationGlAccountBalance(OrganisationGlAccountBalance value)
		        {
		            if(this.OrganisationGlAccountBalance!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.OrganisationGlAccountBalance = value;
		            return this;
		        }		

				
				public global::System.Decimal? Amount {get; set;}

				/// <exclude/>
				public AccountingTransactionDetailBuilder WithAmount(global::System.Decimal? value)
		        {
				    if(this.Amount!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Amount = value;
		            return this;
		        }	

				public global::System.Boolean? Debit {get; set;}

				/// <exclude/>
				public AccountingTransactionDetailBuilder WithDebit(global::System.Boolean? value)
		        {
				    if(this.Debit!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Debit = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public AccountingTransactionDetailBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public AccountingTransactionDetailBuilder WithDeniedPermission(Permission value)
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
				public AccountingTransactionDetailBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class AccountingTransactionDetails : global::Allors.ObjectsBase<AccountingTransactionDetail>
	{
		public static readonly AccountingTransactionDetailMeta Meta = AccountingTransactionDetailMeta.Instance;

		public AccountingTransactionDetails(Allors.ISession session) : base(session)
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