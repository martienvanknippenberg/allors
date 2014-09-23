// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class Lot
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (LotBuilder)objectBuilder;
			

			if(builder.ExpirationDate.HasValue)
			{
				this.ExpirationDate = builder.ExpirationDate.Value;
			}			
					

			if(builder.Quantity.HasValue)
			{
				this.Quantity = builder.Quantity.Value;
			}			
		

			this.LotNumber = builder.LotNumber;
		

			this.DisplayName = builder.DisplayName;
		

			this.SearchData = builder.SearchData;


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

	public partial class LotBuilder : Allors.ObjectBuilder<Lot> , SearchableBuilder, UserInterfaceableBuilder, global::System.IDisposable
	{		
		public LotBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.DateTime? ExpirationDate {get; set;}

				/// <exclude/>
				public LotBuilder WithExpirationDate(global::System.DateTime? value)
		        {
				    if(this.ExpirationDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ExpirationDate = value;
		            return this;
		        }	

				public global::System.Int32? Quantity {get; set;}

				/// <exclude/>
				public LotBuilder WithQuantity(global::System.Int32? value)
		        {
				    if(this.Quantity!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Quantity = value;
		            return this;
		        }	

				public global::System.String LotNumber {get; set;}

				/// <exclude/>
				public LotBuilder WithLotNumber(global::System.String value)
		        {
				    if(this.LotNumber!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.LotNumber = value;
		            return this;
		        }	

				public SearchData SearchData {get; set;}

				/// <exclude/>
				public LotBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public LotBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public LotBuilder WithDeniedPermission(Permission value)
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
				public LotBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class Lots : global::Allors.ObjectsBase<Lot>
	{
		public static readonly LotMeta Meta = LotMeta.Instance;

		public Lots(Allors.ISession session) : base(session)
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