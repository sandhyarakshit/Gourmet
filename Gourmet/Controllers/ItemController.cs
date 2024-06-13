using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Gourmet.Interfaces;
using Gourmet.Repository;
using Gourmet.Models;

namespace Gourmet.Controllers.ItemController
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemRepository _itemService;

        public ItemController(IItemRepository itemService)
        {
            _itemService = itemService;
        }

        // GET: api/items/location/{locationId}
        [HttpGet("location/{locationId}")]
        public ActionResult<List<Item>> GetUnavailableItemsByLocationId(int locationId)
        {
            return _itemService.GetUnavailableItemsByLocationId(locationId);
        }
    }
}