using Lab12_HotelDataBase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab12_HotelDataBase.Data.Repositories
{
    public class RoomDatabaseRepository : IRoomRepository
    {
        private readonly HotelDBContext _context;

        public RoomDatabaseRepository(HotelDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Room>> GetAllRooms()
        {
            return await _context.Rooms.ToListAsync();
        }

        public Task<Room> GetOneRoom(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Room> SaveNewRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public Task<Room> DeleteRoom(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateRoom(int id, Room room)
        {
            throw new NotImplementedException();
        }

        public bool RoomExists(int id)
        {
            throw new NotImplementedException();
        }

    }
}
