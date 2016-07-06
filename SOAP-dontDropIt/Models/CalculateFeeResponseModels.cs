using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAP_dontDropIt.Models
{
    [Serializable()]
    public class CalculateFeeResponseModels
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class FEE
        {

            private object fEEAMOUNTField;

            private object rESPONSECODEField;

            public object FEEAMOUNT
            {
                get
                {
                    return this.fEEAMOUNTField;
                }
                set
                {
                    this.fEEAMOUNTField = value;
                }
            }

            public object RESPONSECODE
            {
                get
                {
                    return this.rESPONSECODEField;
                }
                set
                {
                    this.rESPONSECODEField = value;
                }
            }
        }


    }
}
