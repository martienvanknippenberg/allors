// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class JournalEntry
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (JournalEntryBuilder)objectBuilder;

			this.Description = builder.Description;
					

			if(builder.EntryNumber.HasValue)
			{
				this.EntryNumber = builder.EntryNumber.Value;
			}			
					

			if(builder.EntryDate.HasValue)
			{
				this.EntryDate = builder.EntryDate.Value;
			}			
					

			if(builder.JournalDate.HasValue)
			{
				this.JournalDate = builder.JournalDate.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
		
			if(builder.JournalEntryDetails!=null)
			{
				this.JournalEntryDetails = builder.JournalEntryDetails.ToArray();
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

	public partial class JournalEntryBuilder : Allors.ObjectBuilder<JournalEntry> , UserInterfaceableBuilder, TransitionalBuilder, AccessControlledObjectBuilder, SearchableBuilder, global::System.IDisposable
	{		
		public JournalEntryBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.String Description {get; set;}

				/// <exclude/>
				public JournalEntryBuilder WithDescription(global::System.String value)
		        {
				    if(this.Description!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Description = value;
		            return this;
		        }	

				public global::System.Int64? EntryNumber {get; set;}

				/// <exclude/>
				public JournalEntryBuilder WithEntryNumber(global::System.Int64? value)
		        {
				    if(this.EntryNumber!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.EntryNumber = value;
		            return this;
		        }	

				public global::System.DateTime? EntryDate {get; set;}

				/// <exclude/>
				public JournalEntryBuilder WithEntryDate(global::System.DateTime? value)
		        {
				    if(this.EntryDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.EntryDate = value;
		            return this;
		        }	

				public global::System.DateTime? JournalDate {get; set;}

				/// <exclude/>
				public JournalEntryBuilder WithJournalDate(global::System.DateTime? value)
		        {
				    if(this.JournalDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.JournalDate = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<JournalEntryDetail> JournalEntryDetails {get; set;}	

				/// <exclude/>
				public JournalEntryBuilder WithJournalEntryDetail(JournalEntryDetail value)
		        {
					if(this.JournalEntryDetails == null)
					{
						this.JournalEntryDetails = new global::System.Collections.Generic.List<JournalEntryDetail>(); 
					}
		            this.JournalEntryDetails.Add(value);
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public JournalEntryBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public JournalEntryBuilder WithDeniedPermission(Permission value)
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
				public JournalEntryBuilder WithSecurityToken(SecurityToken value)
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
				public JournalEntryBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				

	}

	public partial class JournalEntries : global::Allors.ObjectsBase<JournalEntry>
	{
		public static readonly JournalEntryMeta Meta = JournalEntryMeta.Instance;

		public JournalEntries(Allors.ISession session) : base(session)
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