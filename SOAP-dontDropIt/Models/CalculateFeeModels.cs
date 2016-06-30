using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace SOAP_dontDropIt.Models
{
    public class CalculateFeeModels
    {
        [XmlRoot(ElementName = "LINEITEM")]
        public class LINEITEM
        {
            [XmlElement(ElementName = "CUSTOMERPAYMENTTYPEID")]
            public string CUSTOMERPAYMENTTYPEID { get; set; }
            [XmlElement(ElementName = "ITEMAMOUNT")]
            public string ITEMAMOUNT { get; set; }
        }

        [XmlRoot(ElementName = "FEE")]
        public class FEE
        {
            [XmlElement(ElementName = "CLIENTKEY")]
            public string CLIENTKEY { get; set; }
            [XmlElement(ElementName = "PAYMENTMETHOD")]
            public string PAYMENTMETHOD { get; set; }
            [XmlElement(ElementName = "CARDTYPE")]
            public string CARDTYPE { get; set; }
            [XmlElement(ElementName = "COLLECTIONMODE")]
            public string COLLECTIONMODE { get; set; }
            [XmlElement(ElementName = "AMOUNT")]
            public string AMOUNT { get; set; }
            [XmlElement(ElementName = "LINEITEM")]
            public LINEITEM LINEITEM { get; set; }
        }

    }
}
