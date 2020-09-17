using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace CoffeeMaker.Common.Connections
{
    public static class ConnectionStringManager
    {
        public static string ConnectionStringFromConfig(IConfiguration configuration, IConfigurationRoot configRoot)
            => configuration.GetConnectionString("") ?? configRoot["ConnectionStrings:"];
        public static string GetConnectionStringFromKeyVault()
        {
            return null;
        }
    }
}
