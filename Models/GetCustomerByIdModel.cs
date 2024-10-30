using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MCISBCWebApp.Models
{
    public class GetCustomerByIdModel
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string OtpToken { get; set; }
    }
}