using SOAP_dontDropIt.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;

namespace SOAP_dontDropIt.Controllers
{
    public class LegacyAPIController : Controller
    {
        // GET: LegacyAPI
        public ActionResult Index()
        {
            return View();
        }
        // GET: CalculateFee
        [HttpGet]
        public ActionResult CalculateFee()
        {
            //var model = TempData["feeAmount"];
            return View();
        }

        // POST: CalculateFee/Create
        [HttpPost]
        public ActionResult CalculateFee(CalculateFeeModels.FEE collection)
        {
            try
            {
                //TODO: check first to see if accountId exists. If so they have account already enrolled, offer an edit screen//
                //
                //dev-web reference//www-dev/magic-services//
                com.collectorsolutions.secure.legacy.ProcessingGateway ws = new com.collectorsolutions.secure.legacy.ProcessingGateway(); //The web service
                //Gregg test client key//CIID 9873rfrf5673mjkmnhyu675tr498iu78
                XmlDocument xmlRequest = new XmlDocument();
               // XmlDocument xmlResponse = new XmlDocument();
                var xml = String.Empty;
                XmlSerializer xsSubmit = new XmlSerializer(typeof(CalculateFeeModels.FEE));
                var subReq = new CalculateFeeModels.FEE();
                using (StringWriter sww = new StringWriter())
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, collection);
                    xml = sww.ToString(); // Your XML
                }

                //string xml = collection.ToString();
                xmlRequest.LoadXml(xml);
                //xmlResponse.LoadXml(ws.calculateFee(xmlRequest).OuterXml);
                
                //XmlSerializer serializer = new XmlSerializer(typeof(CalculateFeeResponseModels.FEE));
                //CalculateFeeResponseModels.FEE ei = (CalculateFeeResponseModels.FEE)serializer.Deserialize(new StreamReader(ws.calculateFee(xmlRequest).OuterXml.ToString())); 
                //string responseCode = xmlResponse.DocumentElement.SelectSingleNode("RESPONSECODE").InnerText;
                //string fee = xmlResponse.DocumentElement.SelectSingleNode("FEEAMOUNT").InnerText;
                var serializer = new XmlSerializer(typeof(CalculateFeeResponseModels.FEE));
                CalculateFeeResponseModels.FEE xmlReponse = (CalculateFeeResponseModels.FEE)serializer.Deserialize(new StringReader(ws.calculateFee(xmlRequest).OuterXml));
                //calFee.FEEAMOUNT = xmlReponse.FEEAMOUNT;
                //calFee.RESPONSECODE = ei.RESPONSECODE;
                TempData["feeAmount"] = xmlReponse.FEEAMOUNT;
                return RedirectToAction("CalculateFee");
            }
            catch
            {
                return View();
            }
        }
    }
}