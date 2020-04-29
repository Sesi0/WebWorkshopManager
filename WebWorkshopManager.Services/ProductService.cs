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
using WebWorkshopManager.Shared.ENUMS;
using WebWorkshopManager.Shared.Models;

namespace WebWorkshopManager.Services
{
    public class ProductService : BaseService, IProductService
    {
        public ProductService(WebWorkshopManagerDataContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<ICollection<ProductDto>> GetAllAsync()
        {
            return await this.context.Products
                .ProjectTo<ProductDto>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<ICollection<ProductDto>> GetAllAsync(PRODUCT_TYPE productType)
        {
            return await this.context.Products
                .Where(p => p.ProductType == productType)
                .ProjectTo<ProductDto>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<ProductDto> GetAsync(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Product is invalid!");
            }

            return await this.context.Products
                 .Where(x => x.ProductId == id)
                 .ProjectTo<ProductDto>(this.mapper.ConfigurationProvider)
                 .FirstOrDefaultAsync();
        }

        public async Task<ProductDto> AddOrUpdateAsync(ProductDto item)
        {
            if (item == null)
            {
                throw new ArgumentException("Product is invalid!");
            }

            Product productEntity = null;
            if (item.ProductId <= 0)
            {
                productEntity = this.mapper.Map<Product>(item);
                this.context.Add(productEntity);
            }
            else
            {
                productEntity = await this.context.Products.FindAsync(item.ProductId);

                if (productEntity == null)
                {
                    throw new ArgumentException("Product was not found!");
                }

                this.mapper.Map(item, productEntity);
                this.context.Update(productEntity);
            }

            await this.context.SaveChangesAsync();

            return await this.GetAsync(productEntity.ProductId);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Product is invalid!");
            }

            var productEntity = await this.context.Products.FindAsync(id);

            if (productEntity == null)
            {
                throw new ArgumentException("Product was not found!");
            }

            this.context.Remove(productEntity);
            await this.context.SaveChangesAsync();
            return true;
        }
    }
}
