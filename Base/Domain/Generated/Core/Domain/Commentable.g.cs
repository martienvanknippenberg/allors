// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface Commentable : Allors.IObjectBase
	{


		global::System.String Comment 
		{
			get;
			set;
		}

		bool ExistComment{get;}

		void RemoveComment();

	}

	public class CommentableMeta
	{
		public static readonly CommentableMeta Instance = new CommentableMeta();

		public global::Allors.Meta.Interface ObjectType = global::Allors.Meta.Interfaces.Commentable;

		public global::Allors.Meta.RoleType Comment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommentableComment;
			}
		} 

	}
}