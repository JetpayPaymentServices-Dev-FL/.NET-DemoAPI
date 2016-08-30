﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOAP_dontDropIt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Landing()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        // GET: /Account/Help
        public ActionResult Help()
        {
            return View();
        }

    }
}