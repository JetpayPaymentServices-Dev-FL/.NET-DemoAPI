using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace SOAP_dontDropIt.Models
{
    public class ProcessCreditModels
    {
        [XmlRoot(ElementName = "CREDIT")]
        public class CREDIT
        {
            [DisplayName("Client Key")]
            [XmlElement(ElementName = "CLIENTKEY")]
            public string CLIENTKEY { get; set; }
            [XmlElement(ElementName = "PRC")]
            public string PRC { get; set; }
            [DisplayName("Amount")]
            [XmlElement(ElementName = "AMOUNT")]
            public string AMOUNT { get; set; }
            [DisplayName("Internal Credit")]
            [XmlElement(ElementName = "INTERNALCREDIT")]
            public string INTERNALCREDIT { get; set; }
            [DisplayName("Charge Back")]
            [XmlElement(ElementName = "CHARGEBACK")]
            public string CHARGEBACK { get; set; }
            [DisplayName("Notes")]
            [XmlElement(ElementName = "NOTES")]
            public string NOTES { get; set; }
            [DisplayName("CSI Organization Unit Identifier")]
            [XmlElement(ElementName = "CSIORGANIZATIONUNITID")]
            public string CSIORGANIZATIONUNITID { get; set; }
            [DisplayName("CSI User Identifier")]
            [XmlElement(ElementName = "CSIUSERID")]
            public string CSIUSERID { get; set; }
        }
    }
}