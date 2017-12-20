using System;
using System.Collections.Generic;

namespace theater.Models
{
    public class Cinema
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Theater> Theaters { get; private set; }

        public List<Movie> Movies { get; set; } = new List<Movie>();

        public Dictionary<Movie, List<Showtime>> Showtimes { get; set; } = new Dictionary<Movie, List<Showtime>>();

        public Cinema(string name, string address, int numTheaters)
        {
            Name = name;
            Address = address;
            Theaters = new List<Theater>();

            for (var i = 1; i <= numTheaters; i++)
            {
                Theaters.Add(new Theater(i.ToString(), 55, "283x12", this));
            }

        }

        public void AddShowTime(Theater theater, Movie movie, string time)
        {
            if (!Showtimes.ContainsKey(movie))
            {
                Showtimes.Add(movie, new List<Showtime>());
            }
            var showTime = new Showtime()
            {
                Movie = movie,
                Time = time,
                Theater = theater,
                Tickets = new List<Ticket>()
            };

            for (var i = 0; i < theater.Seats; i++)
            {
                showTime.Tickets.Add(new Ticket()
                {
                    Seat = "A" + (i + 1),
                    Cinema = this,
                    Theater = theater,
                    Movie = movie,
                    Showtime = showTime
                });
            }

            Showtimes[movie].Add(showTime);
        }

        public void DisplayShowtimes(Movie movie)
        {
            var i = 0;
            foreach (var showtime in Showtimes[movie])
            {
                Console.ForegroundColor = i % 2 == 0 ? ConsoleColor.DarkRed : ConsoleColor.White;
                Console.WriteLine($@"
                ---------------------------------------------
                | Movie: {showtime.Movie.Title}
                | Time: {showtime.Time}        
                | Available Tickets: {showtime.Tickets.Count}
                ---------------------------------------------
                ");
                i++;
            }
        }

        public Movie DisplayMovies()
        {
            string movieSelection;
            int movieSelectionInt;
            for (int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"Movie {i + 1}:" + Movies[i].Title);
            }
            Console.WriteLine("Make a selection to show movie times");
            movieSelection = Console.ReadLine();
            int.TryParse(movieSelection, out movieSelectionInt);
            return Movies[movieSelectionInt - 1];
        }
    }
}