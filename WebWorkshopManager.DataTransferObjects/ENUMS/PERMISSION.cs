using System;
using System.ComponentModel.DataAnnotations;

namespace WebWorkshopManager.Shared.ENUMS
{
    [Flags]
    public enum PERMISSION
    {
        NONE = 0,

        [Display(Name = "Управление на потребители")]
        MANAGE_USERS = 2, // 2^1

        [Display(Name = "Управлява задачи")]
        MANAGE_JOBS = 4, // 2^2

        [Display(Name = "Управлява роли")]
        MANAGE_ROLES = 8, // 2^3

        [Display(Name = "Управлява клиенти")]
        MANAGE_CUSTOMERS = 16, // 2^4

        [Display(Name = "Управлява коли")]
        MANAGE_CAR = 32, // 2^5

        [Display(Name = "Работи по задачи")]
        WORK_ON_JOBS = 64, // 2^6

        [Display(Name = "Създава задачи")]
        CREATES_JOB_ITEMS = 128, // 2^7
    }
}
