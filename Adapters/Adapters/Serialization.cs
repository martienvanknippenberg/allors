//------------------------------------------------------------------------------------------------- 
// <copyright file="Serialization.cs" company="Allors bvba">
// Copyright 2002-2013 Allors bvba.
// 
// Dual Licensed under
//   a) the Lesser General Public Licence v3 (LGPL)
//   b) the Allors License
// 
// The LGPL License is included in the file lgpl.txt.
// The Allors License is an addendum to your contract.
// 
// Allors Platform is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// For more information visit http://www.allors.com/legal
// </copyright>
// <summary>Defines the Serialization type.</summary>
//-------------------------------------------------------------------------------------------------
namespace Allors.Adapters
{
    using System;
    using System.Xml;
    using Allors.Meta;
    
    /// <summary>
    /// Xml tag definitions and utility methods for Xml Serialization.
    /// An <see cref="IDatabase"/> is serialized to a <see cref="XmlDocument"/> 
    /// according to the Allors Serialization Xml Schema.
    /// </summary>
    public static class Serialization
    {
        /// <summary>
        /// This is the document element for a serialized <see cref="IDatabase"/>.
        /// </summary>
        public const string Allors = "allors";

        /// <summary>
        /// This attribute holds the version of the Allors Framework when this <see cref="IDatabase"/> was saved.
        /// Attribute of the <see cref="Serialization#Allors"/> element.
        /// </summary>
        public const string Version = "version";

        /// <summary>
        /// The current <see cref="Serialization#Version"/> of the serialization schema.
        /// </summary>
        public const string VersionCurrent = "1";
        
        /// <summary>
        /// This attribute holds the <see cref="ObjectId"/> of the association of a relation. 
        /// Attribute of the <see cref="Serialization#ChangedRelations"/> element.
        /// </summary>
        public const string Association = "a";

        /// <summary>
        /// This attribute is used for <see cref="ObjectType#Id"/> and <see cref="RelationType#Id"/>.
        /// Attribute of the <see cref="Serialization#IObjectType"/> and <see cref="Serialization#RelationType"/> element.
        /// </summary>
        public const string Id = "i";

        /// <summary>
        /// This element is the container for objects and relations.
        /// Child element of the <see cref="Serialization#Allors"/> element.
        /// </summary>
        public const string Population = "population";

        /// <summary>
        /// This element is the container for <see cref="IObject"/>s.
        /// Child element of the <see cref="Serialization#Population"/> element.
        /// </summary>
        public const string Objects = "objects";

        /// <summary>
        /// This element is the container for new <see cref="IObject"/>s.
        /// Child element of the <see cref="Serialization#Objects"/> element.
        /// </summary>
        public const string New = "new";

        /// <summary>
        /// This element is the container for deleted <see cref="IObject"/>s.
        /// Child element of the <see cref="Serialization#Objects"/> element.
        /// </summary>
        public const string Deleted = "deleted";

        /// <summary>
        /// This character is used to group multiple <see cref="ObjectId"/>s into one value.
        /// </summary>
        public const string ObjectsSplitter = ",";

        /// <summary>
        /// This element groups <see cref="IObject"/>s having the same <see cref="ObjectType"/>.
        /// Child element of the <see cref="Serialization#Objects"/> element.
        /// </summary>
        public const string ObjectType = "ot";

        /// <summary>
        /// This element groups the <see cref="IObject"/>s and relations.
        /// Child element of the <see cref="Serialization#Allors"/> element.
        /// </summary>
        public const string Database = "database";

        /// <summary>
        /// This element groups the <see cref="IObject"/>s and relations.
        /// Child element of the <see cref="Serialization#Allors"/> element.
        /// </summary>
        public const string Workspace = "workspace";
        
        /// <summary>
        /// This element holds a relation.
        /// Child element of the <see cref="Serialization#RelationType"/> element.
        /// </summary>
        public const string Relation = "r";

        /// <summary>
        /// This element holds a relation.
        /// Child element of the <see cref="Serialization#RelationType"/> element.
        /// </summary>
        public const string NoRelation = "x";

        /// <summary>
        /// This element is the container for relations.
        /// Child element of the <see cref="Serialization#Population"/> element.
        /// </summary>
        public const string Relations = "relations";

        /// <summary>
        /// This element groups relations having the same <see cref="RelationType"/> and 
        /// where the role's <see cref="ObjectType"/> is a composite.
        /// Child element of the <see cref="Serialization#Relations"/> element.
        /// </summary>
        public const string RelationTypeComposite = "rtc";

        /// <summary>
        /// This element groups relations having the same <see cref="RelationType"/> and 
        /// where the role's <see cref="ObjectType"/> is a unit.
        /// Child element of the <see cref="Serialization#Relations"/> element.
        /// </summary>
        public const string RelationTypeUnit = "rtu";

        /// <summary>
        /// Char array for <see cref="Serialization#ObjectsSplitter"/>.
        /// </summary>
        public static readonly char[] ObjectsSplitterCharArray = { ObjectsSplitter[0] };

        /// <summary>
        /// Checks if the <see cref="IDatabase#Version"/> is correct.
        /// </summary>
        /// <param name="reader">The reader.</param>
        public static void CheckVersion(XmlReader reader)
        {
            var version = reader.GetAttribute(Version);
            if (string.IsNullOrEmpty(version))
            {
                throw new ArgumentException("Save population has no version.");
            }

            if (!VersionCurrent.Equals(version))
            {
                throw new ArgumentException("database supports version " + VersionCurrent + " but found version " + version + ".");
            }
        }

        /// <summary>
        /// <see cref="XmlConvert"/> from the xml unit value.
        /// </summary>
        /// <param name="xmlValue">The XML value.</param>
        /// <param name="unitTypeTag">The unit type tag.</param>
        /// <returns>The converted value</returns>
        public static object ReadString(string xmlValue, UnitTags unitTypeTag)
        {
            switch (unitTypeTag)
            {
                case UnitTags.AllorsString:
                    return xmlValue;
                case UnitTags.AllorsInteger:
                    return XmlConvert.ToInt32(xmlValue);
                case UnitTags.AllorsLong:
                    return XmlConvert.ToInt64(xmlValue);
                case UnitTags.AllorsDecimal:
                    return XmlConvert.ToDecimal(xmlValue);
                case UnitTags.AllorsDouble:
                    return XmlConvert.ToDouble(xmlValue);
                case UnitTags.AllorsBoolean:
                    return XmlConvert.ToBoolean(xmlValue);
                case UnitTags.AllorsDate:
                    return XmlConvert.ToDateTime(xmlValue, XmlDateTimeSerializationMode.Utc);
                case UnitTags.AllorsUnique:
                    return XmlConvert.ToGuid(xmlValue);
                case UnitTags.AllorsBinary:
                    return Convert.FromBase64String(xmlValue);
                default:
                    throw new ArgumentException("Unknown Unit IObjectType: " + unitTypeTag);
            }
        }

        /// <summary>
        /// <see cref="XmlConvert"/> the unit to an XML value..
        /// </summary>
        /// <param name="unitTypeTag">The unit type tag.</param>
        /// <param name="unit">The unit .</param>
        /// <returns>The XML Value</returns>
        public static string WriteString(UnitTags unitTypeTag, object unit)
        {
            switch (unitTypeTag)
            {
                case UnitTags.AllorsString:
                    return (string)unit;
                case UnitTags.AllorsInteger:
                    return XmlConvert.ToString((int)unit);
                case UnitTags.AllorsLong:
                    return XmlConvert.ToString((long)unit);
                case UnitTags.AllorsDecimal:
                    return XmlConvert.ToString((decimal)unit);
                case UnitTags.AllorsDouble:
                    return XmlConvert.ToString((double)unit);
                case UnitTags.AllorsBoolean:
                    return XmlConvert.ToString((bool)unit);
                case UnitTags.AllorsDate:
                    return XmlConvert.ToString((DateTime)unit, XmlDateTimeSerializationMode.Utc);
                case UnitTags.AllorsUnique:
                    return XmlConvert.ToString((Guid)unit);
                case UnitTags.AllorsBinary:
                    return Convert.ToBase64String((byte[])unit);
                default:
                    throw new ArgumentException("Unknown Unit IObjectType: " + unitTypeTag);
            }
        }
    }
}