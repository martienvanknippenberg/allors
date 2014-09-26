// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class PackageRevenueHistory
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (PackageRevenueHistoryBuilder)objectBuilder;
			

			if(builder.Revenue.HasValue)
			{
				this.Revenue = builder.Revenue.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
		

			this.InternalOrganisation = builder.InternalOrganisation;



			this.Package = builder.Package;



			this.Currency = builder.Currency;


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

	public partial class PackageRevenueHistoryBuilder : Allors.ObjectBuilder<PackageRevenueHistory> , UserInterfaceableBuilder, global::System.IDisposable
	{		
		public PackageRevenueHistoryBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public InternalOrganisation InternalOrganisation {get; set;}

				/// <exclude/>
				public PackageRevenueHistoryBuilder WithInternalOrganisation(InternalOrganisation value)
		        {
		            if(this.InternalOrganisation!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.InternalOrganisation = value;
		            return this;
		        }		

				
				public global::System.Decimal? Revenue {get; set;}

				/// <exclude/>
				public PackageRevenueHistoryBuilder WithRevenue(global::System.Decimal? value)
		        {
				    if(this.Revenue!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Revenue = value;
		            return this;
		        }	

				public Package Package {get; set;}

				/// <exclude/>
				public PackageRevenueHistoryBuilder WithPackage(Package value)
		        {
		            if(this.Package!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Package = value;
		            return this;
		        }		

				
				public Currency Currency {get; set;}

				/// <exclude/>
				public PackageRevenueHistoryBuilder WithCurrency(Currency value)
		        {
		            if(this.Currency!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Currency = value;
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public PackageRevenueHistoryBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public PackageRevenueHistoryBuilder WithDeniedPermission(Permission value)
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
				public PackageRevenueHistoryBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class PackageRevenueHistories : global::Allors.ObjectsBase<PackageRevenueHistory>
	{
		public static readonly PackageRevenueHistoryMeta Meta = PackageRevenueHistoryMeta.Instance;

		public PackageRevenueHistories(Allors.ISession session) : base(session)
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