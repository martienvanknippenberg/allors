// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Domain
{
	public partial interface ILT32Composite : Allors.IObject
	{


		global::Domain.ILT32Composite ILT32CompositeSelf3
		{ 
			get;
			set;
		}

		bool ExistILT32CompositeSelf3
		{
			get;
		}

		void RemoveILT32CompositeSelf3();


		global::Domain.ILT32Composite ILT32CompositeSelf2
		{ 
			get;
			set;
		}

		bool ExistILT32CompositeSelf2
		{
			get;
		}

		void RemoveILT32CompositeSelf2();


		global::Domain.ILT32Composite ILT32CompositeSelf1
		{ 
			get;
			set;
		}

		bool ExistILT32CompositeSelf1
		{
			get;
		}

		void RemoveILT32CompositeSelf1();



		Allors.Extent<global::Domain.ILT32Composite> ILT32CompositesWhereSelf3
		{ 
			get;
		}

		bool ExistILT32CompositesWhereSelf3
		{
			get;
		}


		Allors.Extent<global::Domain.ILT32Composite> ILT32CompositesWhereSelf2
		{ 
			get;
		}

		bool ExistILT32CompositesWhereSelf2
		{
			get;
		}


		Allors.Extent<global::Domain.ILT32Composite> ILT32CompositesWhereSelf1
		{ 
			get;
		}

		bool ExistILT32CompositesWhereSelf1
		{
			get;
		}

	}

	public static class ILT32CompositeMeta
	{
		public static readonly global::Allors.Meta.Interface ObjectType = (Allors.Meta.Interface)global::Domain.M.D.Find( new System.Guid("4f53e1e7-e88a-4161-969c-1fed0b3a24a2") );

		public static readonly global::Allors.Meta.RoleType ILT32CompositeSelf3 = ((Allors.Meta.RelationType)global::Domain.M.D.Find( new System.Guid("be3fc71d-66d8-411f-ab5f-4ed91e437852"))).RoleType;
		public static readonly global::Allors.Meta.RoleType ILT32CompositeSelf2 = ((Allors.Meta.RelationType)global::Domain.M.D.Find( new System.Guid("c03a8b50-7fd1-4304-9d45-2c699fcbee80"))).RoleType;
		public static readonly global::Allors.Meta.RoleType ILT32CompositeSelf1 = ((Allors.Meta.RelationType)global::Domain.M.D.Find( new System.Guid("d0eeeb45-97a6-465e-9a05-7e0fa970a969"))).RoleType;

		public static readonly global::Allors.Meta.AssociationType ILT32CompositesWhereSelf3 = ((Allors.Meta.RelationType)global::Domain.M.D.Find( new System.Guid("be3fc71d-66d8-411f-ab5f-4ed91e437852"))).AssociationType;
		public static readonly global::Allors.Meta.AssociationType ILT32CompositesWhereSelf2 = ((Allors.Meta.RelationType)global::Domain.M.D.Find( new System.Guid("c03a8b50-7fd1-4304-9d45-2c699fcbee80"))).AssociationType;
		public static readonly global::Allors.Meta.AssociationType ILT32CompositesWhereSelf1 = ((Allors.Meta.RelationType)global::Domain.M.D.Find( new System.Guid("d0eeeb45-97a6-465e-9a05-7e0fa970a969"))).AssociationType;

	}
}