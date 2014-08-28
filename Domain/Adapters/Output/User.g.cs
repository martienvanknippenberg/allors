// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Domain
{
	public partial class User : UserAllors 
	{
		public User(Allors.IStrategy allors) : base(allors) {}

		public static User Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (User) allorsSession.Instantiate(allorsObjectId);		
		}
	}

	[System.Diagnostics.DebuggerNonUserCode]
	public abstract class UserAllors : Allors.ObjectBase
	{
		protected UserAllors(Allors.IStrategy allors) : base(allors){}


		virtual public Allors.Extent<global::Domain.User> Selects
		{ 
			get
			{
				return Strategy.GetCompositeRoles(UserMeta.Select);
			}
			set
			{
				Strategy.SetCompositeRoles(UserMeta.Select, value);
			}
		}

		virtual public void AddSelect (global::Domain.User value)
		{
			Strategy.AddCompositeRole(UserMeta.Select, value);
		}

		virtual public void RemoveSelect (global::Domain.User value)
		{
			Strategy.RemoveCompositeRole(UserMeta.Select,value);
		}

		virtual public bool ExistSelects
		{
			get
			{
				return Strategy.ExistCompositeRoles(UserMeta.Select);
			}
		}

		virtual public void RemoveSelects()
		{
			Strategy.RemoveCompositeRoles(UserMeta.Select);
		}



		virtual public global::System.String From 
		{
			get
			{
				return (global::System.String) Strategy.GetUnitRole(UserMeta.From);
			}
			set
			{
				Strategy.SetUnitRole(UserMeta.From, value);
			}
		}

		virtual public bool ExistFrom{
			get
			{
				return Strategy.ExistUnitRole(UserMeta.From);
			}
		}

		virtual public void RemoveFrom()
		{
			Strategy.RemoveUnitRole(UserMeta.From);
		}



		virtual public Allors.Extent<global::Domain.User> UsersWhereSelect
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(UserMeta.UsersWhereSelect);
			}
		}

		virtual public bool ExistUsersWhereSelect
		{
			get
			{
				return Strategy.ExistCompositeAssociations(UserMeta.UsersWhereSelect);
			}
		}

	}

	public static class UserMeta
	{
		public static readonly global::Allors.Meta.Class ObjectType = (Allors.Meta.Class)global::Domain.M.D.Find( new System.Guid("0d6bc154-112b-4a58-aa96-3b2a96f82523") );

		public static readonly global::Allors.Meta.RoleType Select = ((Allors.Meta.RelationType)global::Domain.M.D.Find( new System.Guid("1ffa3cb7-41f0-406a-a3a5-2f3a4c5ad59c"))).RoleType;
		public static readonly global::Allors.Meta.RoleType From = ((Allors.Meta.RelationType)global::Domain.M.D.Find( new System.Guid("bc6b71a8-2a66-4b57-9c86-ecf521b973ba"))).RoleType;

		public static readonly global::Allors.Meta.AssociationType UsersWhereSelect = ((Allors.Meta.RelationType)global::Domain.M.D.Find( new System.Guid("1ffa3cb7-41f0-406a-a3a5-2f3a4c5ad59c"))).AssociationType;

	}
}