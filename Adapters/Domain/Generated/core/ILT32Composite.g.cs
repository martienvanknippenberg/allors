// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface ILT32Composite : Allors.IObjectBase
	{


		ILT32Composite Self3
		{ 
			get;
			set;
		}

		bool ExistSelf3
		{
			get;
		}

		void RemoveSelf3();


		ILT32Composite Self2
		{ 
			get;
			set;
		}

		bool ExistSelf2
		{
			get;
		}

		void RemoveSelf2();


		ILT32Composite Self1
		{ 
			get;
			set;
		}

		bool ExistSelf1
		{
			get;
		}

		void RemoveSelf1();



		global::Allors.Extent<ILT32Composite> ILT32CompositesWhereSelf3
		{ 
			get;
		}

		bool ExistILT32CompositesWhereSelf3
		{
			get;
		}


		global::Allors.Extent<ILT32Composite> ILT32CompositesWhereSelf2
		{ 
			get;
		}

		bool ExistILT32CompositesWhereSelf2
		{
			get;
		}


		global::Allors.Extent<ILT32Composite> ILT32CompositesWhereSelf1
		{ 
			get;
		}

		bool ExistILT32CompositesWhereSelf1
		{
			get;
		}

	}

	public class ILT32CompositeMeta
	{
		public static readonly ILT32CompositeMeta Instance = new ILT32CompositeMeta();

		public global::Allors.Meta.Interface ObjectType = global::Allors.Meta.Interfaces.ILT32Composite;

		public global::Allors.Meta.IRoleType Self3 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ILT32CompositeSelf3;
			}
		} 
		public global::Allors.Meta.IRoleType Self2 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ILT32CompositeSelf2;
			}
		} 
		public global::Allors.Meta.IRoleType Self1 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.ILT32CompositeSelf1;
			}
		} 

		public global::Allors.Meta.IAssociationType ILT32CompositesWhereSelf3 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ILT32CompositeSelf3;
			}
		} 
		public global::Allors.Meta.IAssociationType ILT32CompositesWhereSelf2 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ILT32CompositeSelf2;
			}
		} 
		public global::Allors.Meta.IAssociationType ILT32CompositesWhereSelf1 
		{
			get
			{
				return global::Allors.Meta.AssociationTypes.ILT32CompositeSelf1;
			}
		} 

	}
}