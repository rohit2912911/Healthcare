using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Healthcare.Controllers
{
    public class DoctorController : Controller
    {
        // GET: Doctor
        public ActionResult Index(string DocId)
        { 
            return View();
        }
        public ActionResult Detail()
        {
            return View();
        }

    }
}