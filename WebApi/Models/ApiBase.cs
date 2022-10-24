using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace WebApi.Models
{
    public class ApiBase
    {
        public class ApiBaseRequest
        {
        }

        public class ApiBaseResponse
        {
        }

        public class ApiResponseBody
        {
            public HttpStatusCode HttpStatusCode { get; set; }

            public string Version { get; set; }

            public int ResponseCode { get; set; }

            public string ResponseMessage { get; set; }

            public object Data { get; set; }
        }
    }
}