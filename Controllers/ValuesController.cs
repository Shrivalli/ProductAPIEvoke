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
            int a = 10;
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> getValues()
        {
            int b = 20;
            return Ok("welcome");
        }

        //Put method added
        [HttpPut]
        public async Task<ActionResult> UpdateValues(Value v)
        {
            return Ok();
        }


        
    }
}
