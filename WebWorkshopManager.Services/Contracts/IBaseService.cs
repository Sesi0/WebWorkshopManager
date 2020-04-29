using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebWorkshopManager.Shared.Models;

namespace WebWorkshopManager.Services.Contracts
{
    public interface IBaseService<T> where T : BaseDto
    {
        Task<ICollection<T>> GetAllAsync();

        Task<T> GetAsync(int id);

        Task<T> AddOrUpdateAsync(T item);

        Task<bool> DeleteAsync(int id);
    }
}
