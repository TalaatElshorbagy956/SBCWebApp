using MCISBCWebApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace MCISBCWebApp.Validators
{
    public class IdNumberValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var model = (CustomerModel)validationContext.ObjectInstance;
            string idNumber = (string)value;

            switch (model.IdentityType)
            {
                case 1:
                    if (ValidateSAID.Check(idNumber) == 1)
                    {
                        return ValidationResult.Success;
                    }
                    return new ValidationResult("Invalid Saudi ID.");
                case 2:
                    if (ValidateSAID.Check(idNumber) == 2)
                    {
                        return ValidationResult.Success;
                    }
                    return new ValidationResult("For type 2, IdNumber must be 10 digits long and start with '2'.");
                case 3:
                    if (!string.IsNullOrEmpty(idNumber) && Regex.IsMatch(idNumber, "^[A-PR-WY][1-9]\\d\\s?\\d{4}[1-9]$"))
                    {
                        return ValidationResult.Success;
                    }
                    return new ValidationResult("Invalid passport number.");
                default:
                    return new ValidationResult("Invalid IdentityType.");
            }
        }
    }
}