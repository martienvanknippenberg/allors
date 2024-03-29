// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class Image
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (ImageBuilder)objectBuilder;

			this.OriginalFilename = builder.OriginalFilename;
		

			this.Original = builder.Original;



			this.Responsive = builder.Responsive;


		}
	}

	public partial class ImageBuilder : Allors.ObjectBuilder<Image> , global::System.IDisposable
	{		
		public ImageBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public Media Original {get; set;}

				/// <exclude/>
				public ImageBuilder WithOriginal(Media value)
		        {
		            if(this.Original!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Original = value;
		            return this;
		        }		

				
				public Media Responsive {get; set;}

				/// <exclude/>
				public ImageBuilder WithResponsive(Media value)
		        {
		            if(this.Responsive!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Responsive = value;
		            return this;
		        }		

				
				public global::System.String OriginalFilename {get; set;}

				/// <exclude/>
				public ImageBuilder WithOriginalFilename(global::System.String value)
		        {
				    if(this.OriginalFilename!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.OriginalFilename = value;
		            return this;
		        }	


	}

	public partial class Images : global::Allors.ObjectsBase<Image>
	{
		public static readonly ImageMeta Meta = ImageMeta.Instance;

		public Images(Allors.ISession session) : base(session)
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