using System.ComponentModel.DataAnnotations;

namespace WebWorkshopManager.Shared.ENUMS
{
    public enum JOB_STATUS
    {
        NONE = 0,

        [Display(Name = "Резервиран")]
        RESERVED = 1,

        [Display(Name = "Работи се")]
        WORKING = 2,

        [Display(Name = "Завършен")]
        DONE = 3
    }
}
