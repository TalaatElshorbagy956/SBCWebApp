using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MCISBCWebApp.Models
{
    public class ClassificationItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<SelectItem> SubClassifications { get; set; } = new List<SelectItem>();
    }
}