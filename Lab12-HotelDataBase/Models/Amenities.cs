using System.ComponentModel.DataAnnotations;


namespace Lab12_HotelDataBase.Models
{
    public class Amenities
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
