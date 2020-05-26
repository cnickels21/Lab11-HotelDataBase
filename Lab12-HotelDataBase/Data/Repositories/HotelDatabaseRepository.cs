using Lab12_HotelDataBase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab12_HotelDataBase.Data.Repositories
{
    public class HotelDatabaseRepository : IHotelRepository
    {
        private readonly HotelDBContext _context;

        public HotelDatabaseRepository(HotelDBContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<IEnumerable<Hotel>>> GetAllHotels()
        {
            return await _context.Hotels.ToListAsync();
        }

        public async Task<ActionResult<Hotel>> GetOneHotel(int id)
        {
            return await _context.Hotels.FindAsync(id);
        }

        public async Task<ActionResult<Hotel>> DeleteHotel(int id)
        {
            var hotel = await _context.Hotels.FindAsync(id);
            if (hotel == null)
            {
                return null;
            }

            _context.Hotels.Remove(hotel);
            await _context.SaveChangesAsync();

            return hotel; 
        }

        public async Task<ActionResult<Hotel>> SaveNewHotel(Hotel hotel)
        {
            _context.Hotels.Add(hotel);
            await _context.SaveChangesAsync();
            return hotel;
        }

        public async Task<bool> UpdateHotel(int id, Hotel hotel)
        {
            _context.Entry(hotel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelExists(id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }

        public bool HotelExists(int id)
        {
            return _context.Hotels.Any(e => e.Id == id);
        }
    }
}
