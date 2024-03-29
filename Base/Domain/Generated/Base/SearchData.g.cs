// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class SearchData
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (SearchDataBuilder)objectBuilder;

			this.CharacterBoundaryText = builder.CharacterBoundaryText;
		

			this.PreviousCharacterBoundaryText = builder.PreviousCharacterBoundaryText;
		

			this.PreviousWordBoundaryText = builder.PreviousWordBoundaryText;
		

			this.WordBoundaryText = builder.WordBoundaryText;
		
			if(builder.SearchFragments!=null)
			{
				this.SearchFragments = builder.SearchFragments.ToArray();
			}

		}
	}

	public partial class SearchDataBuilder : Allors.ObjectBuilder<SearchData> , global::System.IDisposable
	{		
		public SearchDataBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public global::System.String CharacterBoundaryText {get; set;}

				/// <exclude/>
				public SearchDataBuilder WithCharacterBoundaryText(global::System.String value)
		        {
				    if(this.CharacterBoundaryText!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.CharacterBoundaryText = value;
		            return this;
		        }	

				public global::System.String PreviousCharacterBoundaryText {get; set;}

				/// <exclude/>
				public SearchDataBuilder WithPreviousCharacterBoundaryText(global::System.String value)
		        {
				    if(this.PreviousCharacterBoundaryText!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.PreviousCharacterBoundaryText = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<SearchFragment> SearchFragments {get; set;}	

				/// <exclude/>
				public SearchDataBuilder WithSearchFragment(SearchFragment value)
		        {
					if(this.SearchFragments == null)
					{
						this.SearchFragments = new global::System.Collections.Generic.List<SearchFragment>(); 
					}
		            this.SearchFragments.Add(value);
		            return this;
		        }		

				
				public global::System.String PreviousWordBoundaryText {get; set;}

				/// <exclude/>
				public SearchDataBuilder WithPreviousWordBoundaryText(global::System.String value)
		        {
				    if(this.PreviousWordBoundaryText!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.PreviousWordBoundaryText = value;
		            return this;
		        }	

				public global::System.String WordBoundaryText {get; set;}

				/// <exclude/>
				public SearchDataBuilder WithWordBoundaryText(global::System.String value)
		        {
				    if(this.WordBoundaryText!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.WordBoundaryText = value;
		            return this;
		        }	


	}

	public partial class SearchDatas : global::Allors.ObjectsBase<SearchData>
	{
		public static readonly SearchDataMeta Meta = SearchDataMeta.Instance;

		public SearchDatas(Allors.ISession session) : base(session)
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