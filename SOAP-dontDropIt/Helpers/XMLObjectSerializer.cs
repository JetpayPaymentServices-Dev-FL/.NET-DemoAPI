using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace SOAP_dontDropIt.Helpers
{
    public class XMLObjectSerializer
    {
        public String objectXMLConverter<T>(Object obj)
        {
            var xml = String.Empty;
            try
            {
                XmlSerializer xsSubmit = new XmlSerializer(typeof(T));
                using (StringWriter sww = new StringWriter())
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, obj);
                    xml = sww.ToString();
                }
            }
            catch
            {
                
            }
            return xml;
        }
    }
}