// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface Localised : Allors.IObject
	{


		Locale Locale
		{ 
			get;
			set;
		}

		bool ExistLocale
		{
			get;
		}

		void RemoveLocale();

	}

	public class LocalisedMeta
	{
		public static readonly LocalisedMeta Instance = new LocalisedMeta();

		public global::Allors.Meta.Interface ObjectType = global::Allors.Meta.Interfaces.Localised;

		public global::Allors.Meta.RoleType Locale 
		{
			get
			{
				return global::Allors.Meta.RoleTypes.LocalisedLocale;
			}
		} 

	}
}