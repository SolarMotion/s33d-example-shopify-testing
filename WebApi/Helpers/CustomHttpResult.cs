using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using static WebApi.Models.ApiBase;

namespace WebApi.Helpers
{
    public static class CustomHttpResult
    {
        public static HttpResponseMessage ConstructHttpResult<T>(this T target, ApiResponseBody baseResponse) where T : HttpRequestMessage
        {
            return target.CreateResponse(baseResponse.HttpStatusCode, baseResponse);
        }
    }
}