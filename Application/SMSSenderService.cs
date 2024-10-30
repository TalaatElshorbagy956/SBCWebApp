using MCISBCWebApp.Application.MCIGateWay;
using MCISBCWebApp.Models;
using MCISBCWebApp.Services;
using Microsoft.Xrm.Sdk;
using System.Configuration;
using System.Linq;
using System.Net;
using System.ServiceModel;


namespace MCISBCWebApp.Application
{
    public class SMSSenderService
    {
        private readonly IOrganizationService organizationService;
        private readonly AuthService authService;
        public SMSSenderService()
        {
            authService = new AuthService();
            organizationService = authService.ConnectCrmOrgService();
        }
        public void SendMCISMS(SMSModel smsModel)
        {

            try
            {

                if (string.IsNullOrEmpty(smsModel.PhoneNumber))
                    throw new System.Exception("No phone number found");

                var Key = CRMPreferencesService.GetSystemPreference(organizationService, "APIKey");
                string MCIGateWayServiceURL = CRMPreferencesService.GetSystemPreference(organizationService, "MCIGateWayServiceURL");
                MCIGateWayServiceClient serviceClient = new MCIGateWayServiceClient(ServiceModelHelpers.GetBinding1_1(), new EndpointAddress(MCIGateWayServiceURL));


                ReturnResults response = serviceClient.SendSMS(Key, smsModel.PhoneNumber, smsModel.SMSTemplateCode, smsModel.BodyParameters.ToArray());


            }
            catch (System.Exception ex)
            {

            }

        }


        public bool SendSBCSMS(SMSModel sMSModel)
        {
            try
            {
                var userId = ConfigurationManager.AppSettings["sbcSMSUserId"];
                var password = ConfigurationManager.AppSettings["sbcSMSPassword"]; ;
                var message = ConfigurationManager.AppSettings["SbcOtpMessage"] + sMSModel.BodyParameters.FirstOrDefault();

                var unifonicURL =
                       "https://el.cloud.unifonic.com/wrapper/sendSMS.php?userid=" + userId + "&password=" + password + "&to=" + sMSModel.PhoneNumber + "&sender=SBC-SA&encoding=ut&msg=" + message;

                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                // var response = client.PostAsync(unifonicURL, null).Result;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(unifonicURL);
                WebProxy myproxy = new WebProxy("http://rhqproxy.mci.gov.sa:8080", false);
                myproxy.BypassProxyOnLocal = false;
                request.Proxy = myproxy;
                request.Method = "POST";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                return response.StatusCode == HttpStatusCode.OK;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

    }

}


