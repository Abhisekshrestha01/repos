using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UserManagementSystem.Models
{
    [MetadataType(typeof(LoginMetaData))]
    public partial class Login
    {
    }
    public class LoginMetaData
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}