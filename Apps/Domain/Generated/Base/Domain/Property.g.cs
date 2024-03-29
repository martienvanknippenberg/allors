// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class Property
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (PropertyBuilder)objectBuilder;

			this.Name = builder.Name;
					

			if(builder.LastServiceDate.HasValue)
			{
				this.LastServiceDate = builder.LastServiceDate.Value;
			}			
					

			if(builder.AcquiredDate.HasValue)
			{
				this.AcquiredDate = builder.AcquiredDate.Value;
			}			
		

			this.Description = builder.Description;
					

			if(builder.ProductionCapacity.HasValue)
			{
				this.ProductionCapacity = builder.ProductionCapacity.Value;
			}			
					

			if(builder.NextServiceDate.HasValue)
			{
				this.NextServiceDate = builder.NextServiceDate.Value;
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


			this.SearchData = builder.SearchData;


		}
	}

	public partial class PropertyBuilder : Allors.ObjectBuilder<Property> , FixedAssetBuilder, global::System.IDisposable
	{		
		public PropertyBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.String Name {get; set;}

				/// <exclude/>
				public PropertyBuilder WithName(global::System.String value)
		        {
				    if(this.Name!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Name = value;
		            return this;
		        }	

				public global::System.DateTime? LastServiceDate {get; set;}

				/// <exclude/>
				public PropertyBuilder WithLastServiceDate(global::System.DateTime? value)
		        {
				    if(this.LastServiceDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.LastServiceDate = value;
		            return this;
		        }	

				public global::System.DateTime? AcquiredDate {get; set;}

				/// <exclude/>
				public PropertyBuilder WithAcquiredDate(global::System.DateTime? value)
		        {
				    if(this.AcquiredDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.AcquiredDate = value;
		            return this;
		        }	

				public global::System.String Description {get; set;}

				/// <exclude/>
				public PropertyBuilder WithDescription(global::System.String value)
		        {
				    if(this.Description!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Description = value;
		            return this;
		        }	

				public global::System.Decimal? ProductionCapacity {get; set;}

				/// <exclude/>
				public PropertyBuilder WithProductionCapacity(global::System.Decimal? value)
		        {
				    if(this.ProductionCapacity!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.ProductionCapacity = value;
		            return this;
		        }	

				public global::System.DateTime? NextServiceDate {get; set;}

				/// <exclude/>
				public PropertyBuilder WithNextServiceDate(global::System.DateTime? value)
		        {
				    if(this.NextServiceDate!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.NextServiceDate = value;
		            return this;
		        }	

				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public PropertyBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public PropertyBuilder WithDeniedPermission(Permission value)
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
				public PropertyBuilder WithSecurityToken(SecurityToken value)
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
				public PropertyBuilder WithSearchData(SearchData value)
		        {
		            if(this.SearchData!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.SearchData = value;
		            return this;
		        }		

				

	}

	public partial class Properties : global::Allors.ObjectsBase<Property>
	{
		public static readonly PropertyMeta Meta = PropertyMeta.Instance;

		public Properties(Allors.ISession session) : base(session)
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