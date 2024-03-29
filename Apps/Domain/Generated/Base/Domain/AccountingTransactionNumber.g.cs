// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class AccountingTransactionNumber
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (AccountingTransactionNumberBuilder)objectBuilder;
			

			if(builder.Number.HasValue)
			{
				this.Number = builder.Number.Value;
			}			
					

			if(builder.Year.HasValue)
			{
				this.Year = builder.Year.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
		

			this.AccountingTransactionType = builder.AccountingTransactionType;


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

	public partial class AccountingTransactionNumberBuilder : Allors.ObjectBuilder<AccountingTransactionNumber> , AccessControlledObjectBuilder, UserInterfaceableBuilder, global::System.IDisposable
	{		
		public AccountingTransactionNumberBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.Int64? Number {get; set;}

				/// <exclude/>
				public AccountingTransactionNumberBuilder WithNumber(global::System.Int64? value)
		        {
				    if(this.Number!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Number = value;
		            return this;
		        }	

				public global::System.Int32? Year {get; set;}

				/// <exclude/>
				public AccountingTransactionNumberBuilder WithYear(global::System.Int32? value)
		        {
				    if(this.Year!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Year = value;
		            return this;
		        }	

				public AccountingTransactionType AccountingTransactionType {get; set;}

				/// <exclude/>
				public AccountingTransactionNumberBuilder WithAccountingTransactionType(AccountingTransactionType value)
		        {
		            if(this.AccountingTransactionType!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.AccountingTransactionType = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public AccountingTransactionNumberBuilder WithDeniedPermission(Permission value)
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
				public AccountingTransactionNumberBuilder WithSecurityToken(SecurityToken value)
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
				public AccountingTransactionNumberBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	


	}

	public partial class AccountingTransactionNumbers : global::Allors.ObjectsBase<AccountingTransactionNumber>
	{
		public static readonly AccountingTransactionNumberMeta Meta = AccountingTransactionNumberMeta.Instance;

		public AccountingTransactionNumbers(Allors.ISession session) : base(session)
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