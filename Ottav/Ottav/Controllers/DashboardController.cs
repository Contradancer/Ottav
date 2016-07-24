using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ottav.Controllers
{
    public class DashboardController : Controller
    {
        //
        // GET: Dashboard/Index
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: Dashboard/List
        public ActionResult List()
        {
            return View();
        }
    }
}