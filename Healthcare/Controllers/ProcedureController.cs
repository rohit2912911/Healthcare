﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Healthcare.Controllers
{
    public class ProcedureController : Controller
    {
        // GET: Procedure
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProcedureDetail( string SpecName)
        {
            ViewBag.SpecName = SpecName;
            return View();
        }
        public ActionResult Article()
        {
            return View();
        }

        public ActionResult Appointment()
        {
            return View();
        }
        public ActionResult Hospital()
        {
            return View();
        }

        public ActionResult Cost()
        {
            return View();
        }

    }
}