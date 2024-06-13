using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Gourmet.Models; 
namespace Gourmet.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string LocationName { get; set; }

        [ForeignKey("Restaurant")]
        public long RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}