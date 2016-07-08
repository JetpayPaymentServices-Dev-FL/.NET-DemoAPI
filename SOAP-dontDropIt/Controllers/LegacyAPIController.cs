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
            //var feeReponse = new CalculateFeeResponseModels.FEE()
            //feeReponse = TempData["CalculateFeeResponse"];
            //if(reponse == null){
            //    return View();
            //    //reponse = (TempData["CalculateFeeResponse"] as CalculateFeeResponseModels.FEE);
            //}
            //var model = TempData["CalculateFeeResponse"];
            return View();
        }

        // POST: CalculateFee/Create
        [HttpPost]
        public ActionResult CalculateFee(CalculateFeeModels.FEE collection)
        {
            try
            {
                com.collectorsolutions.secure.legacy.ProcessingGateway ws = new com.collectorsolutions.secure.legacy.ProcessingGateway(); //The web service
                //Gregg test client key//CIID 9873rfrf5673mjkmnhyu675tr498iu78
                XmlDocument xmlRequest = new XmlDocument();
               // XmlDocument xmlResponse = new XmlDocument();
                var xml = String.Empty;
                XmlSerializer xsSubmit = new XmlSerializer(typeof(CalculateFeeModels.FEE));
                using (StringWriter sww = new StringWriter())
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, collection);
                    xml = sww.ToString();
                }
                xmlRequest.LoadXml(xml);
                var reader = new StringReader(ws.calculateFee(xmlRequest).OuterXml);
                var serializer = new XmlSerializer(typeof(CalculateFeeResponseModels.FEE));
                var instance = (CalculateFeeResponseModels.FEE)serializer.Deserialize(reader);
                TempData["CalculateFeeResponse"] = instance.FEEAMOUNT;
                return RedirectToAction("CalculateFee");
            }
            catch
            {
                return View();
            }
        }
        // GET: VirtualTerminalTransaction
        [HttpGet]
        public ActionResult VirtualTerminalTransaction()
        {
            return View();
        }

        // POST: VirtualTerminalTransaction
        [HttpPost]
        public ActionResult VirtualTerminalTransaction(VirtualTerminalTransactionModels.VT_TRANSACTION transaction)
        {
            try
            {
                com.collectorsolutions.secure.legacy.ProcessingGateway ws = new com.collectorsolutions.secure.legacy.ProcessingGateway(); //The web service
                //Gregg test client key//CIID 9873rfrf5673mjkmnhyu675tr498iu78
                XmlDocument xmlRequest = new XmlDocument();
                var xml = String.Empty;
                //transaction.URLSILENTPOST = @"https://actweb.acttax.com/act_webdev/common/JavaSecure/CollectorSolutions/realtimeNotification.jsp?transID=" + transaction.TRANSACTIONID + "&status=2";
                transaction.URLSILENTPOST = @"https://actweb.acttax.com/act_webdev/common/JavaSecure/CollectorSolutions/realtimeNotification.jsp";
                XmlSerializer xsSubmit = new XmlSerializer(typeof(VirtualTerminalTransactionModels.VT_TRANSACTION));
                using (StringWriter sww = new StringWriter())
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, transaction);
                    xml = sww.ToString();
                }
                xmlRequest.LoadXml(xml);
                var reader = new StringReader(ws.VT_Transaction_POST(xmlRequest).OuterXml);
                var serializer = new XmlSerializer(typeof(VirtualTerminalTransactionModels.VT_TRANSACTION));
                var instance = (VirtualTerminalTransactionModels.VT_TRANSACTION)serializer.Deserialize(reader);
                //TempData["CalculateFeeResponse"] = instance;
                return RedirectToAction("VirtualTerminalTransaction");
            }
            catch
            {
                return View();
            }
        }
    }
}