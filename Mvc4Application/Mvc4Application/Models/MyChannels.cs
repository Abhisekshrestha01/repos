using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Mvc4Application.Models
{
    [Table("tbl_Channel")]
    public class MyChannels
    {
        public int ID
        {
            get;

            set;
        }

       [Required(ErrorMessage="Enter Name")]
        public string Name
        {
            get;

            set;
        }

        public string Type
        {
            get;

            set;
        }

        public bool Status
        {
            get;

            set;
        }

    }
}