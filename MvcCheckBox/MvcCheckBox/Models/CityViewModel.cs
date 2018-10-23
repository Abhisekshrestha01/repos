using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCheckBox.Models
{ 

    public class CityViewModel
    {
        public IEnumerable<SelectListItem> Cities { get; set; }
        public IEnumerable<string> SelectCities { get; set; }
    }
}