using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities
{
    public class Location
    {

        [Key]
        public int locationId { get; set; }

        [Required]
        [StringLength(300)]
        public string locationName { get; set; }
    }
}
