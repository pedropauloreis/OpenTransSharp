﻿using System.Xml.Serialization;

namespace OpenTransSharp
{
    /// <summary>
    /// For <see cref="Feature.FeatureValueType"/>.
    /// </summary>
    public enum FeatureValueTypeValues
    {
        /// <summary>
        /// Choice of value<br/>
        /// <br/>
        /// Indicates that the feature domain is a set of values from which one values must be chosen.
        /// </summary>
        [XmlEnum("choice")]
        Choice,
        /// <summary>
        /// Range of values<br/>
        /// <br/>
        /// Indicates that the feature domain is a range between two values.
        /// </summary>
        [XmlEnum("range")]
        Range,
        /// <summary>
        /// Set of values<br/>
        /// <br/>
        /// Indicates that the feature domain is a set of values.
        /// </summary>
        [XmlEnum("set")]
        Set
    }
}
