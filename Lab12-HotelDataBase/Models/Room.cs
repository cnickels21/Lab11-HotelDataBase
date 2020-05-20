using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab12_HotelDataBase.Models
{
    public class Room
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        public string Layout { get; set; }

        /// <summary>
        /// Navigation properties to hotel room and room amenities
        /// </summary>
        [Required]
        public HotelRoom HotelRoom { get; set; }
        [Required]
        public RoomAmenities RoomAmenities{ get; set; }
    }
}
