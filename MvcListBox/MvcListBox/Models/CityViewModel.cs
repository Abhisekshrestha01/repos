using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcListBox.Models
{
    public class CityViewModel
    { 
        public IEnumerable<SelectListItem> Cities { get; set; }
        public IEnumerable<String> SelectedCities { get; set; }
    }
}