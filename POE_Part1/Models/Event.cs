namespace POE_Part1.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public string? EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string? Description { get; set; }

        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    }
}
