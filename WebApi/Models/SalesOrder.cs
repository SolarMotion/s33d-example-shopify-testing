using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class SalesOrderGetResponse
    {
        public string Status { get; set; }
    }

    public class SalesOrderCreateRequest
    {
        public string Status { get; set; }
    }

    public class SalesOrderCreateResponse
    {
        public string Status { get; set; }
    }
}