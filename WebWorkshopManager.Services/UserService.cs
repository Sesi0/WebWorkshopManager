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
    public class UserService : BaseService, IUserService
    {
        public UserService(WebWorkshopManagerDataContext webWorkshopManagerDataContext, IMapper mapper) : base(webWorkshopManagerDataContext, mapper)
        {
        }

        public async Task<ICollection<UserDto>> GetAllAsync()
        {
            return await this.context.Users
                .ProjectTo<UserDto>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<UserDto> GetAsync(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("User is invalid!");
            }

            return await this.context.Users
                 .Where(x => x.UserId == id)
                 .ProjectTo<UserDto>(this.mapper.ConfigurationProvider)
                 .FirstOrDefaultAsync();
        }

        public async Task<UserDto> AddOrUpdateAsync(UserDto item)
        {
            if (item == null)
            {
                throw new ArgumentException("User is invalid!");
            }

            User userEntity = null;
            if (item.UserId <= 0)
            {
                userEntity = this.mapper.Map<User>(item);
                this.context.Add(userEntity);
            }
            else
            {
                userEntity = await this.context.Users.FindAsync(item.UserId);

                if (userEntity == null)
                {
                    throw new ArgumentException("User was not found!");
                }

                this.mapper.Map(item, userEntity);
                this.context.Update(userEntity);
            }

            await this.context.SaveChangesAsync();
            
            return await this.GetAsync(userEntity.UserId);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("User is invalid!");
            }

            var userEntity = await this.context.Users.FindAsync(id);

            if (userEntity == null)
            {
                throw new ArgumentException("User was not found!");
            }

            this.context.Users.Remove(userEntity);
            await this.context.SaveChangesAsync();
            return true;
        }
    }
}