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
            ViewBag.MoviesList = new List<SelectListItem>()
            {
                new SelectListItem { Value = "El SpiderMân!", Text = "Spider-man"  },
                new SelectListItem { Value = "This is Spaaaartaaaa", Text = "300" },
                new SelectListItem { Value = "Not the beeeeeeeeeees!!!", Text = "Wicker Man" },
                new SelectListItem { Value = "Freeeeeedoooom!!", Text = "Braveheart" }
            };

            DropDownFields fields = new DropDownFields();
            return View(fields);
        }

        //
        // POST: DropDownList
        [HttpPost]
        public ActionResult DropDownList(string optionSelect, DropDownFields fields, string MoviesList)
        {
            ViewBag.MoviesList = InitializeViewBagList();

            // <select> DropDown List

            string forma1 = optionSelect;
            string forma2 = Request["optionSelect"];
            string forma3 = Request.Form["optionSelect"];

            if (!string.IsNullOrWhiteSpace(optionSelect))
                ViewBag.optSelected = optionSelect;

            // DropDownList

            if (!string.IsNullOrEmpty(MoviesList))
            {
                ViewBag.opt2Selected = MoviesList;
            }

            // DropDownListFor
            if (!string.IsNullOrWhiteSpace(fields.selectedField))
            {
                return View(fields);
            }

            // Clear Model Fields - Form Reset;
            //ModelState.Clear();

            return View(fields);
        }

        public List<SelectListItem> InitializeViewBagList()
        {
            List<SelectListItem> list = new List<SelectListItem>()
            {
                new SelectListItem { Value = "El SpiderMân!", Text = "Spider-man"  },
                new SelectListItem { Value = "This is Spaaaartaaaa", Text = "300" },
                new SelectListItem { Value = "Not the beeeeeeeeeees!!!", Text = "Wicker Man" },
                new SelectListItem { Value = "Freeeeeedoooom!!", Text = "Braveheart" }
            };

            return list;
        }
    }
}