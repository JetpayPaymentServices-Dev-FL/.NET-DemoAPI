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
using System.Text.RegularExpressions;

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
                var response = (CalculateFeeResponseModels.FEE)serializer.Deserialize(reader);
                //send data to partial view so it can be displayed//
                TempData["CalculateFeeResponse"] = response;
                return View();
            }
            catch
            {
                return View();
            }
        }
        // GET: VirtualTerminalTransactionPost
        [HttpGet]
        public ActionResult VirtualTerminalTransactionPost()
        {
            return View();
        }

        // POST: VirtualTerminalTransactionPost
        [HttpPost]
        public ActionResult VirtualTerminalTransactionPost(VirtualTerminalTransactionPostModels.VT_TRANSACTION transaction)
        {
            try
            {
                com.collectorsolutions.secure.legacy.ProcessingGateway ws = new com.collectorsolutions.secure.legacy.ProcessingGateway(); //The web service
                XmlDocument xmlRequest = new XmlDocument();
                XMLObjectSerializer obj = new XMLObjectSerializer();
                var xml = String.Empty;
                transaction.URLSILENTPOST = @"https://actweb.acttax.com/act_webdev/common/JavaSecure/CollectorSolutions/realtimeNotification.jsp";
                transaction.PHONE = Regex.Replace(transaction.PHONE, @"\D", "");
                xmlRequest.LoadXml(obj.objectXMLConverter<VirtualTerminalTransactionPostModels.VT_TRANSACTION>(transaction));
                var reader = new StringReader(ws.VT_Transaction_POST(xmlRequest).OuterXml);
                var serializer = new XmlSerializer(typeof(VirtualTerminalTransactionPostResponseModels.VT_TRANSACTION));
                var response = (VirtualTerminalTransactionPostResponseModels.VT_TRANSACTION)serializer.Deserialize(reader);
                TempData["VTPostResponse"] = response;
                if (response.RESPONSECODE.StartsWith("Y"))
                {
                    //PCB Test
                    return Redirect("https://secure.collectorsolutions.com/csi_ecollections_portal_ui/interchange.aspx?ciid=99999991&ste=5&transid=" + response.TRANSACTIONID);
                }
                else
                {
                    return View();
                }
            }
            catch (Exception e)
            {
                return Redirect("~/Shared/Error.cshtml");
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
                XMLObjectSerializer obj = new XMLObjectSerializer();
                var xml = String.Empty;
                //transaction.URLSILENTPOST = @"https://actweb.acttax.com/act_webdev/common/JavaSecure/CollectorSolutions/realtimeNotification.jsp?transID=" + transaction.TRANSACTIONID + "&status=2";
                //transaction.URLSILENTPOST = @"https://actweb.acttax.com/act_webdev/common/JavaSecure/CollectorSolutions/realtimeNotification.jsp";
                XmlSerializer xsSubmit = new XmlSerializer(typeof(ProcessTransactionModels.TRANSACTION));
                xmlRequest.LoadXml(obj.objectXMLConverter<ProcessTransactionModels.TRANSACTION>(transaction));
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