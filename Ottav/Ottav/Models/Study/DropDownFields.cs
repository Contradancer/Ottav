using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ottav.Models.Study
{
    public class DropDownFields
    {
        public string selectedField { get; set; }

        public List<SelectListItem> DropDownListOptions = new List<SelectListItem>()
        {
            new SelectListItem { Value = "1", Text = "Option1" },
            new SelectListItem { Value = "2", Text = "Option2" },
            new SelectListItem { Value = "3", Text = "Option3" },
            new SelectListItem { Value = "4", Text = "Option4" },
        };
    }
}