using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Gourmet.Repository.UnavailableItemsService;
using Gourmet.Models;
using Gourmet.Interfaces;


using Gourmet.Models;

namespace Gourmet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnavailableItemsController : ControllerBase
    {
        private readonly UnavailableItemsService _unavailableItemsService;

        public UnavailableItemsController(UnavailableItemsService unavailableItemsService)
        {
            _unavailableItemsService = unavailableItemsService;
        }

        // GET: api/unavailableitems/{restaurantName}/{locationName}
        [HttpGet("{restaurantName}/{locationName}")]
        public ActionResult<List<Item>> GetUnavailableItems(string restaurantName, string locationName)
        {
            return _unavailableItemsService.GetUnavailableItems(restaurantName, locationName);
        }
    }
}