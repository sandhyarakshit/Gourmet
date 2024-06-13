using System.Collections.Generic;
using Gourmet.Models;   

namespace Gourmet.Interfaces
{
    public interface IRestaurantRepository
    {
         List<Restaurant> GetAllRestaurants();
        Restaurant GetRestaurantById(long id);
        Restaurant GetRestaurantByName(string name);
    }
}