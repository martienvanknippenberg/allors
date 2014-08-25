namespace Allors.Meta.AllorsGenerated
{
	internal interface AllorsInternalAssociationType : AllorsInternalPropertyType, AllorsInternal
	{
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


		global::Allors.Meta.MetaObject ObjectType
		{
			get;
			set;
		}

		void RemoveObjectType();

		bool ExistObjectType
		{
			get;
		}

		void AllorsRemoveAssociationTypeObjectType();


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


		global::Allors.Meta.MetaObject[] DerivedRootObjectTypes
		{
			get;
			set;
		}

		void AddDerivedRootObjectType( global::Allors.Meta.MetaObject addRole );

		void RemoveDerivedRootObjectType( global::Allors.Meta.MetaObject removeRole );

		void RemoveDerivedRootObjectTypes();

		bool ExistDerivedRootObjectTypes
		{
			get;
		}
		void AllorsRemoveAssociationTypeDerivedRootObjectType();

		void AllorsRemoveAssociationTypeDerivedRootObjectType( global::Allors.Meta.MetaObject role );


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


		global::Allors.Meta.MetaObject[] ObjectTypesWhereDerivedExclusiveAssociationType
		{
			get;
		}

		bool ExistObjectTypesWhereDerivedExclusiveAssociationType
		{
			get;
		}

		void AllorsRoleSyncAddDerivedExclusiveAssociationTypeObjectType(global::Allors.Meta.MetaObject association );

		void AllorsRoleSyncRemoveDerivedExclusiveAssociationTypeObjectType(global::Allors.Meta.MetaObject association );

		void AllorsRoleReleaseDerivedExclusiveAssociationTypeObjectType();


		global::Allors.Meta.MetaObject[] ObjectTypesWhereDerivedAssociationType
		{
			get;
		}

		bool ExistObjectTypesWhereDerivedAssociationType
		{
			get;
		}

		void AllorsRoleSyncAddDerivedAssociationTypeObjectType(global::Allors.Meta.MetaObject association );

		void AllorsRoleSyncRemoveDerivedAssociationTypeObjectType(global::Allors.Meta.MetaObject association );

		void AllorsRoleReleaseDerivedAssociationTypeObjectType();



		global::Allors.Meta.MetaRelation RelationTypeWhereAssociationType
		{
			get;
		}

		bool ExistRelationTypeWhereAssociationType
		{
			get;
		}


		void AllorsRoleSyncSetAssociationTypeRelationType(global::Allors.Meta.MetaRelation association );


		void AllorsRoleReleaseAssociationTypeRelationType();


	}

	public interface AllorsInterfaceAssociationType :  AllorsEmbeddedObject 
	{
	}

	[System.Diagnostics.DebuggerNonUserCode]
	public abstract class AllorsClassAssociationType :  global::Allors.Meta.MetaProperty,  AllorsInternalAssociationType , AllorsEmbeddedObject
	{
		protected System.Object _AssociationTypeAssignedPluralName;


		protected global::Allors.Meta.MetaObject _AssociationTypeObjectType;


		protected System.Object _AssociationTypeIsMany;


		protected global::Allors.Meta.MetaObject[] _AssociationTypeDerivedRootObjectType = AllorsEmbeddedArrays.EMPTY_ObjectType_ARRAY;


		protected System.Object _AssociationTypeDerivedRootName;


		protected System.Object _AssociationTypeAssignedSingularName;


		protected global::Allors.Meta.MetaObject[] _DerivedExclusiveAssociationTypeObjectType = AllorsEmbeddedArrays.EMPTY_ObjectType_ARRAY;


		protected global::Allors.Meta.MetaObject[] _DerivedAssociationTypeObjectType = AllorsEmbeddedArrays.EMPTY_ObjectType_ARRAY;


		protected global::Allors.Meta.MetaRelation _AssociationTypeRelationType;




		/// <summary>
		/// Initializes a new instance of the <see cref="AllorsClassAssociationType"/> class.
		/// </summary>
		/// <param name="session">The Allors Session.</param>
		/// <param name="id">The Allors Object Id.</param>
		protected AllorsClassAssociationType(AllorsEmbeddedSession session, System.Int32 id) : base(session,id){}

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
				return new System.Guid("51df648e-4870-403a-8b2e-50f6e63d4749");
			}
		}

		public override void Delete()
		{
			AllorsAssert();

			((AllorsInternalAssociationType)this).AllorsRemoveAssociationTypeObjectType();
			((AllorsInternalAssociationType)this).AllorsRemoveAssociationTypeDerivedRootObjectType();

			((AllorsInternalAssociationType)this).AllorsRoleReleaseDerivedExclusiveAssociationTypeObjectType();
			((AllorsInternalAssociationType)this).AllorsRoleReleaseDerivedAssociationTypeObjectType();
			((AllorsInternalAssociationType)this).AllorsRoleReleaseAssociationTypeRelationType();


			session.Delete(this);
			isDeleted = true;
		}

		object AllorsInternal.GetRole(AllorsEmbeddedRelationType relation)
		{
			AllorsAssert();
			switch(relation.Tag)
			{
				case AllorsRelationTags.AssociationTypeAssignedPluralName:
					return _AssociationTypeAssignedPluralName;
				case AllorsRelationTags.AssociationTypeObjectType:
					return _AssociationTypeObjectType;
				case AllorsRelationTags.AssociationTypeIsMany:
					return _AssociationTypeIsMany;
				case AllorsRelationTags.AssociationTypeDerivedRootObjectType:
					return _AssociationTypeDerivedRootObjectType;
				case AllorsRelationTags.AssociationTypeDerivedRootName:
					return _AssociationTypeDerivedRootName;
				case AllorsRelationTags.AssociationTypeAssignedSingularName:
					return _AssociationTypeAssignedSingularName;
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
				case AllorsRelationTags.AssociationTypeAssignedPluralName:
					RoleSetAssociationTypeAssignedPluralName((global::System.String)role);
					break;
				case AllorsRelationTags.AssociationTypeObjectType:
					RoleSetAssociationTypeObjectType((global::Allors.Meta.MetaObject)role);
					break;
				case AllorsRelationTags.AssociationTypeIsMany:
					RoleSetAssociationTypeIsMany((global::System.Boolean)role);
					break;
				case AllorsRelationTags.AssociationTypeDerivedRootObjectType:
					RoleSetAssociationTypeDerivedRootObjectType((global::Allors.Meta.MetaObject[])role);
					break;
				case AllorsRelationTags.AssociationTypeDerivedRootName:
					RoleSetAssociationTypeDerivedRootName((global::System.String)role);
					break;
				case AllorsRelationTags.AssociationTypeAssignedSingularName:
					RoleSetAssociationTypeAssignedSingularName((global::System.String)role);
					break;
				case AllorsRelationTags.MetaObjectId:
					RoleSetMetaObjectId((global::System.Guid)role);
					break;

		default:
				throw new System.ArgumentException("Illegal relation " + relation.Name);
			}
		}


		public virtual global::System.String AssignedPluralName
		{
			get
			{ 
				AllorsAssert();
				return (global::System.String)_AssociationTypeAssignedPluralName;
			}

			set
			{
				AllorsAssert();
				RoleSetAssociationTypeAssignedPluralName(value);
			}
		}

		protected void RoleSetAssociationTypeAssignedPluralName(global::System.String role)
		{
			_AssociationTypeAssignedPluralName = role;
		}

		public virtual bool ExistAssignedPluralName
		{
			get
			{
				return _AssociationTypeAssignedPluralName != null;
			}
		}

		public virtual void RemoveAssignedPluralName()
		{
			_AssociationTypeAssignedPluralName = null;
		}

		public virtual global::Allors.Meta.MetaObject ObjectType
		{
			get
			{
				AllorsAssert();
				return _AssociationTypeObjectType;
			}

			set
			{
				AllorsAssert(value);
				RoleSetAssociationTypeObjectType(value);
			}
		}

		protected void RoleSetAssociationTypeObjectType(global::Allors.Meta.MetaObject value)
		{
			((AllorsInternalAssociationType)this).AllorsRemoveAssociationTypeObjectType();
			if( value != null ) 
			{
				_AssociationTypeObjectType = value;
				_AssociationTypeObjectType = value;
				// role side
				((AllorsInternalObjectType)_AssociationTypeObjectType).AllorsRoleSyncAddObjectTypeAssociationType((global::Allors.Meta.MetaAssociation) this ); 
			}
		}

		public virtual void RemoveObjectType()
		{
			((AllorsInternalAssociationType)this).AllorsRemoveAssociationTypeObjectType();
		}

		void AllorsInternalAssociationType.AllorsRemoveAssociationTypeObjectType()
		{
			AllorsAssert();
			if( _AssociationTypeObjectType != null) 
			{
				((AllorsInternalObjectType)_AssociationTypeObjectType).AllorsRoleSyncRemoveObjectTypeAssociationType( (global::Allors.Meta.MetaAssociation) this ); 
				_AssociationTypeObjectType = null;
				_AssociationTypeObjectType = null;
			}
		}

		public virtual bool ExistObjectType
		{
			get
			{
				return _AssociationTypeObjectType != null;
			}
		}

		public virtual global::System.Boolean IsMany
		{
			get
			{ 
				AllorsAssert();
				return (global::System.Boolean)_AssociationTypeIsMany;
			}

			set
			{
				AllorsAssert();
				RoleSetAssociationTypeIsMany(value);
			}
		}

		protected void RoleSetAssociationTypeIsMany(global::System.Boolean role)
		{
			_AssociationTypeIsMany = role;
		}

		public virtual bool ExistIsMany
		{
			get
			{
				return _AssociationTypeIsMany != null;
			}
		}

		public virtual void RemoveIsMany()
		{
			_AssociationTypeIsMany = null;
		}

		public virtual global::Allors.Meta.MetaObject[] DerivedRootObjectTypes
		{
			get
			{ 
				AllorsAssert();
				return _AssociationTypeDerivedRootObjectType;
			}

			set
			{ 
				AllorsAssert(value);
				RoleSetAssociationTypeDerivedRootObjectType(value);
			}
		}

		protected void RoleSetAssociationTypeDerivedRootObjectType(global::Allors.Meta.MetaObject[] roles)
		{
			((AllorsInternalAssociationType)this).AllorsRemoveAssociationTypeDerivedRootObjectType();
			if( roles != null && roles.Length > 0 )
			{
				foreach( global::Allors.Meta.MetaObject role in roles )
				{
					RoleAddDerivedRootObjectType(role);
				}
			}
		}

		public virtual void AddDerivedRootObjectType( global::Allors.Meta.MetaObject addRole )
		{
			RoleAddDerivedRootObjectType( addRole );
		}

		void RoleAddDerivedRootObjectType( global::Allors.Meta.MetaObject addRole )
		{
			AllorsAssert(addRole);
			if( addRole != null )
			{
				if( !AllorsEmbeddedArrays.Exist( _AssociationTypeDerivedRootObjectType, addRole ) ) 
				{
					// association side
					_AssociationTypeDerivedRootObjectType = (global::Allors.Meta.MetaObject[]) AllorsEmbeddedArrays.Add( _AssociationTypeDerivedRootObjectType, addRole );
					// role side
					((AllorsInternalObjectType)addRole).AllorsRoleSyncAddDerivedRootObjectTypeAssociationType( (global::Allors.Meta.MetaAssociation) this ); 
				}
			}
		}

		public virtual void RemoveDerivedRootObjectType( global::Allors.Meta.MetaObject removeRole ) 
		{
			((AllorsInternalAssociationType)this).AllorsRemoveAssociationTypeDerivedRootObjectType( removeRole );
		}

		void AllorsInternalAssociationType.AllorsRemoveAssociationTypeDerivedRootObjectType( global::Allors.Meta.MetaObject removeRole ) 
		{
			AllorsAssert(removeRole);
			if( removeRole != null )
			{
				if(AllorsEmbeddedArrays.Exist( _AssociationTypeDerivedRootObjectType, removeRole ) ) 
				{
					_AssociationTypeDerivedRootObjectType = (global::Allors.Meta.MetaObject[]) AllorsEmbeddedArrays.Remove( _AssociationTypeDerivedRootObjectType, removeRole );
					// role side
					((AllorsInternalObjectType)removeRole).AllorsRoleSyncRemoveDerivedRootObjectTypeAssociationType( (global::Allors.Meta.MetaAssociation) this ); 
			
				}
			}
		}

		public virtual void RemoveDerivedRootObjectTypes()
		{
			((AllorsInternalAssociationType)this).AllorsRemoveAssociationTypeDerivedRootObjectType();
		}

		void AllorsInternalAssociationType.AllorsRemoveAssociationTypeDerivedRootObjectType()
		{
			AllorsAssert();

			if( _AssociationTypeDerivedRootObjectType!=null )
			{
				foreach( global::Allors.Meta.MetaObject role in _AssociationTypeDerivedRootObjectType ) 
				{
					// role side
					((AllorsInternalObjectType)role).AllorsRoleSyncRemoveDerivedRootObjectTypeAssociationType( (global::Allors.Meta.MetaAssociation) this ); 
				}
			}
			_AssociationTypeDerivedRootObjectType = AllorsEmbeddedArrays.EMPTY_ObjectType_ARRAY;
		}

		public virtual bool ExistDerivedRootObjectTypes
		{
			get
			{
				return _AssociationTypeDerivedRootObjectType.Length > 0;
			}
		}


		public virtual global::System.String DerivedRootName
		{
			get
			{ 
				AllorsAssert();
				return (global::System.String)_AssociationTypeDerivedRootName;
			}

			set
			{
				AllorsAssert();
				RoleSetAssociationTypeDerivedRootName(value);
			}
		}

		protected void RoleSetAssociationTypeDerivedRootName(global::System.String role)
		{
			_AssociationTypeDerivedRootName = role;
		}

		public virtual bool ExistDerivedRootName
		{
			get
			{
				return _AssociationTypeDerivedRootName != null;
			}
		}

		public virtual void RemoveDerivedRootName()
		{
			_AssociationTypeDerivedRootName = null;
		}

		public virtual global::System.String AssignedSingularName
		{
			get
			{ 
				AllorsAssert();
				return (global::System.String)_AssociationTypeAssignedSingularName;
			}

			set
			{
				AllorsAssert();
				RoleSetAssociationTypeAssignedSingularName(value);
			}
		}

		protected void RoleSetAssociationTypeAssignedSingularName(global::System.String role)
		{
			_AssociationTypeAssignedSingularName = role;
		}

		public virtual bool ExistAssignedSingularName
		{
			get
			{
				return _AssociationTypeAssignedSingularName != null;
			}
		}

		public virtual void RemoveAssignedSingularName()
		{
			_AssociationTypeAssignedSingularName = null;
		}

		public virtual global::Allors.Meta.MetaObject[] ObjectTypesWhereDerivedExclusiveAssociationType
		{
			get
			{
				AllorsAssert();
				return _DerivedExclusiveAssociationTypeObjectType;
			}
		}

		public virtual bool ExistObjectTypesWhereDerivedExclusiveAssociationType
		{
			get
			{
				return _DerivedExclusiveAssociationTypeObjectType.Length > 0;
			}
		}

		void AllorsInternalAssociationType.AllorsRoleSyncAddDerivedExclusiveAssociationTypeObjectType(global::Allors.Meta.MetaObject association)
		{
			AllorsAssert();
			if( !AllorsEmbeddedArrays.Exist( _DerivedExclusiveAssociationTypeObjectType, association ) ) 
			{
				_DerivedExclusiveAssociationTypeObjectType = (global::Allors.Meta.MetaObject[])AllorsEmbeddedArrays.Add(_DerivedExclusiveAssociationTypeObjectType,association);
			}
		}

		void AllorsInternalAssociationType.AllorsRoleSyncRemoveDerivedExclusiveAssociationTypeObjectType(global::Allors.Meta.MetaObject association)
		{
			AllorsAssert();
			_DerivedExclusiveAssociationTypeObjectType = (global::Allors.Meta.MetaObject[]) AllorsEmbeddedArrays.Remove(_DerivedExclusiveAssociationTypeObjectType,association);
		}

		void AllorsInternalAssociationType.AllorsRoleReleaseDerivedExclusiveAssociationTypeObjectType()
		{
			AllorsAssert();
			foreach( global::Allors.Meta.MetaObject association in _DerivedExclusiveAssociationTypeObjectType )
			{
				((AllorsInternalObjectType)association).AllorsRemoveObjectTypeDerivedExclusiveAssociationType((global::Allors.Meta.MetaAssociation) this);
			}
		}

		public virtual global::Allors.Meta.MetaObject[] ObjectTypesWhereDerivedAssociationType
		{
			get
			{
				AllorsAssert();
				return _DerivedAssociationTypeObjectType;
			}
		}

		public virtual bool ExistObjectTypesWhereDerivedAssociationType
		{
			get
			{
				return _DerivedAssociationTypeObjectType.Length > 0;
			}
		}

		void AllorsInternalAssociationType.AllorsRoleSyncAddDerivedAssociationTypeObjectType(global::Allors.Meta.MetaObject association)
		{
			AllorsAssert();
			if( !AllorsEmbeddedArrays.Exist( _DerivedAssociationTypeObjectType, association ) ) 
			{
				_DerivedAssociationTypeObjectType = (global::Allors.Meta.MetaObject[])AllorsEmbeddedArrays.Add(_DerivedAssociationTypeObjectType,association);
			}
		}

		void AllorsInternalAssociationType.AllorsRoleSyncRemoveDerivedAssociationTypeObjectType(global::Allors.Meta.MetaObject association)
		{
			AllorsAssert();
			_DerivedAssociationTypeObjectType = (global::Allors.Meta.MetaObject[]) AllorsEmbeddedArrays.Remove(_DerivedAssociationTypeObjectType,association);
		}

		void AllorsInternalAssociationType.AllorsRoleReleaseDerivedAssociationTypeObjectType()
		{
			AllorsAssert();
			foreach( global::Allors.Meta.MetaObject association in _DerivedAssociationTypeObjectType )
			{
				((AllorsInternalObjectType)association).AllorsRemoveObjectTypeDerivedAssociationType((global::Allors.Meta.MetaAssociation) this);
			}
		}


		public virtual global::Allors.Meta.MetaRelation RelationTypeWhereAssociationType
		{
			get
			{
				AllorsAssert();
				return _AssociationTypeRelationType;
			}
		}

		public virtual bool ExistRelationTypeWhereAssociationType
		{
			get
			{
				return _AssociationTypeRelationType != null;
			}
		}

		void AllorsInternalAssociationType.AllorsRoleSyncSetAssociationTypeRelationType(global::Allors.Meta.MetaRelation association)
		{
			AllorsAssert();
			_AssociationTypeRelationType = association;
		}

		void AllorsInternalAssociationType.AllorsRoleReleaseAssociationTypeRelationType()
		{
			if( _AssociationTypeRelationType != null )
			{
				((AllorsInternalRelationType)_AssociationTypeRelationType).AllorsRemoveRelationTypeAssociationType();
			}
		}


}
}