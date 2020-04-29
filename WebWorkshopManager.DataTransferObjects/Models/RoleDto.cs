using WebWorkshopManager.Shared.ENUMS;

namespace WebWorkshopManager.Shared.Models
{
    public class RoleDto : BaseDto
    {

        public int RoleId { get; set; }

        public string Name { get; set; }

        public PERMISSION Permissions { get; set; }
    }
}
