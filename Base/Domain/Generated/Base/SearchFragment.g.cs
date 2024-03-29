// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class SearchFragment
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (SearchFragmentBuilder)objectBuilder;

			this.LowerCaseText = builder.LowerCaseText;
		
		}
	}

	public partial class SearchFragmentBuilder : Allors.ObjectBuilder<SearchFragment> , global::System.IDisposable
	{		
		public SearchFragmentBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.String LowerCaseText {get; set;}

				/// <exclude/>
				public SearchFragmentBuilder WithLowerCaseText(global::System.String value)
		        {
				    if(this.LowerCaseText!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.LowerCaseText = value;
		            return this;
		        }	


	}

	public partial class SearchFragments : global::Allors.ObjectsBase<SearchFragment>
	{
		public static readonly SearchFragmentMeta Meta = SearchFragmentMeta.Instance;

		public SearchFragments(Allors.ISession session) : base(session)
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