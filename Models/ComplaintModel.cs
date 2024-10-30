using MCISBCWebApp.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MCISBCWebApp.Models
{
    public class ComplaintModel
    {
        // Validate that it is GUID parsable
        [GuidValidation(ErrorMessage = "Invalid GUID format.")]
        public string CustomerId { get; set; }

        // Only numbers (digits)
        [RegularExpression("^[0-9]*$", ErrorMessage = "IdNumber must be digits only.")]
        public string IdNumber { get; set; }

        // Phone number: only digits and + allowed
        [RegularExpression(@"^\+?[0-9]*$", ErrorMessage = "PhoneNumber must contain only digits and the + sign.")]
        public string PhoneNumber { get; set; }

        // Email
        [NullableEmailAddress(ErrorMessage = "Invalid email address.")]
        public string EmailAddress { get; set; }

        [Required]
        public string ComplaintDescription { get; set; }

        // Only digits
        [RegularExpression("^[0-9]*$", ErrorMessage = "MainClassification must be digits only.")]
        public string MainClassification { get; set; }

        // Only digits
        [RegularExpression("^[0-9]*$", ErrorMessage = "SubClassification must be digits only.")]
        public string SubClassification { get; set; }

        [Required]
        public string OTPToken { get; set; }


    }

    // Custom validation attribute for GUID
    public class GuidValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || Guid.TryParse(value.ToString(), out _))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(ErrorMessage ?? "Invalid GUID format.");
        }
    }
}