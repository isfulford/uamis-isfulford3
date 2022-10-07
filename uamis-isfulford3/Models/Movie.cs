using System.ComponentModel.DataAnnotations;

namespace uamis_isfulford3.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        [Url]
        public string IMDBLink { get; set; }

        public string Genre { get; set; }

        public DateTime ReleaseDate { get; set; }

        public byte[]? Photo { get; set; }
    }
}
