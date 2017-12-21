using System;
using System.Collections.Generic;

namespace theater.Models
{
    public class Franchise
    {
        public string Name { get; set; }

        public List<Cinema> Cinemas { get; set; } = new List<Cinema>();

        public void AddCinema(Cinema cinema)
        {
            Cinemas.Add(cinema);
        }

        public Cinema DisplayCinemas()
        {
            string Selection;
            int SelectionInt;
            Console.WriteLine("Please select which Cinema you wish to attend:");
            for (int i = 0; i < Cinemas.Count; i++)
            {
                Console.WriteLine($"{i + 1} {Cinemas[i].Name}");
            }
            Selection = Console.ReadLine();
            int.TryParse(Selection, out SelectionInt);
            return Cinemas[SelectionInt - 1];
        }

        public Franchise(string name)
        {
            Name = name;
        }
    }
}