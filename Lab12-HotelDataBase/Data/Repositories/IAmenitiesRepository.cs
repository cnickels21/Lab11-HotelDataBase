using Lab12_HotelDataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab12_HotelDataBase.Data.Repositories
{
    public interface IAmenitiesRepository
    {
        Task<IEnumerable<Amenities>> GetAllAmenities();

        Task<Amenities> GetOneAmenity(int id);

        Task<bool> UpdateAmenity(int id, Amenities amenities);

        Task<Amenities> SaveNewAmenity(Amenities amenities);

        Task<Amenities> DeleteAmenity(int id);

        bool AmenityExists(int id);
    }
}
