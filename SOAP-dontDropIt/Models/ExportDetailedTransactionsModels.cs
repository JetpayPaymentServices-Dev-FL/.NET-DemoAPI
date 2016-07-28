using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace SOAP_dontDropIt.Models
{
    public class ExportDetailedTransactionsModels
    {
        [XmlRoot(ElementName = "EXPORT")]
        public class EXPORT
        {
            [DisplayName("Client Key")]
            [XmlElement(ElementName = "CLIENTKEY")]
            public string CLIENTKEY { get; set; }
            [DisplayName("Start Date")]
            [XmlElement(ElementName = "STARTDATE")]
            public string STARTDATE { get; set; }
            [DisplayName("End Date")]
            [XmlElement(ElementName = "ENDDATE")]
            public string ENDDATE { get; set; }
            [DisplayName("CSI Organization Unit Identifier")]
            [XmlElement(ElementName = "CSIORGANIZATIONUNITID")]
            public string CSIORGANIZATIONUNITID { get; set; }
            [DisplayName("Customer Payment Type Identifier")]
            [XmlElement(ElementName = "CUSTOMERPAYMENTTYPEID")]
            public string CUSTOMERPAYMENTTYPEID { get; set; }
            [DisplayName("Collection Mode")]
            [XmlElement(ElementName = "COLLECTIONMODE")]
            public string COLLECTIONMODE { get; set; }
        }

    }
}