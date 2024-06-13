using System.ComponentModel.DataAnnotations;

namespace Gourmet.Models
{
    public class Restaurant
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}