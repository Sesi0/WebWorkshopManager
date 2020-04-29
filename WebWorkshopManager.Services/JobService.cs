using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using WebWorkshopManager.Entities.Base;
using WebWorkshopManager.Entities.Models;
using WebWorkshopManager.Services.Base;
using WebWorkshopManager.Services.Contracts;
using WebWorkshopManager.Shared.Models;

namespace WebWorkshopManager.Services
{
    public class JobService : BaseService, IJobService
    {
        public JobService(WebWorkshopManagerDataContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<ICollection<JobDto>> GetAllAsync()
        {
            return await this.context.Jobs
                .ProjectTo<JobDto>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<JobDto> GetAsync(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Job is invalid!");
            }

            return await this.context.Jobs
                 .Where(x => x.JobId == id)
                 .ProjectTo<JobDto>(this.mapper.ConfigurationProvider)
                 .FirstOrDefaultAsync();
        }

        public async Task<JobDto> AddOrUpdateAsync(JobDto item)
        {
            if (item == null)
            {
                throw new ArgumentException("Job is invalid!");
            }

            Job jobEntity = null;
            if (item.JobId <= 0)
            {
                jobEntity = this.mapper.Map<Job>(item);
                jobEntity.JobNumber = await this.GetNextJobNumberAsync();
                this.context.Add(jobEntity);
            }
            else
            {
                jobEntity = await this.context.Jobs.FindAsync(item.JobId);

                if (jobEntity == null)
                {
                    throw new ArgumentException("Job was not found!");
                }

                this.mapper.Map(item, jobEntity);
                this.context.Update(jobEntity);
            }

            await this.context.SaveChangesAsync();

            return await this.GetAsync(jobEntity.JobId);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Job is invalid!");
            }

            var jobEntity = await this.context.Jobs.FindAsync(id);

            if (jobEntity == null)
            {
                throw new ArgumentException("Job was not found!");
            }

            this.context.Jobs.Remove(jobEntity);
            await this.context.SaveChangesAsync();
            return true;
        }

        public async Task<ICollection<JobItemDto>> GetAllItemsAsync(int jobId)
        {
            if (jobId <= 0)
            {
                throw new ArgumentException("Job is invalid!");
            }

            return await this.context.JobItems
                .Where(x => x.JobId == jobId)
                .ProjectTo<JobItemDto>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<JobItemDto> GetItemAsync(int itemId)
        {
            if (itemId <= 0)
            {
                throw new ArgumentException("Job item is invalid!");
            }

            return await this.context.JobItems
                .Where(x => x.JobItemId == itemId)
                .ProjectTo<JobItemDto>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }

        public async Task<JobItemDto> AddOrUpdateItemAsync(JobItemDto item)
        {
            if (item == null)
            {
                throw new ArgumentException("Job item is invalid!");
            }

            JobItem jobItemEntity = null;
            if (item.JobItemId <= 0)
            {
                jobItemEntity = this.mapper.Map<JobItem>(item);
                this.context.Add(jobItemEntity);
            }
            else
            {
                jobItemEntity = await this.context.JobItems.FindAsync(item.JobItemId);

                if (jobItemEntity == null)
                {
                    throw new ArgumentException("Job item was not found!");
                }

                this.mapper.Map(item, jobItemEntity);
                this.context.Update(jobItemEntity);
            }

            await this.context.SaveChangesAsync();

            return await this.GetItemAsync(jobItemEntity.JobItemId);
        }

        public async Task<bool> DeleteItemAsync(int itemId)
        {
            if (itemId <= 0)
            {
                throw new ArgumentException("Job item is invalid!");
            }

            var jobItemEntity = await this.context.JobItems.FindAsync(itemId);

            if (jobItemEntity == null)
            {
                throw new ArgumentException("Job item was not found!");
            }

            this.context.JobItems.Remove(jobItemEntity);
            await this.context.SaveChangesAsync();
            return true;
        }

        private async Task<int> GetNextJobNumberAsync()
        {
            return (await this.context.Jobs.Select(j => j.JobNumber).ToListAsync())?.LastOrDefault() + 1 ?? 1;
        }
    }
}
