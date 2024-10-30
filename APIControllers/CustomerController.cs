using MCISBCWebApp.Models;
using MCISBCWebApp.Services;
using System;
using System.Web.Http;

namespace MCISBCWebApp.APIControllers
{
    //[Authorize]
    public class CustomerController : ApiController
    {
        private readonly ComplaintService complaintEntityService;
        private readonly AuthService authService;

        public CustomerController()
        {
            complaintEntityService = new ComplaintService();
            authService = new AuthService();
        }

        [HttpGet]
        [Route("api/Customer/GetCustomerByQuery")]
        public IHttpActionResult GetCustomerByQuery(string query2)
        {
            if (string.IsNullOrEmpty(query2))
                return BadRequest();
            var result = complaintEntityService.GetCustomerByQuery(query2);
            if (result != null)
            {
                string EndingDigitsOfPhoneNumber = !string.IsNullOrEmpty(result.PhoneNumber) ? result.PhoneNumber.Substring(result.PhoneNumber.Length - 4) : null;
                return Ok(new { result.Id, EndingDigitsOfPhoneNumber });
            }
            return Ok(new { });
        }

        [HttpPost]
        [Route("api/Customer/GetCustomerById")]
        public IHttpActionResult GetCustomerById(GetCustomerByIdModel getCustomerModel)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            //validate otp token and mobile 
            var phoneNumber = authService.IsPhoneOTPTokenValidAndGetPhoneNumber(getCustomerModel.OtpToken);
            var result = complaintEntityService.GetCustomerById(getCustomerModel.Id);
            if (string.IsNullOrEmpty(phoneNumber) || !phoneNumber.Equals(result.PhoneNumber))
                return Unauthorized();
            return Ok(result);
        }


        //generate and send OTP SMS
        [HttpPost]
        [Route("api/Customer/GenerateOTPByCustomerId")]
        public IHttpActionResult GenerateOTPByCustomerId(OTPByCustomerIdModel oTPByCustomerIdModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var customer = complaintEntityService.GetCustomerById(oTPByCustomerIdModel.CustomerId);
                if (customer == null)
                {
                    return NotFound();
                }

                var isSent = authService.GenerateAndSendOTPAsSMS(new PhoneOtpRequest { PhoneNumber = customer.PhoneNumber });
                if (isSent)
                    return Ok(new { });
                return BadRequest("SMSSendingFailed");
            }
            catch (UnauthorizedAccessException)
            {
                return Unauthorized();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


        //Submit Sent otp
        [HttpPost]
        [Route("api/Customer/SubmitSentOTPToGetCustomer")]
        public IHttpActionResult SubmitSentOTPToGetCustomer([FromBody] OtpCustomerIdSubmission phoneOtpSubmission)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var customer = complaintEntityService.GetCustomerById(phoneOtpSubmission.CustomerId);
                    if (customer == null)
                    {
                        return NotFound();
                    }

                    var token = authService.CheckOTPAndGenerateOTPToken(phoneOtpSubmission.OTPCode, customer.PhoneNumber);
                    if (!string.IsNullOrEmpty(token))
                        return Ok(new { OTPToken = token, Customer = customer });

                    return BadRequest("InvalidOTP");
                }
                return BadRequest(ModelState);
            }
            catch (UnauthorizedAccessException)
            {
                return Unauthorized();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("api/Customer/CreateCustomer")]
        public IHttpActionResult CreateCustomer(CustomerModel customerModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    customerModel.Token = authService.GetTokenFromRequest(Request);
                    //validate otp token and return mobile 
                    var phoneNumber = authService.IsPhoneOTPTokenValidAndGetPhoneNumber(customerModel.OTPToken);
                    if (string.IsNullOrEmpty(phoneNumber) || !phoneNumber.Equals(customerModel.PhoneNumber))
                        return Unauthorized();

                    customerModel.PhoneNumber = phoneNumber;
                    var CreatedId = complaintEntityService.CreateCustomer(customerModel);
                    if (CreatedId != null)
                        return Ok(CreatedId);
                    else
                        return BadRequest("CustomerNotCreated");
                }
                catch (Exception ex)
                {
                    return InternalServerError();
                }
            }

            return BadRequest(ModelState);
        }

    }
}