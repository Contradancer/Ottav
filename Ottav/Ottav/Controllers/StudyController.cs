using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ottav.Models.Study;

namespace Ottav.Controllers
{
    public class StudyController : Controller
    {
        //
        // GET: Study
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: DropDownList
        public ActionResult DropDownList()
        {
            return View();
        }

        //
        // POST: DropDownList
        [HttpPost]
        public ActionResult DropDownList(DropDownFields fields, string optionSelect)
        {
            // Escolhido por Select Option. Sendo optionSelect o "name" da <select> tag
            string forma1 = optionSelect;
            string forma2 = Request["optionSelect"];
            string forma3 = Request.Form["optionSelect"];

            if (!string.IsNullOrEmpty(optionSelect))
                ViewBag.optSelected = optionSelect;

            return View();
        }
    }
}