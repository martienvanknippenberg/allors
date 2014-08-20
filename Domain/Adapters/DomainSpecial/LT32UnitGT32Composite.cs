// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LT32UnitGT32Composite.cs" company="Allors bvba">
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

namespace Domain
{
    using Allors;

    public partial class LT32UnitGT32Composite 
    {
        public static LT32UnitGT32Composite Create(ISession session)
        {
            return
                (LT32UnitGT32Composite)session.Create(LT32UnitGT32CompositeMeta.ObjectType);
        }

        public static LT32UnitGT32Composite[] Create(ISession session, int count)
        {
            return
                (LT32UnitGT32Composite[])
                session.Create(LT32UnitGT32CompositeMeta.ObjectType, count);
        }

        public static LT32UnitGT32Composite[] Instantiate(ISession session, string[] ids)
        {
            return
                (LT32UnitGT32Composite[])
                session.Instantiate(ids);
        }

        public static LT32UnitGT32Composite[] Extent(ISession session)
        {
            return
                (LT32UnitGT32Composite[])
                session.Extent(LT32UnitGT32CompositeMeta.ObjectType).ToArray();
        }
    }
}