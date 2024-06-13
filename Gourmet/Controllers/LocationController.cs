using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Gourmet.Interfaces;
using Gourmet.Models;

namespace Gourmet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationRespository _locationService;

        public LocationController(ILocationRespository locationService)
        {
            _locationService = locationService;
        }

        // GET: api/locations/restaurant/{restaurantId}
        [HttpGet("restaurant/{restaurantId}")]
        public ActionResult<List<Location>> GetLocationsByRestaurantId(long restaurantId)
        {
            return _locationService.GetLocationsByRestaurantId(restaurantId);
        }

        // GET: api/locations/restaurant/{restaurantId}/{locationName}
        [HttpGet("restaurant/{restaurantId}/{locationName}")]
        public ActionResult<Location> GetLocationByNameAndRestaurantId(string locationName, long restaurantId)
        {
            return _locationService.GetLocationByNameAndRestaurantId(locationName, restaurantId);
        }
    }
}