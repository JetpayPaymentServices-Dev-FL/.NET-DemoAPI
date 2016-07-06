using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOAP_dontDropIt.Controllers
{
    public class VirtualTerminalTransactionController : Controller
    {
        // GET: VirtualTerminalTransaction
        public ActionResult Index()
        {
            return View();
        }

        // GET: VirtualTerminalTransaction/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VirtualTerminalTransaction/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VirtualTerminalTransaction/Create
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

        // GET: VirtualTerminalTransaction/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VirtualTerminalTransaction/Edit/5
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

        // GET: VirtualTerminalTransaction/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VirtualTerminalTransaction/Delete/5
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
