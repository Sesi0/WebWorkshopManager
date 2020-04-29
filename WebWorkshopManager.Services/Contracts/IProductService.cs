using System.Collections.Generic;
using System.Threading.Tasks;
using WebWorkshopManager.Shared.ENUMS;
using WebWorkshopManager.Shared.Models;

namespace WebWorkshopManager.Services.Contracts
{
    public interface IProductService : IBaseService<ProductDto>
    {
        Task<ICollection<ProductDto>> GetAllAsync(PRODUCT_TYPE productType);
    }
}
