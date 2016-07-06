using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAP_dontDropIt.Models
{
    public class VirtualTerminalTransactionModels
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class VT_TRANSACTION
        {

            private object cLIENTKEYField;

            private object tRANSACTIONIDField;

            private object cOLLECTIONMODEField;

            private object aMOUNTField;

            private object nAMEField;

            private object aDDRESSField;

            private object aDDRESSTWOField;

            private object cITYField;

            private object cOUNTYField;

            private object sTATEField;

            private object cOUNTRYField;

            private object zIPField;

            private object eMAILField;

            private object pHONEField;

            private object nOTESField;

            private object cSIUSERIDField;

            private VT_TRANSACTIONLINEITEM lINEITEMField;

            private object uRLSILENTPOSTField;

            private object uRLRETURNPOSTField;

            private object aLLOWEDPAYMENTMETHODField;

            /// <remarks/>
            public object CLIENTKEY
            {
                get
                {
                    return this.cLIENTKEYField;
                }
                set
                {
                    this.cLIENTKEYField = value;
                }
            }

            /// <remarks/>
            public object TRANSACTIONID
            {
                get
                {
                    return this.tRANSACTIONIDField;
                }
                set
                {
                    this.tRANSACTIONIDField = value;
                }
            }

            /// <remarks/>
            public object COLLECTIONMODE
            {
                get
                {
                    return this.cOLLECTIONMODEField;
                }
                set
                {
                    this.cOLLECTIONMODEField = value;
                }
            }

            /// <remarks/>
            public object AMOUNT
            {
                get
                {
                    return this.aMOUNTField;
                }
                set
                {
                    this.aMOUNTField = value;
                }
            }

            /// <remarks/>
            public object NAME
            {
                get
                {
                    return this.nAMEField;
                }
                set
                {
                    this.nAMEField = value;
                }
            }

            /// <remarks/>
            public object ADDRESS
            {
                get
                {
                    return this.aDDRESSField;
                }
                set
                {
                    this.aDDRESSField = value;
                }
            }

            /// <remarks/>
            public object ADDRESSTWO
            {
                get
                {
                    return this.aDDRESSTWOField;
                }
                set
                {
                    this.aDDRESSTWOField = value;
                }
            }

            /// <remarks/>
            public object CITY
            {
                get
                {
                    return this.cITYField;
                }
                set
                {
                    this.cITYField = value;
                }
            }

            /// <remarks/>
            public object COUNTY
            {
                get
                {
                    return this.cOUNTYField;
                }
                set
                {
                    this.cOUNTYField = value;
                }
            }

            /// <remarks/>
            public object STATE
            {
                get
                {
                    return this.sTATEField;
                }
                set
                {
                    this.sTATEField = value;
                }
            }

            /// <remarks/>
            public object COUNTRY
            {
                get
                {
                    return this.cOUNTRYField;
                }
                set
                {
                    this.cOUNTRYField = value;
                }
            }

            /// <remarks/>
            public object ZIP
            {
                get
                {
                    return this.zIPField;
                }
                set
                {
                    this.zIPField = value;
                }
            }

            /// <remarks/>
            public object EMAIL
            {
                get
                {
                    return this.eMAILField;
                }
                set
                {
                    this.eMAILField = value;
                }
            }

            /// <remarks/>
            public object PHONE
            {
                get
                {
                    return this.pHONEField;
                }
                set
                {
                    this.pHONEField = value;
                }
            }

            /// <remarks/>
            public object NOTES
            {
                get
                {
                    return this.nOTESField;
                }
                set
                {
                    this.nOTESField = value;
                }
            }

            /// <remarks/>
            public object CSIUSERID
            {
                get
                {
                    return this.cSIUSERIDField;
                }
                set
                {
                    this.cSIUSERIDField = value;
                }
            }

            /// <remarks/>
            public VT_TRANSACTIONLINEITEM LINEITEM
            {
                get
                {
                    return this.lINEITEMField;
                }
                set
                {
                    this.lINEITEMField = value;
                }
            }

            /// <remarks/>
            public object URLSILENTPOST
            {
                get
                {
                    return this.uRLSILENTPOSTField;
                }
                set
                {
                    this.uRLSILENTPOSTField = value;
                }
            }

            /// <remarks/>
            public object URLRETURNPOST
            {
                get
                {
                    return this.uRLRETURNPOSTField;
                }
                set
                {
                    this.uRLRETURNPOSTField = value;
                }
            }

            /// <remarks/>
            public object ALLOWEDPAYMENTMETHOD
            {
                get
                {
                    return this.aLLOWEDPAYMENTMETHODField;
                }
                set
                {
                    this.aLLOWEDPAYMENTMETHODField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class VT_TRANSACTIONLINEITEM
        {

            private object pAYMENTIDField;

            private object pAYMENTID_SECONDARYField;

            private object iTEMAMOUNTField;

            private object cUSTOMERPAYMENTTYPEIDField;

            private object mISC_ONEField;

            private object mISC_TWOField;

            private object mISC_THREEField;

            private object mISC_FOURField;

            private object mISC_FIVEField;

            private object mISC_SIXField;

            private object mISC_SEVENField;

            private object mISC_EIGHTField;

            private object mISC_NINEField;

            private object mISC_TENField;

            private object mISC_ELEVENField;

            private object mISC_TWELVEField;

            private object mISC_THIRTEENField;

            private object mISC_FOURTEENField;

            private object mISC_FIFTEENField;

            /// <remarks/>
            public object PAYMENTID
            {
                get
                {
                    return this.pAYMENTIDField;
                }
                set
                {
                    this.pAYMENTIDField = value;
                }
            }

            /// <remarks/>
            public object PAYMENTID_SECONDARY
            {
                get
                {
                    return this.pAYMENTID_SECONDARYField;
                }
                set
                {
                    this.pAYMENTID_SECONDARYField = value;
                }
            }

            /// <remarks/>
            public object ITEMAMOUNT
            {
                get
                {
                    return this.iTEMAMOUNTField;
                }
                set
                {
                    this.iTEMAMOUNTField = value;
                }
            }

            /// <remarks/>
            public object CUSTOMERPAYMENTTYPEID
            {
                get
                {
                    return this.cUSTOMERPAYMENTTYPEIDField;
                }
                set
                {
                    this.cUSTOMERPAYMENTTYPEIDField = value;
                }
            }

            /// <remarks/>
            public object MISC_ONE
            {
                get
                {
                    return this.mISC_ONEField;
                }
                set
                {
                    this.mISC_ONEField = value;
                }
            }

            /// <remarks/>
            public object MISC_TWO
            {
                get
                {
                    return this.mISC_TWOField;
                }
                set
                {
                    this.mISC_TWOField = value;
                }
            }

            /// <remarks/>
            public object MISC_THREE
            {
                get
                {
                    return this.mISC_THREEField;
                }
                set
                {
                    this.mISC_THREEField = value;
                }
            }

            /// <remarks/>
            public object MISC_FOUR
            {
                get
                {
                    return this.mISC_FOURField;
                }
                set
                {
                    this.mISC_FOURField = value;
                }
            }

            /// <remarks/>
            public object MISC_FIVE
            {
                get
                {
                    return this.mISC_FIVEField;
                }
                set
                {
                    this.mISC_FIVEField = value;
                }
            }

            /// <remarks/>
            public object MISC_SIX
            {
                get
                {
                    return this.mISC_SIXField;
                }
                set
                {
                    this.mISC_SIXField = value;
                }
            }

            /// <remarks/>
            public object MISC_SEVEN
            {
                get
                {
                    return this.mISC_SEVENField;
                }
                set
                {
                    this.mISC_SEVENField = value;
                }
            }

            /// <remarks/>
            public object MISC_EIGHT
            {
                get
                {
                    return this.mISC_EIGHTField;
                }
                set
                {
                    this.mISC_EIGHTField = value;
                }
            }

            /// <remarks/>
            public object MISC_NINE
            {
                get
                {
                    return this.mISC_NINEField;
                }
                set
                {
                    this.mISC_NINEField = value;
                }
            }

            /// <remarks/>
            public object MISC_TEN
            {
                get
                {
                    return this.mISC_TENField;
                }
                set
                {
                    this.mISC_TENField = value;
                }
            }

            /// <remarks/>
            public object MISC_ELEVEN
            {
                get
                {
                    return this.mISC_ELEVENField;
                }
                set
                {
                    this.mISC_ELEVENField = value;
                }
            }

            /// <remarks/>
            public object MISC_TWELVE
            {
                get
                {
                    return this.mISC_TWELVEField;
                }
                set
                {
                    this.mISC_TWELVEField = value;
                }
            }

            /// <remarks/>
            public object MISC_THIRTEEN
            {
                get
                {
                    return this.mISC_THIRTEENField;
                }
                set
                {
                    this.mISC_THIRTEENField = value;
                }
            }

            /// <remarks/>
            public object MISC_FOURTEEN
            {
                get
                {
                    return this.mISC_FOURTEENField;
                }
                set
                {
                    this.mISC_FOURTEENField = value;
                }
            }

            /// <remarks/>
            public object MISC_FIFTEEN
            {
                get
                {
                    return this.mISC_FIFTEENField;
                }
                set
                {
                    this.mISC_FIFTEENField = value;
                }
            }
        }


    }
}