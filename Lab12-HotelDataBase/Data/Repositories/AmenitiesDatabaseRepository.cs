using Lab12_HotelDataBase.Models;
using Lab12_HotelDataBase.Models.Api;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab12_HotelDataBase.Data.Repositories
{
    public class AmenitiesDatabaseRepository : IAmenitiesRepository
    {
        private readonly HotelDBContext _context;

        public AmenitiesDatabaseRepository(HotelDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AmenitiesDTO>> GetAllAmenities()
        {
            var amenities = await _context.Amenities
                .Select(amenity => new AmenitiesDTO
                {
                    Id = amenity.Id,
                    Name = amenity.Name,
                })
                .ToListAsync();

            return amenities;
        }

        public async Task<AmenitiesDTO> GetOneAmenity(int id)
        {
            var amenity = await _context.Amenities
                .Select(amenity => new AmenitiesDTO
                {
                    Id = amenity.Id,
                    Name = amenity.Name,
                })
                .FirstOrDefaultAsync(amenity => amenity.Id == id);

            return amenity;
        }

        public async Task<Amenities> SaveNewAmenity(Amenities amenities)
        {
            _context.Amenities.Add(amenities);
            await _context.SaveChangesAsync();
            return amenities;
        }

        public async Task<Amenities> DeleteAmenity(int id)
        {
            var amenities = await _context.Amenities.FindAsync(id);

            if (amenities == null)
            {
                return null;
            }

            _context.Amenities.Remove(amenities);
            await _context.SaveChangesAsync();

            return amenities;
        }

        public async Task<bool> UpdateAmenity(int id, Amenities amenities)
        {
            _context.Entry(amenities).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AmenityExists(id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }

        public bool AmenityExists(int id)
        {
            return _context.Amenities.Any(e => e.Id == id);
        }
    }
}
