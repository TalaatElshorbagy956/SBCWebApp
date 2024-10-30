using MCISBCWebApp.Validators;
using System;
using System.ComponentModel.DataAnnotations;

namespace MCISBCWebApp.Models
{
    public class CustomerModel
    {
        public Guid? Id { get; set; }
        [Required]
        public string FullName { get; set; }

        [Required]
        [IdentityTypeValidation]
        public int IdentityType { get; set; }

        [Required]
        //[IdNumberValidation]
        public string IdNumber { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        
        [Required]
        [PhoneNumberValidation]
        public string PhoneNumber { get; set; }
        
        [Required]
        public string OTPToken { get; set; }
        public string Token { get; set; }
    }

    public class OTPByCustomerIdModel
    {
        [Required]
        public Guid CustomerId { get; set; }
    }
}