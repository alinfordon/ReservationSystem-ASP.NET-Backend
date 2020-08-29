using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities
{
    public class Order
    {
        [Key]
        public int orderId { get; set; }

        [Required]
        [StringLength(300)]
        public string name { get; set; }

        [Required]
        [StringLength(300)]
        public string orderLocation { get; set; }

        [Required]
        [StringLength(500)]
        public string orderProduct { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string dateOfReservation { get; set; }

        [Required]
        [StringLength(5)]
        public string available { get; set; }
    }
}

