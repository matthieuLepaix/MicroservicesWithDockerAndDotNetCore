using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Multiplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultiplicationController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        [Route("{v1}/{v2}")]
        public ActionResult<int> Get(int v1, int v2)
        {
            return v1 * v2;
        }
    }
}
