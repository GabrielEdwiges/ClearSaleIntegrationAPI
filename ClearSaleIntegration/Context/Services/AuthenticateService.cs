using ClearSaleIntegration.Context.Contents;
using ClearSaleIntegration.Context.Interfaces;
using ClearSaleIntegration.Context.Responses;
using Newtonsoft.Json;
using Refit;

namespace ClearSaleIntegration.Context.Services
{
    public class AuthenticateService
    {
        private const string urlBase = "https://homologacao.clearsale.com.br/api/v1";

        public Authenticate authenticate(AuthenticateContent content)
        {
            try
            {
                var auth = RestService.For<IAuthenticate>(urlBase);
                var result = JsonConvert.DeserializeObject<Authenticate>(JsonConvert.SerializeObject(auth.authenticate(content).Result));
                return result;
            }
            catch
            {
                return null;
            }
            
        }
    }
}
