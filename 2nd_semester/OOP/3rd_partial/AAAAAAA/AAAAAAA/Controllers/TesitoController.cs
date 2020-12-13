using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AAAAAAA.Controllers
{
    public class TesitoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

      

        public ActionResult Welcome(string name, int numTimes = 1)
        {

            return View();
        }
    }
}