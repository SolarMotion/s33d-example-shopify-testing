using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.ApiIwaControllers
{
    public class BaseController : ApiController
    {
        public readonly string CURRENT_TIME = DateTime.Now.ToString("HHmmss");

    }
}
