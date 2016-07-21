using SOAP_dontDropIt.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;
using SOAP_dontDropIt.Helpers;

namespace SOAP_dontDropIt.Controllers
{
    public class LegacyServicesController : Controller
    {
        // GET: LegacyAPI Index
        public ActionResult Index()
        {
            return View();
        }
        // GET: CalculateFee
        [HttpGet]
        public ActionResult CalculateFee()
        {
            return View();
        }
        // POST: CalculateFee
        [HttpPost]
        public ActionResult CalculateFee(CalculateFeeModels.FEE collection)
        {
            try
            {
                com.collectorsolutions.secure.legacy.ProcessingGateway ws = new com.collectorsolutions.secure.legacy.ProcessingGateway(); //The web service
                XmlDocument xmlRequest = new XmlDocument();
                XMLObjectSerializer obj = new XMLObjectSerializer();
                xmlRequest.LoadXml(obj.objectXMLConverter<CalculateFeeModels.FEE>(collection));
                //post/receive response//
                var reader = new StringReader(ws.calculateFee(xmlRequest).OuterXml);
                var serializer = new XmlSerializer(typeof(CalculateFeeResponseModels.FEE));
                var instance = (CalculateFeeResponseModels.FEE)serializer.Deserialize(reader);
                //send data to partial view so it can be displayed//
                TempData["CalculateFeeResponse"] = instance;
                return View();
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
        // GET: ProcessTransaction (unencrypted)
        [HttpGet]
        public ActionResult ProcessTransaction()
        {
            return View();
        }

        // POST: ProcessTransaction (unencrypted)
        [HttpPost]
        public ActionResult ProcessTransaction(ProcessTransactionModels.TRANSACTION transaction)
        {
            try
            {
                com.collectorsolutions.secure.legacy.ProcessingGateway ws = new com.collectorsolutions.secure.legacy.ProcessingGateway(); //The web service
                //Gregg test client key//CIID 9873rfrf5673mjkmnhyu675tr498iu78
                XmlDocument xmlRequest = new XmlDocument();
                var xml = String.Empty;
                //transaction.URLSILENTPOST = @"https://actweb.acttax.com/act_webdev/common/JavaSecure/CollectorSolutions/realtimeNotification.jsp?transID=" + transaction.TRANSACTIONID + "&status=2";
                //transaction.URLSILENTPOST = @"https://actweb.acttax.com/act_webdev/common/JavaSecure/CollectorSolutions/realtimeNotification.jsp";
                XmlSerializer xsSubmit = new XmlSerializer(typeof(ProcessTransactionModels.TRANSACTION));
                using (StringWriter sww = new StringWriter())
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, transaction);
                    xml = sww.ToString();
                }
                xmlRequest.LoadXml(xml);
                var reader = new StringReader(ws.VT_Transaction_POST(xmlRequest).OuterXml);
                var serializer = new XmlSerializer(typeof(ProcessTransactionModels.TRANSACTION));
                var instance = (ProcessTransactionModels.TRANSACTION)serializer.Deserialize(reader);
                //TempData["CalculateFeeResponse"] = instance;
                return RedirectToAction("ProcessTransaction");
            }
            catch
            {
                return View();
            }
        }
        // GET: ProcessTransaction (encrypted)
        [HttpGet]
        public ActionResult ProcessTransactionEncrypted()
        {
            return View();
        }

        // POST: ProcessTransaction (encrypted)
        [HttpPost]
        public ActionResult ProcessTransactionEncrypted(ProcessTransactionEncryptedModels.TRANSACTION transaction)
        {
            try
            {
                com.collectorsolutions.secure.legacy.ProcessingGateway ws = new com.collectorsolutions.secure.legacy.ProcessingGateway(); //The web service
                //Gregg test client key//CIID 9873rfrf5673mjkmnhyu675tr498iu78
                XmlDocument xmlRequest = new XmlDocument();
                var xml = String.Empty;
                //transaction.URLSILENTPOST = @"https://actweb.acttax.com/act_webdev/common/JavaSecure/CollectorSolutions/realtimeNotification.jsp?transID=" + transaction.TRANSACTIONID + "&status=2";
                //transaction.URLSILENTPOST = @"https://actweb.acttax.com/act_webdev/common/JavaSecure/CollectorSolutions/realtimeNotification.jsp";
                XmlSerializer xsSubmit = new XmlSerializer(typeof(ProcessTransactionEncryptedModels.TRANSACTION));
                using (StringWriter sww = new StringWriter())
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, transaction);
                    xml = sww.ToString();
                }
                xmlRequest.LoadXml(xml);
                var reader = new StringReader(ws.VT_Transaction_POST(xmlRequest).OuterXml);
                var serializer = new XmlSerializer(typeof(ProcessTransactionEncryptedModels.TRANSACTION));
                var instance = (ProcessTransactionEncryptedModels.TRANSACTION)serializer.Deserialize(reader);
                //TempData["CalculateFeeResponse"] = instance;
                return RedirectToAction("ProcessTransaction");
            }
            catch
            {
                return View();
            }
        }
    }
}