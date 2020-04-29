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
    public class CustomersOverviewBase : OverviewBase<CustomerDto>
    {
        [Inject]
        private ICustomerService CustomerService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            this.SelectedRowItemForEdit =  this.editPlaceHolder = NomenclaturesFactory.GetEmptyCustomerDto();
            this.TableItems = await this.CustomerService.GetAllAsync();
        }

        public override void AddNewRow()
        {
            this.SelectedRowItemForEdit = NomenclaturesFactory.GetEmptyCustomerDto();
            base.AddNewRow();
        }

        public override async Task ConfirmDeleteRowAsync()
        {
            await this.CustomerService.DeleteAsync(this.SelectedRowItemForEdit.CustomerId);
            await base.ConfirmDeleteRowAsync();
        }

        public override async Task CancelRowEditAsync()
        {
            if (this.SelectedRowItemForEdit.CustomerId <= 0)
            {
                this.TableItems.Remove(this.SelectedRowItemForEdit);
            }
            else
            {
                var oldItem = await this.CustomerService.GetAsync(this.SelectedRowItemForEdit.CustomerId);
                this.Mapper.Map(oldItem, this.SelectedRowItemForEdit);
            }

            await base.CancelRowEditAsync();
        }

        public override async Task SaveRowAsync()
        {
            if (this.SelectedRowItemForEdit == null)
            {
                this.Toaster.Add("Не е избран клиент!", MatToastType.Warning);
                return;
            }

            var newItem = await this.CustomerService.AddOrUpdateAsync(this.SelectedRowItemForEdit);
            this.Mapper.Map(newItem, this.SelectedRowItemForEdit);
            await base.SaveRowAsync();
        }
    }
}
