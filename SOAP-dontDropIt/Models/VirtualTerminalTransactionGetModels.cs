using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;
using System.Xml.Serialization;

namespace SOAP_dontDropIt.Models
{
    public class VirtualTerminalTransactionGetModels
    {
        [XmlRoot(ElementName = "VT_TRANSACTION")]
        public class VT_TRANSACTION
        {
            [XmlElement(ElementName = "CLIENTKEY")]
            public string CLIENTKEY { get; set; }
            [XmlElement(ElementName = "TRANSACTIONID")]
            public string TRANSACTIONID { get; set; }
        }
    }
}