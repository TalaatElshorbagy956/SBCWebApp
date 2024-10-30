using System.ComponentModel.DataAnnotations;

namespace MCISBCWebApp.Validators
{
    public class IdentityTypeValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int identityType = (int)value;
            if (identityType == 1 || identityType == 2 || identityType == 3)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("IdentityType must be 1, 2, or 3.");
        }
    }
}