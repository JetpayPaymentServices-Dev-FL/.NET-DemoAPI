using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace SOAP_dontDropIt.Models
{
    public class VirtualTerminalTransactionModels
    {
        [XmlRoot(ElementName = "LINEITEM")]
        public class LINEITEM
        {
            [DisplayName("Payment Identifier")]
            [XmlElement(ElementName = "PAYMENTID")]
            public string PAYMENTID { get; set; }
            [DisplayName("Payment Identifier Secondary")]
            [XmlElement(ElementName = "PAYMENTID_SECONDARY")]
            public string PAYMENTID_SECONDARY { get; set; }
            [DisplayName("Item Amount")]
            [XmlElement(ElementName = "ITEMAMOUNT")]
            public string ITEMAMOUNT { get; set; }
            [DisplayName("Client Payment Type Identifier")]
            [XmlElement(ElementName = "CUSTOMERPAYMENTTYPEID")]
            public string CUSTOMERPAYMENTTYPEID { get; set; }
            [DisplayName("Miscellaneous One")]
            [XmlElement(ElementName = "MISC_ONE")]
            public string MISC_ONE { get; set; }
            [DisplayName("Miscellaneous Two")]
            [XmlElement(ElementName = "MISC_TWO")]
            public string MISC_TWO { get; set; }
            [XmlElement(ElementName = "MISC_THREE")]
            [DisplayName("Miscellaneous Three")]
            public string MISC_THREE { get; set; }
            [XmlElement(ElementName = "MISC_FOUR")]
            public string MISC_FOUR { get; set; }
            [XmlElement(ElementName = "MISC_FIVE")]
            public string MISC_FIVE { get; set; }
            [XmlElement(ElementName = "MISC_SIX")]
            public string MISC_SIX { get; set; }
            [XmlElement(ElementName = "MISC_SEVEN")]
            public string MISC_SEVEN { get; set; }
            [XmlElement(ElementName = "MISC_EIGHT")]
            public string MISC_EIGHT { get; set; }
            [XmlElement(ElementName = "MISC_NINE")]
            public string MISC_NINE { get; set; }
            [XmlElement(ElementName = "MISC_TEN")]
            public string MISC_TEN { get; set; }
            [XmlElement(ElementName = "MISC_ELEVEN")]
            public string MISC_ELEVEN { get; set; }
            [XmlElement(ElementName = "MISC_TWELVE")]
            public string MISC_TWELVE { get; set; }
            [XmlElement(ElementName = "MISC_THIRTEEN")]
            public string MISC_THIRTEEN { get; set; }
            [XmlElement(ElementName = "MISC_FOURTEEN")]
            public string MISC_FOURTEEN { get; set; }
            [XmlElement(ElementName = "MISC_FIFTEEN")]
            public string MISC_FIFTEEN { get; set; }
        }

        [XmlRoot(ElementName = "VT_TRANSACTION")]
        public class VT_TRANSACTION
        {
            [DisplayName("Client Key")]
            [XmlElement(ElementName = "CLIENTKEY")]
            public string CLIENTKEY { get; set; }
            [DisplayName("Transaction Identifier")]
            [XmlElement(ElementName = "TRANSACTIONID")]
            public string TRANSACTIONID { get; set; }
            [DisplayName("Collection Mode")]
            [XmlElement(ElementName = "COLLECTIONMODE")]
            public string COLLECTIONMODE { get; set; }
            [DisplayName("Amount")]
            [XmlElement(ElementName = "AMOUNT")]
            public string AMOUNT { get; set; }
            [DisplayName("Name")]
            [XmlElement(ElementName = "NAME")]
            public string NAME { get; set; }
            [DisplayName("Address")]
            [XmlElement(ElementName = "ADDRESS")]
            public string ADDRESS { get; set; }
            [DisplayName("Address Two")]
            [XmlElement(ElementName = "ADDRESSTWO")]
            public string ADDRESSTWO { get; set; }
            [DisplayName("City")]
            [XmlElement(ElementName = "CITY")]
            public string CITY { get; set; }
            [DisplayName("County")]
            [XmlElement(ElementName = "COUNTY")]
            public string COUNTY { get; set; }
            [DisplayName("State")]
            [XmlElement(ElementName = "STATE")]
            public string STATE { get; set; }
            [DisplayName("Country")]
            [XmlElement(ElementName = "COUNTRY")]
            public string COUNTRY { get; set; }
            [DisplayName("Zip Code")]
            [XmlElement(ElementName = "ZIP")]
            public string ZIP { get; set; }
            [DisplayName("Email Address")]
            [XmlElement(ElementName = "EMAIL")]
            public string EMAIL { get; set; }
            [DisplayName("Mobile Number")]
            [XmlElement(ElementName = "PHONE")]
            public string PHONE { get; set; }
            [DisplayName("Notes")]
            [XmlElement(ElementName = "NOTES")]
            public string NOTES { get; set; }
            [XmlElement(ElementName = "CSIUSERID")]
            public string CSIUSERID { get; set; }
            [XmlElement(ElementName = "LINEITEM")]
            public LINEITEM LINEITEM { get; set; }
            [XmlElement(ElementName = "URLSILENTPOST")]
            public string URLSILENTPOST { get; set; }
            [XmlElement(ElementName = "URLRETURNPOST")]
            public string URLRETURNPOST { get; set; }
            [XmlElement(ElementName = "ALLOWEDPAYMENTMETHOD")]
            public string ALLOWEDPAYMENTMETHOD { get; set; }
        }
    }
}