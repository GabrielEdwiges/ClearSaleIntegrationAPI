using ClearSaleIntegration.Context.Interfaces;
using ClearSaleIntegration.Models;
using ClearSaleIntegration.Models.Responses;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClearSaleIntegration.Context.Services
{
    public class RealTimeDecisionService
    {
        private const string urlBase = "https://homologacao.clearsale.com.br/api/v1";

        public Models.Responses.InclusionOfOrdersResponse makeOrder(Models.InclusionOfOrders content)
        {
            try
            {
                var token = Hub.Authenticate;

                var order = RestService.For<IRealTimeDecision>(urlBase);
                var result = JsonConvert.DeserializeObject<InclusionOfOrdersResponse>(JsonConvert.SerializeObject(order.orders(content, "Bearer " + token).Result));
                return result;
            }
            catch
            {
                return null;
            }
        }
    }
}
