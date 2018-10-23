using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MvcCache.Common;

namespace MvcCache.Models
{
    [MetadataType(typeof(EmployeeMetaData))]
    public partial class Employee
    {
        //[Compare("Email")]
        public string ConfirmEmail { get; set; }
    }
    public class EmployeeMetaData
    {
        [StringLength(10, MinimumLength = 5)]
        [Required]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "*")]
        public string FirstName { get; set; }


        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [CurrentDate]
        public string HireDate { get; set; }

        [RegularExpression(@"^[\w-\._\+%]+@(?:[\w-]+\.)+[\w]{2,6}$", ErrorMessage ="This email is not valid")]
        public string Email { get; set; }

    }
}