// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class VatRate
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (VatRateBuilder)objectBuilder;
			

			if(builder.Rate.HasValue)
			{
				this.Rate = builder.Rate.Value;
			}			
					

			if(builder.ReverseCharge.HasValue)
			{
				this.ReverseCharge = builder.ReverseCharge.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
		

			this.VatCalculationMethod = builder.VatCalculationMethod;


			if(builder.VatReturnBoxes!=null)
			{
				this.VatReturnBoxes = builder.VatReturnBoxes.ToArray();
			}


			this.VatPayableAccount = builder.VatPayableAccount;



			this.TaxAuthority = builder.TaxAuthority;



			this.VatRateUsage = builder.VatRateUsage;



			this.VatRatePurchaseKind = builder.VatRatePurchaseKind;



			this.VatTariff = builder.VatTariff;



			this.PaymentFrequency = builder.PaymentFrequency;



			this.VatToPayAccount = builder.VatToPayAccount;



			this.EuSalesListType = builder.EuSalesListType;



			this.VatToReceiveAccount = builder.VatToReceiveAccount;



			this.VatReceivableAccount = builder.VatReceivableAccount;


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

	public partial class VatRateBuilder : Allors.ObjectBuilder<VatRate> , UserInterfaceableBuilder, global::System.IDisposable
	{		
		public VatRateBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public VatCalculationMethod VatCalculationMethod {get; set;}

				/// <exclude/>
				public VatRateBuilder WithVatCalculationMethod(VatCalculationMethod value)
		        {
		            if(this.VatCalculationMethod!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.VatCalculationMethod = value;
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<VatReturnBox> VatReturnBoxes {get; set;}	

				/// <exclude/>
				public VatRateBuilder WithVatReturnBox(VatReturnBox value)
		        {
					if(this.VatReturnBoxes == null)
					{
						this.VatReturnBoxes = new global::System.Collections.Generic.List<VatReturnBox>(); 
					}
		            this.VatReturnBoxes.Add(value);
		            return this;
		        }		

				
				public global::System.Decimal? Rate {get; set;}

				/// <exclude/>
				public VatRateBuilder WithRate(global::System.Decimal? value)
		        {
				    if(this.Rate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Rate = value;
		            return this;
		        }	

				public OrganisationGlAccount VatPayableAccount {get; set;}

				/// <exclude/>
				public VatRateBuilder WithVatPayableAccount(OrganisationGlAccount value)
		        {
		            if(this.VatPayableAccount!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.VatPayableAccount = value;
		            return this;
		        }		

				
				public Organisation TaxAuthority {get; set;}

				/// <exclude/>
				public VatRateBuilder WithTaxAuthority(Organisation value)
		        {
		            if(this.TaxAuthority!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.TaxAuthority = value;
		            return this;
		        }		

				
				public VatRateUsage VatRateUsage {get; set;}

				/// <exclude/>
				public VatRateBuilder WithVatRateUsage(VatRateUsage value)
		        {
		            if(this.VatRateUsage!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.VatRateUsage = value;
		            return this;
		        }		

				
				public VatRatePurchaseKind VatRatePurchaseKind {get; set;}

				/// <exclude/>
				public VatRateBuilder WithVatRatePurchaseKind(VatRatePurchaseKind value)
		        {
		            if(this.VatRatePurchaseKind!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.VatRatePurchaseKind = value;
		            return this;
		        }		

				
				public VatTariff VatTariff {get; set;}

				/// <exclude/>
				public VatRateBuilder WithVatTariff(VatTariff value)
		        {
		            if(this.VatTariff!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.VatTariff = value;
		            return this;
		        }		

				
				public TimeFrequency PaymentFrequency {get; set;}

				/// <exclude/>
				public VatRateBuilder WithPaymentFrequency(TimeFrequency value)
		        {
		            if(this.PaymentFrequency!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.PaymentFrequency = value;
		            return this;
		        }		

				
				public OrganisationGlAccount VatToPayAccount {get; set;}

				/// <exclude/>
				public VatRateBuilder WithVatToPayAccount(OrganisationGlAccount value)
		        {
		            if(this.VatToPayAccount!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.VatToPayAccount = value;
		            return this;
		        }		

				
				public EuSalesListType EuSalesListType {get; set;}

				/// <exclude/>
				public VatRateBuilder WithEuSalesListType(EuSalesListType value)
		        {
		            if(this.EuSalesListType!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.EuSalesListType = value;
		            return this;
		        }		

				
				public OrganisationGlAccount VatToReceiveAccount {get; set;}

				/// <exclude/>
				public VatRateBuilder WithVatToReceiveAccount(OrganisationGlAccount value)
		        {
		            if(this.VatToReceiveAccount!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.VatToReceiveAccount = value;
		            return this;
		        }		

				
				public OrganisationGlAccount VatReceivableAccount {get; set;}

				/// <exclude/>
				public VatRateBuilder WithVatReceivableAccount(OrganisationGlAccount value)
		        {
		            if(this.VatReceivableAccount!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.VatReceivableAccount = value;
		            return this;
		        }		

				
				public global::System.Boolean? ReverseCharge {get; set;}

				/// <exclude/>
				public VatRateBuilder WithReverseCharge(global::System.Boolean? value)
		        {
				    if(this.ReverseCharge!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ReverseCharge = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public VatRateBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public VatRateBuilder WithDeniedPermission(Permission value)
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
				public VatRateBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class VatRates : global::Allors.ObjectsBase<VatRate>
	{
		public static readonly VatRateMeta Meta = VatRateMeta.Instance;

		public VatRates(Allors.ISession session) : base(session)
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