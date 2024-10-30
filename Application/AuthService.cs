using MCISBCWebApp.Application;
using MCISBCWebApp.Models;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.ServiceModel.Description;
using System.Text;
using SymmetricSecurityKey = Microsoft.IdentityModel.Tokens.SymmetricSecurityKey;


namespace MCISBCWebApp.Services
{
    public class AuthService
    {

        public AuthService()
        {
            organizationService = ConnectCrmOrgService();
        }

        private const string SecretKey = "Ministry-of-Commerce-Institution-SBC-Integration-Key";
        private readonly SymmetricSecurityKey _signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(SecretKey));
        private readonly IOrganizationService organizationService;

        public bool IsAuthTokenValid(string authToken)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            try
            {
                tokenHandler.ValidateToken(authToken, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = _signingKey,
                    ValidateIssuer = true,
                    ValidIssuer = "SBC",
                    ValidateAudience = true,
                    ValidAudience = "MCI",
                    ValidateLifetime = true
                }, out SecurityToken validatedToken);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public string IsPhoneOTPTokenValidAndGetPhoneNumber(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            try
            {
                var principal = tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = _signingKey,
                    ValidateIssuer = true,
                    ValidIssuer = "SBC",
                    ValidateAudience = true,
                    ValidAudience = "MCI",
                    ValidateLifetime = true
                }, out SecurityToken validatedToken);

                var phoneNumberClaim = principal.FindFirst(System.IdentityModel.Claims.ClaimTypes.MobilePhone);
                return phoneNumberClaim?.Value;
            }
            catch
            {
                return null;
            }
        }

        public OrganizationServiceProxy ConnectCrmOrgService(string username = "mmmohamed", string password = "bnoo@mc11")
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            ServicePointManager.ServerCertificateValidationCallback =
                (sender, certificate, chain, sslPolicyErrors) => true;

            ClientCredentials clientCredentials = new ClientCredentials();
            clientCredentials.UserName.UserName = username;
            clientCredentials.UserName.Password = password;

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            return new OrganizationServiceProxy
                      (new Uri("https://crm.mc.gov.sa/MCI/XRMServices/2011/Organization.svc"),
                   null, clientCredentials, null);
        }

        public OrganizationServiceProxy ConnectCrmOrgServiceByToken(string token)
        {
            var username = GetUserCredsFromToken(token);
            return ConnectCrmOrgService(username, "bnoo@mc11");
        }


        public string AuthenticateAndGenerateToken(string username,string password)
        {
            if (AreCredentialsValid(username, password))
            {
                return GenerateAuthToken(username);
            }

            throw new UnauthorizedAccessException("Invalid credentials");
        }



        private bool AreCredentialsValid(string username, string password)
        {
            try
            {
                var orgService = ConnectCrmOrgService(username, password);
                var request = new Microsoft.Crm.Sdk.Messages.WhoAmIRequest();
                var response = (Microsoft.Crm.Sdk.Messages.WhoAmIResponse)orgService.Execute(request);
                return response.UserId != Guid.Empty;
            }
            catch
            {
                // Handle exceptions or log errors if needed
                return false;
            }
        }

        private string GenerateAuthToken(string username)
        {
            var claims = new[]
            {
        new Claim(System.IdentityModel.Claims.ClaimTypes.Name, username)    };

            var token = new JwtSecurityToken(
                issuer: "SBC",
                audience: "MCI",
                claims: claims,
                expires: DateTime.Now.AddMonths(1),
                signingCredentials: new SigningCredentials(_signingKey, SecurityAlgorithms.HmacSha256)
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public string CheckOTPAndGenerateOTPToken(string OtpCode, string PhoneNumber)
        {
            if (OTPGeneratorService.ValidateOtp(PhoneNumber, OtpCode))

            {
                var claims = new[] { new Claim(System.IdentityModel.Claims.ClaimTypes.MobilePhone, PhoneNumber) };

                var token = new JwtSecurityToken(
                    issuer: "SBC",
                    audience: "MCI",
                    claims: claims,
                    expires: DateTime.UtcNow.AddMinutes(2),
                    signingCredentials: new SigningCredentials(_signingKey, SecurityAlgorithms.HmacSha256Signature)
                );

                return new JwtSecurityTokenHandler().WriteToken(token);
            }

            return null;
        }

        public string GetTokenFromRequest(HttpRequestMessage requestMessage)
        {
            var authorizationHeader = requestMessage.Headers.Authorization;
            if (authorizationHeader == null || authorizationHeader.Scheme != "Bearer")
            {
                return null;
            }

            var token = authorizationHeader.Parameter;
            return token;
        }

        private string GetUserCredsFromToken(string token)
        {
            if (string.IsNullOrEmpty(token))
            {
                return null;
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(SecretKey);

            try
            {
                var tokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidIssuer = "SBC",
                    ValidateAudience = true,
                    ValidAudience = "MCI",
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };

                var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out var securityToken);

                if (securityToken is JwtSecurityToken jwtToken)
                {
                    var username = principal.Claims.FirstOrDefault(c => c.Type == System.IdentityModel.Claims.ClaimTypes.Name)?.Value;

                    return username;
                }
            }
            catch (System.Exception ex)
            {
                return null;
            }

            return null;
        }



        public Entity GetUserByUsername(string username)
        {
            var query = new QueryExpression("systemuser")
            {
                ColumnSet = new ColumnSet("systemuserid"),
                Criteria = new FilterExpression
                {
                    Conditions = { new ConditionExpression("domainname", ConditionOperator.Equal, "MCI\\" + username) }
                }
            };

            var result = organizationService.RetrieveMultiple(query);
            var user = result.Entities.FirstOrDefault();

            if (user != null)
            {
                return user;
            }

            return null;
        }


        public bool GenerateAndSendOTPAsSMS(PhoneOtpRequest phoneOtpRequest)
        {
            var otpCode = OTPGeneratorService.GenerateAndStoreOtp(phoneOtpRequest.PhoneNumber);

            var smsSender = new SMSSenderService();
            return smsSender.SendSBCSMS(new SMSModel
            {
                BodyParameters = { otpCode },
                PhoneNumber = phoneOtpRequest.PhoneNumber
            });
        }

        public void IsValidOTP(string otp)
        {

        }
    }
}