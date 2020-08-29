using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities
{
    public class Available
    {
        [Key]
        public int availableId { get; set; }

        [Required]
        [StringLength(5)]
        public string availableName { get; set; }
    }
}
