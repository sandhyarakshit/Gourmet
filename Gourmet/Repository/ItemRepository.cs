using System.Collections.Generic;
using System.Linq;
using Gourmet.Models;
using Gourmet.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Gourmet.Repository
{
    public class ItemRepository : IItemRepository
    {
        private readonly GourmetDbContext _context;

        public ItemRepository(GourmetDbContext context)
        {
            _context = context;
        }

        public List<Item> GetUnavailableItemsByLocationId(int locationId)
        {
            return _context.Items.Where(i => i.LocationId == locationId && !i.Available).ToList();
        }
    }
}