// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DerivationError.cs" company="Allors bvba">
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
    using System.Collections.Generic;

    using Allors.Meta;

    public abstract class DerivationError : IDerivationError
    {
        private readonly DerivationLog derivationLog;
        private readonly DerivationRelation[] relations;
        private readonly string message;

        protected DerivationError(DerivationLog derivationLog, DerivationRelation[] relations, string errorMessage)
            : this(derivationLog, relations, errorMessage, new object[] { DerivationRelation.ToString(relations) })
        {
        }

        protected DerivationError(DerivationLog derivationLog, DerivationRelation[] relations, string errorMessage, object[] errorMessageParameters)
        {
            this.derivationLog = derivationLog;
            this.relations = relations;

            try
            {
                if (errorMessageParameters != null && errorMessageParameters.Length > 0)
                {
                    this.message = string.Format(errorMessage, errorMessageParameters);
                }
                else
                {
                    this.message = string.Format(errorMessage, new object[] { DerivationRelation.ToString(relations) });
                }
            }
            catch
            {
                this.message = this.GetType() + ": " + DerivationRelation.ToString(this.relations);
            }
        }

        public DerivationLog DerivationLog
        {
            get
            {
                return this.derivationLog;
            }
        }

        public DerivationRelation[] Relations
        {
            get
            {
                return this.relations;
            }
        }

        public RoleType[] RoleTypes
        {
            get
            {
                var roleTypes = new List<RoleType>();
                foreach (var derivationRole in this.Relations)
                {
                    var roleType = derivationRole.RoleType;
                    if (!roleTypes.Contains(roleType))
                    {
                        roleTypes.Add(roleType);
                    }
                }

                return roleTypes.ToArray();
            }
        }

        public virtual string Message
        {
            get
            {
                return this.message;
            }
        }

        public override string ToString()
        {
            return this.message;
        }
    }
}