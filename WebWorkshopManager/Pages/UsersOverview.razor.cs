using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using WebWorkshopManager.Services.Contracts;
using WebWorkshopManager.Shared.Models;
using WebWorkshopManager.Web.Base;
using WebWorkshopManager.Web.Shared;

namespace WebWorkshopManager.Web.Pages
{
    public class UsersOverviewBase : OverviewBase<UserDto>
    {
        [Inject]
        private IUserService UserService { get; set; }

        [Inject]
        private IRoleService RoleService { get; set; }

        public IReadOnlyList<RoleDto> RolesSelection { get; set; }

        protected override async Task OnInitializedAsync()
        {
            this.SelectedRowItemForEdit =  this.editPlaceHolder = NomenclaturesFactory.GetEmptyUserDto();
            this.RolesSelection = await this.RoleService.GetAllAsync() as IReadOnlyList<RoleDto>;
            this.TableItems = await this.UserService.GetAllAsync();
        }

        public override void AddNewRow()
        {
            this.SelectedRowItemForEdit = NomenclaturesFactory.GetEmptyUserDto();
            base.AddNewRow();
        }

        public override async Task ConfirmDeleteRowAsync()
        {
            await this.UserService.DeleteAsync(this.SelectedRowItemForEdit.UserId);
            await base.ConfirmDeleteRowAsync();
        }

        public override async Task CancelRowEditAsync()
        {
            if (this.SelectedRowItemForEdit.UserId <= 0)
            {
                this.TableItems.Remove(this.SelectedRowItemForEdit);
            }
            else
            {
                var oldItem = await this.UserService.GetAsync(this.SelectedRowItemForEdit.UserId);
                this.Mapper.Map(oldItem, this.SelectedRowItemForEdit);
            }

            await base.CancelRowEditAsync();
        }

        public override async Task SaveRowAsync()
        {
            if (this.SelectedRowItemForEdit == null)
            {
                this.Toaster.Add("Не е избран потребител!", MatToastType.Warning);
                return;
            }

            var newItem = await this.UserService.AddOrUpdateAsync(this.SelectedRowItemForEdit);
            this.Mapper.Map(newItem, this.SelectedRowItemForEdit);
            await base.SaveRowAsync();
        }
    }
}
