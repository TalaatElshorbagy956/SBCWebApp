using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace MCISBCWebApp.Validators
{
    public class PhoneNumberValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string phoneNumber = (string)value;
            if (Regex.IsMatch(phoneNumber, @"^05\d{8}$"))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Invalid Saudi phone number. It should start with '05' followed by 8 digits.");
        }
    }
}