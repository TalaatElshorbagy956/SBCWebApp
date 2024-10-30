using Microsoft.IdentityModel.Tokens;
using Microsoft.Owin;
using Microsoft.Owin.Security.Jwt;
using Owin;
using System.Text;

[assembly: OwinStartup(typeof(MCISBCWebApp.Startup))]

namespace MCISBCWebApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var issuer = "SBC";
            var audience = "MCI";
            var secret = "Ministry-of-Commerce-Institution-SBC-Integration-Key"; 

            app.UseJwtBearerAuthentication(new JwtBearerAuthenticationOptions
            {
                TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = issuer,
                    ValidAudience = audience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret))
                }
            });

        }

        
    }
}
