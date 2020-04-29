using WebWorkshopManager.Entities.Models;
using WebWorkshopManager.Shared.Models;

namespace WebWorkshopManager.Mapper.Profiles
{
    public class CarsDtosProfile : AutoMapper.Profile
    {
        public CarsDtosProfile()
        {
            this.CreateMap<CarDto, CarDto>();
            this.CreateMap<Car, CarDto>();
            this.CreateMap<CarDto, Car>()
                .ForMember(c => c.Engine, a => a.Ignore())
                .ForMember(c => c.EngineId, a => a.MapFrom(c => c.Engine.EngineId));
        }
    }
}
