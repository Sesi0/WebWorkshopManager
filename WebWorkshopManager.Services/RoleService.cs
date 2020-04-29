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
    public class RoleService : BaseService, IRoleService
    {
        public RoleService(WebWorkshopManagerDataContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<ICollection<RoleDto>> GetAllAsync()
        {
            return await this.context.Roles
                .ProjectTo<RoleDto>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<RoleDto> GetAsync(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Role is invalid!");
            }

            return await this.context.Roles
                 .Where(x => x.RoleId == id)
                 .ProjectTo<RoleDto>(this.mapper.ConfigurationProvider)
                 .FirstOrDefaultAsync();
        }

        public async Task<RoleDto> AddOrUpdateAsync(RoleDto item)
        {
            if (item == null)
            {
                throw new ArgumentException("Role is invalid!");
            }

            Role roleEntity = null;
            if (item.RoleId <= 0)
            {
                roleEntity = this.mapper.Map<Role>(item);
                this.context.Roles.Add(roleEntity);
            }
            else
            {
                roleEntity = await this.context.Roles.FindAsync(item.RoleId);

                if (roleEntity == null)
                {
                    throw new ArgumentException("Role was not found!");
                }

                this.mapper.Map(item, roleEntity);
                this.context.Roles.Update(roleEntity);
            }

            await this.context.SaveChangesAsync();

            return await this.GetAsync(roleEntity.RoleId);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Role is invalid!");
            }

            var roleEntity = await this.context.Roles.FindAsync(id);

            if (roleEntity == null)
            {
                throw new ArgumentException("Role was not found!");
            }

            if (await this.context.Users.Where(u => u.RoleId == roleEntity.RoleId)?.FirstOrDefaultAsync() != null)
            {
                return false;
            }

            this.context.Roles.Remove(roleEntity);
            await this.context.SaveChangesAsync();
            return true;
        }
    }
}
