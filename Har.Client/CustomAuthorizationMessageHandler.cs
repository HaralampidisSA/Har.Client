using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace Har.Client
{
    public class CustomAuthorizationMessageHandler : AuthorizationMessageHandler
    {
        public CustomAuthorizationMessageHandler(IAccessTokenProvider provider, NavigationManager navigation) : base(provider, navigation)
        {
            ConfigureHandler(
                authorizedUrls: new[] { "http://10.116.85.14:9997" },
                scopes: new[] { "api1" });
        }
    }
}
