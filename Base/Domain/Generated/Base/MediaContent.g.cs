// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class MediaContent
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (MediaContentBuilder)objectBuilder;

			this.Value = builder.Value;
		

			this.Hash = builder.Hash;
		
		}
	}

	public partial class MediaContentBuilder : Allors.ObjectBuilder<MediaContent> , global::System.IDisposable
	{		
		public MediaContentBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.Byte[] Value {get; set;}

				/// <exclude/>
				public MediaContentBuilder WithValue(global::System.Byte[] value)
		        {
				    if(this.Value!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Value = value;
		            return this;
		        }	

				public global::System.String Hash {get; set;}

				/// <exclude/>
				public MediaContentBuilder WithHash(global::System.String value)
		        {
				    if(this.Hash!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Hash = value;
		            return this;
		        }	


	}

	public partial class MediaContents : global::Allors.ObjectsBase<MediaContent>
	{
		public static readonly MediaContentMeta Meta = MediaContentMeta.Instance;

		public MediaContents(Allors.ISession session) : base(session)
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