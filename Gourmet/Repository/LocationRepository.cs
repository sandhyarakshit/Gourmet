using System.Collections.Generic;
using Gourmet.Models;
using Gourmet.Repository;
using Gourmet.Interfaces;

namespace Gourmet.Repository.LocationRepository
{
    public class LocationRepository : ILocationRepository
    {
        private readonly ILocationRepository locationRepository;
Gourmet.Repository.LocationRepository locationRepository = new Gourmet.Repository.LocationRepository();
        public LocationRepository(ILocationRepository locationRepository)
        {
            this.locationRepository = locationRepository;
        }

        public List<Location> GetLocationsByRestaurantId(long restaurantId)
        {
            return locationRepository.GetLocationsByRestaurantId(restaurantId);
        }

        public Location GetLocationByNameAndRestaurantId(string locationName, long restaurantId)
        {
            return locationRepository.GetLocationByNameAndRestaurantId(locationName, restaurantId);
        }
    }
}

