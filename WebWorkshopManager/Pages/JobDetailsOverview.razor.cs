using System.Collections.Generic;
using System.Threading.Tasks;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using WebWorkshopManager.Services.Contracts;
using WebWorkshopManager.Shared.Models;
using WebWorkshopManager.Web.Base;
using WebWorkshopManager.Web.Shared;

namespace WebWorkshopManager.Web.Pages
{
    public class JobDetailsOverviewBase : OverviewBase<JobItemDto>
    {
        [Inject]
        private IJobService JobService { get; set; }

        [Inject]
        private IProductService ProductService { get; set; }

        protected IReadOnlyList<ProductDto> Products { get; set; }
 
        protected JobDto Job { get; private set; } 

        [Parameter]
        public int Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            this.SelectedRowItemForEdit = this.editPlaceHolder = NomenclaturesFactory.GetEmptyJobItemDto();
            this.Job = await this.JobService.GetAsync(this.Id);
            this.TableItems = await this.JobService.GetAllItemsAsync(this.Id);
            this.Products = (IReadOnlyList<ProductDto>) await this.ProductService.GetAllAsync();
        }

        public override void AddNewRow()
        {
            this.SelectedRowItemForEdit = NomenclaturesFactory.GetEmptyJobItemDto();
            base.AddNewRow();
        }

        public override async Task ConfirmDeleteRowAsync()
        {
            await this.JobService.DeleteItemAsync(this.SelectedRowItemForEdit.JobItemId);
            await base.ConfirmDeleteRowAsync();
        }

        public override async Task CancelRowEditAsync()
        {
            if (this.SelectedRowItemForEdit.JobItemId <= 0)
            {
                this.TableItems.Remove(this.SelectedRowItemForEdit);
            }
            else
            {
                var oldItem = await this.JobService.GetAsync(this.SelectedRowItemForEdit.JobItemId);
                this.Mapper.Map(oldItem, this.SelectedRowItemForEdit);
            }

            await base.CancelRowEditAsync();
        }

        public override async Task SaveRowAsync()
        {
            if (this.SelectedRowItemForEdit == null)
            {
                this.Toaster.Add("Не е избран продукт!", MatToastType.Warning);
                return;
            }

            this.SelectedRowItemForEdit.JobId = this.Id;
            var newItem = await this.JobService.AddOrUpdateItemAsync(this.SelectedRowItemForEdit);
            this.Mapper.Map(newItem, this.SelectedRowItemForEdit);
            await base.SaveRowAsync();
        }
    }
}
