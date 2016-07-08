using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SOAP_dontDropIt.Models
{
    [Serializable()]
    public class CalculateFeeResponseModels
    {
        [XmlRoot(ElementName = "FEE")]
        public class FEE
        {
            [XmlElement(ElementName = "FEEAMOUNT")]
            public string FEEAMOUNT { get; set; }
            [XmlElement(ElementName = "RESPONSECODE")]
            public string RESPONSECODE { get; set; }
        }
    }
}
