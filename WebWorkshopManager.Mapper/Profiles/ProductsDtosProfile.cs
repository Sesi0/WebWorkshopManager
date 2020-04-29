using WebWorkshopManager.Entities.Models;
using WebWorkshopManager.Shared.Models;

namespace WebWorkshopManager.Mapper.Profiles
{
    public class ProductsDtosProfile : AutoMapper.Profile
    {
        public ProductsDtosProfile()
        {
            this.CreateMap<ProductDto, ProductDto>();
            this.CreateMap<Product, ProductDto>();
            this.CreateMap<ProductDto, Product>();
        }
    }
}
