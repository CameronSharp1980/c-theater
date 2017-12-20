namespace theater.Models
{
    public class Theater
    {
        public string Name { get; set; }
        public int Seats { get; set; }
        public string ScreenSize { get; set; }
        public Cinema Cinema { get; set; }

        public Theater(string name, int seats, string screenSize, Cinema cinema)
        {
            Name = name;
            Seats = seats;
            ScreenSize = screenSize;
            Cinema = cinema;
        }
    }
}