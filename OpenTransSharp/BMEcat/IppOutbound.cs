﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OpenTransSharp
{
    /// <summary>
    /// (IPP call)<br/>
    /// <br/>
    /// This element contains information about the exchange format used for the IPP call and the exchanged parameter.<br/>
    /// <br/>
    /// XML-namespace: BMECAT
    /// </summary>
    public class IppOutbound
    {
        /// <summary>
        /// (required) Exchange format<br/>
        /// <br/>
        /// Exchange format used for implementing the IPP operation, e.g., OCI 4.0 (Open Catalog Interface).<br/>
        /// <br/>
        /// See <see cref="IppOutboundFormatValues"/>.
        /// <br/>
        /// XML-namespace: BMECAT
        /// </summary>
        [BMEXmlElement("IPP_OUTBOUND_FORMAT")]
        public string IppOutboundFormat { get; set; }

        /// <summary>
        /// (optional) IPP input parameters<br/>
        /// <br/>
        /// List of input parameters and their allowed values.<br/>
        /// <br/>
        /// XML-namespace: BMECAT
        /// </summary>
        [BMEXmlElement("IPP_OUTBOUND_PARAMS")]
        public IppOutboundParams? IppOutboundParams { get; set; }

        /// <summary>
        /// (required) IPP operation URL<br/>
        /// <br/>
        /// Calling address of the IPP operation.<br/>
        /// <br/>
        /// XML-namespace: BMECAT
        /// </summary>
        [Required]
        [BMEXmlElement("IPP_URI")]
        public List<MultiLingualString> IppUris { get; set; } = new List<MultiLingualString>();
    }
}
