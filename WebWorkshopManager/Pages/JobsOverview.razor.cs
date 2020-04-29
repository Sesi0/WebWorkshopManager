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
using WebWorkshopManager.Web.Shared;

namespace WebWorkshopManager.Web.Pages
{
    public class JobsOverviewBase : OverviewBase<JobDto>
    {
        [Inject]
        private IJobService JobService { get; set; }

        [Inject]
        private ICarService CarService { get; set; }

        [Inject]
        private ICustomerService CustomerService { get; set; }

        [Inject]
        private IUserService UserService { get; set; }

        protected IReadOnlyList<CustomerDto> Customers { get; set; }
        protected IReadOnlyList<CarDto> Cars { get; set; }
        protected IReadOnlyList<UserDto> Workers { get; set; }

        protected IReadOnlyList<JOB_STATUS> Statuses { get; set; }

        protected override async Task OnInitializedAsync()
        {
            this.SelectedRowItemForEdit = this.editPlaceHolder = NomenclaturesFactory.GetEmptyJobDto();
            this.Customers = (IReadOnlyList<CustomerDto>)await this.CustomerService.GetAllAsync();
            this.Cars = (IReadOnlyList<CarDto>)await this.CarService.GetAllAsync();
            this.Workers = (IReadOnlyList<UserDto>)await this.UserService.GetAllAsync();
            this.Statuses = (IReadOnlyList<JOB_STATUS>)EnumHelper.GetEnumValues<JOB_STATUS>();
            this.TableItems = await this.JobService.GetAllAsync();
        }

        public override void AddNewRow()
        {
            this.SelectedRowItemForEdit = NomenclaturesFactory.GetEmptyJobDto();
            base.AddNewRow();
        }

        public override async Task ConfirmDeleteRowAsync()
        {
            await this.JobService.DeleteAsync(this.SelectedRowItemForEdit.JobId);
            await base.ConfirmDeleteRowAsync();
        }

        public override async Task CancelRowEditAsync()
        {
            if (this.SelectedRowItemForEdit.JobId <= 0)
            {
                this.TableItems.Remove(this.SelectedRowItemForEdit);
            }
            else
            {
                var oldItem = await this.JobService.GetAsync(this.SelectedRowItemForEdit.JobId);
                this.Mapper.Map(oldItem, this.SelectedRowItemForEdit);
            }

            await base.CancelRowEditAsync();
        }

        public override async Task SaveRowAsync()
        {
            if (this.SelectedRowItemForEdit == null)
            {
                this.Toaster.Add("Не е избрана работа!", MatToastType.Warning);
                return;
            }

            var newItem = await this.JobService.AddOrUpdateAsync(this.SelectedRowItemForEdit);
            this.Mapper.Map(newItem, this.SelectedRowItemForEdit);
            await base.SaveRowAsync();
        }
    }
}
