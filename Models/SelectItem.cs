using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MCISBCWebApp.Models
{
    public class SelectItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ParentClassificationId { get; set; } 
    }
}