using System.ComponentModel.DataAnnotations;

namespace Lab12_HotelDataBase.Models
{
    public class RoomAmenities
    {
        [Required]
        public int RoomId { get; set; }

        [Required]
        public int AmenitiesId { get; set; }

        /// <summary>
        /// References to hotels and rooms table below
        /// </summary>
        [Required]
        public Room Room { get; set; }
        [Required]
        public Hotel Amenities { get; set; }

    }
}
