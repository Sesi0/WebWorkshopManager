using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using WebWorkshopManager.Shared.Models;

namespace WebWorkshopManager.Web.Shared
{
    public abstract class OverviewBase<T> : ComponentBase where T : BaseDto
    {
        protected T editPlaceHolder;

        [Inject]
        protected IMapper Mapper { get; set; }

        [Inject]
        protected IMatToaster Toaster { get; set; }

        public ICollection<T> TableItems { get; set; }

        public bool IsEditRowDialogOpen { get; set; }

        public bool IsDeleteRowDialogOpen { get; set; }

        public T SelectedRowItemForEdit { get; set; }

        public string DialogTitle { get; set; }

        public virtual void OpenEditDialog(T rowItem)
        {
            if (rowItem == null)
            {
                this.Toaster.Add("Не съществува такава роля!", MatToastType.Danger);
            }

            this.SelectedRowItemForEdit = rowItem;
            this.DialogTitle = "Редакция";
            this.IsEditRowDialogOpen = true;
        }

        public virtual async Task ConfirmDeleteRowAsync()
        {
            this.IsDeleteRowDialogOpen = false;
            this.Toaster.Add("Успешно изтрит запис!", MatToastType.Success);
            this.TableItems.Remove(this.SelectedRowItemForEdit);
            this.SelectedRowItemForEdit = this.editPlaceHolder;
        }

        public virtual async Task DeleteRowAsync(T rowItem)
        {
            this.SelectedRowItemForEdit = rowItem;
            this.IsDeleteRowDialogOpen = true;
        }

        public virtual async Task SaveRowAsync()
        {
            this.Toaster.Add("Успешен запис!", MatToastType.Success);
            this.IsEditRowDialogOpen = false;
        }

        public virtual async Task CancelRowEditAsync()
        {
            this.Toaster.Add("Отказ от запазване!\nВръщане на предишните данни.", MatToastType.Info);
            this.SelectedRowItemForEdit = this.editPlaceHolder;
            this.IsEditRowDialogOpen = false;
        }

        public virtual void AddNewRow()
        {
            this.TableItems.Add(this.SelectedRowItemForEdit);
            this.OpenEditDialog(this.SelectedRowItemForEdit);
            this.DialogTitle = "Създаване";
        }
    }
}
