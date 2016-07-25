﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace SOAP_dontDropIt.Models
{
    public class VirtualTerminalTransactionResponseModels
    {
        [XmlRoot(ElementName = "VT_TRANSACTION")]
        public class VT_TRANSACTION
        {
            [XmlElement(ElementName = "TRANSACTIONID")]
            public string TRANSACTIONID { get; set; }
            [XmlElement(ElementName = "RESPONSECODE")]
            public string RESPONSECODE { get; set; }
        }
    }
}