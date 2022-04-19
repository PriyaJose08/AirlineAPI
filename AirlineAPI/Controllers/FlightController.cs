using AirlineAPI.Models;
using AirlineLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AirlineAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightController : ControllerBase
    {
        private readonly IFlightMasterRepository flightrep;
        public FlightController(IFlightMasterRepository context)
        {
            flightrep = context;
        }

        [HttpGet]
        public IActionResult GetAllFlights()
        {
            return Ok(flightrep.GetAllFlights());
        }

        [HttpGet("{id}")]
        public IActionResult GetFlightById(int id)
        {
            return Ok(flightrep.GetFlightById(id));
        }

        [HttpPost]
        public IActionResult AddFlight([FromBody] Flightsmaster flightsmaster)
        {
            if (flightsmaster == null)
                return BadRequest();

            if (flightsmaster.Flightname == String.Empty)
            {
                ModelState.AddModelError("Name/FirstName", "The name or first name shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdFlight = flightrep.AddFlight(flightsmaster);

            return Created("Flight", createdFlight);
        }

        [HttpPut]
        public IActionResult UpdateFlight([FromBody] Flightsmaster flightsmaster)
        {
            if (flightsmaster == null)
                return BadRequest();

            if (flightsmaster.Flightname == String.Empty)
            {
                ModelState.AddModelError("Name/FirstName", "The name or first name shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var FlightToUpdate = flightrep.GetFlightById(flightsmaster.FlightregistrationId);

            if (FlightToUpdate == null)
                return NotFound();

            flightrep.UpdateFlight(flightsmaster);

            return NoContent(); //success
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFlight(int id)
        {
            if (id == 0)
                return BadRequest();

            var flightToDelete = flightrep.GetFlightById(id);
            if (flightToDelete == null)
                return NotFound();

            flightrep.DeleteFlight(id);

            return NoContent();//success
        }
    }
}

    
