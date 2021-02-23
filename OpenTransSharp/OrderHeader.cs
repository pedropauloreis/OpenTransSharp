﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace OpenTransSharp
{
    /// <summary>
    /// (Header level)<br/>
    /// <br/>
    /// The header is specified by the ORDER_HEADER element.<br/>
    /// ORDER_HEADER is used to transfer information about the business partners and the business document and enter default settings which can basically be overwritten on item level (ORDER_ITEM).<br/>
    /// <br/>
    /// Caution:<br/>
    /// The exception for overwriting at the level (ORDER_ITEM) is the element PARTIAL_SHIPMENT_ALLOWED.<br/>
    /// In this case, the value in the header overwrites the value at the item level (ORDER_ITEM).
    /// </summary>
    public class OrderHeader
    {
        /// <summary>
        /// (optional) Control information<br/>
        /// <br/>
        /// Control information for the automatic processing of the business documents.
        /// </summary>
        [XmlElement("CONTROL_INFO")]
        public ControlInformation? ControlInformation { get; set; }

        /// <summary>
        /// (optional) Sourcing information<br/>
        /// <br/>
        /// Information about previous quotations, catalog references, skeleton agreements.
        /// </summary>
        [XmlElement("SOURCING_INFO")]
        public SourcingInformation? SourcingInformation { get; set; }

        /// <summary>
        /// (required) Buyer information<br/>
        /// <br/>
        /// Order information on this business document.
        /// </summary>
        [Required]
        [XmlElement("ORDER_INFO")]
        public OrderInformation Information { get; set; } = new OrderInformation();
    }
}
