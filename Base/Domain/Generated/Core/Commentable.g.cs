// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface Commentable : Allors.IObject
	{


		global::System.String CommentableComment 
		{
			get;
			set;
		}

		bool ExistCommentableComment{get;}

		void RemoveCommentableComment();

	}

	public class CommentableMeta
	{
		public static readonly CommentableMeta Instance = new CommentableMeta();

		public global::Allors.Meta.Interface ObjectType = global::Allors.Meta.Interfaces.Commentable;

		public global::Allors.Meta.RoleType CommentableComment 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.CommentableComment;
			}
		} 

	}
}