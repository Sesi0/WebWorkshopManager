using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebWorkshopManager.Shared.ENUMS;

namespace WebWorkshopManager.Entities.Models
{
    [Table("engines")]
    public class Engine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EngineId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int HorsePower { get; set; }

        [Required]
        public FUEL_TYPE FuelType { get; set; }
    }
}
