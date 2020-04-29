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
    public class CarService : BaseService, ICarService
    {
        public CarService(WebWorkshopManagerDataContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<ICollection<CarDto>> GetAllAsync()
        {
            return await this.context.Cars
                .ProjectTo<CarDto>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<ICollection<EngineDto>> GetAllEnginesAsync()
        {
            return await this.context.Engines
                .ProjectTo<EngineDto>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<CarDto> GetAsync(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Car is invalid!");
            }

            return await this.context.Cars
                 .Where(x => x.CarId == id)
                 .ProjectTo<CarDto>(this.mapper.ConfigurationProvider)
                 .FirstOrDefaultAsync();
        }

        public async Task<CarDto> AddOrUpdateAsync(CarDto item)
        {
            if (item == null)
            {
                throw new ArgumentException("Car is invalid!");
            }

            Car carEntity = null;
            if (item.CarId <= 0)
            {
                carEntity = this.mapper.Map<Car>(item);
                this.context.Add(carEntity);
            }
            else
            {
                carEntity = await this.context.Cars.FindAsync(item.CarId);

                if (carEntity == null)
                {
                    throw new ArgumentException("Car was not found!");
                }

                this.mapper.Map(item, carEntity);
                this.context.Update(carEntity);
            }

            await this.context.SaveChangesAsync();

            return await this.GetAsync(carEntity.CarId);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Car is invalid!");
            }

            var carEntity = await this.context.Cars.FindAsync(id);

            if (carEntity == null)
            {
                throw new ArgumentException("Car was not found!");
            }

            this.context.Cars.Remove(carEntity);
            await this.context.SaveChangesAsync();
            return true;
        }
    }
}
