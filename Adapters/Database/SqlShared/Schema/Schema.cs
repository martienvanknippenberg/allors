// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Schema.cs" company="Allors bvba">
//   Copyright 2002-2013 Allors bvba.
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
// --------------------------------------------------------------------------------------------------------------------

namespace Allors.Adapters.Database.Sql
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;

    using Allors.Meta;

    public abstract class Schema : IEnumerable<SchemaTable>
    {
        /// <summary>
        /// This prefix will be used for
        /// <ul>
        /// <li>System tables (e.g. OC)</li>
        /// <li>Indexes</li>
        /// <li>Parameters</li>
        /// </ul>
        /// in order to avoid naming conflictts with existing tables
        /// </summary>
        public const string AllorsPrefix = "_";

        public readonly string ParamInvocationFormat;
        public readonly string ParamFormat;

        private readonly Database database;

        private readonly string prefix;
        private readonly string postfix;
        
        private Dictionary<MetaRelation, SchemaColumn> columnsByRelationType;
        private Dictionary<MetaRelation, SchemaTable> tablesByRelationType;
        private Dictionary<MetaObject, SchemaTable> tableByObjectType;
        private Dictionary<string, SchemaTable> tablesByName;

        private SchemaColumn objectId;
        private SchemaColumn associationId;
        private SchemaColumn roleId;
        private SchemaColumn typeId;
        private SchemaColumn cacheId;

        private SchemaTable objects;
        private SchemaColumn objectsObjectId;
        private SchemaColumn objectsTypeId;
        private SchemaColumn objectsCacheId;

        private SchemaParameter countParam;
        private SchemaParameter matchRoleParam;

        private DbType cacheDbType;
        private DbType typeDbType;
        private DbType singletonDbType;
        private DbType versionDbType;

        protected Schema(Database database, string paramInvocationFormat, string paramFormat, string prefix, string postfix)
        {
            this.database = database;
            this.ParamInvocationFormat = paramInvocationFormat;
            this.ParamFormat = paramFormat;
            this.prefix = prefix;
            this.postfix = postfix;
        }

        public abstract SchemaValidationErrors SchemaValidationErrors { get; }

        /// <summary>
        /// Gets the parameter to pass a count to.
        /// <example>
        /// Is used in CreateObjects to denote the amount of objects to create.
        /// </example>
        /// </summary>
        public SchemaParameter CountParam
        {
            get { return this.countParam; }
        }

        public SchemaParameter MatchRoleParam
        {
            get { return this.matchRoleParam; }
        }

        public SchemaColumn TypeId
        {
            get { return this.typeId; }
        }

        public SchemaColumn CacheId
        {
            get { return this.cacheId; }
        }

        public SchemaColumn AssociationId
        {
            get { return this.associationId; }
        }

        public SchemaColumn RoleId
        {
            get { return this.roleId; }
        }

        public SchemaColumn ObjectId
        {
            get { return this.objectId; }
        }

        public SchemaTable Objects
        {
            get { return this.objects; }
        }

        public SchemaColumn ObjectsObjectId
        {
            get { return this.objectsObjectId; }
        }

        public SchemaColumn ObjectsTypeId
        {
            get { return this.objectsTypeId; }
        }

        public SchemaColumn ObjectsCacheId
        {
            get { return this.objectsCacheId; }
        }

        public int SingletonValue
        {
            get
            {
                return 1;
            }
        }

        public abstract IEnumerable<SchemaProcedure> Procedures { get; }

        /// <summary>
        /// Gets the type used to store object (ids) .
        /// </summary>
        protected abstract DbType ObjectDbType { get; }
        
        protected Database Database
        {
            get { return this.database; }
        }

        protected Dictionary<MetaRelation, SchemaColumn> ColumnsByRelationType
        {
            get { return this.columnsByRelationType; }
        }

        protected Dictionary<string, SchemaTable> TablesByName
        {
            get { return this.tablesByName; }
        }

        protected Dictionary<MetaRelation, SchemaTable> TablesByRelationType
        {
            get { return this.tablesByRelationType; }
        }

        protected Dictionary<MetaObject, SchemaTable> TableByObjectType
        {
            get { return this.tableByObjectType; }
        }

        private DbType TypeDbType
        {
            get { return this.typeDbType; }
        }

        private DbType CacheDbType
        {
            get { return this.cacheDbType; }
        }

        private DbType VersionDbType
        {
            get { return this.versionDbType; }
        }

        private DbType SingletonDbType
        {
            get { return this.singletonDbType; }
        }

        public SchemaTable this[string tableName]
        {
            get { return this.tablesByName[tableName.ToLowerInvariant()]; }
        }

        public static void AddError(SchemaValidationErrors schemaValidationErrors, SchemaTable table, SchemaValidationErrorKind kind)
        {
            schemaValidationErrors.AddTableError(table.ObjectType, table.RelationType, null, table.ToString(), null, kind, kind + ": " + table);
        }

        public static void AddError(SchemaValidationErrors schemaValidationErrors, SchemaTable table, SchemaColumn column, SchemaValidationErrorKind kind)
        {
            var roleType = column.RelationType == null ? null : column.RelationType.RoleType;
            schemaValidationErrors.AddTableError(null, null, roleType, table.ToString(), column.ToString(), kind, kind + ": " + table + "." + column);
        }

        public static void AddError(SchemaValidationErrors schemaValidationErrors, SchemaProcedure schemaProcedure, SchemaValidationErrorKind kind, string message)
        {
            schemaValidationErrors.AddProcedureError(schemaProcedure, kind, message);
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable<SchemaTable>)this).GetEnumerator();
        }

        IEnumerator<SchemaTable> IEnumerable<SchemaTable>.GetEnumerator()
        {
            return this.tablesByName.Values.GetEnumerator();
        }

        public SchemaColumn Column(MetaRelation relationType)
        {
            return this.columnsByRelationType[relationType];
        }

        public SchemaColumn Column(MetaAssociation association)
        {
            return this.columnsByRelationType[association.RelationTypeWhereAssociationType];
        }

        public SchemaColumn Column(MetaRole role)
        {
            return this.columnsByRelationType[role.RelationTypeWhereRoleType];
        }

        public SchemaTable Table(MetaObject type)
        {
            return this.tableByObjectType[type];
        }

        public SchemaTable Table(MetaRelation relationType)
        {
            return this.tablesByRelationType[relationType];
        }

        public SchemaTable Table(MetaAssociation association)
        {
            return this.tablesByRelationType[association.RelationTypeWhereAssociationType];
        }

        public SchemaTable Table(MetaRole role)
        {
            return this.tablesByRelationType[role.RelationTypeWhereRoleType];
        }

        public string EscapeIfReserved(string name)
        {
            if (ReservedWords.Names.Contains(name.ToLowerInvariant()))
            {
                return this.prefix + name + this.postfix;
            }

            return name;
        }

        public abstract SchemaParameter CreateParameter(string name, DbType dbType);

        protected virtual void OnConstructed()
        {
            this.countParam = this.CreateParameter("COUNT", DbType.Int32);
            this.matchRoleParam = this.CreateParameter("MR", DbType.Guid);

            this.typeDbType = DbType.Guid;
            this.cacheDbType = DbType.Int32;
            this.singletonDbType = DbType.Int32;
            this.versionDbType = DbType.Guid;

            this.tablesByName = new Dictionary<string, SchemaTable>();

            this.tableByObjectType = new Dictionary<MetaObject, SchemaTable>();
            this.tablesByRelationType = new Dictionary<MetaRelation, SchemaTable>();
            this.columnsByRelationType = new Dictionary<MetaRelation, SchemaColumn>();

            this.objectId = new SchemaColumn(this, "O", this.ObjectDbType, false, true, SchemaIndexType.None);
            this.cacheId = new SchemaColumn(this, "C", this.CacheDbType, false, false, SchemaIndexType.None);
            this.associationId = new SchemaColumn(this, "A", this.ObjectDbType, false, true, SchemaIndexType.None);
            this.roleId = new SchemaColumn(this, "R", this.ObjectDbType, false, true, SchemaIndexType.None);
            this.typeId = new SchemaColumn(this, "T", this.TypeDbType, false, false, SchemaIndexType.None);

            // Objects
            this.objects = new SchemaTable(this, AllorsPrefix + "O", SchemaTableKind.System);
            this.objectsObjectId = new SchemaColumn(this, this.ObjectId.Name, this.ObjectDbType, true, true, SchemaIndexType.None);
            this.objectsCacheId = new SchemaColumn(this, "C", this.CacheDbType, false, false, SchemaIndexType.None);
            this.objectsTypeId = new SchemaColumn(this, this.TypeId.Name, this.TypeDbType, false, false, SchemaIndexType.None);

            this.Objects.AddColumn(this.ObjectsObjectId);
            this.Objects.AddColumn(this.ObjectsTypeId);
            this.Objects.AddColumn(this.ObjectsCacheId);
            this.tablesByName.Add(this.Objects.Name, this.Objects);

            this.CreateTablesFromMeta();
        }
        
        protected virtual DbType GetDbType(MetaRole role)
        {
            var unitTypeTag = (MetaUnitTags)role.ObjectType.UnitTag;
            switch (unitTypeTag)
            {
                case MetaUnitTags.AllorsString:
                    return DbType.String;
                case MetaUnitTags.AllorsInteger:
                    return DbType.Int32;
                case MetaUnitTags.AllorsLong:
                    return DbType.Int64;
                case MetaUnitTags.AllorsDecimal:
                    return DbType.Decimal;
                case MetaUnitTags.AllorsDouble:
                    return DbType.Double;
                case MetaUnitTags.AllorsBoolean:
                    return DbType.Boolean;
                case MetaUnitTags.AllorsDateTime:
                    return DbType.DateTime;
                case MetaUnitTags.AllorsUnique:
                    return DbType.Guid;
                case MetaUnitTags.AllorsBinary:
                    return DbType.Binary;
                default:
                    throw new ArgumentException("Unkown unit type " + role.ObjectType);
            }
        }

        protected bool Contains(string tableName)
        {
            return this.tablesByName.ContainsKey(tableName.ToLowerInvariant());
        }

        private void CreateTablesFromMeta()
        {
            foreach (var relationType in this.Database.Domain.RelationTypes)
            {
                var associationType = relationType.AssociationType;
                var roleType = relationType.RoleType;

                if (!roleType.ObjectType.IsUnit && ((associationType.IsMany && roleType.IsMany) || !relationType.ExistExclusiveRootClasses))
                {
                    var column = new SchemaColumn(this, "R", this.ObjectDbType, false, true, relationType.IsIndexed ? SchemaIndexType.Combined : SchemaIndexType.None, relationType);
                    this.ColumnsByRelationType.Add(relationType, column);
                }
                else
                {
                    if (roleType.ObjectType.IsUnit)
                    {
                        int? size = null;
                        int? precision = null;
                        int? scale = null;
                        if (roleType.ExistSize)
                        {
                            size = roleType.Size;
                        }

                        if (roleType.ExistPrecision)
                        {
                            precision = roleType.Precision;
                        }

                        if (roleType.ExistScale)
                        {
                            scale = roleType.Scale;
                        }

                        var column = new SchemaColumn(this, roleType.RootName, this.GetDbType(roleType), false, false, relationType.IsIndexed ? SchemaIndexType.Single : SchemaIndexType.None, relationType, size, precision, scale);
                        this.ColumnsByRelationType.Add(relationType, column);
                    }
                    else if (relationType.ExistExclusiveRootClasses)
                    {
                        if (roleType.IsOne)
                        {
                            var column = new SchemaColumn(this, roleType.RootName, this.ObjectDbType, false, false, relationType.IsIndexed ? SchemaIndexType.Combined : SchemaIndexType.None, relationType);
                            this.ColumnsByRelationType.Add(relationType, column);
                        }
                        else
                        {
                            var column = new SchemaColumn(this, associationType.RootName, this.ObjectDbType, false, false, relationType.IsIndexed ? SchemaIndexType.Combined : SchemaIndexType.None, relationType);
                            this.ColumnsByRelationType.Add(relationType, column);
                        }
                    }
                }
            }

            foreach (var objectType in this.Database.Domain.CompositeObjectTypes)
            {
                if (objectType.IsRootClass)
                {
                    var schemaTable = new SchemaTable(this, objectType.SingularName, SchemaTableKind.Object, objectType);
                    this.TablesByName.Add(schemaTable.Name, schemaTable);
                    this.TableByObjectType.Add(objectType, schemaTable);

                    schemaTable.AddColumn(this.ObjectId);
                    schemaTable.AddColumn(this.TypeId);

                    var roleTypes = new List<MetaRole>();
                    var associationTypes = new List<MetaAssociation>();

                    var subClassesAndSelf = new List<MetaObject>(objectType.Subclasses) { objectType };

                    foreach (var subClass in subClassesAndSelf)
                    {
                        foreach (var roleType in subClass.ExclusiveRoleTypes)
                        {
                            if (!roleTypes.Contains(roleType))
                            {
                                roleTypes.Add(roleType);
                            }
                        }

                        foreach (var associationType in subClass.ExclusiveAssociationTypes)
                        {
                            if (!associationTypes.Contains(associationType))
                            {
                                associationTypes.Add(associationType);
                            }
                        }
                    }

                    foreach (var associationType in associationTypes)
                    {
                        var relationType = associationType.RelationTypeWhereAssociationType;
                        var roleType = relationType.RoleType;
                        if (!(associationType.IsMany && roleType.IsMany) && relationType.ExistExclusiveRootClasses && roleType.IsMany)
                        {
                            schemaTable.AddColumn(this.Column(relationType));
                        }
                    }

                    foreach (var roleType in roleTypes)
                    {
                        var relationType = roleType.RelationTypeWhereRoleType;
                        var associationType = relationType.AssociationType;
                        if (roleType.ObjectType.IsUnit)
                        {
                            schemaTable.AddColumn(this.Column(relationType));
                        }
                        else
                        {
                            if (!(associationType.IsMany && roleType.IsMany) && relationType.ExistExclusiveRootClasses && !roleType.IsMany)
                            {
                                schemaTable.AddColumn(this.Column(relationType));
                            }
                        }
                    }
                }
            }

            foreach (var relationType in this.Database.Domain.RelationTypes)
            {
                var associationType = relationType.AssociationType;
                var roleType = relationType.RoleType;

                if (!roleType.ObjectType.IsUnit && ((associationType.IsMany && roleType.IsMany) || !relationType.ExistExclusiveRootClasses))
                {
                    var schemaTable = new SchemaTable(this, relationType.Name, SchemaTableKind.Relation, relationType);
                    this.TablesByName.Add(schemaTable.Name, schemaTable);
                    this.TablesByRelationType.Add(relationType, schemaTable);

                    schemaTable.AddColumn(this.AssociationId);
                    schemaTable.AddColumn(this.Column(relationType));
                }
            }
        }
    }
}