using Lab12_HotelDataBase.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lab12_HotelDataBase.Data.Repositories
{
    public interface IRoomRepository
    {
        Task<IEnumerable<RoomGTO>> GetAllRooms();

        Task<RoomGTO> GetOneRoom(int id);

        Task<bool> UpdateRoom(int id, RoomGTO room);

        Task<RoomGTO> SaveNewRoom(RoomGTO room);

        Task<RoomGTO> DeleteRoom(int id);

        bool RoomExists(int id);
    }
}
