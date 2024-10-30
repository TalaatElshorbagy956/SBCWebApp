using System.ServiceModel.Channels;
using System.ServiceModel;

namespace MCISBCWebApp.Application.MCIGateWay
{
    public class ServiceModelHelpers
    {
        public static CustomBinding GetBinding1_1()
        {

            BasicHttpBinding basicbinding = new BasicHttpBinding
            {
                MaxBufferPoolSize = int.MaxValue,
                //added all that
                Security = new BasicHttpSecurity()
                {
                    Mode = BasicHttpSecurityMode.Transport,
                    Transport = new HttpTransportSecurity()
                    {
                        ClientCredentialType = HttpClientCredentialType.None,
                        ProxyCredentialType = HttpProxyCredentialType.None,
                    },
                    Message = new BasicHttpMessageSecurity()
                    {
                        ClientCredentialType = BasicHttpMessageCredentialType.UserName
                    }
                },
                //added all that

                MaxBufferSize = int.MaxValue,
                MaxReceivedMessageSize = int.MaxValue,
                ReaderQuotas =
        {
            MaxArrayLength = 2000000000,
            MaxDepth=128,
            MaxNameTableCharCount = 2000000,
            MaxStringContentLength = 2000000000,
            MaxBytesPerRead = 200000
        }

            };

            CustomBinding customBinding = new CustomBinding(basicbinding);
            BindingElementCollection bec = customBinding.Elements;
            foreach (BindingElement be in bec)
            {
                if (be is HttpTransportBindingElement)
                {
                    HttpTransportBindingElement httpElemet = (HttpTransportBindingElement)be;
                    httpElemet.KeepAliveEnabled = false;
                }

            }
            return customBinding;
        }
    }
}