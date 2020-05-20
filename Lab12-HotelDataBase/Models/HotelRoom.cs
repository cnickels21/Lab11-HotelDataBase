using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

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

        [Column(TypeName = "decimal(18,4)")]
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
