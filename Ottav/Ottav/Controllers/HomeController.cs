using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ottav.Controllers
{
    [RoutePrefix("home")]
    [Route("{action=Index}")]
    //[Route("home/{action}")]
    public class HomeController : Controller
    {
        [Route("~/")]
        [Route("~/badjoras")]           // Escape from RoutePrefix
        [Route("")]
        //[Route("index")]
        public ActionResult Index()
        {
            return View();
        }

        //[Route("about")]
        //[Route("about/{valor}")]
        //public ActionResult About(int valor)
        public ActionResult About()

        {
            ViewBag.Message = "Your application description page.";
            ViewBag.valor = 3;

            return View();
        }

        //[Route("contact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}