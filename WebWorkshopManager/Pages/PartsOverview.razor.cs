using WebWorkshopManager.Shared.ENUMS;

namespace WebWorkshopManager.Web.Pages
{
    public class PartsOverviewBase : ProductsOverviewBase
    {
        protected override PRODUCT_TYPE ProductType => PRODUCT_TYPE.PART;
    }
}
