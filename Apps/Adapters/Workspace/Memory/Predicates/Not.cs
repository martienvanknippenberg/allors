// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Not.cs" company="Allors bvba">
//   Copyright 2002-2013 Allors bvba.
// Dual Licensed under
//   a) the Lesser General Public Licence v3 (LGPL)
//   b) the Allors License
// The LGPL License is included in the file lgpl.txt.
// The Allors License is an addendum to your contract.
// Allors Platform is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// For more information visit http://www.allors.com/legal
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Allors.Adapters.Workspace.Memory
{
    using System;
    using System.Collections.Generic;

    using Allors.Meta;

    internal sealed class Not : Predicate, ICompositePredicate
    {
        private readonly Extent extent;
        private Predicate predicate;

        internal Not(Extent extent)
        {
            this.extent = extent;
        }

        internal override bool Include
        {
            get { return this.predicate != null && this.predicate.Include; }
        }

        public ICompositePredicate AddAnd()
        {
            this.CheckUnarity();
            this.predicate = new And(this.extent);
            this.extent.Invalidate();
            return (ICompositePredicate)this.predicate;
        }

        public ICompositePredicate AddBetween(RoleType role, object firstValue, object secondValue)
        {
            this.CheckUnarity();
            this.predicate = new RoleBetween(this.extent, role, firstValue, secondValue);
            this.extent.Invalidate();
            return this;
        }

        public ICompositePredicate AddContainedIn(RoleType role, Allors.Extent containingExtent)
        {
            this.CheckUnarity();
            if (role.IsMany)
            {
                this.predicate = new RoleManyContainedInExtent(this.extent, role, containingExtent);
            }
            else
            {
                this.predicate = new RoleOneContainedInExtent(this.extent, role, containingExtent);
            }

            this.extent.Invalidate();
            return this;
        }

        public ICompositePredicate AddContainedIn(RoleType role, IEnumerable<IObject> containingEnumerable)
        {
            this.CheckUnarity();
            if (role.IsMany)
            {
                this.predicate = new RoleManyContainedInEnumerable(this.extent, role, containingEnumerable);
            }
            else
            {
                this.predicate = new RoleOneContainedInEnumerable(this.extent, role, containingEnumerable);
            }

            this.extent.Invalidate();
            return this;
        }

        public ICompositePredicate AddContainedIn(AssociationType association, Allors.Extent containingExtent)
        {
            this.CheckUnarity();
            this.predicate = new AssociationContainedInExtent(this.extent, association, containingExtent);
            this.extent.Invalidate();
            return this;
        }

        public ICompositePredicate AddContainedIn(AssociationType association, IEnumerable<IObject> containingEnumerable)
        {
            this.CheckUnarity();
            this.predicate = new AssociationContainedInEnumerable(this.extent, association, containingEnumerable);
            this.extent.Invalidate();
            return this;
        }

        public ICompositePredicate AddContains(RoleType role, IObject containedObject)
        {
            this.CheckUnarity();
            this.predicate = new RoleContains(this.extent, role, containedObject);
            this.extent.Invalidate();
            return this;
        }

        public ICompositePredicate AddContains(AssociationType association, IObject containedObject)
        {
            this.CheckUnarity();
            this.predicate = new AssociationContains(this.extent, association, containedObject);
            this.extent.Invalidate();
            return this;
        }

        public ICompositePredicate AddEquals(IObject allorsObject)
        {
            this.CheckUnarity();
            this.predicate = new Equals(allorsObject);
            this.extent.Invalidate();
            return this;
        }

        public ICompositePredicate AddEquals(RoleType role, object obj)
        {
            this.CheckUnarity();
            if (role.ObjectType is Unit)
            {
                this.predicate = new RoleUnitEquals(this.extent, role, obj);
            }
            else
            {
                this.predicate = new RoleCompositeEquals(this.extent, role, obj);
            }

            this.extent.Invalidate();
            return this;
        }

        public ICompositePredicate AddEquals(AssociationType association, IObject allorsObject)
        {
            this.CheckUnarity();
            this.predicate = new AssociationEquals(this.extent, association, allorsObject);
            this.extent.Invalidate();
            return this;
        }

        public ICompositePredicate AddExists(RoleType role)
        {
            this.CheckUnarity();
            this.predicate = new RoleExists(this.extent, role);
            this.extent.Invalidate();
            return this;
        }

        public ICompositePredicate AddExists(AssociationType association)
        {
            this.CheckUnarity();
            this.predicate = new AssociationExists(this.extent, association);
            this.extent.Invalidate();
            return this;
        }

        public ICompositePredicate AddGreaterThan(RoleType role, object value)
        {
            this.CheckUnarity();
            this.predicate = new RoleGreaterThan(this.extent, role, value);
            this.extent.Invalidate();
            return this;
        }

        public ICompositePredicate AddInstanceof(Composite type)
        {
            this.CheckUnarity();
            this.predicate = new Instanceof(type);
            this.extent.Invalidate();
            return this;
        }

        public ICompositePredicate AddInstanceof(RoleType role, Composite type)
        {
            this.CheckUnarity();
            this.predicate = new RoleInstanceof(this.extent, role, type);
            this.extent.Invalidate();
            return this;
        }

        public ICompositePredicate AddInstanceof(AssociationType association, Composite type)
        {
            this.CheckUnarity();
            this.predicate = new AssociationInstanceOf(this.extent, association, type);
            this.extent.Invalidate();
            return this;
        }

        public ICompositePredicate AddLessThan(RoleType role, object value)
        {
            this.CheckUnarity();
            this.predicate = new RoleLessThan(this.extent, role, value);
            this.extent.Invalidate();
            return this;
        }

        public ICompositePredicate AddLike(RoleType role, string value)
        {
            this.CheckUnarity();
            this.predicate = new RoleLike(this.extent, role, value);
            this.extent.Invalidate();
            return this;
        }

        public ICompositePredicate AddNot()
        {
            this.CheckUnarity();
            this.predicate = new Not(this.extent);
            this.extent.Invalidate();
            return (ICompositePredicate)this.predicate;
        }

        public ICompositePredicate AddOr()
        {
            this.CheckUnarity();
            this.predicate = new Or(this.extent);
            this.extent.Invalidate();
            return (ICompositePredicate)this.predicate;
        }

        internal override ThreeValuedLogic Evaluate(Strategy strategy)
        {
            switch (this.predicate.Evaluate(strategy))
            {
                case ThreeValuedLogic.True:
                    return ThreeValuedLogic.False;
                case ThreeValuedLogic.False:
                    return ThreeValuedLogic.True;
                default:
                    return ThreeValuedLogic.Unknown;
            }
        }

        private void CheckUnarity()
        {
            if (this.predicate != null)
            {
                throw new ArgumentException("Not predicate accepts only 1 operator (unary)");
            }
        }
    }
}