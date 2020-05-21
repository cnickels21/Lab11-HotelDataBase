using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab12_HotelDataBase.Models
{
    public class Amenities
    {
        public int Id { get; set; }

        [Required]
        public Name Name { get; set; }

        public enum Name
        {
            Coffee,
            Toilet,
            Window,
            Jacuzzi,
            TikiBar,
        }
    }
}
