using Microsoft.EntityFrameworkCore;

namespace MoviesAPIChart.Model
{
    [Keyless]
    public class MoviesData
    {
        public string Title { get; set; }

        public int Year { get; set; }

        public string Rated { get; set; }

        public DateOnly Released { get; set; }

        public int Runtime { get; set; }

        public string Genre { get; set; }

        public string Language { get; set; }

        public string Country { get; set; }

        public decimal imdbRating { get; set; }

        public int imdbVotes { get; set; }

        public string Type { get; set; }
    }
}
