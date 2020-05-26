using Lab12_HotelDataBase.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lab12_HotelDataBase.Data.Repositories
{
    public interface IHotelRepository
    {
        Task<ActionResult<IEnumerable<Hotel>>> GetAllHotels();

        Task<ActionResult<Hotel>> GetOneHotel(int id);

        Task<bool> UpdateHotel(int id, Hotel hotel);

        Task<ActionResult<Hotel>> SaveNewHotel(Hotel hotel);

        Task<ActionResult<Hotel>> DeleteHotel(int id);

        bool HotelExists(int id);
    }
}
