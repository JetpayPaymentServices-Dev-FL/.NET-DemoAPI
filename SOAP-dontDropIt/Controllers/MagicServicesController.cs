using SOAP_dontDropIt.Helpers;
using SOAP_dontDropIt.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;

namespace SOAP_dontDropIt.Controllers
{
    public class MagicServicesController : Controller
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
            return View();
        }

        // POST: CalculateFee/Create
        [HttpPost]
        public ActionResult CalculateFee(CalculateFeeModels.FEE fee)
        {
            try
            {
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                com.collectorsolutions.stage.ProcessingGateway ws = new com.collectorsolutions.stage.ProcessingGateway(); //The web service
                XmlDocument xmlRequest = new XmlDocument();
                XMLObjectSerializer obj = new XMLObjectSerializer();
                xmlRequest.LoadXml(obj.objectXMLConverter<CalculateFeeModels.FEE>(fee));
                //post/receive response//
                var reader = new StringReader(ws.calculateFee(xmlRequest).OuterXml);
                var serializer = new XmlSerializer(typeof(CalculateFeeResponseModels.FEE));
                var response = (CalculateFeeResponseModels.FEE)serializer.Deserialize(reader);
                //send data to partial view so it can be displayed//
                TempData["CalculateFeeResponse"] = response;
                return View();
            }
            catch (Exception e)
            {
                Response.Redirect("~/Shared/Error.cshtml");
            }
            return View();
        }
        // GET: VirtualTerminalTransaction
        [HttpGet]
        public ActionResult VirtualTerminalTransactionPost()
        {
            return View();
        }

        // POST: VirtualTerminalTransaction
        [HttpPost]
        public ActionResult VirtualTerminalTransactionPost(VirtualTerminalTransactionPostModels.VT_TRANSACTION transaction)
        {
            try
            {
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072; //tls protocol override
                com.collectorsolutions.stage.ProcessingGateway ws = new com.collectorsolutions.stage.ProcessingGateway(); //The web service
                XmlDocument xmlRequest = new XmlDocument();
                XMLObjectSerializer obj = new XMLObjectSerializer();
                //stub any optional/required parameters here that are not in the view//
                transaction.COLLECTIONMODE = "1";
                transaction.CSIUSERID = "1";
                transaction.URLSILENTPOST = "";
                xmlRequest.LoadXml(obj.objectXMLConverter<VirtualTerminalTransactionPostModels.VT_TRANSACTION>(transaction));
                //post/receive response//
                var reader = new StringReader(ws.VT_Transaction_POST(xmlRequest).OuterXml);
                var serializer = new XmlSerializer(typeof(VirtualTerminalTransactionPostResponseModels.VT_TRANSACTION));
                var response = (VirtualTerminalTransactionPostResponseModels.VT_TRANSACTION)serializer.Deserialize(reader);
                //send data to partial view so it can be displayed//
                TempData["VTPostResponse"] = response;
                //VirtualTerminal/{clientid}/{transactionid}
                return Redirect("https://stage.collectorsolutions.com/magic-ui/VirtualTerminal/csi-live/" + response.TRANSACTIONID);
                //return View();
            }
            catch (Exception e)
            {
                Response.Redirect("~/Shared/Error.cshtml");
            }
            return View();
        }
        // GET: VirtualTerminalTransaction
        [HttpGet]
        public ActionResult VirtualTerminalTransactionGet()
        {
            return View();
        }

        // POST: VirtualTerminalTransaction
        [HttpPost]
        public ActionResult VirtualTerminalTransactionGet(VirtualTerminalTransactionGetModels.VT_TRANSACTION transaction)
        {
            try
            {
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072; //tls protocol override
                com.collectorsolutions.stage.ProcessingGateway ws = new com.collectorsolutions.stage.ProcessingGateway(); //The web service
                XmlDocument xmlRequest = new XmlDocument();
                XMLObjectSerializer obj = new XMLObjectSerializer();
                //stub any optional/required parameters here that are not in the view//
                xmlRequest.LoadXml(obj.objectXMLConverter<VirtualTerminalTransactionGetModels.VT_TRANSACTION>(transaction));
                //post/receive response//
                var reader = new StringReader(ws.VT_Transaction_GET(xmlRequest).OuterXml);
                var serializer = new XmlSerializer(typeof(VirtualTerminalTransactionGetResponseModels.VT_TRANSACTION));
                var response = (VirtualTerminalTransactionGetResponseModels.VT_TRANSACTION)serializer.Deserialize(reader);
                //send data to partial view so it can be displayed//
                TempData["VTGetResponse"] = response;
                //VirtualTerminal/{clientid}/{transactionid}
                return View();
            }
            catch (Exception e)
            {
                Response.Redirect("~/Shared/Error.cshtml");
            }
            return View();
        }
    }
}