// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccessControlList.cs" company="Allors bvba">
//   Copyright 2002-2013 Allors bvba.
//
// Dual Licensed under
//   a) the General Public Licence v3 (GPL)
//   b) the Allors License
//
// The GPL License is included in the file gpl.txt.
// The Allors License is an addendum to your contract.
//
// Allors Applications is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// For more information visit http://www.allors.com/legal
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Allors.Domain
{
    using System;
    using System.Collections.Generic;

    using Allors.Meta;

    public interface IAccessControlList
    {
        User User { get; }

        bool HasReadOperation { get; }

        bool HasWriteOperation { get; }

        int Count { get; }

        bool CanRead(PropertyType propertyType);

        bool CanWrite(RoleType roleType);

        bool CanExecute(MethodType methodType);

        bool CanExecute(Guid methodTypeId);

        IList<Operation> GetOperations(OperandType operandType);

        bool IsPermitted(OperandType operandType, Operation operation);
    }
}