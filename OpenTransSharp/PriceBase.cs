﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OpenTransSharp
{
    /// <summary>
    /// (Price basis)<br/>
    /// <br/>
    /// This element contains the price basis consisting of price unit and price factor, it defines the basis of a price.
    /// </summary>
    public class PriceBase
    {
        /// <summary>
        /// (required) Price unit<br/>
        /// <br/>
        /// Unit of measurement on which the price is calculated.
        /// </summary>
        [Required]
        [BMEXmlElement("PRICE_UNIT")]
        public string PriceUnit { get; set; }

        /// <summary>
        /// (optional) Price unit factor<br/>
        /// <br/>
        /// The price factor is the conversion factor for price unit and order unit.<br/>
        /// The underlying formula is: <b>PRICE_UNIT = PRICE_UNIT_FACTOR * ORDER_UNIT</b><br/>
        /// <br/>
        /// Default value: 1
        /// </summary>
        [BMEXmlElement("PRICE_UNIT_FACTOR")]
        public decimal? PriceUnitFactor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool PriceUnitFactorSpecified => PriceUnitFactor.HasValue;
    }
}
