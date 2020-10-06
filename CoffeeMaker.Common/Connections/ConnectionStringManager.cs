using Microsoft.Azure.KeyVault;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Threading.Tasks;

namespace CoffeeMaker.Common.Connections
{
    public static class ConnectionStringManager
    {
        private const string clientId = "";
        private const string clientSecret = "";
        public static string ConnectionStringFromConfig(IConfiguration configuration, IConfigurationRoot configRoot)
            => configuration.GetConnectionString("SqlConnection") ?? configRoot["SqlConnection"];
        public static string GetConnectionStringFromKeyVault(string connectionKey)
        {
            return string.Empty;
            //TODO Add authenticaton in Key Vault in ther file and add here method to retrieve from KeyVault
        }

        public static async Task<string> VaultClientAuthenticate(string authority, string resource, string scope)
        {
            var authContext = new AuthenticationContext(authority);
            var clientCred = new ClientCredential(clientId, clientSecret);
            var result = await authContext.AcquireTokenAsync(resource, clientCred);

            if (result == null)
                throw new Exception("Could obtain access token");

            return result.AccessToken;
        }
    }
}
