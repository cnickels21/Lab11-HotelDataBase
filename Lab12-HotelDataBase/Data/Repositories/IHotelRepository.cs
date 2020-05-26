using Lab12_HotelDataBase.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lab12_HotelDataBase.Data.Repositories
{
    public interface IHotelRepository
    {
        Task<IEnumerable<Hotel>> GetAllHotels();

        Task<Hotel> GetOneHotel(int id);

        Task<bool> UpdateHotel(int id, Hotel hotel);

        Task<Hotel> SaveNewHotel(Hotel hotel);

        Task<Hotel> DeleteHotel(int id);

        bool HotelExists(int id);
    }
}
