using System.Collections.Generic;
using System.Threading.Tasks;
using WebWorkshopManager.Shared.Models;

namespace WebWorkshopManager.Services.Contracts
{
    public interface ICarService : IBaseService<CarDto>
    {
        Task<ICollection<EngineDto>> GetAllEnginesAsync();
    }
}
