﻿using BMEcatSharp.Xml;
using OpenTransSharp.Xml;
using System.Collections.Generic;
using System.ComponentModel;

namespace OpenTransSharp
{
    /// <summary>
    /// (Tax details)<br/>
    /// <br/>
    /// This element contains information of one applicable tax.<br/>
    /// <br/>
    /// XML-namespace: OpenTrans
    /// </summary>
    public class TaxDetailsFix
    {
        /// <summary>
        /// <inheritdoc cref="TaxDetailsFix"/>
        /// </summary>
        public TaxDetailsFix() { }

        /// <summary>
        /// (optional) Calculation sequence<br/>
        /// <br/>
        /// This element determines the sequence for applying multiple taxes to a basis.<br/>
        /// The taxes must be applied beginning with the lowest value in CALCULATION_SEQUENCE.<br/>
        /// Therefore, the tax with the lowest sequence will be calculated first, then follows the tax with the next higher sequence, and so on.<br/>
        /// If two taxes have the same sequence, both tax factors must be added prior to calculation.<br/>
        /// <br/>
        /// XML-namespace: BMECAT
        /// </summary>
        [BMEXmlElement("CALCULATION_SEQUENCE")]
        public int? CalculationSequence { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool CalculationSequenceSpecified => CalculationSequence.HasValue;

        /// <summary>
        /// (optional) Tax category<br/>
        /// <br/>
        /// This element specifies the tax category as a code.<br/>
        /// <br/>
        /// By this it is possible to define the tax not as an absolute value, but as the currently valid percentage (TAX).<br/>
        /// The specification should take place, if possible, by using a common code.<br/>
        /// The list of predefined values contains codes that should be used within the European Union (see also http://europa.eu.int/comm/taxation_customs/taxation/vat/how_vat_works/rates/index_en.htm).<br/>
        /// <br/>
        /// See <see cref="BMEcatSharp.TaxCategoryValues"/>.
        /// <br/>
        /// XML-namespace: BMECAT
        /// </summary>
        [BMEXmlElement("TAX_CATEGORY")]
        public string? Category { get; set; }

        /// <summary>
        /// (optional) Tax type<br/>
        /// <br/>
        /// This element specifies the tax type; it should take place by using internationally accepted terms, such as VAT for value added tax.<br/>
        /// <br/>
        /// XML-namespace: BMECAT
        /// </summary>
        [BMEXmlElement("TAX_TYPE")]
        public string? Type { get; set; } = "vat";

        /// <summary>
        /// (optional) Tax rate<br/>
        /// <br/>
        /// Factor for tax applicable to this price.<br/>
        /// <br/>
        /// Example: "0.16", corresponds to 16 percent.<br/>
        /// <br/>
        /// XML-namespace: BMECAT
        /// </summary>
        [BMEXmlElement("TAX")]
        public decimal? Tax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool TaxSpecified => Tax.HasValue;

        /// <summary>
        /// (optional) Tax amount<br/>
        /// <br/>
        /// Total amount of the tax to be paid.<br/>
        /// Is the result of multiplying the price and the tax rate (TAX) and is listed explicitly for tax reasons.<br/>
        /// This amount is related to one item-position.<br/>
        /// <br/>
        /// XML-namespace: BMECAT
        /// </summary>
        [OpenTransXmlElement("TAX_AMOUNT")]
        public decimal? Amount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool AmountSpecified => Amount.HasValue;

        /// <summary>
        /// (optional) Tax base<br/>
        /// <br/>
        /// If used this element specifies the base for the caluclation of the tax.<br/>
        /// <br/>
        /// XML-namespace: BMECAT
        /// </summary>
        [OpenTransXmlElement("TAX_BASE")]
        public decimal? Base { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool BaseSpecified => Base.HasValue;

        /// <summary>
        /// (optional) Exemption reason<br/>
        /// <br/>
        /// This element gives the reason why the tax is an exemption from the norm.<br/>
        /// <br/>
        /// XML-namespace: BMECAT
        /// </summary>
        [BMEXmlElement("EXEMPTION_REASON")]
        public List<global::BMEcatSharp.MultiLingualString>? ExemptionReason { get; set; } = new List<global::BMEcatSharp.MultiLingualString>();
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ExemptionReasonSpecified => ExemptionReason?.Count > 0;

        /// <summary>
        /// (optional) Jurisdiction<br/>
        /// <br/>
        /// Tax jurisdiction.
        /// </summary>
        [BMEXmlElement("JURISDICTION")]
        public List<global::BMEcatSharp.MultiLingualString>? Jurisdiction { get; set; } = new List<global::BMEcatSharp.MultiLingualString>();
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool JurisdictionSpecified => Jurisdiction?.Count > 0;
    }
}
