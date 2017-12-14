using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api_core.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        // GET api/cities
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(
                new List<object>() {
                    new { id=1, Name="Lisbon" },
                    new { id=2, Name="Oporto" },
                    new { id=3, Name="Faro" },
                    new { id=4, Name="Aalborg" },
                    new { id=5, Name="Copenhagen" },
                    new { id=6, Name="Aarhus" }
                });
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
