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
    public class CarsOverviewBase : OverviewBase<CarDto>
    {
        [Inject]
        private ICarService CarService { get; set; }

        protected IReadOnlyList<EngineDto> Engines { get; set; }

        protected override async Task OnInitializedAsync()
        {
            this.SelectedRowItemForEdit =  this.editPlaceHolder = NomenclaturesFactory.GetEmptyCarDto();
            this.Engines = (IReadOnlyList<EngineDto>) await this.CarService.GetAllEnginesAsync();
            this.TableItems = await this.CarService.GetAllAsync();
        }

        public override void AddNewRow()
        {
            this.SelectedRowItemForEdit = NomenclaturesFactory.GetEmptyCarDto();
            base.AddNewRow();
        }

        public override async Task ConfirmDeleteRowAsync()
        {
            await this.CarService.DeleteAsync(this.SelectedRowItemForEdit.CarId);
            await base.ConfirmDeleteRowAsync();
        }

        public override async Task CancelRowEditAsync()
        {
            if (this.SelectedRowItemForEdit.CarId <= 0)
            {
                this.TableItems.Remove(this.SelectedRowItemForEdit);
            }
            else
            {
                var oldItem = await this.CarService.GetAsync(this.SelectedRowItemForEdit.CarId);
                this.Mapper.Map(oldItem, this.SelectedRowItemForEdit);
            }

            await base.CancelRowEditAsync();
        }

        public override async Task SaveRowAsync()
        {
            if (this.SelectedRowItemForEdit == null)
            {
                this.Toaster.Add("Не е избран автомобил!", MatToastType.Warning);
                return;
            }

            var newItem = await this.CarService.AddOrUpdateAsync(this.SelectedRowItemForEdit);
            this.Mapper.Map(newItem, this.SelectedRowItemForEdit);
            await base.SaveRowAsync();
        }
    }
}
