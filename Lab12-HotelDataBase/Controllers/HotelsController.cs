using Lab12_HotelDataBase.Data.Repositories;
using Lab12_HotelDataBase.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lab12_HotelDataBase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        IHotelRepository hotelRepository;

        public HotelsController(IHotelRepository hotelRepository)
        {
            this.hotelRepository = hotelRepository;
        }

        // GET: api/Hotels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hotel>>> GetHotels()
        {
            return Ok(await hotelRepository.GetAllHotels());
        }

        // GET: api/Hotels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hotel>> GetHotel(int id)
        {
            Hotel hotel = await hotelRepository.GetOneHotel(id);

            if (hotel == null)
            {
                return NotFound();
            }

            return hotel;
        }

        // PUT: api/Hotels/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHotel(int id, Hotel hotel)
        {
            hotel.Id = id;

            if (id != hotel.Id)
            {
                return BadRequest();
            }

            bool hotelUpdated = await hotelRepository.UpdateHotel(id, hotel);

            if (!hotelUpdated)
            {
                return NotFound();
            }

            return NoContent();
        }

        // POST: api/Hotels
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Hotel>> PostHotel(Hotel hotel)
        {
            await hotelRepository.SaveNewHotel(hotel);

            return CreatedAtAction("GetHotel", new { id = hotel.Id }, hotel);
        }

        // DELETE: api/Hotels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Hotel>> DeleteHotel(int id)
        {
            var hotel = await hotelRepository.DeleteHotel(id);

            if (hotel == null)
            {
                return NotFound();
            }

            return hotel;
        }

    }
}
