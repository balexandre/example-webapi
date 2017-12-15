using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api_core.Controllers
{ 
    public class PointOfInterestForCreationDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}