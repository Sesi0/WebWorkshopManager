using System.Collections.Generic;
using System.Threading.Tasks;
using WebWorkshopManager.Shared.Models;

namespace WebWorkshopManager.Services.Contracts
{
    public interface IJobService : IBaseService<JobDto>
    {
        Task<ICollection<JobItemDto>> GetAllItemsAsync(int jobId);

        Task<JobItemDto> GetItemAsync(int itemId);

        Task<JobItemDto> AddOrUpdateItemAsync(JobItemDto item);

        Task<bool> DeleteItemAsync(int jobItemId);
    }
}
