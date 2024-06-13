using System.Collections.Generic;
using Gourmet.Models;


namespace Gourmet.ItemRepository
{
    public interface IItemRepository
    {
        List<Item> GetUnavailableItemsByLocationId(int locationId);
    }
}