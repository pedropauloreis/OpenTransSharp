﻿using BMEcatSharp.Xml;
using System.Collections.Generic;
using System.ComponentModel;

namespace BMEcatSharp
{
    /// <summary>
    /// (Customs tariff number)<br/>
    /// <br/>
    /// This element contains information on the customs tariff number.<br/>
    /// <br/>
    /// XML-namespace: BMECAT
    /// </summary>
    public class CustomsTariffNumber
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public CustomsTariffNumber()
            : this(null!)
        {
        }

        public CustomsTariffNumber(string customsNumber)
        {
            CustomsNumber = customsNumber;
        }

        /// <summary>
        /// (required) Customs number<br/>
        /// <br/>
        /// This element contains the customs number.<br/>
        /// <br/>
        /// Max length: 60
        /// </summary>
        [BMEXmlElement("CUSTOMS_NUMBER")]
        public string CustomsNumber { get; set; }

        /// <summary>
        /// (optional) Territory<br/>
        /// <br/>
        /// Territory (i.e. country, state, region) coded according to ISO 3166<br/>
        /// The element specifies here to which territories the customs tariff number is related.<br/>
        /// <br/>
        /// XML-namespace: BMECAT
        /// </summary>
        [BMEXmlElement("TERRITORY")]
        public List<CountryCode>? Territories { get; set; } = new List<CountryCode>();
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool TerritoriesSpecified => Territories?.Count > 0;

        /// <summary>
        /// (optional) Area references<br/>
        /// <br/>
        /// List of references to areas<br/>
        /// The element specifies here to which areas the customs tariff number is related..        
        /// </summary>
        [BMEXmlElement("AREA_REFS")]
        public AreaRef? AreaRef { get; set; }
    }
}
