// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class PositionReportingStructure
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (PositionReportingStructureBuilder)objectBuilder;
			

			if(builder.Primary.HasValue)
			{
				this.Primary = builder.Primary.Value;
			}			
		

			this.DisplayName = builder.DisplayName;
		

			this.Comment = builder.Comment;
		

			this.ManagedByPosition = builder.ManagedByPosition;



			this.Position = builder.Position;


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

	public partial class PositionReportingStructureBuilder : Allors.ObjectBuilder<PositionReportingStructure> , UserInterfaceableBuilder, CommentableBuilder, global::System.IDisposable
	{		
		public PositionReportingStructureBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.Boolean? Primary {get; set;}

				/// <exclude/>
				public PositionReportingStructureBuilder WithPrimary(global::System.Boolean? value)
		        {
				    if(this.Primary!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Primary = value;
		            return this;
		        }	

				public Position ManagedByPosition {get; set;}

				/// <exclude/>
				public PositionReportingStructureBuilder WithManagedByPosition(Position value)
		        {
		            if(this.ManagedByPosition!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.ManagedByPosition = value;
		            return this;
		        }		

				
				public Position Position {get; set;}

				/// <exclude/>
				public PositionReportingStructureBuilder WithPosition(Position value)
		        {
		            if(this.Position!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Position = value;
		            return this;
		        }		

				
				public global::System.String DisplayName {get; set;}

				/// <exclude/>
				public PositionReportingStructureBuilder WithDisplayName(global::System.String value)
		        {
				    if(this.DisplayName!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DisplayName = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public PositionReportingStructureBuilder WithDeniedPermission(Permission value)
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
				public PositionReportingStructureBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				
				public global::System.String Comment {get; set;}

				/// <exclude/>
				public PositionReportingStructureBuilder WithComment(global::System.String value)
		        {
				    if(this.Comment!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Comment = value;
		            return this;
		        }	


	}

	public partial class PositionReportingStructures : global::Allors.ObjectsBase<PositionReportingStructure>
	{
		public static readonly PositionReportingStructureMeta Meta = PositionReportingStructureMeta.Instance;

		public PositionReportingStructures(Allors.ISession session) : base(session)
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