using MCISBCWebApp.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MCISBCWebApp.Models
{
    public class PhoneOtpRequest
    {
        [Required]
        [PhoneNumberValidation]
        public string PhoneNumber { get; set; }
    }


    public class PhoneOtpSubmission
    {
        [Required]
        [PhoneNumberValidation]
        public string PhoneNumber { get; set; }
        [Required]
        [MaxLength(5)]
        public string OTPCode { get; set; }
    }



    public class OtpCustomerIdSubmission
    {
        [Required]
        public Guid CustomerId { get; set; }
        [Required]
        [MaxLength(5)]
        public string OTPCode { get; set; }
    }
}