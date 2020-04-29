using WebWorkshopManager.Entities.Models;
using WebWorkshopManager.Shared.Models;

namespace WebWorkshopManager.Mapper.Profiles
{
    public class RolesDtosProfile : AutoMapper.Profile
    {
        public RolesDtosProfile()
        {
            this.CreateMap<RoleDto, RoleDto>();
            this.CreateMap<Role, RoleDto>();
            this.CreateMap<RoleDto, Role>();
        }
    }
}
