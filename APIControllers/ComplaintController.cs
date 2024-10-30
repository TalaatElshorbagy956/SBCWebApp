using MCISBCWebApp.Models;
using MCISBCWebApp.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace MCISBCWebApp.APIControllers
{
    //[Authorize]
    public class ComplaintController : ApiController
    {
        private readonly ComplaintService complaintEntityService;
        private readonly AuthService authService;

        public ComplaintController()
        {
            complaintEntityService = new ComplaintService();
            authService = new AuthService();
        }



        public ComplaintViewModel GetComplaintByNumber(string complaintNumber, string lang)
        {
            if (!string.IsNullOrEmpty(complaintNumber))
            {
                var language = lang.ToLowerInvariant().Trim().Equals("ar") ? ComplaintService.Language.Arabic : ComplaintService.Language.English;
                var result = complaintEntityService.GetComplaintDetails(complaintNumber, language);
                return result;
            }

            return new ComplaintViewModel();
        }

        [HttpPost]
        [Route("api/Complaint/CreateComplaint")]
        public IHttpActionResult CreateComplaint(ComplaintModel complaintModel)
        {
            if (ModelState.IsValid)
            {
                var customer = complaintEntityService.GetCustomerById(new Guid(complaintModel.CustomerId));
                if (customer == null)
                {
                    return NotFound();
                }
                //validate otp token and customer by phone number
                var phoneNumber = authService.IsPhoneOTPTokenValidAndGetPhoneNumber(complaintModel.OTPToken);
                if (string.IsNullOrEmpty(phoneNumber) || !phoneNumber.Equals(customer.PhoneNumber) || complaintModel.IdNumber != customer.IdNumber)
                    return Unauthorized();

                complaintModel.PhoneNumber = phoneNumber;
                complaintModel.IdNumber = customer.IdNumber;
                complaintModel.EmailAddress = customer.Email;

                var result = complaintEntityService.CreateComplaint(complaintModel);
                return Ok(result);
            }

            return BadRequest();
        }


        public List<SelectItem> GetComplaintsNumbersByQuery(string query)
        {
            var numbers = complaintEntityService.GetComplaintsNumbers(query);

            return numbers;
        }

        public List<ClassificationItem> GetComplaintClassificationsForSBC()
        {
            var result = complaintEntityService.GetMainClassificationsWithSubClassificationsForSBC();
            return result;
        }
    }
}