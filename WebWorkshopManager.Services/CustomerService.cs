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
    public class CustomerService : BaseService, ICustomerService
    {
        public CustomerService(WebWorkshopManagerDataContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<ICollection<CustomerDto>> GetAllAsync()
        {
            return await this.context.Customers
                .ProjectTo<CustomerDto>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<CustomerDto> GetAsync(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Customer is invalid!");
            }

            return await this.context.Customers
                 .Where(x => x.CustomerId == id)
                 .ProjectTo<CustomerDto>(this.mapper.ConfigurationProvider)
                 .FirstOrDefaultAsync();
        }

        public async Task<CustomerDto> AddOrUpdateAsync(CustomerDto item)
        {
            if (item == null)
            {
                throw new ArgumentException("Customer is invalid!");
            }

            Customer customerEntity = null;
            if (item.CustomerId <= 0)
            {
                customerEntity = this.mapper.Map<Customer>(item);
                this.context.Add(customerEntity);
            }
            else
            {
                customerEntity = await this.context.Customers.FindAsync(item.CustomerId);

                if (customerEntity == null)
                {
                    throw new ArgumentException("Customer was not found!");
                }

                this.mapper.Map(item, customerEntity);
            }

            await this.context.SaveChangesAsync();

            return await this.GetAsync(customerEntity.CustomerId);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Customer is invalid!");
            }

            var customerEntity = await this.context.Customers.FindAsync(id);

            if (customerEntity == null)
            {
                throw new ArgumentException("Customer was not found!");
            }

            this.context.Remove(customerEntity);
            await this.context.SaveChangesAsync();
            return true;
        }
    }
}
