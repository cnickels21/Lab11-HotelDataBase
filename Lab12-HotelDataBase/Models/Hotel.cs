using System.ComponentModel.DataAnnotations;

namespace Lab12_HotelDataBase.Models
{
    public class Hotel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string StreetAddress { get; set; }

        [Required]
        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }
    }
}
