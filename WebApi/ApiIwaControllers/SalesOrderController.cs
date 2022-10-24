using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static WebApi.Models.ApiBase;
using static WebApi.Helpers.WebApiLogging;
using WebApi.Helpers;
using WebApi.BALs;
using static WebApi.Helpers.CommonExtension;

namespace WebApi.ApiIwaControllers
{
    public class SalesOrderController : BaseController
    {
        private const string BASE_URL = "api/public/v1/sales_order";
        private ApiResponseBody API_RESPONSE_BODY = new ApiResponseBody();
        private SalesOrderBAL SALES_ORDER_BAL = new SalesOrderBAL();

        [Route(BASE_URL + "/create")]
        [HttpPost]
        public HttpResponseMessage Create()
        {
            ApiStart(nameof(SalesOrderController), nameof(Create), CURRENT_TIME);

            ApiFullRequestBody(GetRawPostData(this).Result);

            API_RESPONSE_BODY = SALES_ORDER_BAL.Create();

            ApiEnd(nameof(SalesOrderController), nameof(Create), CURRENT_TIME, API_RESPONSE_BODY);

            return Request.ConstructHttpResult(API_RESPONSE_BODY);
        }
    }
}
