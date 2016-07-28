using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace SOAP_dontDropIt.Models
{
    public class ExportDetailedTransactionsResponseModels
    {
        [XmlRoot(ElementName = "LINEITEM")]
        public class LINEITEM
        {
            [DisplayName("Customer Payment Type Identifier")]
            [XmlElement(ElementName = "CUSTOMERPAYMENTTYPEID")]
            public string CUSTOMERPAYMENTTYPEID { get; set; }
            [DisplayName("Payment Identifier")]
            [XmlElement(ElementName = "PAYMENTID")]
            public string PAYMENTID { get; set; }
            [DisplayName("Payment Identifier Secondary")]
            [XmlElement(ElementName = "PAYMENTIDSECONDARY")]
            public string PAYMENTIDSECONDARY { get; set; }
            [DisplayName("Item Amount")]
            [XmlElement(ElementName = "ITEMAMOUNT")]
            public string ITEMAMOUNT { get; set; }
        }

        [XmlRoot(ElementName = "TRANSACTION")]
        public class TRANSACTION
        {
            [DisplayName("Effective Date")]
            [XmlElement(ElementName = "EFFECTIVEDATE")]
            public string EFFECTIVEDATE { get; set; }
            [DisplayName("Name")]
            [XmlElement(ElementName = "NAME")]
            public string NAME { get; set; }
            [XmlElement(ElementName = "PRC")]
            public string PRC { get; set; }
            [DisplayName("Payment Method")]
            [XmlElement(ElementName = "PAYMENTMETHOD")]
            public string PAYMENTMETHOD { get; set; }
            [DisplayName("Bank Name")]
            [XmlElement(ElementName = "BANKNAME")]
            public string BANKNAME { get; set; }
            [DisplayName("Check Number")]
            [XmlElement(ElementName = "CHECKNUMBER")]
            public string CHECKNUMBER { get; set; }
            [DisplayName("Routing Number")]
            [XmlElement(ElementName = "ROUTINGNUMBER")]
            public string ROUTINGNUMBER { get; set; }
            [DisplayName("Account Number")]
            [XmlElement(ElementName = "ACCOUNTNUMBER")]
            public string ACCOUNTNUMBER { get; set; }
            [DisplayName("CSI Organization Unit Identifier")]
            [XmlElement(ElementName = "CSIORGANIZATIONUNITID")]
            public string CSIORGANIZATIONUNITID { get; set; }
            [DisplayName("Collection Mode")]
            [XmlElement(ElementName = "COLLECTIONMODE")]
            public string COLLECTIONMODE { get; set; }
            [DisplayName("Amount")]
            [XmlElement(ElementName = "AMOUNT")]
            public string AMOUNT { get; set; }
            [XmlElement(ElementName = "LINEITEM")]
            public LINEITEM LINEITEM { get; set; }
        }

        [XmlRoot(ElementName = "EXPORT")]
        public class EXPORT
        {
            [DisplayName("Count")]
            [XmlElement(ElementName = "COUNT")]
            public string COUNT { get; set; }
            [DisplayName("Response Code")]
            [XmlElement(ElementName = "RESPONSECODE")]
            public string RESPONSECODE { get; set; }
            [DisplayName("Transaction")]
            [XmlElement(ElementName = "TRANSACTION")]
            public TRANSACTION TRANSACTION { get; set; }
        }
    }
}