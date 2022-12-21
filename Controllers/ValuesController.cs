using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //getvalue method 

        //Post method
        [HttpPost]
        public async Task<ActionResult> AddValue(Value V)
        {
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> getValues()
        {
            return Ok("welcome");
        }

        //Post method
        [HttpPost]
        public async Task<ActionResult> AddValue(Value V)
        {
            return Ok();
        }
    }
}
