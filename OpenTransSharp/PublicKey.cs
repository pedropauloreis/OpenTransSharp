﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace OpenTransSharp
{
    /// <summary>
    /// (Public key)<br/>
    /// <br/>
    /// Indicates the public key, e.g.PGP, of the person addressed here.<br/>
    /// <br/>
    /// XML-namespace: BMECAT
    /// </summary>
    public class PublicKey
    {
        public PublicKey()
        {

        }

        public PublicKey(string value, string type)
        {
            Value = value;
            Type = type;
        }

        /// <summary>
        /// (required) Type of coding process<br/>
        /// <br/>
        /// This attribute indicates the Public Key coding process in which the e-mail is coded.<br/>
        /// Must comply with the format "&lt;Name&gt;-&lt;MajorVersion&gt;.&lt;MinorVersions&gt;".<br/>
        /// <br/>
        /// Max length: 50<br/>
        /// <br/>
        /// Example.: PGP-6.5.1
        /// </summary>
        [Required]
        [XmlAttribute("type")]
        public string Type { get; set; }

        /// <summary>
        /// (required)<br/>
        /// <br/>
        /// Max length: 64000
        /// </summary>
        [Required]
        [XmlText]
        public string Value { get; set; }
    }
}
