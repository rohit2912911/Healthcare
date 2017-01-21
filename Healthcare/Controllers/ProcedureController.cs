using System;
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

        public ActionResult ProcedureDetail()
        {
            return View();
        }
    }
}