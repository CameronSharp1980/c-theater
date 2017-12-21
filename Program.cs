using System;
using System.Collections.Generic;
using theater.Models;

namespace theater
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            Cinema currentCinema;
            bool chooseNewTheater = false;

            // Franchises
            Franchise megaPlex = new Franchise("Megaplex");

            // Cinemas
            Cinema edwards14 = new Cinema("Edwards 14", "123 fake str", 14);
            Cinema majestic = new Cinema("The Majestic", "456 Not Real Rd.", 12);

            // Movies
            Movie starWarsVIII = new Movie() { Title = "Star Wars" };
            Movie jumanji = new Movie() { Title = "Jumanji 2" };
            Movie monstersInc = new Movie() { Title = "Monster's Inc" };
            Movie indianaJones = new Movie() { Title = "Indiana Jones and the Temple of Doom" };

            // Console.WriteLine("Edwards14.name = " + edwards14.Name);

            // Populate Franchise with Cinemas
            megaPlex.AddCinema(edwards14);
            megaPlex.AddCinema(majestic);

            // edwards14 movies and showtimes
            edwards14.Movies.Add(starWarsVIII);
            edwards14.Movies.Add(jumanji);

            edwards14.AddShowTime(edwards14.Theaters[0], starWarsVIII, "1000");
            edwards14.AddShowTime(edwards14.Theaters[1], starWarsVIII, "1100");
            edwards14.AddShowTime(edwards14.Theaters[2], starWarsVIII, "1200");
            edwards14.AddShowTime(edwards14.Theaters[0], starWarsVIII, "1300");
            edwards14.AddShowTime(edwards14.Theaters[1], starWarsVIII, "1400");
            edwards14.AddShowTime(edwards14.Theaters[2], starWarsVIII, "1500");

            edwards14.AddShowTime(edwards14.Theaters[3], jumanji, "1000");
            edwards14.AddShowTime(edwards14.Theaters[4], jumanji, "1100");
            edwards14.AddShowTime(edwards14.Theaters[5], jumanji, "1200");
            edwards14.AddShowTime(edwards14.Theaters[3], jumanji, "1300");
            edwards14.AddShowTime(edwards14.Theaters[4], jumanji, "1400");
            edwards14.AddShowTime(edwards14.Theaters[5], jumanji, "1500");

            // majestic movies and showtimes
            majestic.Movies.Add(starWarsVIII);
            majestic.Movies.Add(monstersInc);
            majestic.Movies.Add(indianaJones);

            majestic.AddShowTime(majestic.Theaters[0], starWarsVIII, "1000");
            majestic.AddShowTime(majestic.Theaters[1], starWarsVIII, "1100");
            majestic.AddShowTime(majestic.Theaters[2], starWarsVIII, "1200");
            majestic.AddShowTime(majestic.Theaters[0], starWarsVIII, "1300");
            majestic.AddShowTime(majestic.Theaters[1], starWarsVIII, "1400");
            majestic.AddShowTime(majestic.Theaters[2], starWarsVIII, "1500");

            majestic.AddShowTime(majestic.Theaters[3], monstersInc, "1000");
            majestic.AddShowTime(majestic.Theaters[4], monstersInc, "1100");
            majestic.AddShowTime(majestic.Theaters[5], monstersInc, "1200");
            majestic.AddShowTime(majestic.Theaters[3], monstersInc, "1300");
            majestic.AddShowTime(majestic.Theaters[4], monstersInc, "1400");
            majestic.AddShowTime(majestic.Theaters[5], monstersInc, "1500");

            majestic.AddShowTime(majestic.Theaters[6], indianaJones, "1000");
            majestic.AddShowTime(majestic.Theaters[7], indianaJones, "1100");
            majestic.AddShowTime(majestic.Theaters[8], indianaJones, "1200");
            majestic.AddShowTime(majestic.Theaters[6], indianaJones, "1300");
            majestic.AddShowTime(majestic.Theaters[7], indianaJones, "1400");
            majestic.AddShowTime(majestic.Theaters[8], indianaJones, "1500");

            // Assign default theater
            currentCinema = edwards14;

            while (!quit)
            {
                if (!chooseNewTheater)
                {
                    currentCinema = megaPlex.DisplayCinemas();
                    quit = currentCinema.DisplayMovies();
                }
                else
                {
                    quit = currentCinema.DisplayMovies();
                }
            }




            // movieSelection = edwards14.DisplayMovies();
            // edwards14.DisplayShowtimes(movieSelection);

            //expand to multi-theater allowing you to check movies per theater, and then change theaters to see other showtimes and then an option to quit.




















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
