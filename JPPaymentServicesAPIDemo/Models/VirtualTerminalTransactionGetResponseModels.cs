using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace dotNetAPI.Models
{
    public class VirtualTerminalTransactionGetResponseModels
    {
        [XmlRoot(ElementName = "LINEITEM")]
        public class LINEITEM
        {
            [XmlElement(ElementName = "CUSTOMERPAYMENTTYPEID")]
            public string CUSTOMERPAYMENTTYPEID { get; set; }
            [XmlElement(ElementName = "PAYMENTID")]
            public string PAYMENTID { get; set; }
            [XmlElement(ElementName = "PAYMENTIDSECONDARY")]
            public string PAYMENTIDSECONDARY { get; set; }
            [XmlElement(ElementName = "ITEMAMOUNT")]
            public string ITEMAMOUNT { get; set; }
            [XmlElement(ElementName = "MISC_ONE")]
            public string MISC_ONE { get; set; }
            [XmlElement(ElementName = "MISC_TWO")]
            public string MISC_TWO { get; set; }
            [XmlElement(ElementName = "MISC_THREE")]
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
            [XmlElement(ElementName = "TRANSACTIONID")]
            public string TRANSACTIONID { get; set; }
            [XmlElement(ElementName = "COUNT")]
            public string COUNT { get; set; }
            [XmlElement(ElementName = "RESPONSECODE")]
            public string RESPONSECODE { get; set; }
            [XmlElement(ElementName = "APPROVALSTATUS")]
            public string APPROVALSTATUS { get; set; }
            [XmlElement(ElementName = "PRC")]
            public string PRC { get; set; }
            [XmlElement(ElementName = "EFFECTIVEDATE")]
            public string EFFECTIVEDATE { get; set; }
            [XmlElement(ElementName = "DATENOW")]
            public string DATENOW { get; set; }
            [XmlElement(ElementName = "TIMENOW")]
            public string TIMENOW { get; set; }
            [XmlElement(ElementName = "NAME")]
            public string NAME { get; set; }
            [XmlElement(ElementName = "ADDRESS")]
            public string ADDRESS { get; set; }
            [XmlElement(ElementName = "ADDRESSTWO")]
            public string ADDRESSTWO { get; set; }
            [XmlElement(ElementName = "CITY")]
            public string CITY { get; set; }
            [XmlElement(ElementName = "COUNTY")]
            public string COUNTY { get; set; }
            [XmlElement(ElementName = "STATE")]
            public string STATE { get; set; }
            [XmlElement(ElementName = "ZIP")]
            public string ZIP { get; set; }
            [XmlElement(ElementName = "COUNTRY")]
            public string COUNTRY { get; set; }
            [XmlElement(ElementName = "PHONE")]
            public string PHONE { get; set; }
            [XmlElement(ElementName = "EMAIL")]
            public string EMAIL { get; set; }
            [XmlElement(ElementName = "NOTES")]
            public string NOTES { get; set; }
            [XmlElement(ElementName = "PAYMENTMETHOD")]
            public string PAYMENTMETHOD { get; set; }
            [XmlElement(ElementName = "CREDITCARDNUMBER")]
            public string CREDITCARDNUMBER { get; set; }
            [XmlElement(ElementName = "BANKNAME")]
            public string BANKNAME { get; set; }
            [XmlElement(ElementName = "CHECKNUMBER")]
            public string CHECKNUMBER { get; set; }
            [XmlElement(ElementName = "ROUTINGNUMBER")]
            public string ROUTINGNUMBER { get; set; }
            [XmlElement(ElementName = "ACCOUNTNUMBER")]
            public string ACCOUNTNUMBER { get; set; }
            [XmlElement(ElementName = "CSIUSERID")]
            public string CSIUSERID { get; set; }
            [XmlElement(ElementName = "COLLECTIONMODE")]
            public string COLLECTIONMODE { get; set; }
            [XmlElement(ElementName = "AMOUNT")]
            public string AMOUNT { get; set; }
            [XmlElement(ElementName = "FEEAMOUNT")]
            public string FEEAMOUNT { get; set; }
            [XmlElement(ElementName = "TOTALREMITTED")]
            public string TOTALREMITTED { get; set; }
            [XmlElement(ElementName = "LINEITEM")]
            public LINEITEM LINEITEM { get; set; }
        }

    }
}