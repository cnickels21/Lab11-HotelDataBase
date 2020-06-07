using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Lab12_HotelDataBase.Web.Models
{
    public class Room
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("layout")]
        public string Layout { get; set; }
        [JsonPropertyName("amenities")]
        public List<AmenitiesSummary> Amenities { get; set; }
    }
}
