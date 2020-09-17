using Refit;
using System.Threading.Tasks;

namespace ClearSaleIntegration.Context.Interfaces
{
    public interface IRealTimeDecision
    {
        [Headers("Content-Type: application/json")]
        [Post("/orders/")]
        Task<Models.Responses.InclusionOfOrdersResponse> orders([Body] Models.InclusionOfOrders order, [Header("Authorization")] string bearerToken);
    }
}
