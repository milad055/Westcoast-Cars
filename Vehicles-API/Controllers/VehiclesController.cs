using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Vehicles_API.Controllers
{
    [ApiController]
    [Route("api/v1/vehicles")]
    public class VehiclesController : ControllerBase
    {
        // en metod för att hämta alla fordon...
        // api/v1/vehicles
        [HttpGet()]
        public ActionResult ListVehicles()
        {
            // alt return OK
            return StatusCode(200, "{'message': 'Det funkar'}");
        }
        
        // api/v1/vehicles/id
        [HttpGet("{id}")]
        public ActionResult GetVehiclesById(int id)
        {
            // alt return OK
            return StatusCode(200, "{'message': 'Det funkar'}");

        }    

    }
}