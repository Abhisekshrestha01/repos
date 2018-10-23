using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcCompleteProject.Models
{
    public class Lecture
    {
        public int LectureId { get; set; }

        [Required]
        public String Subject { get; set;  }

        [Display(Name ="Lecturer Name")]
        [Required]
        public String Lecturer { get; set; }
        [Required(ErrorMessage ="Lecture Date is required")]
        [DataType(DataType.DateTime)]
        public DateTime LectureDate { get; set; }
    }
}