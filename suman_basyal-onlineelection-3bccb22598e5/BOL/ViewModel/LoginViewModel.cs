using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BOL.ViewModel
{
    public class LoginViewModel
    {
        public List<Gender> listGender { get; set; }
        public int userId { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        [Compare("password",ErrorMessage ="Password do not match")]
        public string confirmPassword { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string firstName { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string lastName { get; set; }
        public string middleName { get; set; }

        [Required]
        public Nullable<int> genderId { get; set; }
        public byte[] photo { get; set; }

        public HttpPostedFileBase UploadImages { get; set; }

    }
}
