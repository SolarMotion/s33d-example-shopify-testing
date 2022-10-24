using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static WebApi.Models.ApiBase;

namespace WebApi.Helpers
{
    public static class CustomApiRequest
    {
        public static T FormatRequest<T>(this T target) where T : ApiBaseRequest
        {
            return target;
        }

        public static void FormatRequest(ApiBaseRequest request)
        {
        }
    }
}