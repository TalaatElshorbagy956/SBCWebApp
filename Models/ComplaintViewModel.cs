using System;

namespace MCISBCWebApp.Models
{
    public class ComplaintViewModel
    {
        public Guid? Id { get; set; }
        public string ComplaintNumber { get; set; }
        public string Status { get; set; }
        public CustomerViewModel Contact { get; set; }
        public string IdNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string ComplaintDescription { get; set; }
        public string ComplaintCreationChannel { get; set; }
        public string CreatedBy { get; set; }
        public SelectItem MainClassification { get; set; }
        public int? Statecode { get; set; }
        public SelectItem SubClassification { get; set; }

    }
}