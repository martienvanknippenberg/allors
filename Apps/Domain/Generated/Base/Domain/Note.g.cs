// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class Note
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (NoteBuilder)objectBuilder;

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
		

			this.FromParty = builder.FromParty;



			this.ToParty = builder.ToParty;


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

	public partial class NoteBuilder : Allors.ObjectBuilder<Note> , ExternalAccountingTransactionBuilder, global::System.IDisposable
	{		
		public NoteBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public Party FromParty {get; set;}

				/// <exclude/>
				public NoteBuilder WithFromParty(Party value)
		        {
		            if(this.FromParty!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.FromParty = value;
		            return this;
		        }		

				
				public Party ToParty {get; set;}

				/// <exclude/>
				public NoteBuilder WithToParty(Party value)
		        {
		            if(this.ToParty!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.ToParty = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<AccountingTransactionDetail> AccountingTransactionDetails {get; set;}	

				/// <exclude/>
				public NoteBuilder WithAccountingTransactionDetail(AccountingTransactionDetail value)
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
				public NoteBuilder WithDescription(global::System.String value)
		        {
				    if(this.Description!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Description = value;
		            return this;
		        }	

				public global::System.DateTime? TransactionDate {get; set;}

				/// <exclude/>
				public NoteBuilder WithTransactionDate(global::System.DateTime? value)
		        {
				    if(this.TransactionDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.TransactionDate = value;
		            return this;
		        }	

				public global::System.Decimal? DerivedTotalAmount {get; set;}

				/// <exclude/>
				public NoteBuilder WithDerivedTotalAmount(global::System.Decimal? value)
		        {
				    if(this.DerivedTotalAmount!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DerivedTotalAmount = value;
		            return this;
		        }	

				public AccountingTransactionNumber AccountingTransactionNumber {get; set;}

				/// <exclude/>
				public NoteBuilder WithAccountingTransactionNumber(AccountingTransactionNumber value)
		        {
		            if(this.AccountingTransactionNumber!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.AccountingTransactionNumber = value;
		            return this;
		        }		

				
				public global::System.DateTime? EntryDate {get; set;}

				/// <exclude/>
				public NoteBuilder WithEntryDate(global::System.DateTime? value)
		        {
				    if(this.EntryDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.EntryDate = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public NoteBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public NoteBuilder WithDeniedPermission(Permission value)
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
				public NoteBuilder WithSecurityToken(SecurityToken value)
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
				public NoteBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				

	}

	public partial class Notes : global::Allors.ObjectsBase<Note>
	{
		public static readonly NoteMeta Meta = NoteMeta.Instance;

		public Notes(Allors.ISession session) : base(session)
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