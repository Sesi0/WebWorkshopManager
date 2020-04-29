namespace WebWorkshopManager.Core.ENUMS
{
    public enum PERMISSION
    {
        NONE = 0,
        MANAGE_USERS = 2, // 2^1
        MANAGE_CONTRAGENTS = 4, // 2^2
        MANAGE_ROLES = 8, // 2^3
        MANAGE_CUSTOMERS = 16, // 2^4
        MANAGE_VEHICLES = 32 // 2^5
    }
}
