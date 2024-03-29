// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class Extender
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (ExtenderBuilder)objectBuilder;

			this.AllorsString = builder.AllorsString;
		
		}
	}

	public partial class ExtenderBuilder : Allors.ObjectBuilder<Extender> , global::System.IDisposable
	{		
		public ExtenderBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.String AllorsString {get; set;}

				/// <exclude/>
				public ExtenderBuilder WithAllorsString(global::System.String value)
		        {
				    if(this.AllorsString!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.AllorsString = value;
		            return this;
		        }	


	}

	public partial class Extenders : global::Allors.ObjectsBase<Extender>
	{
		public static readonly ExtenderMeta Meta = ExtenderMeta.Instance;

		public Extenders(Allors.ISession session) : base(session)
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