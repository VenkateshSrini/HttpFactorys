using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TokenProvider.Controllers
{
    //[Produces("application/json")]
    [Route("api/Values")]
    public class ValuesController : Controller
    {
        public IActionResult Get()
        {
            if (Request.Headers.ContainsKey("x-access"))
            {
                return Ok(new { statusCode = "success" });
            }
            else
                return Unauthorized();
        }
    }
}