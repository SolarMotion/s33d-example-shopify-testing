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
    public class ShopifyBAL
    {
        private readonly GlobalVariable GLOBE = new GlobalVariable() { VERSION = ApiVersion.One.GetEnumDescription() };

        public ApiResponseBody FulfillmentGet(FulfillmentGetRequest request)
        {
            try
            {
                var response = new FulfillmentGetResponse() { };

                //CHIEN: here
                //https://shopify.dev/tutorials/manage-fulfillments-with-fulfillment-and-fulfillmentservice-resources#create-a-fulfillment
                //https://docs.microsoft.com/en-us/aspnet/web-api/overview/advanced/calling-a-web-api-from-a-net-client

                return ConstructSuccessResponse(response, GLOBE);
            }
            catch (Exception ex)
            {
                PublicError(ex);
                return ConstructInternalServerErrorResponse(new FulfillmentGetResponse(), GLOBE);
            }
        }

        public ApiResponseBody FulfillmentComplete(FulfillmentCompleteRequest request)
        {
            try
            {
                var response = new FulfillmentCompleteResponse() { };

                return ConstructSuccessResponse(response, GLOBE);
            }
            catch (Exception ex)
            {
                PublicError(ex);
                return ConstructInternalServerErrorResponse(new FulfillmentCompleteResponse(), GLOBE);
            }
        }
    }
}