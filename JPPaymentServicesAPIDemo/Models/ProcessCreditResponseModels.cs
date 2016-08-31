using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace dotNetAPI.Models
{
    public class ProcessCreditResponseModels
    {
        [XmlRoot(ElementName = "CREDIT")]
        public class CREDIT
        {
            [XmlElement(ElementName = "PRC")]
            public string PRC { get; set; }
            [DisplayName("Amount Credited")]
            [XmlElement(ElementName = "AMOUNTCREDITED")]
            public string AMOUNTCREDITED { get; set; }
            [DisplayName("Fee Amount Credited")]
            [XmlElement(ElementName = "FEEAMOUNTCREDITED")]
            public string FEEAMOUNTCREDITED { get; set; }
            [DisplayName("Total Amount Credited")]
            [XmlElement(ElementName = "TOTALAMOUNTCREDITED")]
            public string TOTALAMOUNTCREDITED { get; set; }
            [DisplayName("Response Code")]
            [XmlElement(ElementName = "RESPONSECODE")]
            public string RESPONSECODE { get; set; }
        }
    }
}