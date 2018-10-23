using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BOL
{
    public class UserValidation
    {
        [EmailAddress]
        [Required]
        public string email { get; set; }

        [Required]
        public string password { get; set; }

        
        public string firstName { get; set; }

        
        public string lastName { get; set; }

        
        public int genderId { get; set; }

      
        //[Required]
        //[Compare]
        //public string confirmPassword { get; set; }
    }

    [MetadataType(typeof(UserValidation))]
    public partial class User
    {
        //public string confirmPassword { get; set; }
    }
}
