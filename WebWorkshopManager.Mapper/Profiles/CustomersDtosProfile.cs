using WebWorkshopManager.Entities.Models;
using WebWorkshopManager.Shared.Models;

namespace WebWorkshopManager.Mapper.Profiles
{
    public class CustomersDtosProfile : AutoMapper.Profile
    {
        public CustomersDtosProfile()
        {
            this.CreateMap<CustomerDto, CustomerDto>();
            this.CreateMap<Customer, CustomerDto>();
            this.CreateMap<CustomerDto, Customer>();
        }
    }
}
