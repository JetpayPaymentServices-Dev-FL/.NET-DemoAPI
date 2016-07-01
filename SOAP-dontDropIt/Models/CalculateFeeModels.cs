using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace SOAP_dontDropIt.Models
{
    public class CalculateFeeModels
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class FEE
        {

            private string cLIENTKEYField;

            private byte pAYMENTMETHODField;

            private byte cARDTYPEField;

            private byte cOLLECTIONMODEField;

            private decimal aMOUNTField;

            private FEELINEITEM lINEITEMField;

            /// <remarks/>
            public string CLIENTKEY
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
            public byte PAYMENTMETHOD
            {
                get
                {
                    return this.pAYMENTMETHODField;
                }
                set
                {
                    this.pAYMENTMETHODField = value;
                }
            }

            /// <remarks/>
            public byte CARDTYPE
            {
                get
                {
                    return this.cARDTYPEField;
                }
                set
                {
                    this.cARDTYPEField = value;
                }
            }

            /// <remarks/>
            public byte COLLECTIONMODE
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
            public decimal AMOUNT
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
            public FEELINEITEM LINEITEM
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
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class FEELINEITEM
        {

            private string cUSTOMERPAYMENTTYPEIDField;

            private decimal iTEMAMOUNTField;

            /// <remarks/>
            [Display(Name = "API Payment Name")]
            public string CUSTOMERPAYMENTTYPEID
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
            public decimal ITEMAMOUNT
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
        }



    }
}
