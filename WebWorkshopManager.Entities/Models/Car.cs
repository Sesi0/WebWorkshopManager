using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebWorkshopManager.Entities.Models
{
    [Table("cars")]
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarId { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }

        public virtual Engine Engine { get; set; }

        [ForeignKey(nameof(Engine))]
        public int? EngineId { get; set; }

        public string EngineNumber { get; set; }

        public string Vin { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string LicensePlate { get; set; }

        public decimal Mileage { get; set; }
    }
}
