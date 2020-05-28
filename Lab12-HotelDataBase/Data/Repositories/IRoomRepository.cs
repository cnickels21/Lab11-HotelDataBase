using Lab12_HotelDataBase.Models;
using Lab12_HotelDataBase.Models.Api;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lab12_HotelDataBase.Data.Repositories
{
    public interface IRoomRepository
    {
        Task<IEnumerable<RoomDTO>> GetAllRooms();

        Task<Room> GetOneRoom(int id);

        Task<bool> UpdateRoom(int id, Room room);

        Task<Room> SaveNewRoom(Room room);

        Task<Room> DeleteRoom(int id);

        bool RoomExists(int id);
    }
}
