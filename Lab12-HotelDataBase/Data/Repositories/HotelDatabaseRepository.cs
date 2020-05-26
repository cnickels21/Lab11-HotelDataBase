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

        public async Task<ActionResult<IEnumerable<Hotel>>> GetHotels()
        {
            return await _context.Hotels.ToListAsync();
        }

        public Task<ActionResult<Hotel>> GetHotel(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Hotel>> DeleteHotel(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> HotelExists(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Hotel>> PostHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> PutHotel(int id, Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}
