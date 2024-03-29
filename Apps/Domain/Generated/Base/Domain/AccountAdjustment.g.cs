// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class AccountAdjustment
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (AccountAdjustmentBuilder)objectBuilder;

			this.Description = builder.Description;
					

			if(builder.EntryDate.HasValue)
			{
				this.EntryDate = builder.EntryDate.Value;
			}			
					

			if(builder.TransactionDate.HasValue)
			{
				this.TransactionDate = builder.TransactionDate.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
		
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

	public partial class AccountAdjustmentBuilder : Allors.ObjectBuilder<AccountAdjustment> , FinancialAccountTransactionBuilder, global::System.IDisposable
	{		
		public AccountAdjustmentBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.String Description {get; set;}

				/// <exclude/>
				public AccountAdjustmentBuilder WithDescription(global::System.String value)
		        {
				    if(this.Description!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Description = value;
		            return this;
		        }	

				public global::System.DateTime? EntryDate {get; set;}

				/// <exclude/>
				public AccountAdjustmentBuilder WithEntryDate(global::System.DateTime? value)
		        {
				    if(this.EntryDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.EntryDate = value;
		            return this;
		        }	

				public global::System.DateTime? TransactionDate {get; set;}

				/// <exclude/>
				public AccountAdjustmentBuilder WithTransactionDate(global::System.DateTime? value)
		        {
				    if(this.TransactionDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.TransactionDate = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public AccountAdjustmentBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public AccountAdjustmentBuilder WithDeniedPermission(Permission value)
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
				public AccountAdjustmentBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class AccountAdjustments : global::Allors.ObjectsBase<AccountAdjustment>
	{
		public static readonly AccountAdjustmentMeta Meta = AccountAdjustmentMeta.Instance;

		public AccountAdjustments(Allors.ISession session) : base(session)
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