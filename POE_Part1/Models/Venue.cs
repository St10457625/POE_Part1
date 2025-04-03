using Microsoft.Extensions.Logging;

namespace POE_Part1.Models
{
    public class Venue
    {
        public int VenueID { get; set; }
        public string? VenueName { get; set; }

        public string? Location { get; set; }

        public int? Capacity { get; set; }
        public string? ImageURL { get; set; }

        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
