using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalManagerRuleConfiguration
{
    public class FilterAttribute : IEquatable<FilterAttribute>
    {
        private string _displayName;

        /// <summary>
        ///  Gets the Type of attribute (Which can be used to validate assigned value to attribute at UI side)
        /// </summary>
        public Type DataType { get; set; }

        /// <summary>
        ///  Gets the description of current attribute (Can be used as a tool tip to display at UI level)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///  Gets the attribute name (Database understanding name /local naming convention of the attribute)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///  Gets the Native language of the attribute name (Should be come from resource file)
        /// </summary>
        public string DisplayName
        {
            get { return _displayName ?? Name; }
            set
            {
                _displayName = value;
            }
        }

        /// <summary>
        ///  Gets the attribute is unique (To identify is this attribute value unique accross project)
        /// </summary>
        public bool IsUnique { get; set; }

        /// <summary>
        ///  Gets or sets the attribute is readonly
        /// </summary>
        public bool IsReadOnly { get; set; }

        #region Equality members

        public override string ToString()
        {
            return $"{Name}:{DisplayName}:{Description}";
        }

        public bool Equals(FilterAttribute other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(Name, other.Name);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((FilterAttribute)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (_displayName != null ? _displayName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (DataType != null ? DataType.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Description != null ? Description.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ IsUnique.GetHashCode();
                return hashCode;
            }
        }

        #endregion Equality members
    }

}
