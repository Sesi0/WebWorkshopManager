using System.Collections.Generic;
using WebWorkshopManager.Shared.Models;

namespace WebWorkshopManager.ClientSide.Resources
{
    public class AppComponents
    {
        public AppComponents()
        {
            this.Roles = new List<RoleDto>();
        }

        public ICollection<RoleDto> Roles { get; set; }
    }
}
