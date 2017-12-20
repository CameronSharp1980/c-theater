using System.Collections.Generic;

namespace theater.Models
{
    public class Showtime
    {
        public string Time { get; set; }
        public List<Ticket> Tickets { get; set; }
        public Theater Theater { get; set; }
        public Movie Movie { get; set; }

    }
}