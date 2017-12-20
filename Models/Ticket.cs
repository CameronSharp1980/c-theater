namespace theater.Models
{
    public class Ticket
    {
        public string Seat { get; set; }
        public bool Available { get; set; } = true;

        // Relationships
        public Movie Movie { get; set; }
        public Theater Theater { get; set; }
        public Cinema Cinema { get; set; }
        public Showtime Showtime { get; set; }

    }
}