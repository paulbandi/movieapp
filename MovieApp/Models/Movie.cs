using System;
namespace MovieApp.Models
{
    public class Movie
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string genre { get; set; }
        public string rating { get; set; }
        public string releaseDate { get; set; }
    }
}
