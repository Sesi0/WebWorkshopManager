using System;
using System.Threading.Tasks;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using WebWorkshopManager.Services.Contracts;
using WebWorkshopManager.Shared.ENUMS;
using WebWorkshopManager.Shared.Models;
using WebWorkshopManager.Web.Base;
using WebWorkshopManager.Web.Shared;

namespace WebWorkshopManager.Web.Pages
{
    public class ProductsOverviewBase : OverviewBase<ProductDto>
    {
        [Inject]
        private IProductService ProductService { get; set; }

        protected virtual PRODUCT_TYPE ProductType => PRODUCT_TYPE.PRODUCT;

        protected override async Task OnInitializedAsync()
        {
            this.editPlaceHolder = NomenclaturesFactory.GetEmptyProductDto(this.ProductType);
            this.SelectedRowItemForEdit = this.editPlaceHolder;
            this.TableItems = await this.ProductService.GetAllAsync(this.ProductType);
        }

        public override void AddNewRow()
        {
            this.SelectedRowItemForEdit = NomenclaturesFactory.GetEmptyProductDto(this.ProductType);
            base.AddNewRow();
        }

        public override async Task ConfirmDeleteRowAsync()
        {
            await this.ProductService.DeleteAsync(this.SelectedRowItemForEdit.ProductId);
            await base.ConfirmDeleteRowAsync();
        }

        public override async Task CancelRowEditAsync()
        {
            if (this.SelectedRowItemForEdit.ProductId <= 0)
            {
                this.TableItems.Remove(this.SelectedRowItemForEdit);
            }
            else
            {
                var oldItem = await this.ProductService.GetAsync(this.SelectedRowItemForEdit.ProductId);
                this.Mapper.Map(oldItem, this.SelectedRowItemForEdit);
            }

            await base.CancelRowEditAsync();
        }

        public override async Task SaveRowAsync()
        {
            if (this.SelectedRowItemForEdit == null)
            {
                string message = string.Empty;
                switch (this.ProductType)
                {
                    case PRODUCT_TYPE.PRODUCT:
                        message = "Не е избран продукт!";
                        break;
                    case PRODUCT_TYPE.PART:
                        message = "Не е избрана част!";
                        break;
                    case PRODUCT_TYPE.SERVICE:
                        message = "Не е избрана услуга!";
                        break;
                    case PRODUCT_TYPE.LABOUR:
                        message = "Не е избран труд!";
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                this.Toaster.Add(message, MatToastType.Warning);
                return;
            }

            var newItem = await this.ProductService.AddOrUpdateAsync(this.SelectedRowItemForEdit);
            this.Mapper.Map(newItem, this.SelectedRowItemForEdit);
            await base.SaveRowAsync();
        }
    }
}
