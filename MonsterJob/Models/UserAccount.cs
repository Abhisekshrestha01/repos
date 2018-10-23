using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MonsterJob.Models
{
    public class UserAccount
    {
        public int Id
        {
            get;set;
        }
        [Required(ErrorMessage ="Please select the user type")]
        [Display(Name = "User Type")]
        public int UserTypeId
        {
            get;set;
        }
        [Required(ErrorMessage = "Please enter the Email")]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage ="Please enter a proper email address")]
        [StringLength(80,ErrorMessage = "Email length shou,d not be more than 80 chars")]
        public string Email
        {
            get;set;
        }
        [Required(ErrorMessage = "Please enter the Password")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password
        {
            get;set;
        }
        [Required(ErrorMessage = "Please enter the Dataof Birth")]
        [Display(Name = "Date of Birth")]
        [RegularExpression(@"(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{6,15})$", ErrorMessage="The password must be alphanumeric with at least one number, one letter, and be between 6-15 character in length.")]
        public string DOB
        {
            get;set;
        }
        [Required(ErrorMessage = "Please enter the Contact")]
        [Display(Name = "Contact")]
        [RegularExpression(@"^(1\s*[-\/\.]?)?(\((\d{3})\)|(\d{3}))\s*[-\/\.]?\s*(\d{3})\s*[-\/\.]?\s*(\d{4})\s*(([xX]|[eE][xX][tT])\.?\s*(\d+))*$", ErrorMessage = "Please enter proper phone number")]
        public string Contact
        {
            get;set;
        }
        [Required(ErrorMessage = "Please select a image")]
        [Display(Name = "Image")]
        public string UserImage
        {
            get;set;
        }

    }
}