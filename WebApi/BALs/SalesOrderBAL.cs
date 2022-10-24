using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Helpers;
using WebApi.Models;
using static WebApi.Models.ApiBase;
using static WebApi.Helpers.CustomApiResponse;
using static WebApi.Helpers.Log;

namespace WebApi.BALs
{
    public class SalesOrderBAL
    {
        private readonly GlobalVariable GLOBE = new GlobalVariable() { VERSION = ApiVersion.One.GetEnumDescription() };

        public ApiResponseBody Get()
        {
            try
            {
                var response = new SalesOrderGetResponse() { Status = "System is running." };

                return ConstructSuccessResponse(response, GLOBE);
            }
            catch (Exception ex)
            {
                PublicError(ex);
                return ConstructInternalServerErrorResponse(new SalesOrderGetResponse(), GLOBE);
            }
        }

        public ApiResponseBody Create()
        {
            try
            {
                var response = new SalesOrderCreateResponse() { Status = "System is running." };

                return ConstructSuccessResponse(response, GLOBE);
            }
            catch (Exception ex)
            {
                PublicError(ex);
                return ConstructInternalServerErrorResponse(new SalesOrderCreateResponse(), GLOBE);
            }
        }
    }
}