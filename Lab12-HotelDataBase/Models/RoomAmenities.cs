using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab12_HotelDataBase.Models
{
    public class RoomAmenities
    {
        [Required]
        public int AmenitiesId { get; set; }

        [Required]
        public int RoomId { get; set; }

        /// <summary>
        /// References to hotels and rooms table below
        /// </summary>
        [Required]
        public Hotel Amenities { get; set; }
        [Required]
        public Room Room { get; set; }
    }
}
