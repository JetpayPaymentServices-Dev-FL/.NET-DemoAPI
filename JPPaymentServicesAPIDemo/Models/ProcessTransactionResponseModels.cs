using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace dotNetAPI.Models
{
    public class ProcessTransactionResponseModels
    {
        [XmlRoot(ElementName = "TRANSACTION")]
        public class TRANSACTION
        {
            [XmlElement(ElementName = "TRANSACTIONID")]
            public string TRANSACTIONID { get; set; }
            [XmlElement(ElementName = "PRC")]
            public string PRC { get; set; }
            [XmlElement(ElementName = "RESPONSECODE")]
            public string RESPONSECODE { get; set; }
        }
    }
}