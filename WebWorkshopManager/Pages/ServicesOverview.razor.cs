using WebWorkshopManager.Shared.ENUMS;

namespace WebWorkshopManager.Web.Pages
{
    public class ServicesOverviewBase : ProductsOverviewBase
    {
        protected override PRODUCT_TYPE ProductType => PRODUCT_TYPE.SERVICE;
    }
}
