using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebWorkshopManager.Entities.Models
{
    [Table("job_items")]
    public class JobItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobItemId { get; set; }

        public virtual Product Product { get; set; }

        [ForeignKey(nameof(Product))]
        public int? ProductId { get; set; }

        public string Description { get; set; }

        [Required]
        public decimal Quantity { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }

        public virtual Job Job { get; set; }

        [ForeignKey(nameof(Job))]
        public int? JobId { get; set; }
    }
}
