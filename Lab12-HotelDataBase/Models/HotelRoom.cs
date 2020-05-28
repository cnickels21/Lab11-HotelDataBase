using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab12_HotelDataBase.Models
{
    public class HotelRoom
    {
        [Required]
        public int HotelId { get; set; }

        [Required]
        public int RoomNumber { get; set; }

        [Required]
        public int RoomId { get; set; }

        [Column(TypeName = "money")]
        public decimal Rate { get; set; }

        public bool PetFriendly { get; set; }

        /// <summary>
        /// References to hotels and rooms table below
        /// </summary>
        [Required]
        public Hotel Hotel { get; set; }
        [Required]
        public Room Room { get; set; }
    }
}
