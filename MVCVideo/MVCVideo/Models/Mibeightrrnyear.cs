﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCVideo.Models
{
    public class Mibeightrrnyear : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if( customer.MemberShipTypeId==MembershipType.Unknown||
                customer.MemberShipTypeId == MembershipType.PayAsYouGo)
            {
                return ValidationResult.Success;
            }
            if(customer.DOB == null)
            {
                return new ValidationResult("Birthdate is required");
            }
            var age = DateTime.Today.Year - customer.DOB.Year;
            return (age > 18) 
                ? ValidationResult.Success 
                : new ValidationResult("Customer should be at least 18 years old to go on a membership");
        }
    }
}