using WebWorkshopManager.Entities.Models;
using WebWorkshopManager.Shared.Models;

namespace WebWorkshopManager.Mapper.Profiles
{
    public class UsersDtosProfile : AutoMapper.Profile
    {
        public UsersDtosProfile()
        {
            this.CreateMap<UserDto, UserDto>();
            this.CreateMap<User, UserDto>();
            this.CreateMap<UserDto, User>()
                .ForMember(u => u.Role, a => a.Ignore())
                .ForMember(u => u.RoleId, a => a.MapFrom(u => u.Role.RoleId));
        }
    }
}
