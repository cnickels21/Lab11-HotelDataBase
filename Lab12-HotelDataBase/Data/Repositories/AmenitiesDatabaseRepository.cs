using Lab12_HotelDataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab12_HotelDataBase.Data.Repositories
{
    public class AmenitiesDatabaseRepository : IAmenitiesRepository
    {
        public bool AmenityExists(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Amenities> DeleteAmenity(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Amenities>> GetAllAmenities()
        {
            throw new NotImplementedException();
        }

        public Task<Amenities> GetOneAmenity(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Amenities> SaveNewAmenity(Amenities amenities)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAmenity(int id, Amenities amenities)
        {
            throw new NotImplementedException();
        }
    }
}
