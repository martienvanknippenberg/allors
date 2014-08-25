// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Not.cs" company="Allors bvba">
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
    using System.Collections.Generic;

    using Meta;

    public sealed class Not : Predicate, ICompositePredicate
    {
        private readonly ExtentFiltered extent;
        private Predicate filter;

        public Not(ExtentFiltered extent)
        {
            this.extent = extent;

            if (extent.Strategy != null)
            {
                var allorsObject = extent.Strategy.GetObject();
                if (extent.AssociationType != null)
                {
                    var role = extent.AssociationType.RoleType;
                    if (role.IsMany)
                    {
                        this.AddContains(role, allorsObject);
                    }
                    else
                    {
                        this.AddEquals(role, allorsObject);
                    }
                }
                else
                {
                    var association = extent.RoleType.AssociationType;
                    if (association.IsMany)
                    {
                        this.AddContains(association, allorsObject);
                    }
                    else
                    {
                        this.AddEquals(association, allorsObject);
                    }
                }
            }
        }

        public override bool Include
        {
            get { return this.filter != null && this.filter.Include; }
        }

        public ICompositePredicate AddAnd()
        {
            this.CheckUnarity();
            this.extent.FlushCache();
            this.filter = new AndPredicate(this.extent);
            return (ICompositePredicate)this.filter;
        }

        public ICompositePredicate AddBetween(MetaRole role, object firstValue, object secondValue)
        {
            this.CheckUnarity();
            this.extent.FlushCache();
            var betweenRoleA = firstValue as MetaRole;
            var betweenRoleB = secondValue as MetaRole;
            var betweenAssociationA = firstValue as MetaAssociation;
            var betweenAssociationB = secondValue as MetaAssociation;
            if (betweenRoleA != null && betweenRoleB != null)
            {
                this.filter = new RoleBetweenRole(this.extent, role, betweenRoleA, betweenRoleB);
            }
            else if (betweenAssociationA != null && betweenAssociationB != null)
            {
                throw new NotImplementedException();
            }
            else
            {
                this.filter = new RoleBetweenValue(this.extent, role, firstValue, secondValue);
            }

            return this;
        }

        public ICompositePredicate AddContainedIn(MetaRole role, Allors.Extent containingExtent)
        {
            this.CheckUnarity();
            this.extent.FlushCache();
            this.filter = new RoleContainedInExtent(this.extent, role, containingExtent);
            return this;
        }

        public ICompositePredicate AddContainedIn(MetaRole role, IEnumerable<IObject> containingEnumerable)
        {
            this.CheckUnarity();
            this.extent.FlushCache();
            this.filter = new RoleContainedInEnumerable(this.extent, role, containingEnumerable);
            return this;
        }

        public ICompositePredicate AddContainedIn(MetaAssociation association, Allors.Extent containingExtent)
        {
            this.CheckUnarity();
            this.extent.FlushCache();
            this.filter = new AssociationContainedInExtent(this.extent, association, containingExtent);
            return this;
        }

        public ICompositePredicate AddContainedIn(MetaAssociation association, IEnumerable<IObject> containingEnumerable)
        {
            this.CheckUnarity();
            this.extent.FlushCache();
            this.filter = new AssociationContainedInEnumerable(this.extent, association, containingEnumerable);
            return this;
        }

        public ICompositePredicate AddContains(MetaRole role, IObject containedObject)
        {
            this.CheckUnarity();
            this.extent.FlushCache();
            this.filter = new RoleContains(this.extent, role, containedObject);
            return this;
        }

        public ICompositePredicate AddContains(MetaAssociation association, IObject containedObject)
        {
            this.CheckUnarity();
            this.extent.FlushCache();
            this.filter = new AssociationContains(this.extent, association, containedObject);
            return this;
        }

        public ICompositePredicate AddEquals(IObject allorsObject)
        {
            this.CheckUnarity();
            this.extent.FlushCache();
            this.filter = new Equals(allorsObject);
            return this;
        }

        public ICompositePredicate AddEquals(MetaRole role, object obj)
        {
            this.CheckUnarity();
            this.extent.FlushCache();
            var equalsRole = obj as MetaRole;
            var equalsAssociation = obj as MetaAssociation;
            if (equalsRole != null)
            {
                this.filter = new RoleEqualsRole(this.extent, role, equalsRole);
            }
            else if (equalsAssociation != null)
            {
                throw new NotImplementedException();
            }
            else
            {
                this.filter = new RoleEqualsValue(this.extent, role, obj);
            }

            return this;
        }

        public ICompositePredicate AddEquals(MetaAssociation association, IObject allorsObject)
        {
            this.CheckUnarity();
            this.extent.FlushCache();
            this.filter = new AssociationEquals(this.extent, association, allorsObject);
            return this;
        }

        public ICompositePredicate AddExists(MetaRole role)
        {
            this.CheckUnarity();
            this.extent.FlushCache();
            this.filter = new RoleExists(this.extent, role);
            return this;
        }

        public ICompositePredicate AddExists(MetaAssociation association)
        {
            this.CheckUnarity();
            this.extent.FlushCache();
            this.filter = new AssociationExists(this.extent, association);
            return this;
        }

        public ICompositePredicate AddGreaterThan(MetaRole role, object value)
        {
            this.CheckUnarity();
            this.extent.FlushCache();
            var greaterThanRole = value as MetaRole;
            var greaterThanAssociation = value as MetaAssociation;
            if (greaterThanRole != null)
            {
                this.filter = new RoleGreaterThanRole(this.extent, role, greaterThanRole);
            }
            else if (greaterThanAssociation != null)
            {
                throw new NotImplementedException();
            }
            else
            {
                this.filter = new RoleGreaterThanValue(this.extent, role, value);
            }

            return this;
        }

        public ICompositePredicate AddInstanceof(MetaObject type)
        {
            this.CheckUnarity();
            this.extent.FlushCache();
            this.filter = new InstanceOf(type, CompositePredicate.GetConcreteSubClasses(type));
            return this;
        }

        public ICompositePredicate AddInstanceof(MetaRole role, MetaObject type)
        {
            this.CheckUnarity();
            this.extent.FlushCache();
            this.filter = new RoleInstanceof(this.extent, role, type, CompositePredicate.GetConcreteSubClasses(type));
            return this;
        }

        public ICompositePredicate AddInstanceof(MetaAssociation association, MetaObject type)
        {
            this.CheckUnarity();
            this.extent.FlushCache();
            this.filter = new AssociationInstanceOf(this.extent, association, type, CompositePredicate.GetConcreteSubClasses(type));
            return this;
        }

        public ICompositePredicate AddLessThan(MetaRole role, object value)
        {
            this.CheckUnarity();
            this.extent.FlushCache();
            var lessThanRole = value as MetaRole;
            var lessThanAssociation = value as MetaAssociation;
            if (lessThanRole != null)
            {
                this.filter = new RoleLessThanRole(this.extent, role, lessThanRole);
            }
            else if (lessThanAssociation != null)
            {
                throw new NotImplementedException();
            }
            else
            {
                this.filter = new RoleLessThanValue(this.extent, role, value);
            }

            return this;
        }

        public ICompositePredicate AddLike(MetaRole role, string value)
        {
            this.CheckUnarity();
            this.extent.FlushCache();
            this.filter = new RoleLike(this.extent, role, value);
            return this;
        }

        public ICompositePredicate AddNot()
        {
            this.CheckUnarity();
            this.extent.FlushCache();
            this.filter = new Not(this.extent);
            return (ICompositePredicate)this.filter;
        }

        public ICompositePredicate AddOr()
        {
            this.CheckUnarity();
            this.extent.FlushCache();
            this.filter = new Or(this.extent);
            return (ICompositePredicate)this.filter;
        }

        public override bool BuildWhere(ExtentStatement statement, string alias)
        {
            if (this.Include)
            {
                statement.Append(" NOT (");
                this.filter.BuildWhere(statement, alias);
                statement.Append(")");
            }

            return this.Include;
        }

        public override void Setup(ExtentStatement statement)
        {
            if (this.filter != null)
            {
                this.filter.Setup(statement);
            }
        }

        private void CheckUnarity()
        {
            if (this.filter != null)
            {
                throw new ArgumentException("Not predicate accepts only 1 operator (unary)");
            }
        }
    }
}