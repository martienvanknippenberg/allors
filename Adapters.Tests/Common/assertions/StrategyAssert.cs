// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StrategyAssert.cs" company="Allors bvba">
//   Copyright 2002-2012 Allors bvba.
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

namespace Allors.Adapters.Special.Assertions
{
    using System;

    using Allors.Meta;

    using Allors;

    using NUnit.Framework;

    public class StrategyAssert
    {
        public static void AssociationExistHasException(IObject allorsObject, AssociationType associationType)
        {
            bool exceptionOccured = false;
            try
            {
                object o = allorsObject.Strategy.GetAssociation(associationType);
            }
            catch
            {
                exceptionOccured = true;
            }

            if (!exceptionOccured)
            {
                Assert.Fail("Exist didn't threw an Exception for association " + associationType.FullName);
            }
        }

        public static void AssociationGetHasException(IObject allorsObject, AssociationType associationType)
        {
            bool exceptionOccured = false;
            try
            {
                object o = allorsObject.Strategy.GetAssociation(associationType);
            }
            catch
            {
                exceptionOccured = true;
            }

            if (!exceptionOccured)
            {
                Assert.Fail();
            }
        }

        public static void AssociationsExistExclusive(IObject allorsObject, params AssociationType[] associationTypes)
        {
            foreach (AssociationType associationType in associationTypes)
            {
                if (Array.IndexOf(allorsObject.Strategy.ObjectType.AssociationTypes, associationType) < 0)
                {
                    Assert.Fail();
                }
            }

            foreach (AssociationType associationType in allorsObject.Strategy.ObjectType.AssociationTypes)
            {
                if (Array.IndexOf(associationTypes, associationType) >= 0)
                {
                    if (!allorsObject.Strategy.ExistAssociation(associationType))
                    {
                        Assert.Fail();
                    }
                }
                else
                {
                    if (allorsObject.Strategy.ExistAssociation(associationType))
                    {
                        if (allorsObject.Strategy.ExistAssociation(associationType))
                        {
                            Assert.Fail();
                        }
                    }
                }
            }
        }

        public static void RoleExistHasException(IObject allorsObject, RoleType roleType)
        {
            bool exceptionOccured = false;
            try
            {
                object o = allorsObject.Strategy.ExistRole(roleType);
            }
            catch
            {
                exceptionOccured = true;
            }

            if (!exceptionOccured)
            {
                Assert.Fail("Exist didn't threw an Exception for role " + roleType.Name);
            }
        }

        public static void RoleGetHasException(IObject allorsObject, RoleType roleType)
        {
            bool exceptionOccured = false;
            try
            {
                object o = allorsObject.Strategy.GetRole(roleType);
            }
            catch
            {
                exceptionOccured = true;
            }

            if (!exceptionOccured)
            {
                Assert.Fail();
            }
        }

        public static void RolesExistExclusive(IObject allorsObject, params RoleType[] roleTypes)
        {
            foreach (RoleType roleType in roleTypes)
            {
                if (Array.IndexOf(allorsObject.Strategy.ObjectType.RoleTypes, roleType) < 0)
                {
                    Assert.Fail();
                }
            }

            foreach (RoleType roleType in allorsObject.Strategy.ObjectType.RoleTypes)
            {
                if (Array.IndexOf(roleTypes, roleType) >= 0)
                {
                    if (!allorsObject.Strategy.ExistRole(roleType))
                    {
                        Assert.Fail();
                    }
                }
                else
                {
                    if (allorsObject.Strategy.ExistRole(roleType))
                    {
                        Assert.Fail();
                    }
                }
            }
        }
    }
}