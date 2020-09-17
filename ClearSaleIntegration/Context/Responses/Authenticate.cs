using System;

namespace ClearSaleIntegration.Context.Responses
{
    public class Authenticate
    {
        public string Token { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
