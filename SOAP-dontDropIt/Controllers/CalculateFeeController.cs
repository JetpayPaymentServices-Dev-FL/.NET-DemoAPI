using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SOAP_dontDropIt.Models;

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
            return View(new CalculateFeeModels());
        }

        // POST: CalculateFee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

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
