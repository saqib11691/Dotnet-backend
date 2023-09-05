using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backendapi.Controllers
{
    [ApiController]
    [Route("demo")]
    public class BackendController : Controller
    {
        [HttpGet]
        public String Get()
        {
            return "Hello World";
        }
    }
}
