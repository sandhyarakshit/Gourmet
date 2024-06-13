using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Gourmet.Models; 

namespace Gourmet.Models
{
    public class Item
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        public bool Available { get; set; }

        [ForeignKey("Location")]
        public long LocationId { get; set; }
        public Location Location { get; set; }
    }
}