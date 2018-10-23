using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MVCVideo.Models;

namespace MVCVideo.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> membershipTypes { get; set; }
        public int? Id { get; set; }
        [Required(ErrorMessage = "Please enter customer's name")]
        [StringLength(255)]

        public string Name { get; set; }

        [Display(Name = "Birth Date")]
        [Mibeightrrnyear]
        public DateTime? DOB { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        [Display(Name = "Membership Type")]
        public byte? MemberShipTypeId { get; set; }

        public NewCustomerViewModel()
        {
            Id = 0;
        }
        public NewCustomerViewModel(Customer customers)
        {
            Id = customers.Id;
            Name = customers.Name;
            DOB = customers.DOB;
            IsSubscribedToNewsLetter = customers.IsSubscribedToNewsLetter;
            MemberShipTypeId = customers.MemberShipTypeId;
        }
    }

    
}