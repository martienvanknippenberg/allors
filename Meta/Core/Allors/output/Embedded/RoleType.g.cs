namespace Allors.Meta.AllorsGenerated
{
	internal interface AllorsInternalRoleType : AllorsInternalPropertyType, AllorsInternal
	{
		global::Allors.Meta.ObjectType ObjectType
		{
			get;
			set;
		}

		void RemoveObjectType();

		bool ExistObjectType
		{
			get;
		}

		void AllorsRemoveRoleTypeObjectType();


		global::Allors.Meta.ObjectType[] DerivedRootTypes
		{
			get;
			set;
		}

		void AddDerivedRootType( global::Allors.Meta.ObjectType addRole );

		void RemoveDerivedRootType( global::Allors.Meta.ObjectType removeRole );

		void RemoveDerivedRootTypes();

		bool ExistDerivedRootTypes
		{
			get;
		}
		void AllorsRemoveRoleTypeDerivedRootType();

		void AllorsRemoveRoleTypeDerivedRootType( global::Allors.Meta.ObjectType role );


		global::System.Int32 Scale
		{
			get;
			set;
		}

		void RemoveScale();

		bool ExistScale
		{
			get;
		}


		global::System.Int32 Precision
		{
			get;
			set;
		}

		void RemovePrecision();

		bool ExistPrecision
		{
			get;
		}


		global::System.Int32 Size
		{
			get;
			set;
		}

		void RemoveSize();

		bool ExistSize
		{
			get;
		}


		global::System.String DerivedHierarchyPluralName
		{
			get;
			set;
		}

		void RemoveDerivedHierarchyPluralName();

		bool ExistDerivedHierarchyPluralName
		{
			get;
		}


		global::System.String DerivedHierarchySingularName
		{
			get;
			set;
		}

		void RemoveDerivedHierarchySingularName();

		bool ExistDerivedHierarchySingularName
		{
			get;
		}


		global::System.String AssignedPluralName
		{
			get;
			set;
		}

		void RemoveAssignedPluralName();

		bool ExistAssignedPluralName
		{
			get;
		}


		global::System.String DerivedRootName
		{
			get;
			set;
		}

		void RemoveDerivedRootName();

		bool ExistDerivedRootName
		{
			get;
		}


		global::System.Boolean IsMany
		{
			get;
			set;
		}

		void RemoveIsMany();

		bool ExistIsMany
		{
			get;
		}


		global::System.String AssignedSingularName
		{
			get;
			set;
		}

		void RemoveAssignedSingularName();

		bool ExistAssignedSingularName
		{
			get;
		}


		global::Allors.Meta.ObjectType[] ObjectTypesWhereDerivedUnitRoleType
		{
			get;
		}

		bool ExistObjectTypesWhereDerivedUnitRoleType
		{
			get;
		}

		void AllorsRoleSyncAddDerivedUnitRoleTypeObjectType(global::Allors.Meta.ObjectType association );

		void AllorsRoleSyncRemoveDerivedUnitRoleTypeObjectType(global::Allors.Meta.ObjectType association );

		void AllorsRoleReleaseDerivedUnitRoleTypeObjectType();



		global::Allors.Meta.RelationType RelationTypeWhereRoleType
		{
			get;
		}

		bool ExistRelationTypeWhereRoleType
		{
			get;
		}


		void AllorsRoleSyncSetRoleTypeRelationType(global::Allors.Meta.RelationType association );


		void AllorsRoleReleaseRoleTypeRelationType();


		global::Allors.Meta.ObjectType[] ObjectTypesWhereDerivedCompositeRoleType
		{
			get;
		}

		bool ExistObjectTypesWhereDerivedCompositeRoleType
		{
			get;
		}

		void AllorsRoleSyncAddDerivedCompositeRoleTypeObjectType(global::Allors.Meta.ObjectType association );

		void AllorsRoleSyncRemoveDerivedCompositeRoleTypeObjectType(global::Allors.Meta.ObjectType association );

		void AllorsRoleReleaseDerivedCompositeRoleTypeObjectType();


		global::Allors.Meta.ObjectType[] ObjectTypesWhereDerivedRoleType
		{
			get;
		}

		bool ExistObjectTypesWhereDerivedRoleType
		{
			get;
		}

		void AllorsRoleSyncAddDerivedRoleTypeObjectType(global::Allors.Meta.ObjectType association );

		void AllorsRoleSyncRemoveDerivedRoleTypeObjectType(global::Allors.Meta.ObjectType association );

		void AllorsRoleReleaseDerivedRoleTypeObjectType();


		global::Allors.Meta.ObjectType[] ObjectTypesWhereDerivedExclusiveRoleType
		{
			get;
		}

		bool ExistObjectTypesWhereDerivedExclusiveRoleType
		{
			get;
		}

		void AllorsRoleSyncAddDerivedExclusiveRoleTypeObjectType(global::Allors.Meta.ObjectType association );

		void AllorsRoleSyncRemoveDerivedExclusiveRoleTypeObjectType(global::Allors.Meta.ObjectType association );

		void AllorsRoleReleaseDerivedExclusiveRoleTypeObjectType();


	}

	public interface AllorsInterfaceRoleType :  AllorsEmbeddedObject 
	{
	}

	[System.Diagnostics.DebuggerNonUserCode]
	public abstract class AllorsClassRoleType :  global::Allors.Meta.PropertyType,  AllorsInternalRoleType , AllorsEmbeddedObject
	{
		protected global::Allors.Meta.ObjectType _RoleTypeObjectType;


		protected global::Allors.Meta.ObjectType[] _RoleTypeDerivedRootType = AllorsEmbeddedArrays.EMPTY_ObjectType_ARRAY;


		protected System.Object _RoleTypeScale;


		protected System.Object _RoleTypePrecision;


		protected System.Object _RoleTypeSize;


		protected System.Object _RoleTypeDerivedHierarchyPluralName;


		protected System.Object _RoleTypeDerivedHierarchySingularName;


		protected System.Object _RoleTypeAssignedPluralName;


		protected System.Object _RoleTypeDerivedRootName;


		protected System.Object _RoleTypeIsMany;


		protected System.Object _RoleTypeAssignedSingularName;


		protected global::Allors.Meta.ObjectType[] _DerivedUnitRoleTypeObjectType = AllorsEmbeddedArrays.EMPTY_ObjectType_ARRAY;


		protected global::Allors.Meta.RelationType _RoleTypeRelationType;


		protected global::Allors.Meta.ObjectType[] _DerivedCompositeRoleTypeObjectType = AllorsEmbeddedArrays.EMPTY_ObjectType_ARRAY;


		protected global::Allors.Meta.ObjectType[] _DerivedRoleTypeObjectType = AllorsEmbeddedArrays.EMPTY_ObjectType_ARRAY;


		protected global::Allors.Meta.ObjectType[] _DerivedExclusiveRoleTypeObjectType = AllorsEmbeddedArrays.EMPTY_ObjectType_ARRAY;




		/// <summary>
		/// Initializes a new instance of the <see cref="AllorsClassRoleType"/> class.
		/// </summary>
		/// <param name="session">The Allors Session.</param>
		/// <param name="id">The Allors Object Id.</param>
		protected AllorsClassRoleType(AllorsEmbeddedSession session, System.Int32 id) : base(session,id){}

		/// <summary>
		/// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <returns>
		/// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
		/// </returns>
		public override System.String ToString() {
			return this.GetType().Name + " (" + this.AllorsObjectId + ")";
		}

		/// <summary>
		/// Gets the Object Type Id.
		/// </summary>
		/// <value>The Object Type Id.</value>
		public override System.Guid AllorsObjectTypeId
		{ 
			get
			{
				//TODO: make static
				return new System.Guid("903d3eb5-dc70-4cb4-93b8-5a1d0899c949");
			}
		}

	    object AllorsInternal.GetRole(AllorsEmbeddedRelationType relation)
		{
	        switch(relation.Tag)
			{
				case AllorsRelationTags.RoleTypeObjectType:
					return _RoleTypeObjectType;
				case AllorsRelationTags.RoleTypeDerivedRootType:
					return _RoleTypeDerivedRootType;
				case AllorsRelationTags.RoleTypeScale:
					return _RoleTypeScale;
				case AllorsRelationTags.RoleTypePrecision:
					return _RoleTypePrecision;
				case AllorsRelationTags.RoleTypeSize:
					return _RoleTypeSize;
				case AllorsRelationTags.RoleTypeDerivedHierarchyPluralName:
					return _RoleTypeDerivedHierarchyPluralName;
				case AllorsRelationTags.RoleTypeDerivedHierarchySingularName:
					return _RoleTypeDerivedHierarchySingularName;
				case AllorsRelationTags.RoleTypeAssignedPluralName:
					return _RoleTypeAssignedPluralName;
				case AllorsRelationTags.RoleTypeDerivedRootName:
					return _RoleTypeDerivedRootName;
				case AllorsRelationTags.RoleTypeIsMany:
					return _RoleTypeIsMany;
				case AllorsRelationTags.RoleTypeAssignedSingularName:
					return _RoleTypeAssignedSingularName;
				case AllorsRelationTags.MetaObjectId:
					return _MetaObjectId;

		default:
				throw new System.ArgumentException("Illegal relation " + relation.Name);
			}
		}

		void AllorsInternal.SetRole(AllorsEmbeddedRelationType relation, object role)
		{
			switch(relation.Tag)
			{
				case AllorsRelationTags.RoleTypeObjectType:
					RoleSetRoleTypeObjectType((global::Allors.Meta.ObjectType)role);
					break;
				case AllorsRelationTags.RoleTypeDerivedRootType:
					RoleSetRoleTypeDerivedRootType((global::Allors.Meta.ObjectType[])role);
					break;
				case AllorsRelationTags.RoleTypeScale:
					RoleSetRoleTypeScale((global::System.Int32)role);
					break;
				case AllorsRelationTags.RoleTypePrecision:
					RoleSetRoleTypePrecision((global::System.Int32)role);
					break;
				case AllorsRelationTags.RoleTypeSize:
					RoleSetRoleTypeSize((global::System.Int32)role);
					break;
				case AllorsRelationTags.RoleTypeDerivedHierarchyPluralName:
					RoleSetRoleTypeDerivedHierarchyPluralName((global::System.String)role);
					break;
				case AllorsRelationTags.RoleTypeDerivedHierarchySingularName:
					RoleSetRoleTypeDerivedHierarchySingularName((global::System.String)role);
					break;
				case AllorsRelationTags.RoleTypeAssignedPluralName:
					RoleSetRoleTypeAssignedPluralName((global::System.String)role);
					break;
				case AllorsRelationTags.RoleTypeDerivedRootName:
					RoleSetRoleTypeDerivedRootName((global::System.String)role);
					break;
				case AllorsRelationTags.RoleTypeIsMany:
					RoleSetRoleTypeIsMany((global::System.Boolean)role);
					break;
				case AllorsRelationTags.RoleTypeAssignedSingularName:
					RoleSetRoleTypeAssignedSingularName((global::System.String)role);
					break;
				case AllorsRelationTags.MetaObjectId:
					RoleSetMetaObjectId((global::System.Guid)role);
					break;

		default:
				throw new System.ArgumentException("Illegal relation " + relation.Name);
			}
		}


		public virtual global::Allors.Meta.ObjectType ObjectType
		{
			get
			{
			    return _RoleTypeObjectType;
			}

			set
			{
				AllorsAssert(value);
				RoleSetRoleTypeObjectType(value);
			}
		}

		protected void RoleSetRoleTypeObjectType(global::Allors.Meta.ObjectType value)
		{
			((AllorsInternalRoleType)this).AllorsRemoveRoleTypeObjectType();
			if( value != null ) 
			{
				_RoleTypeObjectType = value;
				_RoleTypeObjectType = value;
				// role side
				((AllorsInternalObjectType)_RoleTypeObjectType).AllorsRoleSyncAddObjectTypeRoleType((global::Allors.Meta.RoleType) this ); 
			}
		}

		public virtual void RemoveObjectType()
		{
			((AllorsInternalRoleType)this).AllorsRemoveRoleTypeObjectType();
		}

		void AllorsInternalRoleType.AllorsRemoveRoleTypeObjectType()
		{
		    if( _RoleTypeObjectType != null) 
			{
				((AllorsInternalObjectType)_RoleTypeObjectType).AllorsRoleSyncRemoveObjectTypeRoleType( (global::Allors.Meta.RoleType) this ); 
				_RoleTypeObjectType = null;
				_RoleTypeObjectType = null;
			}
		}

		public virtual bool ExistObjectType
		{
			get
			{
				return _RoleTypeObjectType != null;
			}
		}

		public virtual global::Allors.Meta.ObjectType[] DerivedRootTypes
		{
			get
			{
			    return _RoleTypeDerivedRootType;
			}

			set
			{ 
				AllorsAssert(value);
				RoleSetRoleTypeDerivedRootType(value);
			}
		}

		protected void RoleSetRoleTypeDerivedRootType(global::Allors.Meta.ObjectType[] roles)
		{
			((AllorsInternalRoleType)this).AllorsRemoveRoleTypeDerivedRootType();
			if( roles != null && roles.Length > 0 )
			{
				foreach( global::Allors.Meta.ObjectType role in roles )
				{
					RoleAddDerivedRootType(role);
				}
			}
		}

		public virtual void AddDerivedRootType( global::Allors.Meta.ObjectType addRole )
		{
			RoleAddDerivedRootType( addRole );
		}

		void RoleAddDerivedRootType( global::Allors.Meta.ObjectType addRole )
		{
			AllorsAssert(addRole);
			if( addRole != null )
			{
				if( !AllorsEmbeddedArrays.Exist( _RoleTypeDerivedRootType, addRole ) ) 
				{
					// association side
					_RoleTypeDerivedRootType = (global::Allors.Meta.ObjectType[]) AllorsEmbeddedArrays.Add( _RoleTypeDerivedRootType, addRole );
					// role side
					((AllorsInternalObjectType)addRole).AllorsRoleSyncAddDerivedRootTypeRoleType( (global::Allors.Meta.RoleType) this ); 
				}
			}
		}

		public virtual void RemoveDerivedRootType( global::Allors.Meta.ObjectType removeRole ) 
		{
			((AllorsInternalRoleType)this).AllorsRemoveRoleTypeDerivedRootType( removeRole );
		}

		void AllorsInternalRoleType.AllorsRemoveRoleTypeDerivedRootType( global::Allors.Meta.ObjectType removeRole ) 
		{
			AllorsAssert(removeRole);
			if( removeRole != null )
			{
				if(AllorsEmbeddedArrays.Exist( _RoleTypeDerivedRootType, removeRole ) ) 
				{
					_RoleTypeDerivedRootType = (global::Allors.Meta.ObjectType[]) AllorsEmbeddedArrays.Remove( _RoleTypeDerivedRootType, removeRole );
					// role side
					((AllorsInternalObjectType)removeRole).AllorsRoleSyncRemoveDerivedRootTypeRoleType( (global::Allors.Meta.RoleType) this ); 
			
				}
			}
		}

		public virtual void RemoveDerivedRootTypes()
		{
			((AllorsInternalRoleType)this).AllorsRemoveRoleTypeDerivedRootType();
		}

		void AllorsInternalRoleType.AllorsRemoveRoleTypeDerivedRootType()
		{
		    if( _RoleTypeDerivedRootType!=null )
			{
				foreach( global::Allors.Meta.ObjectType role in _RoleTypeDerivedRootType ) 
				{
					// role side
					((AllorsInternalObjectType)role).AllorsRoleSyncRemoveDerivedRootTypeRoleType( (global::Allors.Meta.RoleType) this ); 
				}
			}
			_RoleTypeDerivedRootType = AllorsEmbeddedArrays.EMPTY_ObjectType_ARRAY;
		}

		public virtual bool ExistDerivedRootTypes
		{
			get
			{
				return _RoleTypeDerivedRootType.Length > 0;
			}
		}


		public virtual global::System.Int32 Scale
		{
			get
			{
			    return (global::System.Int32)_RoleTypeScale;
			}

			set
			{
			    RoleSetRoleTypeScale(value);
			}
		}

		protected void RoleSetRoleTypeScale(global::System.Int32 role)
		{
			_RoleTypeScale = role;
		}

		public virtual bool ExistScale
		{
			get
			{
				return _RoleTypeScale != null;
			}
		}

		public virtual void RemoveScale()
		{
			_RoleTypeScale = null;
		}

		public virtual global::System.Int32 Precision
		{
			get
			{
			    return (global::System.Int32)_RoleTypePrecision;
			}

			set
			{
			    RoleSetRoleTypePrecision(value);
			}
		}

		protected void RoleSetRoleTypePrecision(global::System.Int32 role)
		{
			_RoleTypePrecision = role;
		}

		public virtual bool ExistPrecision
		{
			get
			{
				return _RoleTypePrecision != null;
			}
		}

		public virtual void RemovePrecision()
		{
			_RoleTypePrecision = null;
		}

		public virtual global::System.Int32 Size
		{
			get
			{
			    return (global::System.Int32)_RoleTypeSize;
			}

			set
			{
			    RoleSetRoleTypeSize(value);
			}
		}

		protected void RoleSetRoleTypeSize(global::System.Int32 role)
		{
			_RoleTypeSize = role;
		}

		public virtual bool ExistSize
		{
			get
			{
				return _RoleTypeSize != null;
			}
		}

		public virtual void RemoveSize()
		{
			_RoleTypeSize = null;
		}

		public virtual global::System.String DerivedHierarchyPluralName
		{
			get
			{
			    return (global::System.String)_RoleTypeDerivedHierarchyPluralName;
			}

			set
			{
			    RoleSetRoleTypeDerivedHierarchyPluralName(value);
			}
		}

		protected void RoleSetRoleTypeDerivedHierarchyPluralName(global::System.String role)
		{
			_RoleTypeDerivedHierarchyPluralName = role;
		}

		public virtual bool ExistDerivedHierarchyPluralName
		{
			get
			{
				return _RoleTypeDerivedHierarchyPluralName != null;
			}
		}

		public virtual void RemoveDerivedHierarchyPluralName()
		{
			_RoleTypeDerivedHierarchyPluralName = null;
		}

		public virtual global::System.String DerivedHierarchySingularName
		{
			get
			{
			    return (global::System.String)_RoleTypeDerivedHierarchySingularName;
			}

			set
			{
			    RoleSetRoleTypeDerivedHierarchySingularName(value);
			}
		}

		protected void RoleSetRoleTypeDerivedHierarchySingularName(global::System.String role)
		{
			_RoleTypeDerivedHierarchySingularName = role;
		}

		public virtual bool ExistDerivedHierarchySingularName
		{
			get
			{
				return _RoleTypeDerivedHierarchySingularName != null;
			}
		}

		public virtual void RemoveDerivedHierarchySingularName()
		{
			_RoleTypeDerivedHierarchySingularName = null;
		}

		public virtual global::System.String AssignedPluralName
		{
			get
			{
			    return (global::System.String)_RoleTypeAssignedPluralName;
			}

			set
			{
			    RoleSetRoleTypeAssignedPluralName(value);
			}
		}

		protected void RoleSetRoleTypeAssignedPluralName(global::System.String role)
		{
			_RoleTypeAssignedPluralName = role;
		}

		public virtual bool ExistAssignedPluralName
		{
			get
			{
				return _RoleTypeAssignedPluralName != null;
			}
		}

		public virtual void RemoveAssignedPluralName()
		{
			_RoleTypeAssignedPluralName = null;
		}

		public virtual global::System.String DerivedRootName
		{
			get
			{
			    return (global::System.String)_RoleTypeDerivedRootName;
			}

			set
			{
			    RoleSetRoleTypeDerivedRootName(value);
			}
		}

		protected void RoleSetRoleTypeDerivedRootName(global::System.String role)
		{
			_RoleTypeDerivedRootName = role;
		}

		public virtual bool ExistDerivedRootName
		{
			get
			{
				return _RoleTypeDerivedRootName != null;
			}
		}

		public virtual void RemoveDerivedRootName()
		{
			_RoleTypeDerivedRootName = null;
		}

		public virtual global::System.Boolean IsMany
		{
			get
			{
			    return (global::System.Boolean)_RoleTypeIsMany;
			}

			set
			{
			    RoleSetRoleTypeIsMany(value);
			}
		}

		protected void RoleSetRoleTypeIsMany(global::System.Boolean role)
		{
			_RoleTypeIsMany = role;
		}

		public virtual bool ExistIsMany
		{
			get
			{
				return _RoleTypeIsMany != null;
			}
		}

		public virtual void RemoveIsMany()
		{
			_RoleTypeIsMany = null;
		}

		public virtual global::System.String AssignedSingularName
		{
			get
			{
			    return (global::System.String)_RoleTypeAssignedSingularName;
			}

			set
			{
			    RoleSetRoleTypeAssignedSingularName(value);
			}
		}

		protected void RoleSetRoleTypeAssignedSingularName(global::System.String role)
		{
			_RoleTypeAssignedSingularName = role;
		}

		public virtual bool ExistAssignedSingularName
		{
			get
			{
				return _RoleTypeAssignedSingularName != null;
			}
		}

		public virtual void RemoveAssignedSingularName()
		{
			_RoleTypeAssignedSingularName = null;
		}

		public virtual global::Allors.Meta.ObjectType[] ObjectTypesWhereDerivedUnitRoleType
		{
			get
			{
			    return _DerivedUnitRoleTypeObjectType;
			}
		}

		public virtual bool ExistObjectTypesWhereDerivedUnitRoleType
		{
			get
			{
				return _DerivedUnitRoleTypeObjectType.Length > 0;
			}
		}

		void AllorsInternalRoleType.AllorsRoleSyncAddDerivedUnitRoleTypeObjectType(global::Allors.Meta.ObjectType association)
		{
		    if( !AllorsEmbeddedArrays.Exist( _DerivedUnitRoleTypeObjectType, association ) ) 
			{
				_DerivedUnitRoleTypeObjectType = (global::Allors.Meta.ObjectType[])AllorsEmbeddedArrays.Add(_DerivedUnitRoleTypeObjectType,association);
			}
		}

		void AllorsInternalRoleType.AllorsRoleSyncRemoveDerivedUnitRoleTypeObjectType(global::Allors.Meta.ObjectType association)
		{
		    _DerivedUnitRoleTypeObjectType = (global::Allors.Meta.ObjectType[]) AllorsEmbeddedArrays.Remove(_DerivedUnitRoleTypeObjectType,association);
		}

		void AllorsInternalRoleType.AllorsRoleReleaseDerivedUnitRoleTypeObjectType()
		{
		    foreach( global::Allors.Meta.ObjectType association in _DerivedUnitRoleTypeObjectType )
			{
				((AllorsInternalObjectType)association).AllorsRemoveObjectTypeDerivedUnitRoleType((global::Allors.Meta.RoleType) this);
			}
		}


		public virtual global::Allors.Meta.RelationType RelationTypeWhereRoleType
		{
			get
			{
			    return _RoleTypeRelationType;
			}
		}

		public virtual bool ExistRelationTypeWhereRoleType
		{
			get
			{
				return _RoleTypeRelationType != null;
			}
		}

		void AllorsInternalRoleType.AllorsRoleSyncSetRoleTypeRelationType(global::Allors.Meta.RelationType association)
		{
		    _RoleTypeRelationType = association;
		}

		void AllorsInternalRoleType.AllorsRoleReleaseRoleTypeRelationType()
		{
			if( _RoleTypeRelationType != null )
			{
				((AllorsInternalRelationType)_RoleTypeRelationType).AllorsRemoveRelationTypeRoleType();
			}
		}


		public virtual global::Allors.Meta.ObjectType[] ObjectTypesWhereDerivedCompositeRoleType
		{
			get
			{
			    return _DerivedCompositeRoleTypeObjectType;
			}
		}

		public virtual bool ExistObjectTypesWhereDerivedCompositeRoleType
		{
			get
			{
				return _DerivedCompositeRoleTypeObjectType.Length > 0;
			}
		}

		void AllorsInternalRoleType.AllorsRoleSyncAddDerivedCompositeRoleTypeObjectType(global::Allors.Meta.ObjectType association)
		{
		    if( !AllorsEmbeddedArrays.Exist( _DerivedCompositeRoleTypeObjectType, association ) ) 
			{
				_DerivedCompositeRoleTypeObjectType = (global::Allors.Meta.ObjectType[])AllorsEmbeddedArrays.Add(_DerivedCompositeRoleTypeObjectType,association);
			}
		}

		void AllorsInternalRoleType.AllorsRoleSyncRemoveDerivedCompositeRoleTypeObjectType(global::Allors.Meta.ObjectType association)
		{
		    _DerivedCompositeRoleTypeObjectType = (global::Allors.Meta.ObjectType[]) AllorsEmbeddedArrays.Remove(_DerivedCompositeRoleTypeObjectType,association);
		}

		void AllorsInternalRoleType.AllorsRoleReleaseDerivedCompositeRoleTypeObjectType()
		{
		    foreach( global::Allors.Meta.ObjectType association in _DerivedCompositeRoleTypeObjectType )
			{
				((AllorsInternalObjectType)association).AllorsRemoveObjectTypeDerivedCompositeRoleType((global::Allors.Meta.RoleType) this);
			}
		}

		public virtual global::Allors.Meta.ObjectType[] ObjectTypesWhereDerivedRoleType
		{
			get
			{
			    return _DerivedRoleTypeObjectType;
			}
		}

		public virtual bool ExistObjectTypesWhereDerivedRoleType
		{
			get
			{
				return _DerivedRoleTypeObjectType.Length > 0;
			}
		}

		void AllorsInternalRoleType.AllorsRoleSyncAddDerivedRoleTypeObjectType(global::Allors.Meta.ObjectType association)
		{
		    if( !AllorsEmbeddedArrays.Exist( _DerivedRoleTypeObjectType, association ) ) 
			{
				_DerivedRoleTypeObjectType = (global::Allors.Meta.ObjectType[])AllorsEmbeddedArrays.Add(_DerivedRoleTypeObjectType,association);
			}
		}

		void AllorsInternalRoleType.AllorsRoleSyncRemoveDerivedRoleTypeObjectType(global::Allors.Meta.ObjectType association)
		{
		    _DerivedRoleTypeObjectType = (global::Allors.Meta.ObjectType[]) AllorsEmbeddedArrays.Remove(_DerivedRoleTypeObjectType,association);
		}

		void AllorsInternalRoleType.AllorsRoleReleaseDerivedRoleTypeObjectType()
		{
		    foreach( global::Allors.Meta.ObjectType association in _DerivedRoleTypeObjectType )
			{
				((AllorsInternalObjectType)association).AllorsRemoveObjectTypeDerivedRoleType((global::Allors.Meta.RoleType) this);
			}
		}

		public virtual global::Allors.Meta.ObjectType[] ObjectTypesWhereDerivedExclusiveRoleType
		{
			get
			{
			    return _DerivedExclusiveRoleTypeObjectType;
			}
		}

		public virtual bool ExistObjectTypesWhereDerivedExclusiveRoleType
		{
			get
			{
				return _DerivedExclusiveRoleTypeObjectType.Length > 0;
			}
		}

		void AllorsInternalRoleType.AllorsRoleSyncAddDerivedExclusiveRoleTypeObjectType(global::Allors.Meta.ObjectType association)
		{
		    if( !AllorsEmbeddedArrays.Exist( _DerivedExclusiveRoleTypeObjectType, association ) ) 
			{
				_DerivedExclusiveRoleTypeObjectType = (global::Allors.Meta.ObjectType[])AllorsEmbeddedArrays.Add(_DerivedExclusiveRoleTypeObjectType,association);
			}
		}

		void AllorsInternalRoleType.AllorsRoleSyncRemoveDerivedExclusiveRoleTypeObjectType(global::Allors.Meta.ObjectType association)
		{
		    _DerivedExclusiveRoleTypeObjectType = (global::Allors.Meta.ObjectType[]) AllorsEmbeddedArrays.Remove(_DerivedExclusiveRoleTypeObjectType,association);
		}

		void AllorsInternalRoleType.AllorsRoleReleaseDerivedExclusiveRoleTypeObjectType()
		{
		    foreach( global::Allors.Meta.ObjectType association in _DerivedExclusiveRoleTypeObjectType )
			{
				((AllorsInternalObjectType)association).AllorsRemoveObjectTypeDerivedExclusiveRoleType((global::Allors.Meta.RoleType) this);
			}
		}

}
}