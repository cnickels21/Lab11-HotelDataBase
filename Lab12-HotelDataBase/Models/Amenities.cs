using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace Lab12_HotelDataBase.Models
{
    public class Amenities
    {
        public int Id { get; set; }

        [Required]
        public Name Name { get; set; }
    }

    /// <summary>
    /// Amenity enum constructor
    /// </summary>
    public enum Name
    {
        Coffee,
        Toilet,
        Window,
        Jacuzzi,
        TikiBar,
    }
}
