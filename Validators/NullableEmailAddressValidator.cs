using System.ComponentModel.DataAnnotations;

namespace MCISBCWebApp.Validators
{
    public class NullableEmailAddressAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var email = value as string;

            if (string.IsNullOrEmpty(email))
            {
                return ValidationResult.Success;
            }

            var emailAttribute = new EmailAddressAttribute();
            if (emailAttribute.IsValid(email))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Invalid email address.");
        }
    }

}