using System;
using theater.Models;

namespace theater
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movieSelection;
            Cinema edwards14 = new Cinema("Edwards 14", "123 fake str", 14);

            Movie starWarsVIII = new Movie() { Title = "Star Wars" };
            Movie jumanji = new Movie() { Title = "Jumanji 2" };


            // Console.WriteLine("Edwards14.name = " + edwards14.Name);

            //expand to multi-theater allowing you to check movies per theater, and then change theaters to see other showtimes and then an option to quit.

            edwards14.Movies.Add(starWarsVIII);
            edwards14.Movies.Add(jumanji);

            edwards14.AddShowTime(edwards14.Theaters[0], starWarsVIII, "1000");
            edwards14.AddShowTime(edwards14.Theaters[1], starWarsVIII, "1100");
            edwards14.AddShowTime(edwards14.Theaters[3], starWarsVIII, "1200");
            edwards14.AddShowTime(edwards14.Theaters[0], starWarsVIII, "1300");
            edwards14.AddShowTime(edwards14.Theaters[1], starWarsVIII, "1400");
            edwards14.AddShowTime(edwards14.Theaters[3], starWarsVIII, "1500");

            edwards14.AddShowTime(edwards14.Theaters[0], jumanji, "1000");
            edwards14.AddShowTime(edwards14.Theaters[1], jumanji, "1100");
            edwards14.AddShowTime(edwards14.Theaters[3], jumanji, "1200");
            edwards14.AddShowTime(edwards14.Theaters[0], jumanji, "1300");
            edwards14.AddShowTime(edwards14.Theaters[1], jumanji, "1400");
            edwards14.AddShowTime(edwards14.Theaters[3], jumanji, "1500");


            movieSelection = edwards14.DisplayMovies();
            edwards14.DisplayShowtimes(movieSelection);

            // edwards14.Name = "paul";

            // Console.WriteLine("is it paul? Edwards14.name = " + edwards14.Name);
            // edwards14.Name = "Majestic";

            // Console.WriteLine("is it Majestic? Edwards14.name = " + edwards14.Name);

            /**
            Models
                cinema
                    - constructor
                    - Get Movies
                        - Movie see showtimes
                            - GetShowtimes(movie)??? each theater show times flag if availble
                                - purchase ticket


                theater
                movie
                ticket - showtime
                concession
            */
        }
    }
}
