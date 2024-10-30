using MCISBCWebApp.Models;
using MCISBCWebApp.Services;
using MCISBCWebApp.Validators;
using System;
using System.Web.Http;


namespace MCISBCWebApp.APIControllers
{
    //[Authorize]
    public class AuthController : ApiController
    {
        private readonly AuthService authService;
        public AuthController()
        {
            authService = new AuthService();
        }


        [AllowAnonymous]
        [HttpPost]
        [Route("api/Auth/GenerateToken")]
        public IHttpActionResult GenerateToken([FromBody] LoginModel login)
        {
            try
            {
                string token = authService.AuthenticateAndGenerateToken(login.Username, login.Password);
                return Ok(new { token });
            }
            catch (UnauthorizedAccessException)
            {
                return Unauthorized();
            }
            catch (System.Exception ex)
            {
                return InternalServerError(ex);
            }
        }


        //generate and send OTP SMS
        [HttpPost]
        [Route("api/Auth/GeneratePhoneOTP")]
        public IHttpActionResult GeneratePhoneOTP([FromBody] PhoneOtpRequest request)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var isSent = authService.GenerateAndSendOTPAsSMS(request);
                    if (isSent)
                        return Ok(new { });
                    return BadRequest("SMSSendingFailed");
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



        //Submit Sent otp
        [HttpPost]
        [Route("api/Auth/SubmitSentOTP")]
        public IHttpActionResult SubmitSentOTP([FromBody] PhoneOtpSubmission phoneOtpSubmission)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var token = authService.CheckOTPAndGenerateOTPToken(phoneOtpSubmission.OTPCode, phoneOtpSubmission.PhoneNumber);
                    if (!string.IsNullOrEmpty(token))
                        return Ok(new { OTPToken = token });

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

    }

}