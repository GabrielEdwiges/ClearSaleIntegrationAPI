using System.Collections.Generic;

namespace ClearSaleIntegration.Models.Responses
{
    public class Order
    {
        public string code { get; set; }
        public string status { get; set; }
        public double score { get; set; }
    }
    public class InclusionOfOrdersResponse
    {
        public string packageID { get; set; }
        public List<Order> orders { get; set; }
    }
}
