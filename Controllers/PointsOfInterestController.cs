using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api_core.Controllers
{
    [Route("api/cities")]
    public class PointsOfInterestController : Controller
    {
        [HttpGet("{cityId}/poi")]
        public IActionResult Get(int cityId)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(x => x.Id == cityId);
            if(city == null)
            {
                return NotFound();
            }

            return Ok(city.PointsOfInterest);
        }

        [HttpGet("{cityId}/poi/{id}", Name = "GetPoi")]
        public IActionResult GetPoi(int cityId, int id)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(x => x.Id == cityId);
            if (city == null)
            {
                return NotFound();
            }

            var poi = city.PointsOfInterest.FirstOrDefault(x => x.Id == id);
            if (poi == null)
            {
                return NotFound();
            }

            return Ok(poi);
        }

        // POST api/values
        [HttpPost("{cityId}/poi")]
        public IActionResult Post(int cityId, [FromBody]PointOfInterestForCreationDto poi)
        {
            if(poi == null)
            {
                return BadRequest();
            }

            var city = CitiesDataStore.Current.Cities.FirstOrDefault(x => x.Id == cityId);
            if (city == null)
            {
                return NotFound();
            }

            var nextId = CitiesDataStore.Current.Cities.SelectMany(x => x.PointsOfInterest).Max(m => m.Id);

            var newPoi = new PointOfInterestDto()
            {
                Id = nextId + 1,
                Name = poi.Name,
                Description = poi.Description
            };

            city.PointsOfInterest.Add(newPoi);

            return CreatedAtRoute("GetPoi", new { cityId = cityId, id = newPoi.Id }, newPoi);
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
