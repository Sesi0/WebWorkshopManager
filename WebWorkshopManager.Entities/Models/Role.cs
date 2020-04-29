using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebWorkshopManager.Shared.ENUMS;

namespace WebWorkshopManager.Entities.Models
{
    [Table("roles")]
    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoleId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public PERMISSION Permissions { get; set; }
    }
}
