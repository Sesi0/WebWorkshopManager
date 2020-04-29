using WebWorkshopManager.Entities.Models;
using WebWorkshopManager.Shared.Models;

namespace WebWorkshopManager.Mapper.Profiles
{
    public class JobsDtosProfile : AutoMapper.Profile
    {
        public JobsDtosProfile()
        {
            this.CreateMap<JobDto, JobDto>();
            this.CreateMap<Job, JobDto>();
            this.CreateMap<JobDto, Job>()
                .ForMember(j => j.Worker, a => a.Ignore())
                .ForMember(j => j.WorkerId, a => a.MapFrom(j => j.Worker.UserId))
                .ForMember(j => j.Customer, a => a.Ignore())
                .ForMember(j => j.CustomerId, a => a.MapFrom(j => j.Customer.CustomerId))
                .ForMember(j => j.Car, a => a.Ignore())
                .ForMember(j => j.CarId, a => a.MapFrom(j => j.Car.CarId));
            ;

            this.CreateMap<JobItemDto, JobItemDto>();
            this.CreateMap<JobItem, JobItemDto>();
            this.CreateMap<JobItemDto, JobItem>()
                .ForMember(ji => ji.Product, a => a.Ignore())
                .ForMember(ji => ji.ProductId, a => a.MapFrom(ji => ji.Product.ProductId));
        }
    }
}
