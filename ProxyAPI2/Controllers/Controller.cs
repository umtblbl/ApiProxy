using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProxyAPI2.Proxy;

namespace ProxyAPI2.Controllers
{
    [Route("api")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IMyResponseProxy myResponseProxy;

        public ValuesController(IMyResponseProxy myResponseProxy)
        {
            this.myResponseProxy = myResponseProxy;
        }

        // GET api/values/5
        [HttpGet("userinfo/{id}")]
        public ActionResult<ApiModel.MyResponse> Get(int id)
        {
            return myResponseProxy.getMyResponse(id);
        }

    }
}
