using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TokenProvider.Controllers
{
  
    [Route("api/TokenProvider")]
    public class TokenProviderController : Controller
    {
        public IActionResult Get()
        {
            return Ok(Guid.NewGuid().ToString());
        }
    }
}