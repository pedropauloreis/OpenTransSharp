﻿using System.Xml.Serialization;

namespace OpenTransSharp
{
    /// <summary>
    /// For <see cref="FeatureContent.FeatureTemplateValency"/>.
    /// </summary>
    public enum FeatureTemplateValencyValues
    {
        /// <summary>
        /// Univalent<br/>
        /// <br/>
        /// The feature can only have one value.
        /// </summary>
        [XmlEnum("univalent")]
        Univalent,
        /// <summary>
        /// Univalent<br/>
        /// <br/>
        /// The feature can have more than one value.
        /// </summary>
        [XmlEnum("multivalent")]
        Multivalent
    }
}
