using WebWorkshopManager.Shared.ENUMS;

namespace WebWorkshopManager.Web.Pages
{
    public class LaboursOverviewBase : ProductsOverviewBase
    {
        protected override PRODUCT_TYPE ProductType => PRODUCT_TYPE.LABOUR;
    }
}
