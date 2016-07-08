using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SOAP_dontDropIt.Models;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace SOAP_dontDropIt.Controllers
{
    public class CalculateFeeController : Controller
    {
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
                XmlDocument xmlResponse = new XmlDocument();
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
                xmlResponse.LoadXml(ws.calculateFee(xmlRequest).OuterXml);
                string responseCode = xmlResponse.DocumentElement.SelectSingleNode("RESPONSECODE").InnerText;
                string fee = xmlResponse.DocumentElement.SelectSingleNode("FEEAMOUNT").InnerText;
                CalculateFeeResponseModels.FEE calFee = new CalculateFeeResponseModels.FEE();
                calFee.FEEAMOUNT = xmlResponse.DocumentElement.SelectSingleNode("FEEAMOUNT").InnerText;
                //calFee.RESPONSECODE = xmlResponse.DocumentElement.SelectSingleNode("RESPONSECODE");
                TempData["feeAmount"] = calFee.FEEAMOUNT;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CalculateFee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CalculateFee/Create
        public ActionResult Create()
        {
            //CalculateFeeModels.FEE calFee = new CalculateFeeModels.FEE();
            //CalculateFeeModels.FEELINEITEM calFeeLineItem = new
            //this is where we would stub our data on the get
            return View();
        }

        // POST: CalculateFee/Create
        [HttpPost]
        public ActionResult Create(CalculateFeeModels.FEE collection)
        {
            try
            {
                //TODO: check first to see if accountId exists. If so they have account already enrolled, offer an edit screen//
                //
                //dev-web reference//www-dev/magic-services//
                com.collectorsolutions.secure.legacy.ProcessingGateway ws = new com.collectorsolutions.secure.legacy.ProcessingGateway(); //The web service
                //Gregg test client key//CIID 9873rfrf5673mjkmnhyu675tr498iu78
                XmlDocument xmlRequest = new XmlDocument();
                XmlDocument xmlResponse = new XmlDocument();
                string xml = collection.ToString();
                xmlRequest.LoadXml(xml);
                //xmlResponse.LoadXml(ws.calculateFee(xmlRequest).OuterXml);
                string responseCode = xmlResponse.DocumentElement.SelectSingleNode("RESPONSECODE").InnerText;
                string fee = xmlResponse.DocumentElement.SelectSingleNode("TRANSACTIONID").InnerText;
                ViewData["feeAmount"] = fee;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CalculateFee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CalculateFee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CalculateFee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CalculateFee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
