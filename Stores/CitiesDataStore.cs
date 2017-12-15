using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api_core.Controllers
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most visited urban park in US"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "The 102-story skyscrapper located in Midtown Manhattan"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Lisbon",
                    Description = "The one with that nostalgy"
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Barcelona",
                    Description = "The one with no country"
                },
                new CityDto()
                {
                    Id = 1,
                    Name = "Paris",
                    Description = "Oh-la-la-la"
                }
            };
        }
    }
}