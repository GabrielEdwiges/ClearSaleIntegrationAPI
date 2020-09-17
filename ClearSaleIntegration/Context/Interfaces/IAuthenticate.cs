using ClearSaleIntegration.Context.Contents;
using ClearSaleIntegration.Context.Responses;
using Refit;
using System.Threading.Tasks;

namespace ClearSaleIntegration.Context.Interfaces
{
    public interface IAuthenticate
    {
        [Post("/authenticate")]
        Task<Authenticate> authenticate([Body] AuthenticateContent content);
    }
}
