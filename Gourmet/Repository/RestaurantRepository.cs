using System.Collections.Generic;
using Gourmet.Models; 
using Gourmet.Repository; 
using Gourmet.Interfaces;
using System.Collections.Generic;
using Gourmet.Models; 
using Gourmet.Interfaces;


namespace Gourmet.Repository.RestaurantRepository
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public RestaurantRepository(RestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        public List<Restaurant> GetAllRestaurants()
        {
            return _restaurantRepository.FindAll();
        }

        public Restaurant GetRestaurantById(long id)
        {
            return _restaurantRepository.FindById(id);
        }

        public Restaurant GetRestaurantByName(string name)
        {
            return _restaurantRepository.FindByName(name);
        }
    }
}