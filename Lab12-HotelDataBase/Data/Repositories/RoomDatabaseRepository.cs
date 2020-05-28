using Lab12_HotelDataBase.Models;
using Lab12_HotelDataBase.Models.Api;
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

        public async Task<IEnumerable<RoomDTO>> GetAllRooms()
        {
            var rooms = await _context.Rooms
                .Select(room => new RoomDTO
                {
                    Id = room.Id,
                    Name = room.Name,
                    Layout = room.Layout.ToString(),

                    Amenities = room.Amenities
                        .Select(amenity => new AmenitiesDTO
                        {
                            Id = amenity.Id,
                            Name = amenity.Name,
                        })
                        .ToList()
                })
                .ToListAsync();

            return rooms;
        }

        public async Task<RoomDTO> GetOneRoom(int id)
        {
            var room = await _context.Rooms
                .Select(room => new RoomDTO
                {
                    Id = room.Id,
                    Name = room.Name,
                    Layout = room.Layout.ToString(),

                    Amenities = room.Amenities
                        .Select(amenity => new AmenitiesDTO
                        {
                            Id = amenity.Id,
                            Name = amenity.Name,
                        })
                        .ToList()
                })
                .FirstOrDefaultAsync(room => room.Id == id);

            return room;
        }

        public async Task<Room> SaveNewRoom(Room room)
        {
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();
            return room;
        }

        public async Task<Room> DeleteRoom(int id)
        {
            var room = await _context.Rooms.FindAsync(id);
            if (room == null)
            {
                return null;
            }

            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();

            return room;
        }

        public async Task<bool> UpdateRoom(int id, Room room)
        {
            _context.Entry(room).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomExists(id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }

        public bool RoomExists(int id)
        {
             return _context.Rooms.Any(e => e.Id == id);
        }

    }
}
