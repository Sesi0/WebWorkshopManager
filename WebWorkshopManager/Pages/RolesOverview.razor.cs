using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BobbysUtils;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using WebWorkshopManager.Services.Contracts;
using WebWorkshopManager.Shared.ENUMS;
using WebWorkshopManager.Shared.Models;
using WebWorkshopManager.Web.Base;
using WebWorkshopManager.Web.Models;
using WebWorkshopManager.Web.Shared;

namespace WebWorkshopManager.Web.Pages
{
    public class RolesOverviewBase : OverviewBase<RoleDto>
    {
        [Inject]
        private IRoleService RoleService { get; set; }

        public List<PermissionCheckBoxItem> PermissionCheckBoxItems { get; set; }

        private void InitializePermissionCheckBoxList()
        {
            var allPermissions = EnumHelper.GetEnumValues<PERMISSION>()
                .Where(p => p != PERMISSION.NONE)
                .Select(p => new PermissionCheckBoxItem
                { IsChecked = false, Permission = p, Label = EnumHelper.GetEnumFieldDisplayName(p) }).ToList();

            this.PermissionCheckBoxItems = allPermissions;
        }

        private void SyncPermissionsWithSelectedRowItemForEdit()
        {
            this.PermissionCheckBoxItems.ForEach(x => x.IsChecked = false);

            foreach (var permission in EnumHelper.GetEnumValuesFromFlags(this.SelectedRowItemForEdit.Permissions))
            {
                var item = this.PermissionCheckBoxItems.FirstOrDefault(x => x.Permission == permission);

                if (item == null)
                {
                    continue;
                }

                item.IsChecked = true;
            }
        }

        private void SyncSelectedRowItemForEditWithPermissions()
        {
            this.SelectedRowItemForEdit.Permissions = PERMISSION.NONE;

            foreach (var item in this.PermissionCheckBoxItems.Where(x => x.IsChecked))
            {
                this.SelectedRowItemForEdit.Permissions |= item.Permission;
            }
        }

        protected override async Task OnInitializedAsync()
        {
            this.editPlaceHolder = NomenclaturesFactory.GetEmptyRoleDto();
            this.SelectedRowItemForEdit = this.editPlaceHolder;
            this.InitializePermissionCheckBoxList();
            this.TableItems = await this.RoleService.GetAllAsync();
        }

        public override void OpenEditDialog(RoleDto rowItem)
        {
            base.OpenEditDialog(rowItem);
            this.SyncPermissionsWithSelectedRowItemForEdit();
        }

        public override void AddNewRow()
        {
            this.SelectedRowItemForEdit = NomenclaturesFactory.GetEmptyRoleDto();
            base.AddNewRow();
        }

        public override async Task ConfirmDeleteRowAsync()
        {
            await this.RoleService.DeleteAsync(this.SelectedRowItemForEdit.RoleId);
            await base.ConfirmDeleteRowAsync();
        }

        public override async Task CancelRowEditAsync()
        {
            if (this.SelectedRowItemForEdit.RoleId <= 0)
            {
                this.TableItems.Remove(this.SelectedRowItemForEdit);
            }
            else
            {
                var oldItem = await this.RoleService.GetAsync(this.SelectedRowItemForEdit.RoleId);
                this.SelectedRowItemForEdit.Name = oldItem.Name;
                this.SelectedRowItemForEdit.Permissions = oldItem.Permissions;
            }

            await base.CancelRowEditAsync();
        }

        public override async Task SaveRowAsync()
        {
            if (this.SelectedRowItemForEdit == null)
            {
                this.Toaster.Add("Не е избрана роля!", MatToastType.Warning);
                return;
            }

            this.SyncSelectedRowItemForEditWithPermissions();
            var newItem = await this.RoleService.AddOrUpdateAsync(this.SelectedRowItemForEdit);

            this.SelectedRowItemForEdit.RoleId = newItem.RoleId;
            this.SelectedRowItemForEdit.Permissions = newItem.Permissions;

            await base.SaveRowAsync();
        }
    }
}
