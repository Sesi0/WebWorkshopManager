using System.ComponentModel.DataAnnotations;

namespace WebWorkshopManager.Shared.ENUMS
{
    public enum FUEL_TYPE
    {
        NONE = 0,

        [Display(Name = "Бензинов")]
        GASOLINE = 1,

        [Display(Name = "Дизелов")]
        DIESEL = 2,

        [Display(Name = "Електрически")]
        ELECTRIC = 3,

        [Display(Name = "Хибриден")]
        HYBRID = 4,
    }
}
