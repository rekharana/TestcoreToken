using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using DemoWebApi.Models;

namespace DemoWebApi.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Value> Get()
        {
            var Values = new List<Value>();

            Values.Add(new Value() { Id = 1, Name = "rekha" });
            Values.Add(new Value() { Id =2, Name = "rekha1" });
            Values.Add(new Value() { Id = 3, Name = "rekha3" });
            Values.Add(new Value() { Id = 4, Name = "rekha4" });
            return Values;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
