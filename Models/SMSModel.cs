using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MCISBCWebApp.Models
{
    public class SMSModel
    {

        public string PhoneNumber;
        public List<string> BodyParameters = new List<string>();
        public string SMSTemplateCode { get; set; }
    }
}