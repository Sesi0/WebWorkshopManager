using System.ComponentModel.DataAnnotations;

namespace WebWorkshopManager.Shared.ENUMS
{
    public enum PRODUCT_TYPE
    {
        [Display(Name = "Продукт")]
        PRODUCT = 1,

        [Display(Name = "Част")]
        PART = 2,

        [Display(Name = "Услуга")]
        SERVICE = 3,

        [Display(Name = "Труд")]
        LABOUR = 4,
    }
}
