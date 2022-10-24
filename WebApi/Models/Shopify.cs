using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class FulfillmentGetRequest
    {
        public string OrderID { get; set; }
    }

    public class FulfillmentGetResponse
    {

    }

    public class FulfillmentCompleteRequest
    {
        public string OrderID { get; set; }
        public string FulfillmentID { get; set; }
    }

    public class FulfillmentCompleteResponse
    {

    }
}