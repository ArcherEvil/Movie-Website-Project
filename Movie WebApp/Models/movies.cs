using System.ComponentModel.DataAnnotations;

namespace Movie_WebApp.Models
{
    public class Movies
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        [Required]
        public bool IsAvailable { get; set; }

    }
}
