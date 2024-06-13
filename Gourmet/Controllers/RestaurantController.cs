using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Gourmet.Interfaces;
using Gourmet.Models;
using Gourmet.Repository;

namespace Gourmet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantRespository _restaurantService;

        public RestaurantController(IRestaurantRespository restaurantService)
        {
            _restaurantService = restaurantService;
        }

        // GET: api/restaurants
        [HttpGet]
        public ActionResult<List<Restaurant>> GetAllRestaurants()
        {
            return _restaurantService.GetAllRestaurants();
        }

        // GET: api/restaurants/{id}
        [HttpGet("{id}")]
        public ActionResult<Restaurant> GetRestaurantById(long id)
        {
            return _restaurantService.GetRestaurantById(id);
        }

        // GET: api/restaurants/name/{name}
        [HttpGet("name/{name}")]
        public ActionResult<Restaurant> GetRestaurantByName(string name)
        {
            return _restaurantService.GetRestaurantByName(name);
        }
    }
}