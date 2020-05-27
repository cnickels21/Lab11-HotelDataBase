﻿using Lab12_HotelDataBase.Data;
using Lab12_HotelDataBase.Data.Repositories;
using Lab12_HotelDataBase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab12_HotelDataBase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmenitiesController : ControllerBase
    {
        IAmenitiesRepository amenitiesRepository;

        public AmenitiesController(IAmenitiesRepository amenitiesRepository)
        {
            this.amenitiesRepository = amenitiesRepository;
        }

        // GET: api/Amenities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Amenities>>> GetAmenities()
        {
            return Ok(await amenitiesRepository.GetAllAmenities());
        }

        // GET: api/Amenities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Amenities>> GetAmenities(int id)
        {
            Amenities amenities = await amenitiesRepository.GetOneAmenity(id);

            if (amenities == null)
            {
                return NotFound();
            }

            return amenities;
        }

        // PUT: api/Amenities/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAmenities(int id, Amenities amenities)
        {
            amenities.Id = id;

            if (id != amenities.Id)
            {
                return BadRequest();
            }

            bool amenityUpdated = await amenitiesRepository.UpdateAmenity(id, amenities);

                if (!amenityUpdated)
                {
                    return NotFound();
                }
            return NoContent();
        }

        // POST: api/Amenities
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Amenities>> PostAmenities(Amenities amenities)
        {
            await amenitiesRepository.SaveNewAmenity(amenities);

            return CreatedAtAction("GetAmenities", new { id = amenities.Id }, amenities);
        }

        // DELETE: api/Amenities/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Amenities>> DeleteAmenities(int id)
        {
            var amenities = await amenitiesRepository.DeleteAmenity(id);
            if (amenities == null)
            {
                return NotFound();
            }

            return amenities;
        }

    }
}
