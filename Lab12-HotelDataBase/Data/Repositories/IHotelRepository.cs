using Lab12_HotelDataBase.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lab12_HotelDataBase.Data.Repositories
{
    public interface IHotelRepository
    {
        Task<ActionResult<IEnumerable<Hotel>>> GetHotels();

        Task<ActionResult<Hotel>> GetHotel(int id);

        Task<IActionResult> UpdateHotel(int id, Hotel hotel);

        Task<ActionResult<Hotel>> PostHotel(Hotel hotel);

        Task<ActionResult<Hotel>> DeleteHotel(int id);

        Task<bool> HotelExists(int id);
    }
}
