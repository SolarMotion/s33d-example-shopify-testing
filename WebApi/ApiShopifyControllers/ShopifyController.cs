using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.ApiIwaControllers;
using WebApi.BALs;
using WebApi.Helpers;
using WebApi.Models;
using static WebApi.Models.ApiBase;
using static WebApi.Helpers.WebApiLogging;

namespace WebApi.ApiShopifyControllers
{
    public class ShopifyController : BaseController
    {
        private const string BASE_URL = "api/public/v1/shopify";
        private ApiResponseBody API_RESPONSE_BODY = new ApiResponseBody();
        private ShopifyBAL SHOPIFY_BAL = new ShopifyBAL();

        [Route(BASE_URL + "/fulfillment_get/{OrderID}")]
        [HttpGet]
        public HttpResponseMessage FulfillmentGet([FromUri]FulfillmentGetRequest request)
        {
            ApiStart(nameof(ShopifyController), nameof(FulfillmentGet), CURRENT_TIME);

            API_RESPONSE_BODY = SHOPIFY_BAL.FulfillmentGet(request);

            ApiEnd(nameof(ShopifyController), nameof(FulfillmentGet), CURRENT_TIME, API_RESPONSE_BODY);

            return Request.ConstructHttpResult(API_RESPONSE_BODY);
        }

        [Route(BASE_URL + "/fulfillment_complete/{OrderID}/{FulfillmentID}")]
        [HttpGet]
        public HttpResponseMessage FulfillmentComplete([FromUri]FulfillmentCompleteRequest request)
        {
            ApiStart(nameof(ShopifyController), nameof(FulfillmentComplete), CURRENT_TIME);

            API_RESPONSE_BODY = SHOPIFY_BAL.FulfillmentComplete(request);

            ApiEnd(nameof(ShopifyController), nameof(FulfillmentComplete), CURRENT_TIME, API_RESPONSE_BODY);

            return Request.ConstructHttpResult(API_RESPONSE_BODY);
        }
    }
}
