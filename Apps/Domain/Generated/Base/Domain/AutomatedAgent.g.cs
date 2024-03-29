// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class AutomatedAgent
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (AutomatedAgentBuilder)objectBuilder;

			this.Name = builder.Name;
		

			this.Description = builder.Description;
					

			if(builder.UserEmailConfirmed.HasValue)
			{
				this.UserEmailConfirmed = builder.UserEmailConfirmed.Value;
			}			
		

			this.UserName = builder.UserName;
		

			this.UserEmail = builder.UserEmail;
		

			this.UserPasswordHash = builder.UserPasswordHash;
		

			this.DisplayName = builder.DisplayName;
					

			if(builder.YTDRevenue.HasValue)
			{
				this.YTDRevenue = builder.YTDRevenue.Value;
			}			
					

			if(builder.LastYearsRevenue.HasValue)
			{
				this.LastYearsRevenue = builder.LastYearsRevenue.Value;
			}			
					

			if(builder.ExcludeFromDunning.HasValue)
			{
				this.ExcludeFromDunning = builder.ExcludeFromDunning.Value;
			}			
		

			this.PartyName = builder.PartyName;
					

			if(builder.OpenOrderAmount.HasValue)
			{
				this.OpenOrderAmount = builder.OpenOrderAmount.Value;
			}			
					

			if(builder.UniqueId.HasValue)
			{
				this.UniqueId = builder.UniqueId.Value;
			}			
		

			this.OwnerSecurityToken = builder.OwnerSecurityToken;


			if(builder.DeniedPermissions!=null)
			{
				this.DeniedPermissions = builder.DeniedPermissions.ToArray();
			}

			if(builder.SecurityTokens!=null)
			{
				this.SecurityTokens = builder.SecurityTokens.ToArray();
			}


			this.Locale = builder.Locale;



			this.BillingInquiriesFax = builder.BillingInquiriesFax;


			if(builder.Qualifications!=null)
			{
				this.Qualifications = builder.Qualifications.ToArray();
			}


			this.HomeAddress = builder.HomeAddress;



			this.SalesOffice = builder.SalesOffice;



			this.OrderInquiriesFax = builder.OrderInquiriesFax;


			if(builder.CurrentSalesReps!=null)
			{
				this.CurrentSalesReps = builder.CurrentSalesReps.ToArray();
			}

			if(builder.PartyContactMechanisms!=null)
			{
				this.PartyContactMechanisms = builder.PartyContactMechanisms.ToArray();
			}


			this.ShippingInquiriesFax = builder.ShippingInquiriesFax;



			this.ShippingInquiriesPhone = builder.ShippingInquiriesPhone;


			if(builder.BillingAccounts!=null)
			{
				this.BillingAccounts = builder.BillingAccounts.ToArray();
			}


			this.OrderInquiriesPhone = builder.OrderInquiriesPhone;


			if(builder.PartySkills!=null)
			{
				this.PartySkills = builder.PartySkills.ToArray();
			}

			if(builder.PartyClassifications!=null)
			{
				this.PartyClassifications = builder.PartyClassifications.ToArray();
			}

			if(builder.BankAccounts!=null)
			{
				this.BankAccounts = builder.BankAccounts.ToArray();
			}


			this.BillingAddress = builder.BillingAddress;



			this.DefaultShipmentMethod = builder.DefaultShipmentMethod;


			if(builder.Resumes!=null)
			{
				this.Resumes = builder.Resumes.ToArray();
			}


			this.HeadQuarter = builder.HeadQuarter;



			this.PersonalEmailAddress = builder.PersonalEmailAddress;



			this.CellPhoneNumber = builder.CellPhoneNumber;



			this.BillingInquiriesPhone = builder.BillingInquiriesPhone;



			this.OrderAddress = builder.OrderAddress;



			this.InternetAddress = builder.InternetAddress;


			if(builder.Contents!=null)
			{
				this.Contents = builder.Contents.ToArray();
			}

			if(builder.CreditCards!=null)
			{
				this.CreditCards = builder.CreditCards.ToArray();
			}


			this.ShippingAddress = builder.ShippingAddress;



			this.GeneralFaxNumber = builder.GeneralFaxNumber;



			this.DefaultPaymentMethod = builder.DefaultPaymentMethod;



			this.GeneralPhoneNumber = builder.GeneralPhoneNumber;



			this.PreferredCurrency = builder.PreferredCurrency;



			this.VatRegime = builder.VatRegime;



			this.SearchData = builder.SearchData;


		}
	}

	public partial class AutomatedAgentBuilder : Allors.ObjectBuilder<AutomatedAgent> , UserBuilder, PartyBuilder, global::System.IDisposable
	{		
		public AutomatedAgentBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.String Name {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithName(global::System.String value)
		        {
				    if(this.Name!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Name = value;
		            return this;
		        }	

				public global::System.String Description {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithDescription(global::System.String value)
		        {
				    if(this.Description!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Description = value;
		            return this;
		        }	

				public global::System.Boolean? UserEmailConfirmed {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithUserEmailConfirmed(global::System.Boolean? value)
		        {
				    if(this.UserEmailConfirmed!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UserEmailConfirmed = value;
		            return this;
		        }	

				public global::System.String UserName {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithUserName(global::System.String value)
		        {
				    if(this.UserName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UserName = value;
		            return this;
		        }	

				public global::System.String UserEmail {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithUserEmail(global::System.String value)
		        {
				    if(this.UserEmail!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UserEmail = value;
		            return this;
		        }	

				public global::System.String UserPasswordHash {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithUserPasswordHash(global::System.String value)
		        {
				    if(this.UserPasswordHash!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UserPasswordHash = value;
		            return this;
		        }	

				public SecurityToken OwnerSecurityToken {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithOwnerSecurityToken(SecurityToken value)
		        {
		            if(this.OwnerSecurityToken!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.OwnerSecurityToken = value;
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public AutomatedAgentBuilder WithDeniedPermission(Permission value)
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
				public AutomatedAgentBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				
				public Locale Locale {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithLocale(Locale value)
		        {
		            if(this.Locale!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Locale = value;
		            return this;
		        }		

				
				public global::System.Decimal? YTDRevenue {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithYTDRevenue(global::System.Decimal? value)
		        {
				    if(this.YTDRevenue!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.YTDRevenue = value;
		            return this;
		        }	

				public global::System.Decimal? LastYearsRevenue {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithLastYearsRevenue(global::System.Decimal? value)
		        {
				    if(this.LastYearsRevenue!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.LastYearsRevenue = value;
		            return this;
		        }	

				public TelecommunicationsNumber BillingInquiriesFax {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithBillingInquiriesFax(TelecommunicationsNumber value)
		        {
		            if(this.BillingInquiriesFax!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.BillingInquiriesFax = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<Qualification> Qualifications {get; set;}	

				/// <exclude/>
				public AutomatedAgentBuilder WithQualification(Qualification value)
		        {
					if(this.Qualifications == null)
					{
						this.Qualifications = new global::System.Collections.Generic.List<Qualification>(); 
					}
		            this.Qualifications.Add(value);
		            return this;
		        }		

				
				public ContactMechanism HomeAddress {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithHomeAddress(ContactMechanism value)
		        {
		            if(this.HomeAddress!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.HomeAddress = value;
		            return this;
		        }		

				
				public ContactMechanism SalesOffice {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithSalesOffice(ContactMechanism value)
		        {
		            if(this.SalesOffice!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SalesOffice = value;
		            return this;
		        }		

				
				public TelecommunicationsNumber OrderInquiriesFax {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithOrderInquiriesFax(TelecommunicationsNumber value)
		        {
		            if(this.OrderInquiriesFax!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.OrderInquiriesFax = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<Person> CurrentSalesReps {get; set;}	

				/// <exclude/>
				public AutomatedAgentBuilder WithCurrentSalesRep(Person value)
		        {
					if(this.CurrentSalesReps == null)
					{
						this.CurrentSalesReps = new global::System.Collections.Generic.List<Person>(); 
					}
		            this.CurrentSalesReps.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<PartyContactMechanism> PartyContactMechanisms {get; set;}	

				/// <exclude/>
				public AutomatedAgentBuilder WithPartyContactMechanism(PartyContactMechanism value)
		        {
					if(this.PartyContactMechanisms == null)
					{
						this.PartyContactMechanisms = new global::System.Collections.Generic.List<PartyContactMechanism>(); 
					}
		            this.PartyContactMechanisms.Add(value);
		            return this;
		        }		

				
				public TelecommunicationsNumber ShippingInquiriesFax {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithShippingInquiriesFax(TelecommunicationsNumber value)
		        {
		            if(this.ShippingInquiriesFax!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.ShippingInquiriesFax = value;
		            return this;
		        }		

				
				public TelecommunicationsNumber ShippingInquiriesPhone {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithShippingInquiriesPhone(TelecommunicationsNumber value)
		        {
		            if(this.ShippingInquiriesPhone!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.ShippingInquiriesPhone = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<BillingAccount> BillingAccounts {get; set;}	

				/// <exclude/>
				public AutomatedAgentBuilder WithBillingAccount(BillingAccount value)
		        {
					if(this.BillingAccounts == null)
					{
						this.BillingAccounts = new global::System.Collections.Generic.List<BillingAccount>(); 
					}
		            this.BillingAccounts.Add(value);
		            return this;
		        }		

				
				public TelecommunicationsNumber OrderInquiriesPhone {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithOrderInquiriesPhone(TelecommunicationsNumber value)
		        {
		            if(this.OrderInquiriesPhone!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.OrderInquiriesPhone = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<PartySkill> PartySkills {get; set;}	

				/// <exclude/>
				public AutomatedAgentBuilder WithPartySkill(PartySkill value)
		        {
					if(this.PartySkills == null)
					{
						this.PartySkills = new global::System.Collections.Generic.List<PartySkill>(); 
					}
		            this.PartySkills.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<PartyClassification> PartyClassifications {get; set;}	

				/// <exclude/>
				public AutomatedAgentBuilder WithPartyClassification(PartyClassification value)
		        {
					if(this.PartyClassifications == null)
					{
						this.PartyClassifications = new global::System.Collections.Generic.List<PartyClassification>(); 
					}
		            this.PartyClassifications.Add(value);
		            return this;
		        }		

				
				public global::System.Boolean? ExcludeFromDunning {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithExcludeFromDunning(global::System.Boolean? value)
		        {
				    if(this.ExcludeFromDunning!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ExcludeFromDunning = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<BankAccount> BankAccounts {get; set;}	

				/// <exclude/>
				public AutomatedAgentBuilder WithBankAccount(BankAccount value)
		        {
					if(this.BankAccounts == null)
					{
						this.BankAccounts = new global::System.Collections.Generic.List<BankAccount>(); 
					}
		            this.BankAccounts.Add(value);
		            return this;
		        }		

				
				public ContactMechanism BillingAddress {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithBillingAddress(ContactMechanism value)
		        {
		            if(this.BillingAddress!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.BillingAddress = value;
		            return this;
		        }		

				
				public ShipmentMethod DefaultShipmentMethod {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithDefaultShipmentMethod(ShipmentMethod value)
		        {
		            if(this.DefaultShipmentMethod!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.DefaultShipmentMethod = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<Resume> Resumes {get; set;}	

				/// <exclude/>
				public AutomatedAgentBuilder WithResume(Resume value)
		        {
					if(this.Resumes == null)
					{
						this.Resumes = new global::System.Collections.Generic.List<Resume>(); 
					}
		            this.Resumes.Add(value);
		            return this;
		        }		

				
				public ContactMechanism HeadQuarter {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithHeadQuarter(ContactMechanism value)
		        {
		            if(this.HeadQuarter!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.HeadQuarter = value;
		            return this;
		        }		

				
				public ElectronicAddress PersonalEmailAddress {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithPersonalEmailAddress(ElectronicAddress value)
		        {
		            if(this.PersonalEmailAddress!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.PersonalEmailAddress = value;
		            return this;
		        }		

				
				public TelecommunicationsNumber CellPhoneNumber {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithCellPhoneNumber(TelecommunicationsNumber value)
		        {
		            if(this.CellPhoneNumber!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.CellPhoneNumber = value;
		            return this;
		        }		

				
				public TelecommunicationsNumber BillingInquiriesPhone {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithBillingInquiriesPhone(TelecommunicationsNumber value)
		        {
		            if(this.BillingInquiriesPhone!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.BillingInquiriesPhone = value;
		            return this;
		        }		

				
				public global::System.String PartyName {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithPartyName(global::System.String value)
		        {
				    if(this.PartyName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.PartyName = value;
		            return this;
		        }	

				public ContactMechanism OrderAddress {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithOrderAddress(ContactMechanism value)
		        {
		            if(this.OrderAddress!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.OrderAddress = value;
		            return this;
		        }		

				
				public ElectronicAddress InternetAddress {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithInternetAddress(ElectronicAddress value)
		        {
		            if(this.InternetAddress!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.InternetAddress = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<Media> Contents {get; set;}	

				/// <exclude/>
				public AutomatedAgentBuilder WithContent(Media value)
		        {
					if(this.Contents == null)
					{
						this.Contents = new global::System.Collections.Generic.List<Media>(); 
					}
		            this.Contents.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<CreditCard> CreditCards {get; set;}	

				/// <exclude/>
				public AutomatedAgentBuilder WithCreditCard(CreditCard value)
		        {
					if(this.CreditCards == null)
					{
						this.CreditCards = new global::System.Collections.Generic.List<CreditCard>(); 
					}
		            this.CreditCards.Add(value);
		            return this;
		        }		

				
				public PostalAddress ShippingAddress {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithShippingAddress(PostalAddress value)
		        {
		            if(this.ShippingAddress!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.ShippingAddress = value;
		            return this;
		        }		

				
				public global::System.Decimal? OpenOrderAmount {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithOpenOrderAmount(global::System.Decimal? value)
		        {
				    if(this.OpenOrderAmount!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.OpenOrderAmount = value;
		            return this;
		        }	

				public TelecommunicationsNumber GeneralFaxNumber {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithGeneralFaxNumber(TelecommunicationsNumber value)
		        {
		            if(this.GeneralFaxNumber!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.GeneralFaxNumber = value;
		            return this;
		        }		

				
				public PaymentMethod DefaultPaymentMethod {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithDefaultPaymentMethod(PaymentMethod value)
		        {
		            if(this.DefaultPaymentMethod!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.DefaultPaymentMethod = value;
		            return this;
		        }		

				
				public TelecommunicationsNumber GeneralPhoneNumber {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithGeneralPhoneNumber(TelecommunicationsNumber value)
		        {
		            if(this.GeneralPhoneNumber!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.GeneralPhoneNumber = value;
		            return this;
		        }		

				
				public Currency PreferredCurrency {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithPreferredCurrency(Currency value)
		        {
		            if(this.PreferredCurrency!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.PreferredCurrency = value;
		            return this;
		        }		

				
				public VatRegime VatRegime {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithVatRegime(VatRegime value)
		        {
		            if(this.VatRegime!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.VatRegime = value;
		            return this;
		        }		

				
				public global::System.Guid? UniqueId {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithUniqueId(global::System.Guid? value)
		        {
				    if(this.UniqueId!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.UniqueId = value;
		            return this;
		        }	

				public SearchData SearchData {get; set;}

				/// <exclude/>
				public AutomatedAgentBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				

	}

	public partial class AutomatedAgents : global::Allors.ObjectsBase<AutomatedAgent>
	{
		public static readonly AutomatedAgentMeta Meta = AutomatedAgentMeta.Instance;

		public AutomatedAgents(Allors.ISession session) : base(session)
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