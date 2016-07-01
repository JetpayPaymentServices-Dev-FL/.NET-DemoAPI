using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SOAP_dontDropIt.Models;
using System.Xml;

namespace SOAP_dontDropIt.Controllers
{
    public class CalculateFeeController : Controller
    {
        // GET: CalculateFee
        public ActionResult Index()
        {
            return View();
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
                //await DocumentDBRepository<CustomerInfo>.CreateCustomerDocumentsAsync(Repository.GetCustomerInfo());
                //dev-web reference//www-dev/magic-services/
                //com.collectorsolutions.magic.ProcessingGateway ws = new com.collectorsolutions.magic.ProcessingGateway(); //The web service
                //Vero test client key//CIID 53dd564b
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
