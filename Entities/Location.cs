using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
