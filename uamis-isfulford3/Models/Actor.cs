using System.ComponentModel.DataAnnotations;

namespace uamis_isfulford3.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public int Age { get; set; }

        [Url]
        public string IMDBLink { get; set; }

        public byte[]? Photo { get; set; }

    }
}
