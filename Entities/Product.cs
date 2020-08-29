using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities
{
    public class Product
    {
        [Key]
        public int productId { get; set; }

        [Required]
        [StringLength(500)]
        public string productName { get; set; }
    }
}
