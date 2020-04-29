using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebWorkshopManager.Entities.Models
{
    [Table("customers")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ContactNumber { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
