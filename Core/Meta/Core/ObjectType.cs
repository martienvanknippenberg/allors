//------------------------------------------------------------------------------------------------- 
// <copyright file="ObjectType.cs" company="Allors bvba">
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
// <summary>Defines the IObjectType type.</summary>
//-------------------------------------------------------------------------------------------------

namespace Allors.Meta
{
    using System;

    public abstract partial class ObjectType : DomainObject, IObjectType
    {
        private string singularName;

        private string pluralName;

        protected ObjectType(Domain domain, Guid id)
            : base(domain, id)
        {
        }

        public string SingularName
        {
            get
            {
                return this.singularName;
            }

            set
            {
                this.MetaPopulation.AssertUnlocked();
                this.singularName = value;
                this.MetaPopulation.Stale();
            }
        }

        public string PluralName
        {
            get
            {
                return this.pluralName;
            }

            set
            {
                this.MetaPopulation.AssertUnlocked();
                this.pluralName = value;
                this.MetaPopulation.Stale();
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name .</value>
        public string Name
        {
            get
            {
                return this.SingularName;
            }
        }

        public bool IsUnit
        {
            get
            {
                return this is IUnit;
            }
        }

        public bool IsComposite
        {
            get
            {
                return this is IComposite;
            }
        }

        public bool IsInterface
        {
            get
            {
                return this is IInterface;
            }
        }

        public bool IsClass
        {
            get
            {
                return this is IClass;
            }
        }

        /// <summary>
        /// Gets the validation name.
        /// </summary>
        /// <value>The validation name.</value>
        protected internal override string ValidationName
        {
            get
            {
                if (!string.IsNullOrEmpty(this.SingularName))
                {
                    return "object type " + this.SingularName;
                }
                
                return "object type " + this.Id;
            }
        }
        
        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="obj">An object to compare with this instance.</param>
        /// <returns>
        /// A 32-bit signed integer that indicates the relative order of the objects being compared. The return value has these meanings: Value Meaning Less than zero This instance is less than <paramref name="obj"/>. Zero This instance is equal to <paramref name="obj"/>. Greater than zero This instance is greater than <paramref name="obj"/>.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// <paramref name="obj"/> is not the same type as this instance. </exception>
        public int CompareTo(object obj)
        {
            var that = obj as ObjectType;
            if (that != null)
            {
                return string.CompareOrdinal(this.Name, that.Name);
            }

            return -1;
        }
        
        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </returns>
        public override string ToString()
        {
            if (!string.IsNullOrEmpty(this.SingularName))
            {
                return this.SingularName;
            }

            return this.IdAsString;
        }

        /// <summary>
        /// Validates this instance.
        /// </summary>
        /// <param name="validationLog">The validation.</param>
        protected internal override void Validate(ValidationLog validationLog)
        {
            base.Validate(validationLog);

            if (!string.IsNullOrEmpty(this.SingularName))
            {
                if (this.SingularName.Length < 2)
                {
                    var message = this.ValidationName + " should have a singular name with at least 2 characters";
                    validationLog.AddError(message, this, ValidationKind.MinimumLength, "IObjectType.SingularName");
                }
                else
                {
                    if (!char.IsLetter(this.SingularName[0]))
                    {
                        var message = this.ValidationName + "'s singular name should start with an alfabetical character";
                        validationLog.AddError(message, this, ValidationKind.Format, "IObjectType.SingularName");
                    }

                    for (var i = 1; i < this.SingularName.Length; i++)
                    {
                        if (!char.IsLetter(this.SingularName[i]) && !char.IsDigit(this.SingularName[i]))
                        {
                            var message = this.ValidationName + "'s singular name should only contain alfanumerical characters";
                            validationLog.AddError(message, this, ValidationKind.Format, "IObjectType.SingularName");
                            break;
                        }
                    }
                }

                if (validationLog.ExistObjectTypeName(this.SingularName))
                {
                    var message = "The singular name of " + this.ValidationName + " is already in use";
                    validationLog.AddError(message, this, ValidationKind.Unique, "IObjectType.SingularName");
                }
                else
                {
                    validationLog.AddObjectTypeName(this.SingularName);
                }
            }
            else
            {
                validationLog.AddError(this.ValidationName + " has no singular name", this, ValidationKind.Required, "IObjectType.SingularName");
            }

            if (!string.IsNullOrEmpty(this.PluralName))
            {
                if (this.PluralName.Length < 2)
                {
                    var message = this.ValidationName + " should have a plural name with at least 2 characters";
                    validationLog.AddError(message, this, ValidationKind.MinimumLength, "IObjectType.PluralName");
                }
                else
                {
                    if (!char.IsLetter(this.PluralName[0]))
                    {
                        var message = this.ValidationName + "'s plural name should start with an alfabetical character";
                        validationLog.AddError(message, this, ValidationKind.Format, "IObjectType.PluralName");
                    }

                    for (var i = 1; i < this.PluralName.Length; i++)
                    {
                        if (!char.IsLetter(this.PluralName[i]) && !char.IsDigit(this.PluralName[i]))
                        {
                            var message = this.ValidationName + "'s plural name should only contain alfanumerical characters";
                            validationLog.AddError(message, this, ValidationKind.Format, "IObjectType.PluralName");
                            break;
                        }
                    }
                }

                if (validationLog.ExistObjectTypeName(this.PluralName))
                {
                    var message = "The plural name of " + this.ValidationName + " is already in use";
                    validationLog.AddError(message, this, ValidationKind.Unique, "IObjectType.PluralName");
                }
                else
                {
                    validationLog.AddObjectTypeName(this.PluralName);
                }
            }
            else
            {
                validationLog.AddError(this.ValidationName + " has no plural name", this, ValidationKind.Required, "IObjectType.PluralName");
            }
        }
    }
}