using WebWorkshopManager.Entities.Models;
using WebWorkshopManager.Shared.Models;

namespace WebWorkshopManager.Mapper.Profiles
{
    public class EnginesDtosProfile : AutoMapper.Profile
    {
        public EnginesDtosProfile()
        {
            this.CreateMap<EngineDto, EngineDto>();
            this.CreateMap<Engine, EngineDto>();
            this.CreateMap<EngineDto, Engine>();
        }
    }
}
