using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace dotNetAPI.Models
{
    public class CalculateFeeModels
    {
        [XmlRoot(ElementName = "LINEITEM")]
        public class LINEITEM
        {
            [DisplayName("Client Payment Type Identifier")]
            [XmlElement(ElementName = "CUSTOMERPAYMENTTYPEID")]
            public string CUSTOMERPAYMENTTYPEID { get; set; }
            [DisplayName("Item Amount")]
            [XmlElement(ElementName = "ITEMAMOUNT")]
            public string ITEMAMOUNT { get; set; }
        }

        [XmlRoot(ElementName = "FEE")]
        public class FEE
        {
            [DisplayName("Client Key")]
            [XmlElement(ElementName = "CLIENTKEY")]
            public string CLIENTKEY { get; set; }
            [DisplayName("Payment Method")]
            [XmlElement(ElementName = "PAYMENTMETHOD")]
            public string PAYMENTMETHOD { get; set; }
            [DisplayName("Card Type")]
            [XmlElement(ElementName = "CARDTYPE")]
            public string CARDTYPE { get; set; }
            [DisplayName("Collection Mode")]
            [XmlElement(ElementName = "COLLECTIONMODE")]
            public string COLLECTIONMODE { get; set; }
            [DisplayName("Amount")]
            [XmlElement(ElementName = "AMOUNT")]
            public string AMOUNT { get; set; }
            [DisplayName("Line Item")]
            [XmlElement(ElementName = "LINEITEM")]
            public LINEITEM LINEITEM { get; set; }
        }
    }
}
