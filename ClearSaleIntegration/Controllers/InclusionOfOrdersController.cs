using ClearSaleIntegration.Context;
using ClearSaleIntegration.Models.Responses;
using ClearSaleIntegration.Validate;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ClearSaleIntegration.Controllers
{
    [Route("pedidos")]
    public class InclusionOfOrdersController : Controller
    {
        [Route("novo")]
        public MainResponse IncludeOrder()
        {
            try
            {
                var validate = new InclusionOfOrdersValidator();
                var isValidated = validate.validateToken();

                if (isValidated)
                {

                    //return new MainResponse()
                    //{
                    //    Message="Sucesso",
                    //    Data=Hub.Authenticate,
                    //    Status=true
                    //};
                }
                else
                {
                    return new MainResponse()
                    {
                        Message = "Erro",
                        Data = "Erro na solicitação do token de autenticação",
                        Status = false
                    };
                }
            }
            catch(Exception e)
            {
                return new MainResponse()
                {
                    Message = "Erro",
                    Data = e.Message,
                    Status = false
                };
            }
        }
    }
}
