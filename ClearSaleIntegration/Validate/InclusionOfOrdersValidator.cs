using ClearSaleIntegration.Context;
using ClearSaleIntegration.Context.Contents;
using ClearSaleIntegration.Context.Services;
using ClearSaleIntegration.Models;
using System;

namespace ClearSaleIntegration.Validate
{
    public class InclusionOfOrdersValidator
    {
        public bool validateToken()
        {
            if (Hub.Authenticate == null)
            {
                try
                {
                    var newToken = new AuthenticateService();
                    var credentials = new AuthenticateContent()
                    {
                        name = "BisPay_RealTime",
                        password = "RiTBorVl9J"
                    };
                    Hub.Authenticate = newToken.authenticate(credentials);
                    if(Hub.Authenticate.ExpirationDate <= DateTime.Now || Hub.Authenticate == null)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                if(Hub.Authenticate.ExpirationDate <= DateTime.Now)
                {
                    try
                    {
                        var newToken = new AuthenticateService();
                        var credentials = new AuthenticateContent()
                        {
                            name = "BisPay_RealTime",
                            password = "RiTBorVl9J"
                        };
                        Hub.Authenticate = newToken.authenticate(credentials);
                        if (Hub.Authenticate.ExpirationDate <= DateTime.Now || Hub.Authenticate == null)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool validateOrder(InclusionOfOrders content)
        {
            if(content.)
        }
    }
}
