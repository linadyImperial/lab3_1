// I, Linady Imperial, student number 000341325, certify that this material is my
// original work. No other person's work has been used without due
// acknowledgement and I have not made my work available to anyone else.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lab1A.Controllers
{
    [Produces("application/json")]
    [Route("api/DealershipApi")]
    public class DealershipApiController : Controller
    {
        // GET: api/DealershipApi
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //return _context.Cars;
            return new string[] { "value1", "value2" };
        }

        // GET: api/DealershipApi/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/DealershipApi
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/DealershipApi/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
